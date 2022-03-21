using System.Runtime.Serialization.Formatters.Binary;

namespace Crosstales.Common.Util
{
	public static class SerializeDeSerialize
	{
		private static BinaryFormatter binaryFormatter
		{
			get
			{
				return null;
			}
		}

		public static void SerializeToFile<T>(T obj, string filename)
		{
		}

		public static byte[] SerializeToByteArray<T>(T obj)
		{
			return null;
		}

		public static T DeserializeFromFile<T>(string filename)
		{
			return (T)null;
		}

		public static T DeserializeFromByteArray<T>(byte[] data)
		{
			return (T)null;
		}
	}
}
