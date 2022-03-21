using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ActorMainLight : MonoBehaviour
{
	private static List<ActorMainLight> _lights;

	private bool _checkedForLight;

	private Light _light;

	private Light Light
	{
		get
		{
			return null;
		}
	}

	public void Awake()
	{
	}

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	public void Update()
	{
	}

	private void OnDrawGizmos()
	{
	}

	private void SetGlobals()
	{
	}
}
