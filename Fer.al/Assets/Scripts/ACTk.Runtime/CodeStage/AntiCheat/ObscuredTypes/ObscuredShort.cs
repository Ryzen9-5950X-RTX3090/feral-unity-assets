using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredShort : IObscuredType, IFormattable, IEquatable<ObscuredShort>, IComparable<ObscuredShort>, IComparable<short>, IComparable
	{
		[SerializeField]
		private short currentCryptoKey;

		[SerializeField]
		private short hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private short fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredShort(short value)
		{
		}

		public static short Encrypt(short value, short key)
		{
			return default(short);
		}

		public static short Decrypt(short value, short key)
		{
			return default(short);
		}

		public static ObscuredShort FromEncrypted(short encrypted, short key)
		{
			return default(ObscuredShort);
		}

		public static short GenerateKey()
		{
			return default(short);
		}

		public short GetEncrypted(out short key)
		{
			return default(short);
		}

		public void SetEncrypted(short encrypted, short key)
		{
		}

		public short GetDecrypted()
		{
			return default(short);
		}

		public void RandomizeCryptoKey()
		{
		}

		private short InternalDecrypt()
		{
			return default(short);
		}

		public static implicit operator ObscuredShort(short value)
		{
			return default(ObscuredShort);
		}

		public static implicit operator short(ObscuredShort value)
		{
			return default(short);
		}

		public static ObscuredShort operator ++(ObscuredShort input)
		{
			return default(ObscuredShort);
		}

		public static ObscuredShort operator --(ObscuredShort input)
		{
			return default(ObscuredShort);
		}

		private static ObscuredShort Increment(ObscuredShort input, int increment)
		{
			return default(ObscuredShort);
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

		public bool Equals(ObscuredShort obj)
		{
			return default(bool);
		}

		public int CompareTo(ObscuredShort other)
		{
			return default(int);
		}

		public int CompareTo(short other)
		{
			return default(int);
		}

		public int CompareTo(object obj)
		{
			return default(int);
		}

		[Obsolete]
		public static void SetNewCryptoKey(short newKey)
		{
		}

		[Obsolete]
		public void ApplyNewCryptoKey()
		{
		}

		[Obsolete]
		public static short EncryptDecrypt(short value)
		{
			return default(short);
		}

		[Obsolete]
		public static short EncryptDecrypt(short value, short key)
		{
			return default(short);
		}

		[Obsolete]
		public static ObscuredShort FromEncrypted(short encrypted)
		{
			return default(ObscuredShort);
		}

		[Obsolete]
		public short GetEncrypted()
		{
			return default(short);
		}

		[Obsolete]
		public void SetEncrypted(short encrypted)
		{
		}
	}
}
