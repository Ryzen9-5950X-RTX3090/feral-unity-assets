using System;

namespace Rewired.Libraries.SharpDX.DirectInput
{
	[AttributeUsage(AttributeTargets.Field)]
	internal sealed class DataObjectFormatAttribute : Attribute
	{
		public string Name;

		public string Guid;

		public int ArrayCount;

		public JfjreZuUDjbWVyLqGWRQiFDJVUZ TypeFlags;

		public pdzLPhXIAtPEtUPkpNNMIEuRrnt Flags;

		public int InstanceNumber;

		public DataObjectFormatAttribute(string guid, JfjreZuUDjbWVyLqGWRQiFDJVUZ typeFlags, pdzLPhXIAtPEtUPkpNNMIEuRrnt flags)
		{
		}

		public DataObjectFormatAttribute(string guid, int arrayCount, JfjreZuUDjbWVyLqGWRQiFDJVUZ typeFlags, pdzLPhXIAtPEtUPkpNNMIEuRrnt flags)
		{
		}

		public DataObjectFormatAttribute(string guid, int arrayCount, JfjreZuUDjbWVyLqGWRQiFDJVUZ typeFlags)
		{
		}

		public DataObjectFormatAttribute(int arrayCount, JfjreZuUDjbWVyLqGWRQiFDJVUZ typeFlags)
		{
		}
	}
}
