using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Crosstales.Common.Util
{
	public class CTProcess : IDisposable
	{
		private uint exitCode;

		private CTProcessStartInfo startInfo;

		private EventHandler _onExited;

		private DataReceivedEventHandler _onOutputDataReceived;

		private DataReceivedEventHandler _onErrorDataReceived;

		private IntPtr threadHandle;

		private static readonly FieldInfo[] eventFields;

		private const uint Infinite = uint.MaxValue;

		private const uint CREATE_NO_WINDOW = 134217728u;

		public IntPtr Handle
		{
			[CompilerGenerated]
			get
			{
				return default(IntPtr);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int Id
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CTProcessStartInfo StartInfo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool HasExited
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public uint ExitCode
		{
			get
			{
				return default(uint);
			}
		}

		public DateTime StartTime
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DateTime ExitTime
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public StreamReader StandardOutput
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

		public StreamReader StandardError
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

		public bool isBusy
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public event EventHandler Exited
		{
			add
			{
			}
			remove
			{
			}
		}

		public event DataReceivedEventHandler OutputDataReceived
		{
			add
			{
			}
			remove
			{
			}
		}

		public event DataReceivedEventHandler ErrorDataReceived
		{
			add
			{
			}
			remove
			{
			}
		}

		private void onExited()
		{
		}

		public void Start()
		{
		}

		public void Start(CTProcessStartInfo info)
		{
		}

		public void Kill()
		{
		}

		public void WaitForExit(int milliseconds = 0)
		{
		}

		public void BeginOutputReadLine()
		{
		}

		public void BeginErrorReadLine()
		{
		}

		public void Dispose()
		{
		}

		private void createProcess()
		{
		}

		private void cleanup()
		{
		}

		private void watchStdOut()
		{
		}

		private void watchStdErr()
		{
		}

		private static DataReceivedEventArgs createMockDataReceivedEventArgs(string data)
		{
			return null;
		}
	}
}
