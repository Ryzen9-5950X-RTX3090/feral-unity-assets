using System.Runtime.CompilerServices;

public abstract class InventoryItemDef : LocalizedNameBundledDef
{
	public string localizedDescriptionID;

	public string imageDefId
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

	public ERarity rarity
	{
		[CompilerGenerated]
		get
		{
			return default(ERarity);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public EIdentity identity
	{
		[CompilerGenerated]
		get
		{
			return default(EIdentity);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool unique
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public override void LoadEntry()
	{
	}
}
