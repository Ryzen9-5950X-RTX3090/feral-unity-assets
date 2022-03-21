using UnityEngine;

namespace DG.Tweening
{
	public static class DOVirtual
	{
		public static Tweener Float(float from, float to, float duration, TweenCallback<float> onVirtualUpdate)
		{
			return null;
		}

		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType)
		{
			return default(float);
		}

		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float overshoot)
		{
			return default(float);
		}

		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float amplitude, float period)
		{
			return default(float);
		}

		public static float EasedValue(float from, float to, float lifetimePercentage, AnimationCurve easeCurve)
		{
			return default(float);
		}

		public static Tween DelayedCall(float delay, TweenCallback callback, bool ignoreTimeScale = true)
		{
			return null;
		}
	}
}
