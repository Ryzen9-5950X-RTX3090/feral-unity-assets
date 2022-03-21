using System;
using FMOD;

namespace FMODUnity
{
	public class PlatformAppleTV : Platform
	{
		public override string DisplayName
		{
			get
			{
				return null;
			}
		}

		static PlatformAppleTV()
		{
		}

		public override void DeclareUnityMappings(Settings settings)
		{
		}

		public override void LoadPlugins(FMOD.System coreSystem, Action<RESULT, string> reportResult)
		{
		}
	}
}
