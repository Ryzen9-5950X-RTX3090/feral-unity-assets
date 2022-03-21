using System.Collections;
using Amazon.Runtime.Internal.Util;
using Amazon.Util.Internal.PlatformServices;
using UnityEngine;

namespace Amazon.Runtime.Internal
{
	public class UnityMainThreadDispatcher : MonoBehaviour
	{
		private Amazon.Runtime.Internal.Util.Logger _logger;

		private float _nextUpdateTime;

		private float _updateInterval;

		private NetworkStatus _currentNetworkStatus;

		public void Awake()
		{
		}

		private void Update()
		{
		}

		private void ProcessRequests()
		{
		}

		private IEnumerator InvokeRequest(IUnityHttpRequest request)
		{
			return null;
		}
	}
}
