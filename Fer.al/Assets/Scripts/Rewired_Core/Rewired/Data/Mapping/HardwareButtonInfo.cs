using System;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Data.Mapping
{
	[Serializable]
	public class HardwareButtonInfo : IDeepCloneable
	{
		[SerializeField]
		internal bool _excludeFromPolling;

		[SerializeField]
		internal bool _isPressureSensitive;

		public bool excludeFromPolling
		{
			get
			{
				return default(bool);
			}
		}

		public bool isPressureSensitive
		{
			get
			{
				return default(bool);
			}
		}

		public HardwareButtonInfo()
		{
		}

		[CustomObfuscation]
		internal HardwareButtonInfo(bool excludeFromPolling, bool isPressureSensitive)
		{
		}

		public object DeepClone()
		{
			return null;
		}
	}
}
