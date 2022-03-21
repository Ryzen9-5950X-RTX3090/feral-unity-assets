using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	public sealed class InputMapCategory : InputCategory
	{
		[SerializeField]
		[CustomObfuscation]
		private bool _checkConflictsWithAllCategories;

		[SerializeField]
		[CustomObfuscation]
		private List<int> _checkConflictsCategoryIds;

		private ReadOnlyCollection<int> _checkConflictsCategoryIds_readOnly;

		public bool checkConflictsWithAllCategories
		{
			get
			{
				return default(bool);
			}
			internal set
			{
			}
		}

		public IList<int> checkConflictsCategoryIds
		{
			get
			{
				return null;
			}
		}

		internal List<int> checkConflictsCategoryIds_orig
		{
			get
			{
				return null;
			}
		}

		public InputMapCategory()
		{
		}

		public InputMapCategory(InputMapCategory source)
		{
		}

		internal void ItdhavHGXcUkAhyjaCFbIXENJheh()
		{
		}
	}
}
