from enum import IntFlag, Enum

class hkClassMemberFlagValues(IntFlag):
	FLAGS_NONE                  = 0,
	SIZE_8                      = (1 << 3)
	ENUM_8                      = (1 << 3)
	SIZE_16                     = (1 << 4)
	ENUM_16                     = (1 << 4)
	SIZE_32                     = (1 << 5)
	ENUM_32                     = (1 << 5)
	ALIGN_8                     = (1 << 7)
	ALIGN_16                    = (1 << 8)
	NOT_OWNED                   = (1 << 9)
	SERIALIZE_IGNORED           = (1 << 10)
	ALIGN_32                    = (1 << 11)
	ALIGN_REAL                  = ALIGN_16


class hkClassMemberType(Enum):
	TYPE_VOID                        = 0
	TYPE_BOOL                        = 1
	TYPE_CHAR                        = 2
	TYPE_INT8                        = 3
	TYPE_UINT8                       = 4
	TYPE_INT16                       = 5
	TYPE_UINT16                      = 6
	TYPE_INT32                       = 7
	TYPE_UINT32                      = 8
	TYPE_INT64                       = 9
	TYPE_UINT64                      = 10
	TYPE_REAL                        = 11
	TYPE_VECTOR4                     = 12
	TYPE_QUATERNION                  = 13
	TYPE_MATRIX3                     = 14
	TYPE_ROTATION                    = 15
	TYPE_QSTRANSFORM                 = 16
	TYPE_MATRIX4                     = 17
	TYPE_TRANSFORM                   = 18
	TYPE_ZERO                        = 19
	TYPE_POINTER                     = 20
	TYPE_FUNCTIONPOINTER             = 21
	TYPE_ARRAY                       = 22
	TYPE_INPLACEARRAY                = 23
	TYPE_ENUM                        = 24
	TYPE_STRUCT                      = 25
	TYPE_SIMPLEARRAY                 = 26
	TYPE_HOMOGENEOUSARRAY            = 27
	TYPE_VARIANT                     = 28
	TYPE_CSTRING                     = 29
	TYPE_ULONG                       = 30
	TYPE_FLAGS                       = 31
	TYPE_HALF                        = 32
	TYPE_STRINGPTR                   = 33
	TYPE_RELARRAY                    = 34
	TYPE_MAX                         = 35

class hkClassFlagValues(IntFlag):
	FLAGS_NONE                        = 0
	FLAGS_NOT_SERIALIZABLE            = (1 << 0)

class hkClassEnumFlagValues(IntFlag):
	FLAGS_NONE                        = 0

class hkCustomAttributeAttribute:
	def __init__(self):
		self.name = ""
		self.value: dict[str, any] = {}
		self.clazz: hkClass = None

class hkClassEnumItem:
	def __init__(self):
		self.value = 0
		self.name = ""

class hkClassEnum:
	def __init__(self):
		self.name = ""
		self.items: list[hkClassEnumItem] = []
		self.attributes: list[any] = None
		self.flags = hkClassEnumFlagValues.FLAGS_NONE


		self.clazz: hkClass = None
		self.populated = False

class hkClassMember:
	def __init__(self):
		self.name = ""
		self.clazz: hkClass = None
		self.enum: hkClassEnum = None
		self.type = hkClassMemberType.TYPE_VOID
		self.subtype = hkClassMemberType.TYPE_VOID
		self.cArraySize = 0
		self.flags = hkClassMemberFlagValues.FLAGS_NONE
		self.offset = 0
		self.attributes: list[any] = []

class hkClass:
	def __init__(self):
		self.name = ""
		self.parent: hkClass = None
		self.objectSize = 0
		self.numImplementedInterfaces = 0
		self.declaredEnums: list[hkClassEnum] = []
		self.declaredMembers: list[hkClassMember] = []
		self.defaults: list[any] = None
		self.attributes: list[any] = []
		self.flags = hkClassFlagValues.FLAGS_NONE
		self.describedVersion = 0

		self.populated = False

	def memberCount(self) -> int:
		count = 0
		classIter = self
		while classIter != None:
			count += len(classIter.declaredMembers)
			classIter = classIter.parent
		return count

	def getField(self, index: int) -> hkClassMember:
		fields: list[hkClassMember] = []
		classIter = self
		while classIter != None:
			fields = classIter.declaredMembers + fields
			classIter = classIter.parent

		if index < len(fields):
			return fields[index]
		else:
			return None