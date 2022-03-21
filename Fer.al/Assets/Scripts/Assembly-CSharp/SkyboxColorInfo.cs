using System;
using UnityEngine;

[Serializable]
public class SkyboxColorInfo
{
	public float transitionDuration;

	[Header("Skybox Settings")]
	public Color skyboxTint;

	public Color skyboxColor1;

	public Color skyboxColor2;

	public Color skyboxColor3;

	public Color cloudLayer1Tint;

	public Color cloudLayer2Tint;

	[Header("Skybox Bottom Settings")]
	public Color skyboxBottomTint;

	public Color skyboxBottomColor1;

	public Color skyboxBottomColor2;

	public Color skyboxBottomColor3;

	[Header("Main Light Settings")]
	public Color lightColor;

	public float lightIntensity;

	[Header("Fog Settings")]
	public Color fogColor;

	public float fogStart;

	public float fogEnd;

	[Header("Background Transparency")]
	public float backgroundAlphaEnd;
}
