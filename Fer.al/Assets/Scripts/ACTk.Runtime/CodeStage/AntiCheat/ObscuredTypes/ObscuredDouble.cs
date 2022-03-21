using System;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;
using UnityEngine.Serialization;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredDouble : IObscuredType, IFormattable, IEquatable<ObscuredDouble>, IComparable<ObscuredDouble>, IComparable<double>, IComparable
	{
		[StructLayout(LayoutKind.Explicit)]
		private struct DoubleLongBytesUnion
		{
			internal double d;

			internal long l;

			internal ACTkByte8 b8;

			internal static long Migrate(long value, byte fromVersion, byte toVersion)
			{
				return default(long);
			}

			internal static long XorDoubleToLong(double value, long key)
			{
				return default(long);
			}

			internal static double XorLongToDouble(long value, long key)
			{
				return default(double);
			}

			private static DoubleLongBytesUnion FromDouble(double value)
			{
				return default(DoubleLongBytesUnion);
			}

			private static DoubleLongBytesUnion FromLong(long value)
			{
				return default(DoubleLongBytesUnion);
			}

			private DoubleLongBytesUnion Shuffle(long key)
			{
				return default(DoubleLongBytesUnion);
			}

			private DoubleLongBytesUnion UnShuffle(long key)
			{
				return default(DoubleLongBytesUnion);
			}
		}

		[SerializeField]
		private long currentCryptoKey;

		[SerializeField]
		private long hiddenValue;

		[SerializeField]
		[FormerlySerializedAs("hiddenValue")]
		private ACTkByte8 hiddenValueOldByte8;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private double fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredDouble(double value)
		{
		}

		public static long Encrypt(double value, long key)
		{
			return default(long);
		}

		public static double Decrypt(long value, long key)
		{
			return default(double);
		}

		public static long MigrateEncrypted(long encrypted, byte fromVersion = 0, byte toVersion = 2)
		{
			return default(long);
		}

		public static ObscuredDouble FromEncrypted(long encrypted, long key)
		{
			return default(ObscuredDouble);
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

		public double GetDecrypted()
		{
			return default(double);
		}

		public void RandomizeCryptoKey()
		{
		}

		private double InternalDecrypt()
		{
			return default(double);
		}

		public static implicit operator ObscuredDouble(double value)
		{
			return default(ObscuredDouble);
		}

		public static implicit operator double(ObscuredDouble value)
		{
			return default(double);
		}

		public static explicit operator ObscuredDouble(ObscuredFloat f)
		{
			return default(ObscuredDouble);
		}

		public static ObscuredDouble operator ++(ObscuredDouble input)
		{
			return default(ObscuredDouble);
		}

		public static ObscuredDouble operator --(ObscuredDouble input)
		{
			return default(ObscuredDouble);
		}

		private static ObscuredDouble Increment(ObscuredDouble input, double increment)
		{
			return default(ObscuredDouble);
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

		public bool Equals(ObscuredDouble obj)
		{
			return default(bool);
		}

		public int CompareTo(ObscuredDouble other)
		{
			return default(int);
		}

		public int CompareTo(double other)
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
		public static long Encrypt(double value)
		{
			return default(long);
		}

		[Obsolete]
		public static double Decrypt(long value)
		{
			return default(double);
		}

		[Obsolete]
		public static ObscuredDouble FromEncrypted(long encrypted)
		{
			return default(ObscuredDouble);
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
