using System.Runtime.CompilerServices;

[ManagedBehaviourManager("NetworkManager")]
public class KeepAlive : ManagedBehaviour
{
	private int KICK_INTERVAL_SEC;

	private int WARNING_INTERVAL_SEC;

	private int SEND_INTERVAL_SEC;

	private int SEND_INTERVAL_SEC_MINIGAME;

	private float _elapsedTime;

	private bool _warningSent;

	private bool _sendKeepAliveMessageNextSendInterval;

	public bool IsUserIdleForLongTime
	{
		get
		{
			return default(bool);
		}
	}

	public static KeepAlive instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	public override void MUpdate()
	{
	}

	private void RestartKeepAlive()
	{
	}

	private void SendKeepAlive()
	{
	}

	private void OnTouchReceived()
	{
	}

	public void RequestKeepAlive()
	{
	}

	private void WarnUserAboutLoomingKickage()
	{
	}
}
