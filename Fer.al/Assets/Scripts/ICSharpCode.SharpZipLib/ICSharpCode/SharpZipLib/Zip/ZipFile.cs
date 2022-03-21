using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace ICSharpCode.SharpZipLib.Zip
{
	[DefaultMember("EntryByIndex")]
	public class ZipFile : IEnumerable, IDisposable
	{
		public delegate void KeysRequiredEventHandler(object sender, KeysRequiredEventArgs e);

		[Flags]
		private enum HeaderTest
		{
			Extract = 1,
			Header = 2
		}

		private class ZipEntryEnumerator : IEnumerator
		{
			private ZipEntry[] array;

			private int index;

			public object Current
			{
				get
				{
					return null;
				}
			}

			public ZipEntryEnumerator(ZipEntry[] entries)
			{
			}

			public void Reset()
			{
			}

			public bool MoveNext()
			{
				return default(bool);
			}
		}

		private class PartialInputStream : Stream
		{
			private ZipFile zipFile_;

			private Stream baseStream_;

			private long start_;

			private long length_;

			private long readPos_;

			private long end_;

			public override long Position
			{
				get
				{
					return default(long);
				}
				set
				{
				}
			}

			public override long Length
			{
				get
				{
					return default(long);
				}
			}

			public override bool CanWrite
			{
				get
				{
					return default(bool);
				}
			}

			public override bool CanSeek
			{
				get
				{
					return default(bool);
				}
			}

			public override bool CanRead
			{
				get
				{
					return default(bool);
				}
			}

			public override bool CanTimeout
			{
				get
				{
					return default(bool);
				}
			}

			public PartialInputStream(ZipFile zipFile, long start, long length)
			{
			}

			public override int ReadByte()
			{
				return default(int);
			}

			public override void Close()
			{
			}

			public override int Read(byte[] buffer, int offset, int count)
			{
				return default(int);
			}

			public override void Write(byte[] buffer, int offset, int count)
			{
			}

			public override void SetLength(long value)
			{
			}

			public override long Seek(long offset, SeekOrigin origin)
			{
				return default(long);
			}

			public override void Flush()
			{
			}
		}

		public KeysRequiredEventHandler KeysRequired;

		private bool isDisposed_;

		private string name_;

		private string comment_;

		private string rawPassword_;

		private Stream baseStream_;

		private bool isStreamOwner;

		private long offsetOfFirstEntry;

		private ZipEntry[] entries_;

		private byte[] key;

		private UseZip64 useZip64_;

		private ArrayList updates_;

		private Hashtable updateIndex_;

		private IArchiveStorage archiveStorage_;

		private IDynamicDataSource updateDataSource_;

		private int bufferSize_;

		private IEntryFactory updateEntryFactory_;

		public string Password
		{
			set
			{
			}
		}

		private bool HaveKeys
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsStreamOwner
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public long Count
		{
			get
			{
				return default(long);
			}
		}

		private void OnKeysRequired(string fileName)
		{
		}

		public ZipFile(FileStream file)
		{
		}

		~ZipFile()
		{
		}

		public void Close()
		{
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}

		public int FindEntry(string name, bool ignoreCase)
		{
			return default(int);
		}

		public Stream GetInputStream(ZipEntry entry)
		{
			return null;
		}

		public Stream GetInputStream(long entryIndex)
		{
			return null;
		}

		private long TestLocalHeader(ZipEntry entry, HeaderTest tests)
		{
			return default(long);
		}

		private void PostUpdateCleanup()
		{
		}

		void IDisposable.Dispose()
		{
		}

		private void DisposeInternal(bool disposing)
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		private ushort ReadLEUshort()
		{
			return default(ushort);
		}

		private uint ReadLEUint()
		{
			return default(uint);
		}

		private ulong ReadLEUlong()
		{
			return default(ulong);
		}

		private long LocateBlockWithSignature(int signature, long endLocation, int minimumBlockSize, int maximumVariableData)
		{
			return default(long);
		}

		private void ReadEntries()
		{
		}

		private long LocateEntry(ZipEntry entry)
		{
			return default(long);
		}

		private Stream CreateAndInitDecryptionStream(Stream baseStream, ZipEntry entry)
		{
			return null;
		}

		private static void CheckClassicPassword(CryptoStream classicCryptoStream, ZipEntry entry)
		{
		}
	}
}
