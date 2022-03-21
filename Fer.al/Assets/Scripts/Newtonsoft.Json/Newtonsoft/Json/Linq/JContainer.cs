using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Newtonsoft.Json.Linq
{
	public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, ITypedList, IBindingList, ICollection, IList
	{
		internal ListChangedEventHandler _listChanged;

		internal AddingNewEventHandler _addingNew;

		internal NotifyCollectionChangedEventHandler _collectionChanged;

		private object _syncRoot;

		private bool _busy;

		protected abstract IList<JToken> ChildrenTokens { get; }

		public override bool HasValues
		{
			get
			{
				return default(bool);
			}
		}

		public override JToken First
		{
			get
			{
				return null;
			}
		}

		public override JToken Last
		{
			get
			{
				return null;
			}
		}

		JToken IList<JToken>.this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		bool ICollection<JToken>.IsReadOnly
		{
			get
			{
				return default(bool);
			}
		}

		bool IList.IsFixedSize
		{
			get
			{
				return default(bool);
			}
		}

		bool IList.IsReadOnly
		{
			get
			{
				return default(bool);
			}
		}

		object IList.this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		bool ICollection.IsSynchronized
		{
			get
			{
				return default(bool);
			}
		}

		object ICollection.SyncRoot
		{
			get
			{
				return null;
			}
		}

		bool IBindingList.AllowEdit
		{
			get
			{
				return default(bool);
			}
		}

		bool IBindingList.AllowNew
		{
			get
			{
				return default(bool);
			}
		}

		bool IBindingList.AllowRemove
		{
			get
			{
				return default(bool);
			}
		}

		bool IBindingList.IsSorted
		{
			get
			{
				return default(bool);
			}
		}

		ListSortDirection IBindingList.SortDirection
		{
			get
			{
				return default(ListSortDirection);
			}
		}

		PropertyDescriptor IBindingList.SortProperty
		{
			get
			{
				return null;
			}
		}

		bool IBindingList.SupportsChangeNotification
		{
			get
			{
				return default(bool);
			}
		}

		bool IBindingList.SupportsSearching
		{
			get
			{
				return default(bool);
			}
		}

		bool IBindingList.SupportsSorting
		{
			get
			{
				return default(bool);
			}
		}

		public event ListChangedEventHandler ListChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		internal JContainer()
		{
		}

		internal JContainer(JContainer other)
		{
		}

		internal void CheckReentrancy()
		{
		}

		protected virtual void OnAddingNew(AddingNewEventArgs e)
		{
		}

		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
		}

		protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
		{
		}

		public override JEnumerable<JToken> Children()
		{
			return default(JEnumerable<JToken>);
		}

		internal bool IsMultiContent(object content)
		{
			return default(bool);
		}

		internal JToken EnsureParentToken(JToken item, bool skipParentCheck)
		{
			return null;
		}

		internal abstract int IndexOfItem(JToken item);

		internal virtual void InsertItem(int index, JToken item, bool skipParentCheck)
		{
		}

		internal virtual void RemoveItemAt(int index)
		{
		}

		internal virtual bool RemoveItem(JToken item)
		{
			return default(bool);
		}

		internal virtual JToken GetItem(int index)
		{
			return null;
		}

		internal virtual void SetItem(int index, JToken item)
		{
		}

		internal virtual void ClearItems()
		{
		}

		internal virtual void ReplaceItem(JToken existing, JToken replacement)
		{
		}

		internal virtual bool ContainsItem(JToken item)
		{
			return default(bool);
		}

		internal virtual void CopyItemsTo(Array array, int arrayIndex)
		{
		}

		internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue)
		{
			return default(bool);
		}

		internal virtual void ValidateToken(JToken o, JToken existing)
		{
		}

		public virtual void Add(object content)
		{
		}

		internal void AddAndSkipParentCheck(JToken token)
		{
		}

		internal void AddInternal(int index, object content, bool skipParentCheck)
		{
		}

		internal static JToken CreateFromContent(object content)
		{
			return null;
		}

		public void RemoveAll()
		{
		}

		internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options)
		{
		}

		internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings)
		{
		}

		private static JProperty ReadProperty(JsonReader r, JsonLoadSettings settings, IJsonLineInfo lineInfo, JContainer parent)
		{
			return null;
		}

		string ITypedList.GetListName(PropertyDescriptor[] listAccessors)
		{
			return null;
		}

		PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			return null;
		}

		int IList<JToken>.IndexOf(JToken item)
		{
			return default(int);
		}

		void IList<JToken>.Insert(int index, JToken item)
		{
		}

		void IList<JToken>.RemoveAt(int index)
		{
		}

		void ICollection<JToken>.Add(JToken item)
		{
		}

		void ICollection<JToken>.Clear()
		{
		}

		bool ICollection<JToken>.Contains(JToken item)
		{
			return default(bool);
		}

		void ICollection<JToken>.CopyTo(JToken[] array, int arrayIndex)
		{
		}

		bool ICollection<JToken>.Remove(JToken item)
		{
			return default(bool);
		}

		private JToken EnsureValue(object value)
		{
			return null;
		}

		int IList.Add(object value)
		{
			return default(int);
		}

		void IList.Clear()
		{
		}

		bool IList.Contains(object value)
		{
			return default(bool);
		}

		int IList.IndexOf(object value)
		{
			return default(int);
		}

		void IList.Insert(int index, object value)
		{
		}

		void IList.Remove(object value)
		{
		}

		void IList.RemoveAt(int index)
		{
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		void IBindingList.AddIndex(PropertyDescriptor property)
		{
		}

		object IBindingList.AddNew()
		{
			return null;
		}

		void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction)
		{
		}

		int IBindingList.Find(PropertyDescriptor property, object key)
		{
			return default(int);
		}

		void IBindingList.RemoveIndex(PropertyDescriptor property)
		{
		}

		void IBindingList.RemoveSort()
		{
		}
	}
}
