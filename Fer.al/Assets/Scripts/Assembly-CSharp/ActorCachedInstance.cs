using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ActorCachedInstance
{
	public string hash;

	public GameObject gameObject;

	public float timer;

	public List<GameObject> references;
}
