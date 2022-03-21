using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using BestHTTP.SignalR.Messages;

namespace BestHTTP.SignalR.Hubs
{
	public class Hub : IHub
	{
		private Dictionary<string, object> state;

		private Dictionary<ulong, ClientMessage> SentMessages;

		private Dictionary<string, OnMethodCallCallbackDelegate> MethodTable;

		private StringBuilder builder;

		public string Name
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

		public Dictionary<string, object> State
		{
			get
			{
				return null;
			}
		}

		Connection IHub.Connection
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

		public event OnMethodCallDelegate OnMethodCall
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

		public Hub(string name)
		{
		}

		public Hub(string name, Connection manager)
		{
		}

		public void On(string method, OnMethodCallCallbackDelegate callback)
		{
		}

		public void Off(string method)
		{
		}

		public bool Call(string method, object[] args)
		{
			return default(bool);
		}

		public bool Call(string method, OnMethodResultDelegate onResult, object[] args)
		{
			return default(bool);
		}

		public bool Call(string method, OnMethodResultDelegate onResult, OnMethodFailedDelegate onResultError, object[] args)
		{
			return default(bool);
		}

		public bool Call(string method, OnMethodResultDelegate onResult, OnMethodProgressDelegate onProgress, object[] args)
		{
			return default(bool);
		}

		public bool Call(string method, OnMethodResultDelegate onResult, OnMethodFailedDelegate onResultError, OnMethodProgressDelegate onProgress, object[] args)
		{
			return default(bool);
		}

		bool IHub.Call(ClientMessage msg)
		{
			return default(bool);
		}

		bool IHub.HasSentMessageId(ulong id)
		{
			return default(bool);
		}

		void IHub.Close()
		{
		}

		void IHub.OnMethod(MethodCallMessage msg)
		{
		}

		void IHub.OnMessage(IServerMessage msg)
		{
		}

		private void MergeState(IDictionary<string, object> state)
		{
		}

		private string BuildMessage(ClientMessage msg)
		{
			return null;
		}
	}
}
