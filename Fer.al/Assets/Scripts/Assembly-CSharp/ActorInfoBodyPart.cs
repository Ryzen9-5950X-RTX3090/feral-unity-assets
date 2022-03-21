using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ActorInfoBodyPart
{
	public string bodyPartDefID;

	[ChartBool]
	public bool attached;

	[NonSerialized]
	public bool decalsDirty;

	[NonSerialized]
	private ActorBodyPartDefComponent _bodyPartDefComponent;

	[SerializeField]
	[ChartList]
	private List<ActorInfoDecalEntry> _decalEntries;

	private List<ActorInfoDecalEntry> _tempDecalEntries;

	public BaseDef BodyPartDef
	{
		get
		{
			return null;
		}
	}

	public ActorBodyPartDefComponent BodyPartDefComponent
	{
		get
		{
			return null;
		}
	}

	public List<ActorInfoDecalEntry> EyeDecalEntries
	{
		get
		{
			return null;
		}
	}

	public List<ActorInfoDecalEntry> DecalEntries
	{
		get
		{
			return null;
		}
	}

	public List<ActorInfoDecalEntry> DecalEntriesWithoutDefaults
	{
		get
		{
			return null;
		}
	}

	public void ResetCaches()
	{
	}
}
