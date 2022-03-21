using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;
using Rewired.Utils.Attributes;
using Rewired.Utils.Interfaces;

namespace Rewired.Utils.Classes.Data
{
	[CustomClassObfuscation]
	[Preserve]
	[CustomObfuscation]
	internal sealed class SerializedObject : IEnumerable, IEnumerable<SerializedObject.Field>, IAddValue<object>, IAddKeyValue<string, object>, IExportToXml, IExportToJson
	{
		[CustomObfuscation]
		public enum ObjectType
		{
			[CustomObfuscation]
			Object,
			[CustomObfuscation]
			List
		}

		[Flags]
		[CustomObfuscation]
		public enum FieldOptions
		{
			[CustomObfuscation]
			None = 0,
			[CustomObfuscation]
			ExculdeFromXml = 1
		}

		private struct Entry
		{
			public Type type;

			public object value;

			public FieldOptions options;

			public Entry(Type type, object value, FieldOptions options)
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		[CustomObfuscation]
		[CustomClassObfuscation]
		public struct Field
		{
			public string name;

			public object value;

			public Type type;

			public FieldOptions options;

			public Field(string name, object value, Type type, FieldOptions options)
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		[CustomClassObfuscation]
		[CustomObfuscation]
		public class XmlInfo
		{
			public abstract class XmlAttribute
			{
			}

			public class XmlStringAttribute : XmlAttribute
			{
				public string prefix;

				public string localName;

				public string ns;

				public string value;

				public override string ToString()
				{
					return null;
				}
			}

			private List<XmlAttribute> CjCObhIbdjJBbcPIpPIfpHmiUPx;

			public List<XmlAttribute> attributes
			{
				get
				{
					return null;
				}
			}

			public override string ToString()
			{
				return null;
			}
		}

		[CustomClassObfuscation]
		[CustomObfuscation]
		public struct Enumerator : IDisposable, IEnumerator, IEnumerator<Field>
		{
			private IndexedDictionary<string, Entry> PPzpPGLKIynvruBNxkGUfOVeEjO;

			private Field hXsQEjeqlbsWHdImyyWjqLiDOxk;

			private IEnumerator<KeyValuePair<string, Entry>> KkUPIlZfykaAVAeYrQJjyKHWghgJ;

			public Field Current
			{
				get
				{
					return default(Field);
				}
			}

			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			internal Enumerator(object dictionary)
			{
			}

			public bool MoveNext()
			{
				return default(bool);
			}

			public void Dispose()
			{
			}

			void IEnumerator.Reset()
			{
			}
		}

		private class XmlDocument
		{
			public class Element
			{
				public readonly string name;

				public readonly Element parent;

				public string content;

				public Dictionary<string, string> attributes;

				public List<Element> children;

				public int childCount
				{
					get
					{
						return default(int);
					}
				}

				public int attributeCount
				{
					get
					{
						return default(int);
					}
				}

				public Element(string name, Element parent)
				{
				}

				public void AddChild(Element element)
				{
				}

				public void AddAttribute(string key, string value)
				{
				}

				public bool ContainsChild(string name)
				{
					return default(bool);
				}

				public Element FindChild(string name)
				{
					return null;
				}

				public object GetSerializedObject()
				{
					return null;
				}

				public override string ToString()
				{
					return null;
				}

				private string ToString(string s, int indent)
				{
					return null;
				}
			}

			private readonly Element _root;

			public Element root
			{
				get
				{
					return null;
				}
			}

			public bool isValid
			{
				get
				{
					return default(bool);
				}
			}

			public XmlDocument(string xml)
			{
			}

			private void ReadAll(XmlReader reader)
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		private readonly IndexedDictionary<string, Entry> ySajSnFbKHgdVuFdAWJcCwTpOXg;

		private XmlInfo sMQZevdFTstQSGQKnEcYIUdKaQg;

		private Type qYQtZXCUUQiyGpzdDXLOHBOwcPe;

		private ObjectType pEOEuicaoSrPbieyGjgaTOirLUe;

		private static readonly Dictionary<Type, Dictionary<string, FieldInfo>> mtjDgwrsKHLyGpZcHneeBeJiCIF;

		private static readonly Dictionary<Type, Dictionary<string, PropertyInfo>> KzybAcqvobVRsvNuDNHGjeCrgkWj;

		[CompilerGenerated]
		private static Func<FieldInfo, bool> rMADKvwwlBDxGizQaeqoBdFZwld;

		[CompilerGenerated]
		private static Func<FieldInfo, string> JTCXEGDxEOeUKhqiWcgWTpItzfs;

		[CompilerGenerated]
		private static Func<PropertyInfo, bool> qKeWAGlhnvzAfpdHfrtZXCbPGPfH;

