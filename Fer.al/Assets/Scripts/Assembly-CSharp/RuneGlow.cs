using UnityEngine.Rendering.PostProcessing;

public class RuneGlow : MonoBehaviour
{
	public PostProcessVolume runeGlow;

	private Bloom bloomLayer;

	public float bloomValueMin;

	public float bloomValueMax;

	public float glowTime;

	private static float t;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
