using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Assets.AltUnityTester.AltUnityDriver.UnityStruct;
using Newtonsoft.Json;

public class AltUnityObject
{
	public string name;

	public int id;

	public int x;

	public int y;

	public int z;

	public int mobileY;

	public string type;

	public bool enabled;

	public float worldX;

	public float worldY;

	public float worldZ;

	public int idCamera;

	public int parentId;

	public int transformId;

	[JsonIgnore]
	public SocketSettings socketSettings;

	public AltUnityObject(string name, int id = 0, int x = 0, int y = 0, int z = 0, int mobileY = 0, string type = "", bool enabled = true, float worldX = 0f, float worldY = 0f, float worldZ = 0f, int idCamera = 0, int parentId = 0, int transformId = 0)
	{
	}

	public AltUnityVector2 getScreenPosition()
	{
		return default(AltUnityVector2);
	}

	public AltUnityVector3 getWorldPosition()
	{
		return default(AltUnityVector3);
	}

	public string GetComponentProperty(string componentName, string propertyName, [Optional] string assemblyName)
	{
		return null;
	}

	public string SetComponentProperty(string componentName, string propertyName, string value, [Optional] string assemblyName)
	{
		return null;
	}

	public string CallComponentMethod(string componentName, string methodName, string parameters, string typeOfParameters = "", [Optional] string assemblyName)
	{
		return null;
	}

	public string GetText()
	{
		return null;
	}

	public AltUnityObject SetText(string text)
	{
		return null;
	}

	public AltUnityObject ClickEvent()
	{
		return null;
	}

	[Obsolete]
	public AltUnityObject DragObject(AltUnityVector2 position)
	{
		return null;
	}

	[Obsolete]
	public AltUnityObject DropObject(AltUnityVector2 position)
	{
		return null;
	}

	public AltUnityObject PointerUpFromObject()
	{
		return null;
	}

	public AltUnityObject PointerDownFromObject()
	{
		return null;
	}

	public AltUnityObject PointerEnterObject()
	{
		return null;
	}

	public AltUnityObject PointerExitObject()
	{
		return null;
	}

	public AltUnityObject Tap()
	{
		return null;
	}

	public AltUnityObject DoubleTap()
	{
		return null;
	}

	public List<AltUnityComponent> GetAllComponents()
	{
		return null;
	}

	public List<AltUnityProperty> GetAllProperties(AltUnityComponent altUnityComponent)
	{
		return null;
	}

	public List<string> GetAllMethods(AltUnityComponent altUnityComponent, AltUnityMethodSelection methodSelection = AltUnityMethodSelection.ALLMETHODS)
	{
		return null;
	}
}
