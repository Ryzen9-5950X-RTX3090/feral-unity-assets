using UnityEngine;
using UnityEngine.Events;

namespace FIMSpace.Basics
{
	public class FBasic_TimedExecutor : MonoBehaviour
	{
		[Header("How much seconds should take space between executions")]
		public Vector2 RandomTimerRange;

		public UnityEvent ToExecute;

		private float timer;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void ResetTimer()
		{
		}
	}
}
