from struct import unpack, unpack_from
import sys
import xml.etree.ElementTree as XmlTree
from hkReflection import *

file       = sys.argv[1]
output      = sys.argv[2]
memoffset  = int(sys.argv[3], 16)
memrangesArg  = sys.argv[4]
platform   = sys.argv[5]

endianness  = '<' if platform == "ps4" or platform == "xboxone" or platform == "ios64" or platform == "ios32" else '>'
pointerSize = 8 if platform == "ps4" or platform == "xboxone" or platform == "ios64" else 4

class MemRange:
	def __init__(self, memstart: int, filestart: int, size: int):
		self.memstart = memstart
		self.memend = memstart + size
		self.filestart = filestart

memranges: list[MemRange] = []
memrangesSplit = memrangesArg.split(',')
for memrange in memrangesSplit:
	parts = memrange.split('-')
	memranges.append(MemRange(int(parts[0], 16), int(parts[1], 16), int(parts[2], 16)))

memfile = open(file, "rb")

def mapAddress(address: int) -> int:
	for memrange in memranges:
		if memrange.memstart <= address and memrange.memend > address:
			#print("address " + str(hex(address)) + " to " + str(hex(memrange.filestart + address - memrange.memstart)))
			return memrange.filestart + address - memrange.memstart
	raise LookupError("Failed to map address " + str(hex(address)) + " to a range")

class Vector4:
	def __init__(self, x = 0.0, y = 0.0, z = 0.0, w = 0.0):
		self.x = x
		self.y = y
		self.z = z
		self.w = w
	def __str__(self):
		return str(self.x) + "," + str(self.y) + "," + str(self.z) + "," + str(self.w)

class Matrix3x4:
	def __init__(self, m11 = 1.0, m12 = 0.0, m13 = 0.0, m14 = 0.0, m21 = 0.0, m22 = 1.0, m23 = 0.0, m24 = 0.0, m31 = 0.0, m32 = 0.0, m33 = 1.0, m34 = 0.0):
		self.m11 = m11
		self.m12 = m12
		self.m13 = m13
		self.m14 = m14
		self.m21 = m21
		self.m22 = m22
		self.m23 = m23
		self.m24 = m24
		self.m31 = m31
		self.m32 = m32
		self.m33 = m33
		self.m34 = m34
	def __str__(self):
		return str(self.m11) + "," + str(self.m12) + "," + str(self.m13) + "," + str(self.m14) + "," + str(self.m21) + "," + str(self.m22) + "," + str(self.m23) + "," + str(self.m24) + "," + str(self.m31) + "," + str(self.m32) + "," + str(self.m33) + "," + str(self.m34)

class Matrix4x4:
	def __init__(self, m11 = 1.0, m12 = 0.0, m13 = 0.0, m14 = 0.0, m21 = 0.0, m22 = 1.0, m23 = 0.0, m24 = 0.0, m31 = 0.0, m32 = 0.0, m33 = 1.0, m34 = 0.0, m41 = 0.0, m42 = 0.0, m43 = 0.0, m44 = 1.0):
		self.m11 = m11
		self.m12 = m12
		self.m13 = m13
		self.m14 = m14
		self.m21 = m21
		self.m22 = m22
		self.m23 = m23
		self.m24 = m24
		self.m31 = m31
		self.m32 = m32
		self.m33 = m33
		self.m34 = m34
		self.m41 = m41
		self.m42 = m42
		self.m43 = m43
		self.m44 = m44
	def __str__(self):
		return str(self.m11) + "," + str(self.m12) + "," + str(self.m13) + "," + str(self.m14) + "," + str(self.m21) + "," + str(self.m22) + "," + str(self.m23) + "," + str(self.m24) + "," + str(self.m31) + "," + str(self.m32) + "," + str(self.m33) + "," + str(self.m34) + "," + str(self.m41) + "," + str(self.m42) + "," + str(self.m43) + "," + str(self.m44)


def readData(address: int, size: int, char: str):
	memfile.seek(mapAddress(address))
	data = memfile.read(size)
	if len(data) == 0:
		print("ran out of data at addr " + str(hex(address)))
	return unpack(endianness + char, data)[0]
def readUBytes(address, len) -> bytes:
	memfile.seek(mapAddress(address))
	return memfile.read(len)

def readInt(address) -> int:
	return readData(address, 4, 'i')
def readUInt(address) -> int:
	return readData(address, 4, 'I')
def readLong(address) -> int:
	return readData(address, 8, 'l')
def readULong(address) -> int:
	return readData(address, 8, 'L')
def readSByte(address) -> int:
	return readData(address, 1, 'b')
def readUByte(address) -> int:
	return readData(address, 1, 'B')
