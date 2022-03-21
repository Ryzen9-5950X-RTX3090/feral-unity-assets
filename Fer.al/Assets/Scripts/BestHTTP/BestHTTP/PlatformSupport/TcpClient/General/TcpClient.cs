using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace BestHTTP.PlatformSupport.TcpClient.General
{
	public class TcpClient : IDisposable
	{
		private enum Properties : uint
		{
			LingerState = 1u,
			NoDelay = 2u,
			ReceiveBufferSize = 4u,
			ReceiveTimeout = 8u,
			SendBufferSize = 0x10u,
			SendTimeout = 0x20u
		}

		private NetworkStream stream;

		private bool active;

		private Socket client;

		private bool disposed;

		private Properties values;

		private int recv_timeout;

		private int send_timeout;

		private int recv_buffer_size;

		private int send_buffer_size;

		private LingerOption linger_state;

		private bool no_delay;

		protected bool Active
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Socket Client
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Available
		{
			get
			{
				return default(int);
			}
		}

		public bool Connected
		{
			get
			{
				return default(bool);
			}
		}

		public bool ExclusiveAddressUse
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public LingerOption LingerState
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool NoDelay
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int ReceiveBufferSize
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int ReceiveTimeout
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int SendBufferSize
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int SendTimeout
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public TimeSpan ConnectTimeout
		{
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void Init(AddressFamily family)
		{
		}

		public TcpClient()
		{
		}

		public TcpClient(AddressFamily family)
		{
		}

		public TcpClient(IPEndPoint localEP)
		{
		}

		public TcpClient(string hostname, int port)
		{
		}

		public bool IsConnected()
		{
			return default(bool);
		}

		internal void SetTcpClient(Socket s)
		{
		}

		public void Close()
		{
		}

		public void Connect(IPEndPoint remoteEP)
		{
		}

		public void Connect(IPAddress address, int port)
		{
		}

		private void SetOptions()
		{
		}

		public void Connect(string hostname, int port)
		{
		}

		public void Connect(IPAddress[] ipAddresses, int port, HTTPRequest request)
		{
		}

		public void EndConnect(IAsyncResult asyncResult)
		{
		}

		public IAsyncResult BeginConnect(IPAddress address, int port, AsyncCallback requestCallback, object state)
		{
			return null;
		}

		public IAsyncResult BeginConnect(IPAddress[] addresses, int port, AsyncCallback requestCallback, object state)
		{
			return null;
		}

		public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state)
		{
			return null;
		}

		void IDisposable.Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		~TcpClient()
		{
		}

		public Stream GetStream()
		{
			return null;
		}

		private void CheckDisposed()
		{
		}
	}
}
