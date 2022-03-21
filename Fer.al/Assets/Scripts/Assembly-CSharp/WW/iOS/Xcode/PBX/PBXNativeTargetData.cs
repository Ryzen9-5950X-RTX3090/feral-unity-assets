namespace WW.iOS.Xcode.PBX
{
	internal class PBXNativeTargetData : PBXObjectData
	{
		public GUIDList phases;

		public string buildConfigList;

		public string name;

		public GUIDList dependencies;

		public string productReference;

		private static PropertyCommentChecker checkerData;

		internal override PropertyCommentChecker checker
		{
			get
			{
				return null;
			}
		}

		public static PBXNativeTargetData Create(string name, string productRef, string productType, string buildConfigList)
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