def readShort(address) -> int:
	return readData(address, 2, 'h')
def readUShort(address) -> int:
	return readData(address, 2, 'H')
def readFloat(address) -> float:
	return readData(address, 4, 'f')
def readPointer(address) -> int:
	if pointerSize == 8:
		return readULong(address)
	else:
		return readUInt(address)
def readStringPtr(address) -> str:
	strptr = readPointer(address)
	if strptr == 0:
		return None
	return readString(strptr)
def readString(address) -> str:
	theStr = str()
	i = 0
	while True:
		curchar = readUByte(address + i)
		if curchar == 0:
			break
		theStr += bytes([curchar]).decode("ascii")
		i += 1
	return theStr


def lookupHkClass(address) -> hkClass:
	if address == 0:
		return None
	
	if address in hkClassDict:
		return hkClassDict[address]
	else:
		clazz = hkClass()
		hkClassDict[address] = clazz
		return clazz
def lookupHkClassEnum(address) -> hkClassEnum:
	if address == 0:
		return None
	
	if address in hkEnumDict:
		return hkEnumDict[address]
	else:
		clazz = hkClassEnum()
		hkEnumDict[address] = clazz
		return clazz
hkClassDict: dict[int, hkClass] = {}
hkEnumDict: dict[int, hkClassEnum] = {}

def readAttributeValue(address: int) -> dict[str, any]:
	valuePtr = readPointer(address)
	clazz = readHkClass(readPointer(address + pointerSize))
	items: dict[str, any] = {}
	for member in clazz.declaredMembers:
		items[member.name] = readMemberValue(valuePtr + member.offset, member.type, member.subtype)

	return items

def readAttributes(address: int) -> list[hkCustomAttributeAttribute]:
	if address == 0:
		return None

	attributesPtr = readPointer(address)
	numAttributes = readUInt(address + pointerSize)

	attributes = []
	for i in range(numAttributes):
		attr = hkCustomAttributeAttribute()
		attr.name = readStringPtr(attributesPtr + 0)
		attr.value = readAttributeValue(attributesPtr + pointerSize)
		attr.clazz = lookupHkClass(readPointer(attributesPtr + pointerSize * 2))
		attributes.append(attr)
	return attributes

def readHkEnum(address: int) -> hkClassEnum:
	if address == 0:
		return None

	enum = lookupHkClassEnum(address)
	if enum.populated:
		return enum
	enum.populated = True

	enum.name = readStringPtr(address)
	address += pointerSize
	itemsPtr = readPointer(address)
	address += pointerSize
	itemsCount = readInt(address)
	address += pointerSize # add pointer size for alignment on 64 bit platforms

	for i in range(itemsCount):
		item = hkClassEnumItem()
		item.value = readUInt(     itemsPtr + i * pointerSize * 2)
		item.name  = readStringPtr(itemsPtr + i * pointerSize * 2 + pointerSize)
		enum.items.append(item)

	enum.attributes = readAttributes(readPointer(address))
	address += pointerSize
	enum.flags = hkClassEnumFlagValues(readUInt(address))

	if enum.name == "WeldingType":
		hkpWeldingUtilityClass = lookupHkClass(0x000BA115) # balls
		hkpWeldingUtilityClass.populated = True
		hkpWeldingUtilityClass.name = "hkpWeldingUtility"
		hkpWeldingUtilityClass.objectSize = 1
		hkpWeldingUtilityClass.declaredEnums.append(enum)
		enum.clazz = hkpWeldingUtilityClass

	return enum

