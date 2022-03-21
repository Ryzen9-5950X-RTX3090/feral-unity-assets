using System;
using System.Collections.Generic;

namespace Rewired.Utils.Classes.Utility
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal class ObjectInstanceTracker : IDisposable
	{
		[CustomClassObfuscation]
		[CustomObfuscation]
		public class Wrapper<T> : IDisposable where T : class
		{
			public readonly T instance;

			public readonly uint instanceId;

			private readonly ObjectInstanceTracker SRTIePsJiAFtcYHeVPMOKnlVyMr;

			private bool vEblpmllYIOuQHCXVghuIpihdSG;

			public Wrapper(T instance)
			{
			}

			public Wrapper(T instance, ObjectInstanceTracker tracker)
			{
			}

			public void Dispose()
			{
			}

			~Wrapper()
			{
			}

			protected virtual void Dispose(bool disposing)
			{
			}
		}

		private static ObjectInstanceTracker DqYmGHECTlrDVQmfbrCSLOJGmsK;

		private readonly Dictionary<uint, object> TYufseIPYRAITDrtiEyIVAnwmfKR;

		private readonly object WatKdvusjCxngKhmexeOsWElHfj;

		private uint LmoXqZdlklByordOEfRAEHUjbmtR;

		private int zmVTMZhvzUQzWQrGMGOGKzlVJbw;

		private bool uCCFjviloQzdElMrfDDBZRCAEDsh;

		public static ObjectInstanceTracker Default
		{
			get
			{
				return null;
			}
		}

		public uint Register(object instance)
		{
			return default(uint);
		}

		public void Unregister(uint instanceId)
		{
		}

		public bool TryGetInstance<T>(uint instanceId, out T instance) where T : class
		{
			return default(bool);
		}

		public void Dispose()
		{
		}

		private void HpvXOLYMqgpVKJfbWRtmjedASDv(bool P_0)
		{
		}

		~ObjectInstanceTracker()
		{
		}
	}
}
