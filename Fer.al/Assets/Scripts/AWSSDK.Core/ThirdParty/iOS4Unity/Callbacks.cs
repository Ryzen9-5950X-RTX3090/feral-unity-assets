using System;
using System.Collections.Generic;
using AOT;

namespace ThirdParty.iOS4Unity
{
	public static class Callbacks
	{
		private class Methods
		{
			public Action Action;

			public IntPtrHandler ActionIntPtr;

			public IntPtrHandler2 ActionIntPtrIntPtr;

			public IntPtrHandler3 ActionIntPtrIntPtrIntPtr;

			public EventHandler EventHandler;

			public EventHandler<ButtonEventArgs> EventHandlerInt;

			public readonly object Object;

			public Methods(object obj)
			{
			}
		}

		private static readonly Dictionary<string, Delegate> _delegates;

		private static readonly Dictionary<IntPtr, Dictionary<IntPtr, Methods>> _callbacks;

		private static Methods GetMethods(NSObject obj, string selector)
		{
			return null;
		}

		public static void Subscribe(NSObject obj, string selector, IntPtrHandler callback)
		{
		}

		public static void Subscribe(NSObject obj, string selector, EventHandler callback)
		{
		}

		public static void Subscribe(NSObject obj, string selector, EventHandler<ButtonEventArgs> callback)
		{
		}

		public static void Subscribe(NSObject obj, string selector, IntPtrHandler2 callback)
		{
		}

		public static void Subscribe(NSObject obj, string selector, IntPtrHandler3 callback)
		{
		}

		public static void Unsubscribe(NSObject obj, string selector, Action callback)
		{
		}

		public static void Unsubscribe(NSObject obj, string selector, IntPtrHandler callback)
		{
		}

		public static void Unsubscribe(NSObject obj, string selector, IntPtrHandler2 callback)
		{
		}

		public static void Unsubscribe(NSObject obj, string selector, IntPtrHandler3 callback)
		{
		}

		public static void Unsubscribe(NSObject obj, string selector, EventHandler callback)
		{
		}

		public static void Unsubscribe(NSObject obj, string selector, EventHandler<ButtonEventArgs> callback)
		{
		}

		public static void UnsubscribeAll(NSObject obj)
		{
		}

		[MonoPInvokeCallback(typeof(IntPtrHandler3))]
		private static void OnCallback(IntPtr @this, IntPtr selector, IntPtr arg1)
		{
		}

		[MonoPInvokeCallback(typeof(Action<IntPtr, IntPtr, IntPtr, int>))]
		private static void OnCallbackInt(IntPtr @this, IntPtr selector, IntPtr arg1, int arg2)
		{
		}

		[MonoPInvokeCallback(typeof(IntPtrHandler4))]
		private static void OnCallbackIntPtrIntPtr(IntPtr @this, IntPtr selector, IntPtr arg1, IntPtr arg2)
		{
		}

		[MonoPInvokeCallback(typeof(IntPtrHandler5))]
		private static void OnCallbackIntPtrIntPtrIntPtr(IntPtr @this, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3)
		{
		}
	}
}
