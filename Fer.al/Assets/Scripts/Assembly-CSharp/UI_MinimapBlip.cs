using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[ManagedBehaviourManager("MinimapManager")]
public class UI_MinimapBlip : ManagedBehaviour
{
	public enum EState
	{
		NONE,
		IN_MAP,
		OUTSIDE_MAP
	}

	[SerializeField]
	private UI_Tooltip _tooltip;

	[SerializeField]
	private FeralButton _button;

	private bool _isShowing;

	private bool _mapIsExpanded;

	private bool _isWithinMap;

	private MinimapBlipData _minimapBlipData;

	private MinimapBlip _minimapBlip;

	private MinimapManager.EBlipType _blipType;

	private string _blipTooltipText;

	private GameObject _blipGroup;

	private bool _hasChangingBlipVisual;

	private GameObject _blipGroupNormal;

	private GameObject _blipGroupOutsideMap;

	private RawImage _blipGlow;

	public EState currentState
	{
		[CompilerGenerated]
		get
		{
			return default(EState);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool isMasked
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public RawImage BlipGlow
	{
		get
		{
			return null;
		}
	}

	public void Setup(MinimapBlip inBlip)
	{
	}

	private void SetupChildren()
	{
	}

	private void SetupTooltip()
	{
	}

	public void SetScale(float inScale)
	{
	}

	public void SetMapState(bool inExpandedMap, bool inIsWithinMap)
	{
	}

	public void BtnClicked()
	{
	}

	public void SetPositionAndRotation(Vector3 inPosition, Quaternion inRotation)
	{
	}

	private string GetNetworkPlayerName()
	{
		return null;
	}

	private string GetPlayerName()
	{
		return null;
	}

	private string GetWorldMapLocationName()
	{
		return null;
	}

	private string GetNpcName()
	{
		return null;
	}

	public void Hide(bool inFadeout)
	{
	}
}
