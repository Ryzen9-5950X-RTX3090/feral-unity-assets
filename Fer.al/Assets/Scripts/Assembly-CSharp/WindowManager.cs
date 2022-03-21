using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using WW.Debug;

public class WindowManager : CoreWindowManager
{
	[SerializeField]
	private List<string> _fontBundlePaths;

	[SetInstance]
	public static WindowManager instance;

	public override void Init()
	{
	}

	public override bool HasFinishCoroutine()
	{
		return default(bool);
	}

	[IteratorStateMachine(typeof(<FinishCoroutine>d__4))]
	public override IEnumerator FinishCoroutine()
	{
		return null;
	}

	public override void Deinit()
	{
	}

	[ConsoleCommand("listwindows", "Prints all open windows")]
	public static string ListWindows()
	{
		return null;
	}

	[ConsoleCommand("closewindow", "Closes window with provided ID")]
	public static string CloseWindow(string inWindowID)
	{
		return null;
	}

	[ConsoleCommand("openwindow", "Opens window with provided ID")]
	public static void OpenWindow(string inWindowID)
	{
	}
}
