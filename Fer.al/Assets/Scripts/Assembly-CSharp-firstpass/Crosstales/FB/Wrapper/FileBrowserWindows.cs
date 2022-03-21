using System;
using AOT;

namespace Crosstales.FB.Wrapper
{
	public class FileBrowserWindows : FileBrowserBase
	{
		private static string _initialPath;

		private const int OFN_NOCHANGEDIR = 8;

		private const int OFN_ALLOWMULTISELECT = 512;

		private const int OFN_EXPLORER = 524288;

		private const int OFN_FILEMUSTEXIST = 4096;

		private const int OFN_PATHMUSTEXIST = 2048;

		private const int OFN_OVERWRITEPROMPT = 2;

		private const int MAX_OPEN_FILE_LENGTH = 65536;

		private const int MAX_SAVE_FILE_LENGTH = 4096;

		private const int MAX_PATH_LENGTH = 4096;

		private const int WM_USER = 1024;

		private const int BFFM_INITIALIZED = 1;

		private const int BFFM_SELCHANGED = 2;

		private const int BFFM_SETSELECTIONW = 1127;

		private const int BFFM_SETSTATUSTEXTW = 1128;

		private const uint BIF_NEWDIALOGSTYLE = 64u;

		private const uint BIF_SHAREABLE = 32768u;

		private static readonly IntPtr currentWindow;

		private static readonly char[] nullChar;

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

		private string[] openFolders(string title, string directory, bool multiselect, bool isAsync)
		{
			return null;
		}

		[MonoPInvokeCallback(typeof(NativeMethods.BrowseCallbackProc))]
		private static int onBrowseEvent(IntPtr hWnd, int msg, IntPtr lp, IntPtr lpData)
		{
			return default(int);
		}

		private static string getDefaultExtension(ExtensionFilter[] extensions)
		{
			return null;
		}

		private static string getFilterFromFileExtensionList(ExtensionFilter[] extensions)
		{
			return null;
		}
	}
}
