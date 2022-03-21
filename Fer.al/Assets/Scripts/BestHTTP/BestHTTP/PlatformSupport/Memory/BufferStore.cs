using System.Collections.Generic;
using BestHTTP.PlatformSupport.IL2CPP;

namespace BestHTTP.PlatformSupport.Memory
{
	[Il2CppEagerStaticClassConstruction]
	internal struct BufferStore
	{
		public readonly long Size;

		public List<BufferDesc> buffers;

		public BufferStore(long size)
		{
		}

		public BufferStore(long size, byte[] buffer)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
