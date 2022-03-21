using System.Collections.Generic;

public class AltUnityFindElementsByComponent : AltUnityCommandReturningAltElement
{
	private string componentName;

	private string assemblyName;

	private string cameraName;

	private bool enabled;

	public AltUnityFindElementsByComponent(SocketSettings socketSettings, string componentName, string assemblyName, string cameraName, bool enabled)
	{
	}

	public List<AltUnityObject> Execute()
	{
		return null;
	}
}
