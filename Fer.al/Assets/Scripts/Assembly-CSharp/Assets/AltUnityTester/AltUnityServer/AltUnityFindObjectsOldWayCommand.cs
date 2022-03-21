using System.Collections.Generic;
using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer
{
	internal class AltUnityFindObjectsOldWayCommand : AltUnityCommand
	{
		protected GameObject FindObjectInScene(string objectName, bool enabled)
		{
			return null;
		}

		private GameObject CheckChildren(GameObject obj, string[] pathList, bool enabled)
		{
			return null;
		}

		private GameObject CheckPath(GameObject obj, string[] pathList, int pathListStep, bool enabled)
		{
			return null;
		}

		private GameObject CheckNextElementInPath(GameObject obj, string[] pathList, int pathListStep, bool enabled)
		{
			return null;
		}

		protected List<GameObject> FindObjectsInScene(string objectName, bool enabled)
		{
			return null;
		}

		private List<GameObject> CheckChildrenForMultipleElements(GameObject obj, string[] pathList, bool enabled)
		{
			return null;
		}

		private List<GameObject> CheckPathForMultipleElements(GameObject obj, string[] pathList, int pathListStep, bool enabled)
		{
			return null;
		}

		private static int CheckOption(string[] pathList, int pathListStep)
		{
			return default(int);
		}

		private List<GameObject> CheckNextElementInPathForMultipleElements(GameObject obj, string[] pathList, int pathListStep, bool enabled)
		{
			return null;
		}

		public override string Execute()
		{
			return null;
		}
	}
}
