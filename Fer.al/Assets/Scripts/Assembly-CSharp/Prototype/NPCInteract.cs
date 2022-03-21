using UnityEngine;

namespace Prototype
{
	public class NPCInteract : Interaction
	{
		[SerializeField]
		private string _npcDefId;

		[RootSelector("NpcImageDefId", "ImageChartData", false, false)]
		public string npcImageDefId;

		public string npcDefId
		{
			get
			{
				return null;
			}
		}

		public float Timer()
		{
			return default(float);
		}
	}
}
