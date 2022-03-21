using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using Assets.AltUnityTester.AltUnityDriver.UnityStruct;

public class AltUnityDriver
{
	public TcpClient Socket;

	public SocketSettings socketSettings;

	public static readonly string VERSION;

	public static string requestSeparatorString;

	public static string requestEndingString;

	public AltUnityDriver(string tcp_ip = "127.0.0.1", int tcp_port = 13000, string requestSeparator = ";", string requestEnding = "&", bool logFlag = false)
	{
	}

	public string CheckServerVersion()
	{
		return null;
	}

	private void EnableLogging()
	{
	}

	public void Stop()
	{
	}

	public void LoadScene(string scene, bool loadSingle = true)
	{
	}

	public List<string> GetAllLoadedScenes()
	{
		return null;
	}

	[Obsolete]
	public List<AltUnityObject> FindObjects(By by, string value, string cameraName, bool enabled = true)
	{
		return null;
	}

	public List<AltUnityObject> FindObjects(By by, string value, By cameraBy = By.NAME, string cameraPath = "", bool enabled = true)
	{
		return null;
	}

	[Obsolete]
	public List<AltUnityObject> FindObjectsWhichContain(By by, string value, string cameraName, bool enabled = true)
	{
		return null;
	}

	public List<AltUnityObject> FindObjectsWhichContain(By by, string value, By cameraBy = By.NAME, string cameraPath = "", bool enabled = true)
	{
		return null;
	}

	[Obsolete]
	public AltUnityObject FindObject(By by, string value, string cameraName, bool enabled = true)
	{
		return null;
	}

	public AltUnityObject FindObject(By by, string value, By cameraBy = By.NAME, string cameraValue = "", bool enabled = true)
	{
		return null;
	}

	[Obsolete]
	public AltUnityObject FindObjectWhichContains(By by, string value, string cameraName, bool enabled = true)
	{
		return null;
	}

	public AltUnityObject FindObjectWhichContains(By by, string value, By cameraBy = By.NAME, string cameraValue = "", bool enabled = true)
	{
		return null;
	}

	public void SetTimeScale(float timeScale)
	{
	}

	public float GetTimeScale()
	{
		return default(float);
	}

	public string CallStaticMethods(string typeName, string methodName, string parameters, string typeOfParameters = "", string assemblyName = "")
	{
		return null;
	}

	public void DeletePlayerPref()
	{
	}

	public void DeleteKeyPlayerPref(string keyName)
	{
	}

	public void SetKeyPlayerPref(string keyName, int valueName)
	{
	}

	public void SetKeyPlayerPref(string keyName, float valueName)
	{
	}

	public void SetKeyPlayerPref(string keyName, string valueName)
	{
	}

	public int GetIntKeyPlayerPref(string keyName)
	{
		return default(int);
	}

	public float GetFloatKeyPlayerPref(string keyName)
	{
		return default(float);
	}

	public string GetStringKeyPlayerPref(string keyName)
	{
		return null;
	}

	public string GetCurrentScene()
	{
		return null;
	}

	public void Swipe(AltUnityVector2 start, AltUnityVector2 end, float duration)
	{
	}

	public void SwipeAndWait(AltUnityVector2 start, AltUnityVector2 end, float duration)
	{
	}

	public void MultipointSwipe(AltUnityVector2[] positions, float duration)
	{
	}

	public void MultipointSwipeAndWait(AltUnityVector2[] positions, float duration)
	{
	}

	public void HoldButton(AltUnityVector2 position, float duration)
	{
	}

	public void HoldButtonAndWait(AltUnityVector2 position, float duration)
	{
	}

	public void PressKey(AltUnityKeyCode keyCode, float power = 1f, float duration = 1f)
	{
	}

	public void PressKeyAndWait(AltUnityKeyCode keyCode, float power = 1f, float duration = 1f)
	{
	}

	public void MoveMouse(AltUnityVector2 location, float duration = 0f)
	{
	}

	public void MoveMouseAndWait(AltUnityVector2 location, float duration = 0f)
	{
	}

	public void ScrollMouse(float speed, float duration = 0f)
	{
	}

	public void ScrollMouseAndWait(float speed, float duration = 0f)
	{
	}

	public AltUnityObject TapScreen(float x, float y)
	{
		return null;
	}

	public void TapCustom(float x, float y, int count, float interval = 0.1f)
	{
	}

	public void Tilt(AltUnityVector3 acceleration, float duration = 0f)
	{
	}

	public void TiltAndWait(AltUnityVector3 acceleration, float duration = 0f)
	{
	}

