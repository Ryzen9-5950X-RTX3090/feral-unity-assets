using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredUInt : IObscuredType, IFormattable, IEquatable<ObscuredUInt>, IComparable<ObscuredUInt>, IComparable<uint>, IComparable
	{
		[SerializeField]
		private uint currentCryptoKey;

		[SerializeField]
		private uint hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private uint fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredUInt(uint value)
		{
		}

		public static uint Encrypt(uint value, uint key)
		{
			return default(uint);
		}

		public static uint Decrypt(uint value, uint key)
		{
			return default(uint);
		}

		public static ObscuredUInt FromEncrypted(uint encrypted, uint key)
		{
			return default(ObscuredUInt);
		}

		public static uint GenerateKey()
		{
			return default(uint);
		}

		public uint GetEncrypted(out uint key)
		{
			return default(uint);
		}

		public void SetEncrypted(uint encrypted, uint key)
		{
		}

		public uint GetDecrypted()
		{
			return default(uint);
		}

		public void RandomizeCryptoKey()
		{
		}

		private uint InternalDecrypt()
		{
			return default(uint);
		}

		public static implicit operator ObscuredUInt(uint value)
		{
			return default(ObscuredUInt);
		}

		public static implicit operator uint(ObscuredUInt value)
		{
			return default(uint);
		}

		public static explicit operator ObscuredInt(ObscuredUInt value)
		{
			return default(ObscuredInt);
		}

		public static ObscuredUInt operator ++(ObscuredUInt input)
		{
			return default(ObscuredUInt);
		}

		public static ObscuredUInt operator --(ObscuredUInt input)
		{
			return default(ObscuredUInt);
		}

		private static ObscuredUInt Increment(ObscuredUInt input, int increment)
		{
			return default(ObscuredUInt);
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

		public bool Equals(ObscuredUInt obj)
		{
			return default(bool);
		}

		public int CompareTo(ObscuredUInt other)
		{
			return default(int);
		}

		public int CompareTo(uint other)
		{
			return default(int);
		}

		public int CompareTo(object obj)
		{
			return default(int);
		}

		[Obsolete]
		public static void SetNewCryptoKey(uint newKey)
		{
		}

		[Obsolete]
		public void ApplyNewCryptoKey()
		{
		}

		[Obsolete]
		public static int Encrypt(uint value)
		{
			return default(int);
		}

		[Obsolete]
		public static int Decrypt(uint value)
		{
			return default(int);
		}

		[Obsolete]
		public static ObscuredUInt FromEncrypted(uint encrypted)
		{
			return default(ObscuredUInt);
		}

		[Obsolete]
		public uint GetEncrypted()
		{
			return default(uint);
		}

		[Obsolete]
		public void SetEncrypted(uint encrypted)
		{
		}
	}
}
