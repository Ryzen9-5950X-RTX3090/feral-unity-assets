using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredInt : IObscuredType, IFormattable, IEquatable<ObscuredInt>, IComparable<ObscuredInt>, IComparable<int>, IComparable
	{
		[SerializeField]
		private int currentCryptoKey;

		[SerializeField]
		private int hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private int fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredInt(int value)
		{
		}

		public static int Encrypt(int value, int key)
		{
			return default(int);
		}

		public static int Decrypt(int value, int key)
		{
			return default(int);
		}

		public static ObscuredInt FromEncrypted(int encrypted, int key)
		{
			return default(ObscuredInt);
		}

		public static int GenerateKey()
		{
			return default(int);
		}

		public int GetEncrypted(out int key)
		{
			return default(int);
		}

		public void SetEncrypted(int encrypted, int key)
		{
		}

		public int GetDecrypted()
		{
			return default(int);
		}

		public void RandomizeCryptoKey()
		{
		}

		private int InternalDecrypt()
		{
			return default(int);
		}

		public static implicit operator ObscuredInt(int value)
		{
			return default(ObscuredInt);
		}

		public static implicit operator int(ObscuredInt value)
		{
			return default(int);
		}

		public static implicit operator ObscuredFloat(ObscuredInt value)
		{
			return default(ObscuredFloat);
		}

		public static implicit operator ObscuredDouble(ObscuredInt value)
		{
			return default(ObscuredDouble);
		}

		public static explicit operator ObscuredUInt(ObscuredInt value)
		{
			return default(ObscuredUInt);
		}

		public static ObscuredInt operator ++(ObscuredInt input)
		{
			return default(ObscuredInt);
		}

		public static ObscuredInt operator --(ObscuredInt input)
		{
			return default(ObscuredInt);
		}

		private static ObscuredInt Increment(ObscuredInt input, int increment)
		{
			return default(ObscuredInt);
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

		public bool Equals(ObscuredInt obj)
		{
			return default(bool);
		}

		public int CompareTo(ObscuredInt other)
		{
			return default(int);
		}

		public int CompareTo(int other)
		{
			return default(int);
		}

		public int CompareTo(object obj)
		{
			return default(int);
		}

		[Obsolete]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Obsolete]
		public void ApplyNewCryptoKey()
		{
		}

		[Obsolete]
		public static int Encrypt(int value)
		{
			return default(int);
		}

		[Obsolete]
		public static int Decrypt(int value)
		{
			return default(int);
		}

		[Obsolete]
		public static ObscuredInt FromEncrypted(int encrypted)
		{
			return default(ObscuredInt);
		}

		[Obsolete]
		public int GetEncrypted()
		{
			return default(int);
		}

		[Obsolete]
		public void SetEncrypted(int encrypted)
		{
		}
	}
}
