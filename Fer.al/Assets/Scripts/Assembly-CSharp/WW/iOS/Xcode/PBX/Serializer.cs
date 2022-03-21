using System.Text;

namespace WW.iOS.Xcode.PBX
{
	internal class Serializer
	{
		private static string k_Indent;

		public static PBXElementDict ParseTreeAST(TreeAST ast, TokenList tokens, string text)
		{
			return null;
		}

		public static PBXElementArray ParseArrayAST(ArrayAST ast, TokenList tokens, string text)
		{
			return null;
		}

		public static PBXElement ParseValueAST(ValueAST ast, TokenList tokens, string text)
		{
			return null;
		}

		public static PBXElementString ParseIdentifierAST(IdentifierAST ast, TokenList tokens, string text)
		{
			return null;
		}

		private static string GetIndent(int indent)
		{
			return null;
		}

		private static void WriteStringImpl(StringBuilder sb, string s, bool comment, GUIDToCommentMap comments)
		{
		}

		public static void WriteDictKeyValue(StringBuilder sb, string key, PBXElement value, int indent, bool compact, PropertyCommentChecker checker, GUIDToCommentMap comments)
		{
		}

		public static void WriteDict(StringBuilder sb, PBXElementDict el, int indent, bool compact, PropertyCommentChecker checker, GUIDToCommentMap comments)
		{
		}

		public static void WriteArray(StringBuilder sb, PBXElementArray el, int indent, bool compact, PropertyCommentChecker checker, GUIDToCommentMap comments)
		{
		}
	}
}
