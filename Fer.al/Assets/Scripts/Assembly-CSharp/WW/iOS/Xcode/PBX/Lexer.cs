namespace WW.iOS.Xcode.PBX
{
	internal class Lexer
	{
		private string text;

		private int pos;

		private int length;

		private int line;

		public static TokenList Tokenize(string text)
		{
			return null;
		}

		public void SetText(string text)
		{
		}

		public TokenList ScanAll()
		{
			return null;
		}

		private void UpdateNewlineStats(char ch)
		{
		}

		private void ScanOne(Token tok)
		{
		}

		private void ScanString(Token tok)
		{
		}

		private void ScanQuotedString(Token tok)
		{
		}

		private void ScanMultilineComment(Token tok)
		{
		}

		private void ScanComment(Token tok)
		{
		}

		private bool IsOperator(char ch)
		{
			return default(bool);
		}

		private void ScanOperator(Token tok)
		{
		}

		private void ScanOperatorSpecific(Token tok, TokenType type)
		{
		}
	}
}
