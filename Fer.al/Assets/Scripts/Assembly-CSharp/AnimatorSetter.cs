using System.Collections;
using System.Runtime.CompilerServices;

public class AnimatorSetter : ManagedBehaviour
{
	public enum EActions
	{
		None = 0,
		IdleBreak02 = 2,
		IdleBreak03 = 3,
		Jump = 10,
		Falling = 11,
		Dig = 20,
		Dive = 30,
		Sleep = 40,
		Tired = 41,
		Dizzy = 50,
		Sit = 60,
		Sit02 = 61,
		Sit03 = 62,
		Angry = 70,
		Excited = 80,
		Surprised = 90,
		Talk = 100,
		Agree = 110,
		Disagree = 120,
		GetAttention = 130,
		SendAway = 140,
		Laugh = 150,
		Dance = 160,
		Eat = 170,
		Sad = 180,
		Scared = 190,
		Strut = 200,
		Play = 210
	}

	public enum ERotationOverrides
	{
		None,
		Disable,
		HeadOnly
	}

	public EActions actionId;

	public ERotationOverrides rotationOverride;

	public bool disableStickToGround;

	private readonly float timeout;

	[IteratorStateMachine(typeof(<SetAnimator>d__6))]
	private IEnumerator SetAnimator()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<SetFaceLocalPlayer>d__7))]
	private IEnumerator SetFaceLocalPlayer()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<SetStickToGroun>d__8))]
	private IEnumerator SetStickToGroun()
	{
		return null;
	}

	public void Init()
	{
	}
}
