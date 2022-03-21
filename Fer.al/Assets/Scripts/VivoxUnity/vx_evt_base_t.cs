using System;
using System.Runtime.InteropServices;

public class vx_evt_base_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public vx_message_base_t message
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public vx_event_type type
	{
		get
		{
			return default(vx_event_type);
		}
		set
		{
		}
	}

	public string extended_status_info
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_evt_base_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_base_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_base_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public static implicit operator vx_evt_account_login_state_change_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_buddy_presence_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_subscription_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_session_notification_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_message_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_session_archive_message_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_transcribed_message_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_session_archive_query_end_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_aux_audio_properties_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_buddy_changed_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_buddy_group_changed_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_buddy_and_group_list_changed_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_keyboard_mouse_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_idle_state_changed_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_media_stream_updated_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_text_stream_updated_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_sessiongroup_added_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_sessiongroup_removed_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_session_added_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_session_removed_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_participant_added_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_participant_removed_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_participant_updated_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_sessiongroup_playback_frame_played_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_session_updated_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_sessiongroup_updated_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_media_completion_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_server_app_data_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_user_app_data_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_network_message_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_voice_service_connection_state_changed_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_publication_state_changed_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_audio_device_hot_swap_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_user_to_user_message_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_account_archive_message_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_account_archive_query_end_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_account_send_message_failed_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_tts_injection_started_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_tts_injection_ended_t(vx_evt_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_tts_injection_failed_t(vx_evt_base_t t)
	{
		return null;
	}

	public vx_evt_account_login_state_change_t as_vx_evt_account_login_state_change()
	{
		return null;
	}

	public vx_evt_buddy_presence_t as_vx_evt_buddy_presence()
	{
		return null;
	}

	public vx_evt_subscription_t as_vx_evt_subscription()
	{
		return null;
	}

	public vx_evt_session_notification_t as_vx_evt_session_notification()
	{
		return null;
	}

	public vx_evt_message_t as_vx_evt_message()
	{
		return null;
	}

	public vx_evt_session_archive_message_t as_vx_evt_session_archive_message()
	{
		return null;
	}

	public vx_evt_transcribed_message_t as_vx_evt_transcribed_message()
	{
		return null;
	}

	public vx_evt_session_archive_query_end_t as_vx_evt_session_archive_query_end()
	{
		return null;
	}

	public vx_evt_aux_audio_properties_t as_vx_evt_aux_audio_properties()
	{
		return null;
	}

	public vx_evt_buddy_changed_t as_vx_evt_buddy_changed()
	{
		return null;
	}

	public vx_evt_buddy_group_changed_t as_vx_evt_buddy_group_changed()
	{
		return null;
	}

	public vx_evt_buddy_and_group_list_changed_t as_vx_evt_buddy_and_group_list_changed()
	{
		return null;
	}

	public vx_evt_keyboard_mouse_t as_vx_evt_keyboard_mouse()
	{
		return null;
	}

	public vx_evt_idle_state_changed_t as_vx_evt_idle_state_changed()
	{
		return null;
	}

	public vx_evt_media_stream_updated_t as_vx_evt_media_stream_updated()
	{
		return null;
	}

	public vx_evt_text_stream_updated_t as_vx_evt_text_stream_updated()
	{
		return null;
	}

	public vx_evt_sessiongroup_added_t as_vx_evt_sessiongroup_added()
	{
		return null;
	}

	public vx_evt_sessiongroup_removed_t as_vx_evt_sessiongroup_removed()
	{
		return null;
	}

	public vx_evt_session_added_t as_vx_evt_session_added()
	{
		return null;
	}

	public vx_evt_session_removed_t as_vx_evt_session_removed()
	{
		return null;
	}

	public vx_evt_participant_added_t as_vx_evt_participant_added()
	{
		return null;
	}

	public vx_evt_participant_removed_t as_vx_evt_participant_removed()
	{
		return null;
	}

	public vx_evt_participant_updated_t as_vx_evt_participant_updated()
	{
		return null;
	}

	public vx_evt_sessiongroup_playback_frame_played_t as_vx_evt_sessiongroup_playback_frame_played()
	{
		return null;
	}

	public vx_evt_session_updated_t as_vx_evt_session_updated()
	{
		return null;
	}

	public vx_evt_sessiongroup_updated_t as_vx_evt_sessiongroup_updated()
	{
		return null;
	}

	public vx_evt_media_completion_t as_vx_evt_media_completion()
	{
		return null;
	}

	public vx_evt_server_app_data_t as_vx_evt_server_app_data()
	{
		return null;
	}

	public vx_evt_user_app_data_t as_vx_evt_user_app_data()
	{
		return null;
	}

	public vx_evt_network_message_t as_vx_evt_network_message()
	{
		return null;
	}

	public vx_evt_voice_service_connection_state_changed_t as_vx_evt_voice_service_connection_state_changed()
	{
		return null;
	}

	public vx_evt_publication_state_changed_t as_vx_evt_publication_state_changed()
	{
		return null;
	}

	public vx_evt_audio_device_hot_swap_t as_vx_evt_audio_device_hot_swap()
	{
		return null;
	}

	public vx_evt_user_to_user_message_t as_vx_evt_user_to_user_message()
	{
		return null;
	}

	public vx_evt_account_archive_message_t as_vx_evt_account_archive_message()
	{
		return null;
	}

	public vx_evt_account_archive_query_end_t as_vx_evt_account_archive_query_end()
	{
		return null;
	}

	public vx_evt_account_send_message_failed_t as_vx_evt_account_send_message_failed()
	{
		return null;
	}

	public vx_evt_tts_injection_started_t as_vx_evt_tts_injection_started()
	{
		return null;
	}

	public vx_evt_tts_injection_ended_t as_vx_evt_tts_injection_ended()
	{
		return null;
	}

	public vx_evt_tts_injection_failed_t as_vx_evt_tts_injection_failed()
	{
		return null;
	}

	public vx_evt_base_t()
	{
	}
}
