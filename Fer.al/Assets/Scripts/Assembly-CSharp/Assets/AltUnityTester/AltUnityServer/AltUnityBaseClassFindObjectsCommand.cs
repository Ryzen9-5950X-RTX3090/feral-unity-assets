using System.Collections.Generic;
using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer
{
	internal class AltUnityBaseClassFindObjectsCommand : AltUnityCommand
	{
		protected List<List<string>> ProcessPath(string path)
		{
			return null;
		}

		private List<List<string>> AddEscapedCharactersBack(List<List<string>> pathSetCorrectly, List<char> escapeCharacters)
		{
			return null;
		}

		private List<List<string>> SetCondition(List<string> list)
		{
			return null;
		}

		private List<string> ParseSelector(string selector)
		{
			return null;
		}

		private string EliminateEscapedCharacters(string text, out List<char> escapedCharacters)
		{
			return null;
		}

		private List<string> SeparateAxesAndSelectors(string path)
		{
			return null;
		}

		public List<GameObject> FindObjects(GameObject gameObject, List<List<string>> conditions, int step, bool singleObject, bool directChildren, bool enabled)
		{
			return null;
		}

		private bool CheckCondition(GameObject objectToCheck, List<string> listOfConditions)
		{
			return default(bool);
		}

		private static int CheckOption(string condition)
		{
			return default(int);
		}

		private bool CheckConditionIfParent(List<string> list)
		{
			return default(bool);
		}

		protected bool IsNextElementDirectChild(List<string> list)
		{
			return default(bool);
		}

		private List<GameObject> GetGameObjectsToCheck(GameObject gameObject)
		{
			return null;
		}

		private List<GameObject> GetAllChildren(GameObject gameObject)
		{
			return null;
		}

		private List<GameObject> GetAllRootObjects()
		{
			return null;
		}

		public override string Execute()
		{
			return null;
		}

		protected Camera GetCamera(By cameraBy, string cameraPath)
		{
			return null;
		}
	}
}
