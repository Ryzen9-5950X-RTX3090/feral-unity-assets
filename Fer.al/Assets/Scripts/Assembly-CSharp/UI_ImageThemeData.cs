using System;
using DG.DeInspektor.Attributes;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class UI_ImageThemeData
{
	public const bool DISABLE_ID_IN_INSPECTOR = false;

	[SerializeField]
	[DeDisabled("DISABLE_ID_IN_INSPECTOR", Condition.IsNullOrEmpty)]
	private string _id;

	[SerializeField]
	private string _name;

	[SerializeField]
	[DeEndDisabled]
	private Sprite _sprite;

	[SerializeField]
	private Color _color;

	[SerializeField]
	private bool _useOverridePixelsPerUnit;

	[SerializeField]
	private float _overridePixelsPerUnit;

	[SerializeField]
	private Image.Type _type;

	[SerializeField]
	[DeHeader("Sliced/Tiled", null, null, FontStyle.Bold, 11)]
	private bool _fillCenter;

	[SerializeField]
	[DeHeader("Filled", null, null, FontStyle.Bold, 11)]
	private Image.FillMethod _fillMethod;

	[SerializeField]
	[DeRange(0f, 1f, null)]
	private float _fillAmount;

	[SerializeField]
	private bool _fillClockwise;

	[SerializeField]
	private int _fillOrigin;

	[SerializeField]
	private bool _preserveAspect;

	public string Id
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

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

	public Sprite Sprite
	{
		get
		{
			return null;
		}
	}

	public Color Color
	{
		get
		{
			return default(Color);
		}
	}

	public bool UseOverridePixelsPerUnit
	{
		get
		{
			return default(bool);
		}
	}

	public float OverridePixelsPerUnit
	{
		get
		{
			return default(float);
		}
	}

	public Image.Type Type
	{
		get
		{
			return default(Image.Type);
		}
	}

	public bool FillCenter
	{
		get
		{
			return default(bool);
		}
	}

	public Image.FillMethod FillMethod
	{
		get
		{
			return default(Image.FillMethod);
		}
	}

	public float FillAmount
	{
		get
		{
			return default(float);
		}
	}

	public bool FillClockwise
	{
		get
		{
			return default(bool);
		}
	}

	public int FillOrigin
	{
		get
		{
			return default(int);
		}
	}

	public bool PreserveAspect
	{
		get
		{
			return default(bool);
		}
	}

	public UI_ImageThemeData()
	{
	}

	public UI_ImageThemeData(string inId, string inName, Sprite inSprite, Color inColor)
	{
	}

	public UI_ImageThemeData(string inId, string inName, WWImage inSrc)
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	public void SetDefaults()
	{
	}

	public void SetDataFromSrc(WWImage inSrc)
	{
	}
}
