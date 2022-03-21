using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : ManagedBehaviour
{
	[Serializable]
	public class SceneDetails
	{
		public string loadScene;

		public LoadSceneMode loadSceneMode;
	}

	private string _loadingScene;

	public string activeSceneName;

	[SerializeField]
	private SceneDetails[] _sceneDetails;

	public string[] unloadedScenes;

	public void StartLoad()
	{
	}

	[IteratorStateMachine(typeof(<LoadScenes>d__6))]
	private IEnumerator LoadScenes()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<LoadSingles>d__7))]
	private IEnumerator LoadSingles(SceneDetails inSceneDetails)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<LoadAdditives>d__8))]
	private IEnumerator LoadAdditives(SceneDetails inSceneDetails)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<DestroyScenes>d__9))]
	private IEnumerator DestroyScenes()
	{
		return null;
	}
}
