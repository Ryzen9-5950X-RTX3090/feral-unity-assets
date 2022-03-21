using System.Collections.Generic;
using System.Runtime.CompilerServices;

[ChartComponent("Actor Class Item")]
public class ActorClassDefComponent : DefComponent
{
	[ChartFloat]
	public float scale;

	[ChartList]
	[ChartDef("CraftableItem", new string[] { }, SearchString = "ActorBodyPart")]
	public List<string> bodyPartDefIDs;

	[ChartList]
	[ChartDef("ActorBodyPartNode", new string[] { })]
	public List<string> bodyPartNodeDefIDs;

	[ChartList]
	[ChartDef("ActorScaleGroup", new string[] { })]
	public List<string> scaleGroupDefIDs;

	[ChartList]
	[ChartDef("CraftableItem", new string[] { }, SearchString = "ActorClothing")]
	public List<string> npcClothingItemDefIDs;

	[ChartList]
	public ChartDefList eyeShapeDefs;

	[ChartList]
	public ChartDefList eyePupilDefs;

	public string avatarLookDefId;

	private string _skeletonBundleID;

	private string _wingSkeletonBundleID;

	private string _dataBundleID;

	private string _animationClipsBundleID;

	private string _bodyPartsBundleID;

	private BundleIDDefComponent _bundleIDDefComponent;

	private ActorInfo _defaultActorInfo;

	public List<BaseDef> BodyParts
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

	public List<BaseDef> BodyPartNodes
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

	public List<BaseDef> ScaleGroups
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

	public List<BaseDef> NPCClothingItems
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

	public string SkeletonBundleID
	{
		get
		{
			return null;
		}
	}

	public string WingSkeletonBundleID
	{
		get
		{
			return null;
		}
	}

	public string DataBundleID
	{
		get
		{
			return null;
		}
	}

	public string AnimationClipsBundleID
	{
		get
		{
			return null;
		}
	}

	public string BodyPartsBundleID
	{
		get
		{
			return null;
		}
	}

	public BundleIDDefComponent BundleIDDefComponent
	{
		get
		{
			return null;
		}
	}

	public ActorInfo DefaultActorInfo
	{
		get
		{
			return null;
		}
	}

	public List<ActorBodyPartDefComponent> GetBodyPartsForNode(string inNodeDefId)
	{
		return null;
	}

	public List<ActorBodyPartDefComponent> GetAllOwnedBodyPartsForActorByNode(string actorClassDefID, string inNodeDefId)
	{
		return null;
	}

	protected override void LoadEntry()
	{
	}
}
