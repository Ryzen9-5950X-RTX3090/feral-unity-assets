using System;
using UnityEngine;

public class UI_Window_SelectDecal : UI_Window
{
	[SerializeField]
	private UI_DecalItem _decalItemPrefab;

	[SerializeField]
	private WWSmoothLayout _smoothLayout;

	public Action<BaseDef> OnDecalSelected;

	public static void OpenWindow()
	{
	}

	public static void QueueWindow()
	{
	}

	public static void CloseWindow()
	{
	}

	public void Setup(Action<BaseDef> inOnDecalSelected)
	{
	}

	private void OnDecalItemClicked(UI_DecalItem inItem)
	{
	}
}
