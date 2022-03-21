using System.Collections.Generic;

namespace Gaia
{
	public class GaiaCompatiblePublisher
	{
		public string m_publisherName;

		public bool m_installedFoldedOut;

		public bool m_compatibleFoldedOut;

		private Dictionary<string, GaiaCompatiblePackage> m_packages;

		public GaiaCompatiblePackage GetPackage(string packageName)
		{
			return null;
		}

		public List<GaiaCompatiblePackage> GetPackages()
		{
			return null;
		}

		public int InstalledPackages()
		{
			return default(int);
		}

		public int CompatiblePackages()
		{
			return default(int);
		}

		public void AddPackage(GaiaCompatiblePackage package)
		{
		}
	}
}