def readMemberValue(address: int, type: hkClassMemberType, subtype: hkClassMemberType) -> any:
	match type:
		case hkClassMemberType.TYPE_BOOL:
			return readUByte(address) != 0
		case hkClassMemberType.TYPE_CHAR:
			return bytes([readUByte(address)]).decode("ascii")
		case hkClassMemberType.TYPE_INT8:
			return readSByte(address)
		case hkClassMemberType.TYPE_UINT8:
			return readUByte(address)
		case hkClassMemberType.TYPE_INT16:
			return readShort(address)
		case hkClassMemberType.TYPE_UINT16:
			return readUShort(address)
		case hkClassMemberType.TYPE_INT32:
			return readInt(address)
		case hkClassMemberType.TYPE_UINT32:
			return readUInt(address)
		case hkClassMemberType.TYPE_INT64:
			return readLong(address)
		case hkClassMemberType.TYPE_UINT64:
			return readULong(address)
		case hkClassMemberType.TYPE_REAL:
			return readFloat(address)
		case hkClassMemberType.TYPE_VECTOR4:
			return Vector4(readFloat(address), readFloat(address+4), readFloat(address+8), readFloat(address+12))
		case hkClassMemberType.TYPE_QUATERNION:
			return Vector4(readFloat(address), readFloat(address+4), readFloat(address+8), readFloat(address+12))
		case hkClassMemberType.TYPE_MATRIX3:
			return Matrix3x4(readFloat(address), readFloat(address+4), readFloat(address+8), readFloat(address+12), readFloat(address+16), readFloat(address+20), readFloat(address+24), readFloat(address+28), readFloat(address+32), readFloat(address+36), readFloat(address+40), readFloat(address+44))
		case hkClassMemberType.TYPE_MATRIX4:
			return Matrix4x4(readFloat(address), readFloat(address+4), readFloat(address+8), readFloat(address+12), readFloat(address+16), readFloat(address+20), readFloat(address+24), readFloat(address+28), readFloat(address+32), readFloat(address+36), readFloat(address+40), readFloat(address+44), readFloat(address+48), readFloat(address+52), readFloat(address+56), readFloat(address+60))
		case hkClassMemberType.TYPE_QSTRANSFORM:
			return Matrix3x4(readFloat(address), readFloat(address+4), readFloat(address+8), readFloat(address+12), readFloat(address+16), readFloat(address+20), readFloat(address+24), readFloat(address+28), readFloat(address+32), readFloat(address+36), readFloat(address+40), readFloat(address+44))
		case hkClassMemberType.TYPE_ENUM:
			return readMemberValue(address, subtype, hkClassMemberType.TYPE_VOID)
		case hkClassMemberType.TYPE_FLAGS:
			return readMemberValue(address, subtype, hkClassMemberType.TYPE_VOID)
		case hkClassMemberType.TYPE_CSTRING:
			return readStringPtr(address)
		case hkClassMemberType.TYPE_STRINGPTR:
			return readStringPtr(address)
		case hkClassMemberType.TYPE_POINTER:
			match subtype:
				case hkClassMemberType.TYPE_VOID:
					return None
				case _:
					NotImplementedError(type.name + " (subtype " + subtype.name + ")" + " unimplemented at address " + str(hex(address)) + " (" + str(hex(mapAddress(address))) + ")")
		case _:
			raise NotImplementedError(type.name + " (subtype " + subtype.name + ")" + " unimplemented at address " + str(hex(address)) + " (" + str(hex(mapAddress(address))) + ")")

def readHkClass(address: int) -> hkClass:
	if address == 0:
		return None

	clazz = lookupHkClass(address)
	if clazz.populated:
		return clazz
	clazz.populated = True

	readHead = address

	clazz.name = readStringPtr(readHead)
	readHead += pointerSize

	clazz.parent = readHkClass(readPointer(readHead))
	readHead += pointerSize

	clazz.objectSize = readUInt(readHead)
	readHead += 4

	clazz.numImplementedInterfaces = readUInt(readHead)
	# the interfaces themselves aren't stored for some reason
	readHead += 4

	enumPtr = readPointer(readHead)
	readHead += pointerSize
	numEnums = readUInt(readHead)
	readHead += 4

	for i in range(numEnums):
		enum = readHkEnum(enumPtr + i * pointerSize * 5)
		enum.clazz = clazz
		clazz.declaredEnums.append(enum)
		


	memberPtr = readPointer(readHead)
	readHead += pointerSize
	numMembers = readUInt(readHead)
	readHead += 4

	for i in range(numMembers):
		member = hkClassMember()
		member.name = readStringPtr(memberPtr)
		memberPtr += pointerSize
		member.clazz = readHkClass(readPointer(memberPtr))
		memberPtr += pointerSize
		enumPtr = readPointer(memberPtr)
		member.enum = readHkEnum(enumPtr)
		memberPtr += pointerSize
		member.type = hkClassMemberType(readUByte(memberPtr))
		memberPtr += 1
		member.subtype = hkClassMemberType(readUByte(memberPtr))
		memberPtr += 1
		member.cArraySize = readUShort(memberPtr)
		memberPtr += 2
		member.flags = hkClassMemberFlagValues(readUShort(memberPtr))
		memberPtr += 2
		member.offset = readUShort(memberPtr)
		memberPtr += 2
		member.attributes = readAttributes(readPointer(memberPtr))
		memberPtr += pointerSize
		clazz.declaredMembers.append(member)

	defaultsPtr = readPointer(readHead)
	readHead += pointerSize
	clazz.attributes = readAttributes(readPointer(readHead))
	readHead += pointerSize
	clazz.flags = hkClassFlagValues(readUInt(readHead))
	readHead += 4
	clazz.describedVersion = readUInt(readHead)
	readHead += 4

	if defaultsPtr != 0:
		clazz.defaults = []
		for i in range(len(clazz.declaredMembers)):
			defaultOffset = readInt(defaultsPtr + i * 4)
			if defaultOffset < 0:
				clazz.defaults.append(None)
			else:
				clazz.defaults.append(readMemberValue(defaultsPtr + defaultOffset, clazz.declaredMembers[i].type, clazz.declaredMembers[i].subtype))

	return clazz

