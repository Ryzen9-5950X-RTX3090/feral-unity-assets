using System;
using System.Dynamic;
using System.Linq.Expressions;
using System.Numerics;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	public class JValue : JToken, IEquatable<JValue>, IFormattable, IComparable, IComparable<JValue>, IConvertible
	{
		private class JValueDynamicProxy : DynamicProxy<JValue>
		{
		}

		private JTokenType _valueType;

		private object _value;

		public override bool HasValues
		{
			get
			{
				return default(bool);
			}
		}

		public override JTokenType Type
		{
			get
			{
				return default(JTokenType);
			}
		}

		public object Value
		{
			get
			{
				return null;
			}
		}

		internal JValue(object value, JTokenType type)
		{
		}

		public JValue(JValue other)
		{
		}

		public JValue(object value)
		{
		}

		private static int CompareBigInteger(BigInteger i1, object i2)
		{
			return default(int);
		}

		internal static int Compare(JTokenType valueType, object objA, object objB)
		{
			return default(int);
		}

		private static int CompareFloat(object objA, object objB)
		{
			return default(int);
		}

		internal override JToken CloneToken()
		{
			return null;
		}

		public static JValue CreateComment(string value)
		{
			return null;
		}

		public static JValue CreateNull()
		{
			return null;
		}

		public static JValue CreateUndefined()
		{
			return null;
		}

		private static JTokenType GetValueType(JTokenType? current, object value)
		{
			return default(JTokenType);
		}

		private static JTokenType GetStringValueType(JTokenType? current)
		{
			return default(JTokenType);
		}

		public override void WriteTo(JsonWriter writer, JsonConverter[] converters)
		{
		}

		private static bool ValuesEquals(JValue v1, JValue v2)
		{
			return default(bool);
		}

		public bool Equals(JValue other)
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

		public string ToString(IFormatProvider formatProvider)
		{
			return null;
		}

		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		protected override DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return null;
		}

		int IComparable.CompareTo(object obj)
		{
			return default(int);
		}

		public int CompareTo(JValue obj)
		{
			return default(int);
		}

		TypeCode IConvertible.GetTypeCode()
		{
			return default(TypeCode);
		}

		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return default(bool);
		}

		char IConvertible.ToChar(IFormatProvider provider)
		{
			return default(char);
		}

		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return default(sbyte);
		}

		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return default(byte);
		}

		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return default(short);
		}

		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return default(ushort);
		}

		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return default(int);
		}

		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return default(uint);
		}

		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return default(long);
		}

		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return default(ulong);
		}

		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return default(float);
		}

		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return default(double);
		}

		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return default(decimal);
		}

		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return default(DateTime);
		}

		object IConvertible.ToType(Type conversionType, IFormatProvider provider)
		{
			return null;
		}
	}
}
