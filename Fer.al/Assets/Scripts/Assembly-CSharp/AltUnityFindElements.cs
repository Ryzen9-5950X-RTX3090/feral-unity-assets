using System.Collections.Generic;

public class AltUnityFindElements : AltUnityCommandReturningAltElement
{
	private string name;

	private string cameraName;

	private bool enabled;

	public AltUnityFindElements(SocketSettings socketSettings, string name, string cameraName, bool enabled)
	{
	}

	public List<AltUnityObject> Execute()
	{
		return null;
	}
}
