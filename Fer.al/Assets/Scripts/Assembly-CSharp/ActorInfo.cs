using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ActorInfo : WorldObjectInfo, ISerializationCallbackReceiver
{
	[Space]
	[Header("Body")]
	public string actorClassDefID;

	[ChartList]
	public List<ActorInfoBodyPart> bodyParts;

	public Action<ActorInfoBodyPart> OnBodyPartSet;

	[ChartHSV]
	[SerializeField]
	private HSVColor _bodyColor1HSV;

	[ChartHSV]
	[SerializeField]
	private HSVColor _bodyColor2HSV;

	[ChartHSV]
	[SerializeField]
	private HSVColor _bodyColor3HSV;

	[ChartHSV]
	[SerializeField]
	private HSVColor _bodyColor4HSV;

	public Action OnBodyColorChanged;

	[Space]
	[Header("Eyes")]
	public string eyeShapeDefID;

	public string eyePupilDefID;

	private List<BaseDef> _eyeShapeDefs;

	private List<BaseDef> _eyePupilDefs;

	[ChartHSV]
	[SerializeField]
	private HSVColor _eyeShapeColorHSV;

	[ChartHSV]
	[SerializeField]
	private HSVColor _eyePupilColorHSV;

	public Action OnEyeColorChanged;

	[ChartHSV]
	[SerializeField]
	private HSVColor _sparkColor1HSV;

	public Action OnSparkColorChanged;

	[ChartHSV]
	[SerializeField]
	private HSVColor _hornColor1HSV;

	[ChartHSV]
	[SerializeField]
	private HSVColor _hornColor2HSV;

	[ChartHSV]
	[SerializeField]
	private HSVColor _hornColor3HSV;

	[ChartHSV]
	[SerializeField]
	private HSVColor _hornColor4HSV;

	public Action OnHornColorChanged;

	[ChartHSV]
	[SerializeField]
	private HSVColor _wingColor1HSV;

	[ChartHSV]
	[SerializeField]
	private HSVColor _wingColor2HSV;

	[ChartHSV]
	[SerializeField]
	private HSVColor _wingColor3HSV;

	[ChartHSV]
	[SerializeField]
	private HSVColor _wingColor4HSV;

	public Action OnWingColorChanged;

	[ChartFloat]
	public float eyeShapeScale;

	[ChartFloat]
	public float eyePupilScale;

	[Space]
	[ChartList]
	[Header("Clothing Items")]
	public List<ActorInfoClothingItem> clothingItems;

	[ChartBool]
	public bool defaultDecalsEnabled;

	public Action<ActorInfoClothingItem, bool> OnClothingEquip;

	public Action<ActorInfoDecalEntry> OnDecalAdded;

	public Action<ActorInfoDecalEntry> OnDecalRemoved;

	[NonSerialized]
	private ActorClassDefComponent _classDefComponent;

	[NonSerialized]
	private List<ActorInfoBodyPart> _attachedBodyParts;

	public List<ActorInfoScaleGroup> scaleGroups;

	private Dictionary<string, ActorInfoClothingItem> _attachNodeToClothingItemDict;

	private ActorInfoDecalEntry _selectedDecalEntry;

	private float _selectedDecalEntryOutlinePulse;

	[NonSerialized]
	private bool _isRefreshingDirty;

	public HSVColor BodyColor1HSV
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	public HSVColor BodyColor2HSV
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	public HSVColor BodyColor3HSV
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	public HSVColor BodyColor4HSV
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	public List<BaseDef> EyeShapeDefs
	{
		get
		{
			return null;
		}
	}

	public List<BaseDef> EyePupilDefs
	{
		get
		{
			return null;
		}
	}

	public HSVColor EyeShapeColorHSV
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	public HSVColor EyePupilColorHSV
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	public HSVColor SparkColor1HSV
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	public HSVColor HornColor1HSV
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	public HSVColor HornColor2HSV
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	public HSVColor HornColor3HSV
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	public HSVColor HornColor4HSV
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	public HSVColor WingColor1HSV
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	public HSVColor WingColor2HSV
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	public HSVColor WingColor3HSV
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	public HSVColor WingColor4HSV
	{
		get
		{
			return default(HSVColor);
		}
		set
		{
		}
	}

	public ActorClassDefComponent ClassDefComponent
	{
		get
		{
			return null;
		}
	}

	public List<ActorInfoBodyPart> AttachedBodyParts
	{
		get
		{
			return null;
		}
	}

	public bool IsDesignerMode
	{
		get
		{
			return default(bool);
		}
	}

	public ActorInfoDecalEntry SelectedDecalEntry
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float SelectedDecalEntryOutlinePulse
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public HSVColor SelectedDecalEntryOutlineColor
	{
		get
		{
			return default(HSVColor);
		}
	}

	public bool IsRefreshingDirty
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public override void ResetCaches()
	{
	}

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
	}

	public void RefreshAttachedBodyParts()
	{
	}

	public ActorInfoScaleGroup GetScaleGroupWithDefID(string inGroupDefID)
	{
		return null;
	}

	public ActorInfoBodyPart GetAttachedBodyPartForNode(BaseDef inNodeDef)
	{
		return null;
	}

	public ActorInfoBodyPart GetAttachedBodyPartForNode(string inNodeDefID)
	{
		return null;
	}

	public List<ActorInfoBodyPart> GetBodyPartsForNode(BaseDef inNodeDef)
	{
		return null;
	}

	public List<ActorInfoBodyPart> GetBodyPartsForNode(string inNodeDefID)
	{
		return null;
	}

	public bool IsBodyPartAttached(ActorBodyPartDefComponent inDef)
	{
		return default(bool);
	}

	public void SetEyeShape(BaseDef inDecalDef)
	{
	}

	public void SetPupilShape(BaseDef inDecalDef)
	{
	}

	public void SetEyeShapeScale(float inScale)
	{
	}

	public void SetEyePupilScale(float inScale)
	{
	}

	public void SetBodyPart(ActorBodyPartDefComponent inPartDefComponent)
	{
	}

	public bool ClothingItemIsEquipped(Item inItem)
	{
		return default(bool);
	}

	public ValueTuple<ActorInfoClothingItem, List<ActorInfoClothingItem>> AddClothingItem(Item inItem)
	{
		return default(ValueTuple<ActorInfoClothingItem, List<ActorInfoClothingItem>>);
	}

	public void AddClothingItem(ActorInfoClothingItem inItem)
	{
	}

	public void RemoveClothingItem(Item inItem)
	{
	}

	public void RemoveClothingItem(ActorInfoClothingItem inItem)
	{
	}

	public List<ActorInfoClothingItem> RemoveClothingItemsOnGroup(ActorAttachNodeGroupDefComponent inAttachNodeGroup)
	{
		return null;
	}

	public void RemoveAllClothingItems()
	{
	}

	public ActorInfoDecalEntry AddDecal(BaseDef inDecalDef)
	{
		return null;
	}

	public ActorInfoDecalEntry AddDuplicateDecal(ActorInfoDecalEntry inDecalEntry)
	{
		return null;
	}

	public void RemoveAllDecals()
	{
	}

	public void RemoveDecal(ActorInfoDecalEntry inDecalEntry)
	{
	}

	public ActorInfoBodyPart GetDecalBodyPart(ActorInfoDecalEntry inDecalEntry)
	{
		return null;
	}

	public void SetDecalShape(BaseDef inDecalDef, ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart)
	{
	}

	public void SetDecalPositionFromHit(RaycastHit inHit, RaycastHit? inMirrorHit, ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart)
	{
	}

	public void SetDecalRotation(float inDecalRotation, ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart)
	{
	}

	public void SetDecalColor(HSVColor inDecalColor, ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart)
	{
	}

	public void SetDecalScale(float inNormalizedScale, ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart)
	{
	}

	public void SetDecalAlpha(float inAlpha, ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart)
	{
	}

	public void SetDecalEnabled(bool inEnabled, ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart)
	{
	}

	public void SetDefaultDecalsEnabled(bool inEnabled)
	{
	}

	public void FlipDecalX(ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart)
	{
	}

	public void FlipDecalY(ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart)
	{
	}

	public bool DecalIsAtBottomLayer(ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart)
	{
		return default(bool);
	}

	public bool DecalIsAtTopLayer(ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart)
	{
		return default(bool);
	}

	public void MoveDecalUp(ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart)
	{
	}

	public void MoveDecalDown(ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart)
	{
	}

	public void MirrorDecal(ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart, bool inMirror)
	{
	}

	public void SetDecalBodyPart(ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inOriginalBodyPart, ActorInfoBodyPart inNewBodyPart)
	{
	}

	public void SetDirty(ActorInfoDirtyType inType, bool inValue = true)
	{
	}

	public void SetAllDirty(bool inValue = true)
	{
	}

	public void SyncInventoryItems(Inventory inv)
	{
	}
}
