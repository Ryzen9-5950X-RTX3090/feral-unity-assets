using System;

namespace ParadoxNotion.Serialization.FullSerializer
{
	[AttributeUsage(AttributeTargets.Class)]
	public class fsMigrateVersionsAttribute : Attribute
	{
		public readonly Type[] previousTypes;

		public fsMigrateVersionsAttribute(Type[] previousTypes)
		{
		}
	}
}
