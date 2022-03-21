using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;

namespace Newtonsoft.Json.Linq
{
	[DefaultMember("Item")]
	public abstract class JToken : IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable, IDynamicMetaObjectProvider
	{
		private class LineInfoAnnotation
		{
			internal readonly int LineNumber;

			internal readonly int LinePosition;

			public LineInfoAnnotation(int lineNumber, int linePosition)
			{
			}
		}

		private JContainer _parent;

		private JToken _previous;

		private JToken _next;

		private object _annotations;

		private static readonly JTokenType[] BooleanTypes;

		private static readonly JTokenType[] NumberTypes;

		private static readonly JTokenType[] BigIntegerTypes;

		private static readonly JTokenType[] StringTypes;

		private static readonly JTokenType[] GuidTypes;

		private static readonly JTokenType[] TimeSpanTypes;

		private static readonly JTokenType[] UriTypes;

		private static readonly JTokenType[] CharTypes;

		private static readonly JTokenType[] DateTimeTypes;

		private static readonly JTokenType[] BytesTypes;

		public JContainer Parent
		{
			[DebuggerStepThrough]
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public JToken Root
		{
			get
			{
				return null;
			}
		}

		public abstract JTokenType Type { get; }

		public abstract bool HasValues { get; }

		public JToken Next
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public JToken Previous
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public string Path
		{
			get
			{
				return null;
			}
		}

		public virtual JToken First
		{
			get
			{
				return null;
			}
		}

		public virtual JToken Last
		{
			get
			{
				return null;
			}
		}

		int IJsonLineInfo.LineNumber
		{
			get
			{
				return default(int);
			}
		}

		int IJsonLineInfo.LinePosition
		{
			get
			{
				return default(int);
			}
		}

		internal abstract JToken CloneToken();

		internal JToken()
		{
		}

		public virtual JEnumerable<JToken> Children()
		{
			return default(JEnumerable<JToken>);
		}

		public void Remove()
		{
		}

		public void Replace(JToken value)
		{
		}

		public abstract void WriteTo(JsonWriter writer, JsonConverter[] converters);

		public override string ToString()
		{
			return null;
		}

		public string ToString(Formatting formatting, JsonConverter[] converters)
		{
			return null;
		}

		private static JValue EnsureValue(JToken value)
		{
			return null;
		}

		private static string GetType(JToken token)
		{
			return null;
		}

		private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable)
		{
			return default(bool);
		}

		public static explicit operator bool(JToken value)
		{
			return default(bool);
		}

		public static explicit operator DateTimeOffset(JToken value)
		{
			return default(DateTimeOffset);
		}

		public static explicit operator bool?(JToken value)
		{
			return null;
		}

		public static explicit operator long(JToken value)
		{
			return default(long);
		}

		public static explicit operator DateTime?(JToken value)
		{
			return null;
		}

		public static explicit operator DateTimeOffset?(JToken value)
		{
			return null;
		}

		public static explicit operator decimal?(JToken value)
		{
			return null;
		}

		public static explicit operator double?(JToken value)
		{
			return null;
		}

		public static explicit operator char?(JToken value)
		{
			return null;
		}

		public static explicit operator int(JToken value)
		{
			return default(int);
		}

		public static explicit operator short(JToken value)
		{
			return default(short);
		}

		[CLSCompliant(false)]
		public static explicit operator ushort(JToken value)
		{
			return default(ushort);
		}

		[CLSCompliant(false)]
		public static explicit operator char(JToken value)
		{
			return default(char);
		}

		public static explicit operator byte(JToken value)
		{
			return default(byte);
		}

		[CLSCompliant(false)]
		public static explicit operator sbyte(JToken value)
		{
			return default(sbyte);
		}

		public static explicit operator int?(JToken value)
		{
			return null;
		}

		public static explicit operator short?(JToken value)
		{
			return null;
		}

		[CLSCompliant(false)]
		public static explicit operator ushort?(JToken value)
		{
			return null;
		}

		public static explicit operator byte?(JToken value)
		{
			return null;
		}

		[CLSCompliant(false)]
		public static explicit operator sbyte?(JToken value)
		{
			return null;
		}

		public static explicit operator DateTime(JToken value)
		{
			return default(DateTime);
		}

		public static explicit operator long?(JToken value)
		{
			return null;
		}

		public static explicit operator float?(JToken value)
		{
			return null;
		}

		public static explicit operator decimal(JToken value)
		{
			return default(decimal);
		}

		[CLSCompliant(false)]
		public static explicit operator uint?(JToken value)
		{
			return null;
		}

		[CLSCompliant(false)]
		public static explicit operator ulong?(JToken value)
		{
			return null;
		}

		public static explicit operator double(JToken value)
		{
			return default(double);
		}

		public static explicit operator float(JToken value)
		{
			return default(float);
		}

		public static explicit operator string(JToken value)
		{
			return null;
		}

		[CLSCompliant(false)]
		public static explicit operator uint(JToken value)
		{
			return default(uint);
		}

		[CLSCompliant(false)]
		public static explicit operator ulong(JToken value)
		{
			return default(ulong);
		}

		public static explicit operator Guid(JToken value)
		{
			return default(Guid);
		}

		public static explicit operator Guid?(JToken value)
		{
			return null;
		}

		public static explicit operator TimeSpan(JToken value)
		{
			return default(TimeSpan);
		}

		public static explicit operator TimeSpan?(JToken value)
		{
			return null;
		}

		public static explicit operator Uri(JToken value)
		{
			return null;
		}

		private static BigInteger ToBigInteger(JToken value)
		{
			return default(BigInteger);
		}

		private static BigInteger? ToBigIntegerNullable(JToken value)
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator()
		{
			return null;
		}

		public JsonReader CreateReader()
		{
			return null;
		}

		public object ToObject(Type objectType)
		{
			return null;
		}

		public object ToObject(Type objectType, JsonSerializer jsonSerializer)
		{
			return null;
		}

		public static JToken ReadFrom(JsonReader reader)
		{
			return null;
		}

		public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}

		internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings)
		{
		}

		internal void SetLineInfo(int lineNumber, int linePosition)
		{
		}

		bool IJsonLineInfo.HasLineInfo()
		{
			return default(bool);
		}

		protected virtual DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return null;
		}

		DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter)
		{
			return null;
		}

		object ICloneable.Clone()
		{
			return null;
		}

		public JToken DeepClone()
		{
			return null;
		}

		public void AddAnnotation(object annotation)
		{
		}

		public T Annotation<T>() where T : class
		{
			return null;
		}
	}
}
