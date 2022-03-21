using System;

namespace ThirdParty.iOS4Unity
{
	public class Selector
	{
		public static readonly IntPtr Init;

		public static readonly IntPtr InitWithCoder;

		public static readonly IntPtr InitWithName;

		public static readonly IntPtr InitWithFrame;

		private static IntPtr MethodSignatureForSelector;

		private static IntPtr FrameLength;

		internal static IntPtr RetainCount;

		internal const string Alloc = "alloc";

		internal const string Release = "release";

		internal const string Retain = "retain";

		internal const string Autorelease = "autorelease";

		internal const string DoesNotRecognizeSelector = "doesNotRecognizeSelector:";

		internal const string PerformSelectorOnMainThreadWithObjectWaitUntilDone = "performSelectorOnMainThread:withObject:waitUntilDone:";

		internal const string PerformSelectorWithObjectAfterDelay = "performSelector:withObject:afterDelay:";

		internal const string UTF8String = "UTF8String";

		internal static IntPtr AllocHandle;

		internal static IntPtr ReleaseHandle;

		internal static IntPtr RetainHandle;

		internal static IntPtr AutoreleaseHandle;

		internal static IntPtr DoesNotRecognizeSelectorHandle;

		internal static IntPtr PerformSelectorOnMainThreadWithObjectWaitUntilDoneHandle;

		internal static IntPtr PerformSelectorWithObjectAfterDelayHandle;

		internal static IntPtr UTF8StringHandle;

		internal IntPtr handle;

		public IntPtr Handle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
		}

		public Selector(IntPtr sel)
		{
		}

		internal Selector(IntPtr sel, bool check)
		{
		}

		public Selector(string name, bool alloc)
		{
		}

		public Selector(string name)
		{
		}

		public static Selector Register(IntPtr handle)
		{
			return null;
		}

		public static Selector FromHandle(IntPtr sel)
		{
			return null;
		}

		private static extern IntPtr sel_getName(IntPtr sel);

		public static extern IntPtr GetHandle(string name);

		private static extern bool sel_isMapped(IntPtr sel);
	}
}
