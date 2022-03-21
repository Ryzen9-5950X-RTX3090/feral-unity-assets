using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace VivoxUnity.Private
{
	public class TranscribedMessage : ITranscribedMessage, ITextMessage, IKeyedItemNotifyPropertyChanged<string>, INotifyPropertyChanged
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

		public string Key
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

		public DateTime ReceivedTime
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string Message
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

		public string Language
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

		public IChannelSession ChannelSession
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

		public AccountId Sender
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

		public bool FromSelf
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
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

		public TranscribedMessage(AccountId sender, string message, string key, string language, IChannelSession channelSession, bool fromSelf, [Optional] DateTime? receivedTime)
		{
		}
	}
}
