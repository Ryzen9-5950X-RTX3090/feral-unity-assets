using System;
using System.Security.Cryptography;

namespace ICSharpCode.SharpZipLib.Encryption
{
	internal class PkzipClassicEncryptCryptoTransform : PkzipClassicCryptoBase, ICryptoTransform, IDisposable
	{
		public bool CanReuseTransform
		{
			get
			{
				return default(bool);
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

		internal PkzipClassicEncryptCryptoTransform(byte[] keyBlock)
		{
		}

		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			return null;
		}

		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			return default(int);
		}

		public void Dispose()
		{
		}
	}
}
