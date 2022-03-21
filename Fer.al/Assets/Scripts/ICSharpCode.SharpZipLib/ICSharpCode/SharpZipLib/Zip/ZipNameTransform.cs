using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip
{
	public class ZipNameTransform : INameTransform
	{
		private static readonly char[] InvalidEntryChars;

		private static readonly char[] InvalidEntryCharsRelaxed;

		static ZipNameTransform()
		{
		}

		public static bool IsValidName(string name, bool relaxed)
		{
			return default(bool);
		}
	}
}
