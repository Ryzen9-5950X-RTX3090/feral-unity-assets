namespace ICSharpCode.SharpZipLib.Encryption
{
	internal class PkzipClassicCryptoBase
	{
		private uint[] keys;

		protected byte TransformByte()
		{
			return default(byte);
		}

		protected void SetKeys(byte[] keyData)
		{
		}

		protected void UpdateKeys(byte ch)
		{
		}

		protected void Reset()
		{
		}
	}
}
