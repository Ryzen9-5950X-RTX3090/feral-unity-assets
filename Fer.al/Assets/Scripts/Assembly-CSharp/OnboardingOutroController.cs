using System.Runtime.CompilerServices;
using NodeCanvas.BehaviourTrees;
using UnityEngine;

public class OnboardingOutroController : MonoBehaviour
{
	[SerializeField]
	private BehaviourTreeOwner _onboardingTree;

	public static bool OnboardingOutroInProgress
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnOutroCompleted(OnboardingOutroCompleteMessage inMessage)
	{
	}
}
