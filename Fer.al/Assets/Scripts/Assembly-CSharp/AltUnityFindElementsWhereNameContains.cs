using System.Collections.Generic;

public class AltUnityFindElementsWhereNameContains : AltUnityCommandReturningAltElement
{
	private string name;

	private string cameraName;

	private bool enabled;

	public AltUnityFindElementsWhereNameContains(SocketSettings socketSettings, string name, string cameraName, bool enabled)
	{
	}

	public List<AltUnityObject> Execute()
	{
		return null;
	}
}
