using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public sealed class ObscuredString : IObscuredType, IComparable<ObscuredString>, IComparable<string>, IComparable
	{
		[SerializeField]
		private string currentCryptoKey;

		[SerializeField]
		private byte[] hiddenValue;

		[SerializeField]
		private char[] cryptoKey;

		[SerializeField]
		private char[] hiddenChars;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private string fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		public int Length
		{
			get
			{
				return default(int);
			}
		}

		public char this[int index]
		{
			get
			{
				return default(char);
			}
		}

		private ObscuredString()
		{
		}

		private ObscuredString(string value)
		{
		}

		public static char[] Encrypt(string value, string key)
		{
			return null;
		}

		public static char[] Encrypt(string value, char[] key)
		{
			return null;
		}

		public static char[] Encrypt(char[] value, char[] key)
		{
			return null;
		}

		public static string Decrypt(char[] value, string key)
		{
			return null;
		}

		public static string Decrypt(char[] value, char[] key)
		{
			return null;
		}

		public static ObscuredString FromEncrypted(char[] encrypted, char[] key)
		{
			return null;
		}

		[Obsolete]
		public static ObscuredString FromEncrypted(string encrypted, string key = "4441")
		{
			return null;
		}

		public static char[] GenerateKey()
		{
			return null;
		}

		public static void GenerateKey(ref char[] arrayToFill)
		{
		}

		[Obsolete]
		public static char[] GenerateKey(char[] arrayToFill)
		{
			return null;
		}

		internal static char[] InternalEncryptDecrypt(char[] value, char[] key)
		{
			return null;
		}

		internal static string EncryptDecryptObsolete(string value, string key)
		{
			return null;
		}

		public char[] GetEncrypted(out char[] key)
		{
			return null;
		}

		public void SetEncrypted(char[] encrypted, char[] key)
		{
		}

		[Obsolete]
		public void SetEncrypted(string encrypted, string key)
		{
		}

		public string GetDecrypted()
		{
			return null;
		}

		public char[] GetDecryptedToChars()
		{
			return null;
		}

		public void RandomizeCryptoKey()
		{
		}

		private string InternalDecryptToString()
		{
			return null;
		}

		private char[] InternalDecrypt()
		{
			return null;
		}

		private bool CompareCharsToString(char[] chars, string s)
		{
			return default(bool);
		}

		internal void MigrateFromACTkV1()
		{
		}

		public static implicit operator ObscuredString(string value)
		{
			return null;
		}

		public static implicit operator string(ObscuredString value)
		{
			return null;
		}

		public static bool operator ==(ObscuredString a, ObscuredString b)
		{
			return default(bool);
		}

		public static bool operator !=(ObscuredString a, ObscuredString b)
		{
			return default(bool);
		}

		public string Substring(int startIndex)
		{
			return null;
		}

		public string Substring(int startIndex, int length)
		{
			return null;
		}

		public bool StartsWith(string value, StringComparison comparisonType = StringComparison.CurrentCulture)
		{
			return default(bool);
		}

		public bool EndsWith(string value, StringComparison comparisonType = StringComparison.CurrentCulture)
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

		public bool Equals(ObscuredString value)
		{
			return default(bool);
		}

		public bool Equals(ObscuredString value, StringComparison comparisonType)
		{
			return default(bool);
		}

		public int CompareTo(ObscuredString other)
		{
			return default(int);
		}

		public int CompareTo(string other)
		{
			return default(int);
		}

		public int CompareTo(object obj)
		{
			return default(int);
		}

		[Obsolete]
		public static void SetNewCryptoKey(string newKey)
		{
		}

		[Obsolete]
		public void ApplyNewCryptoKey()
		{
		}

		[Obsolete]
		public static string EncryptDecrypt(string value)
		{
			return null;
		}

		[Obsolete]
		public static string EncryptDecrypt(string value, string key)
		{
			return null;
		}

		[Obsolete]
		public string GetEncrypted()
		{
			return null;
		}

		[Obsolete]
		public void SetEncrypted(string encrypted)
		{
		}

		internal static string GetStringObsolete(byte[] bytes)
		{
			return null;
		}

		internal static byte[] GetBytesObsolete(string str)
		{
			return null;
		}

		private static bool ArraysEquals(char[] a1, char[] a2)
		{
			return default(bool);
		}
	}
}
