using UnityEngine;

public static class CoreCameraExtensions
{
	public static void LayerCullingShow(this Camera cam, int layerMask)
	{
	}

	public static void LayerCullingShow(this Camera cam, string layer)
	{
	}

	public static void LayerCullingHide(this Camera cam, int layerMask)
	{
	}

	public static void LayerCullingHide(this Camera cam, string layer)
	{
	}

	public static void LayerCullingToggle(this Camera cam, int layerMask)
	{
	}

	public static void LayerCullingToggle(this Camera cam, string layer)
	{
	}

	public static bool LayerCullingIncludes(this Camera cam, int layerMask)
	{
		return default(bool);
	}

	public static bool LayerCullingIncludes(this Camera cam, string layer)
	{
		return default(bool);
	}

	public static void LayerCullingToggle(this Camera cam, int layerMask, bool isOn)
	{
	}

	public static void LayerCullingToggle(this Camera cam, string layer, bool isOn)
	{
	}
}
