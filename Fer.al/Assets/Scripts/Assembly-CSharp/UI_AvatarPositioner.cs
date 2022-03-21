using System.Collections.Generic;
using RootMotion.FinalIK;
using UnityEngine;

public class UI_AvatarPositioner : UI_StageSubjectPositioner
{
	private readonly List<DynamicBone> _previouslyActiveDynamicBones;

	private readonly List<LegIK> _previouslyActiveLegIKs;

	private UI_Stage_Avatar _avatarStage;

	public UI_Stage_Avatar AvatarStage
	{
		get
		{
			return null;
		}
	}

	public void Setup(Camera inUICamera, UI_Stage_Avatar inStage)
	{
	}

	public void ViewHead()
	{
	}

	public void ViewTail()
	{
	}

	public void ViewGeneral()
	{
	}

	public void ViewDetached()
	{
	}

	public void ViewBodyPart(ActorInfoBodyPart inBodyPart)
	{
	}

	public void FreezeAvatar(bool inFreeze)
	{
	}

	private void UpdateVirtualCamera()
	{
	}

	private void ProcessDynamicBones(bool inFreeze)
	{
	}

	private void ProcessLegIKs(bool inFreeze)
	{
	}
}
