using System;
using System.Collections.Generic;

namespace Gaia.FullSerializer
{
	public struct fsResult
	{
		private static readonly string[] EmptyStringArray;

		private bool _success;

		private List<string> _messages;

		public static fsResult Success;

		public bool Failed
		{
			get
			{
				return default(bool);
			}
		}

		public bool Succeeded
		{
			get
			{
				return default(bool);
			}
		}

		public bool HasWarnings
		{
			get
			{
				return default(bool);
			}
		}

		public Exception AsException
		{
			get
			{
				return null;
			}
		}

		public IEnumerable<string> RawMessages
		{
			get
			{
				return null;
			}
		}

		public string FormattedMessages
		{
			get
			{
				return null;
			}
		}

		public void AddMessage(string message)
		{
		}

		public void AddMessages(fsResult result)
		{
		}

		public fsResult Merge(fsResult other)
		{
			return default(fsResult);
		}

		public static fsResult Warn(string warning)
		{
			return default(fsResult);
		}

		public static fsResult Fail(string warning)
		{
			return default(fsResult);
		}

		public static fsResult operator +(fsResult a, fsResult b)
		{
			return default(fsResult);
		}

		public fsResult AssertSuccess()
		{
			return default(fsResult);
		}

		public fsResult AssertSuccessWithoutWarnings()
		{
			return default(fsResult);
		}
	}
}
