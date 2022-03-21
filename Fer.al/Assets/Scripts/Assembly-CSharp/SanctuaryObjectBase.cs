using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[ManagedBehaviourManager("SanctuaryManager")]
public class SanctuaryObjectBase : WorldObject<SanctuaryObjectBaseInfo>
{
	public class States
	{
		public Transform parent;
	}

	private SanctuaryHouseDefComponent _sanctuaryHouseDefComponent;

	private SanctuaryItemDefComponent _data;

	private GameObject _model;

	private List<GameObject> _models;

	private string _inventoryId;

	private MeshFilter[] _meshFilters;

	private bool _rebuilt;

	private Color _gizmoColor;

	private Transform _dayGroup;

	private Transform _nightGroup;

	private SanctuaryObjectBase _lastGoodSanctuaryObjectParent;

	private Vector3 _lastGoodPosition;

	private Vector3 _lastGoodRotation;

	private Vector3 _localSurfacePosition;

	private int? _sanctuaryMaterialRoomIndex;

	private SanctuaryObjectBase _hitSanctuaryObject;

	private bool _isSpawnedFromUI;

	private int _interactableState;

	private ItemType? _itemType;

	private string _defName;

	private SanctuaryItemCategory? _itemCategory;

	public SanctuaryHouseDefComponent sanctuaryHouseDefComponent
	{
		get
		{
			return null;
		}
	}

	public SanctuaryItemDefComponent data
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GameObject model
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<GameObject> models
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string inventoryId
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public MeshFilter[] meshFilters
	{
		get
		{
			return null;
		}
	}

	public BoxCollider touchCollider
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

	public MeshCollider meshCollider
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

	public Bounds meshColliderBounds
	{
		get
		{
			return default(Bounds);
		}
	}

	public Vector3 leftEdge
	{
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 rightEdge
	{
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 forwardEdge
	{
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 backEdge
	{
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 meshColliderCenter
	{
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 meshColliderSize
	{
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 meshColliderMinimum
	{
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 meshColliderMaximum
	{
		get
		{
			return default(Vector3);
		}
	}

	public SanctuaryObjectBase lastGoodSanctuaryObjectParent
	{
		get
		{
			return null;
		}
	}

	public Vector3 lastGoodPosition
	{
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 lastGoodRotation
	{
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 localSurfacePosition
	{
		get
		{
			return default(Vector3);
		}
	}

	public int sanctuaryMaterialRoomIndex
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public SanctuaryObjectBase hitSanctuaryObject
	{
		get
		{
			return null;
		}
	}

	public SanctuaryObjectBase sanctuaryObjectParent
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

	public SanctuarySurface onSurface
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

	public bool beingDestroyed
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

	public bool isWallObject
	{
		get
		{
			return default(bool);
		}
	}

	public bool isGroundObject
	{
		get
		{
			return default(bool);
		}
	}

	public List<States> stateList
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

	public int interactableState
	{
		get
		{
			return default(int);
		}
	}

	public Item item
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

	private ItemType? itemType
	{
		get
		{
			return null;
		}
	}

	private string defName
	{
		get
		{
			return null;
		}
	}

	public SanctuaryItemCategory? itemCategory
	{
		get
		{
			return null;
		}
	}

	public SanctuaryItemDefComponent sanctuaryItemDefComponent
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

	public bool isDefault
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

	public int GetRoomIndex()
	{
		return default(int);
	}

	public void SetAsDefault()
	{
	}

	private void SetName()
	{
	}

	public bool IsSpawnedFromUI()
	{
		return default(bool);
	}

	public void SetIsSpawnedFromUI(bool inValue)
	{
	}

	public void MovePosition(Vector3 inPosition)
	{
	}

	public void MoveRotation(Quaternion inRotation)
	{
	}

	public void SetStates(GameObject inParent, SanctuaryItemDefComponent inSanctuaryItemDefComponent)
	{
	}

	public void ChangeInteractableState(bool inInitInteractableState, int inInteractableState)
	{
	}

	private void SaveInteractableState(bool inInitInteractableState)
	{
	}

	private void UpdateInteractableState()
	{
	}

	public void SetupInteractableState(int inIndex, GameObject inGameObject)
	{
	}

	public bool ShouldTeleport()
	{
		return default(bool);
	}

	protected override void OnMoveMessage(WorldObjectMoveMessage inMessage)
	{
	}

	private void InfoCreated(GameObject inGameObject, SanctuaryObjectBaseInfo inInfo)
	{
	}

	public override void OnObjectInfo(WorldObjectInfoMessage inInfoMessage)
	{
	}

	[IteratorStateMachine(typeof(<Build>d__133))]
	public override IEnumerator Build()
	{
		return null;
	}

	public override void MStart()
	{
	}

	private void OnSanctuaryStateChangeMessage(SanctuaryStateChangeMessage inMessage)
	{
	}

	private void UpdateMeshCollider(SanctuaryController.EState inState)
	{
	}

	private static void RemoveTemp(SanctuaryObjectBase inSanctuaryObjectBase)
	{
	}

	public override void MOnDestroy()
	{
	}

	[IteratorStateMachine(typeof(<SpawnPlacedObject>d__139))]
	private IEnumerator SpawnPlacedObject(Item inItem, Action<GameObject> inResult)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<SpawnHouseLook>d__140))]
	private IEnumerator SpawnHouseLook(Item inItem)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<SpawnHouse>d__141))]
	private IEnumerator SpawnHouse(Item inItem, Action<List<GameObject>> inHouseBases)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<SpawnIsland>d__142))]
	private IEnumerator SpawnIsland(Item inItem, Action<GameObject> inResult)
	{
		return null;
	}

