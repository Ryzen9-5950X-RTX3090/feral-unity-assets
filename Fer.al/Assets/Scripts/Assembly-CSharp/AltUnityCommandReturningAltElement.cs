using System.Collections.Generic;

public class AltUnityCommandReturningAltElement : AltBaseCommand
{
	public AltUnityCommandReturningAltElement(SocketSettings socketSettings)
	{
	}

	protected AltUnityObject ReceiveAltUnityObject()
	{
		return null;
	}

	protected List<AltUnityObject> ReceiveListOfAltUnityObjects()
	{
		return null;
	}
}
