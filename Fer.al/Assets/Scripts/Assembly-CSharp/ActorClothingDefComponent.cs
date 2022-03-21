using System;
using System.Collections.Generic;

[ChartComponent("Actor Clothing Item")]
public class ActorClothingDefComponent : DefComponent
{
	[Serializable]
	public class ClassModelOverride
	{
		public string actorClassDefId;

		private ActorClassDefComponent _actorClassDef;

		[ChartString]
		public string modelFolderPrefix;

		public ActorClassDefComponent ActorClassDef
		{
			get
			{
				return null;
			}
		}
	}

	[ChartDef("ActorAttachNodeGroup", new string[] { })]
	public string attachNodeGroupDefID;

	private ActorAttachNodeGroupDefComponent _attachNodeGroupDef;

	[ChartList]
	public ChartDefList clearAttachNodeGroups;

	[ChartList]
	public List<ClassModelOverride> classModelOverrides;

	[ChartDef("ActorAttachNode", new string[] { })]
	public string attachNodeDefID;

	private ActorAttachNodeDefComponent _attachNodeDef;

	[ChartBool]
	public bool allowCombining;

	private BundleIDDefComponent _bundleIDDefComponent;

	private ActorClothingGetModelDefComponent _getModelDefComponent;

	public ActorAttachNodeGroupDefComponent AttachNodeGroupDef
	{
		get
		{
			return null;
		}
	}

	public ActorAttachNodeDefComponent AttachNodeDefComponent
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

	public ActorClothingGetModelDefComponent GetModelDefComponent
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

	protected override void LoadEntry()
	{
	}
}
