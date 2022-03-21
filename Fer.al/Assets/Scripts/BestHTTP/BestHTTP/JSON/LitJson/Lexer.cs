using System.IO;
using System.Text;

namespace BestHTTP.JSON.LitJson
{
	internal sealed class Lexer
	{
		private delegate bool StateHandler(FsmContext ctx);

		private static readonly int[] fsm_return_table;

		private static readonly StateHandler[] fsm_handler_table;

		private bool allow_comments;

		private bool allow_single_quoted_strings;

		private bool end_of_input;

		private FsmContext fsm_context;

		private int input_buffer;

		private int input_char;

		private TextReader reader;

		private int state;

		private StringBuilder string_buffer;

		private string string_value;

		private int token;

		private int unichar;

		public bool AllowComments
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool AllowSingleQuotedStrings
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool EndOfInput
		{
			get
			{
				return default(bool);
			}
		}

		public int Token
		{
			get
			{
				return default(int);
			}
		}

		public string StringValue
		{
			get
			{
				return null;
			}
		}

		static Lexer()
		{
		}

		public Lexer(TextReader reader)
		{
		}

		private static int HexValue(int digit)
		{
			return default(int);
		}

		private static void PopulateFsmTables(out StateHandler[] fsm_handler_table, out int[] fsm_return_table)
		{
		}

		private static char ProcessEscChar(int esc_char)
		{
			return default(char);
		}

		private static bool State1(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State2(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State3(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State4(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State5(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State6(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State7(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State8(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State9(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State10(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State11(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State12(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State13(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State14(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State15(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State16(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State17(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State18(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State19(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State20(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State21(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State22(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State23(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State24(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State25(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State26(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State27(FsmContext ctx)
		{
			return default(bool);
		}

		private static bool State28(FsmContext ctx)
		{
			return default(bool);
		}

		private bool GetChar()
		{
			return default(bool);
		}

		private int NextChar()
		{
			return default(int);
		}

		public bool NextToken()
		{
			return default(bool);
		}

		private void UngetChar()
		{
		}
	}
}
