using System;
using UnityEngine;

namespace Rewired.Utils.Classes.Data
{
	[Serializable]
	public class SerializableULong
	{
		[CustomObfuscation]
		[SerializeField]
		private int ulong_32BitLow;

		[SerializeField]
		[CustomObfuscation]
		private int ulong_32BitHigh;

		public ulong value
		{
			get
			{
				return default(ulong);
			}
			set
			{
			}
		}

		public SerializableULong()
		{
		}

		public SerializableULong(SerializableULong sULong)
		{
		}

		private void xeztihWAOshwHueAxvzQUrCpDbQ(ulong P_0, out int P_1, out int P_2)
		{
		}

		private ulong MsUKXxKooqapJlCmbYZgNClEQXD(int P_0, int P_1)
		{
			return default(ulong);
		}

		public SerializableULong Clone()
		{
			return null;
		}
	}
}
