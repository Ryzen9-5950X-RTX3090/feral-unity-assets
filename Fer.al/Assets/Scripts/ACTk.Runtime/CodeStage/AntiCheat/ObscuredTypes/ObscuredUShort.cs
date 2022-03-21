using System;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredUShort : IObscuredType, IFormattable, IEquatable<ObscuredUShort>, IComparable<ObscuredUShort>, IComparable<ushort>, IComparable
	{
		private ushort currentCryptoKey;

		private ushort hiddenValue;

		private bool inited;

		private ushort fakeValue;

		private bool fakeValueActive;

		private ObscuredUShort(ushort value)
		{
		}

		public static ushort Encrypt(ushort value, ushort key)
		{
			return default(ushort);
		}

		public static ushort Decrypt(ushort value, ushort key)
		{
			return default(ushort);
		}

		public static ObscuredUShort FromEncrypted(ushort encrypted, ushort key)
		{
			return default(ObscuredUShort);
		}

		public static ushort GenerateKey()
		{
			return default(ushort);
		}

		public ushort GetEncrypted(out ushort key)
		{
			return default(ushort);
		}

		public void SetEncrypted(ushort encrypted, ushort key)
		{
		}

		public ushort GetDecrypted()
		{
			return default(ushort);
		}

		public void RandomizeCryptoKey()
		{
		}

		private ushort InternalDecrypt()
		{
			return default(ushort);
		}

		public static implicit operator ObscuredUShort(ushort value)
		{
			return default(ObscuredUShort);
		}

		public static implicit operator ushort(ObscuredUShort value)
		{
			return default(ushort);
		}

		public static ObscuredUShort operator ++(ObscuredUShort input)
		{
			return default(ObscuredUShort);
		}

		public static ObscuredUShort operator --(ObscuredUShort input)
		{
			return default(ObscuredUShort);
		}

		private static ObscuredUShort Increment(ObscuredUShort input, int increment)
		{
			return default(ObscuredUShort);
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

		public bool Equals(ObscuredUShort obj)
		{
			return default(bool);
		}

		public int CompareTo(ObscuredUShort other)
		{
			return default(int);
		}

		public int CompareTo(ushort other)
		{
			return default(int);
		}

		public int CompareTo(object obj)
		{
			return default(int);
		}

		[Obsolete]
		public static void SetNewCryptoKey(ushort newKey)
		{
		}

		[Obsolete]
		public void ApplyNewCryptoKey()
		{
		}

		[Obsolete]
		public static ushort EncryptDecrypt(ushort value)
		{
			return default(ushort);
		}

		[Obsolete]
		public static ushort EncryptDecrypt(ushort value, ushort key)
		{
			return default(ushort);
		}

		[Obsolete]
		public static ObscuredUShort FromEncrypted(ushort encrypted)
		{
			return default(ObscuredUShort);
		}

		[Obsolete]
		public ushort GetEncrypted()
		{
			return default(ushort);
		}

		[Obsolete]
		public void SetEncrypted(ushort encrypted)
		{
		}
	}
}
