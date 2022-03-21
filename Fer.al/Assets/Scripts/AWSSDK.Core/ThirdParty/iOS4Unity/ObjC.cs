using System;

namespace ThirdParty.iOS4Unity
{
	public static class ObjC
	{
		public static class Libraries
		{
			public static readonly IntPtr Foundation;

			public static readonly IntPtr UIKit;
		}

		private const string timeIntervalSinceReferenceDate = "timeIntervalSinceReferenceDate";

		internal static readonly Selector TimeIntervalSinceReferenceDateSelector;

		private const string absoluteString = "absoluteString";

		internal static readonly Selector AbsoluteStringSelector;

		private const string doubleValue = "doubleValue";

		internal static readonly Selector DoubleValueSelector;

		private const string count = "count";

		internal static readonly Selector CountSelector;

		private const string objectAtIndex = "objectAtIndex:";

		internal static readonly Selector ObjectAtIndexSelector;

		private const string allObjects = "allObjects";

		internal static readonly Selector AllObjectsSelector;

		private const string arrayWithObjects_count = "arrayWithObjects:count:";

		internal static readonly Selector ArrayWithObjects_CountSelector;

		private const string setWithArray = "setWithArray";

		internal static readonly Selector SetWithArraySelector;

		private const string initWithCharacters_length = "initWithCharacters:length:";

		internal static readonly Selector InitWithCharacters_lengthSelector;

		private const string URLWithString = "URLWithString:";

		internal static readonly Selector URLWithStringSelector;

		private const string dateWithTimeIntervalSinceReferenceDate = "dateWithTimeIntervalSinceReferenceDate:";

		internal static readonly Selector DateWithTimeIntervalSinceReferenceDateSelector;

		private const string initWithDouble = "initWithDouble:";

		internal static readonly Selector InitWithDoubleSelector;

		public static extern IntPtr GetSelector(string name);

		public static extern string GetSelectorName(IntPtr selector);

		public static extern IntPtr GetClass(string name);

		public static extern IntPtr AllocateClassPair(IntPtr superclass, string name, int extraBytes);

		public static extern bool AddMethod(IntPtr cls, IntPtr selector, Delegate imp, string types);

		public static extern void MessageSend(IntPtr receiver, IntPtr selector, object arg1);

		public static extern void MessageSend(IntPtr receiver, IntPtr selector);

		public static extern void MessageSend(IntPtr receiver, IntPtr selector, bool arg1);

		public static extern void MessageSend(IntPtr receiver, IntPtr selector, CGSize arg1);

		public static extern void MessageSend(IntPtr receiver, IntPtr selector, IntPtr arg1);

		public static extern void MessageSend(IntPtr receiver, IntPtr selector, CGRect arg1);

		public static extern void MessageSend(IntPtr receiver, IntPtr selector, CGPoint arg1);

		public static extern void MessageSend(IntPtr receiver, IntPtr selector, int arg1);

		public static extern void MessageSend(IntPtr receiver, IntPtr selector, float arg1);

		public static extern void MessageSend(IntPtr receiver, IntPtr selector, string arg1);

		public static extern void MessageSend(IntPtr receiver, IntPtr selector, string arg1, IntPtr arg2);

		public static extern void MessageSend(IntPtr receiver, IntPtr selector, string arg1, int arg2);

		public static extern void MessageSend(IntPtr receiver, IntPtr selector, string arg1, int arg2, IntPtr arg3);

		public static extern void MessageSend(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3);

		public static extern void MessageSend(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3);

		public static extern void MessageSend(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, string arg3, IntPtr arg4);

		public static extern void MessageSend(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, uint arg3, bool arg4);

		public static extern void MessageSend(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);

		public static extern void MessageSend(IntPtr receiver, IntPtr selector, int arg1, bool arg2);

		public static extern void MessageSend(IntPtr receiver, IntPtr selector, bool arg1, bool arg2);

		public static extern void MessageSend(IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2);

		[CLSCompliant(false)]
		public static extern uint MessageSendUInt(IntPtr receiver, IntPtr selector);

		public static extern int MessageSendInt(IntPtr receiver, IntPtr selector);

		public static extern int MessageSendInt(IntPtr receiver, IntPtr selector, string arg1);

		public static extern int MessageSendInt(IntPtr receiver, IntPtr selector, object arg1);

		public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector);

