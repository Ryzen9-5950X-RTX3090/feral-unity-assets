using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Rewired.Libraries.SharpDX
{
	internal sealed class ResultDescriptor
	{
		private static readonly object LockDescriptor;

		private static readonly List<Type> RegisteredDescriptorProvider;

		private static readonly Dictionary<UzlbEXavGoPESIZdELhSmKjMUa, ResultDescriptor> Descriptors;

		public UzlbEXavGoPESIZdELhSmKjMUa Result
		{
			[CompilerGenerated]
			get
			{
				return default(UzlbEXavGoPESIZdELhSmKjMUa);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string Module
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

		public string NativeApiCode
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

		public string ApiCode
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

		public string Description
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ResultDescriptor(UzlbEXavGoPESIZdELhSmKjMUa code, string module, string nativeApiCode, string apiCode, [Optional] string description)
		{
		}

		public bool Equals(ResultDescriptor other)
		{
			return default(bool);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
		}

		public static ResultDescriptor Find(UzlbEXavGoPESIZdELhSmKjMUa result)
		{
			return null;
		}

		private static void AddDescriptorsFromType(Type type)
		{
		}

		private static string GetDescriptionFromResultCode(int resultCode)
		{
			return null;
		}

		private static extern uint FormatMessageW(int dwFlags, IntPtr lpSource, int dwMessageId, int dwLanguageId, ref IntPtr lpBuffer, int nSize, IntPtr Arguments);
	}
}
