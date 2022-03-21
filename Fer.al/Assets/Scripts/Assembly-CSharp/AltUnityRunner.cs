using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.UI;

public class AltUnityRunner : UnityEngine.MonoBehaviour, AltIClientSocketHandlerDelegate
{
	private enum FindOption
	{
		Name,
		ContainName,
		Component
	}

	public static AltUnityRunner _altUnityRunner;

	public GameObject AltUnityPopUp;

	public Image AltUnityIcon;

	public Text AltUnityPopUpText;

	public bool AltUnityIconPressed;

	private Vector3 _position;

	private AltSocketServer _socketServer;

	public static StringBuilder logMessage;

	public bool logEnabled;

	private string myPathFile;

	public static StreamWriter FileWriter;

	public static readonly string VERSION;

	public readonly string errorNotFoundMessage;

	public readonly string errorPropertyNotFoundMessage;

	public readonly string errorMethodNotFoundMessage;

	public readonly string errorComponentNotFoundMessage;

	public readonly string errorCouldNotPerformOperationMessage;

	public readonly string errorCouldNotParseJsonString;

	public readonly string errorIncorrectNumberOfParameters;

	public readonly string errorFailedToParseArguments;

	public readonly string errorObjectWasNotFound;

	public readonly string errorPropertyNotSet;

	public readonly string errorNullRefferenceMessage;

	public readonly string errorUnknownError;

	public readonly string errorFormatException;

	public readonly string errorCameraNotFound;

	public JsonSerializerSettings _jsonSettings;

	[Space]
	[SerializeField]
	private bool _showInputs;

	[SerializeField]
	private AltUnityInputsVisualiser _inputsVisualiser;

	[Space]
	public bool showPopUp;

	[SerializeField]
	private GameObject AltUnityPopUpCanvas;

	public bool destroyHightlight;

	public int SocketPortNumber;

	public bool DebugBuildNeeded;

	public Shader outlineShader;

	public GameObject panelHightlightPrefab;

	public string requestSeparatorString;

	public string requestEndingString;

	public static AltResponseQueue _responseQueue;

	public bool ShowInputs
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnApplicationQuit()
	{
	}

	public void CleanUp()
	{
	}

	public void StartSocketServer()
	{
	}

	private Vector3 getObjectScreePosition(GameObject gameObject, Camera camera)
	{
		return default(Vector3);
	}

	public AltUnityObject GameObjectToAltUnityObject(GameObject altGameObject, [Optional] Camera camera)
	{
		return null;
	}

	public void ClientSocketHandlerDidReadMessage(AltClientSocketHandler handler, string message)
	{
	}

	public void LogMessage(string logMessage)
	{
	}

	public static GameObject[] GetDontDestroyOnLoadObjects()
	{
		return null;
	}

	public void ServerRestartPressed()
	{
	}

	public void IconPressed()
	{
	}

	public static GameObject GetGameObject(AltUnityObject altUnityObject)
	{
		return null;
	}

	public static GameObject GetGameObject(int objectId)
	{
		return null;
	}

	public Camera FoundCameraById(int id)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<HighLightSelectedObjectCorutine>d__59))]
	public IEnumerator HighLightSelectedObjectCorutine(GameObject gameObject, Color color, float width, Vector2 size, AltClientSocketHandler handler)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<TakeTexturedScreenshot>d__60))]
	public IEnumerator TakeTexturedScreenshot(Vector2 size, AltClientSocketHandler handler)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<TakeScreenshot>d__61))]
	public IEnumerator TakeScreenshot(AltClientSocketHandler handler)
	{
		return null;
	}

	public void ShowClick(Vector2 position)
	{
	}

	public int ShowInput(Vector2 position, int markId = -1)
	{
		return default(int);
	}

	public static void CopyTo(Stream src, Stream dest)
	{
	}

	public static byte[] CompressScreenshot(byte[] screenshotSerialized)
	{
		return null;
	}

	private static bool ByteArrayCompare(byte[] a1, byte[] a2)
	{
		return default(bool);
	}
}
