using System;
using System.Collections.Generic;

namespace Amazon.Runtime.Internal
{
	public sealed class UnityRequestQueue
	{
		private static readonly UnityRequestQueue _instance;

		private static readonly object _requestsLock;

		private static readonly object _callbacksLock;

		private static readonly object _mainThreadCallbackLock;

		private Queue<IUnityHttpRequest> _requests;

		private Queue<RuntimeAsyncResult> _callbacks;

		private Queue<Action> _mainThreadCallbacks;

		public static UnityRequestQueue Instance
		{
			get
			{
				return null;
			}
		}

		private UnityRequestQueue()
		{
		}

		public void EnqueueRequest(IUnityHttpRequest request)
		{
		}

		public IUnityHttpRequest DequeueRequest()
		{
			return null;
		}

		public void EnqueueCallback(RuntimeAsyncResult asyncResult)
		{
		}

		public RuntimeAsyncResult DequeueCallback()
		{
			return null;
		}

		public void ExecuteOnMainThread(Action action)
		{
		}

		public Action DequeueMainThreadOperation()
		{
			return null;
		}
	}
}
