using System.Collections;
using System.Runtime.CompilerServices;
using Prototype.QuickGames;
using UnityEngine;

namespace Prototype
{
	public class CraftIngredient : Interactable
	{
		[SerializeField]
		private MeshRenderer _meshRenderer;

		private string _ingredientDefId;

		private QuickGamesBase _quickGame;

		private BaseDef _ingredientDef;

		[HideInInspector]
		public string texturePath;

		private static CraftIngredient _craftIngredient;

		public BaseDef ingredientDef
		{
			get
			{
				return null;
			}
		}

		public static CraftIngredient Get()
		{
			return null;
		}

		public void Setup(string inIngredientDefId, QuickGamesBase inGame)
		{
		}

		public void CollectFromQuickGame(string inDefId, int inCount = 1, int inEmberCount = 0)
		{
		}

		public void Collect()
		{
		}

		[IteratorStateMachine(typeof(<GetTextureRoutine>d__12))]
		private IEnumerator GetTextureRoutine()
		{
			return null;
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
