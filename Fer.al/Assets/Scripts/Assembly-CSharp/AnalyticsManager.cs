using System;
using Amazon;
using Amazon.KinesisFirehose;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class AnalyticsManager : SingletonManagerBase<AnalyticsManager>
{
	[Serializable]
	public class FirehoseInfo
	{
		public ObscuredString accessKey;

		public ObscuredString secretKey;

		public ObscuredString regionName;

		public ObscuredString streamName;
	}

	[Serializable]
	public class VivoxEvent
	{
		public string category;

		public string subcategory;

		public string label;

		public string ts;
	}

	[Serializable]
	public class WWRegistrationAnalyticEvent : VivoxEvent
	{
		public RegistrationDataPayload data;

		public WWRegistrationAnalyticEvent(string inCategory, string inSubCategory)
		{
		}
	}

	[Serializable]
	public class RegistrationDataPayload
	{
		public string platform;

		public string install_uuid;

		public string step;

		public bool isError;

		public int step_order;

		public RegistrationDataPayload(string inStep, bool inError, int inStepOrder)
		{
		}
	}

	[Serializable]
	public class WWVivoxAnalyticEventInviteResponse : VivoxEvent
	{
		public VivoxDataPayloadInviteResponse data;

		public WWVivoxAnalyticEventInviteResponse(string inCategory, string inSubCategory)
		{
		}
	}

	[Serializable]
	public class VivoxDataPayloadInviteResponse
	{
		public enum EAction
		{
			accept,
			reject,
			callFull,
			privacySettings,
			blocked,
			manualRejection,
			channelClosed
		}

		public string platform;

		public string call_id;

		public string from_user_uuid;

		public string to_user_uuid;

		public string action;

		public VivoxDataPayloadInviteResponse(string inCallID, string inFromUUID, string inToUUID, string inAction)
		{
		}
	}

	[Serializable]
	public class WWVivoxAnalyticEventCallEnd : VivoxEvent
	{
		public VivoxDataPayloadCallEnd data;

		public WWVivoxAnalyticEventCallEnd(string inCategory, string inSubCategory)
		{
		}
	}

	[Serializable]
	public class VivoxDataPayloadCallEnd
	{
		public string platform;

		public string duration;

		public string user_uuid;

		public string call_id;

		public VivoxDataPayloadCallEnd(string inDuration, string inUUID, string inCallId)
		{
		}
	}

	[SerializeField]
	private FirehoseInfo firehoseDev;

	[SerializeField]
	private FirehoseInfo firehoseStage;

	[SerializeField]
	private FirehoseInfo firehoseProd;

	[SerializeField]
	private ObscuredString _randomUUIDSaveVar;

	[SerializeField]
	private ObscuredString _firstTimeSaveVar;

	private FirehoseInfo _fireHoseInfo;

	private string _randomUUID;

	private string _platform;

	private IAmazonKinesisFirehose _kinesisClient;

	private bool _sendEventsToUnity
	{
		get
		{
			return default(bool);
		}
	}

	private bool _sendEventsToFirehose
	{
		get
		{
			return default(bool);
		}
	}

	private FirehoseInfo fireHoseInfo
	{
		get
		{
			return null;
		}
	}

	private string randomUUID
	{
		get
		{
			return null;
		}
	}

	private string platform
	{
		get
		{
			return null;
		}
	}

	private RegionEndpoint _regionEndPoint
	{
		get
		{
			return null;
		}
	}

	private IAmazonKinesisFirehose kinesisClient
	{
		get
		{
			return null;
		}
	}

	public override void MStart()
	{
	}

	private void SendEvent(VivoxEvent inWWAnalyticEvent)
	{
	}

	private void PutRecord(VivoxEvent inWWAnalyticEvent)
	{
	}

	public void Event_OpenAppForFirstTime()
	{
	}

	public void Event_LoginToExistingAccount()
	{
	}

	public void Event_TapFirstRegister()
	{
	}

	public void Event_TapSecondRegister()
	{
	}

	public void Event_BirthdaySuccess()
	{
	}

	public void Event_BirthdayError()
	{
	}

	public void Event_EmailSuccess()
	{
	}

	public void Event_EmailError()
	{
	}

	public void Event_UsernameSuccess()
	{
	}

	public void Event_UsernameTakenError()
	{
	}

	public void Event_UsernameInappropriateError()
	{
	}

	public void Event_UsernameError_TooShort()
	{
	}

	public void Event_UsernameError_TooLong()
	{
	}

	public void Event_UsernameError(string inError)
	{
	}

	public void Event_UsernameError_InvalidFormat()
	{
	}

	public void Event_UsernameError_Unknown()
	{
	}

	public void Event_PasswordSuccess()
	{
	}

	public void Event_PasswordTooShortError()
	{
	}

	public void Event_PasswordError()
	{
	}

	public void Event_TOSAgree()
	{
	}

	public void Event_TOSDisagree()
	{
	}

	public void Event_CommunicationOptIn()
	{
	}

	public void Event_CommunicationOptOut()
	{
	}

	public void Event_OTPSent()
	{
	}

	public void Event_OTPSuccess()
	{
	}

	public void Event_OTPError()
	{
	}

	public void Event_VivoxEndCall(DateTime inStartTS, DateTime inEndTS, string inUUID, string inCallId)
	{
	}

	public void Event_VivoxInviteResponse(string inCallId, string inFromUserUUID, string inToUserUUID, VivoxDataPayloadInviteResponse.EAction inAction)
	{
	}

	private void AnalyticsLog(string inObject)
	{
	}

	private void AnalyticsLogWarning(string inObject)
	{
	}

	private void AnalyticsLogError(string inObject)
	{
	}
}
