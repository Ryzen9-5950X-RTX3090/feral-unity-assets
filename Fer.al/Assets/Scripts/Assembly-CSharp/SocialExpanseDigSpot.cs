using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SocialExpanseDigSpot : MonoBehaviour
{
	[RootSelector("DigFX Bundle ID", "BundleIDChartData", false, false)]
	public string digBundleID;

	[RootSelector("SmokePuff Bundle ID", "BundleIDChartData", false, false)]
	public string smokePuffBundleID;

	public SocialExpanseDigSpotSettings socialExpanseDigSpotSetting;

	private ParticleSystem[] _digFX;

	private ParticleSystem[] _smokePuffFX;

	private Interactable _interactable;

	private Coroutine _alignCoroutine;

	private Coroutine _moveCameraCoroutine;

	private Coroutine _waitForJumpLandCoroutine;

	private Transform _playerCameraTransform;

	private Transform _playerTransform;

	private GameObject _digCameraStartPosition;

	private Vector3 _digCamStartPosition;

	private Vector3 _digCamEndPosition;

	private bool _finished;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void OnDisable()
	{
	}

	private void OnInteractableInteracted(InteractableInteractedMessage inMessage)
	{
	}

	[IteratorStateMachine(typeof(<WaitForJumpLandCoroutine>d__19))]
	private IEnumerator WaitForJumpLandCoroutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<AlignToDigSpot>d__20))]
	private IEnumerator AlignToDigSpot()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<MoveCamera>d__21))]
	private IEnumerator MoveCamera(bool inActivate)
	{
		return null;
	}

	private void CleanupCoroutines()
	{
	}

	private void StartDig()
	{
	}

	private void Interrupted()
	{
	}

	private void PlaySmokePuff()
	{
	}

	private void PlayDigFX(bool inPlay)
	{
	}

	private void PlayFx(ParticleSystem[] inParticleSystem, bool inPlay)
	{
	}
}
