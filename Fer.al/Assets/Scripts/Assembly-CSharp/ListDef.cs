using System;
using System.Collections.Generic;

[Serializable]
public class ListDef : BaseDef
{
	public string localizedNameID;

	public string refsChart;

	public List<string> refs;

	public List<string> strings;

	public override void LoadEntry()
	{
	}
}
