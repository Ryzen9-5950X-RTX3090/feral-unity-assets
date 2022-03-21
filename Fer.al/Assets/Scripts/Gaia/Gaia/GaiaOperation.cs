using System;
using UnityEngine;

namespace Gaia
{
	[Serializable]
	public class GaiaOperation
	{
		public enum OperationType
		{
			CreateTerrain,
			FlattenTerrain,
			SmoothTerrain,
			ClearDetails,
			ClearTrees,
			Stamp,
			StampUndo,
			StampRedo,
			Spawn,
			SpawnReset
		}

		public string m_description;

		public OperationType m_operationType;

		public bool m_isActive;

		public string m_generatedByName;

		public string m_generatedByID;

		public string m_generatedByType;

		public string m_operationDateTime;

		[HideInInspector]
		public string[] m_operationDataJson;

		public bool m_isFoldedOut;
	}
}
