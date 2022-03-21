using System;
using FMOD;

namespace FMODUnity
{
	public class PlatformPlayInEditor : Platform
	{
		public override string DisplayName
		{
			get
			{
				return null;
			}
		}

		public override bool IsIntrinsic
		{
			get
			{
				return default(bool);
			}
		}

		public override void DeclareUnityMappings(Settings settings)
		{
		}

		public override string GetBankFolder()
		{
			return null;
		}

		public override void LoadStaticPlugins(FMOD.System coreSystem, Action<RESULT, string> reportResult)
		{
		}

		public override void InitializeProperties()
		{
		}
	}
}
