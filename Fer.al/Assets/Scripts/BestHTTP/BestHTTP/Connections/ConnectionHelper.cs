using System;
using System.Runtime.InteropServices;
using BestHTTP.Logger;

namespace BestHTTP.Connections
{
	public static class ConnectionHelper
	{
		public static void HandleResponse(string context, HTTPRequest request, out bool resendRequest, out HTTPConnectionStates proposedConnectionState, ref KeepAliveHeader keepAlive, [Optional] LoggingContext loggingContext1, [Optional] LoggingContext loggingContext2, [Optional] LoggingContext loggingContext3)
		{
		}

		public static bool LoadFromCache(string context, HTTPRequest request, [Optional] LoggingContext loggingContext1, [Optional] LoggingContext loggingContext2, [Optional] LoggingContext loggingContext3)
		{
			return default(bool);
		}

		private static bool LoadFromCache(string context, HTTPRequest request, Uri uri, [Optional] LoggingContext loggingContext1, [Optional] LoggingContext loggingContext2, [Optional] LoggingContext loggingContext3)
		{
			return default(bool);
		}

		public static bool TryLoadAllFromCache(string context, HTTPRequest request, [Optional] LoggingContext loggingContext1, [Optional] LoggingContext loggingContext2, [Optional] LoggingContext loggingContext3)
		{
			return default(bool);
		}

		public static void TryStoreInCache(HTTPRequest request)
		{
		}

		public static Uri GetRedirectUri(HTTPRequest request, string location)
		{
			return null;
		}
	}
}
