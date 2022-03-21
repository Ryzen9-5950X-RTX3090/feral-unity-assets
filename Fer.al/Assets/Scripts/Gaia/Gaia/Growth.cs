using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gaia
{
	public class Growth : MonoBehaviour
	{
		[Tooltip("The start size in the game.")]
		public float m_startScale;

		[Tooltip("The end size in the game.")]
		public float m_endScale;

		[Tooltip("Scale variance. Final scale is equal to end scale plus a a random value between 0 and this.")]
		public float m_scaleVariance;

		[Range(0.5f, 60f)]
		[Tooltip("The time it takes to grow in seconds.")]
		public float m_growthTime;

		private float m_actualEndScale;

		private void Start()
		{
		}

		public virtual void Initialise()
		{
		}

		[IteratorStateMachine(typeof(<Grow>d__7))]
		private IEnumerator Grow()
		{
			return null;
		}

		public virtual void Die()
		{
		}
	}
}
