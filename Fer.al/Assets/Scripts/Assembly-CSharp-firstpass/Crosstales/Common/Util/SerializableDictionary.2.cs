using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Crosstales.Common.Util
{
	[Serializable]
	public class SerializableDictionary<TKey, TVal> : Dictionary<TKey, TVal>, IXmlSerializable, ISerializable
	{
		private const string ItemNodeName = "Item";

		private const string KeyNodeName = "Key";

		private const string ValueNodeName = "Value";

		private XmlSerializer keySerializer;

		private XmlSerializer valueSerializer;

		private XmlSerializer ValueSerializer
		{
			get
			{
				return null;
			}
		}

		private XmlSerializer KeySerializer
		{
			get
			{
				return null;
			}
		}

		public SerializableDictionary()
		{
		}

		public SerializableDictionary(IDictionary<TKey, TVal> dictionary)
		{
		}

		public SerializableDictionary(IEqualityComparer<TKey> comparer)
		{
		}

		public SerializableDictionary(int capacity)
		{
		}

		public SerializableDictionary(IDictionary<TKey, TVal> dictionary, IEqualityComparer<TKey> comparer)
		{
		}

		public SerializableDictionary(int capacity, IEqualityComparer<TKey> comparer)
		{
		}

		protected SerializableDictionary(SerializationInfo info, StreamingContext context)
		{
		}

		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}

		void IXmlSerializable.ReadXml(XmlReader reader)
		{
		}

		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}
	}
}
