using System.Collections.Generic;

namespace WW.iOS.Xcode.Extensions
{
	public static class PBXProjectExtensions
	{
		internal class FlagList : List<KeyValuePair<string, string>>
		{
			public void Add(string flag, string value)
			{
			}
		}

		internal static FlagList appExtensionReleaseBuildFlags;

		internal static FlagList appExtensionDebugBuildFlags;

		internal static FlagList watchExtensionReleaseBuildFlags;

		internal static FlagList watchExtensionDebugBuildFlags;

		internal static FlagList watchAppReleaseBuildFlags;

		internal static FlagList watchAppDebugBuildFlags;

		private static void SetBuildFlagsFromDict(this PBXProject proj, string configGuid, IEnumerable<KeyValuePair<string, string>> data)
		{
		}

		internal static void SetDefaultAppExtensionReleaseBuildFlags(this PBXProject proj, string configGuid)
		{
		}

		internal static void SetDefaultAppExtensionDebugBuildFlags(this PBXProject proj, string configGuid)
		{
		}

		internal static void SetDefaultWatchExtensionReleaseBuildFlags(this PBXProject proj, string configGuid)
		{
		}

		internal static void SetDefaultWatchExtensionDebugBuildFlags(this PBXProject proj, string configGuid)
		{
		}

		internal static void SetDefaultWatchAppReleaseBuildFlags(this PBXProject proj, string configGuid)
		{
		}

		internal static void SetDefaultWatchAppDebugBuildFlags(this PBXProject proj, string configGuid)
		{
		}

		public static string AddAppExtension(this PBXProject proj, string mainTargetGuid, string name, string bundleId, string infoPlistPath)
		{
			return null;
		}

		public static string AddWatchApp(this PBXProject proj, string mainTargetGuid, string watchExtensionTargetGuid, string name, string bundleId, string infoPlistPath)
		{
			return null;
		}

		public static string AddWatchExtension(this PBXProject proj, string mainTarget, string name, string bundleId, string infoPlistPath)
		{
			return null;
		}
	}
}
