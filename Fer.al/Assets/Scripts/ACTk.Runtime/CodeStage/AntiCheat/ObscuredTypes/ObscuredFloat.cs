using System;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;
using UnityEngine.Serialization;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredFloat : IObscuredType, IFormattable, IEquatable<ObscuredFloat>, IComparable<ObscuredFloat>, IComparable<float>, IComparable
	{
		[StructLayout(LayoutKind.Explicit)]
		internal struct FloatIntBytesUnion
		{
			internal float f;

			internal int i;

			internal ACTkByte4 b4;

			public static int Migrate(int value, byte fromVersion, byte toVersion)
			{
				return default(int);
			}

			internal static int XorFloatToInt(float value, int key)
			{
				return default(int);
			}

			internal static float XorIntToFloat(int value, int key)
			{
				return default(float);
			}

			private static FloatIntBytesUnion FromFloat(float value)
			{
				return default(FloatIntBytesUnion);
			}

			private static FloatIntBytesUnion FromInt(int value)
			{
				return default(FloatIntBytesUnion);
			}

			private FloatIntBytesUnion Shuffle(int key)
			{
				return default(FloatIntBytesUnion);
			}

			private FloatIntBytesUnion UnShuffle(int key)
			{
				return default(FloatIntBytesUnion);
			}
		}

		[SerializeField]
		private int currentCryptoKey;

		[SerializeField]
		private int hiddenValue;

		[SerializeField]
		[FormerlySerializedAs("hiddenValue")]
		private ACTkByte4 hiddenValueOldByte4;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private float fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredFloat(float value)
		{
		}

		public static int Encrypt(float value, int key)
		{
			return default(int);
		}

		public static float Decrypt(int value, int key)
		{
			return default(float);
		}

		public static int MigrateEncrypted(int encrypted, byte fromVersion = 0, byte toVersion = 2)
		{
			return default(int);
		}

		public static ObscuredFloat FromEncrypted(int encrypted, int key)
		{
			return default(ObscuredFloat);
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

		public float GetDecrypted()
		{
			return default(float);
		}

		public void RandomizeCryptoKey()
		{
		}

		private float InternalDecrypt()
		{
			return default(float);
		}

		public static implicit operator ObscuredFloat(float value)
		{
			return default(ObscuredFloat);
		}

		public static implicit operator float(ObscuredFloat value)
		{
			return default(float);
		}

		public static ObscuredFloat operator ++(ObscuredFloat input)
		{
			return default(ObscuredFloat);
		}

		public static ObscuredFloat operator --(ObscuredFloat input)
		{
			return default(ObscuredFloat);
		}

		private static ObscuredFloat Increment(ObscuredFloat input, int increment)
		{
			return default(ObscuredFloat);
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

		public bool Equals(ObscuredFloat obj)
		{
			return default(bool);
		}

		public int CompareTo(ObscuredFloat other)
		{
			return default(int);
		}

		public int CompareTo(float other)
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
		public static int Encrypt(float value)
		{
			return default(int);
		}

		[Obsolete]
		public static float Decrypt(int value)
		{
			return default(float);
		}

		[Obsolete]
		public static ObscuredFloat FromEncrypted(int encrypted)
		{
			return default(ObscuredFloat);
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
