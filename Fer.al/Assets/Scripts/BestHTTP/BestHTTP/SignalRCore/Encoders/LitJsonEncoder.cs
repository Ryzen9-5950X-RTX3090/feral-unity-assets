using System;
using BestHTTP.PlatformSupport.Memory;

namespace BestHTTP.SignalRCore.Encoders
{
	public sealed class LitJsonEncoder : IEncoder
	{
		public T DecodeAs<T>(BufferSegment buffer)
		{
			return (T)null;
		}

		public BufferSegment Encode<T>(T value)
		{
			return default(BufferSegment);
		}

		public object ConvertTo(Type toType, object obj)
		{
			return null;
		}
	}
}
