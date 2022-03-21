namespace Amazon.Runtime.EventStreams
{
	public enum EventStreamHeaderType : byte
	{
		BoolTrue,
		BoolFalse,
		Byte,
		Int16,
		Int32,
		Int64,
		ByteBuf,
		String,
		Timestamp,
		UUID
	}
}
