using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace ThirdParty.Json.LitJson
{
	public class JsonWriter
	{
		private static NumberFormatInfo number_format;

		private WriterContext context;

		private Stack<WriterContext> ctx_stack;

		private bool has_reached_end;

		private char[] hex_seq;

		private int indentation;

		private int indent_value;

		private StringBuilder inst_string_builder;

		private bool pretty_print;

		private bool validate;

		private TextWriter writer;

		public int IndentValue
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool PrettyPrint
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public TextWriter TextWriter
		{
			get
			{
				return null;
			}
		}

		public bool Validate
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		static JsonWriter()
		{
		}

		public JsonWriter()
		{
		}

		public JsonWriter(StringBuilder sb)
		{
		}

		public JsonWriter(TextWriter writer)
		{
		}

		private void DoValidation(Condition cond)
		{
		}

		private void Init()
		{
		}

		private static void IntToHex(int n, char[] hex)
		{
		}

		private void Indent()
		{
		}

		private void Put(string str)
		{
		}

		private void PutNewline()
		{
		}

		private void PutNewline(bool add_comma)
		{
		}

		private void PutString(string str)
		{
		}

		private void Unindent()
		{
		}

		public override string ToString()
		{
			return null;
		}

		public void Reset()
		{
		}

		public void Write(bool boolean)
		{
		}

		public void Write(decimal number)
		{
		}

		public void Write(double number)
		{
		}

		public void Write(int number)
		{
		}

		public void Write(uint number)
		{
		}

		public void Write(long number)
		{
		}

		public void Write(string str)
		{
		}

		public void WriteRaw(string str)
		{
		}

		[CLSCompliant(false)]
		public void Write(ulong number)
		{
		}

		public void Write(DateTime date)
		{
		}

		public void WriteArrayEnd()
		{
		}

		public void WriteArrayStart()
		{
		}

		public void WriteObjectEnd()
		{
		}

		public void WriteObjectStart()
		{
		}

		public void WritePropertyName(string property_name)
		{
		}
	}
}
