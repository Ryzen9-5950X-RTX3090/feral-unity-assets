using System;
using System.Runtime.CompilerServices;
using Rewired.Utils.Classes.Utility;

namespace Rewired
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal sealed class LowLevelButtonEvent : LowLevelEvent
	{
		private const int qjYEzlcqnRjpmfRwXjlhcmfUoPZw = 100;

		public float value;

		private static readonly ObjectPool<LowLevelButtonEvent> eFCibrbGidYVCqriQoUjiEnwNFDh;

		[CompilerGenerated]
		private static Func<LowLevelButtonEvent> RmAwVhXJkTmkPbnjHBqKiBrHewI;

		private LowLevelButtonEvent()
		{
		}

		static LowLevelButtonEvent()
		{
		}

		public static LowLevelButtonEvent GetPooled(float timestamp, float value)
		{
			return null;
		}

		public static void ReturnPooled(LowLevelButtonEvent @event)
		{
		}

		[CompilerGenerated]
		private static LowLevelButtonEvent SHhkYQoZOcOvJaWepRTLupkJhxaf()
		{
			return null;
		}
	}
}
