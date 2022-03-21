using TMPro;
using UnityEngine;

public class UI_SettingsControl_AntiAliasing : MonoBehaviour
{
	[SerializeField]
	private WWTextMeshProUGUI _antiAliasingText;

	private int _antiAliasing;

	public int AntiAliasing
	{
		get
		{
			return default(int);
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

	private void RefreshAntiAliasingText()
	{
	}
}
