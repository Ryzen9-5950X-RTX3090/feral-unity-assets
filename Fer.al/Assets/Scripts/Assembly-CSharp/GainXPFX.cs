using UnityEngine;

public class GainXPFX : MonoBehaviour
{
	[SerializeField]
	private AvatarBase _avatar;

	[SerializeField]
	[RootSelector("XPUpFX", "BundleIDChartData", false, false)]
	private string _xpUpFxDefId;

	[SerializeField]
	[RootSelector("LevelUpFX", "BundleIDChartData", false, false)]
	private string _levelUpFxDefId;

	private string _uuid;

	private bool _isPlayer;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnXPGained(XPUpdateMessage inMessage)
	{
	}

	public void PlayXPFX()
	{
	}

	public void PlayLevelupFX()
	{
	}
}
