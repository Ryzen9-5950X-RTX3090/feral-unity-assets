using CodeStage.AntiCheat.ObscuredTypes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuildersFollyUI_ResoureDisplay : MonoBehaviour
{
	public WWImage resourceImage;

	public TextMeshProUGUI resourceAmount;

	public UI_Tooltip uiTooltip;

	internal BuildersFollyResource resource;

	internal ObscuredInt prioramount;

	internal ObscuredInt amount;

	internal ObscuredInt startAmount;

	internal Vector3 startScale;

	private void Start()
	{
	}
}
