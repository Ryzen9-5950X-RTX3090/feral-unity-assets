using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class RuneSpawnPoint
{
	public Transform spawnInPosition;

	public Transform spawnRestPosition;

	public float spawnInTime;

	public float resetTime;

	public RuneGroup RunePiece
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public void SpawnInRunePiece(RuneGroup inRunePiece, float inOverrideSpawnInTime = -1f)
	{
	}

	public void ResetRunePiece(float inOverrideResetTime = -1f)
	{
	}

	public void Clear()
	{
	}
}
