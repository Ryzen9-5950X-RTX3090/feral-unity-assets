using System.Collections.Generic;

public class AltUnityFindObjectsWhichContain : AltUnityBaseFindObjects
{
	private By by;

	private string value;

	private By cameraBy;

	private string cameraPath;

	private bool enabled;

	public AltUnityFindObjectsWhichContain(SocketSettings socketSettings, By by, string value, By cameraBy, string cameraPath, bool enabled)
	{
	}

	public List<AltUnityObject> Execute()
	{
		return null;
	}
}
