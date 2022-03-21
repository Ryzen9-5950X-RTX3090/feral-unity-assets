using System.Runtime.CompilerServices;
using UnityEngine;

[ManagedBehaviourManager("MinimapManager")]
public class MinimapBlip : ManagedBehaviour
{
	public MinimapManager.EBlipType blipType;

	public bool forceDisplayOnExpandedMap;

	public UI_MinimapBlip uiMinimapBlip;

	public MinimapBlipData minimapBlipData
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public UI_MinimapIndicator uiMinimapIndicator
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Avatar_Network avatarNetwork
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Transform cachedTransform
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public override void MAwake()
	{
	}

	public override void MOnEnable()
	{
	}

	public override void MOnDisable()
	{
	}

	public void SetBlipData(MinimapBlipData inMinimapBlipData)
	{
	}

	public void SetBlipUI(UI_MinimapBlip inUI_MinimapBlip)
	{
	}

	public void SetBlipIndicator(UI_MinimapIndicator inUI_MinimapIndicator)
	{
	}

	public static MinimapManager.EBlipType GetBlipType(string inLevelId)
	{
		return default(MinimapManager.EBlipType);
	}

	public static void AddBlip(GameObject inParent, string inLevelId)
	{
	}

	public static void AddBlip(GameObject inParent, MinimapManager.EBlipType inBlipType)
	{
	}

	public static void RemoveBlip(GameObject inParent)
	{
	}
}
