using System;
using UnityEngine;

[Serializable]
public struct ItemPopupStyleData
{
	public ItemPopupStyle style;

	public Color outlineColor;

	public bool isShiny;

	public void ApplyStyleTo(IItemPopupStylable inStyleTarget)
	{
	}
}
