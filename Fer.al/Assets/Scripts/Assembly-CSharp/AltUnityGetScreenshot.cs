using Assets.AltUnityTester.AltUnityDriver.UnityStruct;

public class AltUnityGetScreenshot : AltUnityCommandReturningAltElement
{
	private int id;

	private AltUnityColor color;

	private float width;

	private AltUnityVector2 size;

	private AltUnityVector2 coordinates;

	private int option;

	public AltUnityGetScreenshot(SocketSettings socketSettings, AltUnityVector2 size)
	{
	}

	public AltUnityGetScreenshot(SocketSettings socketSettings, int id, AltUnityColor color, float width, AltUnityVector2 size)
	{
	}

	public AltUnityGetScreenshot(SocketSettings socketSettings, AltUnityVector2 coordinates, AltUnityColor color, float width, AltUnityVector2 size)
	{
	}

	public AltUnityTextureInformation Execute(out AltUnityObject selectedObject)
	{
		return default(AltUnityTextureInformation);
	}

	public AltUnityTextureInformation Execute()
	{
		return default(AltUnityTextureInformation);
	}

	private AltUnityTextureInformation GetSimpleScreenshot()
	{
		return default(AltUnityTextureInformation);
	}

	private AltUnityTextureInformation GetHighlightObjectScreenshot()
	{
		return default(AltUnityTextureInformation);
	}

	private AltUnityTextureInformation GetHighlightObjectFromCoordinatesScreenshot(out AltUnityObject selectedObject)
	{
		return default(AltUnityTextureInformation);
	}
}