	[Obsolete]
	public AltUnityObject FindElementWhereNameContains(string name, string cameraName = "", bool enabled = true)
	{
		return null;
	}

	[Obsolete]
	public List<AltUnityObject> GetAllElements(string cameraName, bool enabled = true)
	{
		return null;
	}

	public List<AltUnityObject> GetAllElements(By cameraBy = By.NAME, string cameraPath = "", bool enabled = true)
	{
		return null;
	}

	[Obsolete]
	public AltUnityObject FindElement(string name, string cameraName = "", bool enabled = true)
	{
		return null;
	}

	[Obsolete]
	public List<AltUnityObject> FindElements(string name, string cameraName = "", bool enabled = true)
	{
		return null;
	}

	[Obsolete]
	public List<AltUnityObject> FindElementsWhereNameContains(string name, string cameraName = "", bool enabled = true)
	{
		return null;
	}

	public string WaitForCurrentSceneToBe(string sceneName, double timeout = 10.0, double interval = 1.0)
	{
		return null;
	}

	[Obsolete]
	public AltUnityObject WaitForElementWhereNameContains(string name, string cameraName = "", bool enabled = true, double timeout = 20.0, double interval = 0.5)
	{
		return null;
	}

	[Obsolete]
	public AltUnityObject WaitForObject(By by, string value, string cameraName, bool enabled = true, double timeout = 20.0, double interval = 0.5)
	{
		return null;
	}

	public AltUnityObject WaitForObject(By by, string value, By cameraBy = By.NAME, string cameraPath = "", bool enabled = true, double timeout = 20.0, double interval = 0.5)
	{
		return null;
	}

	[Obsolete]
	public void WaitForObjectNotBePresent(By by, string value, string cameraName, bool enabled = true, double timeout = 20.0, double interval = 0.5)
	{
	}

	public void WaitForObjectNotBePresent(By by, string value, By cameraBy = By.NAME, string cameraPath = "", bool enabled = true, double timeout = 20.0, double interval = 0.5)
	{
	}

	[Obsolete]
	public AltUnityObject WaitForObjectWhichContains(By by, string value, string cameraName, bool enabled = true, double timeout = 20.0, double interval = 0.5)
	{
		return null;
	}

	public AltUnityObject WaitForObjectWhichContains(By by, string value, By cameraBy = By.NAME, string cameraPath = "", bool enabled = true, double timeout = 20.0, double interval = 0.5)
	{
		return null;
	}

	[Obsolete]
	public void WaitForElementToNotBePresent(string name, string cameraName = "", bool enabled = true, double timeout = 20.0, double interval = 0.5)
	{
	}

	[Obsolete]
	public AltUnityObject WaitForElement(string name, string cameraName = "", bool enabled = true, double timeout = 20.0, double interval = 0.5)
	{
		return null;
	}

	[Obsolete]
	public AltUnityObject WaitForElementWithText(string name, string text, string cameraName = "", bool enabled = true, double timeout = 20.0, double interval = 0.5)
	{
		return null;
	}

	[Obsolete]
	public AltUnityObject WaitForObjectWithText(By by, string value, string text, string cameraName, bool enabled = true, double timeout = 20.0, double interval = 0.5)
	{
		return null;
	}

	public AltUnityObject WaitForObjectWithText(By by, string value, string text, By cameraBy = By.NAME, string cameraPath = "", bool enabled = true, double timeout = 20.0, double interval = 0.5)
	{
		return null;
	}

	[Obsolete]
	public AltUnityObject FindElementByComponent(string componentName, string assemblyName = "", string cameraName = "", bool enabled = true)
	{
		return null;
	}

	[Obsolete]
	public List<AltUnityObject> FindElementsByComponent(string componentName, string assemblyName = "", string cameraName = "", bool enabled = true)
	{
		return null;
	}

	public List<string> GetAllScenes()
	{
		return null;
	}

	public List<AltUnityObject> GetAllCameras()
	{
		return null;
	}

	public AltUnityTextureInformation GetScreenshot([Optional] AltUnityVector2 size)
	{
		return default(AltUnityTextureInformation);
	}

	public AltUnityTextureInformation GetScreenshot(int id, AltUnityColor color, float width, [Optional] AltUnityVector2 size)
	{
		return default(AltUnityTextureInformation);
	}

	public AltUnityTextureInformation GetScreenshot(AltUnityVector2 coordinates, AltUnityColor color, float width, out AltUnityObject selectedObject, [Optional] AltUnityVector2 size)
	{
		return default(AltUnityTextureInformation);
	}

	public void GetPNGScreenshot(string path)
	{
	}
}
