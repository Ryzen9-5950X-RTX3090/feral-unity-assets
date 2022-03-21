using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BestHTTP.PlatformSupport.Memory;

namespace BestHTTP.SocketIO3
{
	public struct OutgoingPacket
	{
		public bool IsBinary
		{
			get
			{
				return default(bool);
			}
		}

		public string Payload
		{
			[IsReadOnly]
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

		public List<byte[]> Attachements
		{
			[IsReadOnly]
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

		public BufferSegment PayloadData
		{
			[IsReadOnly]
			[CompilerGenerated]
			get
			{
				return default(BufferSegment);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsVolatile
		{
			[IsReadOnly]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
