namespace WW.iOS.Xcode.PBX
{
	internal class FileGUIDListBase : PBXObjectData
	{
		public GUIDList files;

		private static PropertyCommentChecker checkerData;

		internal override PropertyCommentChecker checker
		{
			get
			{
				return null;
			}
		}

		public override void UpdateProps()
		{
		}

		public override void UpdateVars()
		{
		}
	}
}
