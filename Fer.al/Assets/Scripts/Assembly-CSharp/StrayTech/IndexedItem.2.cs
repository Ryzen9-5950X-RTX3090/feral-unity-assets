using System;
using UnityEngine;

namespace StrayTech
{
	[Serializable]
	public abstract class IndexedItem<TKey, TValue> : IValidates
	{
		[SerializeField]
		private TKey _ID;

		[SerializeField]
		private TValue _Value;

		public TKey ID
		{
			get
			{
				return (TKey)null;
			}
			protected set
			{
			}
		}

		public TValue Value
		{
			get
			{
				return (TValue)null;
			}
			protected set
			{
			}
		}

		public IndexedItem()
		{
		}

		public IndexedItem(TKey ID, TValue value)
		{
		}

		public abstract bool IsValid();
	}
}
