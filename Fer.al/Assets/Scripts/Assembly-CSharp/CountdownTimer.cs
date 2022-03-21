using System.Collections;
using System.Runtime.CompilerServices;

public class CountdownTimer : MonoBehaviour
{
	public delegate void CountdownEvent();

	public float CountdownDuration;

	public float CountdownTickInterval;

	private float _countdownTimeRemaining;

	private bool _wasCancelled;

	public bool IsRunning
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

	public event CountdownEvent OnCountdownTicked
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event CountdownEvent OnCountdownCompleted
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void StartCountdown(bool inRestartIfRunning = false, bool inTickOnStart = false)
	{
	}

	public void CancelCountdown()
	{
	}

	private float GetNextTickInterval()
	{
		return default(float);
	}

	private void TickCountdown()
	{
	}

	[IteratorStateMachine(typeof(<RunCountdown>d__19))]
	private IEnumerator RunCountdown()
	{
		return null;
	}

	private void CountdownCompleted()
	{
	}
}
