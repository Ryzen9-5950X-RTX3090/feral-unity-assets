using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class RuntimeCreatedCutscene : Cutscene
{
	[Serializable]
	private class SerializedSettings
	{
		public float speedMultiplier;

		public float cameraTranslationSpeed;

		public float cameraRotationSpeed;

		public float scrollWheelSensitivity;

		public float smoothingFramesCount;

		public float fieldOfView;
	}

	[SerializeField]
	private GameObject _freeLookCameraHUD;

	[SerializeField]
	private GameObject _freeLookCameraParametersDisplay;

	[SerializeField]
	private WWTextMeshProUGUI _moveSpeedText;

	[SerializeField]
	private WWTextMeshProUGUI _mouseSpeedText;

	[SerializeField]
	private WWTextMeshProUGUI _scrollSpeedText;

	[SerializeField]
	private WWTextMeshProUGUI _fieldOfViewText;

	[SerializeField]
	private WWTextMeshProUGUI _smoothingFramesText;

	[SerializeField]
	private WWTextMeshProUGUI _mouseWheelText;

	[SerializeField]
	private WWTextMeshProUGUI _positionText;

	[SerializeField]
	private WWTextMeshProUGUI _rotationText;

	[SerializeField]
	private WWTextMeshProUGUI _fpsText;

	private const float _secondsBetweenKeyPresses = 0.75f;

	private readonly List<Vector3> _previousTranslations;

	private readonly List<Vector2> _previousMousePositions;

	private readonly List<float> _previousScrollWheelValues;

	private readonly KeyCode[] _jklCode;

	private readonly KeyCode[] _konamiCode;

	private bool _isCutsceneSystemActive;

	private bool _isDisplayingPlayer;

	private bool _isDisplayingHUD;

	private bool _isDisplayingParameters;

	private int _jklCodeIndex;

	private int _konamiCodeIndex;

	private int _fpsTextUpdateFrameCount;

	private float? _lastKeyUpTime;

	private string _lastSettingsJSON;

	private SerializedSettings _serializedSettings;

	private Vector2 _cameraEulerRotation;

	private List<KeyCode> _cachedGetNonActivationKeysDownResults;

	private CinematicManager CinematicManager
	{
		get
		{
			return null;
		}
	}

	private bool IsUsingEitherCode
	{
		get
		{
			return default(bool);
		}
	}

	private bool IsUsingJKLCode
	{
		get
		{
			return default(bool);
		}
	}

	private bool IsUsingKonamiCode
	{
		get
		{
			return default(bool);
		}
	}

	public override bool IsPlayable
	{
		get
		{
			return default(bool);
		}
	}

	private void Update()
	{
	}

	protected override void PrePlay()
	{
	}

	[IteratorStateMachine(typeof(<Play>d__41))]
	protected override IEnumerator Play()
	{
		return null;
	}

	protected override void PostPlay()
	{
	}

	private void UpdateControlSettings()
	{
	}

	private void UpdateParametersDisplay()
	{
	}

	private void ResetStates()
	{
	}

	private void ToggleHUDVisibility()
	{
	}

	private void SetHUDVisibility(bool isVisible)
	{
	}

	private void TogglePlayerVisibility()
	{
	}

	private void SetPlayerVisibility(bool isVisible)
	{
	}

	private void ToggleParametersVisibility()
	{
	}

	private void SetParametersVisibility(bool isVisible)
	{
	}

	private void CheckForParameterChanges(KeyCode increaseKey, KeyCode decreaseKey, ref float parameter, float valueMagnitude, float lowerBound, float upperBound)
	{
	}

	private void CheckForActivationKeyCodes()
	{
	}

	private List<KeyCode> GetNonActivationKeysDown()
	{
		return null;
	}

	private bool IsBadActivationKey(KeyCode keyCode)
	{
		return default(bool);
	}

	private void ResetActivationKeys()
	{
	}

	private Vector3 GetCameraTranslationVector()
	{
		return default(Vector3);
	}

	private Vector3 GetCameraRotationVector()
	{
		return default(Vector3);
	}

	private bool CheckUserEmailSubdomain()
	{
		return default(bool);
	}

	private string GetWildWorksSubdomain()
	{
		return null;
	}

	private string GetHammerCreativeSubdomain()
	{
		return null;
	}
}
