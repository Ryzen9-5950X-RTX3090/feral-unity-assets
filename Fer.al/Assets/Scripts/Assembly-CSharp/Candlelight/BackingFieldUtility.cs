using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Candlelight
{
	public static class BackingFieldUtility
	{
		public enum IntKeyMode
		{
			Increment,
			SetToZero
		}

		private static T ConvertStringKeyToLower<T>(T stringKey)
		{
			return (T)null;
		}

		public static int GenerateSerializedPropertiesHash<T>(IList<T> listField) where T : IPropertyBackingFieldCompatible
		{
			return default(int);
		}

		public static T GetInterfaceBackingField<T>(ref T interfaceBackingField, UnityEngine.Object objectBackingField) where T : class
		{
			return null;
		}

		public static void GetKeyedListBackingFieldAsDict<T, TId, TData>(List<T> backingField, Dictionary<TId, TData> result, Func<T, TData> getData) where T : IIdentifiable<TId>
		{
		}

		private static bool SetHashedListBackingFieldFromArray<T>(List<T> backingField, IList<T> value, bool ignoreCase, IntKeyMode intKeyMode = IntKeyMode.Increment)
		{
			return default(bool);
		}

		public static bool SetHashedListBackingFieldFromIntArray(List<int> backingField, IList<int> value, IntKeyMode mode = IntKeyMode.Increment)
		{
			return default(bool);
		}

		public static bool SetHashedListBackingFieldFromObjectArray<T>(List<T> backingField, IList<T> value) where T : UnityEngine.Object
		{
			return default(bool);
		}

		public static bool SetHashedListBackingFieldFromStringArray(List<string> backingField, IList<string> value, bool ignoreCase = false)
		{
			return default(bool);
		}

		private static bool SetHashedListBackingFieldFromHashset<T>(List<T> backingField, HashSet<T> value, bool ignoreCase = false)
		{
			return default(bool);
		}

		public static bool SetHashedListBackingFieldFromIntHashset(List<int> backingField, HashSet<int> value)
		{
			return default(bool);
		}

		public static bool SetHashedListBackingFieldFromObjectHashset<T>(List<T> backingField, HashSet<T> value) where T : UnityEngine.Object
		{
			return default(bool);
		}

		public static bool SetHashedListBackingFieldFromStringHashset(List<string> backingField, HashSet<string> value, bool ignoreCase = false)
		{
			return default(bool);
		}

		public static bool SetInterfaceBackingField<T>(T value, ref T interfaceBackingField, ref UnityEngine.Object objectBackingField, [Optional] Action<T> onAssign, [Optional] Action<T> onUnassign) where T : class
		{
			return default(bool);
		}

		public static void SetInterfaceBackingFieldObject<T>(UnityEngine.Object value, ref UnityEngine.Object backingField, Action<T> setInterfaceProperty) where T : class
		{
		}

		private static bool SetKeyedListBackingFieldFromArray<T, TId>(List<T> backingField, IList<T> value, Func<TId, T, T> mutateIdentifier, bool ignoreCase, IntKeyMode intKeyMode = IntKeyMode.Increment) where T : IIdentifiable<TId>
		{
			return default(bool);
		}

		public static bool SetKeyedListBackingFieldFromIntKeyedArray<T>(List<T> backingField, IList<T> value, Func<int, T, T> mutateIdentifier, IntKeyMode mode = IntKeyMode.Increment) where T : IIdentifiable<int>
		{
			return default(bool);
		}

		public static bool SetKeyedListBackingFieldFromObjectKeyedArray<T, TId>(List<T> backingField, IList<T> value, Func<TId, T, T> mutateIdentifier) where T : IIdentifiable<TId> where TId : UnityEngine.Object
		{
			return default(bool);
		}

		public static bool SetKeyedListBackingFieldFromStringKeyedArray<T>(List<T> backingField, IList<T> value, Func<string, T, T> mutateIdentifier, bool ignoreCase = false) where T : IIdentifiable<string>
		{
			return default(bool);
		}

		private static bool SetKeyedListBackingFieldFromDict<TWrapper, TId, TData>(List<TWrapper> backingField, Dictionary<TId, TData> value, Func<TId, TData, TWrapper> factory, bool ignoreCase = false) where TWrapper : IdentifiableBackingFieldCompatibleObjectWrapper<TId, TData>
		{
			return default(bool);
		}

		public static bool SetKeyedListBackingFieldFromIntKeyedDict<TWrapper, TData>(List<TWrapper> backingField, Dictionary<int, TData> value, Func<int, TData, TWrapper> factory) where TWrapper : IdentifiableBackingFieldCompatibleObjectWrapper<int, TData>
		{
			return default(bool);
		}

		public static bool SetKeyedListBackingFieldFromObjectKeyedDict<TWrapper, TId, TData>(List<TWrapper> backingField, Dictionary<TId, TData> value, Func<TId, TData, TWrapper> factory) where TWrapper : IdentifiableBackingFieldCompatibleObjectWrapper<TId, TData> where TId : UnityEngine.Object
		{
			return default(bool);
		}

		public static bool SetKeyedListBackingFieldFromStringKeyedDict<TWrapper, TData>(List<TWrapper> backingField, Dictionary<string, TData> value, Func<string, TData, TWrapper> factory, bool ignoreCase = false) where TWrapper : IdentifiableBackingFieldCompatibleObjectWrapper<string, TData>
		{
			return default(bool);
		}
	}
}
