using System;
using TMPro;
using UnityEngine;

public class UI_SanctuaryExpansionCostItem : MonoBehaviour
{
	[SerializeField]
	private WWTextMeshProUGUI _itemNameText;

	[SerializeField]
	private WWTextMeshProUGUI _itemCountText;

	public void Setup(ValueTuple<BaseDef, int> inCostItem)
	{
	}
}
