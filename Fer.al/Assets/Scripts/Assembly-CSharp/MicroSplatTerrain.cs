using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[DisallowMultipleComponent]
public class MicroSplatTerrain : MicroSplatObject
{
	public delegate void MaterialSyncAll();

	public delegate void MaterialSync(Material m);

	private static List<MicroSplatTerrain> sInstances;

	public Terrain terrain;

	[HideInInspector]
	public Texture2D customControl0;

	[HideInInspector]
	public Texture2D customControl1;

	[HideInInspector]
	public Texture2D customControl2;

	[HideInInspector]
	public Texture2D customControl3;

	[HideInInspector]
	public Texture2D customControl4;

	[HideInInspector]
	public Texture2D customControl5;

	[HideInInspector]
	public Texture2D customControl6;

	[HideInInspector]
	public Texture2D customControl7;

	[HideInInspector]
	public bool reenabled;

	public static event MaterialSyncAll OnMaterialSyncAll
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event MaterialSync OnMaterialSync
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void Cleanup()
	{
	}

	public override TerrainDescriptor GetTerrainDescriptor()
	{
		return default(TerrainDescriptor);
	}

	public void Sync()
	{
	}

	public override Bounds GetBounds()
	{
		return default(Bounds);
	}

	public new static void SyncAll()
	{
	}
}
