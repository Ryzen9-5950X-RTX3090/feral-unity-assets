using System;
using System.Runtime.CompilerServices;

namespace VivoxUnity
{
	public class VivoxApiException : Exception
	{
		public int StatusCode
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string RequestId
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

		public VivoxApiException(int statusCode)
		{
		}

		public VivoxApiException(int statusCode, string requestId)
		{
		}

		public VivoxApiException(int statusCode, Exception inner)
		{
		}

		public static string GetErrorString(int statusCode)
		{
			return null;
		}
	}
}
