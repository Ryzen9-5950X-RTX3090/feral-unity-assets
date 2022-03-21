using System;
using System.Collections.Generic;

public class BackButtonHandler : MonoBehaviour
{
	private static BackButtonHandler _instance;

	private const float BackButtonMinimumTime = 0.25f;

	private List<Action> _stack;

	private float _lastBackButtonTime;

	public static BackButtonHandler instance
	{
		get
		{
			return null;
		}
	}

	public static void Push(Action onBackButton)
	{
	}

	public static void Pop(Action onBackButton)
	{
	}

	private void Update()
	{
	}
}
