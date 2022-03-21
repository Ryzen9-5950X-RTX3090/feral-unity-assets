using System;
using System.Runtime.InteropServices;

namespace Crosstales.FB.Wrapper
{
	internal static class NativeMethods
	{
		public delegate int BrowseCallbackProc(IntPtr hwnd, int uMsg, IntPtr lParam, IntPtr lpData);

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		internal struct OpenFileName
		{
			public int structSize;

			public IntPtr dlgOwner;

			public IntPtr instance;

			public string filter;

			public string customFilter;

			public int maxCustFilter;

			public int filterIndex;

			public IntPtr file;

			public int maxFile;

			public string fileTitle;

			public int maxFileTitle;

			public string initialDir;

			public string title;

			public int flags;

			public ushort fileOffset;

			public ushort fileExtension;

			public string defExt;

			public string custData;

			public IntPtr hook;

			public string templateName;

			public IntPtr reservedPtr;

			public int reservedInt;

			public int flagsEx;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		internal struct BROWSEINFO
		{
			public IntPtr dlgOwner;

			public IntPtr pidlRoot;

			public IntPtr pszDisplayName;

			public string lpszTitle;

			public uint ulFlags;

			public BrowseCallbackProc lpfn;

			public IntPtr lParam;

			public int iImage;
		}

		public static extern bool GetOpenFileName(ref OpenFileName ofn);

		public static extern bool GetSaveFileName(ref OpenFileName sfn);

		internal static extern IntPtr SHBrowseForFolder(ref BROWSEINFO lpbi);

		internal static extern bool SHGetPathFromIDList(IntPtr pidl, IntPtr pszPath);

		internal static extern IntPtr GetActiveWindow();

		public static extern IntPtr SendMessage(HandleRef hWnd, uint Msg, int wParam, IntPtr lParam);

		public static extern IntPtr SendMessage(HandleRef hWnd, int msg, int wParam, string lParam);
	}
}
