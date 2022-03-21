using System.Collections.Generic;
using DG.DeInspektor.Attributes;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_WorldMapButton : MonoBehaviour
{
	[SerializeField]
	private Vector3 _cameraPosition;

	[SerializeField]
	private List<UI_WorldMapButton> _subButtons;

	[SerializeField]
	[DeComment("select before navigating to the level, even if it has no sub buttons", 3)]
	private bool _forceSelectionBeforeNavigation;

	[SerializeField]
	private Graphic _colliderGraphic;

	private UI_WorldMapQuestIcons _worldMapQuestIcons;

	private Tweener _showTweener;

	private bool _isHiding;

	public Vector3 CameraPosition
	{
		get
		{
			return default(Vector3);
		}
	}

	public List<UI_WorldMapButton> SubButtons
	{
		get
		{
			return null;
		}
	}

	public bool ForceSelectionBeforeNavigation
	{
		get
		{
			return default(bool);
		}
	}

	protected float scrollWheel
	{
		get
		{
			return default(float);
		}
	}

	public void BtnClicked()
	{
	}

	public void SetSelected(bool inSelected)
	{
	}

	internal void SetWorldMapQuestIcons(UI_WorldMapQuestIcons inWorldMapQuestIcons)
	{
	}

	public virtual void Scroll(BaseEventData inBaseEventData)
	{
	}

	public void Show(bool inShow)
	{
	}

	public void EndHideTween()
	{
	}

	public void OnShowTweenStart()
	{
	}

	public virtual void GoToLevel()
	{
	}
}
