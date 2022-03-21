using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Tar
{
	public class TarArchive : IDisposable
	{
		private ProgressMessageHandler ProgressMessageEvent;

		private bool keepOldFiles;

		private bool asciiTranslate;

		private string userName;

		private string groupName;

		private TarInputStream tarIn;

		private TarOutputStream tarOut;

		private bool isDisposed;

		protected virtual void OnProgressMessageEvent(TarEntry entry, string message)
		{
		}

		protected TarArchive(TarInputStream stream)
		{
		}

		public static TarArchive CreateInputTarArchive(Stream inputStream)
		{
			return null;
		}

		public static TarArchive CreateInputTarArchive(Stream inputStream, int blockFactor)
		{
			return null;
		}

		public void ExtractContents(string destinationDirectory)
		{
		}

		private void ExtractEntry(string destDir, TarEntry entry)
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public virtual void Close()
		{
		}

		~TarArchive()
		{
		}

		private static void EnsureDirectoryExists(string directoryName)
		{
		}

		private static bool IsBinary(string filename)
		{
			return default(bool);
		}
	}
}
