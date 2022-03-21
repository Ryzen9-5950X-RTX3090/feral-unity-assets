using System;
using System.IO;
using System.Runtime.CompilerServices;
using BestHTTP.PlatformSupport.TcpClient.General;

namespace BestHTTP.Connections
{
	public sealed class TCPConnector : IDisposable
	{
		public bool IsConnected
		{
			get
			{
				return default(bool);
			}
		}

		public string NegotiatedProtocol
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

		public TcpClient Client
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

		public Stream TopmostStream
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

		public Stream Stream
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

		public bool LeaveOpen
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Connect(HTTPRequest request)
		{
		}

		public void Close()
		{
		}

		public void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}

		~TCPConnector()
		{
		}
	}
}
