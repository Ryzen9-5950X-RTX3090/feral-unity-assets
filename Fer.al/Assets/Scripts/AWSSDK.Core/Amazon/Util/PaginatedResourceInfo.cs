using System;
using System.Runtime.CompilerServices;

namespace Amazon.Util
{
	public class PaginatedResourceInfo
	{
		private string tokenRequestPropertyPath;

		private string tokenResponsePropertyPath;

		internal object Client
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

		internal string MethodName
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

		internal object Request
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

		internal string TokenRequestPropertyPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal string TokenResponsePropertyPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal string ItemListPropertyPath
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

		public PaginatedResourceInfo WithClient(object client)
		{
			return null;
		}

		public PaginatedResourceInfo WithMethodName(string methodName)
		{
			return null;
		}

		public PaginatedResourceInfo WithRequest(object request)
		{
			return null;
		}

		public PaginatedResourceInfo WithTokenRequestPropertyPath(string tokenRequestPropertyPath)
		{
			return null;
		}

		public PaginatedResourceInfo WithTokenResponsePropertyPath(string tokenResponsePropertyPath)
		{
			return null;
		}

		public PaginatedResourceInfo WithItemListPropertyPath(string itemListPropertyPath)
		{
			return null;
		}

		internal void Verify()
		{
		}

		private static void VerifyProperty(string propName, Type start, string path, Type expectedType)
		{
		}

		private static void VerifyProperty(string propName, Type start, string path, Type expectedType, bool skipTypecheck)
		{
		}
	}
}
