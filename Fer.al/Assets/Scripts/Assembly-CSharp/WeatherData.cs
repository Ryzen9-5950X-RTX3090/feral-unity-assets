using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class WeatherData
{
	public ParticleSystem weatherFx;

	public List<GameObject> gameObjectRefs;

	public FeralAudioInfo audio;

	public SkyboxColorInfo skyboxColors;

	public GameObject objectVisible;

	public GameObject objectInvisible;
}
