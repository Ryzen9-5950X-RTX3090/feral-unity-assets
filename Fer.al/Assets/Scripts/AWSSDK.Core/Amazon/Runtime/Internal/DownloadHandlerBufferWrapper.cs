using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime.Internal
{
	public class DownloadHandlerBufferWrapper : IDisposable
	{
		private static Type downloadHandlerBufferType;

		private static PropertyInfo[] downloadHandlerBufferProperties;

		private static MethodInfo[] downloadHandlerBufferMethods;

		private static PropertyInfo dataProperty;

		private static MethodInfo dataGetMethod;

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

		public byte[] Data
		{
			get
			{
				return null;
			}
		}

		static DownloadHandlerBufferWrapper()
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
