using System;
using System.IO;

namespace ThirdParty.iOS4Unity
{
	public class NSData : NSObject
	{
		private class UnmanagedMemoryStreamWithRef : UnmanagedMemoryStream
		{
			private NSData _data;

			public UnmanagedMemoryStreamWithRef(NSData source)
			{
			}

			protected override void Dispose(bool disposing)
			{
			}
		}

		private static readonly IntPtr _classHandle;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public IntPtr Bytes
		{
			get
			{
				return default(IntPtr);
			}
		}

		public uint Length
		{
			get
			{
				return default(uint);
			}
			set
			{
			}
		}

		public byte this[int index]
		{
			get
			{
				return default(byte);
			}
			set
			{
			}
		}

		static NSData()
		{
		}

		internal NSData(IntPtr handle)
		{
		}

		public static NSData FromArray(byte[] buffer)
		{
			return null;
		}

		public static NSData FromBytes(IntPtr bytes, uint size)
		{
			return null;
		}

		public static NSData FromData(NSData source)
		{
			return null;
		}

		public static NSData FromBytesNoCopy(IntPtr bytes, uint size)
		{
			return null;
		}

		public static NSData FromBytesNoCopy(IntPtr bytes, uint size, bool freeWhenDone)
		{
			return null;
		}

		public static NSData FromFile(string path, NSDataReadingOptions mask, out NSError error)
		{
			return null;
		}

		public static NSData FromFile(string path)
		{
			return null;
		}

		public static NSData FromUrl(string url)
		{
			return null;
		}

		public static NSData FromUrl(string url, NSDataReadingOptions mask, out NSError error)
		{
			return null;
		}

		public bool Save(string path, bool atomically = true)
		{
			return default(bool);
		}

		public Stream AsStream()
		{
			return null;
		}

		public byte[] ToArray()
		{
			return null;
		}
	}
}
