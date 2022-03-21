using UnityEngine.Rendering.PostProcessing;

public class PostProcessQualitySettings : ManagedBehaviour
{
	private PostProcessVolume _volume;

	private bool _hasColorGradingLayer;

	private bool? _lastUseColorGradingLayer;

	private bool _hasAOLayer;

	private bool? _lastUseAOLayer;

	private bool _hasBloomLayer;

	private bool? _lastUseBloomLayer;

	private bool _hasMotionBlurLayer;

	private bool? _lastUseMotionBlurLayer;

	public override void MOnEnable()
	{
	}

	public override void MUpdate()
	{
	}

	private void UpdateQualitySettings(bool inUseColorGradingLayer, bool inUseAOLayer, bool inUseBloomLayer, bool inUseMotionBlurLayer)
	{
	}
}
