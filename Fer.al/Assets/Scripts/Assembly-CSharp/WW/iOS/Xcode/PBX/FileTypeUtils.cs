using System.Collections.Generic;

namespace WW.iOS.Xcode.PBX
{
	internal class FileTypeUtils
	{
		internal class FileTypeDesc
		{
			public string name;

			public PBXFileType type;

			public bool isExplicit;

			public FileTypeDesc(string typeName, PBXFileType type)
			{
			}

			public FileTypeDesc(string typeName, PBXFileType type, bool isExplicit)
			{
			}
		}

		private static readonly Dictionary<string, FileTypeDesc> types;

		private static readonly Dictionary<PBXSourceTree, string> sourceTree;

		private static readonly Dictionary<string, PBXSourceTree> stringToSourceTreeMap;

		public static string TrimExtension(string ext)
		{
			return null;
		}

		public static bool IsKnownExtension(string ext)
		{
			return default(bool);
		}

		internal static bool IsFileTypeExplicit(string ext)
		{
			return default(bool);
		}

		public static PBXFileType GetFileType(string ext, bool isFolderRef)
		{
			return default(PBXFileType);
		}

		public static string GetTypeName(string ext)
		{
			return null;
		}

		public static bool IsBuildableFile(string ext)
		{
			return default(bool);
		}

		public static bool IsBuildable(string ext, bool isFolderReference)
		{
			return default(bool);
		}

		internal static string SourceTreeDesc(PBXSourceTree tree)
		{
			return null;
		}

		internal static PBXSourceTree ParseSourceTree(string tree)
		{
			return default(PBXSourceTree);
		}

		internal static List<PBXSourceTree> AllAbsoluteSourceTrees()
		{
			return null;
		}
	}
}
