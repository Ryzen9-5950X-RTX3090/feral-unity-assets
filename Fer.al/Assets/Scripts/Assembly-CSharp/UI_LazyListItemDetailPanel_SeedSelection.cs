using TMPro;
using UnityEngine;

public class UI_LazyListItemDetailPanel_SeedSelection : UI_LazyListItemDetailPanel<Item>
{
	[SerializeField]
	private Transform _arrow;

	[SerializeField]
	private WWTextMeshProUGUI _growTimeText;

	private UI_Window_SanctuaryGreenhouse _window;

	public override void Setup(UI_LazyListItem<Item> inDataSrc)
	{
	}

	public void BtnClicked_Plant()
	{
	}
}
