using System;
using UnityEngine;

namespace Lean.Pool.Examples
{
	[RequireComponent(typeof(Rigidbody))]
	[HelpURL("https://carloswilkes.github.io/Documentation/LeanPool#LeanPoolDebugger")]
	[AddComponentMenu("Lean/Pool/Lean Pool Debugger")]
	public class LeanPoolDebugger : MonoBehaviour
	{
		[SerializeField]
		[HideInInspector]
		private LeanGameObjectPool cachedPool;

		[NonSerialized]
		private bool skip;

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void OnApplicationQuit()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		private bool Exists()
		{
			return default(bool);
		}
	}
}
