namespace WW.iOS.Xcode.PBX
{
	internal class Parser
	{
		private TokenList tokens;

		private int currPos;

		public Parser(TokenList tokens)
		{
		}

		private int SkipComments(int pos)
		{
			return default(int);
		}

		private int IncInternal(int pos)
		{
			return default(int);
		}

		private int Inc()
		{
			return default(int);
		}

		private TokenType Tok()
		{
			return default(TokenType);
		}

		private void SkipIf(TokenType type)
		{
		}

		private string GetErrorMsg()
		{
			return null;
		}

		public IdentifierAST ParseIdentifier()
		{
			return null;
		}

		public TreeAST ParseTree()
		{
			return null;
		}

		public ArrayAST ParseList()
		{
			return null;
		}

		public KeyValueAST ParseKeyValue()
		{
			return null;
		}

		public ValueAST ParseValue()
		{
			return null;
		}
	}
}
