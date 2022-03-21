using UnityEngine;

namespace GaiaCommon1
{
	public class AppConfig
	{
		public const string VERSION = "1";

		public readonly string CfgVersion;

		public readonly double LastUpdated;

		public readonly string MinUnity;

		public readonly string Name;

		public readonly Texture2D Logo;

		public readonly string NameSpace;

		public readonly string Folder;

		public readonly string ScriptsFolder;

		public readonly string EditorScriptsFolder;

		public readonly string DocsFolder;

		public readonly string DocsFolderSpaced;

		public readonly string MajorVersion;

		public readonly string MinorVersion;

		public readonly string PatchVersion;

		public readonly string Version;

		public readonly SystemLanguage[] AvailableLanguages;

		public readonly string TutorialsLink;

		public readonly string DiscordLink;

		public readonly string SupportLink;

		public readonly string ASLink;

		public readonly string NewsURLStripped;

		public readonly bool HasWelcome;

		public string NewsURL
		{
			get
			{
				return null;
			}
		}

		public AppConfig(string minUnity, string name, SystemLanguage[] availableLanguages)
		{
		}

		public AppConfig(string cfgVersion, double lastUpdated, string minUnity, string name, Texture2D logo, string nameSpace, string folder, string scriptsFolder, string editorScriptsFolder, string docsFolder, string majorVer, string minorVer, string patchVer, SystemLanguage[] availableLang, string tutorialsLink, string discordLink, string supportLink, string asLink, string newsURL, bool hasWelcome)
		{
		}
	}
}
