using System;
using Crosstales.FB.Wrapper;

namespace Crosstales.FB
{
	public static class FileBrowser
	{
		private static readonly IFileBrowser platformWrapper;

		public static bool canOpenMultipleFiles
		{
			get
			{
				return default(bool);
			}
		}

		public static bool canOpenMultipleFolders
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isPlatformSupported
		{
			get
			{
				return default(bool);
			}
		}

		static FileBrowser()
		{
		}

		public static string OpenSingleFile(string extension = "*")
		{
			return null;
		}

		public static string OpenSingleFile(string title, string directory, string[] extensions)
		{
			return null;
		}

		public static string OpenSingleFile(string title, string directory, ExtensionFilter[] extensions)
		{
			return null;
		}

		public static string[] OpenFiles(string extension = "*")
		{
			return null;
		}

		public static string[] OpenFiles(string title, string directory, string[] extensions)
		{
			return null;
		}

		public static string[] OpenFiles(string title, string directory, ExtensionFilter[] extensions)
		{
			return null;
		}

		public static string OpenSingleFolder()
		{
			return null;
		}

		public static string OpenSingleFolder(string title, string directory = "")
		{
			return null;
		}

		public static string[] OpenFolders()
		{
			return null;
		}

		public static string[] OpenFolders(string title, string directory = "")
		{
			return null;
		}

		public static string SaveFile(string defaultName = "", string extension = "*")
		{
			return null;
		}

		public static string SaveFile(string title, string directory, string defaultName, string[] extensions)
		{
			return null;
		}

		public static string SaveFile(string title, string directory, string defaultName, ExtensionFilter[] extensions)
		{
			return null;
		}

		public static void OpenFilesAsync(Action<string[]> cb, bool multiselect = true, string[] extensions)
		{
		}

		public static void OpenFilesAsync(Action<string[]> cb, string title, string directory, bool multiselect = true, string[] extensions)
		{
		}

		public static void OpenFilesAsync(Action<string[]> cb, string title, string directory, bool multiselect = true, ExtensionFilter[] extensions)
		{
		}

		public static void OpenFoldersAsync(Action<string[]> cb, bool multiselect = true)
		{
		}

		public static void OpenFoldersAsync(Action<string[]> cb, string title, string directory = "", bool multiselect = true)
		{
		}

		public static void SaveFileAsync(Action<string> cb, string defaultName = "", string extension = "*")
		{
		}

		public static void SaveFileAsync(Action<string> cb, string title, string directory, string defaultName, string[] extensions)
		{
		}

		public static void SaveFileAsync(Action<string> cb, string title, string directory, string defaultName, ExtensionFilter[] extensions)
		{
		}

		public static string[] GetFiles(string path, bool isRecursive = false, string[] extensions)
		{
			return null;
		}

		public static string[] GetFiles(string path, bool isRecursive, ExtensionFilter[] extensions)
		{
			return null;
		}

		public static string[] GetDirectories(string path, bool isRecursive = false)
		{
			return null;
		}

		private static ExtensionFilter[] getFilter(string[] extensions)
		{
			return null;
		}
	}
}
