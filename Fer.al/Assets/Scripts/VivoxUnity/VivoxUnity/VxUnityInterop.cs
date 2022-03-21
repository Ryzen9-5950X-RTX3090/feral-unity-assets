using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VivoxUnity
{
	public class VxUnityInterop : MonoBehaviour
	{
		private static object m_Lock;

		private bool quitting;

		private static VxUnityInterop m_Instance;

		public static VxUnityInterop Instance
		{
			get
			{
				return null;
			}
		}

		private void OnApplicationQuit()
		{
		}

		public virtual void StartVivoxUnity()
		{
		}

		[IteratorStateMachine(typeof(<VivoxUnityRun>d__7))]
		private IEnumerator VivoxUnityRun()
		{
			return null;
		}

		private void OnDestroy()
		{
		}
	}
}
