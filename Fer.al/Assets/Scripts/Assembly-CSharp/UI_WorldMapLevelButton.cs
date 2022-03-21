using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_WorldMapLevelButton : UI_WorldMapButton
{
	[SerializeField]
	[RootSelector("Level", "LevelChartData", false, false)]
	private string _levelDefId;

	[SerializeField]
	private bool _expanse;

	[SerializeField]
	private SocialExpanseArea _socialExpanseArea;

	[SerializeField]
	private Transform _subButtonParent;

	[SerializeField]
	private WWImage _levelImage;

	[SerializeField]
	private GameObject _levelName;

	[SerializeField]
	private Vector3 _vignetteOffset;

	private LevelDefComponent.WorldMapInfo _worldMapInfo;

	private GameObject _subLevelButton;

	private static List<UI_WorldMapLevelButton> _allWorldMapLevelButtons;

	internal Vector3 vignetteOffset
	{
		get
		{
			return default(Vector3);
		}
	}

	internal Transform subButtonParent
	{
		get
		{
			return null;
		}
	}

	internal SocialExpanseArea socialExpanseArea
	{
		get
		{
			return default(SocialExpanseArea);
		}
	}

	public bool FinishedLoading
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void SetLevelDetails(LevelDefComponent.WorldMapInfo inWorldMapInfo, Transform inParent)
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	[IteratorStateMachine(typeof(<Init>d__19))]
	private IEnumerator Init()
	{
		return null;
	}

	internal void HideOtherLevelText(UI_WorldMapButton inWorldMapLevelButton, bool inHide)
	{
	}

	private void FadeOutImmediate()
	{
	}

	public void FadeIn()
	{
	}

	private void WorldMapDataSet(List<LevelDefComponent.WorldMapInfo> inWorldMapInfos, Transform inParent, bool inExpanse)
	{
	}

	private string GetLocalizationId(LevelDefComponent.WorldMapInfo inWorldMapInfo)
	{
		return null;
	}

	private void GetSprite(LevelDefComponent.WorldMapInfo inWorldMapInfo, Action<Sprite> inSprite)
	{
	}

	private string GetTooltipDefId(LevelDefComponent.WorldMapInfo inWorldMapInfo)
	{
		return null;
	}

	private void SetSprite(GameObject inGameObject, Sprite inSprite)
	{
	}

	private void SetLocalizedName(GameObject inGameObject, string inLocDefId)
	{
	}

	public override void GoToLevel()
	{
	}

	public override void Scroll(BaseEventData inBaseEventData)
	{
	}
}
