using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gaia
{
	[ExecuteInEditMode]
	public class SpawnerGroup : MonoBehaviour
	{
		[Serializable]
		public class SpawnerInstance
		{
			public string m_name;

			public Spawner m_spawner;

			public int m_interationsPerSpawn;
		}

		public List<SpawnerInstance> m_spawners;

		[HideInInspector]
		public List<SpawnerGroup> m_spawnerGroups;

		public IEnumerator m_updateCoroutine;

		private bool m_cancelSpawn;

		[HideInInspector]
		public int m_progress;

		private void OnEnable()
		{
		}

		private void OnDisable()
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

		public void RunSpawnerIteration()
		{
		}

		[IteratorStateMachine(typeof(<RunSpawnerIterationCoRoutine>d__12))]
		public IEnumerator RunSpawnerIterationCoRoutine()
		{
			return null;
		}

		public void CancelSpawn()
		{
		}

		public bool FixNames()
		{
			return default(bool);
		}

		public void ResetSpawner()
		{
		}
	}
}
