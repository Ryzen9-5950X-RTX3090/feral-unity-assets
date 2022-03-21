using System.Collections.Generic;
using UnityEngine;

public static class FTransformMethods
{
	public static Transform FindChildByNameInDepth(string name, Transform transform)
	{
		return null;
	}

	public static List<T> FindComponentsInAllChildren<T>(Transform transformToSearchIn) where T : Component
	{
		return null;
	}

	public static T FindComponentInAllChildren<T>(Transform transformToSearchIn) where T : Component
	{
		return null;
	}

	public static T FindComponentInAllParents<T>(Transform transformToSearchIn) where T : Component
	{
		return null;
	}

	public static void ChangeActiveChildrenInside(Transform parentOfThem, bool active)
	{
	}

	public static void ChangeActiveThroughParentTo(Transform start, Transform end, bool active, bool changeParentsChildrenActivation = false)
	{
	}
}
