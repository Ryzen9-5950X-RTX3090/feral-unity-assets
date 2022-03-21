using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using UnityEngine;

namespace Candlelight
{
	public static class ObjectX
	{
		private static readonly Regex s_MatchPrefabName;

		public static bool AreObjectSequencesEqual<T>(IList<T> list1, IList<T> list2) where T : UnityEngine.Object
		{
			return default(bool);
		}

		public static bool AreStructSequencesEqual<T>(IList<T> list1, IList<T> list2) where T : struct, IEquatable<T>
		{
			return default(bool);
		}

		public static int GenerateHashCode(int hash1, int hash2)
		{
			return default(int);
		}

		public static int GenerateHashCode(int hash1, int hash2, int hash3)
		{
			return default(int);
		}

		public static int GenerateHashCode(int hash1, int hash2, int hash3, int hash4)
		{
			return default(int);
		}

		public static int GenerateHashCode(int hash1, int hash2, int hash3, int hash4, int hash5)
		{
			return default(int);
		}

		public static int GenerateHashCode(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6)
		{
			return default(int);
		}

		public static int GenerateHashCode(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7)
		{
			return default(int);
		}

		public static int GenerateHashCode(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7, int hash8)
		{
			return default(int);
		}

		public static int GenerateHashCode(IList<int> fieldHashes)
		{
			return default(int);
		}

		public static int GenerateHashCode<T>(IList<T> listField)
		{
			return default(int);
		}

		[Conditional("UNITY_EDITOR")]
		public static void GetAllTypes(HashSet<Type> allTypes)
		{
		}

		public static T GetFromPool<T>(List<T> pool, T prefab, [Optional] Transform parent, [Optional] Predicate<T> isElementSuitable) where T : Component
		{
			return null;
		}

		public static string GetPrefabName(this UnityEngine.Object instance)
		{
			return null;
		}

		public static void OpenReferencePage(this UnityEngine.Object obj, string product, string urlFormat = "http://candlelightinteractive.com/docs/{0}/html/T_{1}.htm?ref=editor")
		{
		}

		[Obsolete]
		public static bool Equals<T>(ref T thisObj, object otherObj) where T : struct
		{
			return default(bool);
		}
	}
}
