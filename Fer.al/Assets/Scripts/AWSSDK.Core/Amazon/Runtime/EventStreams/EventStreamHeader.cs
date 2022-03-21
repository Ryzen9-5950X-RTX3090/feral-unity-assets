using System;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime.EventStreams
{
	public class EventStreamHeader : IEventStreamHeader
	{
		private static readonly DateTime _unixEpoch;

		private const int _sizeOfByte = 1;

		private const int _sizeOfInt16 = 2;

		private const int _sizeOfInt32 = 4;

		private const int _sizeOfInt64 = 8;

		private const int _sizeOfGuid = 16;

		[CompilerGenerated]
		private readonly string <Name>k__BackingField;

		public string Name
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public EventStreamHeaderType HeaderType
		{
			[CompilerGenerated]
			get
			{
				return default(EventStreamHeaderType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private object HeaderValue
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

		public EventStreamHeader(string name)
		{
		}

		public static EventStreamHeader FromBuffer(byte[] buffer, int offset, ref int newOffset)
		{
			return null;
		}

		public int WriteToBuffer(byte[] buffer, int offset)
		{
			return default(int);
		}

		public int GetWireSize()
		{
			return default(int);
		}

		public bool AsBool()
		{
			return default(bool);
		}

		public void SetBool(bool value)
		{
		}

		public byte AsByte()
		{
			return default(byte);
		}

		public void SetByte(byte value)
		{
		}

		public short AsInt16()
		{
			return default(short);
		}

		public void SetInt16(short value)
		{
		}

		public int AsInt32()
		{
			return default(int);
		}

		public void SetInt32(int value)
		{
		}

		public long AsInt64()
		{
			return default(long);
		}

		public void SetInt64(long value)
		{
		}

		public byte[] AsByteBuf()
		{
			return null;
		}

		public void SetByteBuf(byte[] value)
		{
		}

		public string AsString()
		{
			return null;
		}

		public void SetString(string value)
		{
		}

		public DateTime AsTimestamp()
		{
			return default(DateTime);
		}

		public void SetTimestamp(DateTime value)
		{
		}

		public Guid AsUUID()
		{
			return default(Guid);
		}

		public void SetUUID(Guid value)
		{
		}
	}
}
