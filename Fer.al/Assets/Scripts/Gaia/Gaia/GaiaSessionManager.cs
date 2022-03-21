using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;
using UnityEngine;

namespace Gaia
{
	[ExecuteInEditMode]
	public class GaiaSessionManager : MonoBehaviour
	{
		public IEnumerator m_updateSessionCoroutine;

		public IEnumerator m_updateOperationCoroutine;

		private bool m_cancelPlayback;

		public GaiaSession m_session;

		public bool m_focusSceneView;

		public bool m_genShowRandomGenerator;

		public bool m_genShowTerrainHelper;

		public GaiaConstants.GeneratorBorderStyle m_genBorderStyle;

		public int m_genGridSize;

		public int m_genNumStampsToGenerate;

		public float m_genScaleWidth;

		public float m_genScaleHeight;

		public float m_genChanceOfHills;

		public float m_genChanceOfIslands;

		public float m_genChanceOfLakes;

		public float m_genChanceOfMesas;

		public float m_genChanceOfMountains;

		public float m_genChanceOfPlains;

		public float m_genChanceOfRivers;

		public float m_genChanceOfValleys;

		public float m_genChanceOfVillages;

		public float m_genChanceOfWaterfalls;

		[fsIgnore]
		public Stamper m_currentStamper;

		[fsIgnore]
		public Spawner m_currentSpawner;

		[fsIgnore]
		public DateTime m_lastUpdateDateTime;

		[fsIgnore]
		public ulong m_progress;

		private List<string> m_genHillStamps;

		private List<string> m_genIslandStamps;

		private List<string> m_genLakeStamps;

		private List<string> m_genMesaStamps;

		private List<string> m_genMountainStamps;

		private List<string> m_genPlainsStamps;

		private List<string> m_genRiverStamps;

		private List<string> m_genValleyStamps;

		private List<string> m_genVillageStamps;

		private List<string> m_genWaterfallStamps;

		public static GaiaSessionManager GetSessionManager(bool pickupExistingTerrain = false)
		{
			return null;
		}

		public bool IsLocked()
		{
			return default(bool);
		}

		public bool LockSession()
		{
			return default(bool);
		}

		public bool UnLockSession()
		{
			return default(bool);
		}

		public void AddOperation(GaiaOperation operation)
		{
		}

		public GaiaOperation GetOperation(int operationIdx)
		{
			return null;
		}

		public void RemoveOperation(int operationIdx)
		{
		}

		public void AddResource(GaiaResource resource)
		{
		}

		public void AddDefaults(GaiaDefaults defaults)
		{
		}

		public void AddPreviewImage(Texture2D image)
		{
		}

		public bool HasPreviewImage()
		{
			return default(bool);
		}

		public void RemovePreviewImage()
		{
		}

		public Texture2D GetPreviewImage()
		{
			return null;
		}

		public void SaveSession()
		{
		}

		public void StartEditorUpdates()
		{
		}

		public void StopEditorUpdates()
		{
		}

		private void EditorUpdate()
		{
		}

		public GaiaSession CreateSession(bool pickupExistingTerrain = false)
		{
			return null;
		}

		public void SetSeaLevel(float seaLevel)
		{
		}

		public float GetSeaLevel()
		{
			return default(float);
		}

		public void ResetSession()
		{
		}

		public void RandomiseStamps()
		{
		}

		private void PositionStamp(Bounds bounds, Stamper stamper, GaiaConstants.FeatureType stampType)
		{
		}

		private void PositionStampV2(Bounds bounds, Stamper stamper, GaiaConstants.FeatureType stampType, float suggestX, float suggestZ, float suggestJitter)
		{
		}

		private GaiaConstants.FeatureType GetWeightedRandomFeatureType()
		{
			return default(GaiaConstants.FeatureType);
		}

		public string GetRandomStampPath(GaiaConstants.FeatureType featureType)
		{
			return null;
		}

		public string GetRandomMountainFieldPath()
		{
			return null;
		}

		public GameObject Apply(int operationIdx)
		{
			return null;
		}

		public void PlaySession()
		{
		}

		[IteratorStateMachine(typeof(<PlaySessionCoRoutine>d__65))]
		public IEnumerator PlaySessionCoRoutine()
		{
			return null;
		}

		public void PlayOperation(int opIdx)
		{
		}

		[IteratorStateMachine(typeof(<PlayOperationCoRoutine>d__67))]
		public IEnumerator PlayOperationCoRoutine(int operationIdx)
		{
			return null;
		}

		public void CancelPlayback()
		{
		}

		public void ExportSessionResources()
		{
		}

		public void ExportSessionDefaults()
		{
		}

		public void ExportSessionResource(string resourcePath)
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		private GameObject FindOrCreateObject(GaiaOperation operation)
		{
			return null;
		}

		private GameObject ShowStamper(string name, string id)
		{
			return null;
		}

		private GameObject CreateSpawner(string name, string id)
		{
			return null;
		}
	}
}
