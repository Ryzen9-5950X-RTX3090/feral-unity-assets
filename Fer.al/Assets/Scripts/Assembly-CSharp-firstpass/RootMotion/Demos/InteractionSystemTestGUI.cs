using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[RequireComponent(typeof(InteractionSystem))]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("The object to interact to")]
		private InteractionObject interactionObject;

		[SerializeField]
		[Tooltip("The effectors to interact with")]
		private FullBodyBipedEffector[] effectors;

		private InteractionSystem interactionSystem;

		private void Awake()
		{
		}

		private void OnGUI()
		{
		}
	}
}
