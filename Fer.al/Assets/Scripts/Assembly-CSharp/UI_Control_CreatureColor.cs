using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class UI_Control_CreatureColor : UI_CustomizationControl
{
	private enum CreatureColorCategory
	{
		Body = 1,
		EyeShape = 5,
		EyePupil = 6,
		Eye = 7,
		Horns = 10,
		Clothing = 15,
		Spark = 20,
		Wings = 25
	}

	private class ColorTarget
	{
		private Graphic _colorPreviewGraphic;

		private Action<HSVColor> _setColorAction;

		private HSVColor _color;

		private HSVColor Color
		{
			get
			{
				return default(HSVColor);
			}
			set
			{
			}
		}

		public ColorTarget(HSVColor color, Action<HSVColor> setColorAction, [Optional] Graphic colorPreviewGraphic)
		{
		}

		public void SetAsSelected(UI_Control_HSVSliders inHSVSliders)
		{
		}
	}

	[SerializeField]
	private CreatureColorCategory _creatureColorCategory;

	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private UI_Control_HSVSliders _hsvSliders;

	[SerializeField]
	private UI_TabGroup _tabGroup;

	[SerializeField]
	private Graphic[] _colorPreviewGraphics;

	[SerializeField]
	private List<GameObject> _tabRelatedObjects;

	private ColorTarget[] _colorTargets;

	private ActorInfo ActorInfo
	{
		get
		{
			return null;
		}
	}

	private bool DesignMode
	{
		get
		{
			return default(bool);
		}
	}

	private void OnEnable()
	{
	}

	private void OnDesignerEditClothingTargetChanged(ActorInfoClothingItem inItem)
	{
	}

	private void OnBodyPartSet(ActorInfoBodyPart inBodyPart)
	{
	}

	private void OnDisable()
	{
	}

	private void Setup()
	{
	}

	private void OnColorTabSelected(int inTabIndex)
	{
	}

	public override bool CheckIsValid()
	{
		return default(bool);
	}
}
