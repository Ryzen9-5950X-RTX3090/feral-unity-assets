using System;

namespace Rewired.Utils
{
	public static class EnumTools
	{
		public static string GetName<TEnum>(TEnum value) where TEnum : struct, IComparable, IFormattable
		{
			return null;
		}

		public static bool ConvertByName<TEnumFrom, TEnumTo>(TEnumFrom convertFrom, out TEnumTo value) where TEnumFrom : struct, IFormattable, IComparable where TEnumTo : struct, IFormattable, IComparable
		{
			return default(bool);
		}

		public static int[] GetIntValues(Type enumType)
		{
			return null;
		}

		public static bool IsEnum(Type type)
		{
			return default(bool);
		}

		public static Type GetUnderlyingType(Type type)
		{
			return null;
		}

		public static bool IsValidUnderlyingType(Type underlyingType)
		{
			return default(bool);
		}
	}
}
