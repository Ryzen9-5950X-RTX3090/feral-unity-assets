using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace StrayTech
{
	public static class GameObjectExtension
	{
		public static void CopyLocalTransform(this GameObject self, GameObject other)
		{
		}

		public static void CopyLocalTransform(this Transform self, Transform other)
		{
		}

		public static void ResetLocalTransform(this Transform self)
		{
		}

		public static void NiceifyGameobjectName(this GameObject current, string prefix = "", string suffix = "", [Optional] List<string> substringsToRemove)
		{
		}

		public static T GetInterface<T>(this GameObject toSearch) where T : class
		{
			return null;
		}

		public static T[] GetInterfaces<T>(this GameObject toSearch) where T : class
		{
			return null;
		}

		public static T[] GetInterfacesInChildren<T>(this GameObject toSearch, bool includeInactive, bool searchSelf = false) where T : class
		{
			return null;
		}

		public static T GetInterfaceInChildren<T>(this GameObject toSearch, bool includeInactive) where T : class
		{
			return null;
		}

		public static TMonoBehaviour AddOrGetComponent<TMonoBehaviour>(this GameObject source) where TMonoBehaviour : Component
		{
			return null;
		}

		public static T GetComponentUpwards<T>(this GameObject toSearch, bool searchSelfFirst = false) where T : Component
		{
			return null;
		}

		public static GameObject GetFirstChild(this GameObject toSearch)
		{
			return null;
		}

		public static GameObject CreateChild(this GameObject parent, string name)
		{
			return null;
		}

		public static GameObject FindChildDeep(this Transform parent, string name)
		{
			return null;
		}

		public static T GetComponentInChildren<T>(this GameObject component, bool includeInactive) where T : Component
		{
			return null;
		}

		public static T GetComponentInChildren<T>(this Component component, bool includeInactive) where T : Component
		{
			return null;
		}

		public static GameObject FindOrCreate(string name)
		{
			return null;
		}

		public static void LookAtXZ(this Transform self, Transform target)
		{
		}

		public static void LookAtXZ(this Transform self, Vector3 worldTarget)
		{
		}

		public static Transform AddOrGetChild(this Transform parent, string childName)
		{
			return null;
		}

		public static GameObject FindChild(this GameObject self, string childName)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<FindAllInterfaces>d__20<>))]
		public static IEnumerable<T> FindAllInterfaces<T>() where T : class
		{
			return null;
		}

		public static bool IsNullOrInvalid(this IValidates self)
		{
			return default(bool);
		}

		[IteratorStateMachine(typeof(<ScrapeInterfaces>d__22<>))]
		public static IEnumerable<TInterface> ScrapeInterfaces<TInterface>(this IEnumerable<GameObject> self) where TInterface : class
		{
			return null;
		}

		public static string FullPath(this GameObject self)
		{
			return null;
		}

		public static string FullPath(this Component self)
		{
			return null;
		}

		public static List<GameObject> GetAllChildren(this GameObject self)
		{
			return null;
		}

		public static void GetAllChildren(this GameObject self, ref List<GameObject> toPopulate)
		{
		}

		[IteratorStateMachine(typeof(<GetComponentsInChildren>d__27<>))]
		public static IEnumerable<T> GetComponentsInChildren<T>(this Component self, Predicate<T> filter, bool includeInactive = false) where T : Component
		{
			return null;
		}

		public static T GetComponentInChildren<T>(this Component self, Predicate<T> filter) where T : Component
		{
			return null;
		}

		public static T GetComponentFromLoadedResource<T>(string resourcePath) where T : Component
		{
			return null;
		}
	}
}
