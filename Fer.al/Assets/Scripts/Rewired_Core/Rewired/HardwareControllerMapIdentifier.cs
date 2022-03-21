using System;

namespace Rewired
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal struct HardwareControllerMapIdentifier
	{
		public readonly Guid guid;

		public readonly InputSource inputSource;

		public readonly InputPlatform actualInputPlatform;

		public readonly int variantIndex;

		public HardwareControllerMapIdentifier(Guid guid, InputSource inputSource, InputPlatform actualInputPlatform, int variantIndex)
		{
		}
	}
}
