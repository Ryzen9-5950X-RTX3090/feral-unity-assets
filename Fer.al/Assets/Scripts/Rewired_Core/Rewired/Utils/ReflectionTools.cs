using System;
using System.Collections.Generic;
using System.Reflection;

namespace Rewired.Utils
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	public static class ReflectionTools
	{
		[Flags]
		public enum BindingFlags
		{
			IgnoreCase = 1,
			DeclaredOnly = 2,
			Instance = 4,
			Static = 8,
			Public = 0x10,
			NonPublic = 0x20,
			FlattenHierarchy = 0x40
		}

		public static bool IsValueType(Type type)
		{
			return default(bool);
		}

		public static bool IsEnum(Type type)
		{
			return default(bool);
		}

		public static Type GetUnderlyingEnumType(Type enumType)
		{
			return null;
		}

		public static bool IsClass(Type type)
		{
			return default(bool);
		}

		public static bool IsPrimitive(Type type)
		{
			return default(bool);
		}

		public static bool IsArray(Type type)
		{
			return default(bool);
		}

		public static bool DoesTypeImplement(Type type, Type baseOrInterfaceType)
		{
			return default(bool);
		}

		public static bool IsGenericType(Type type)
		{
			return default(bool);
		}

		public static Type[] GetGenericArguments(Type type)
		{
			return null;
		}

		public static IEnumerable<FieldInfo> GetFields(Type type)
		{
			return null;
		}

		public static IEnumerable<FieldInfo> GetFields(Type type, BindingFlags bindingFlags)
		{
			return null;
		}

		public static IEnumerable<PropertyInfo> GetProperties(Type type)
		{
			return null;
		}

		public static IEnumerable<PropertyInfo> GetProperties(Type type, BindingFlags bindingFlags)
		{
			return null;
		}

		public static IEnumerable<MethodInfo> GetMethods(Type type)
		{
			return null;
		}

		public static IEnumerable<MethodInfo> GetMethods(Type type, BindingFlags bindingFlags)
		{
			return null;
		}

		public static bool IsDefined(Type type, Type attributeType, bool inherit)
		{
			return default(bool);
		}

		public static T GetAttribute<T>(Type type, bool inherit) where T : Attribute
		{
			return null;
		}

		internal static bool IsAssemblyLoaded(string assemblyName, bool useShortName, bool ignoreCase)
		{
			return default(bool);
		}

		internal static Type GetTypeInUnityEditorAssembly(string classPath, bool ignoreCase = false)
		{
			return null;
		}

		internal static Type GetTypeInUnityBuildAssembly(string classPath, bool ignoreCase = false)
		{
			return null;
		}

		private static Type QAAFzCNodXgjvQxNteeqEOzuZhvV(string P_0, bool P_1, bool P_2 = false)
		{
			return null;
		}

		internal static Type GetTypeInAssembly(string classPath, string assemblyName, bool ignoreCase = false)
		{
			return null;
		}

		public static TRet GetPrivateField<TRet, T>(T obj, string name)
		{
			return (TRet)null;
		}

		public static TRet GetPrivateProperty<TRet, T>(T obj, string name)
		{
			return (TRet)null;
		}

		public static void SetPrivateField<T>(T obj, string name, object value)
		{
		}

		public static void SetPrivateProperty<T>(T obj, string name, object value)
		{
		}

		public static TRet CallPrivateMethod<TRet, T>(T obj, string name, object[] param)
		{
			return (TRet)null;
		}

		public static MethodInfo GetMethodInfo(Delegate @delegate)
		{
			return null;
		}
	}
}
