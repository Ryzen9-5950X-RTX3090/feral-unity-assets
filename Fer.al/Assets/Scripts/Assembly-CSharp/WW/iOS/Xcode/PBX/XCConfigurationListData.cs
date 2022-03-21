namespace WW.iOS.Xcode.PBX
{
	internal class XCConfigurationListData : PBXObjectData
	{
		public GUIDList buildConfigs;

		private static PropertyCommentChecker checkerData;

		internal override PropertyCommentChecker checker
		{
			get
			{
				return null;
			}
		}

		public static XCConfigurationListData Create()
		{
			return null;
		}

		public override void UpdateProps()
		{
		}

		public override void UpdateVars()
		{
		}
	}
}
