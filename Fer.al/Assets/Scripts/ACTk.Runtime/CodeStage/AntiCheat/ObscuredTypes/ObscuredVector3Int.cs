using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredVector3Int : IObscuredType
	{
		[Serializable]
		public struct RawEncryptedVector3Int
		{
			public int x;

			public int y;

			public int z;
		}

		private static readonly Vector3Int Zero;

		[SerializeField]
		private int currentCryptoKey;

		[SerializeField]
		private RawEncryptedVector3Int hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private Vector3Int fakeValue;

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

		public int z
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

		private ObscuredVector3Int(Vector3Int value)
		{
		}

		public ObscuredVector3Int(int x, int y, int z)
		{
		}

		public static RawEncryptedVector3Int Encrypt(Vector3Int value, int key)
		{
			return default(RawEncryptedVector3Int);
		}

		public static RawEncryptedVector3Int Encrypt(int x, int y, int z, int key)
		{
			return default(RawEncryptedVector3Int);
		}

		public static Vector3Int Decrypt(RawEncryptedVector3Int value, int key)
		{
			return default(Vector3Int);
		}

		public static ObscuredVector3Int FromEncrypted(RawEncryptedVector3Int encrypted, int key)
		{
			return default(ObscuredVector3Int);
		}

		public static int GenerateKey()
		{
			return default(int);
		}

		public RawEncryptedVector3Int GetEncrypted(out int key)
		{
			return default(RawEncryptedVector3Int);
		}

		public void SetEncrypted(RawEncryptedVector3Int encrypted, int key)
		{
		}

		public Vector3Int GetDecrypted()
		{
			return default(Vector3Int);
		}

		public void RandomizeCryptoKey()
		{
		}

		private Vector3Int InternalDecrypt()
		{
			return default(Vector3Int);
		}

		public static implicit operator ObscuredVector3Int(Vector3Int value)
		{
			return default(ObscuredVector3Int);
		}

		public static implicit operator Vector3Int(ObscuredVector3Int value)
		{
			return default(Vector3Int);
		}

		public static implicit operator Vector3(ObscuredVector3Int value)
		{
			return default(Vector3);
		}

		public static ObscuredVector3Int operator +(ObscuredVector3Int a, ObscuredVector3Int b)
		{
			return default(ObscuredVector3Int);
		}

		public static ObscuredVector3Int operator +(Vector3Int a, ObscuredVector3Int b)
		{
			return default(ObscuredVector3Int);
		}

		public static ObscuredVector3Int operator +(ObscuredVector3Int a, Vector3Int b)
		{
			return default(ObscuredVector3Int);
		}

		public static ObscuredVector3Int operator -(ObscuredVector3Int a, ObscuredVector3Int b)
		{
			return default(ObscuredVector3Int);
		}

		public static ObscuredVector3Int operator -(Vector3Int a, ObscuredVector3Int b)
		{
			return default(ObscuredVector3Int);
		}

		public static ObscuredVector3Int operator -(ObscuredVector3Int a, Vector3Int b)
		{
			return default(ObscuredVector3Int);
		}

		public static ObscuredVector3Int operator *(ObscuredVector3Int a, int d)
		{
			return default(ObscuredVector3Int);
		}

		public static bool operator ==(ObscuredVector3Int lhs, ObscuredVector3Int rhs)
		{
			return default(bool);
		}

		public static bool operator ==(Vector3Int lhs, ObscuredVector3Int rhs)
		{
			return default(bool);
		}

		public static bool operator ==(ObscuredVector3Int lhs, Vector3Int rhs)
		{
			return default(bool);
		}

		public static bool operator !=(ObscuredVector3Int lhs, ObscuredVector3Int rhs)
		{
			return default(bool);
		}

		public static bool operator !=(Vector3Int lhs, ObscuredVector3Int rhs)
		{
			return default(bool);
		}

		public static bool operator !=(ObscuredVector3Int lhs, Vector3Int rhs)
		{
			return default(bool);
		}

		public override bool Equals(object other)
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
		public static RawEncryptedVector3Int Encrypt(Vector3Int value)
		{
			return default(RawEncryptedVector3Int);
		}

		[Obsolete]
		public static Vector3Int Decrypt(RawEncryptedVector3Int value)
		{
			return default(Vector3Int);
		}

		[Obsolete]
		public RawEncryptedVector3Int GetEncrypted()
		{
			return default(RawEncryptedVector3Int);
		}

		[Obsolete]
		public void SetEncrypted(RawEncryptedVector3Int encrypted)
		{
		}
	}
}
