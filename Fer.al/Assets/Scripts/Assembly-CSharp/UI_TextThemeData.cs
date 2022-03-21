using System;
using DG.DeInspektor.Attributes;
using TMPro;
using UnityEngine;

[Serializable]
public class UI_TextThemeData
{
	public const bool DISABLE_ID_IN_INSPECTOR = false;

	[SerializeField]
	[DeDisabled("DISABLE_ID_IN_INSPECTOR", Condition.IsNullOrEmpty)]
	private string _id;

	[SerializeField]
	private string _name;

	[SerializeField]
	[DeEndDisabled]
	private Color _color;

	[SerializeField]
	private TMP_FontAsset _fontAsset;

	[SerializeField]
	private Material _fontMaterial;

	[SerializeField]
	private float _fontSize;

	[SerializeField]
	private bool _autoSize;

	[SerializeField]
	private float _minFontSize;

	[SerializeField]
	private float _maxFontSize;

	[SerializeField]
	private int _fontStyle;

	[SerializeField]
	private bool _useGradient;

	[SerializeField]
	private VertexGradient _vertexGradient;

	[SerializeField]
	private TMP_ColorGradient _gradientPreset;

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

	public Color Color
	{
		get
		{
			return default(Color);
		}
	}

	public TMP_FontAsset FontAsset
	{
		get
		{
			return null;
		}
	}

	public Material FontMaterial
	{
		get
		{
			return null;
		}
	}

	public float FontSize
	{
		get
		{
			return default(float);
		}
	}

	public bool AutoSize
	{
		get
		{
			return default(bool);
		}
	}

	public float MinFontSize
	{
		get
		{
			return default(float);
		}
	}

	public float MaxFontSize
	{
		get
		{
			return default(float);
		}
	}

	public int FontStyle
	{
		get
		{
			return default(int);
		}
	}

	public bool UseGradient
	{
		get
		{
			return default(bool);
		}
	}

	public VertexGradient VertexGradient
	{
		get
		{
			return default(VertexGradient);
		}
	}

	public TMP_ColorGradient GradientPreset
	{
		get
		{
			return null;
		}
	}

	public UI_TextThemeData()
	{
	}

	public UI_TextThemeData(string inId, string inName)
	{
	}

	public UI_TextThemeData(string inId, string inName, WWTextMeshProUGUI inSrc)
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	public void SetDefaults()
	{
	}

	public void SetDataFromSrc(WWTextMeshProUGUI inSrc, bool inIgnoreSizeSettings = false)
	{
	}
}
