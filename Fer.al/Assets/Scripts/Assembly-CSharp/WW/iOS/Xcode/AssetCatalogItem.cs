using System.Collections.Generic;

namespace WW.iOS.Xcode
{
	internal abstract class AssetCatalogItem
	{
		public readonly string name;

		public readonly string authorId;

		protected Dictionary<string, string> m_Properties;

		protected string m_Path;

		public string path
		{
			get
			{
				return null;
			}
		}

		public AssetCatalogItem(string name, string authorId)
		{
		}

		protected JsonElementDict WriteInfoToJson(JsonDocument doc)
		{
			return null;
		}

		public abstract void Write(List<string> warnings);
	}
}
