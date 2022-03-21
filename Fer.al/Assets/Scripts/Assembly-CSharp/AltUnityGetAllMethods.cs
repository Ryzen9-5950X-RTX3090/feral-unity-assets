using System.Collections.Generic;

public class AltUnityGetAllMethods : AltBaseCommand
{
	private AltUnityComponent altUnityComponent;

	private AltUnityObject altUnityObject;

	private AltUnityMethodSelection methodSelection;

	public AltUnityGetAllMethods(SocketSettings socketSettings, AltUnityComponent altUnityComponent, AltUnityObject altUnityObject, AltUnityMethodSelection methodSelection = AltUnityMethodSelection.ALLMETHODS)
	{
	}

	public List<string> Execute()
	{
		return null;
	}
}