def outputXml() -> str:
	rootnode = XmlTree.Element("metadata")
	hkclassrootnode = XmlTree.SubElement(rootnode, "hkclasses")
	processedEnums = []
	for clazz in hkClassDict.values():
		hkclassnode = XmlTree.SubElement(hkclassrootnode, "hkclass")
		hkclassnode.attrib["objectSize"] = str(clazz.objectSize)
		hkclassnode.attrib["describedVersion"] = str(clazz.describedVersion)
		hkclassnode.attrib["numImplementedInterfaces"] = str(clazz.numImplementedInterfaces)

		outputXmlAttributes(hkclassnode, clazz.attributes)

		if clazz.name != None:
			hkclassnode.attrib["name"] = clazz.name
		if clazz.flags != 0:
			hkclassnode.attrib["flags"] = clazz.flags.name
		if clazz.parent != None:
			hkclassnode.attrib["parent"] = clazz.parent.name
		if len(clazz.declaredMembers) > 0:
			memberrootnode = XmlTree.SubElement(hkclassnode, "members")
			memberI = 0
			for member in clazz.declaredMembers:
				membernode = XmlTree.SubElement(memberrootnode, "member")
				membernode.attrib["type"]      = member.type.name
				membernode.attrib["subtype"]   = member.subtype.name
				membernode.attrib["arraysize"] = str(member.cArraySize)
				membernode.attrib["offset"]    = str(member.offset)
				if member.name != None:
					membernode.attrib["name"]  = member.name
				if member.flags != 0:
					membernode.attrib["flags"] = member.flags.name
				if member.clazz != None:
					membernode.attrib["class"] = member.clazz.name
				if clazz.defaults != None and clazz.defaults[memberI] != None:
					defaultStr = str(clazz.defaults[memberI])
					# grr python bools
					if member.type is bool:
						defaultStr = defaultStr.lower()
					membernode.attrib["default"] = defaultStr
				if member.enum != None:
					declaringClass = "$loose" if member.enum.clazz == None else member.enum.clazz.name
					membernode.attrib["enum"] = declaringClass + "." + member.enum.name
				memberI += 1
		if len(clazz.declaredEnums) > 0:
			enumrootnode = XmlTree.SubElement(hkclassnode, "enums")
			for enum in clazz.declaredEnums:
				outputXmlEnum(enumrootnode, processedEnums, enum)

	hklooseenumsrootnode = XmlTree.SubElement(rootnode, "hkenums")
	for enum in hkEnumDict.values():
		if enum in processedEnums:
			continue
		outputXmlEnum(hklooseenumsrootnode, processedEnums, enum)

	XmlTree.indent(rootnode, "\t")
	return XmlTree.tostring(rootnode, encoding="utf-8", method="xml").decode("utf-8")

def outputXmlEnum(parentnode: XmlTree.Element, processedEnumList: list[hkClassEnum], enum: hkClassEnum):
	if enum.populated == False:
		raise

	processedEnumList.append(enum)

	enumnode = XmlTree.SubElement(parentnode, "enum")
	enumnode.attrib["name"]  = enum.name

	if enum.flags != 0:
		enumnode.attrib["flags"] = enum.flags.name
	for enumItem in enum.items:
		itemnode = XmlTree.SubElement(enumnode, "item")
		itemnode.attrib["value"] = str(enumItem.value)
		itemnode.attrib["name"]  = enumItem.name

def outputXmlAttributes(parentnode: XmlTree.Element, attributes: list[hkCustomAttributeAttribute]):
	if attributes == None:
		return

	for attr in attributes:
		attrnode = XmlTree.SubElement(parentnode, "attribute")
		attrnode.attrib["name"] = attr.name
		attrnode.attrib["type"] = attr.clazz.name
		for key in attr.value.keys():
			valuenode = XmlTree.SubElement(attrnode, "value")
			valuenode.attrib["name"] = key
			valuenode.attrib["value"] = str(attr.value[key])

listReadHead = memoffset
while True:
	classPointer = readPointer(listReadHead)
	if classPointer == 0:
		break

	readHkClass(classPointer)

	listReadHead += pointerSize

oxml = open(output, "wt", newline="\n")
oxml.write(outputXml())
oxml.close()