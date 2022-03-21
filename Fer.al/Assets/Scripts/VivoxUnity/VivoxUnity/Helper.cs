using System;
using System.Runtime.InteropServices;

namespace VivoxUnity
{
	public class Helper
	{
		public static ulong serialNumber;

		private static readonly DateTime unixEpoch;

		public static vx_message_base_t NextMessage()
		{
			return null;
		}

		private static void CheckInitialized()
		{
		}

		public static string GetLoginToken(string issuer, TimeSpan expiration, string userUri, string key)
		{
			return null;
		}

		public static string GetJoinToken(string issuer, TimeSpan expiration, string userUri, string conferenceUri, string key)
		{
			return null;
		}

		public static string GetMuteForAllToken(string issuer, TimeSpan expiration, string fromUserUri, string userUri, string conferenceUri, string key)
		{
			return null;
		}

		public static string GetTranscriptionToken(string issuer, TimeSpan expiration, string userUri, string conferenceUri, string key)
		{
			return null;
		}

		public static string GetRandomUserId(string prefix)
		{
			return null;
		}

		public static string GetRandomUserIdEx(string prefix, string issuer)
		{
			return null;
		}

		public static string GetRandomChannelUri(string prefix, string realm)
		{
			return null;
		}

		private static int SecondsSinceUnixEpochPlusDuration([Optional] TimeSpan? duration)
		{
			return default(int);
		}
	}
}
