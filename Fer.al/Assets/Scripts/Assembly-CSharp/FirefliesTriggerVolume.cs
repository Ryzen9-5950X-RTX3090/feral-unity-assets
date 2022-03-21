using UnityEngine;

[RequireComponent(typeof(Collider))]
public class FirefliesTriggerVolume : ManagedBehaviour
{
	[RootSelector("Firefly Low FX", "BundleIDChartData", false, false)]
	public string lowPosition;

	[RootSelector("Firefly High FX", "BundleIDChartData", false, false)]
	public string highPosition;

	private ParticleSystem _lowPosition;

	private ParticleSystem _highPosition;

	public override void MStart()
	{
	}

	public override void MOnDisable()
	{
	}

	private void Toggle(bool inNear)
	{
	}

	private void OnTriggerEnter(Collider inCollider)
	{
	}

	private void OnTriggerExit(Collider inCollider)
	{
	}
}
