using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

[ManagedBehaviourManager("SanctuaryManager")]
public class SanctuaryIndoorRoom : ManagedBehaviour
{
	public enum EWall
	{
		FRONT,
		BACK,
		LEFT,
		RIGHT,
		ALL
	}

	public class Naming
	{
		public string back;

		public string front;

		public string left;

		public string right;

		public string main;

		public string entry;

		public string doorBlock;

		public string doorCeiling;

		public string doorWall;

		public string doorPortal;

		public string doorSpawn;

		public string fader;

		public string black;

		public string wall;

		public string floor;

		public string baseBoard;

		public string crownMolding;

		public string doortrim;

		public string ceiling;

		public string editLine;

		public string door;

		public string stairs;

		public string guardRail;

		public string stairsBlockerL;

		public string stairsBlockerR;

		public string stairsL;

		public string stairsR;

		public string stairsPortalL;

		public string stairsPortalR;

		public string stairsSpawnL;

		public string stairsSpawnR;

		public string floorNoStairs;

		public string bothStairs;

		public string stairsFloorL;

		public string stairsFloorR;

		public string wallNoStairs;
	}

	[Serializable]
	public class Data
	{
		public Transform main;

		public List<Transform> objects;

		public List<Transform> doorwayObjects;

		public List<Transform> doorwayWallObjects;

		public List<Transform> wallObjects;

		public List<Transform> floorObjects;

		public List<Transform> doorTrimObjects;

		public List<Transform> ceilingObjects;

		public List<Transform> surfaces;

		public Transform doorBlockerObject;

		public Transform spawn;

		public Transform portal;

		public Transform stairWallL;

		public Transform stairWallR;

		public Transform stairL;

		public Transform stairR;

		public Transform stairsPortalL;

		public Transform stairsPortalR;

		public Transform stairsSpawnL;

		public Transform stairsSpawnR;

		public Transform floorNoStairs;

		public Transform bothStairs;

		public Transform stairsFloorL;

		public Transform stairsFloorR;

		public Transform wallNoStairs;

		public Transform stairBlockerR;
	}

	public Transform toExterior;

	[Header("Stair Transitions")]
	public SanctuaryIndoorRoom toUpstairs;

	public SanctuaryIndoorRoom toDownstairs;

	[Header("Room Transitions")]
	public SanctuaryIndoorRoom toRoomL;

	public SanctuaryIndoorRoom toRoomR;

	public SanctuaryIndoorRoom toRoomF;

	public SanctuaryIndoorRoom toRoomB;

	[Header("Data")]
	public SanctuaryLayoutData.RoomData roomData;

	private int _roomIndex;

	private int _roomSizeIndex;

	public Naming naming;

	public Data frontData;

	public Data backData;

	public Data leftData;

	public Data rightData;

	public Data entryData;

	public Transform editLine;

	[Header("Infos")]
	public List<SanctuarySurface> sanctuarySurfaces;

	public List<SanctuarySurface> sanctuaryDoorSurfaces;

	public bool locked
	{
		get
		{
			return default(bool);
		}
	}

	public bool entry
	{
		get
		{
			return default(bool);
		}
	}

	public int roomIndex
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int roomSizeIndex
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public BoxCollider roomBoxCollider
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

	public SanctuaryObjectBase wallpaperBase
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

	public SanctuaryObjectBase flooringBase
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

	public SanctuaryObjectBase trimBase
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

	public SanctuaryObjectBase ceilingBase
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

	public List<Transform> allWalls
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

	public List<Transform> allFloors
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

	public List<Transform> allTrims
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

	public List<Transform> allCeilings
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

	public List<Transform> allFaders
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

	public List<Transform> allBlacks
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

	public Transform mainFloor
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

	public Transform mainCeiling
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

	public Transform editline
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

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	private void OnSanctuaryStateChangeMessage(SanctuaryStateChangeMessage inMessage)
	{
	}

	public void Setup(SanctuaryLayoutData inLayoutData)
	{
	}

	public void SetRoomBoxCollider(BoxCollider inBoxCollider)
	{
	}

	private void SetPortal(GameObject inGameObject, [Optional] Vector3? size, [Optional] Vector3? center)
	{
	}

	public void SetMaterial(SanctuaryItemCategory inCategory, Material inMaterial, SanctuaryObjectBase inSanctuaryObjectBase)
	{
	}

	public void SetRoomAddOns()
	{
	}

	private Data CreateObjectInfo(string inName, bool inEntryShown = false)
	{
		return null;
	}

	private void OnTriggerEnter(Collider inCollider)
	{
	}

	private void OnTriggerExit(Collider inCollider)
	{
	}

	public void SetRoomData(SanctuaryLayoutData.RoomData inRoomData)
	{
	}

	public void SetRoomIndex(int inRoomIdx)
	{
	}

	public void SetRoomSize(int inRoomSizeIdx)
	{
	}

	public List<Transform> GetSafeSpawns()
	{
		return null;
	}

	public Transform GetSpawnToEntry()
	{
		return null;
	}

	public Transform GetSpawnToRoomF()
	{
		return null;
	}

	public Transform GetSpawnToRoomB()
	{
		return null;
	}

	public Transform GetSpawnToRoomL()
	{
		return null;
	}

	public Transform GetSpawnToRoomR()
	{
		return null;
	}

	public Transform GetSpawnToUpstairs()
	{
		return null;
	}

	public Transform GetSpawnToDownstairs()
	{
		return null;
	}

	private void SetSurfaceInfo(SanctuaryLayoutData inLayoutData)
	{
	}

	private void SetSurfaceInfos(int inStartIdx)
	{
	}

	public bool HasSurface(SanctuarySurface inSanctuarySurface)
	{
		return default(bool);
	}
}
