using System;
using System.Runtime.CompilerServices;
using ThirdParty.Ionic.Zlib;

namespace Amazon.Runtime.EventStreams.Internal
{
	public class EventStreamDecoder : IEventStreamDecoder, IDisposable
	{
		private delegate int ProcessRead(byte[] data, int offset, int length);

		private enum DecoderState
		{
			Start,
			ReadPrelude,
			ProcessPrelude,
			ReadMessage,
			Error
		}

		private ProcessRead[] _stateFns;

		private DecoderState _state;

		private int _currentMessageLength;

		private int _amountBytesRead;

		private byte[] _workingMessage;

		private byte[] _workingBuffer;

		private CrcCalculatorStream _runningChecksumStream;

		private bool disposedValue;

		public object MessageReceivedContext
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public event EventHandler<EventStreamMessageReceivedEventArgs> MessageReceived
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private int Start(byte[] data, int offset, int length)
		{
			return default(int);
		}

		private int ReadPrelude(byte[] data, int offset, int length)
		{
			return default(int);
		}

		private int ProcessPrelude(byte[] data, int offset, int length)
		{
			return default(int);
		}

		private int ReadMessage(byte[] data, int offset, int length)
		{
			return default(int);
		}

		private void ProcessMessage()
		{
		}

		private int Error(byte[] data, int offset, int length)
		{
			return default(int);
		}

		public void ProcessData(byte[] data, int offset, int length)
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public void Dispose()
		{
		}
	}
}
