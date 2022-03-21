using System;
using System.Collections.Generic;

namespace FMODUnity
{
	public static class Legacy
	{
		[Serializable]
		public enum Platform
		{
			None,
			PlayInEditor,
			Default,
			Desktop,
			Mobile,
			MobileHigh,
			MobileLow,
			Console,
			Windows,
			Mac,
			Linux,
			iOS,
			Android,
			Deprecated_1,
			XboxOne,
			PS4,
			Deprecated_2,
			Deprecated_3,
			AppleTV,
			UWP,
			Switch,
			WebGL,
			Stadia,
			Reserved_1,
			Reserved_2,
			Reserved_3,
			Count
		}

		public class PlatformSettingBase
		{
			public Platform Platform;
		}

		public class PlatformSetting<T> : PlatformSettingBase
		{
			public T Value;
		}

		[Serializable]
		public class PlatformIntSetting : PlatformSetting<int>
		{
		}

		[Serializable]
		public class PlatformStringSetting : PlatformSetting<string>
		{
		}

		[Serializable]
		public class PlatformBoolSetting : PlatformSetting<TriStateBool>
		{
		}

		public static void CopySetting<T, U>(List<T> list, Platform fromPlatform, Platform toPlatform) where T : PlatformSetting<U>, new()
		{
		}

		public static void CopySetting(List<PlatformBoolSetting> list, Platform fromPlatform, Platform toPlatform)
		{
		}

		public static void CopySetting(List<PlatformIntSetting> list, Platform fromPlatform, Platform toPlatform)
		{
		}

		public static string DisplayName(Platform platform)
		{
			return null;
		}

		public static float SortOrder(Platform legacyPlatform)
		{
			return default(float);
		}

		public static Platform Parent(Platform platform)
		{
			return default(Platform);
		}

		public static bool IsGroup(Platform platform)
		{
			return default(bool);
		}
	}
}
