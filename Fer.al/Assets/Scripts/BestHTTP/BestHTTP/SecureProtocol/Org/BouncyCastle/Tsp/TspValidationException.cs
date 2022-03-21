using System;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Tsp
{
	[Serializable]
	public class TspValidationException : TspException
	{
		private int failureCode;

		public int FailureCode
		{
			get
			{
				return default(int);
			}
		}

		public TspValidationException(string message)
		{
		}

		public TspValidationException(string message, int failureCode)
		{
		}
	}
}
