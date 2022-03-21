using System;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredDecimal : IObscuredType, IFormattable, IEquatable<ObscuredDecimal>, IComparable<ObscuredDecimal>, IComparable<decimal>, IComparable
	{
		[StructLayout(LayoutKind.Explicit)]
		private struct DecimalLongBytesUnion
		{
			private decimal d;

			private long l1;

			private long l2;

			private ACTkByte16 b16;

			internal static decimal XorDecimalToDecimal(decimal value, long key)
			{
				return default(decimal);
			}

			internal static ACTkByte16 XorDecimalToB16(decimal value, long key)
			{
				return default(ACTkByte16);
			}

			internal static decimal XorB16ToDecimal(ACTkByte16 value, long key)
			{
				return default(decimal);
			}

			internal static decimal ConvertB16ToDecimal(ACTkByte16 value)
			{
				return default(decimal);
			}

			internal static ACTkByte16 ConvertDecimalToB16(decimal value)
			{
				return default(ACTkByte16);
			}

			private static DecimalLongBytesUnion FromDecimal(decimal value)
			{
				return default(DecimalLongBytesUnion);
			}

			private static DecimalLongBytesUnion FromB16(ACTkByte16 value)
			{
				return default(DecimalLongBytesUnion);
			}

			private DecimalLongBytesUnion XorLongs(long key)
			{
				return default(DecimalLongBytesUnion);
			}
		}

		[SerializeField]
		private long currentCryptoKey;

		[SerializeField]
		private ACTkByte16 hiddenValue;

		[SerializeField]
		private bool inited;

		private decimal fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredDecimal(decimal value)
		{
		}

		public static decimal Encrypt(decimal value, long key)
		{
			return default(decimal);
		}

		public static decimal Decrypt(decimal value, long key)
		{
			return default(decimal);
		}

		public static ObscuredDecimal FromEncrypted(decimal encrypted, long key)
		{
			return default(ObscuredDecimal);
		}

		public static long GenerateKey()
		{
			return default(long);
		}

		public decimal GetEncrypted(out long key)
		{
			return default(decimal);
		}

		public void SetEncrypted(decimal encrypted, long key)
		{
		}

		public decimal GetDecrypted()
		{
			return default(decimal);
		}

		public void RandomizeCryptoKey()
		{
		}

		private static ACTkByte16 InternalEncrypt(decimal value, long key)
		{
			return default(ACTkByte16);
		}

		private decimal InternalDecrypt()
		{
			return default(decimal);
		}

		public static implicit operator ObscuredDecimal(decimal value)
		{
			return default(ObscuredDecimal);
		}

		public static implicit operator decimal(ObscuredDecimal value)
		{
			return default(decimal);
		}

		public static explicit operator ObscuredDecimal(ObscuredFloat f)
		{
			return default(ObscuredDecimal);
		}

		public static ObscuredDecimal operator ++(ObscuredDecimal input)
		{
			return default(ObscuredDecimal);
		}

		public static ObscuredDecimal operator --(ObscuredDecimal input)
		{
			return default(ObscuredDecimal);
		}

		private static ObscuredDecimal Increment(ObscuredDecimal input, decimal increment)
		{
			return default(ObscuredDecimal);
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

		public bool Equals(ObscuredDecimal obj)
		{
			return default(bool);
		}

		public int CompareTo(ObscuredDecimal other)
		{
			return default(int);
		}

		public int CompareTo(decimal other)
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
		public static decimal Encrypt(decimal value)
		{
			return default(decimal);
		}

		[Obsolete]
		public static decimal Decrypt(decimal value)
		{
			return default(decimal);
		}

		[Obsolete]
		public static ObscuredDecimal FromEncrypted(decimal encrypted)
		{
			return default(ObscuredDecimal);
		}

		[Obsolete]
		public decimal GetEncrypted()
		{
			return default(decimal);
		}

		[Obsolete]
		public void SetEncrypted(decimal encrypted)
		{
		}
	}
}
