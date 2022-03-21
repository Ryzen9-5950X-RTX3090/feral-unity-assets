using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using BestHTTP.Logger;
using BestHTTP.PlatformSupport.Memory;
using BestHTTP.SignalRCore.Messages;

namespace BestHTTP.SignalRCore.Transports
{
	internal abstract class TransportBase : ITransport
	{
		protected TransportStates _state;

		protected List<Message> messages;

		protected HubConnection connection;

		private StringBuilder queryBuilder;

		public abstract TransportTypes TransportType { get; }

		public TransferModes TransferMode
		{
			get
			{
				return default(TransferModes);
			}
		}

		public TransportStates State
		{
			get
			{
				return default(TransportStates);
			}
			protected set
			{
			}
		}

		public string ErrorReason
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
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
			protected set
			{
			}
		}

		public event Action<TransportStates, TransportStates> OnStateChanged
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

		internal TransportBase(HubConnection con)
		{
		}

		public abstract void StartConnect();

		public abstract void Send(BufferSegment msg);

		public abstract void StartClose();

		protected string ParseHandshakeResponse(string data)
		{
			return null;
		}

		protected void HandleHandshakeResponse(string data)
		{
		}

		protected Uri BuildUri(Uri baseUri)
		{
			return null;
		}
	}
}
