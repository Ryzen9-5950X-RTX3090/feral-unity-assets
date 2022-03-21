using System;
using System.Collections.Generic;

public class LocalizationTemplate : PropertyEditor.ChartTemplateBase
{
	public LocalizationDefComponent localizationDefComponent;

	public OldLocalizationDefComponent oldLocalizationDefComponent;

	private string _enText;

	public string EnText
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override void OnCreateGUI()
	{
	}

	public override List<ValueTuple<string, string>> GetSuggestions()
	{
		return null;
	}

	public override void OnCreated(PropertyEditor.DefEntry inDefEntry)
	{
	}
}
