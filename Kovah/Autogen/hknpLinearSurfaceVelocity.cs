namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpLinearSurfaceVelocity : hknpSurfaceVelocity
	{
		public enum ProjectMethod
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			VELOCITY_PROJECT,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			VELOCITY_RESCALE,
			
		}
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, typeof(hknpSurfaceVelocity.Space), Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		private hknpSurfaceVelocity.Space space;
		[HavokMember(EVersion.hk_2014_1_0_r1, 9, null, typeof(hknpLinearSurfaceVelocity.ProjectMethod), Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		private hknpLinearSurfaceVelocity.ProjectMethod projectMethod;
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float maxVelocityScale;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 velocityMeasurePlane;
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 velocity;
	}
}
