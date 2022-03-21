namespace WW.iOS.Xcode.PBX
{
	internal class PBXGroupData : PBXObjectData
	{
		public GUIDList children;

		public PBXSourceTree tree;

		public string name;

		public string path;

		private static PropertyCommentChecker checkerData;

		internal override PropertyCommentChecker checker
		{
			get
			{
				return null;
			}
		}

		public static PBXGroupData Create(string name, string path, PBXSourceTree tree)
		{
			return null;
		}

		public static PBXGroupData CreateRelative(string name)
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
