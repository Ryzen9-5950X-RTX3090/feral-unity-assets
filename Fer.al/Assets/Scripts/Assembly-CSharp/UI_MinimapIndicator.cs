using UnityEngine;
using UnityEngine.UI;

[ManagedBehaviourManager("MinimapManager")]
public class UI_MinimapIndicator : ManagedBehaviour
{
	private MinimapBlipData _minimapBlipData;

	private GameObject _indicator;

	private Image _image;

	public void SetBlipData(MinimapBlipData inBlipData)
	{
	}
}
