using UnityEngine;

namespace Lean.Common
{
	public static class LeanHelper
	{
		public const string HelpUrlPrefix = "https://carloswilkes.github.io/Documentation/";

		public const string ComponentPathPrefix = "Lean/";

		public static T CreateElement<T>(Transform parent) where T : Component
		{
			return null;
		}

		public static float DampenFactor(float dampening, float elapsed)
		{
			return default(float);
		}

		public static T Destroy<T>(T o) where T : Object
		{
			return null;
		}
	}
}
