using System;

namespace Unity.IO.Compression
{
	internal class DeflaterManaged : IDeflater, IDisposable
	{
		private enum DeflaterState
		{
			NotStarted,
			SlowDownForIncompressible1,
			SlowDownForIncompressible2,
			StartingSmallData,
			CompressThenCheck,
			CheckingForIncompressible,
			HandlingSmallData
		}

		private const int MinBlockSize = 256;

		private const int MaxHeaderFooterGoo = 120;

		private const int CleanCopySize = 8072;

		private const double BadCompressionThreshold = 1.0;

		private FastEncoder deflateEncoder;

		private CopyEncoder copyEncoder;

		private DeflateInput input;

		private OutputBuffer output;

		private DeflaterState processingState;

		private DeflateInput inputFromHistory;

		internal DeflaterManaged()
		{
		}

		private bool NeedsInput()
		{
			return default(bool);
		}

		bool IDeflater.NeedsInput()
		{
			return default(bool);
		}

		void IDeflater.SetInput(byte[] inputBuffer, int startIndex, int count)
		{
		}

		int IDeflater.GetDeflateOutput(byte[] outputBuffer)
		{
			return default(int);
		}

		bool IDeflater.Finish(byte[] outputBuffer, out int bytesRead)
		{
			return default(bool);
		}

		void IDisposable.Dispose()
		{
		}

		protected void Dispose(bool disposing)
		{
		}

		private bool UseCompressed(double ratio)
		{
			return default(bool);
		}

		private void FlushInputWindows()
		{
		}

		private void WriteFinal()
		{
		}
	}
}
