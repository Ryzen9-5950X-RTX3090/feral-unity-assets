using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.Runtime
{
	public abstract class AmazonWebServiceRequest : IAmazonWebServiceRequest
	{
		internal RequestEventHandler mBeforeRequestEvent;

		private Dictionary<string, object> requestState;

		EventHandler<StreamTransferProgressArgs> IAmazonWebServiceRequest.StreamUploadProgressCallback
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

		Dictionary<string, object> IAmazonWebServiceRequest.RequestState
		{
			get
			{
				return null;
			}
		}

		bool IAmazonWebServiceRequest.UseSigV4
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

		protected virtual bool Expect100Continue
		{
			get
			{
				return default(bool);
			}
		}

		protected virtual bool IncludeSHA256Header
		{
			get
			{
				return default(bool);
			}
		}

		internal event RequestEventHandler BeforeRequestEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		void IAmazonWebServiceRequest.AddBeforeRequestHandler(RequestEventHandler handler)
		{
		}

		void IAmazonWebServiceRequest.RemoveBeforeRequestHandler(RequestEventHandler handler)
		{
		}

		internal void FireBeforeRequestEvent(object sender, RequestEventArgs args)
		{
		}

		internal bool GetExpect100Continue()
		{
			return default(bool);
		}

		internal bool GetIncludeSHA256Header()
		{
			return default(bool);
		}

		protected virtual AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		internal AbstractAWSSigner GetSigner()
		{
			return null;
		}
	}
}