		public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, string arg1);

		public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, CGRect arg1);

		public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, CGSize arg1, bool arg2);

		public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, double arg1);

		public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, int arg1);

		public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, int arg1, bool arg2);

		public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, double arg1, int arg2);

		[CLSCompliant(false)]
		public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, uint arg1);

		public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

		public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

		[CLSCompliant(false)]
		public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2);

		public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);

		public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2);

		[CLSCompliant(false)]
		public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2);

		[CLSCompliant(false)]
		public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, bool arg3);

		public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, string arg1, IntPtr arg2);

		public static extern IntPtr MessageSendIntPtr(IntPtr receiver, IntPtr selector, string arg1, uint arg2, out IntPtr arg3);

		public static extern bool MessageSendBool(IntPtr receiver, IntPtr selector);

		public static extern bool MessageSendBool(IntPtr receiver, IntPtr selector, bool arg1);

		public static extern bool MessageSendBool(IntPtr receiver, IntPtr selector, object arg1);

		public static extern bool MessageSendBool(IntPtr receiver, IntPtr selector, string arg1);

		public static extern bool MessageSendBool(IntPtr receiver, IntPtr selector, string arg1, bool arg2);

		public static extern double MessageSendDouble(IntPtr receiver, IntPtr selector);

		public static extern double MessageSendDouble(IntPtr receiver, IntPtr selector, object arg1);

		public static extern float MessageSendFloat(IntPtr receiver, IntPtr selector);

		public static extern float MessageSendFloat(IntPtr receiver, IntPtr selector, float arg1);

		public static extern object MessageSendDate(IntPtr receiver, IntPtr selector);

		public static extern object MessageSendDate(IntPtr receiver, IntPtr selector, object arg1);

		public static extern string MessageSendString(IntPtr receiver, IntPtr selector, object arg1);

		public static extern string MessageSendString(IntPtr receiver, IntPtr selector);

		public static extern string MessageSendString(IntPtr receiver, IntPtr selector, IntPtr arg1);

		public static extern string MessageSendString(IntPtr receiver, IntPtr selector, int arg1);

		public static extern string MessageSendString(IntPtr receiver, IntPtr selector, double arg1);

		public static extern string MessageSendString(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

		public static extern string MessageSendString(IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);

		public static extern string MessageSendString(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);

		public static string MessageSendString(IntPtr receiver, IntPtr selector, string arg1)
		{
			return null;
		}

		public static string MessageSendString(IntPtr receiver, IntPtr selector, string arg1, string arg2, string arg3)
		{
			return null;
		}

		public static extern IntPtr MessageSendIntPtr_NSUrl(IntPtr receiver, IntPtr selector, string arg1);

		[CLSCompliant(false)]
		public static extern IntPtr MessageSendIntPtr_NSUrl(IntPtr receiver, IntPtr selector, string arg1, uint arg2, out IntPtr arg3);

		public static extern bool MessageSendBool_NSUrl(IntPtr receiver, IntPtr selector, string arg1);

		public static extern CGRect MessageSendCGRect(IntPtr receiver, IntPtr selector);

		[CLSCompliant(false)]
		public static extern CGPoint _MessageSendStretCGPoint(IntPtr receiver, IntPtr selector);

		[CLSCompliant(false)]
		public static extern CGSize _MessageSendStretCGSize(IntPtr receiver, IntPtr selector);

		public static CGSize MessageSendCGSize(IntPtr receiver, string selector)
		{
			return default(CGSize);
		}

		public static CGPoint MessageSendCGPoint(IntPtr receiver, string selector)
		{
			return default(CGPoint);
		}

		private static extern IntPtr dlsym(IntPtr handle, string symbol);

		private static extern IntPtr dlopen(string path, int mode);

		public static string FromNSString(IntPtr handle)
		{
			return null;
		}

		public static DateTime FromNSDate(IntPtr handle)
		{
			return default(DateTime);
		}

		public static string FromNSUrl(IntPtr handle)
		{
			return null;
		}

		public static double FromNSNumber(IntPtr handle)
		{
			return default(double);
		}

		public static string[] FromNSArray(IntPtr handle)
		{
			return null;
		}

		public static string[] FromNSSet(IntPtr handle)
		{
			return null;
		}

		public static T[] FromNSArray<T>(IntPtr handle) where T : NSObject
		{
			return null;
		}

		public static void ReleaseNSArrayItems(IntPtr handle)
		{
		}

		public static T[] FromNSSet<T>(IntPtr handle) where T : NSObject
		{
			return null;
		}

		public static string GetStringConstant(IntPtr handle, string symbol)
		{
			return null;
		}

		public static float GetFloatConstant(IntPtr handle, string symbol)
		{
			return default(float);
		}

		public static IntPtr ToNSArray(IntPtr[] items)
		{
			return default(IntPtr);
		}

		public static IntPtr ToNSArray(NSObject[] items)
		{
			return default(IntPtr);
		}

		public static IntPtr ToNSArray(string[] items)
		{
			return default(IntPtr);
		}

		public static IntPtr ToNSSet(IntPtr[] items)
		{
			return default(IntPtr);
		}

		public static IntPtr ToNSSet(string[] items)
		{
			return default(IntPtr);
		}

		public static IntPtr ToNSString(string str)
		{
			return default(IntPtr);
		}

		public static IntPtr ToNSUrl(string str)
		{
			return default(IntPtr);
		}

		public static IntPtr ToNSDate(DateTime date)
		{
			return default(IntPtr);
		}

		public static IntPtr ToNSNumber(double value)
		{
			return default(IntPtr);
		}

		public static extern void NSLog(IntPtr format, IntPtr args);

		public static void NSLog(string format, object[] args)
		{
		}
	}
}
