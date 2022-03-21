using DG.DeInspektor.Attributes;
using UnityEngine;

public class UI_SelectableStringList : UI_SelectableList<string>
{
	[SerializeField]
	private UI_SelectableListStringItem _stringItemPrefab;

	protected override UI_SelectableListItem<string> ListItemPrefab
	{
		get
		{
			return null;
		}
	}

	[DeMethodButton(null, 0, new object[] { })]
	public void AddTestItem()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	public void RemoveFirstItem()
	{
	}
}
