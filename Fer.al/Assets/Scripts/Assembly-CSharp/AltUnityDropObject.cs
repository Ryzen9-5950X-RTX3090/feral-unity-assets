using Assets.AltUnityTester.AltUnityDriver.UnityStruct;

public class AltUnityDropObject : AltUnityCommandReturningAltElement
{
	private AltUnityVector2 position;

	private AltUnityObject altUnityObject;

	public AltUnityDropObject(SocketSettings socketSettings, AltUnityVector2 position, AltUnityObject altUnityObject)
	{
	}

	public AltUnityObject Execute()
	{
		return null;
	}
}
