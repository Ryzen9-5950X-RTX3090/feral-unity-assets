using System;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredByte : IObscuredType, IFormattable, IEquatable<ObscuredByte>, IComparable<ObscuredByte>, IComparable<byte>, IComparable
	{
		private byte currentCryptoKey;

		private byte hiddenValue;

		private bool inited;

		private byte fakeValue;

		private bool fakeValueActive;

		private ObscuredByte(byte value)
		{
		}

		public static byte Encrypt(byte value, byte key)
		{
			return default(byte);
		}

		public static void Encrypt(byte[] value, byte key)
		{
		}

		public static byte Decrypt(byte value, byte key)
		{
			return default(byte);
		}

		public static void Decrypt(byte[] value, byte key)
		{
		}

		public static ObscuredByte FromEncrypted(byte encrypted, byte key)
		{
			return default(ObscuredByte);
		}

		public static byte GenerateKey()
		{
			return default(byte);
		}

		public byte GetEncrypted(out byte key)
		{
			return default(byte);
		}

		public void SetEncrypted(byte encrypted, byte key)
		{
		}

		public byte GetDecrypted()
		{
			return default(byte);
		}

		public void RandomizeCryptoKey()
		{
		}

		private byte InternalDecrypt()
		{
			return default(byte);
		}

		public static implicit operator ObscuredByte(byte value)
		{
			return default(ObscuredByte);
		}

		public static implicit operator byte(ObscuredByte value)
		{
			return default(byte);
		}

		public static ObscuredByte operator ++(ObscuredByte input)
		{
			return default(ObscuredByte);
		}

		public static ObscuredByte operator --(ObscuredByte input)
		{
			return default(ObscuredByte);
		}

		private static ObscuredByte Increment(ObscuredByte input, int increment)
		{
			return default(ObscuredByte);
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

		public bool Equals(ObscuredByte obj)
		{
			return default(bool);
		}

		public int CompareTo(ObscuredByte other)
		{
			return default(int);
		}

		public int CompareTo(byte other)
		{
			return default(int);
		}

		public int CompareTo(object obj)
		{
			return default(int);
		}

		[Obsolete]
		public static void SetNewCryptoKey(byte newKey)
		{
		}

		[Obsolete]
		public void ApplyNewCryptoKey()
		{
		}

		[Obsolete]
		public static byte EncryptDecrypt(byte value)
		{
			return default(byte);
		}

		[Obsolete]
		public static byte EncryptDecrypt(byte[] value)
		{
			return default(byte);
		}

		[Obsolete]
		public static byte EncryptDecrypt(byte value, byte key)
		{
			return default(byte);
		}

		[Obsolete]
		public static void EncryptDecrypt(byte[] value, byte key)
		{
		}

		[Obsolete]
		public static ObscuredByte FromEncrypted(byte encrypted)
		{
			return default(ObscuredByte);
		}

		[Obsolete]
		public byte GetEncrypted()
		{
			return default(byte);
		}

		[Obsolete]
		public void SetEncrypted(byte encrypted)
		{
		}
	}
}
