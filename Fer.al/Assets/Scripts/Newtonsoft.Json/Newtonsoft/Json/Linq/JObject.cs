using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, INotifyPropertyChanged, ICustomTypeDescriptor, INotifyPropertyChanging
	{
		private class JObjectDynamicProxy : DynamicProxy<JObject>
		{
			public override IEnumerable<string> GetDynamicMemberNames(JObject instance)
			{
				return null;
			}
		}

		private readonly JPropertyKeyedCollection _properties;

		protected override IList<JToken> ChildrenTokens
		{
			get
			{
				return null;
			}
		}

		public override JTokenType Type
		{
			get
			{
				return default(JTokenType);
			}
		}

		public JToken this[string propertyName]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		ICollection<string> IDictionary<string, JToken>.Keys
		{
			get
			{
				return null;
			}
		}

		ICollection<JToken> IDictionary<string, JToken>.Values
		{
			get
			{
				return null;
			}
		}

		bool ICollection<KeyValuePair<string, JToken>>.IsReadOnly
		{
			get
			{
				return default(bool);
			}
		}

		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event PropertyChangingEventHandler PropertyChanging
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public JObject()
		{
		}

		public JObject(JObject other)
		{
		}

		internal override int IndexOfItem(JToken item)
		{
			return default(int);
		}

		internal override void InsertItem(int index, JToken item, bool skipParentCheck)
		{
		}

		internal override void ValidateToken(JToken o, JToken existing)
		{
		}

		internal void InternalPropertyChanged(JProperty childProperty)
		{
		}

		internal void InternalPropertyChanging(JProperty childProperty)
		{
		}

		internal override JToken CloneToken()
		{
			return null;
		}

		public IEnumerable<JProperty> Properties()
		{
			return null;
		}

		public JProperty Property(string name, StringComparison comparison)
		{
			return null;
		}

		public static JObject Load(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}

		public override void WriteTo(JsonWriter writer, JsonConverter[] converters)
		{
		}

		public void Add(string propertyName, JToken value)
		{
		}

		public bool ContainsKey(string propertyName)
		{
			return default(bool);
		}

		public bool Remove(string propertyName)
		{
			return default(bool);
		}

		public bool TryGetValue(string propertyName, out JToken value)
		{
			return default(bool);
		}

		void ICollection<KeyValuePair<string, JToken>>.Add(KeyValuePair<string, JToken> item)
		{
		}

		void ICollection<KeyValuePair<string, JToken>>.Clear()
		{
		}

		bool ICollection<KeyValuePair<string, JToken>>.Contains(KeyValuePair<string, JToken> item)
		{
			return default(bool);
		}

		void ICollection<KeyValuePair<string, JToken>>.CopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex)
		{
		}

		bool ICollection<KeyValuePair<string, JToken>>.Remove(KeyValuePair<string, JToken> item)
		{
			return default(bool);
		}

		[IteratorStateMachine(typeof(<GetEnumerator>d__63))]
		public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator()
		{
			return null;
		}

		protected virtual void OnPropertyChanged(string propertyName)
		{
		}

		protected virtual void OnPropertyChanging(string propertyName)
		{
		}

		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
		{
			return null;
		}

		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
		{
			return null;
		}

		AttributeCollection ICustomTypeDescriptor.GetAttributes()
		{
			return null;
		}

		string ICustomTypeDescriptor.GetClassName()
		{
			return null;
		}

		string ICustomTypeDescriptor.GetComponentName()
		{
			return null;
		}

		TypeConverter ICustomTypeDescriptor.GetConverter()
		{
			return null;
		}

		EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
		{
			return null;
		}

		PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
		{
			return null;
		}

		object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
		{
			return null;
		}

		EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
		{
			return null;
		}

		EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
		{
			return null;
		}

		object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
		{
			return null;
		}

		protected override DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return null;
		}
	}
}
