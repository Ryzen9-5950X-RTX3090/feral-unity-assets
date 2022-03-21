using System.Text;

namespace Gaia.FullSerializer
{
	public class fsJsonParser
	{
		private int _start;

		private string _input;

		private readonly StringBuilder _cachedStringBuilder;

		private fsResult MakeFailure(string message)
		{
			return default(fsResult);
		}

		private bool TryMoveNext()
		{
			return default(bool);
		}

		private bool HasValue()
		{
			return default(bool);
		}

		private bool HasValue(int offset)
		{
			return default(bool);
		}

		private char Character()
		{
			return default(char);
		}

		private char Character(int offset)
		{
			return default(char);
		}

		private void SkipSpace()
		{
		}

		private bool IsHex(char c)
		{
			return default(bool);
		}

		private uint ParseSingleChar(char c1, uint multipliyer)
		{
			return default(uint);
		}

		private uint ParseUnicode(char c1, char c2, char c3, char c4)
		{
			return default(uint);
		}

		private fsResult TryUnescapeChar(out char escaped)
		{
			return default(fsResult);
		}

		private fsResult TryParseExact(string content)
		{
			return default(fsResult);
		}

		private fsResult TryParseTrue(out fsData data)
		{
			return default(fsResult);
		}

		private fsResult TryParseFalse(out fsData data)
		{
			return default(fsResult);
		}

		private fsResult TryParseNull(out fsData data)
		{
			return default(fsResult);
		}

		private bool IsSeparator(char c)
		{
			return default(bool);
		}

		private fsResult TryParseNumber(out fsData data)
		{
			return default(fsResult);
		}

		private fsResult TryParseString(out string str)
		{
			return default(fsResult);
		}

		private fsResult TryParseArray(out fsData arr)
		{
			return default(fsResult);
		}

		private fsResult TryParseObject(out fsData obj)
		{
			return default(fsResult);
		}

		private fsResult RunParse(out fsData data)
		{
			return default(fsResult);
		}

		public static fsResult Parse(string input, out fsData data)
		{
			return default(fsResult);
		}

		public static fsData Parse(string input)
		{
			return null;
		}

		private fsJsonParser(string input)
		{
		}
	}
}
