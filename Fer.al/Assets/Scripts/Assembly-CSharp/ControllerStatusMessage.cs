using Rewired;

public abstract class ControllerStatusMessage : Message
{
	public readonly string name;

	public readonly int controllerId;

	public readonly ControllerType controllerType;

	public ControllerStatusMessage(ControllerStatusChangedEventArgs inArgs)
	{
	}
}
