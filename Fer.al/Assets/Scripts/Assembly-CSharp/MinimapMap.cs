using System;
using UnityEngine;

[ManagedBehaviourManager("MinimapManager")]
public class MinimapMap : ManagedBehaviour
{
	[Serializable]
	public class MapImageInfo
	{
		public Sprite mapImage;

		public float farClip;

		public float mapHeight;

		public bool showBounds;
	}

	[SerializeField]
	private LayerMask _cullingMask;

	[SerializeField]
	private bool _hideTerrainObjects;

	[SerializeField]
	private bool _hideTerrain;

	[SerializeField]
	private GameObject[] _hideObjects;

	[SerializeField]
	private Vector3 _mapCenter;

	[SerializeField]
	private float _mapSize;

	private int _mapTextureSize;

	[SerializeField]
	private bool _flip180;

	private int _mapTextureCount;

	public MapImageInfo[] mapImageInfos;

	private float _mapUnitScale;

	public LayerMask cullingMask
	{
		get
		{
			return default(LayerMask);
		}
	}

	public bool hideTerrainObjects
	{
		get
		{
			return default(bool);
		}
	}

	public bool hideTerrain
	{
		get
		{
			return default(bool);
		}
	}

	public GameObject[] hideObjects
	{
		get
		{
			return null;
		}
	}

	public Vector3 mapCenter
	{
		get
		{
			return default(Vector3);
		}
	}

	public float mapSize
	{
		get
		{
			return default(float);
		}
	}

	public int mapTextureSize
	{
		get
		{
			return default(int);
		}
	}

	public bool flip180
	{
		get
		{
			return default(bool);
		}
	}

	public int mapTextureCount
	{
		get
		{
			return default(int);
		}
	}

	public float mapUnitScale
	{
		get
		{
			return default(float);
		}
	}

	private void OnDrawGizmosSelected()
	{
	}
}
