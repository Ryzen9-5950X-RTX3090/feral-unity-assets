using System;
using System.Collections.Generic;
using UnityEngine;

public class WorldMapData
{
	[Serializable]
	public class WorldMapInfo
	{
		[HideInInspector]
		public string level;

		public string uniqueMapId;

		public string localization;

		public MinimapManager.EBlipType worldBlipType;

		public Vector2 worldMapPosition;

		public Vector3 scenePosition;

		public Vector3 sceneRotation;
	}

	private static WorldMapData _instance;

	public List<WorldMapInfo> worldMapInfos;

	public static WorldMapData instance
	{
		get
		{
			return null;
		}
	}
}
