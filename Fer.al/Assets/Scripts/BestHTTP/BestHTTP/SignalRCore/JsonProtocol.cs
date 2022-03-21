using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BestHTTP.PlatformSupport.Memory;
using BestHTTP.SignalRCore.Messages;

namespace BestHTTP.SignalRCore
{
	public sealed class JsonProtocol : IProtocol
	{
		public const char Separator = '\u001e';

		public string Name
		{
			get
			{
				return null;
			}
		}

		public TransferModes Type
		{
			get
			{
				return default(TransferModes);
			}
		}

		public IEncoder Encoder
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

		public HubConnection Connection
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

		public JsonProtocol(IEncoder encoder)
		{
		}

		public void ParseMessages(BufferSegment segment, ref List<Message> messages)
		{
		}

		public BufferSegment EncodeMessage(Message message)
		{
			return default(BufferSegment);
		}

		public object[] GetRealArguments(Type[] argTypes, object[] arguments)
		{
			return null;
		}

		public object ConvertTo(Type toType, object obj)
		{
			return null;
		}

		public static BufferSegment WithSeparator(string str)
		{
			return default(BufferSegment);
		}
	}
}
