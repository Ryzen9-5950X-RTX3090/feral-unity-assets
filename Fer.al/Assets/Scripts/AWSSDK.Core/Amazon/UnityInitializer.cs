using System.Threading;
using UnityEngine;

namespace Amazon
{
	public class UnityInitializer : MonoBehaviour
	{
		private static UnityInitializer _instance;

		private static object _lock;

		private static Thread _mainThread;

		public static UnityInitializer Instance
		{
			get
			{
				return null;
			}
		}

		private UnityInitializer()
		{
		}

		public static void AttachToGameObject(GameObject gameObject)
		{
		}

		public void Awake()
		{
		}

		public static bool IsMainThread()
		{
			return default(bool);
		}
	}
}
