using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuildersFollyUI_LevelSelect : MonoBehaviour
{
	public GameObject buttonHolder;

	public ScrollRect scrollRect;

	public BuildersFollyUI_LevelButton levelButton;

	public WWTextMeshProUGUI levelSelectHeader;

	[RootSelector("Normal Levels Header", "LocalizationChartData", false, false)]
	public string normalLevelsHeader;

	private string _normalLevelsHeader;

	[RootSelector("Expert Levels Header", "LocalizationChartData", false, false)]
	public string expertLevelsHeader;

	private string _expertLevelsHeader;

	private List<BuildersFollyUI_LevelButton> _buttons;

	private BuildersFollyGame _game;

	public GameObject startButton;

	private float normalScrollPosition;

	private float expertScrollPosition;

	private string NormalLevelsHeader
	{
		get
		{
			return null;
		}
	}

	private string ExpertLevelsHeader
	{
		get
		{
			return null;
		}
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnLevelSelected(CodeBreakerLevelSelectedMessage inMessage)
	{
	}

	private void SetupLevelInfo(int inLevelIndex)
	{
	}

	public void BtnClicked_LevelStart()
	{
	}

	internal void ToggleButtons()
	{
	}
}
