using DG.Tweening;
using UnityEngine;

public static class DOTweenSettingsExtensionsAddon
{
	public static T SetFrom<T>(this T t, bool isFrom, bool isRelative) where T : Tweener
	{
		return null;
	}

	public static T SetEase<T>(this T t, Ease ease, AnimationCurve animCurve) where T : Tweener
	{
		return null;
	}

	public static T Pause<T>(this T t, bool doPause) where T : Tween
	{
		return null;
	}
}
