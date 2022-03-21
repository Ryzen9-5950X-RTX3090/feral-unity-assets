using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Prototype.QuickGames;
using UnityEngine;

namespace Prototype
{
	public class GroupSpawn : ManagedBehaviour
	{
		public enum EShape
		{
			SPHERE,
			RECTANGLE
		}

		[Serializable]
		public class SharedDetails
		{
			public bool enabled;

			public int amountToSpawn;

			public float minSpacing;

			public float offsetY;

			public bool checkForTerrain;

			public LayerMask groundLayermask;

			public Vector3 spawnAreaOffset;

			public float spawnAreaSphere;

			public Vector3 spawnAreaRectangle;

			public EShape shape;

			[HideInInspector]
			public List<Vector3> spawnPositions;

			public Color gizmoColor;
		}

		[Serializable]
		public class InspirationDetails
		{
			[RootSelector("Inspiration", "InspirationChartData", false, false)]
			public string defId;

			public SharedDetails details;
		}

		[Serializable]
		public class IngredientDetails
		{
			[RootSelector("Craftable Item", "CraftableItemChartData", false, false)]
			public string defId;

			public SharedDetails details;

			public QuickGamesBase quickGame;
		}

		[SerializeField]
		private InspirationDetails[] _inspirationDetails;

		[SerializeField]
		private IngredientDetails[] _ingredientDetails;

		private List<Vector3> _usedPositions;

		public override void MStart()
		{
		}

		private void SetInitialUsedPositions()
		{
		}

		private void Spawn(InspirationDetails inInspirationDetails)
		{
		}

		private void Spawn(IngredientDetails inIngredientDetails)
		{
		}

		[IteratorStateMachine(typeof(<Spawn>d__11))]
		private IEnumerator Spawn(SharedDetails inSharedDetails, GameObject inPrefab, string inDefId, [Optional] QuickGamesBase inQuickGame)
		{
			return null;
		}

		private bool IsValidPosition(SharedDetails inSharedDetails, Vector3 inPosition)
		{
			return default(bool);
		}

		private void OnDrawGizmos()
		{
		}
	}
}
