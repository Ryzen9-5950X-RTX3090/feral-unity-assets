using System;
using FMOD;

namespace FMODUnity
{
	public class PlatformIOS : Platform
	{
		public override string DisplayName
		{
			get
			{
				return null;
			}
		}

		static PlatformIOS()
		{
		}

		public override void DeclareUnityMappings(Settings settings)
		{
		}

		public override void LoadPlugins(FMOD.System coreSystem, Action<RESULT, string> reportResult)
		{
		}

		public static void StaticLoadPlugins(Platform platform, FMOD.System coreSystem, Action<RESULT, string> reportResult)
		{
		}
	}
}
