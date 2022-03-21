using UnityEngine;

public class ClothingInfo : PurchasedItemInfo
{
	public string color1DefID;

	public string color2DefID;

	public string color3DefID;

	public string color4DefID;

	[SerializeField]
	private HSVColor _clothingColor1HSV;

	[SerializeField]
	private HSVColor _clothingColor2HSV;

	[SerializeField]
	private HSVColor _clothingColor3HSV;

	[SerializeField]
	private HSVColor _clothingColor4HSV;

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
}
