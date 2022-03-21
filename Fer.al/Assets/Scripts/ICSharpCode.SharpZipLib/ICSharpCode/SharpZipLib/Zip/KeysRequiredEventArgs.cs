using System;

namespace ICSharpCode.SharpZipLib.Zip
{
	public class KeysRequiredEventArgs : EventArgs
	{
		private string fileName;

		private byte[] key;

		public byte[] Key
		{
			get
			{
				return null;
			}
		}

		public KeysRequiredEventArgs(string name, byte[] keyValue)
		{
		}
	}
}
