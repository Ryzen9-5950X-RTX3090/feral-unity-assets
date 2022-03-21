using System.Collections.Generic;
using Unitilities.Tuples;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
[RequireComponent(typeof(WWButton))]
public class UI_ButtonThemeApplier : UI_ThemeApplier
{
	[SerializeField]
	private WWButton _buttonTarget;

	public WWButton ButtonTarget
	{
		get
		{
			return null;
		}
	}

	public override List<StringTuple> GetDataOptions()
	{
		return null;
	}

	public override bool AddThemeDataFromTarget(string inName)
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
