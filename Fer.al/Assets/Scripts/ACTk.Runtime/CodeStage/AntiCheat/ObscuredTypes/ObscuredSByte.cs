using System;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredSByte : IObscuredType, IFormattable, IEquatable<ObscuredSByte>, IComparable<ObscuredSByte>, IComparable<sbyte>, IComparable
	{
		private sbyte currentCryptoKey;

		private sbyte hiddenValue;

		private bool inited;

		private sbyte fakeValue;

		private bool fakeValueActive;

		private ObscuredSByte(sbyte value)
		{
		}

		public static sbyte Encrypt(sbyte value, sbyte key)
		{
			return default(sbyte);
		}

		public static sbyte Decrypt(sbyte value, sbyte key)
		{
			return default(sbyte);
		}

		public static ObscuredSByte FromEncrypted(sbyte encrypted, sbyte key)
		{
			return default(ObscuredSByte);
		}

		public static sbyte GenerateKey()
		{
			return default(sbyte);
		}

		public sbyte GetEncrypted(out sbyte key)
		{
			return default(sbyte);
		}

		public void SetEncrypted(sbyte encrypted, sbyte key)
		{
		}

		public sbyte GetDecrypted()
		{
			return default(sbyte);
		}

		public void RandomizeCryptoKey()
		{
		}

		private sbyte InternalDecrypt()
		{
			return default(sbyte);
		}

		public static implicit operator ObscuredSByte(sbyte value)
		{
			return default(ObscuredSByte);
		}

		public static implicit operator sbyte(ObscuredSByte value)
		{
			return default(sbyte);
		}

		public static ObscuredSByte operator ++(ObscuredSByte input)
		{
			return default(ObscuredSByte);
		}

		public static ObscuredSByte operator --(ObscuredSByte input)
		{
			return default(ObscuredSByte);
		}

		private static ObscuredSByte Increment(ObscuredSByte input, int increment)
		{
			return default(ObscuredSByte);
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

		public bool Equals(ObscuredSByte obj)
		{
			return default(bool);
		}

		public int CompareTo(ObscuredSByte other)
		{
			return default(int);
		}

		public int CompareTo(sbyte other)
		{
			return default(int);
		}

		public int CompareTo(object obj)
		{
			return default(int);
		}

		[Obsolete]
		public static void SetNewCryptoKey(sbyte newKey)
		{
		}

		[Obsolete]
		public void ApplyNewCryptoKey()
		{
		}

		[Obsolete]
		public static sbyte EncryptDecrypt(sbyte value)
		{
			return default(sbyte);
		}

		[Obsolete]
		public static sbyte EncryptDecrypt(sbyte value, sbyte key)
		{
			return default(sbyte);
		}

		[Obsolete]
		public static ObscuredSByte FromEncrypted(sbyte encrypted)
		{
			return default(ObscuredSByte);
		}

		[Obsolete]
		public sbyte GetEncrypted()
		{
			return default(sbyte);
		}

		[Obsolete]
		public void SetEncrypted(sbyte encrypted)
		{
		}
	}
}
