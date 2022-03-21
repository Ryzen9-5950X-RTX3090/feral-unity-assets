using System;
using Prototype.QuickGames;
using UnityEngine;

namespace Prototype
{
	public class SingleSpawn : ManagedBehaviour
	{
		[Serializable]
		public class InspirationDetails
		{
			[RootSelector("Inspiration", "InspirationChartData", false, false)]
			public string defId;
		}

		[Serializable]
		public class IngredientDetails
		{
			[RootSelector("Craftable Item", "CraftableItemChartData", false, false)]
			public string defId;

			public QuickGamesBase quickGame;
		}

		[SerializeField]
		private InspirationDetails _inspirationDetails;

		[SerializeField]
		private IngredientDetails _ingredientDetails;

		public override void MStart()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
