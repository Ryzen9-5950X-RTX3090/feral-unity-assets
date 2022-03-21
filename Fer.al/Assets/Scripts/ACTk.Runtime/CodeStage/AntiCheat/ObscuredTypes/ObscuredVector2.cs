using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredVector2 : IObscuredType
	{
		[Serializable]
		public struct RawEncryptedVector2
		{
			public int x;

			public int y;
		}

		private static readonly Vector2 Zero;

		[SerializeField]
		private int currentCryptoKey;

		[SerializeField]
		private RawEncryptedVector2 hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private Vector2 fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		public float x
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float y
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float this[int index]
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		private ObscuredVector2(Vector2 value)
		{
		}

		public ObscuredVector2(float x, float y)
		{
		}

		public static RawEncryptedVector2 Encrypt(Vector2 value, int key)
		{
			return default(RawEncryptedVector2);
		}

		public static RawEncryptedVector2 Encrypt(float x, float y, int key)
		{
			return default(RawEncryptedVector2);
		}

		public static Vector2 Decrypt(RawEncryptedVector2 value, int key)
		{
			return default(Vector2);
		}

		public static ObscuredVector2 FromEncrypted(RawEncryptedVector2 encrypted, int key)
		{
			return default(ObscuredVector2);
		}

		public static int GenerateKey()
		{
			return default(int);
		}

		private static bool CompareVectorsWithTolerance(Vector2 vector1, Vector2 vector2)
		{
			return default(bool);
		}

		public RawEncryptedVector2 GetEncrypted(out int key)
		{
			return default(RawEncryptedVector2);
		}

		public void SetEncrypted(RawEncryptedVector2 encrypted, int key)
		{
		}

		public Vector2 GetDecrypted()
		{
			return default(Vector2);
		}

		public void RandomizeCryptoKey()
		{
		}

		private Vector2 InternalDecrypt()
		{
			return default(Vector2);
		}

		public static implicit operator ObscuredVector2(Vector2 value)
		{
			return default(ObscuredVector2);
		}

		public static implicit operator Vector2(ObscuredVector2 value)
		{
			return default(Vector2);
		}

		public static implicit operator Vector3(ObscuredVector2 value)
		{
			return default(Vector3);
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

		[Obsolete]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Obsolete]
		public void ApplyNewCryptoKey()
		{
		}

		[Obsolete]
		public static RawEncryptedVector2 Encrypt(Vector2 value)
		{
			return default(RawEncryptedVector2);
		}

		[Obsolete]
		public static Vector2 Decrypt(RawEncryptedVector2 value)
		{
			return default(Vector2);
		}

		[Obsolete]
		public RawEncryptedVector2 GetEncrypted()
		{
			return default(RawEncryptedVector2);
		}

		[Obsolete]
		public void SetEncrypted(RawEncryptedVector2 encrypted)
		{
		}
	}
}
