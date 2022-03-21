using System.Collections.Generic;
using UnityEngine;

public class UI_CharmList : MonoBehaviour
{
	public List<Sprite> charmSlotSprites;

	public Sprite charmIconNormal;

	public Sprite charmIconSpecial;

	[SerializeField]
	private List<UI_CharmItem> _charms;

	private UI_Panel_CreatureOverview _panel;

	public void Setup(UI_Panel_CreatureOverview inCreatureOverviewPanel, int inCharmCount)
	{
	}

	public void CharmClicked(UI_CharmItem inClickedItem)
	{
	}

	public void DeselectAllCharms()
	{
	}
}
