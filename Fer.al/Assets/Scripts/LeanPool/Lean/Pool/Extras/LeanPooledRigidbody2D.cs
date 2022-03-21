using UnityEngine;

namespace Lean.Pool.Extras
{
	[RequireComponent(typeof(Rigidbody2D))]
	[HelpURL("https://carloswilkes.github.io/Documentation/LeanPool#LeanPooledRigidbody2D")]
	[AddComponentMenu("Lean/Pool/Lean Pooled Rigidbody2D")]
	public class LeanPooledRigidbody2D : MonoBehaviour, IPoolable
	{
		public void OnSpawn()
		{
		}

		public void OnDespawn()
		{
		}
	}
}