	public void SetupHouse(List<GameObject> inModels, Item inItem, string inId, SanctuaryItemDefComponent inSanctuaryItemDefComponent, SanctuaryObjectBaseInfo inInfo)
	{
	}

	public void SetupIsland(GameObject inModel, Item inItem, string inId, SanctuaryItemDefComponent inSanctuaryItemDefComponent, SanctuaryObjectBaseInfo inInfo)
	{
	}

	public void SetupPlacedObject(GameObject inModel, Item inItem, string inId, SanctuaryItemDefComponent inSanctuaryItemDefComponent, SanctuaryObjectBaseInfo inInfo)
	{
	}

	public void SetSanctuarySurface(SanctuarySurface inSanctuarySurface)
	{
	}

	private void SetSanctuaryItemDefComponent(SanctuaryItemDefComponent inComponent)
	{
	}

	public void SetSanctuaryObjectParent(SanctuaryObjectBase inSanctuaryObject)
	{
	}

	public bool DoesFit(Vector3 inNormal)
	{
		return default(bool);
	}

	public void RefreshLastGoodPosition()
	{
	}

	[IteratorStateMachine(typeof(<InitPlacedObject>d__151))]
	private IEnumerator InitPlacedObject()
	{
		return null;
	}

	public void OnCollisionEnter(Collision inCollision)
	{
	}

	public bool BoxCast(int inLayermask, QueryTriggerInteraction inQueryTriggerInteraction, string inTag = "")
	{
		return default(bool);
	}

	public bool EdgeCast(int inLayermask, QueryTriggerInteraction inQueryTriggerInteraction, string inTag = "")
	{
		return default(bool);
	}

	public bool CornerCast(int inLayermask, QueryTriggerInteraction inQueryTriggerInteraction, string inTag = "")
	{
		return default(bool);
	}

	public bool HittingRigidbodyObject()
	{
		return default(bool);
	}

	public bool HittingStaticObject(out SanctuaryObjectBase outHitSanctuaryObject)
	{
		return default(bool);
	}

	public bool CollidingWithObject(out SanctuaryObjectBase outHitSanctuaryObject)
	{
		return default(bool);
	}

	public bool CanBePlaced(Vector3 inNormal)
	{
		return default(bool);
	}

	public bool DoesFit(out SanctuaryObjectBase outHitSanctuaryObject)
	{
		return default(bool);
	}

	private void OnDrawGizmosSelected()
	{
	}

	public bool FitsOnSurface()
	{
		return default(bool);
	}

	public void ServerUpdate(SanctuaryObjectBaseInfo inInfo)
	{
	}

	public void ExternalUpdateObject(bool inRemove = false)
	{
	}

	private void UpdateObject(bool inRemove = false)
	{
	}

	public void UIChangeState()
	{
	}

	private BoxCollider CreateTouchCollider()
	{
		return null;
	}

	private MeshCollider CreateMeshCollider()
	{
		return null;
	}

	public void UpdateDayNight(SanctuaryController.ETime inTime)
	{
	}

	public Vector3 GetLastGoodPosition(Vector3 inNormal)
	{
		return default(Vector3);
	}

	public Vector3 GetLastGoodRotation(Vector3 inNormal)
	{
		return default(Vector3);
	}

	public void SetTouchColliderActive(bool inActive)
	{
	}

	private bool Linecast(Vector3 inStart, Vector3 inEnd, int inLayermask, QueryTriggerInteraction inIgnore)
	{
		return default(bool);
	}
}
