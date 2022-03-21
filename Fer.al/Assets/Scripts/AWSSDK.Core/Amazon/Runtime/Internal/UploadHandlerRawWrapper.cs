using System;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime.Internal
{
	public class UploadHandlerRawWrapper : IDisposable
	{
		private static Type uploadHandlerRawType;

		private bool disposedValue;

		public object Instance
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

		static UploadHandlerRawWrapper()
		{
		}

		public UploadHandlerRawWrapper(byte[] data)
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public void Dispose()
		{
		}
	}
}
