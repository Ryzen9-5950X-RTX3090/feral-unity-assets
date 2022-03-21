using System;
using System.Collections.Generic;

namespace Gaia
{
	public class GaiaExtensionManager
	{
		private Dictionary<string, GaiaCompatiblePublisher> m_extensions;

		public void ScanForExtensions()
		{
		}

		public int GetInstalledExtensionCount()
		{
			return default(int);
		}

		public List<GaiaCompatiblePublisher> GetPublishers()
		{
			return null;
		}

		public List<Type> GetTypesInNamespace(string nameSpace)
		{
			return null;
		}
	}
}
