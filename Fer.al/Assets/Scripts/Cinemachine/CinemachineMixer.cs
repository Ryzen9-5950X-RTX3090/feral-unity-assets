using Cinemachine;
using UnityEngine.Playables;

internal sealed class CinemachineMixer : PlayableBehaviour
{
	private CinemachineBrain mBrain;

	private int mBrainOverrideId;

	private bool mPreviewPlay;

	public override void OnPlayableDestroy(Playable playable)
	{
	}

	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	private float GetDeltaTime(float deltaTime)
	{
		return default(float);
	}
}
