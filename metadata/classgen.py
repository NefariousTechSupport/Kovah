from pathlib import Path
import sys
from typing import Optional, TextIO
from enum import IntFlag
import ctypes
import xml.etree.ElementTree as XmlTree
from hkReflection import hkClassMemberFlagValues, hkClassMemberType, hkClassFlagValues, hkClassEnumFlagValues

# we're using our own definitions to assist with deduplication
class hkClassEnumItem:
	def __init__(self):
		self.name = ""
		self.value: dict[str, int] = {}

class hkClassEnum:
	def __init__(self):
		self.name = ""
		# first level key is the member name
		# second level key is the version to get the value
		self.items: dict[str, dict[str, int]] = {}
		self.flags: dict[str, str] = {}

		# determined by context
		self.isFlags = False
		self.clazz: hkClass = None

class hkClassMember:
	def __init__(self):
		self.clazz: hkClass = None
		self.enum: hkClassEnum = None
		self.type = hkClassMemberType.TYPE_VOID
		self.subtype = hkClassMemberType.TYPE_VOID
		self.cArraySize = 0
		self.flags: str = "FLAGS_NONE"
		self.offset = 0

class hkClass:
	def __init__(self):
		self.name = ""
		self.versions: list[str] = []
		self.parents: set[hkClass] = set()
		self.bestParent: hkClass = None
		self.bestParentSet: bool = False
		self.numImplementedInterfaces: dict[str, int] = {}
		self.declaredEnums: list[hkClassEnum] = []
		# first level key is the member name
		# second level key is the version
		self.declaredMembers: dict[str, dict[str, hkClassMember]] = {}
		self.flags: dict[str, str] = {}
		self.describedVersion: dict[str, int] = {}

classes: dict[str, hkClass] = {}
enums:   dict[str, hkClass] = {}

def main():
	outputDir = sys.argv[1]
	inputs = sys.argv[2:]

	for input in inputs:
		readHavokXml(input)

	outputCS(outputDir)

def readHavokXml(input: str):
	document = XmlTree.parse(input)
	# Havok-7.1.0-r1.metadata.xml -> Havok-7.1.0-r1 -> Havok_7_1_0_r1
	version = mangleVersion(Path(Path(input).stem).stem)
	rootnode = document.getroot()
	for node in rootnode:
		if node.tag == "hkclasses":
			for classnode in node:
				readHkClass(version, classnode)
		if node.tag == "hkenums":
			for enumnode in node:
				readHkEnum(version, None, enumnode)

def mangleVersion(version: str) -> str:
	return version.replace("-", "_").replace(".", "_")

def findHkClass(name: str) -> hkClass:
	if name in classes:
		return classes[name]
	else:
		clazz = hkClass()
		clazz.name = name
		classes[name] = clazz
		return clazz

def findHkEnum(name: str) -> hkClassEnum:
	if name in enums:
		return enums[name]
	else:
		print (name)
		parts = name.split(".")
		enum = hkClassEnum()
		enum.name = parts[1]
		if parts[0] != "$loose":
			enum.clazz = findHkClass(parts[0])
			enum.clazz.declaredEnums.append(enum)
		enums[name] = enum
		return enum

def getHkEnumIdentifier(enum: hkClassEnum) -> str:
	className = enum.clazz.name + "." if enum.clazz != None else ""
	return className + enum.name

def readHkClass(version: str, classnode: XmlTree.Element) -> hkClass:
	if "name" in classnode.attrib:
		clazz = findHkClass(classnode.attrib["name"])
	else:
		raise

	clazz.versions.append(version)

	if "flags" in classnode.attrib:
		clazz.flags[version] = classnode.attrib["flags"]
	if "parent" in classnode.attrib:
		clazz.parents.add(findHkClass(classnode.attrib["parent"]))

	#clazz.objectSize = int(classnode.attrib["objectSize"])
	clazz.describedVersion[version] = int(classnode.attrib["describedVersion"])
	clazz.numImplementedInterfaces[version] = int(classnode.attrib["numImplementedInterfaces"])

	for node in classnode:
		if node.tag == "members":
			for membernode in node:
				readHkMember(version, clazz, membernode)
		elif node.tag == "enums":
			for enumnode in node:
				readHkEnum(version, clazz, enumnode)
				

	return clazz

