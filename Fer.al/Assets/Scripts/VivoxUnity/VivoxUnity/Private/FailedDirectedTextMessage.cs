using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Private
{
	internal class FailedDirectedTextMessage : IFailedDirectedTextMessage
	{
		private Exception _exception;

		public Exception Exception
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AccountId Sender
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

		public string RequestId
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

		public int StatusCode
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public event PropertyChangedEventHandler PropertyChanged
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
	}
}
