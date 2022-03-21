using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_LazyListItemDetailPanel_SanctuaryLookSaving : UI_LazyListItemDetailPanel<SanctuaryLookItemComponent>
{
	[SerializeField]
	private CanvasGroup _groupNoLookSelected;

	[SerializeField]
	private CanvasGroup _groupLookSelected;

	[SerializeField]
	private FeralButton _saveBtn;

	[SerializeField]
	private TMP_InputField _nameInput;

	public string Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public override void Setup(UI_LazyListItem<SanctuaryLookItemComponent> inDataSrc)
	{
	}

	public override void Refresh()
	{
	}

	public void BtnClicked_Save()
	{
	}

	public void OnInputFieldChanged_Name(string inValue)
	{
	}

	private void OnSubmit(string inValue)
	{
	}
}
