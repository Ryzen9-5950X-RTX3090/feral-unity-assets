using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class FeralParticleSystem : ManagedBehaviour
{
	public enum EEmit
	{
		AfterLoaded
	}

	private ParticleSystem _particleSystem;

	private ParticleSystemRenderer _particleSystemRenderer;

	[RootSelector("TextureBundleId", "BundleIDChartData", false, false)]
	public string bundleId;

	[SerializeField]
	private EEmit _emit;

	public override void MStart()
	{
	}
}
