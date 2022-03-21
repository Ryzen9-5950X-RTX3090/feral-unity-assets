using System.Collections.Generic;
using UnityEngine;

namespace Gaia
{
	public class TreeManager
	{
		private List<TreePrototype> m_terrainTrees;

		private Quadtree<int> m_terrainTreeLocations;

		public void LoadTreesFromTerrain()
		{
		}

		public void AddTree(Vector3 position, int prototypeIdx)
		{
		}

		public int Count(Vector3 position, float range)
		{
			return default(int);
		}

		public int Count()
		{
			return default(int);
		}
	}
}
