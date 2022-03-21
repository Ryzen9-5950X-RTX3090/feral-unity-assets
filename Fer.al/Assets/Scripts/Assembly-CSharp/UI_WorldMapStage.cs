using System;
using System.Collections.Generic;
using UnityEngine;

public class UI_WorldMapStage : MonoBehaviour
{
	public static UI_WorldMapStage instance;

	[SerializeField]
	private Transform _cameraParent;

	[SerializeField]
	private Transform _vignette;

	[SerializeField]
	private Vector2 _cameraRotationMin;

	[SerializeField]
	private Vector2 _cameraRotationMax;

	[SerializeField]
	private Vector2 _cameraPositionMin;

	[SerializeField]
	private Vector2 _cameraPositionMax;

	[SerializeField]
	private UI_WorldMapButton _rootButton;

	private Vector2 _lastMousePos;

	private Vector2 _mouseVelocity;

	private SpriteRenderer _vignetteSprite;

	private Stack<UI_WorldMapButton> _levelButtonNavStack;

	[SerializeField]
	private GameObject _subLevelButton;

	public Action<UI_WorldMapButton> OnLevelButtonSelected;

	public FeralAudioInfo subButtonPopUp;

	public UI_WorldMapButton RootButton
	{
		get
		{
			return null;
		}
	}

	public GameObject subLevelButton
	{
		get
		{
			return null;
		}
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void RemoveScene(string inLevelDefId)
	{
	}

	public void BtnClicked_Back()
	{
	}

	public void BtnClicked_WorldMapLevelButton(UI_WorldMapButton inButton)
	{
	}

	private void SelectLevelButton(UI_WorldMapButton inButton)
	{
	}
}
