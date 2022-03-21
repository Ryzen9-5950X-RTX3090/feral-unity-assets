using System;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredChar : IObscuredType, IEquatable<ObscuredChar>, IComparable<ObscuredChar>, IComparable<char>, IComparable
	{
		private char currentCryptoKey;

		private char hiddenValue;

		private bool inited;

		private char fakeValue;

		private bool fakeValueActive;

		private ObscuredChar(char value)
		{
		}

		public static char Encrypt(char value, char key)
		{
			return default(char);
		}

		public static char Decrypt(char value, char key)
		{
			return default(char);
		}

		public static ObscuredChar FromEncrypted(char encrypted, char key)
		{
			return default(ObscuredChar);
		}

		public static char GenerateKey()
		{
			return default(char);
		}

		public char GetEncrypted(out char key)
		{
			return default(char);
		}

		public void SetEncrypted(char encrypted, char key)
		{
		}

		public char GetDecrypted()
		{
			return default(char);
		}

		public void RandomizeCryptoKey()
		{
		}

		private char InternalDecrypt()
		{
			return default(char);
		}

		public static implicit operator ObscuredChar(char value)
		{
			return default(ObscuredChar);
		}

		public static implicit operator char(ObscuredChar value)
		{
			return default(char);
		}

		public static ObscuredChar operator ++(ObscuredChar input)
		{
			return default(ObscuredChar);
		}

		public static ObscuredChar operator --(ObscuredChar input)
		{
			return default(ObscuredChar);
		}

		private static ObscuredChar Increment(ObscuredChar input, int increment)
		{
			return default(ObscuredChar);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public bool Equals(ObscuredChar obj)
		{
			return default(bool);
		}

		public int CompareTo(ObscuredChar other)
		{
			return default(int);
		}

		public int CompareTo(char other)
		{
			return default(int);
		}

		public int CompareTo(object obj)
		{
			return default(int);
		}

		[Obsolete]
		public static void SetNewCryptoKey(char newKey)
		{
		}

		[Obsolete]
		public void ApplyNewCryptoKey()
		{
		}

		[Obsolete]
		public static char EncryptDecrypt(char value)
		{
			return default(char);
		}

		[Obsolete]
		public static char EncryptDecrypt(char value, char key)
		{
			return default(char);
		}

		[Obsolete]
		public static ObscuredChar FromEncrypted(char encrypted)
		{
			return default(ObscuredChar);
		}

		[Obsolete]
		public char GetEncrypted()
		{
			return default(char);
		}

		[Obsolete]
		public void SetEncrypted(char encrypted)
		{
		}
	}
}
