using System;
using UnityEngine;

[Serializable]
public abstract class LocalizedNameBundledDef : BundledDef
{
	[Header("Localization")]
	public string localizedNameID;

	public override void LoadEntry()
	{
	}
}
