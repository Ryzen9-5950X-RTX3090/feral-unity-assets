using System.Collections.Generic;
using System.Runtime.CompilerServices;

[ChartComponent("Actor Body Part Item")]
public class ActorBodyPartDefComponent : DefComponent
{
	public ChartDef actorClassDef;

	[ChartDef("ActorBodyPartNode", new string[] { })]
	public string bodyPartNodeDefID;

	[ChartBool]
	public bool blank;

	[ChartInt]
	public int availableColorChannels;

	[ChartButton("Get Eyes From NPC Editor", "ButtonGetEyeDecalsFromNPCEditor")]
	private bool buttonGetEyeDecalsFromNPCEditor;

	[ChartList]
	public List<ActorInfoDecalEntry> eyeDecals;

	[ChartList]
	public List<ActorBodyPartAdditiveAnimationEntry> additiveAnimations;

	private BundleIDDefComponent _bundleIDDefComponent;

	private ActorBodyPartGetModelDefComponent _getModelDefComponent;

	public ActorBodyPartNodeDefComponent BodyPartNode
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

	public BundleIDDefComponent BundleIDDefComponent
	{
		get
		{
			return null;
		}
	}

	public ActorBodyPartGetModelDefComponent GetModelDefComponent
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

	public string FXAttachmentBundleID
	{
		get
		{
			return null;
		}
	}

	public string BaseTextureBundleID
	{
		get
		{
			return null;
		}
	}

	public string ColorIDTextureBundleID
	{
		get
		{
			return null;
		}
	}

	public void ButtonGetEyeDecalsFromNPCEditor(PropertyEditor.DefEntry inDefEntry)
	{
	}

	protected override void LoadEntry()
	{
	}
}
