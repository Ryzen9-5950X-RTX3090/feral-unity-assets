using TMPro;
using UnityEngine;

public class UI_ListItem_AAVClothingChoice : MonoBehaviour
{
	[SerializeField]
	private CanvasGroup _frameSelected;

	[SerializeField]
	private WWTextMeshProUGUI _clothingNameText;

	[SerializeField]
	private UI_ItemImage _clothingItemImage;

	private ActorClothingDefComponent _def;

	private bool _isSelected;

	public string AttachNode
	{
		get
		{
			return null;
		}
	}

	public string FullName
	{
		get
		{
			return null;
		}
	}

	public ActorClothingDefComponent ClothingDef
	{
		get
		{
			return null;
		}
	}

	public void Setup(ActorClothingDefComponent inDef)
	{
	}

	public void SetSelected(bool inIsSelected)
	{
	}

	public void BtnClicked_Remove()
	{
	}

	public void BtnClicked_ReplaceItem()
	{
	}

	public void BtnClicked_Prev()
	{
	}

	public void BtnClicked_Next()
	{
	}

	private void Update()
	{
	}
}
