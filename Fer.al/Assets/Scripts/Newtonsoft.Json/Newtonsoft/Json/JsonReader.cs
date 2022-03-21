using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json
{
	public abstract class JsonReader : IDisposable
	{
		protected internal enum State
		{
			Start,
			Complete,
			Property,
			ObjectStart,
			Object,
			ArrayStart,
			Array,
			Closed,
			PostValue,
			ConstructorStart,
			Constructor,
			Error,
			Finished
		}

		private JsonToken _tokenType;

		private object _value;

		internal char _quoteChar;

		internal State _currentState;

		private JsonPosition _currentPosition;

		private CultureInfo _culture;

		private DateTimeZoneHandling _dateTimeZoneHandling;

		private int? _maxDepth;

		private bool _hasExceededMaxDepth;

		internal DateParseHandling _dateParseHandling;

		internal FloatParseHandling _floatParseHandling;

		private string _dateFormatString;

		private List<JsonPosition> _stack;

		protected State CurrentState
		{
			get
			{
				return default(State);
			}
		}

		public bool CloseInput
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

		public bool SupportMultipleContent
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

		public DateParseHandling DateParseHandling
		{
			get
			{
				return default(DateParseHandling);
			}
			set
			{
			}
		}

		public FloatParseHandling FloatParseHandling
		{
			get
			{
				return default(FloatParseHandling);
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

		public int? MaxDepth
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual JsonToken TokenType
		{
			get
			{
				return default(JsonToken);
			}
		}

		public virtual object Value
		{
			get
			{
				return null;
			}
		}

		public virtual Type ValueType
		{
			get
			{
				return null;
			}
		}

		public virtual int Depth
		{
			get
			{
				return default(int);
			}
		}

		public virtual string Path
		{
			get
			{
				return null;
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

		internal JsonPosition GetPosition(int depth)
		{
			return default(JsonPosition);
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

		public abstract bool Read();

		public virtual int? ReadAsInt32()
		{
			return null;
		}

		internal int? ReadInt32String(string s)
		{
			return null;
		}

		public virtual string ReadAsString()
		{
			return null;
		}

		public virtual byte[] ReadAsBytes()
		{
			return null;
		}

		internal byte[] ReadArrayIntoByteArray()
		{
			return null;
		}

		private bool ReadArrayElementIntoByteArrayReportDone(List<byte> buffer)
		{
			return default(bool);
		}

		public virtual double? ReadAsDouble()
		{
			return null;
		}

		internal double? ReadDoubleString(string s)
		{
			return null;
		}

		public virtual bool? ReadAsBoolean()
		{
			return null;
		}

		internal bool? ReadBooleanString(string s)
		{
			return null;
		}

		public virtual decimal? ReadAsDecimal()
		{
			return null;
		}

		internal decimal? ReadDecimalString(string s)
		{
			return null;
		}

		public virtual DateTime? ReadAsDateTime()
		{
			return null;
		}

		internal DateTime? ReadDateTimeString(string s)
		{
			return null;
		}

		public virtual DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		internal DateTimeOffset? ReadDateTimeOffsetString(string s)
		{
			return null;
		}

		internal void ReaderReadAndAssert()
		{
		}

		internal JsonReaderException CreateUnexpectedEndException()
		{
			return null;
		}

		internal void ReadIntoWrappedTypeObject()
		{
		}

		public void Skip()
		{
		}

		protected void SetToken(JsonToken newToken)
		{
		}

		protected void SetToken(JsonToken newToken, object value)
		{
		}

		protected void SetToken(JsonToken newToken, object value, bool updateIndex)
		{
		}

		internal void SetPostValueState(bool updateIndex)
		{
		}

		private void UpdateScopeWithFinishedValue()
		{
		}

		private void ValidateEnd(JsonToken endToken)
		{
		}

		protected void SetStateBasedOnCurrent()
		{
		}

		private void SetFinished()
		{
		}

		private JsonContainerType GetTypeForCloseToken(JsonToken token)
		{
			return default(JsonContainerType);
		}

		void IDisposable.Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public virtual void Close()
		{
		}

		internal void ReadAndAssert()
		{
		}

		internal void ReadForTypeAndAssert(JsonContract contract, bool hasConverter)
		{
		}

		internal bool ReadForType(JsonContract contract, bool hasConverter)
		{
			return default(bool);
		}

		internal bool ReadAndMoveToContent()
		{
			return default(bool);
		}

		internal bool MoveToContent()
		{
			return default(bool);
		}

		private JsonToken GetContentToken()
		{
			return default(JsonToken);
		}
	}
}
