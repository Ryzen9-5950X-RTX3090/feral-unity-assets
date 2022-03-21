using UnityEngine;

public static class ChatServiceRequests
{
	public class ChatStartSessionRequest : PersistentServiceRequest
	{
		[SerializeField]
		protected string uuid;

		[SerializeField]
		protected string auth_token;
	}

	public class ChatPingRequest : PersistentServiceRequest
	{
	}

	public class RoomJoinRequest : PersistentServiceRequest
	{
		[SerializeField]
		protected int roomId;

		public RoomJoinRequest(int roomId)
		{
		}
	}

	public class RoomLeaveRequest : PersistentServiceRequest
	{
		[SerializeField]
		protected string roomName;

		public RoomLeaveRequest(string roomName)
		{
		}
	}

	public class ChatMessageRequest : PersistentServiceRequest
	{
		[SerializeField]
		protected string message;

		[SerializeField]
		protected string conversationId;

		public ChatMessageRequest(string message, string conversationId)
		{
		}
	}

	public class ConversationGetRequest : PersistentServiceRequest
	{
		[SerializeField]
		protected string conversationId;

		public ConversationGetRequest(string inConversationId)
		{
		}
	}

	public class ConversationListRequest : PersistentServiceRequest
	{
		[SerializeField]
		protected int pageSize;

		[SerializeField]
		protected string cursor;

		public ConversationListRequest(string inCursor, int inPageSize)
		{
		}
	}

	public class ConversationRequest : PersistentServiceRequest
	{
		[SerializeField]
		protected string conversation_id;

		public ConversationRequest(string conversationId)
		{
		}
	}

	public class ConversationRenameRequest : PersistentServiceRequest
	{
		[SerializeField]
		protected string conversation_id;

		[SerializeField]
		protected string title;

		public ConversationRenameRequest(string newTitle, string conversationId)
		{
		}
	}

	public class ConversationAddRequest : PersistentServiceRequest
	{
		[SerializeField]
		protected string conversationId;

		[SerializeField]
		protected string participant;

		public ConversationAddRequest(string inConversationId, string inUserIdToAdd)
		{
		}
	}

	public class ConversationLeaveRequest : PersistentServiceRequest
	{
		[SerializeField]
		protected string conversation_id;

		public ConversationLeaveRequest(string conversationId)
		{
		}
	}

	public class ConversationCreateRequest : PersistentServiceRequest
	{
		[SerializeField]
		protected string title;

		[SerializeField]
		protected string[] participants;

		[SerializeField]
		protected string conversationType;

		public ConversationCreateRequest(string inName, string inConversationType, string[] inParticipants)
		{
		}
	}

	public class ChatConversationOpenPrivateRequest : PersistentServiceRequest
	{
		[SerializeField]
		protected string participant;

		public ChatConversationOpenPrivateRequest(string inOtherParticipantUUID)
		{
		}
	}

	public class ChatConversationHistoryRequest : PersistentServiceRequest
	{
		[SerializeField]
		protected string conversationId;

		[SerializeField]
		protected int pageSize;

		[SerializeField]
		protected string cursor;

		[SerializeField]
		protected bool include_messages;

		public ChatConversationHistoryRequest(string inConversationId, string inCursor, int inPageSize, bool inIncludeMessages = true)
		{
		}
	}
}
