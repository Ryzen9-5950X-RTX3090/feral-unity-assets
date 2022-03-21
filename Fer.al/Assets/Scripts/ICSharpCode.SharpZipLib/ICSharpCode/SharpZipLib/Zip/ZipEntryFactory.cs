using System;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip
{
	public class ZipEntryFactory : IEntryFactory
	{
		private INameTransform nameTransform_;

		private DateTime fixedDateTime_;

		private int getAttributes_;
	}
}
