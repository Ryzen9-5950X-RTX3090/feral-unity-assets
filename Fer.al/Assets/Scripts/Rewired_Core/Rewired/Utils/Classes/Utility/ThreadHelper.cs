using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal class ThreadHelper : IDisposable
	{
		private const uint xRrBUqETfTFgVaeKYEwNasRTyVOn = 750u;

		private readonly Stopwatch FKwdqzuvPRrWeVDIWsADAjGZLcc;

		private Thread habGSklQHfgBqWkyroQbBEtCUJR;

		private ManualResetEvent NQkCEnFdUEkdVrBHRrubSmTJhYov;

		private ManualResetEvent AyYfOiGgrSxLTAdlEDUMUXnTRfB;

		private AutoResetEvent ZUTwmekGucOcqyAeKEFNjBjsCTFR;

		private bool poaRiUqiRYcMJhfteEEAaRqPCsRW;

		private bool kjtzKmhFdsTjZhJRubaabYqJdEE;

		private int EIjirRmgaJCksDxFWknrCnPJJoR;

		private bool oIvEaInphknKGxKSxbysjEnjjxS;

		private int pkJsQFNiQkkfIgUtQDfwVaPoHrW;

		private long QFbTemGqrlhUBpGKnAafIoTNkcl;

		private bool yWYbVSTlcEadOIFRRMdhTDkOvtM;

		private int bgjACySmyKYejqcBagxLhFRoWvm;

		private long eHHlqGdDfpiFPGLLImXLQoAQMFBH;

		private uint QmSRtIXiyzFHLjHuiqFwzkmnqKRf;

		private readonly object HdReBjtnDdCBQVuNqrmXmuJmhjA;

		private Queue<Action> FsZxrUpILXAJyOJFwCXhdsnDXWUe;

		private Queue<Action> ysFeBhnBeCcmBfiwVCDZNDnnMNu;

		private bool ArdEqPnNKZivrHMPdsmorqZgTIb;

		private Action nNLdcDapmXavZMwpGvoMFYAzaFVg;

		private Action CBzEsFzeCLGouetFgwrtBUMDQPB;

		private Action UDIMQZSAvHGZVbNSRVCBaqkiUUVA;

		private bool vEblpmllYIOuQHCXVghuIpihdSG;

		public bool isRunning
		{
			get
			{
				return default(bool);
			}
		}

		public bool isStopped
		{
			get
			{
				return default(bool);
			}
		}

		public bool useHighPrecitionTimer
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool useFixedTimeStep
		{
			get
			{
				return default(bool);
			}
		}

		public int fixedTimeStepFPS
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int timeoutMS
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public uint tick
		{
			get
			{
				return default(uint);
			}
		}

		public event Action ThreadUpdateEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private event Action _ThreadStartedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action ThreadStartedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private event Action _ThreadPreStopEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action ThreadPreStopEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static ThreadHelper Create(bool fixedTimeStep = false, int fixedTimeStepFPS = 100, bool useHighPrecisionTimer = false, int timeoutMS = 0)
		{
			return null;
		}

		public static ThreadHelper CreateFixedTimeStep(int timeStepFPS, int timeoutMS = 0)
		{
			return null;
		}

		public static ThreadHelper CreateFixedTimeStep(int timeStepFPS, bool useHighPrecisionTimer = false, int timeoutMS = 0)
		{
			return null;
		}

		private ThreadHelper()
		{
		}

		private ThreadHelper(int timeoutMS)
		{
		}

		private ThreadHelper(int fixedTimeStepFPS, bool useHighPrecisionTimer, int timeoutMS)
		{
		}

		public bool Start(bool wait)
		{
			return default(bool);
		}

		public void Stop(bool wait)
		{
		}

		public bool EnqueueAction(Action action)
		{
			return default(bool);
		}

		public bool InvokeActionSync(Action action)
		{
			return default(bool);
		}

		public void WaitForActionQueueToFinish()
		{
		}

		public void ResetTimeout()
		{
		}

		private void kKSVTjtddAMHJluEODRtunpFBngb()
		{
		}

		private void WeZwFgEsvVCMUMEuZbModzyyPsDT()
		{
		}

		private void xKfhMAjRMTJNkkhhxGNZLpQxWCs()
		{
		}

		private void iSQfPOuvmRjCJIOfvTnBxpTaZSb()
		{
		}

		public void Dispose()
		{
		}

		~ThreadHelper()
		{
		}

		protected void Dispose(bool disposing)
		{
		}

		[Conditional("DEBUG_THREAD_HELPER")]
		private static void jTweAqDZThMkNjABOhuheMWIYxB(object P_0)
		{
		}
	}
}
