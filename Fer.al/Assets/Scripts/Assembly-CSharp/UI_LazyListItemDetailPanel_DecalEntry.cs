using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Coffee.UIExtensions;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_LazyListItemDetailPanel_DecalEntry : UI_LazyListItemDetailPanel<ActorInfoDecalEntry>
{
	[SerializeField]
	private LayerMask _raycastLayerMask;

	[SerializeField]
	private WWTextMeshProUGUI _decalNameText;

	[SerializeField]
	private WWImage _decalIconImage;

	[SerializeField]
	private WWImage _decalIconHighlightImage;

	[SerializeField]
	private UIHsvModifier _iconHSVModifier;

	[SerializeField]
	private FeralButton _enableDecalButton;

	[SerializeField]
	private FeralButton _layerUpButton;

	[SerializeField]
	private FeralButton _layerDownButton;

	[SerializeField]
	private FeralButton _mirrorDecalButton;

	[SerializeField]
	private ConstrainedSlider _sizeSlider;

	[SerializeField]
	private ConstrainedSlider _rotationSlider;

	[SerializeField]
	private UI_Control_HSVSliders _colorSliders;

	[SerializeField]
	private UI_LazyItemList_DecalEntry _itemList;

	[SerializeField]
	private UI_CustomizationNavPanel _navPanel;

	[SerializeField]
	private FeralButton _duplicateDecalButton;

	[SerializeField]
	private UI_DecalDragger _decalDragger;

	private HSVColor _decalColor;

	private ActorInfoBodyPart _bodyPart;

	private Dictionary<Collider, ActorInfoBodyPart> _bodyPartLookup;

	private bool _isDraggingDecal;

	private Tweener _pulseTween;

	private ActorInfoDecalEntry _data;

	private UI_Window_CreatureCustomization _window;

	private float? _lastGoodVerticalAngle;

	private float? _lastGoodMirrorVerticalAngle;

	private HSVColor DecalColor
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	private ActorInfo ActorInfo
	{
		get
		{
			return null;
		}
	}

	private UI_Window_CreatureCustomization Window
	{
		get
		{
			return null;
		}
	}

	private void SetupBodyPartLookup()
	{
	}

	public override void Setup(UI_LazyListItem<ActorInfoDecalEntry> inDataSrc)
	{
	}

	private void Setup(ActorInfoDecalEntry inData)
	{
	}

	public void BtnClicked_ChangeDecal()
	{
	}

	public void BtnClicked_DuplicateDecal()
	{
	}

	public void BtnClicked_DeleteDecal()
	{
	}

	public void BtnClicked_LayerUp()
	{
	}

	public void BtnClicked_LayerDown()
	{
	}

	public void BtnToggled_EnableDecal(bool inValue)
	{
	}

	public void BtnClicked_FlipDecalX()
	{
	}

	public void BtnClicked_FlipDecalY()
	{
	}

	public void BtnToggled_MirrorDecal(bool inValue)
	{
	}

	public void PositionDecalAtDefaultPosition([Optional] ActorInfoDecalEntry inDecalToPosition)
	{
	}

	private void RefreshIcon()
	{
	}

	private void RefreshIconColor()
	{
	}

	private void RefreshLayerButtons()
	{
	}

	private void SliderValueChanged_Size(float inScale)
	{
	}

	private void SliderValueChanged_Rotation(float inRotation)
	{
	}

	private void Start()
	{
	}

	private void ApplyPositionFromDragger(Vector2 inScreenPosition)
	{
	}

	private void Update()
	{
	}

	private void RaycastAndAdjustDecal(Vector2 inPosition, ActorInfoDecalEntry inDecal)
	{
	}

	private ValueTuple<RaycastHit?, RaycastHit?> RaycastMirrored(Vector2 inPosition, ActorInfoDecalEntry inDecal)
	{
		return default(ValueTuple<RaycastHit?, RaycastHit?>);
	}

	private void OnDecalCountChanged(int inDecalCount)
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}
}
