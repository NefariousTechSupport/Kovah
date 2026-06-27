namespace Kovah.Numerics
{
	/// <summary>
	/// 3x4 Matrix implementation based on the System.Numerics.Matrix4x4 implementation
	/// </summary>
	public struct Matrix3x4 : IEquatable<Matrix3x4>
	{
		internal const int RowCount = 3;
		internal const int ColumnCount = 4;

		public float M11;
		public float M12;
		public float M13;
		public float M14;
		public float M21;
		public float M22;
		public float M23;
		public float M24;
		public float M31;
		public float M32;
		public float M33;
		public float M34;


		public Matrix3x4(
			float m11, float m12, float m13, float m14,
			float m21, float m22, float m23, float m24,
			float m31, float m32, float m33, float m34)
		{
			this = Create(
				m11, m12, m13, m14,
				m21, m22, m23, m24,
				m31, m32, m33, m34
			);
		}

		public static Matrix3x4 Create(
			float m11, float m12, float m13, float m14,
			float m21, float m22, float m23, float m24,
			float m31, float m32, float m33, float m34)
		{
			Matrix3x4 mat = new Matrix3x4();
			mat.M11 = m11;
			mat.M12 = m12;
			mat.M13 = m13;
			mat.M14 = m14;
			mat.M21 = m21;
			mat.M22 = m22;
			mat.M23 = m23;
			mat.M24 = m24;
			mat.M31 = m31;
			mat.M32 = m32;
			mat.M33 = m33;
			mat.M34 = m34;
			return mat;
		}

		public readonly bool Equals(Matrix3x4 other)
		{
			return M11 == other.M11
			    && M12 == other.M12
			    && M13 == other.M13
			    && M14 == other.M14
			    && M21 == other.M21
			    && M22 == other.M22
			    && M23 == other.M23
			    && M24 == other.M24
			    && M31 == other.M31
			    && M32 == other.M32
			    && M33 == other.M33
			    && M34 == other.M34;
		}
	}
}