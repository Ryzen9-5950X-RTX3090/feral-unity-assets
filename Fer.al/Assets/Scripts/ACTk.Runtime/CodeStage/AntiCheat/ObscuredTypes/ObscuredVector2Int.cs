using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredVector2Int : IObscuredType
	{
		[Serializable]
		public struct RawEncryptedVector2Int
		{
			public int x;

			public int y;
		}

		private static readonly Vector2Int Zero;

		[SerializeField]
		private int currentCryptoKey;

		[SerializeField]
		private RawEncryptedVector2Int hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private Vector2Int fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		public int x
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int y
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int this[int index]
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		private ObscuredVector2Int(Vector2Int value)
		{
		}

		public ObscuredVector2Int(int x, int y)
		{
		}

		public static RawEncryptedVector2Int Encrypt(Vector2Int value, int key)
		{
			return default(RawEncryptedVector2Int);
		}

		public static RawEncryptedVector2Int Encrypt(int x, int y, int key)
		{
			return default(RawEncryptedVector2Int);
		}

		public static Vector2Int Decrypt(RawEncryptedVector2Int value, int key)
		{
			return default(Vector2Int);
		}

		public static ObscuredVector2Int FromEncrypted(RawEncryptedVector2Int encrypted, int key)
		{
			return default(ObscuredVector2Int);
		}

		public static int GenerateKey()
		{
			return default(int);
		}

		public RawEncryptedVector2Int GetEncrypted(out int key)
		{
			return default(RawEncryptedVector2Int);
		}

		public void SetEncrypted(RawEncryptedVector2Int encrypted, int key)
		{
		}

		public Vector2Int GetDecrypted()
		{
			return default(Vector2Int);
		}

		public void RandomizeCryptoKey()
		{
		}

		private Vector2Int InternalDecrypt()
		{
			return default(Vector2Int);
		}

		public static implicit operator ObscuredVector2Int(Vector2Int value)
		{
			return default(ObscuredVector2Int);
		}

		public static implicit operator Vector2Int(ObscuredVector2Int value)
		{
			return default(Vector2Int);
		}

		public static implicit operator Vector2(ObscuredVector2Int value)
		{
			return default(Vector2);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
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
		public static RawEncryptedVector2Int Encrypt(Vector2Int value)
		{
			return default(RawEncryptedVector2Int);
		}

		[Obsolete]
		public static Vector2Int Decrypt(RawEncryptedVector2Int value)
		{
			return default(Vector2Int);
		}

		[Obsolete]
		public RawEncryptedVector2Int GetEncrypted()
		{
			return default(RawEncryptedVector2Int);
		}

		[Obsolete]
		public void SetEncrypted(RawEncryptedVector2Int encrypted)
		{
		}
	}
}
