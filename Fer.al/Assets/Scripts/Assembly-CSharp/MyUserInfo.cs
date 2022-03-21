using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.ObscuredTypes;
using WW.Debug;

public class MyUserInfo : UserInfo
{
	[CompilerGenerated]
	private readonly Inventory <Inventory>k__BackingField;

	private ItemComponentRef<QuantityItemComponent> _likeQuantity;

	private ItemComponentRef<QuantityItemComponent> _starFragmentQuantity;

	private ItemComponentRef<QuantityItemComponent> _lockpickQuantity;

	private AccountPendingFlag _pendingFlags;

	public Inventory Inventory
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public AvatarLookItemComponent ActiveAvatarLookItem
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public ActorInfo ActiveAvatarAppearance
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SanctuaryLookItemComponent ActiveSanctuaryLookItem
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public string EmailAddress
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

	[DebugField("", "User", true, true)]
	private static string PlayerID
	{
		get
		{
			return null;
		}
	}

	[DebugField("", "User", true, true)]
	private static string Email
	{
		get
		{
			return null;
		}
	}

	[DebugField("", "User", true, true)]
	private static string DisplayName
	{
		get
		{
			return null;
		}
	}

	public int Likes
	{
		get
		{
			return default(int);
		}
	}

	public int StarFragments
	{
		get
		{
			return default(int);
		}
	}

	public int Lockpicks
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public bool IsGuest
	{
		get
		{
			return default(bool);
		}
	}

	public bool HasCompletedCustomization
	{
		get
		{
			return default(bool);
		}
	}

	public bool HasUnlocked(string unlockableDefId)
	{
		return default(bool);
	}

	public Dictionary<int, ObscuredLong> GetUserVar(string defId)
	{
		return null;
	}

	public void UpdateUserVar(string defId, int index, long newValue)
	{
	}

	public MyUserInfo(string uuid, string email, [Optional] string name)
	{
	}

	public void ParseLoginData(LoginData data)
	{
	}

	public void OnLoginComplete(LoginData data)
	{
	}

	public void MarkTutorialComplete(bool inIsComplete)
	{
	}

	public bool HasWings(bool inNeedsToBeEquiped)
	{
		return default(bool);
	}

	public int GetAttributeValue(string inAttributeDefId)
	{
		return default(int);
	}
}
