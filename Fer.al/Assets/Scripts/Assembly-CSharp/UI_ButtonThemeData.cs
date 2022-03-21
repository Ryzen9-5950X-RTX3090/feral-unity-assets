using System;
using DG.DeInspektor.Attributes;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class UI_ButtonThemeData
{
	public const bool DISABLE_ID_IN_INSPECTOR = false;

	[SerializeField]
	[DeDisabled("DISABLE_ID_IN_INSPECTOR", Condition.IsNullOrEmpty)]
	private string _id;

	[SerializeField]
	private string _name;

	[SerializeField]
	[DeEndDisabled]
	private Selectable.Transition _transition;

	[SerializeField]
	private ColorBlock _colorBlock;

	[SerializeField]
	private SpriteState _spriteState;

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

	public Selectable.Transition Transition
	{
		get
		{
			return default(Selectable.Transition);
		}
	}

	public ColorBlock ColorBlock
	{
		get
		{
			return default(ColorBlock);
		}
	}

	public SpriteState SpriteState
	{
		get
		{
			return default(SpriteState);
		}
	}

	public UI_ButtonThemeData()
	{
	}

	public UI_ButtonThemeData(string inId, string inName)
	{
	}

	public UI_ButtonThemeData(string inId, string inName, WWButton inSrc)
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	public void SetDefaults()
	{
	}

	public void SetDataFromSrc(WWButton inSrc, bool inIgnoreSizeSettings = false)
	{
	}
}
