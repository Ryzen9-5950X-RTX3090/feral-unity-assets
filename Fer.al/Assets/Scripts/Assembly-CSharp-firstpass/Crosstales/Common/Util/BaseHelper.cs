using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using Crosstales.Common.Model.Enum;
using UnityEngine;

namespace Crosstales.Common.Util
{
	public abstract class BaseHelper
	{
		public static readonly CultureInfo BaseCulture;

		protected static readonly Regex lineEndingsRegex;

		protected static readonly Regex cleanSpacesRegex;

		protected static readonly Regex cleanTagsRegex;

		protected static readonly System.Random rnd;

		protected const string file_prefix = "file://";

		public static bool isInternetAvailable
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isWindowsPlatform
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isMacOSPlatform
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isLinuxPlatform
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isStandalonePlatform
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isAndroidPlatform
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isIOSPlatform
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isTvOSPlatform
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isWSAPlatform
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isXboxOnePlatform
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isPS4Platform
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isWebGLPlatform
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isWebPlatform
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isWindowsBasedPlatform
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isWSABasedPlatform
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isAppleBasedPlatform
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isIOSBasedPlatform
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isEditor
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isWindowsEditor
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isMacOSEditor
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isLinuxEditor
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isEditorMode
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isIL2CPP
		{
			get
			{
				return default(bool);
			}
		}

		public static Platform CurrentPlatform
		{
			get
			{
				return default(Platform);
			}
		}

		public static string StreamingAssetsPath
		{
			get
			{
				return null;
			}
		}

		public static bool OpenURL(string url)
		{
			return default(bool);
		}

		public static string CreateString(string replaceChars, int stringLength)
		{
			return null;
		}

		public static bool hasActiveClip(AudioSource source)
		{
			return default(bool);
		}

		public static bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return default(bool);
		}

		public static string ValidatePath(string path, bool addEndDelimiter = true)
		{
			return null;
		}

		public static string ValidateFile(string path)
		{
			return null;
		}

		public static string[] GetFiles(string path, bool isRecursive = false, string[] extensions)
		{
			return null;
		}

		public static string[] GetDirectories(string path, bool isRecursive = false)
		{
			return null;
		}

		public static string ValidURLFromFilePath(string path)
		{
			return null;
		}

		public static string CleanUrl(string url, bool removeProtocol = true, bool removeWWW = true, bool removeSlash = true)
		{
			return null;
		}

		public static string ClearTags(string text)
		{
			return null;
		}

		public static string ClearSpaces(string text)
		{
			return null;
		}

		public static string ClearLineEndings(string text)
		{
			return null;
		}

		public static List<string> SplitStringToLines(string text, bool ignoreCommentedLines = true, int skipHeaderLines = 0, int skipFooterLines = 0)
		{
			return null;
		}

		public static string FormatBytesToHRF(long bytes)
		{
			return null;
		}

		public static string FormatSecondsToHourMinSec(double seconds)
		{
			return null;
		}

		public static Color HSVToRGB(float h, float s, float v, float a = 1f)
		{
			return default(Color);
		}

		public static bool isValidURL(string url)
		{
			return default(bool);
		}

		public static void FileCopy(string inputFile, string outputFile, bool move = false)
		{
		}

		public static void ShowFileLocation(string file)
		{
		}

		public static void OpenFile(string file)
		{
		}

		public static string getIP(string host)
		{
			return null;
		}
	}
}
