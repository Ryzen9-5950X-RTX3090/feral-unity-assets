using System.Collections.Generic;
using TMPro;
using Unitilities.Tuples;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(WWTextMeshProUGUI))]
public class UI_TextThemeApplier : UI_ThemeApplier
{
	[SerializeField]
	private WWTextMeshProUGUI _textTarget;

	[SerializeField]
	private bool _ignoreSizeSettings;

	public WWTextMeshProUGUI TextTarget
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
