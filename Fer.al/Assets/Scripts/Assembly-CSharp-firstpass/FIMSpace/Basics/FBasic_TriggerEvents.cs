using UnityEngine;
using UnityEngine.Events;

namespace FIMSpace.Basics
{
	public class FBasic_TriggerEvents : MonoBehaviour
	{
		public string EnteringTag;

		public UnityEvent OnAwakeEvent;

		public UnityEvent OnStartEvent;

		public UnityEvent OnTriggerEnterEvents;

		public UnityEvent OnTriggerExitEvents;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}
	}
}
