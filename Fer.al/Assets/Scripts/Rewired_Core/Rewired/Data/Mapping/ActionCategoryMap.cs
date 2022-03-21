using System;
using System.Collections.Generic;
using UnityEngine;

namespace Rewired.Data.Mapping
{
	[Serializable]
	public sealed class ActionCategoryMap
	{
		[Serializable]
		public class Entry
		{
			public int categoryId;

			public List<int> actionIds;

			public IEnumerable<int> ActionIds
			{
				get
				{
					return null;
				}
			}

			public Entry()
			{
			}

			public Entry(int categoryId)
			{
			}

			public Entry(Entry source)
			{
			}

			public void AddAction(int actionId)
			{
			}

			public bool InsertAction(int actionId, int index)
			{
				return default(bool);
			}

			public bool ReorderAction(int actionId, bool offsetDown, bool offsetNow)
			{
				return default(bool);
			}

			public void RemoveAction(int actionId)
			{
			}

			public int IndexOfAction(int id)
			{
				return default(int);
			}

			public bool ContainsAction(int id)
			{
				return default(bool);
			}

			public Entry Clone()
			{
				return null;
			}
		}

		[CustomObfuscation]
		[SerializeField]
		private List<Entry> list;

		public IEnumerable<int> ActionIdsInCategory(int categoryId)
		{
			return null;
		}

		public ActionCategoryMap()
		{
		}

		public ActionCategoryMap(ActionCategoryMap source)
		{
		}

		public void AddCategory(int id)
		{
		}

		public void RemoveCategory(int id)
		{
		}

		public bool ReorderCategory(int id, bool offsetDown)
		{
			return default(bool);
		}

		public bool ChangeCategory(int actionId, int newCategoryId)
		{
			return default(bool);
		}

		public int IndexOfCategory(int id)
		{
			return default(int);
		}

		public bool AddAction(int categoryId, int actionId)
		{
			return default(bool);
		}

		public bool InsertAction(int categoryId, int actionId, int index)
		{
			return default(bool);
		}

		public bool ReorderAction(int categoryId, int actionId, bool offsetDown, bool offsetNow)
		{
			return default(bool);
		}

		public void RemoveAction(int categoryId, int actionId)
		{
		}

		public int IndexOfAction(int categoryId, int actionId)
		{
			return default(int);
		}

		public ActionCategoryMap Clone()
		{
			return null;
		}
	}
}
