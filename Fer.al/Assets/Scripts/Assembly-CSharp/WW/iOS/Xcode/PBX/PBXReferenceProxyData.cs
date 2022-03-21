namespace WW.iOS.Xcode.PBX
{
	internal class PBXReferenceProxyData : PBXObjectData
	{
		private static PropertyCommentChecker checkerData;

		internal override PropertyCommentChecker checker
		{
			get
			{
				return null;
			}
		}

		public string path
		{
			get
			{
				return null;
			}
		}

		public static PBXReferenceProxyData Create(string path, string fileType, string remoteRef, string sourceTree)
		{
			return null;
		}
	}
}
