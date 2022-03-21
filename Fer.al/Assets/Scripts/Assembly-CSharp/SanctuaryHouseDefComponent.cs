using System;
using System.Collections.Generic;
using UnityEngine;

[ChartComponent("Sanctuary House")]
public class SanctuaryHouseDefComponent : DefComponent, IItemDefComponent
{
	[Serializable]
	public class Expansion
	{
		[ChartInt]
		public int number;

		[ChartList]
		public List<ChartDef> modelLists;
	}

	[Serializable]
	public class HouseNaming
	{
		[ChartList]
		[ChartString]
		public List<string> exteriorInteriorFloor;

		[ChartList]
		[ChartString]
		public List<string> exteriorInteriorWall;
	}

	[Serializable]
	public class EntryPortal
	{
		[ChartVector3]
		public Vector3 localPosition;

		[ChartVector3]
		public Vector3 localScale;

		[ChartVector3]
		public Vector3 safeSpawnPosition;

		[ChartVector3]
		public Vector3 safeSpawnRotation;
	}

	[Serializable]
	public class TwiggleBuildLocation
	{
		[ChartVector3]
		public Vector3 position;

		[ChartVector3]
		public Vector3 rotation;
	}

	[ChartClass]
	public HouseNaming houseNaming;

	[ChartClass]
	public EntryPortal entryPortal;

	[ChartList]
	public List<Expansion> baseExpansions;

	[ChartList]
	public List<Expansion> edgeExpansions;

	[ChartList]
	public List<Expansion> decorExpansions;

	[ChartList]
	public List<Expansion> shrubExpansions;

	[ChartList]
	public List<Expansion> doorExpansions;

	[ChartList]
	public List<Expansion> lightExpansions;

	[ChartList]
	public List<Expansion> roofExpansions;

	[ChartList]
	public List<Expansion> windowExpansions;

	[ChartList]
	public List<ChartDef> expansions;

	[ChartList]
	public List<ChartDef> upgrades;

	[ChartList]
	public List<TwiggleBuildLocation> twiggleBuildLocations;

	[ChartBundle]
	public ChartBundle layoutData;

	public void OnClientOnlyItemCreated(Item item)
	{
	}
}