def readHkMember(version: str, clazz: hkClass, membernode: XmlTree.Element) -> hkClassMember:
	if "name" in membernode.attrib:
		memberName = membernode.attrib["name"]
		if memberName in clazz.declaredMembers:
			versionInfo = clazz.declaredMembers[memberName]
		else:
			versionInfo: dict[str, hkClassMember] = {}
			clazz.declaredMembers[memberName] = versionInfo

		member = hkClassMember()
		versionInfo[version] = member
	else:
		raise Exception("no name for certain member in class {}".format(clazz.name))

	if "flags" in membernode.attrib:
		member.flags = membernode.attrib["flags"]
	if "class" in membernode.attrib:
		member.clazz = findHkClass(membernode.attrib["class"])
	if "enum" in membernode.attrib:
		member.enum = findHkEnum(membernode.attrib["enum"])

	member.type = hkClassMemberType[membernode.attrib["type"]]
	member.subtype = hkClassMemberType[membernode.attrib["subtype"]]
	member.cArraySize = int(membernode.attrib["arraysize"])
	member.offset = int(membernode.attrib["offset"])

	if member.type == hkClassMemberType.TYPE_FLAGS and member.enum != None:
		member.enum.isFlags = True
	return member

def readHkEnum(version: str, clazz: hkClass, enumnode: XmlTree.Element) -> hkClassEnum:
	className = clazz.name if clazz != None else "$loose"
	enum = findHkEnum(className + "." + enumnode.attrib["name"])
	for itemnode in enumnode:
		itemName = itemnode.attrib["name"]
		if itemName in enum.items:
			versionInfo = enum.items[itemName]
		else:
			versionInfo: dict[str, int] = {}
			enum.items[itemName] = versionInfo

		item = int(itemnode.attrib["value"])
		versionInfo[version] = item
	return enum

def isAssignableTo(clazz1: hkClass, clazz2: hkClass) -> bool:
	tester = clazz1
	while tester != None:
		print("checking if {} = {} is possible".format(clazz2.name, tester.name))
		if tester == clazz2:
			return True
		if not tester.bestParentSet:
			resolveParent(tester)
		tester = tester.bestParent

	return False

def resolveParent(clazz: hkClass) -> hkClass:
	if clazz.bestParentSet:
		return clazz.bestParent
	bestOne = None
	for parent in clazz.parents:
		if bestOne == None:
			bestOne = parent
			continue

		# if the parent can be assigned to the best one then change the best one, else error
		print("checking best {} vs iter {}".format(bestOne.name, parent.name))
		bestAssignableToParent = isAssignableTo(bestOne, parent)
		print("checking iter {} vs best {}".format(parent.name, bestOne.name))
		parentAssignableToBest = isAssignableTo(parent, bestOne)
		if       bestAssignableToParent and     parentAssignableToBest:
			continue
		elif not bestAssignableToParent and     parentAssignableToBest:
			bestOne = parent
		elif     bestAssignableToParent and not parentAssignableToBest:
			continue
		elif not bestAssignableToParent and not parentAssignableToBest:
			raise Exception("cannot resolve parent for class " + clazz.name)

	clazz.bestParentSet = True
	clazz.bestParent = bestOne
	return bestOne

def outputEnum(cs: TextIO, indentNum: int, enum: hkClassEnum):
	indent = '\t' * indentNum
	if enum.isFlags:
		cs.write(indent + "[Flags]\n")
	cs.write(indent + "public enum " + enum.name.removeprefix("$loose.") + " : int\n")
	cs.write(indent + "{\n")
	for itemName, versionInfo in enum.items.items():
		for version, value in versionInfo.items():
			cs.write(indent + "\t[HavokEnumItem(EVersion.{}, {})]\n".format(version, ctypes.c_int32(value).value))
		cs.write(indent + "\t{},\n".format(itemName))

	cs.write(indent + "\t\n")
	cs.write(indent + "}\n")

def outputCS(outputDir: str):
	for clazz in classes.values():
		cs = open(outputDir + "/" + clazz.name + ".cs", "wt", newline="\n")
		cs.write("namespace Kovah\n")
		cs.write("{\n")
		for version in clazz.versions:
			cs.write("\t[HavokClass(EVersion.{})]\n".format(version))
		parent = resolveParent(clazz)
		cs.write("\tpublic partial class " + clazz.name + ((" : " + parent.name) if parent != None else "") + "\n")
		cs.write("\t{\n")
		for enum in clazz.declaredEnums:
			outputEnum(cs, 2, enum)
		for memberName, versionInfo in clazz.declaredMembers.items():
			for version, member in versionInfo.items():
				memberclassname = "typeof({})".format(member.clazz.name) if member.clazz != None else "null"
				memberenumname  = "typeof({}{})".format(member.enum.clazz.name + "." if member.enum.clazz != None else "", member.enum.name) if member.enum != None else "null"
				cs.write("\t\t[HavokMember(EVersion.{}, {}, {}, {}, hkClassMember.Type.{}, hkClassMember.Type.{}, {}, {})]\n".format(version, member.offset, memberclassname, memberenumname, member.type.name, member.subtype.name, member.cArraySize, getCSFlagValues("hkClassMember.FlagValues.", member.flags)))
			cs.write("\t\tprivate {} {};\n".format(getCSType(member.type, member.subtype, member.clazz, member.enum), getCSName(memberName)))
		cs.write("\t}\n")
		cs.write("}\n")
		cs.close()

