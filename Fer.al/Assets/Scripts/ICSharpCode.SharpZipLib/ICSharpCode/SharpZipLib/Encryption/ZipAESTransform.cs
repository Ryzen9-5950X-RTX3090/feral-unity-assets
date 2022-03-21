using System;
using System.Security.Cryptography;

namespace ICSharpCode.SharpZipLib.Encryption
{
	internal class ZipAESTransform : ICryptoTransform, IDisposable
	{
		private int _blockSize;

		private ICryptoTransform _encryptor;

		private readonly byte[] _counterNonce;

		private byte[] _encryptBuffer;

		private int _encrPos;

		private byte[] _pwdVerifier;

		private HMACSHA1 _hmacsha1;

		private bool _finalised;

		private bool _writeMode;

		public byte[] PwdVerifier
		{
			get
			{
				return null;
			}
		}

		public int InputBlockSize
		{
			get
			{
				return default(int);
			}
		}

		public int OutputBlockSize
		{
			get
			{
				return default(int);
			}
		}

		public bool CanTransformMultipleBlocks
		{
			get
			{
				return default(bool);
			}
		}

		public bool CanReuseTransform
		{
			get
			{
				return default(bool);
			}
		}

		public ZipAESTransform(string key, byte[] saltBytes, int blockSize, bool writeMode)
		{
		}

		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			return default(int);
		}

		public byte[] GetAuthCode()
		{
			return null;
		}

		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			return null;
		}

		public void Dispose()
		{
		}
	}
}
