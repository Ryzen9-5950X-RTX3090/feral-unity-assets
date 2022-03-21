using System.Collections.Generic;
using LitJson;
using Server;
using UnityEngine;

public static class VoiceChatServiceRequests
{
	public class VoiceChatStartSessionRequest : PersistentServiceRequest
	{
		[SerializeField]
		protected string uuid;

		[SerializeField]
		protected string auth_token;
	}

	public class VoiceChatPingRequest : PersistentServiceRequest
	{
	}

	public class VoiceChatNewCallRequest : PersistentServiceRequest
	{
		[SerializeField]
		protected string uuid;

		public VoiceChatNewCallRequest(string uuid)
		{
		}
	}

	public class VoiceChatInvitePlayer : PersistentServiceRequest
	{
		[SerializeField]
		protected string attendee;

		public VoiceChatInvitePlayer(string uuid)
		{
		}
	}

	public class VoiceChatLeaveCall : PersistentServiceRequest
	{
	}

	public class VoiceChatGetAttendees : PersistentServiceRequest
	{
	}

	[RoutedMessage("call.start", QueueMessageMode.Never)]
	public class VoiceChatCallGetResponse : ServiceMessage
	{
		public readonly bool Success;

		public readonly string CallID;

		public readonly string Error;

		public VoiceChatCallGetResponse(JsonData jsonData)
		{
		}
	}

	[RoutedMessage("call.add", QueueMessageMode.Never)]
	public class VoiceChatInvitePlayerGetResponse : ServiceMessage
	{
		public readonly bool Success;

		public readonly string Error;

		public VoiceChatInvitePlayerGetResponse(JsonData jsonData)
		{
		}
	}

	[RoutedMessage("call.leave", QueueMessageMode.Never)]
	public class VoiceChatLeaveCallGetResponse : ServiceMessage
	{
		public readonly bool Success;

		public readonly string Error;

		public VoiceChatLeaveCallGetResponse(JsonData jsonData)
		{
		}
	}

	[RoutedMessage("call.attendees", QueueMessageMode.Never)]
	public class VoiceChatGetAttendeesResponse : ServiceMessage
	{
		public readonly bool Success;

		public readonly string Error;

		public readonly List<string> Attendees;

		public VoiceChatGetAttendeesResponse(JsonData jsonData)
		{
		}
	}
}
