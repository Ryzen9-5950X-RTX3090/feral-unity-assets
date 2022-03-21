namespace WW.iOS.Xcode.PBX
{
	internal class PBXFileReferenceData : PBXObjectData
	{
		private string m_Path;

		private string m_ExplicitFileType;

		private string m_LastKnownFileType;

		public string name;

		public PBXSourceTree tree;

		public string path
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isFolderReference
		{
			get
			{
				return default(bool);
			}
		}

		internal override bool shouldCompact
		{
			get
			{
				return default(bool);
			}
		}

		public static PBXFileReferenceData CreateFromFile(string path, string projectFileName, PBXSourceTree tree)
		{
			return null;
		}

		public static PBXFileReferenceData CreateFromFolderReference(string path, string projectFileName, PBXSourceTree tree)
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
