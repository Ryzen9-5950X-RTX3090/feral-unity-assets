using System;

namespace Crosstales.FB.Wrapper
{
	public class FileBrowserGeneric : FileBrowserBase
	{
		public override bool canOpenMultipleFiles
		{
			get
			{
				return default(bool);
			}
		}

		public override bool canOpenMultipleFolders
		{
			get
			{
				return default(bool);
			}
		}

		public override bool isPlatformSupported
		{
			get
			{
				return default(bool);
			}
		}

		public override string[] OpenFiles(string title, string directory, ExtensionFilter[] extensions, bool multiselect)
		{
			return null;
		}

		public override string[] OpenFolders(string title, string directory, bool multiselect)
		{
			return null;
		}

		public override string SaveFile(string title, string directory, string defaultName, ExtensionFilter[] extensions)
		{
			return null;
		}

		public override void OpenFilesAsync(string title, string directory, ExtensionFilter[] extensions, bool multiselect, Action<string[]> cb)
		{
		}

		public override void OpenFoldersAsync(string title, string directory, bool multiselect, Action<string[]> cb)
		{
		}

		public override void SaveFileAsync(string title, string directory, string defaultName, ExtensionFilter[] extensions, Action<string> cb)
		{
		}
	}
}
