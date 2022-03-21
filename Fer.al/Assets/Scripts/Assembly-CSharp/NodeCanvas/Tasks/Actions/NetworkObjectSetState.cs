using System.Collections.Generic;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Network")]
	[Description("Server script - Changes the state of a network object")]
	public class NetworkObjectSetState : NetworkActionTask<NetworkedObjectInfo>
	{
		public enum ESetType
		{
			equalTo,
			add_1,
			subtract_1
		}

		public enum EActionObjects
		{
			single,
			multiple
		}

		public ESetType setType;

		[ShowIf("setType", 0)]
		public BBParameter<int> setValue;

		public EActionObjects actionObjects;

		[ShowIf("actionObjects", 1)]
		public List<BBParameter<NetworkedObjectInfo>> networkedObjectInfos;

		protected override string info
		{
			get
			{
				return null;
			}
		}
	}
}
