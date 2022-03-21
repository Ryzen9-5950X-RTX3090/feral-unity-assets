using System.Collections.Generic;
using Unitilities.Tuples;
using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
[RequireComponent(typeof(WWImage))]
public class UI_ImageThemeApplier : UI_ThemeApplier
{
	[SerializeField]
	private WWImage _imageTarget;

	[SerializeField]
	private bool _ignoreFillAmount;

	public WWImage ImageTarget
	{
		get
		{
			return null;
		}
	}

	public bool IgnoreFillAmount
	{
		get
		{
			return default(bool);
		}
	}

	public override List<StringTuple> GetDataOptions()
	{
		return null;
	}

	public override bool AddThemeDataFromTarget(string inId)
	{
		return default(bool);
	}

	public override bool UpdateThemeDataFromTarget(string inId, string inName)
	{
		return default(bool);
	}

	protected override void ApplyTheme()
	{
	}

	protected override void DereferenceAssets()
	{
	}
}
