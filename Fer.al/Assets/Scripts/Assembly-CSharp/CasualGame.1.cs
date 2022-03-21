using System.Collections.Generic;
using System.Reflection;

public class CasualGame<T> : MonoBehaviour where T : CasualGame<T>
{
	protected static T _instance;

	private int _inputBlockers;

	private int _pausedCount;

	private Dictionary<string, MethodInfo> _casualGameCommandRouteTable;

	public static T instance
	{
		get
		{
			return null;
		}
	}

	public static bool InputBlocked
	{
		get
		{
			return default(bool);
		}
	}

	public static bool Paused
	{
		get
		{
			return default(bool);
		}
	}

	protected virtual void Awake()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected virtual void OnWindowOpened(WindowOpenedMessage inMessage)
	{
	}

	protected virtual void OnWindowClosed(WindowClosedMessage inMessage)
	{
	}

	protected virtual void OnGamePaused(CasualGamePausedMessage inMessage)
	{
	}

	public static bool GetMouseButtonDown(int inMouseButton = 0)
	{
		return default(bool);
	}

	public static bool GetMouseButton(int inMouseButton = 0)
	{
		return default(bool);
	}

	public static bool GetMouseButtonUp(int inMouseButton = 0)
	{
		return default(bool);
	}

	public virtual void BtnClicked_Settings()
	{
	}

	private void SetupCasualGameCommandAttributes()
	{
	}

	protected void OnCasualGameCommand(CasualGameCommand inMessage)
	{
	}

	protected virtual void HandleGameCommand(CasualGameCommand inMessage)
	{
	}

	protected virtual void SendGameCommand(string[] inArgs)
	{
	}
}
