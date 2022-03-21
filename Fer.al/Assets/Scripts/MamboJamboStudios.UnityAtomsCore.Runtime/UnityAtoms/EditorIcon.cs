using System;
using System.Runtime.CompilerServices;

namespace UnityAtoms
{
	[AttributeUsage(AttributeTargets.All)]
	public class EditorIcon : Attribute
	{
		public string Name
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public EditorIcon(string name)
		{
		}
	}
}
