using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace StrayTech
{
	public static class ReflectionExtension
	{
		public static IList<TAttribute> GetCustomAttributes<TAttribute>(this ICustomAttributeProvider toScan, bool inherit = false) where TAttribute : Attribute
		{
			return null;
		}

		public static TAttribute GetCustomAttribute<TAttribute>(this ICustomAttributeProvider toScan, bool inherit = false) where TAttribute : Attribute
		{
			return null;
		}

		public static IList<TAttribute> GetFieldAttributes<TAttribute>(this FieldInfo field, bool inherit = false) where TAttribute : Attribute
		{
			return null;
		}

		public static TAttribute GetFieldAttribute<TAttribute>(this FieldInfo field, bool inherit = false) where TAttribute : Attribute
		{
			return null;
		}

		public static IEnumerable<FieldInfo> GetAllFields(this Type type)
		{
			return null;
		}

		public static void CopyFromOther(this UnityEngine.Object source, UnityEngine.Object target)
		{
		}

		public static void CopyFromOther(this UnityEngine.Object source, UnityEngine.Object target, HashSet<Type> typesToSkip)
		{
		}
	}
}
