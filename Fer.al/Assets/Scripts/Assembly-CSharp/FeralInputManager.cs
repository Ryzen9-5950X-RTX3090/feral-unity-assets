using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using UnityEngine;
using UnityEngine.EventSystems;
using WW.Waiters;

public class FeralInputManager : SingletonManagerBase<FeralInputManager>
{
	private Dictionary<int, List<Action>> _registeredActions;

	private Player _rewiredPlayer;

	private int _gameplayActionCategoryDisableRequests;

	private int _playerMovementActionCategoryDisableRequests;

	private int _uiActionCategoryDisableRequests;

	private WW.Waiters.Waiter _gameplayMapWaiter;

	private WW.Waiters.Waiter _playerMovementMapWaiter;

	private WW.Waiters.Waiter _uiMapWaiter;

	private bool _controlsEnabled;

	private GameObject _previousSelectedGameObject;

	private bool _autoRun;

	private PointerEventData _pointerEventData;

	private List<RaycastResult> _pointerRaycastResults;

	private List<GameObject> _currentScrollCandidates;

	private List<GameObject> _currentClickCandidates;

	private List<GameObject> _currentTouchedObjects;

	private int _enablesToDisables;

	private List<ActionElementMap> _cachedMouseAxisMaps;

	public Player RewiredPlayer
	{
		get
		{
			return null;
		}
	}

	public bool IsGameplayActionCategoryEnabled
	{
		get
		{
			return default(bool);
		}
	}

	public bool ControlsEnabled
	{
		get
		{
			return default(bool);
		}
	}

	public Vector2? MoveVectorOverride
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool IsUsingJoystick
	{
		get
		{
			return default(bool);
		}
	}

	public GameObject CurrentSelectedGameObject
	{
		get
		{
			return null;
		}
	}

	public bool HasScrollCandidate
	{
		get
		{
			return default(bool);
		}
	}

	public bool HasClickCandidate
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsTouchingUI
	{
		get
		{
			return default(bool);
		}
	}

	public override void Init()
	{
	}

	public override void Deinit()
	{
	}

	private void SetControlsEnabled(SetControlsEnabledCommand inCommand)
	{
	}

	private void OnDisableGameplayActionCategory(DisableGameplayActionCategoryMessage inMessage)
	{
	}

	private void OnDisableUIActionCategory(DisableUIActionCategoryMessage inMessage)
	{
	}

	private void OnInputEvent(InputActionEventData inInputActionEventData)
	{
	}

	public void RegisterAction(int inActionId, Action inAction)
	{
	}

	public void UnregisterAction(int inActionId, Action inAction)
	{
	}

	public Vector2 GetMoveVector()
	{
		return default(Vector2);
	}

	public Vector2 GetRotationVector()
	{
		return default(Vector2);
	}

	public Vector2 GetPanVector()
	{
		return default(Vector2);
	}

	public bool GetPanButton()
	{
		return default(bool);
	}

	public bool GetPanButtonDown()
	{
		return default(bool);
	}

	public float GetZoomAxis()
	{
		return default(float);
	}

	public void SetMouseAxisRotationMapping(bool isMapping)
	{
	}

	public void SetSelectedGameObject(GameObject inGameObject)
	{
	}

	public List<GameObject> GetCurrentScrollCandidates()
	{
		return null;
	}

	public List<GameObject> GetCurrentClickCandidates([Optional] Vector2 inPositionToCheck)
	{
		return null;
	}

	public List<GameObject> GetCurrentTouchedObjects()
	{
		return null;
	}

	private void Update()
	{
	}
}
