using System.Collections.Generic;
using DG.DeInspektor.Attributes;
using UnityEngine;

public class UI_CustomizationPageInfo : MonoBehaviour
{
	[SerializeField]
	[RootSelector("Page Name Def", "LocalizationChartData", false, false)]
	private string _pageTitleDefId;

	private LocalizationDef _localizationDef;

	[SerializeField]
	private List<UI_CustomizationPageInfo> _navLinks;

	[SerializeField]
	private List<UI_CustomizationControl> _controls;

	[SerializeField]
	private Transform _fullPageControl;

	[SerializeField]
	private bool _designerModeOnly;

	[SerializeField]
	private bool _requiresWingUnlock;

	[SerializeField]
	private bool _useWingUnlockUnread;

	[SerializeField]
	[DeComment("Must only match a single item type not all of them", 3)]
	private List<UI_UnreadCount.UnreadItemType> _unreadItemTypes;

	public string PageTitle
	{
		get
		{
			return null;
		}
	}

	public List<UI_CustomizationPageInfo> NavLinks
	{
		get
		{
			return null;
		}
	}

	public List<UI_CustomizationControl> Controls
	{
		get
		{
			return null;
		}
	}

	public Transform FullPageControl
	{
		get
		{
			return null;
		}
	}

	public bool DesignerModeOnly
	{
		get
		{
			return default(bool);
		}
	}

	public bool RequiresWingUnlock
	{
		get
		{
			return default(bool);
		}
	}

	public bool UseWingUnlockUnread
	{
		get
		{
			return default(bool);
		}
	}

	public bool UseWingUnlockUnreadRecursive
	{
		get
		{
			return default(bool);
		}
	}

	public bool CheckIsValid()
	{
		return default(bool);
	}

	public void SetTitle(string inLocalizationDefId)
	{
	}

	public List<UI_UnreadCount.UnreadItemType> GetUnreadItemTypes()
	{
		return null;
	}

	[DeMethodButton(null, 0, new object[] { })]
	public void AssignNavLinksFromChildren()
	{
	}
}
