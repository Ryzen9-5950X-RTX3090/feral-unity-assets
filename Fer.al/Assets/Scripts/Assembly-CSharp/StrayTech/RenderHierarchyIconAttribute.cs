using System;

namespace StrayTech
{
	[AttributeUsage(AttributeTargets.Class)]
	public class RenderHierarchyIconAttribute : Attribute
	{
		public readonly string _iconAssetPath;

		public RenderHierarchyIconAttribute(string iconAssetPath)
		{
		}
	}
}
