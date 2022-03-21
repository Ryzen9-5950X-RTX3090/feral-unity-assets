using System.Collections.Generic;
using UnityEngine;

public class UI_WorldMapQuestIcons : MonoBehaviour
{
	[SerializeField]
	private GameObject worldMapQuestIcon;

	[SerializeField]
	private GameObject worldMapQuestSubIcon;

	[SerializeField]
	private Transform _questSubLocator;

	[SerializeField]
	private Transform _linearQuestLocator;

	[SerializeField]
	private Transform[] _dailyQuestLocators;

	private List<UI_WorldMapQuestIcon> worldMapQuestIcons;

	private UI_WorldMapQuestSubIcons _worldMapQuestSubIcons;

	private static List<UI_WorldMapQuestIcons> allWorldMapQuestIcons;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void LoadIcon(Transform inParent, string inToolTip, Vector3 inPosition, string inImageDefID)
	{
	}

	internal void SetSelected(bool inSelected)
	{
	}

	internal void HideAll(bool inHide)
	{
	}

	internal static void HideOthers(UI_WorldMapQuestIcons inWorldMapQuestIcons, bool inHide)
	{
	}

	internal static void Show(Transform inTrans, bool inShow, float inOriginalScale)
	{
	}
}
