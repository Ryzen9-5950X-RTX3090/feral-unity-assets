using System.Xml;

namespace Rewired.Utils
{
	public static class SerializationTools
	{
		public static string SerializeObjectToXmlString<T>(T obj)
		{
			return null;
		}

		public static void WriteXmlElement(XmlWriter writer, string name, object value)
		{
		}

		public static void WriteXmlElement<T>(XmlWriter writer, string name, T value)
		{
		}

		private static void KLKUswJvjFGJaorCZEWHfSWexmG(XmlWriter P_0, object P_1)
		{
		}

		public static string ReadXmlElement(XmlReader reader, string name)
		{
			return null;
		}

		public static T ReadXmlElement<T>(XmlReader reader, string name)
		{
			return (T)null;
		}

		public static bool TryReadXmlElement(XmlReader reader, string name, out string outValue)
		{
			return default(bool);
		}

		public static bool TryReadXmlElement<T>(XmlReader reader, string name, out T outValue)
		{
			return default(bool);
		}

		public static bool TryReadXmlElement<T>(XmlReader reader, string name, out T outValue, T defaultValue)
		{
			return default(bool);
		}

		public static bool TryReadXmlStartElement(XmlReader reader, string name, out bool isEmpty)
		{
			return default(bool);
		}

		public static bool TryReadXmlEndElement(XmlReader reader)
		{
			return default(bool);
		}

		public static string CleanInvalidXmlChars(string text)
		{
			return null;
		}
	}
}
