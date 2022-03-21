using Rewired;

[ManagedBehaviourManager("MessageManager")]
public class RewiredMessageRouter : ManagedBehaviour
{
	public override void MAwake()
	{
	}

	public override void OnDestroy()
	{
	}

	private void OnControllerConnected(ControllerStatusChangedEventArgs inArgs)
	{
	}

	private void OnControllerDisconnected(ControllerStatusChangedEventArgs inArgs)
	{
	}

	private void OnControllerPreDisconnected(ControllerStatusChangedEventArgs inArgs)
	{
	}
}
