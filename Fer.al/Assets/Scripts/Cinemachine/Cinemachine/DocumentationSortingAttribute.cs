using System;
using System.Runtime.CompilerServices;

namespace Cinemachine
{
	[DocumentationSorting(Level.Undoc)]
	public sealed class DocumentationSortingAttribute : Attribute
	{
		public enum Level
		{
			Undoc,
			API,
			UserRef
		}

		private Level Category
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public DocumentationSortingAttribute(Level category)
		{
		}
	}
}
