using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredLong : IObscuredType, IFormattable, IEquatable<ObscuredLong>, IComparable<ObscuredLong>, IComparable<long>, IComparable
	{
		[SerializeField]
		private long currentCryptoKey;

		[SerializeField]
		private long hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private long fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredLong(long value)
		{
		}

		public static long Encrypt(long value, long key)
		{
			return default(long);
		}

		public static long Decrypt(long value, long key)
		{
			return default(long);
		}

		public static ObscuredLong FromEncrypted(long encrypted, long key)
		{
			return default(ObscuredLong);
		}

		public static long GenerateKey()
		{
			return default(long);
		}

		public long GetEncrypted(out long key)
		{
			return default(long);
		}

		public void SetEncrypted(long encrypted, long key)
		{
		}

		public long GetDecrypted()
		{
			return default(long);
		}

		public void RandomizeCryptoKey()
		{
		}

		private long InternalDecrypt()
		{
			return default(long);
		}

		public static implicit operator ObscuredLong(long value)
		{
			return default(ObscuredLong);
		}

		public static implicit operator long(ObscuredLong value)
		{
			return default(long);
		}

		public static ObscuredLong operator ++(ObscuredLong input)
		{
			return default(ObscuredLong);
		}

		public static ObscuredLong operator --(ObscuredLong input)
		{
			return default(ObscuredLong);
		}

		private static ObscuredLong Increment(ObscuredLong input, int increment)
		{
			return default(ObscuredLong);
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

		public bool Equals(ObscuredLong obj)
		{
			return default(bool);
		}

		public int CompareTo(ObscuredLong other)
		{
			return default(int);
		}

		public int CompareTo(long other)
		{
			return default(int);
		}

		public int CompareTo(object obj)
		{
			return default(int);
		}

		[Obsolete]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		[Obsolete]
		public void ApplyNewCryptoKey()
		{
		}

		[Obsolete]
		public static long Encrypt(long value)
		{
			return default(long);
		}

		[Obsolete]
		public static long Decrypt(long value)
		{
			return default(long);
		}

		[Obsolete]
		public static ObscuredLong FromEncrypted(long encrypted)
		{
			return default(ObscuredLong);
		}

		[Obsolete]
		public long GetEncrypted()
		{
			return default(long);
		}

		[Obsolete]
		public void SetEncrypted(long encrypted)
		{
		}
	}
}
