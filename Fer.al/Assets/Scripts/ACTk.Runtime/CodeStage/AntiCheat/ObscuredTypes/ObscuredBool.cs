using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredBool : IObscuredType, IEquatable<ObscuredBool>, IComparable<ObscuredBool>, IComparable<bool>, IComparable
	{
		[SerializeField]
		private byte currentCryptoKey;

		[SerializeField]
		private int hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private bool fakeValue;

		[SerializeField]
		[FormerlySerializedAs("fakeValueChanged")]
		private bool fakeValueActive;

		private ObscuredBool(bool value)
		{
		}

		public static int Encrypt(bool value, byte key)
		{
			return default(int);
		}

		public static bool Decrypt(int value, byte key)
		{
			return default(bool);
		}

		public static ObscuredBool FromEncrypted(int encrypted, byte key)
		{
			return default(ObscuredBool);
		}

		public static byte GenerateKey()
		{
			return default(byte);
		}

		public int GetEncrypted(out byte key)
		{
			return default(int);
		}

		public void SetEncrypted(int encrypted, byte key)
		{
		}

		public bool GetDecrypted()
		{
			return default(bool);
		}

		public void RandomizeCryptoKey()
		{
		}

		private bool InternalDecrypt()
		{
			return default(bool);
		}

		public static implicit operator ObscuredBool(bool value)
		{
			return default(ObscuredBool);
		}

		public static implicit operator bool(ObscuredBool value)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public bool Equals(ObscuredBool obj)
		{
			return default(bool);
		}

		public int CompareTo(ObscuredBool other)
		{
			return default(int);
		}

		public int CompareTo(bool other)
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
		public static int Encrypt(bool value)
		{
			return default(int);
		}

		[Obsolete]
		public static bool Decrypt(int value)
		{
			return default(bool);
		}

		[Obsolete]
		public static ObscuredBool FromEncrypted(int encrypted)
		{
			return default(ObscuredBool);
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
