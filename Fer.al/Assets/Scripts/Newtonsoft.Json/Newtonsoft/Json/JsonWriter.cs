using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	public abstract class JsonWriter : IDisposable
	{
		internal enum State
		{
			Start,
			Property,
			ObjectStart,
			Object,
			ArrayStart,
			Array,
			ConstructorStart,
			Constructor,
			Closed,
			Error
		}

		private static readonly State[][] StateArray;

		internal static readonly State[][] StateArrayTempate;

		private List<JsonPosition> _stack;

		private JsonPosition _currentPosition;

		private State _currentState;

		private Formatting _formatting;

		private DateFormatHandling _dateFormatHandling;

		private DateTimeZoneHandling _dateTimeZoneHandling;

		private StringEscapeHandling _stringEscapeHandling;

		private FloatFormatHandling _floatFormatHandling;

		private string _dateFormatString;

		private CultureInfo _culture;

		public bool CloseOutput
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool AutoCompleteOnClose
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected internal int Top
		{
			get
			{
				return default(int);
			}
		}

		public WriteState WriteState
		{
			get
			{
				return default(WriteState);
			}
		}

		internal string ContainerPath
		{
			get
			{
				return null;
			}
		}

		public string Path
		{
			get
			{
				return null;
			}
		}

		public Formatting Formatting
		{
			get
			{
				return default(Formatting);
			}
			set
			{
			}
		}

		public DateFormatHandling DateFormatHandling
		{
			get
			{
				return default(DateFormatHandling);
			}
			set
			{
			}
		}

		public DateTimeZoneHandling DateTimeZoneHandling
		{
			get
			{
				return default(DateTimeZoneHandling);
			}
			set
			{
			}
		}

		public StringEscapeHandling StringEscapeHandling
		{
			get
			{
				return default(StringEscapeHandling);
			}
			set
			{
			}
		}

		public FloatFormatHandling FloatFormatHandling
		{
			get
			{
				return default(FloatFormatHandling);
			}
			set
			{
			}
		}

		public string DateFormatString
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CultureInfo Culture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal static State[][] BuildStateArray()
		{
			return null;
		}

		static JsonWriter()
		{
		}

		internal virtual void OnStringEscapeHandlingChanged()
		{
		}

		internal void UpdateScopeWithFinishedValue()
		{
		}

		private void Push(JsonContainerType value)
		{
		}

		private JsonContainerType Pop()
		{
			return default(JsonContainerType);
		}

		private JsonContainerType Peek()
		{
			return default(JsonContainerType);
		}

		public virtual void Close()
		{
		}

		public virtual void WriteStartObject()
		{
		}

		public virtual void WriteEndObject()
		{
		}

		public virtual void WriteStartArray()
		{
		}

		public virtual void WriteEndArray()
		{
		}

		public virtual void WriteStartConstructor(string name)
		{
		}

		public virtual void WriteEndConstructor()
		{
		}

		public virtual void WritePropertyName(string name)
		{
		}

		public virtual void WritePropertyName(string name, bool escape)
		{
		}

		public virtual void WriteEnd()
		{
		}

		public void WriteToken(JsonReader reader)
		{
		}

		public void WriteToken(JsonReader reader, bool writeChildren)
		{
		}

		public void WriteToken(JsonToken token, object value)
		{
		}

		internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments)
		{
		}

		private int CalculateWriteTokenInitialDepth(JsonReader reader)
		{
			return default(int);
		}

		private int CalculateWriteTokenFinalDepth(JsonReader reader)
		{
			return default(int);
		}

		private void WriteConstructorDate(JsonReader reader)
		{
		}

		private void WriteEnd(JsonContainerType type)
		{
		}

		private void AutoCompleteAll()
		{
		}

		private JsonToken GetCloseTokenForType(JsonContainerType type)
		{
			return default(JsonToken);
		}

		private void AutoCompleteClose(JsonContainerType type)
		{
		}

		private int CalculateLevelsToComplete(JsonContainerType type)
		{
			return default(int);
		}

		private void UpdateCurrentState()
		{
		}

		protected virtual void WriteEnd(JsonToken token)
		{
		}

		protected virtual void WriteIndent()
		{
		}

		protected virtual void WriteValueDelimiter()
		{
		}

		protected virtual void WriteIndentSpace()
		{
		}

		internal void AutoComplete(JsonToken tokenBeingWritten)
		{
		}

		public virtual void WriteNull()
		{
		}

		public virtual void WriteUndefined()
		{
		}

		public virtual void WriteRaw(string json)
		{
		}

		public virtual void WriteRawValue(string json)
		{
		}

		public virtual void WriteValue(string value)
		{
		}

		public virtual void WriteValue(int value)
		{
		}

		[CLSCompliant(false)]
		public virtual void WriteValue(uint value)
		{
		}

		public virtual void WriteValue(long value)
		{
		}

		[CLSCompliant(false)]
		public virtual void WriteValue(ulong value)
		{
		}

		public virtual void WriteValue(float value)
		{
		}

		public virtual void WriteValue(double value)
		{
		}

		public virtual void WriteValue(bool value)
		{
		}

		public virtual void WriteValue(short value)
		{
		}

		[CLSCompliant(false)]
		public virtual void WriteValue(ushort value)
		{
		}

		public virtual void WriteValue(char value)
		{
		}

		public virtual void WriteValue(byte value)
		{
		}

		[CLSCompliant(false)]
		public virtual void WriteValue(sbyte value)
		{
		}

		public virtual void WriteValue(decimal value)
		{
		}

		public virtual void WriteValue(DateTime value)
		{
		}

		public virtual void WriteValue(DateTimeOffset value)
		{
		}

		public virtual void WriteValue(Guid value)
		{
		}

		public virtual void WriteValue(TimeSpan value)
		{
		}

		public virtual void WriteValue(int? value)
		{
		}

		[CLSCompliant(false)]
		public virtual void WriteValue(uint? value)
		{
		}

		public virtual void WriteValue(long? value)
		{
		}

		[CLSCompliant(false)]
		public virtual void WriteValue(ulong? value)
		{
		}

		public virtual void WriteValue(float? value)
		{
		}

		public virtual void WriteValue(double? value)
		{
		}

		public virtual void WriteValue(bool? value)
		{
		}

		public virtual void WriteValue(short? value)
		{
		}

		[CLSCompliant(false)]
		public virtual void WriteValue(ushort? value)
		{
		}

		public virtual void WriteValue(char? value)
		{
		}

		public virtual void WriteValue(byte? value)
		{
		}

		[CLSCompliant(false)]
		public virtual void WriteValue(sbyte? value)
		{
		}

		public virtual void WriteValue(decimal? value)
		{
		}

		public virtual void WriteValue(DateTime? value)
		{
		}

		public virtual void WriteValue(DateTimeOffset? value)
		{
		}

		public virtual void WriteValue(Guid? value)
		{
		}

		public virtual void WriteValue(TimeSpan? value)
		{
		}

		public virtual void WriteValue(byte[] value)
		{
		}

		public virtual void WriteValue(Uri value)
		{
		}

		public virtual void WriteValue(object value)
		{
		}

		public virtual void WriteComment(string text)
		{
		}

		void IDisposable.Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value)
		{
		}

		private static void ResolveConvertibleValue(IConvertible convertible, out PrimitiveTypeCode typeCode, out object value)
		{
		}

		private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value)
		{
			return null;
		}

		protected void SetWriteState(JsonToken token, object value)
		{
		}

		internal void InternalWriteEnd(JsonContainerType container)
		{
		}

		internal void InternalWritePropertyName(string name)
		{
		}

		internal void InternalWriteRaw()
		{
		}

		internal void InternalWriteStart(JsonToken token, JsonContainerType container)
		{
		}

		internal void InternalWriteValue(JsonToken token)
		{
		}

		internal void InternalWriteComment()
		{
		}
	}
}
