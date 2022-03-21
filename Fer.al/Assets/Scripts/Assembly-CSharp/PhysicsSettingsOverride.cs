using System;
using UnityEngine;

public class PhysicsSettingsOverride : MonoBehaviour
{
	[Serializable]
	public class OverrideValues
	{
		public Vector3 gravity;

		public float timeStep;
	}

	public OverrideValues physicsValueOverrides;

	private OverrideValues _savedValues;

	private void Start()
	{
	}

	private void SetValues(OverrideValues inValues)
	{
	}

	private void OnDestroy()
	{
	}
}
