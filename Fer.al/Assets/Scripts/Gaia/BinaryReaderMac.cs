using System.IO;

public class BinaryReaderMac : BinaryReader
{
	public BinaryReaderMac(Stream stream)
	{
	}

	public override ushort ReadUInt16()
	{
		return default(ushort);
	}
}
