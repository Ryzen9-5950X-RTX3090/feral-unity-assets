using System;

namespace Gaia.FullSerializer
{
	public sealed class fsMissingVersionConstructorException : Exception
	{
		public fsMissingVersionConstructorException(Type versionedType, Type constructorType)
		{
		}
	}
}
