using UnityEngine;

namespace FMODUnity
{
	public class PlatformGroup : Platform
	{
		[SerializeField]
		public string displayName;

		[SerializeField]
		private Legacy.Platform legacyIdentifier;

		public override string DisplayName
		{
			get
			{
				return null;
			}
		}

		public override void DeclareUnityMappings(Settings settings)
		{
		}
	}
}
