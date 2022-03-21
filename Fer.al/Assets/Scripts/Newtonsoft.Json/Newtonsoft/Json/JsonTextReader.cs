using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	public class JsonTextReader : JsonReader, IJsonLineInfo
	{
		private readonly bool _safeAsync;

		private readonly TextReader _reader;

		private char[] _chars;

		private int _charsUsed;

		private int _charPos;

		private int _lineStartPos;

		private int _lineNumber;

		private bool _isEndOfFile;

		private StringBuffer _stringBuffer;

		private StringReference _stringReference;

		private IArrayPool<char> _arrayPool;

		public JsonNameTable PropertyNameTable
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

		public int LineNumber
		{
			get
			{
				return default(int);
			}
		}

		public int LinePosition
		{
			get
			{
				return default(int);
			}
		}

		public JsonTextReader(TextReader reader)
		{
		}

		private void EnsureBufferNotEmpty()
		{
		}

		private void SetNewLine(bool hasNextChar)
		{
		}

		private void OnNewLine(int pos)
		{
		}

		private void ParseString(char quote, ReadType readType)
		{
		}

		private void ParseReadString(char quote, ReadType readType)
		{
		}

		private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count)
		{
		}

		private void ShiftBufferIfNeeded()
		{
		}

		private int ReadData(bool append)
		{
			return default(int);
		}

		private void PrepareBufferForReadData(bool append, int charsRequired)
		{
		}

		private int ReadData(bool append, int charsRequired)
		{
			return default(int);
		}

		private bool EnsureChars(int relativePosition, bool append)
		{
			return default(bool);
		}

		private bool ReadChars(int relativePosition, bool append)
		{
			return default(bool);
		}

		public override bool Read()
		{
			return default(bool);
		}

		public override int? ReadAsInt32()
		{
			return null;
		}

		public override DateTime? ReadAsDateTime()
		{
			return null;
		}

		public override string ReadAsString()
		{
			return null;
		}

		public override byte[] ReadAsBytes()
		{
			return null;
		}

		private object ReadStringValue(ReadType readType)
		{
			return null;
		}

		private object FinishReadQuotedStringValue(ReadType readType)
		{
			return null;
		}

		private JsonReaderException CreateUnexpectedCharacterException(char c)
		{
			return null;
		}

		public override bool? ReadAsBoolean()
		{
			return null;
		}

		private void ProcessValueComma()
		{
		}

		private object ReadNumberValue(ReadType readType)
		{
			return null;
		}

		private object FinishReadQuotedNumber(ReadType readType)
		{
			return null;
		}

		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		public override decimal? ReadAsDecimal()
		{
			return null;
		}

		public override double? ReadAsDouble()
		{
			return null;
		}

		private void HandleNull()
		{
		}

		private void ReadFinished()
		{
		}

		private bool ReadNullChar()
		{
			return default(bool);
		}

		private void EnsureBuffer()
		{
		}

		private void ReadStringIntoBuffer(char quote)
		{
		}

		private void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition)
		{
		}

		private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition)
		{
		}

		private char ConvertUnicode(bool enoughChars)
		{
			return default(char);
		}

		private char ParseUnicode()
		{
			return default(char);
		}

		private void ReadNumberIntoBuffer()
		{
		}

		private bool ReadNumberCharIntoBuffer(char currentChar, int charPos)
		{
			return default(bool);
		}

		private void ClearRecentString()
		{
		}

		private bool ParsePostValue(bool ignoreComments)
		{
			return default(bool);
		}

		private bool ParseObject()
		{
			return default(bool);
		}

		private bool ParseProperty()
		{
			return default(bool);
		}

		private bool ValidIdentifierChar(char value)
		{
			return default(bool);
		}

		private void ParseUnquotedProperty()
		{
		}

		private bool ReadUnquotedPropertyReportIfDone(char currentChar, int initialPosition)
		{
			return default(bool);
		}

		private bool ParseValue()
		{
			return default(bool);
		}

		private void ProcessLineFeed()
		{
		}

		private void ProcessCarriageReturn(bool append)
		{
		}

		private void EatWhitespace()
		{
		}

		private void ParseConstructor()
		{
		}

		private void ParseNumber(ReadType readType)
		{
		}

		private void ParseReadNumber(ReadType readType, char firstChar, int initialPosition)
		{
		}

		private JsonReaderException ThrowReaderError(string message, [Optional] Exception ex)
		{
			return null;
		}

		private static object BigIntegerParse(string number, CultureInfo culture)
		{
			return null;
		}

		private void ParseComment(bool setToken)
		{
		}

		private void EndComment(bool setToken, int initialPosition, int endPosition)
		{
		}

		private bool MatchValue(string value)
		{
			return default(bool);
		}

		private bool MatchValue(bool enoughChars, string value)
		{
			return default(bool);
		}

		private bool MatchValueWithTrailingSeparator(string value)
		{
			return default(bool);
		}

		private bool IsSeparator(char c)
		{
			return default(bool);
		}

		private void ParseTrue()
		{
		}

		private void ParseNull()
		{
		}

		private void ParseUndefined()
		{
		}

		private void ParseFalse()
		{
		}

		private object ParseNumberNegativeInfinity(ReadType readType)
		{
			return null;
		}

		private object ParseNumberNegativeInfinity(ReadType readType, bool matched)
		{
			return null;
		}

		private object ParseNumberPositiveInfinity(ReadType readType)
		{
			return null;
		}

		private object ParseNumberPositiveInfinity(ReadType readType, bool matched)
		{
			return null;
		}

		private object ParseNumberNaN(ReadType readType)
		{
			return null;
		}

		private object ParseNumberNaN(ReadType readType, bool matched)
		{
			return null;
		}

		public override void Close()
		{
		}

		public bool HasLineInfo()
		{
			return default(bool);
		}
	}
}
