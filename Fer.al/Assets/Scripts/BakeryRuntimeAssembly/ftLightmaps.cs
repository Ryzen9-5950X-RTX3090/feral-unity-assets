using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ftLightmaps
{
	private struct LightmapAdditionalData
	{
		public Texture2D rnm0;

		public Texture2D rnm1;

		public Texture2D rnm2;

		public int mode;
	}

	private static List<int> lightmapRefCount;

	private static List<LightmapAdditionalData> globalMapsAdditional;

	private static bool directionalMode;

	static ftLightmaps()
	{
	}

	private static void OnSceneChangedPlay(Scene prev, Scene next)
	{
	}

	public static void RefreshFull()
	{
	}

	public static GameObject FindInScene(string nm, Scene scn)
	{
		return null;
	}

	private static Texture2D GetEmptyDirectionTex(ftLightmapsStorage storage)
	{
		return null;
	}

	public static void RefreshScene(Scene scene, [Optional] ftLightmapsStorage storage, bool updateNonBaked = false)
	{
	}

	public static void UnloadScene(ftLightmapsStorage storage)
	{
	}

	public static void RefreshScene2(Scene scene, ftLightmapsStorage storage)
	{
	}
}
