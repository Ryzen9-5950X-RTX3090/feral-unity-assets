using System;
using UnityEngine;

[Serializable]
public class ActorInfoClothingItem
{
	[ChartString]
	public string itemInvID;

	public string clothingItemDefID;

	[ChartBool]
	public bool attached;

	[SerializeField]
	[ChartHSV]
	private HSVColor _clothingColor1HSV;

	[SerializeField]
	[ChartHSV]
	private HSVColor _clothingColor2HSV;

	[SerializeField]
	[ChartHSV]
	private HSVColor _clothingColor3HSV;

	[SerializeField]
	[ChartHSV]
	private HSVColor _clothingColor4HSV;

	[NonSerialized]
	private ActorClothingDefComponent _clothingDefComponent;

	public HSVColor ClothingColor1HSV
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	public HSVColor ClothingColor2HSV
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	public HSVColor ClothingColor3HSV
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	public HSVColor ClothingColor4HSV
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	public ActorClothingDefComponent ClothingDefComponent
	{
		get
		{
			return null;
		}
	}

	public void ResetCaches()
	{
	}

	public ActorInfoClothingItem()
	{
	}

	public ActorInfoClothingItem(ColorableItemComponent inItem)
	{
	}
}
