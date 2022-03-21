using System;
using TMPro;
using UnityEngine;

public class UI_DyeCostItem : MonoBehaviour
{
	[SerializeField]
	private WWTextMeshProUGUI _itemNameText;

	[SerializeField]
	private WWTextMeshProUGUI _itemCountText;

	[SerializeField]
	private Color _redColor;

	[SerializeField]
	private Color _defaultColor;

	public void Setup(ValueTuple<Item, int> inDyeCostItem)
	{
	}
}
