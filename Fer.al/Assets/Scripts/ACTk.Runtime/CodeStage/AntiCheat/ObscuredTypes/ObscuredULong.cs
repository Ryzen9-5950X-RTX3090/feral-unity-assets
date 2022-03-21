using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredULong : IObscuredType, IFormattable, IEquatable<ObscuredULong>, IComparable<ObscuredULong>, IComparable<ulong>, IComparable
	{
		[SerializeField]
		private ulong currentCryptoKey;

		[SerializeField]
		private ulong hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private ulong fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredULong(ulong value)
		{
		}

		public static ulong Encrypt(ulong value, ulong key)
		{
			return default(ulong);
		}

		public static ulong Decrypt(ulong value, ulong key)
		{
			return default(ulong);
		}

		public static ObscuredULong FromEncrypted(ulong encrypted, ulong key)
		{
			return default(ObscuredULong);
		}

		public static ulong GenerateKey()
		{
			return default(ulong);
		}

		public ulong GetEncrypted(out ulong key)
		{
			return default(ulong);
		}

		public void SetEncrypted(ulong encrypted, ulong key)
		{
		}

		public ulong GetDecrypted()
		{
			return default(ulong);
		}

		public void RandomizeCryptoKey()
		{
		}

		private ulong InternalDecrypt()
		{
			return default(ulong);
		}

		public static implicit operator ObscuredULong(ulong value)
		{
			return default(ObscuredULong);
		}

		public static implicit operator ulong(ObscuredULong value)
		{
			return default(ulong);
		}

		public static ObscuredULong operator ++(ObscuredULong input)
		{
			return default(ObscuredULong);
		}

		public static ObscuredULong operator --(ObscuredULong input)
		{
			return default(ObscuredULong);
		}

		private static ObscuredULong Increment(ObscuredULong input, int increment)
		{
			return default(ObscuredULong);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(string format)
		{
			return null;
		}

		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public bool Equals(ObscuredULong obj)
		{
			return default(bool);
		}

		public int CompareTo(ObscuredULong other)
		{
			return default(int);
		}

		public int CompareTo(ulong other)
		{
			return default(int);
		}

		public int CompareTo(object obj)
		{
			return default(int);
		}

		[Obsolete]
		public static void SetNewCryptoKey(ulong newKey)
		{
		}

		[Obsolete]
		public void ApplyNewCryptoKey()
		{
		}

		[Obsolete]
		public static ulong Encrypt(ulong value)
		{
			return default(ulong);
		}

		[Obsolete]
		public static ulong Decrypt(ulong value)
		{
			return default(ulong);
		}

		[Obsolete]
		public static ObscuredULong FromEncrypted(ulong encrypted)
		{
			return default(ObscuredULong);
		}

		[Obsolete]
		public ulong GetEncrypted()
		{
			return default(ulong);
		}

		[Obsolete]
		public void SetEncrypted(ulong encrypted)
		{
		}
	}
}
