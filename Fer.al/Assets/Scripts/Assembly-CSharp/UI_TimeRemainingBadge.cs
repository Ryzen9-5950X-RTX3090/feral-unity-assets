using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class UI_TimeRemainingBadge : MonoBehaviour
{
	[SerializeField]
	private GameObject _groupNew;

	[SerializeField]
	private GameObject _groupLeavingSoon;

	[SerializeField]
	private WWTextMeshProUGUI _timeRemainingText;

	[SerializeField]
	[Range(1f, 10f)]
	private int _daysAfterNewStatus;

	[SerializeField]
	[Range(1f, 10f)]
	private int _daysBeforeExpiringStatus;

	[SerializeField]
	private bool _allowShowExpiring;

	[SerializeField]
	private bool _forceAlwaysNew;

	[SerializeField]
	private FeralAudioInfo _enableNewBadgeAudio;

	[SerializeField]
	private float _enableDelay;

	private DateTime? _startDate;

	private DateTime? _expirationDate;

	private TimeSpan _newItemTimeSpan;

	private TimeSpan _expiringTimeSpan;

	private void OnDisable()
	{
	}

	public void Setup(BaseDef inDef)
	{
	}

	public void Setup([Optional] DateTime? inStartDate, [Optional] DateTime? inExpirationDate)
	{
	}

	private void EnableNewGroup()
	{
	}

	private void EnableExpirationGroup()
	{
	}

	private void Disable()
	{
	}

	[IteratorStateMachine(typeof(<UpdateTimeRemainingBadge>d__19))]
	private IEnumerator UpdateTimeRemainingBadge()
	{
		return null;
	}

	private string GetTimeRemaining(TimeSpan timeDifference)
	{
		return null;
	}

	private string GetTimeValueUnit(int value, string unit)
	{
		return null;
	}

	private bool IsNew()
	{
		return default(bool);
	}

	private bool IsExpiring()
	{
		return default(bool);
	}

	private bool IsNegative(TimeSpan timeDifference)
	{
		return default(bool);
	}

	private TimeSpan GetNewDateDifference()
	{
		return default(TimeSpan);
	}

	private TimeSpan GetExpirationDateDifference()
	{
		return default(TimeSpan);
	}
}
