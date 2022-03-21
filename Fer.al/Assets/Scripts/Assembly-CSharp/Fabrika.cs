using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Networking;

public class Fabrika
{
	private static bool isLoading;

	private static UnityWebRequest www;

	private static string _authToken;

	private static string _userId;

	private static string _userName;

	private static int it;

	private static delegateNetworkFabrikaSuccess _loginPromptCallback;

	private static string _toolId;

	public static string AuthToken
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string UserID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string UserName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private static void sendData(string email, string password, string toolId)
	{
	}

	[IteratorStateMachine(typeof(<OnGameUpdate>d__16))]
	private static IEnumerator OnGameUpdate()
	{
		return null;
	}

	public void OnDestroy()
	{
	}

	public static void LoadCompleted()
	{
	}

	public static void login(string email, string password)
	{
	}

	public static void clearCache()
	{
	}

	public static void promptUserforAccess(string toolId, [Optional] delegateNetworkFabrikaSuccess callBack, [Optional] delegateNetworkFabrikaFail failCallBack)
	{
	}
}
