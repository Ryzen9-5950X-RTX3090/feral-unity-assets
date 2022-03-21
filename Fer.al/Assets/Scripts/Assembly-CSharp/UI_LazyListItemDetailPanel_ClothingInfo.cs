using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_LazyListItemDetailPanel_ClothingInfo : UI_LazyListItemDetailPanel<ColorableItemComponent>
{
	[SerializeField]
	private List<Graphic> _searchModeOffGraphics;

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	[SerializeField]
	private WWTextMeshProUGUI _descriptionText;

	[SerializeField]
	private FeralAudioInfo _equipAudioInfo;

	[SerializeField]
	private FeralAudioInfo _removeAudioInfo;

	[SerializeField]
	private Transform _arrow;

	[SerializeField]
	private FeralButton _equipBtn;

	private bool _clothingIsEquipped;

	[SerializeField]
	[Header("Colors")]
	private UI_Control_HSVSliders _clothingColorSliders;

	[SerializeField]
	private UI_TabGroup _clothingColorTabGroup;

	[SerializeField]
	private Graphic _clothingColor1Icon;

	private HSVColor _clothingColor1;

	[SerializeField]
	private Graphic _clothingColor2Icon;

	private HSVColor _clothingColor2;

	[SerializeField]
	private Graphic _clothingColor3Icon;

	private HSVColor _clothingColor3;

	[SerializeField]
	private Graphic _clothingColor4Icon;

	private HSVColor _clothingColor4;

	private ActorInfoClothingItem _equippedClothingItem;

	private ActorInfo ActorInfo
	{
		get
		{
			return null;
		}
	}

	private HSVColor ClothingColor1
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	private HSVColor ClothingColor2
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	private HSVColor ClothingColor3
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	private HSVColor ClothingColor4
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	public override void Setup(UI_LazyListItem<ColorableItemComponent> inDataSrc)
	{
	}

	public void BtnClicked_Equip()
	{
	}

	private void RefreshEquipped()
	{
	}

	private void OnTabSelected_ClothingColor(int inSelectedTab)
	{
	}

	private void OnClothingEquipped(ActorInfoClothingItem inClothingItem, bool inIsEquipped)
	{
	}
}
