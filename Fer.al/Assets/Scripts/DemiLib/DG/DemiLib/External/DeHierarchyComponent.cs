using System;
using System.Collections.Generic;
using UnityEngine;

namespace DG.DemiLib.External
{
	public class DeHierarchyComponent : MonoBehaviour
	{
		public enum HColor
		{
			None,
			Blue,
			Green,
			Orange,
			Purple,
			Red,
			Yellow,
			BrightGrey,
			DarkGrey,
			Black,
			White
		}

		public enum IcoType
		{
			Dot,
			Star,
			Cog,
			Comment,
			UI,
			Play
		}

		[Serializable]
		public class CustomizedItem
		{
			public GameObject gameObject;

			public HColor hColor;

			public IcoType icoType;

			public CustomizedItem(GameObject gameObject, HColor hColor)
			{
			}

			public CustomizedItem(GameObject gameObject, IcoType icoType)
			{
			}
		}

		public List<CustomizedItem> customizedItems;

		public List<int> MissingItemsIndexes()
		{
			return null;
		}

		public void StoreItemColor(GameObject go, HColor hColor)
		{
		}

		public void StoreItemIcon(GameObject go, IcoType icoType)
		{
		}

		public bool RemoveItemData(GameObject go)
		{
			return default(bool);
		}

		public CustomizedItem GetItem(GameObject go)
		{
			return null;
		}
	}
}
