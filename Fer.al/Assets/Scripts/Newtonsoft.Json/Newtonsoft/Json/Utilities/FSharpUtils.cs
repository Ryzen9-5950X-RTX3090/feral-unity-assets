using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	internal static class FSharpUtils
	{
		private static readonly object Lock;

		private static bool _initialized;

		private static MethodInfo _ofSeq;

		private static Type _mapType;

		private static Assembly FSharpCoreAssembly
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public static MethodCall<object, object> IsUnion
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

		public static MethodCall<object, object> GetUnionCases
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

		public static MethodCall<object, object> PreComputeUnionTagReader
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

		public static MethodCall<object, object> PreComputeUnionReader
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

		public static MethodCall<object, object> PreComputeUnionConstructor
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

		public static Func<object, object> GetUnionCaseInfoDeclaringType
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

		public static Func<object, object> GetUnionCaseInfoName
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

		public static Func<object, object> GetUnionCaseInfoTag
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

		public static MethodCall<object, object> GetUnionCaseInfoFields
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

		public static void EnsureInitialized(Assembly fsharpCoreAssembly)
		{
		}

		private static MethodInfo GetMethodWithNonPublicFallback(Type type, string methodName, BindingFlags bindingFlags)
		{
			return null;
		}

		private static MethodCall<object, object> CreateFSharpFuncCall(Type type, string methodName)
		{
			return null;
		}

		public static ObjectConstructor<object> CreateSeq(Type t)
		{
			return null;
		}

		public static ObjectConstructor<object> CreateMap(Type keyType, Type valueType)
		{
			return null;
		}

		public static ObjectConstructor<object> BuildMapCreator<TKey, TValue>()
		{
			return null;
		}
	}
}
