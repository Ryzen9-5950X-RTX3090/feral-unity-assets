using UnityEngine;

public static class FAnimatorMethods
{
	public static void LerpFloatValue(Animator animator, string name = "RunWalk", float value = 0f, float deltaSpeed = 8f)
	{
	}

	public static bool CheckAnimationEnd(Animator animator, int layer = 0, bool reverse = false, bool checkAnimLoop = true)
	{
		return default(bool);
	}

	public static void ResetLayersWeights(Animator animator, float speed = 10f)
	{
	}

	public static void LerpLayerWeight(Animator animator, int layer = 0, float newValue = 1f, float speed = 8f)
	{
	}

	public static bool StateExists(Animator animator, string clipName, int layer = 0)
	{
		return default(bool);
	}
}
