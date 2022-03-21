using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;

namespace Newtonsoft.Json.Utilities
{
	internal static class ConvertUtils
	{
		internal enum ConvertResult
		{
			Success,
			CannotConvertNull,
			NotInstantiableType,
			NoValidConversion
		}

		private static readonly Dictionary<Type, PrimitiveTypeCode> TypeCodeMap;

		private static readonly TypeInformation[] PrimitiveTypeCodes;

		private static readonly ThreadSafeStore<StructMultiKey<Type, Type>, Func<object, object>> CastConverters;

		public static PrimitiveTypeCode GetTypeCode(Type t)
		{
			return default(PrimitiveTypeCode);
		}

		public static PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum)
		{
			return default(PrimitiveTypeCode);
		}

		public static TypeInformation GetTypeInformation(IConvertible convertable)
		{
			return null;
		}

		public static bool IsConvertible(Type t)
		{
			return default(bool);
		}

		public static TimeSpan ParseTimeSpan(string input)
		{
			return default(TimeSpan);
		}

		private static Func<object, object> CreateCastConverter(StructMultiKey<Type, Type> t)
		{
			return null;
		}

		internal static BigInteger ToBigInteger(object value)
		{
			return default(BigInteger);
		}

		public static object FromBigInteger(BigInteger i, Type targetType)
		{
			return null;
		}

		private static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, out object value)
		{
			return default(bool);
		}

		private static ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, out object value)
		{
			return default(ConvertResult);
		}

		public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType)
		{
			return null;
		}

		private static object EnsureTypeAssignable(object value, Type initialType, Type targetType)
		{
			return null;
		}

		public static bool VersionTryParse(string input, out Version result)
		{
			return default(bool);
		}

		public static bool IsInteger(object value)
		{
			return default(bool);
		}

		public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value)
		{
			return default(ParseResult);
		}

		public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value)
		{
			return default(ParseResult);
		}

		public static ParseResult DecimalTryParse(char[] chars, int start, int length, out decimal value)
		{
			return default(ParseResult);
		}

		public static bool TryConvertGuid(string s, out Guid g)
		{
			return default(bool);
		}

		public static bool TryHexTextToInt(char[] text, int start, int end, out int value)
		{
			return default(bool);
		}
	}
}
