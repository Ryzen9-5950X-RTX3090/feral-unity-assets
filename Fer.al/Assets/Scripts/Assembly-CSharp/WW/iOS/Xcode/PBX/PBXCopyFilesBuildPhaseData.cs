namespace WW.iOS.Xcode.PBX
{
	internal class PBXCopyFilesBuildPhaseData : FileGUIDListBase
	{
		private static PropertyCommentChecker checkerData;

		public string name;

		internal override PropertyCommentChecker checker
		{
			get
			{
				return null;
			}
		}

		public static PBXCopyFilesBuildPhaseData Create(string name, string dstPath, string subfolderSpec)
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
