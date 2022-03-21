using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FXController : MonoBehaviour
{
	public enum FXType
	{
		NONE,
		SWIRL
	}

	[Serializable]
	public class FXInfo
	{
		public FXType type;

		public FXObject prefab;
	}

	public FXInfo[] fxList;

	private Dictionary<Transform, FXInfo> _fxDictionay;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(<SpawnFXToPlayer>d__5))]
	private IEnumerator SpawnFXToPlayer(FXType inType)
	{
		return null;
	}

	public void SetFXToObject(FXType inType, Transform target)
	{
	}

	private void SpawnFXObject(FXInfo inFXInfo, Transform inTransform)
	{
	}
}