		[CompilerGenerated]
		private static Func<PropertyInfo, string> EWlhMlrDrFKXLfmWfTVIDnhEqEQ;

		private bool allowDuplicateKeys
		{
			get
			{
				return default(bool);
			}
		}

		public ObjectType objectType
		{
			get
			{
				return default(ObjectType);
			}
			set
			{
			}
		}

		public Type type
		{
			get
			{
				return null;
			}
		}

		public XmlInfo xmlInfo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int count
		{
			get
			{
				return default(int);
			}
		}

		public Field this[int index]
		{
			get
			{
				return default(Field);
			}
		}

		bool IExportToXml.writesOwnElementTag
		{
			get
			{
				return default(bool);
			}
		}

		[CustomObfuscation]
		private SerializedObject()
		{
		}

		private SerializedObject(int capacity)
		{
		}

		public SerializedObject(Type type, ObjectType objectType)
		{
		}

		public SerializedObject(Type type, ObjectType objectType, int capacity)
		{
		}

		public SerializedObject(Type type, IDictionary<string, object> dictionary, ObjectType objectType)
		{
		}

		public void Add<T>(string fieldName, T value, FieldOptions options = FieldOptions.None)
		{
		}

		public void Add(Type type, string fieldName, object value, FieldOptions options = FieldOptions.None)
		{
		}

		public void Add(string fieldName, object value)
		{
		}

		public bool Remove(string fieldName)
		{
			return default(bool);
		}

		public bool Contains(string fieldName)
		{
			return default(bool);
		}

		public Type GetDataType(string fieldName)
		{
			return null;
		}

		public bool TryGetOriginalValue(string fieldName, out object value)
		{
			return default(bool);
		}

		public Field GetEntry(string fieldName)
		{
			return default(Field);
		}

		public object GetOriginalValue(string fieldName)
		{
			return null;
		}

		public object GetOriginalValue(int index)
		{
			return null;
		}

		public T GetOriginalValue<T>(string fieldName)
		{
			return (T)null;
		}

		public T GetOriginalValue<T>(int index)
		{
			return (T)null;
		}

		public bool TryGetDeserializedValue<T>(string fieldName, out T value)
		{
			return default(bool);
		}

		public bool TryGetDeserializedValue<T>(int index, out T value)
		{
			return default(bool);
		}

		public bool TryGetDeserializedValueByRef<T>(string fieldName, ref T value)
		{
			return default(bool);
		}

		public bool TryGetDeserializedValueByRef<T>(int index, ref T value)
		{
			return default(bool);
		}

		public string ToXmlString(bool writeDocumentTag)
		{
			return null;
		}

		public string ToJsonString()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		private void WriteXml(XmlWriter writer)
		{
		}

		private void WriteXml_Value(XmlWriter writer)
		{
		}

		void IExportToXml.WriteXml(XmlWriter writer)
		{
		}

		void IExportToJson.WriteJson(StringBuilder stringBuilder, Action<StringBuilder, object> appendValueDelegate)
		{
		}

		void IAddValue<object>.Add(object value)
		{
		}

		void IAddKeyValue<string, object>.Add(string key, object value)
		{
		}

		IEnumerator<Field> IEnumerable<Field>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		private static bool TryConvertOrCreateObject<T>(object obj, out T result, NumberStyles numberStyle = NumberStyles.Any, [Optional] CultureInfo cultureInfo)
		{
			return default(bool);
		}

		private static bool TryConvertOrCreateObject(Type targetType, object obj, out object result, NumberStyles numberStyle = NumberStyles.Any, [Optional] CultureInfo cultureInfo)
		{
			return default(bool);
		}

		private static bool TryCreateObject(Type type, SerializedObject serializedObject, out object result, NumberStyles numberStyle = NumberStyles.Any, [Optional] CultureInfo cultureInfo)
		{
			return default(bool);
		}

		public static SerializedObject FromJson(Type type, string jsonString)
		{
			return null;
		}

		public static SerializedObject FromXml(Type type, string xmlString)
		{
			return null;
		}

		[CompilerGenerated]
		private static bool hTMmGFUzslkPOpeckvSuGKZifFM(FieldInfo P_0)
		{
			return default(bool);
		}

		[CompilerGenerated]
		private static string EOKBSkHDOwjZsiFoXGItfFheNaH(FieldInfo P_0)
		{
			return null;
		}

		[CompilerGenerated]
		private static bool dfbvxYLwDGmNWNvGvVcTWxGNSDW(PropertyInfo P_0)
		{
			return default(bool);
		}

		[CompilerGenerated]
		private static string sxEANbGdTKXGUGDohUfWhrwXRnqk(PropertyInfo P_0)
		{
			return null;
		}
	}
}
