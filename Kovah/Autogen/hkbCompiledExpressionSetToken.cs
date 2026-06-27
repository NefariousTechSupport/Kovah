namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbCompiledExpressionSetToken
	{
		public enum TokenType
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			TOKEN_TYPE_NONE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			TOKEN_TYPE_OPERATOR,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			TOKEN_TYPE_NUMBER,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			TOKEN_TYPE_VARIABLE_INDEX,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			TOKEN_TYPE_OPENING_PAREN,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 5)]
			TOKEN_TYPE_CLOSING_PAREN,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 6)]
			TOKEN_TYPE_COMMA,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 7)]
			TOKEN_TYPE_CHARACTER_PROPERTY_INDEX,
			
		}
		public enum Operator
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			OP_NOP,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			OP_RAND01,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			OP_LOGICAL_NOT,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			OP_UNARY_MINUS,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			OP_UNARY_PLUS,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 5)]
			OP_SIN,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 6)]
			OP_COS,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 7)]
			OP_ASIN,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			OP_ACOS,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 9)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 9)]
			OP_SQRT,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 10)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 10)]
			OP_FABS,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 11)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 11)]
			OP_CEIL,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 12)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 12)]
			OP_FLOOR,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 13)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 13)]
			OP_SQRTINV,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 14)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 14)]
			OP_MUL,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 15)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 15)]
			OP_DIV,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 16)]
			OP_ADD,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 17)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 17)]
			OP_SUB,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 18)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 18)]
			OP_LOGICAL_OR,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 19)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 19)]
			OP_LOGICAL_AND,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 20)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 20)]
			OP_EQ,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 21)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 21)]
			OP_NEQ,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 22)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 22)]
			OP_LT,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 23)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 23)]
			OP_GT,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 24)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 24)]
			OP_LEQ,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 25)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 25)]
			OP_GEQ,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 26)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 26)]
			OP_POW,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 27)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 27)]
			OP_MAX2,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 28)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 28)]
			OP_MIN2,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 29)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 29)]
			OP_RANDRANGE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 30)]
			OP_ATAN2APPROX,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 31)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 31)]
			OP_CLAMP,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 32)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 32)]
			OP_MOD,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 33)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 33)]
			OP_DEG2RAD,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 34)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 34)]
			OP_RAD2DEG,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 35)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 35)]
			OP_COSD,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 36)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 36)]
			OP_SIND,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 37)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 37)]
			OP_ACOSD,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 38)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 38)]
			OP_ASIND,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 39)]
			OP_ATAN2APPROXD,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 40)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 40)]
			OP_SIGN,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 41)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 41)]
			OP_LERP,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 42)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 42)]
			OP_CLERP,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 43)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 43)]
			OP_COND,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 30)]
			OP_ATAN2,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 39)]
			OP_ATAN2D,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float data;
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, null, typeof(hkbCompiledExpressionSetToken.TokenType), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, null, typeof(hkbCompiledExpressionSetToken.TokenType), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbCompiledExpressionSetToken.TokenType type;
		[HavokMember(EVersion.hk_2012_1_0_r1, 5, null, typeof(hkbCompiledExpressionSetToken.Operator), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 5, null, typeof(hkbCompiledExpressionSetToken.Operator), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbCompiledExpressionSetToken.Operator @operator;
	}
}
