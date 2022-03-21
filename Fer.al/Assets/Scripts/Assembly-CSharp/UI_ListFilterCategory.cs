using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_ListFilterCategory : MonoBehaviour
{
	[SerializeField]
	private FeralButton _button;

	[SerializeField]
	private LayoutGroup _layoutGroup;

	[SerializeField]
	private LayoutElement _layoutElement;

	[SerializeField]
	private WWTextMeshProUGUI _categoryNameText;

	private string _category;

	public string Category
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	public void Setup(string inCategory)
	{
	}

	private void ToggleBtnClicked_Category(bool inIsOn)
	{
	}
}
