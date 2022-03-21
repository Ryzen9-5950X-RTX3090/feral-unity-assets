using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QRoutineMaster : MonoBehaviour
{
	private static QRoutineMaster _instance;

	private static QRoutineGroup _masterGroup;

	private static QRoutineGroup _standardGroup;

	private static QRoutine _currentActiveQRoutine;

	private List<QRoutineGroup> _tempSubGroups;

	private static QRoutineMaster Instance
	{
		get
		{
			return null;
		}
	}

	public static QRoutineGroup MasterGroup
	{
		get
		{
			return null;
		}
	}

	public static QRoutineGroup StandardGroup
	{
		get
		{
			return null;
		}
	}

	public static QRoutine CurrentActiveQRoutine
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string CurrentQRoutineStack
	{
		get
		{
			return null;
		}
	}

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	public static void CoreReset()
	{
	}

	public static QRoutineMaster CreateMasterObject(string inName)
	{
		return null;
	}

	public static void TrackAsset(Object inAsset)
	{
	}

	public static bool TryMoveNextQRoutine(IEnumerator inIEnumerator, QRoutine inParentQRoutine)
	{
		return default(bool);
	}

	private void Update()
	{
	}
}
