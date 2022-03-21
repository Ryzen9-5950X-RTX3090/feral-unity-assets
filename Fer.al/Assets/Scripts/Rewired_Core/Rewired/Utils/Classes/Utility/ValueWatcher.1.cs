using System;
using System.Collections.Generic;

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal sealed class ValueWatcher<T> : ValueWatcher
	{
		private static IEqualityComparer<T> PHfYDGwiJMDirGAMJwTwYeofakp;

		private bool nGUCoIcYbohCvvLydsvgZqrzEaW;

		private T FsxdnKHTiBkQzQeLhcyCJCYysFt;

		private bool ZNnNpvKquNHqulJlMfemZtvvtHp;

		private Func<T> ymUirBBLEcargSiPzLvIxNFtCho;

		private Action<T> azkkxSPPqfjHrXpBnJCfsmWbzmp;

		public override bool changed
		{
			get
			{
				return default(bool);
			}
		}

		public override bool autoTriggerEvent
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Func<T> getValueDelegate
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public T value
		{
			get
			{
				return (T)null;
			}
		}

		public event Action<T> ChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public ValueWatcher(T initialValue, bool autoTriggerEvent)
		{
		}

		public ValueWatcher(T initialValue, Func<T> getValueDelegate, bool autoTriggerEvent)
		{
		}

		public override bool Update()
		{
			return default(bool);
		}

		public override bool Use()
		{
			return default(bool);
		}

		public override bool TriggerEvent()
		{
			return default(bool);
		}

		public bool Set(T value)
		{
			return default(bool);
		}

		public override void AddEventListener(eaksbTCSHXsAACqYSgJAdgGkDQR eventType, Delegate listener)
		{
		}

		public override void RemoveEventListener(eaksbTCSHXsAACqYSgJAdgGkDQR eventType, Delegate listener)
		{
		}
	}
}
