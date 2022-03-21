using UnityEngine;

namespace Lean.Pool.Extras
{
	[RequireComponent(typeof(Rigidbody))]
	[HelpURL("https://carloswilkes.github.io/Documentation/LeanPool#LeanPooledRigidbody")]
	[AddComponentMenu("Lean/Pool/Lean Pooled Rigidbody")]
	public class LeanPooledRigidbody : MonoBehaviour, IPoolable
	{
		public void OnSpawn()
		{
		}

		public void OnDespawn()
		{
		}
	}
}
