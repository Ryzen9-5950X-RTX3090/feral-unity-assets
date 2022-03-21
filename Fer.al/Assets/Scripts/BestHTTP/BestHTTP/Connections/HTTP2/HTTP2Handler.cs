using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BestHTTP.Core;
using BestHTTP.Extensions;
using BestHTTP.Logger;

namespace BestHTTP.Connections.HTTP2
{
	public sealed class HTTP2Handler : IHTTPRequestHandler, IDisposable
	{
		private static readonly byte[] MAGIC;

		public const uint MaxValueFor31Bits = 2147483647u;

		private DateTime lastPingSent;

		private TimeSpan pingFrequency;

		public static int RTTBufferCapacity;

		private CircularBuffer<double> rtts;

		private bool isRunning;

		private AutoResetEvent newFrameSignal;

		private ConcurrentQueue<HTTPRequest> requestQueue;

		private List<HTTP2Stream> clientInitiatedStreams;

		private HPACKEncoder HPACKEncoder;

		private ConcurrentQueue<HTTP2FrameHeaderAndPayload> newFrames;

		private List<HTTP2FrameHeaderAndPayload> outgoingFrames;

		private HTTP2SettingsManager settings;

		private uint remoteWindow;

		private DateTime lastInteraction;

		private DateTime goAwaySentAt;

		private HTTPConnection conn;

		private int threadExitCount;

		private long LastStreamId;

		public bool HasCustomRequestProcessor
		{
			get
			{
				return default(bool);
			}
		}

		public KeepAliveHeader KeepAlive
		{
			get
			{
				return null;
			}
		}

		public bool CanProcessMultiple
		{
			get
			{
				return default(bool);
			}
		}

		public double Latency
		{
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public LoggingContext Context
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private TimeSpan MaxGoAwayWaitTime
		{
			get
			{
				return default(TimeSpan);
			}
		}

		public ShutdownTypes ShutdownType
		{
			[CompilerGenerated]
			get
			{
				return default(ShutdownTypes);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public HTTP2Handler(HTTPConnection conn)
		{
		}

		public void Process(HTTPRequest request)
		{
		}

		public void RunHandler()
		{
		}

		private void OnRemoteSettingChanged(HTTP2SettingsRegistry registry, HTTP2Settings setting, uint oldValue, uint newValue)
		{
		}

		private void ReadThread()
		{
		}

		private void TryToCleanup()
		{
		}

		private double CalculateLatency()
		{
			return default(double);
		}

		private HTTP2Stream FindStreamById(uint streamId)
		{
			return null;
		}

		public void Shutdown(ShutdownTypes type)
		{
		}

		public void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}

		~HTTP2Handler()
		{
		}
	}
}
