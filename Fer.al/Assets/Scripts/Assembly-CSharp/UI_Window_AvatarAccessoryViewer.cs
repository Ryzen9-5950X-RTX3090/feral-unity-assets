using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using WW.Debug;

public class UI_Window_AvatarAccessoryViewer : UI_Window
{
	[SerializeField]
	private UI_ListItem_AAVPreview _previewItemPrefabReference;

	[SerializeField]
	private Transform _content;

	[SerializeField]
	private ScrollRect _scrollRect;

	[SerializeField]
	[Header("Size")]
	private float _itemSize;

	[SerializeField]
	private float _zoomSpeed;

	[SerializeField]
	[Header("Rotation")]
	private float _rotationSpeed;

	[SerializeField]
	[Header("Panning")]
	private float _panSpeed;

	private Vector3 _currentOffset;

	[SerializeField]
	[Header("Chosen Clothing")]
	private UI_ListItem_AAVClothingChoice _clothingChoicePrefab;

	[SerializeField]
	private Transform _clothingChoiceParent;

	[SerializeField]
	[Header("Chosen Class")]
	private WWTextMeshProUGUI _classNameText;

	[SerializeField]
	private UI_ItemImage _classItemImage;

	[SerializeField]
	[Header("Animation")]
	private TMP_Dropdown _actionDropdown;

	private ActorClassDefComponent _actorClass;

	private bool _combinedMesh;

	private List<ActorInfo> _actorInfos;

	private List<UI_ListItem_AAVPreview> _previewItems;

	private List<UI_ListItem_AAVClothingChoice> _clothingChoices;

	private UI_ListItem_AAVClothingChoice _focusedClothingChoice;

	private Vector2 _prevMousePos;

	private bool _isAnimating;

	private ActorActionType[] _animations;

	private List<ActorBodyPartDefComponent> _headParts;

	private List<ActorBodyPartDefComponent> _hornParts;

	private List<ActorBodyPartDefComponent> _earParts;

	private List<ActorBodyPartDefComponent> _wingParts;

	private List<ActorBodyPartDefComponent> _tailParts;

	private List<ActorBodyPartDefComponent> _legParts;

	private ActorClothingDefComponent _chosenClothing;

	[DebugButton("Brody Bunch", "QA", true, true)]
	public static void OpenWindow()
	{
	}

	public static void QueueWindow()
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup(ActorClassDefComponent inActorClass)
	{
	}

	public void BtnClicked_ChooseItem()
	{
	}

	public void BtnClicked_ReplaceItem(UI_ListItem_AAVClothingChoice inItemToReplace)
	{
	}

	public void BtnClicked_ClearClothing()
	{
	}

	public void BtnClicked_PrevItem(UI_ListItem_AAVClothingChoice inItemToReplace)
	{
	}

	public void BtnClicked_NextItem(UI_ListItem_AAVClothingChoice inItemToReplace)
	{
	}

	public void BtnClicked_RemoveClothingChoice(UI_ListItem_AAVClothingChoice inItemToRemove, bool inDestroyChoiceItem = true)
	{
	}

	public void BtnClicked_ChooseClass()
	{
	}

	public void ToggleBtnClicked_Animate(bool inValue)
	{
	}

	public void ToggleBtnClicked_CombinedMesh(bool inValue)
	{
	}

	public void DropdownItemSelected_Animation(int inItemIndex)
	{
	}

	public void BtnClicked_ReplayAnimation()
	{
	}

	private void SetupPartLists()
	{
	}

	private void ClearPartLists()
	{
	}

	private void SetupActorInfos()
	{
	}

	private void SpawnPreviewItems()
	{
	}

	private void SetupAnimationOptions()
	{
	}

	private void OnClothingChosen(ActorClothingDefComponent inChosenClothing)
	{
	}

	private void SpawnClothingChoiceItem(ActorClothingDefComponent inChosenClothing)
	{
	}

	private void FocusPrevClothingChoice()
	{
	}

	private void FocusNextClothingChoice()
	{
	}

	private void OnClassChosen(ActorClassDefComponent inChosenClass)
	{
	}

	private void OnActionChosen(ActorActionType inAction)
	{
	}

	private void CaptureScreenshot()
	{
	}

	private void NextAvatar()
	{
	}

	private void PreviousAvatar()
	{
	}

	private void Update()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	public override void MOnDestroy()
	{
	}
}
