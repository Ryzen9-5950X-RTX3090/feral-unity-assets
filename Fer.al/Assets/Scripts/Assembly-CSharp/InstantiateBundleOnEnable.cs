using UnityEngine;

public class InstantiateBundleOnEnable : ManagedBehaviour
{
	[RootSelector("Bundle ID", "BundleIDChartData", false, false)]
	public string bundleID;

	private GameObject _bundleInstance;

	public override void MOnEnable()
	{
	}

	public override void MOnDisable()
	{
	}
}
