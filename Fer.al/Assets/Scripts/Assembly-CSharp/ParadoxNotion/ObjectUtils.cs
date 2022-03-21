using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace ParadoxNotion
{
	public static class ObjectUtils
	{
		public static bool AnyEquals(object a, object b)
		{
			return default(bool);
		}

		public static List<T> Shuffle<T>(this List<T> list)
		{
			return null;
		}

		public static bool Is<T>(this object o, out T result)
		{
			return default(bool);
		}

		public static T GetAddComponent<T>(this GameObject gameObject) where T : Component
		{
			return null;
		}

		public static Component TransformToType(this Component current, Type type)
		{
			return null;
		}

		public static IEnumerable<GameObject> FindGameObjectsWithinLayerMask(LayerMask mask, [Optional] GameObject exclude)
		{
			return null;
		}

		public static bool IsInLayerMask(this GameObject gameObject, LayerMask mask)
		{
			return default(bool);
		}
	}
}
