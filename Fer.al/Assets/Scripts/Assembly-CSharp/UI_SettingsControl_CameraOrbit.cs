using TMPro;
using UnityEngine;

public class UI_SettingsControl_CameraOrbit : MonoBehaviour
{
	[SerializeField]
	private WWTextMeshProUGUI _valueText;

	private bool _cameraOrbitSetting;

	public bool CameraOrbitSetting
	{
		get
		{
			return default(bool);
		}
		private set
		{
		}
	}

	private void Start()
	{
	}

	public void BtnClicked_Next()
	{
	}

	public void BtnClicked_Prev()
	{
	}

	private void RefreshText()
	{
	}
}
