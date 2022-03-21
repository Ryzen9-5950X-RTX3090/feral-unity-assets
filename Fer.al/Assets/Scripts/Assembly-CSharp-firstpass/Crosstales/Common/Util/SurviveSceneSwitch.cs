using UnityEngine;

namespace Crosstales.Common.Util
{
	[DisallowMultipleComponent]
	public class SurviveSceneSwitch : MonoBehaviour
	{
		[Tooltip("Objects which have to survive a scene switch.")]
		public GameObject[] Survivors;

		[Tooltip("Don't destroy gameobject during scene switches (default: true).")]
		public bool DontDestroy;

		private const float ensureParentTime = 1.5f;

		private float ensureParentTimer;

		private static SurviveSceneSwitch instance;

		private static Transform tf;

		private static bool loggedOnlyOneInstance;

		public void OnEnable()
		{
		}

		public void Start()
		{
		}

		public void Update()
		{
		}
	}
}
