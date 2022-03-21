using System.Collections;
using System.Runtime.CompilerServices;
using BeautifyEffect;
using UnityEngine;

public class PositionBasedLight : ManagedBehaviour
{
	public Light keyLight;

	public Color topColor;

	public Color bottomColor;

	public float topLightIntensity;

	public float bottomLightIntensity;

	public Light waterLight;

	public float waterLightIntensityTop;

	public float waterLightIntensityBot;

	public Material skyBoxMaterial;

	public Color skyBoxColorTop;

	public Color skyBoxColorBottom;

	public float fogEndDistTop;

	public float fogEndDistBot;

	public Color fogColorTop;

	public Color fogColorBottom;

	public float bloomIntesityTop;

	public float bloomIntesityBot;

	public float bloomThresholdTop;

	public float bloomThresholdBot;

	public float duration;

	public GameObject swampObj;

	public Camera playerCam;

	private Beautify _beautify;

	public override void MStart()
	{
	}

	[IteratorStateMachine(typeof(<Setup>d__24))]
	private IEnumerator Setup()
	{
		return null;
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