def getCSType(type: hkClassMemberType, subtype: hkClassMemberType, clazz: hkClass, enum: hkClassEnum) -> str:
	match type:
		case hkClassMemberType.TYPE_VOID:             return "object? /* void */"
		case hkClassMemberType.TYPE_BOOL:             return "bool"
		case hkClassMemberType.TYPE_CHAR:             return "char"
		case hkClassMemberType.TYPE_INT8:             return "sbyte"
		case hkClassMemberType.TYPE_UINT8:            return "byte"
		case hkClassMemberType.TYPE_INT16:            return "short"
		case hkClassMemberType.TYPE_UINT16:           return "ushort"
		case hkClassMemberType.TYPE_INT32:            return "int"
		case hkClassMemberType.TYPE_UINT32:           return "uint"
		case hkClassMemberType.TYPE_INT64:            return "long"
		case hkClassMemberType.TYPE_UINT64:           return "ulong"
		case hkClassMemberType.TYPE_REAL:             return "float"
		case hkClassMemberType.TYPE_VECTOR4:          return "Vector4"
		case hkClassMemberType.TYPE_QUATERNION:       return "Quaternion"
		case hkClassMemberType.TYPE_MATRIX3:          return "Matrix3x4"
		case hkClassMemberType.TYPE_ROTATION:         return "Quaternion /* rotation */"
		case hkClassMemberType.TYPE_QSTRANSFORM:      return "Matrix3x4"
		case hkClassMemberType.TYPE_MATRIX4:          return "Matrix4x4"
		case hkClassMemberType.TYPE_TRANSFORM:        return "Matrix4x4 /* transform */"
		case hkClassMemberType.TYPE_ZERO:             raise
		case hkClassMemberType.TYPE_POINTER:          return getCSType(subtype, hkClassMemberType.TYPE_VOID, clazz, enum)
		case hkClassMemberType.TYPE_FUNCTIONPOINTER:  raise
		case hkClassMemberType.TYPE_ARRAY:            return getCSType(subtype, hkClassMemberType.TYPE_VOID, clazz, enum) + "[]?"
		case hkClassMemberType.TYPE_INPLACEARRAY:     raise
		case hkClassMemberType.TYPE_ENUM:             return getHkEnumIdentifier(enum) if enum != None else getCSType(subtype, hkClassMemberType.TYPE_VOID, None, None)
		case hkClassMemberType.TYPE_STRUCT:           return clazz.name + "?"
		case hkClassMemberType.TYPE_SIMPLEARRAY:      return getCSType(subtype, hkClassMemberType.TYPE_VOID, clazz, enum) + "[]?"
		case hkClassMemberType.TYPE_HOMOGENEOUSARRAY: raise
		case hkClassMemberType.TYPE_VARIANT:          return "object? /* variant */"
		case hkClassMemberType.TYPE_CSTRING:          return "string?"
		case hkClassMemberType.TYPE_ULONG:            return "ulong"
		case hkClassMemberType.TYPE_FLAGS:            return getHkEnumIdentifier(enum) if enum != None else getCSType(subtype, hkClassMemberType.TYPE_VOID, None, None)
		case hkClassMemberType.TYPE_HALF:             return "Half"
		case hkClassMemberType.TYPE_STRINGPTR:        return "string?"
		case hkClassMemberType.TYPE_RELARRAY:         return "object? /* relarray */"

csKeywords: set[str] = {
	"string",
	"override",
	"internal",
	"event",
	"int",
	"object",
	"class",
	"enum",
	"operator",
}
def getCSName(name: str) -> str:
	if name in csKeywords:
		return "@" + name
	if name[0].isdigit():
		return "_" + name
	return name

def getCSFlagValues(enumName: str, flags: str) -> str:
	if flags != 0:
		output = ""
		for flag in flags.split("|"):
			output += enumName + flag + "|"
		return output.removesuffix("|")
	else:
		return enumName + "FLAGS_NONE"

main()
