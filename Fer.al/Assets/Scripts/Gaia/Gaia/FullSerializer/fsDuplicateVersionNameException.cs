using System;

namespace Gaia.FullSerializer
{
	public sealed class fsDuplicateVersionNameException : Exception
	{
		public fsDuplicateVersionNameException(Type typeA, Type typeB, string version)
		{
		}
	}
}
