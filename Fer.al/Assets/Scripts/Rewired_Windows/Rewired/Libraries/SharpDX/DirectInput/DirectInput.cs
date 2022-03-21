using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Rewired.Utils.Attributes;

namespace Rewired.Libraries.SharpDX.DirectInput
{
	[Guid("bf798031-483a-4da2-aa99-5d64ed369700")]
	internal class DirectInput : DcpKHDPHjqjOAJSikkknHeBBaZZo
	{
		private static class GetDeviceCountHelper
		{
			[UnmanagedFunctionPointer(CallingConvention.StdCall)]
			private unsafe delegate int DirectInputEnumDevicesDelegate(void* deviceInstance, IntPtr data);

			private static DirectInputEnumDevicesDelegate _callback;

			private static IntPtr _callbackPointer;

			private static int _count;

			public static IntPtr callbackPointer
			{
				get
				{
					return default(IntPtr);
				}
			}

			static GetDeviceCountHelper()
			{
			}

			public static int GetCountAndClear()
			{
				return default(int);
			}

			public static void Clear()
			{
			}

			[Rewired.Utils.Attributes.MonoPInvokeCallback(typeof(DirectInputEnumDevicesDelegate))]
			private unsafe static int DirectInputEnumDevicesImpl(void* deviceInstance, IntPtr data)
			{
				return default(int);
			}
		}

		public IList<AWARuLKFrIKzIKknTkXdungFUra> GetDevices()
		{
			return null;
		}

		public IList<AWARuLKFrIKzIKknTkXdungFUra> GetDevices(irBeUaHArjzfFdeYfFNDILPfamaU deviceClass, EijBMMkCKwdFsvoVbRtrqhSAufV deviceEnumFlags)
		{
			return null;
		}

		public int GetDeviceCount(irBeUaHArjzfFdeYfFNDILPfamaU deviceClass, EijBMMkCKwdFsvoVbRtrqhSAufV deviceEnumFlags)
		{
			return default(int);
		}

		private unsafe static extern int CreateDevice_(void* pIDirectInput8, void* rguid, void* lplpDirectInputDevice, void* pUnkOuter);

		private unsafe static extern int EnumDevices_(void* pIDirectInput8, int dwDevType, void* lpCallback, void* pvRef, int dwFlags);

		internal void CreateDevice(Guid arg0, out IntPtr arg1, DcpKHDPHjqjOAJSikkknHeBBaZZo arg2)
		{
		}

		internal void EnumDevices(int arg0, lKGBmPQbRLXnhufbAfVpasHaJVkz arg1, IntPtr arg2, EijBMMkCKwdFsvoVbRtrqhSAufV arg3)
		{
		}
	}
}
