using UnityEngine;

namespace Prototype
{
	public class NPCShopKeep : Interactable
	{
		[RootSelector("NpcImageDefId", "ImageChartData", false, false)]
		public string _npcImageDefId;

		[SerializeField]
		private string _npcDefId;

		public string npcDefId
		{
			get
			{
				return null;
			}
		}

		public override void PlayAudioAndFX()
		{
		}
	}
}
