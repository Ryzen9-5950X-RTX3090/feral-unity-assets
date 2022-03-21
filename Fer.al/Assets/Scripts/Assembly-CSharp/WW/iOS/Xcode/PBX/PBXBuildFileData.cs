using System.Collections.Generic;

namespace WW.iOS.Xcode.PBX
{
	internal class PBXBuildFileData : PBXObjectData
	{
		public string fileRef;

		public string compileFlags;

		public bool weak;

		public List<string> assetTags;

		private static PropertyCommentChecker checkerData;

		internal override PropertyCommentChecker checker
		{
			get
			{
				return null;
			}
		}

		internal override bool shouldCompact
		{
			get
			{
				return default(bool);
			}
		}

		public static PBXBuildFileData CreateFromFile(string fileRefGUID, bool weak, string compileFlags)
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
