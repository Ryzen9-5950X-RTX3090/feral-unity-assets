using System;
using System.Runtime.InteropServices;

public class vx_resp_base_t : IDisposable
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

	public vx_response_type type
	{
		get
		{
			return default(vx_response_type);
		}
		set
		{
		}
	}

	public int return_code
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int status_code
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public string status_string
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public vx_req_base_t request
	{
		get
		{
			return null;
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

	internal vx_resp_base_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_resp_base_t obj)
	{
		return default(HandleRef);
	}

	~vx_resp_base_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public static implicit operator vx_resp_connector_create_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_connector_initiate_shutdown_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_login_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_authtoken_login_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_anonymous_login_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_logout_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_set_login_properties_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_sessiongroup_create_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_sessiongroup_terminate_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_sessiongroup_add_session_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_sessiongroup_remove_session_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_sessiongroup_set_focus_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_sessiongroup_unset_focus_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_sessiongroup_reset_focus_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_sessiongroup_set_tx_session_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_sessiongroup_set_tx_all_sessions_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_sessiongroup_set_tx_no_session_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_sessiongroup_set_session_3d_position_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_sessiongroup_control_audio_injection_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_session_create_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_session_media_connect_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_session_media_disconnect_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_session_text_connect_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_session_text_disconnect_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_session_terminate_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_session_mute_local_speaker_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_session_set_local_speaker_volume_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_session_set_local_render_volume_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_session_channel_invite_user_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_session_set_participant_volume_for_me_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_session_set_participant_mute_for_me_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_session_set_3d_position_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_session_set_voice_font_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_channel_get_participants_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_channel_change_owner_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_send_user_app_data_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_channel_create_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_channel_update_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_channel_delete_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_channel_favorites_get_list_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_channel_favorite_set_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_channel_favorite_delete_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_channel_favorite_group_set_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_channel_favorite_group_delete_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_channel_get_info_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_channel_search_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_buddy_search_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_channel_add_moderator_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_channel_remove_moderator_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_channel_get_moderators_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_channel_add_acl_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_channel_remove_acl_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_channel_get_acl_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_channel_mute_user_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_channel_ban_user_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_channel_get_banned_users_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_channel_kick_user_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_channel_mute_all_users_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_channel_set_lock_mode_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_connector_mute_local_mic_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_connector_mute_local_speaker_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_connector_set_local_mic_volume_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_connector_set_local_speaker_volume_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_connector_get_local_audio_info_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_buddy_set_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_buddy_delete_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_buddygroup_set_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_buddygroup_delete_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_list_buddies_and_groups_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_session_send_message_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_session_archive_query_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_set_presence_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_send_subscription_reply_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_session_send_notification_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_session_send_dtmf_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_create_block_rule_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_delete_block_rule_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_list_block_rules_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_create_auto_accept_rule_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_delete_auto_accept_rule_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_list_auto_accept_rules_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_update_account_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_get_account_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_send_sms_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_connectivity_info_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_get_render_devices_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_get_capture_devices_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_set_render_device_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_set_capture_device_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_get_mic_level_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_get_speaker_level_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_set_mic_level_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_set_speaker_level_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_render_audio_start_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_render_audio_modify_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_get_vad_properties_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_set_vad_properties_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_get_derumbler_properties_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_set_derumbler_properties_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_render_audio_stop_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_capture_audio_start_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_capture_audio_stop_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_global_monitor_keyboard_mouse_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_set_idle_timeout_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_create_account_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_reactivate_account_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_deactivate_account_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_post_crash_dump_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_reset_password_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_get_session_fonts_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_get_template_fonts_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_start_buffer_capture_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_play_audio_buffer_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_diagnostic_state_dump_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_web_call_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_sessiongroup_get_stats_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_send_message_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_archive_query_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_aux_notify_application_state_change_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_account_control_communications_t(vx_resp_base_t t)
	{
		return null;
	}

	public static implicit operator vx_resp_session_transcription_control_t(vx_resp_base_t t)
	{
		return null;
	}

	public vx_resp_connector_create_t as_vx_resp_connector_create()
	{
		return null;
	}

	public vx_resp_connector_initiate_shutdown_t as_vx_resp_connector_initiate_shutdown()
	{
		return null;
	}

	public vx_resp_account_login_t as_vx_resp_account_login()
	{
		return null;
	}

	public vx_resp_account_authtoken_login_t as_vx_resp_account_authtoken_login()
	{
		return null;
	}

	public vx_resp_account_anonymous_login_t as_vx_resp_account_anonymous_login()
	{
		return null;
	}

	public vx_resp_account_logout_t as_vx_resp_account_logout()
	{
		return null;
	}

	public vx_resp_account_set_login_properties_t as_vx_resp_account_set_login_properties()
	{
		return null;
	}

	public vx_resp_sessiongroup_create_t as_vx_resp_sessiongroup_create()
	{
		return null;
	}

	public vx_resp_sessiongroup_terminate_t as_vx_resp_sessiongroup_terminate()
	{
		return null;
	}

	public vx_resp_sessiongroup_add_session_t as_vx_resp_sessiongroup_add_session()
	{
		return null;
	}

	public vx_resp_sessiongroup_remove_session_t as_vx_resp_sessiongroup_remove_session()
	{
		return null;
	}

	public vx_resp_sessiongroup_set_focus_t as_vx_resp_sessiongroup_set_focus()
	{
		return null;
	}

	public vx_resp_sessiongroup_unset_focus_t as_vx_resp_sessiongroup_unset_focus()
	{
		return null;
	}

	public vx_resp_sessiongroup_reset_focus_t as_vx_resp_sessiongroup_reset_focus()
	{
		return null;
	}

	public vx_resp_sessiongroup_set_tx_session_t as_vx_resp_sessiongroup_set_tx_session()
	{
		return null;
	}

	public vx_resp_sessiongroup_set_tx_all_sessions_t as_vx_resp_sessiongroup_set_tx_all_sessions()
	{
		return null;
	}

	public vx_resp_sessiongroup_set_tx_no_session_t as_vx_resp_sessiongroup_set_tx_no_session()
	{
		return null;
	}

	public vx_resp_sessiongroup_set_session_3d_position_t as_vx_resp_sessiongroup_set_session_3d_position()
	{
		return null;
	}

	public vx_resp_sessiongroup_control_audio_injection_t as_vx_resp_sessiongroup_control_audio_injection()
	{
		return null;
	}

	public vx_resp_session_create_t as_vx_resp_session_create()
	{
		return null;
	}

	public vx_resp_session_media_connect_t as_vx_resp_session_media_connect()
	{
		return null;
	}

	public vx_resp_session_media_disconnect_t as_vx_resp_session_media_disconnect()
	{
		return null;
	}

	public vx_resp_session_text_connect_t as_vx_resp_session_text_connect()
	{
		return null;
	}

	public vx_resp_session_text_disconnect_t as_vx_resp_session_text_disconnect()
	{
		return null;
	}

	public vx_resp_session_terminate_t as_vx_resp_session_terminate()
	{
		return null;
	}

	public vx_resp_session_mute_local_speaker_t as_vx_resp_session_mute_local_speaker()
	{
		return null;
	}

	public vx_resp_session_set_local_speaker_volume_t as_vx_resp_session_set_local_speaker_volume()
	{
		return null;
	}

	public vx_resp_session_set_local_render_volume_t as_vx_resp_session_set_local_render_volume()
	{
		return null;
	}

	public vx_resp_session_channel_invite_user_t as_vx_resp_session_channel_invite_user()
	{
		return null;
	}

	public vx_resp_session_set_participant_volume_for_me_t as_vx_resp_session_set_participant_volume_for_me()
	{
		return null;
	}

	public vx_resp_session_set_participant_mute_for_me_t as_vx_resp_session_set_participant_mute_for_me()
	{
		return null;
	}

	public vx_resp_session_set_3d_position_t as_vx_resp_session_set_3d_position()
	{
		return null;
	}

	public vx_resp_session_set_voice_font_t as_vx_resp_session_set_voice_font()
	{
		return null;
	}

	public vx_resp_account_channel_get_participants_t as_vx_resp_account_channel_get_participants()
	{
		return null;
	}

	public vx_resp_account_channel_change_owner_t as_vx_resp_account_channel_change_owner()
	{
		return null;
	}

	public vx_resp_account_send_user_app_data_t as_vx_resp_account_send_user_app_data()
	{
		return null;
	}

	public vx_resp_account_channel_create_t as_vx_resp_account_channel_create()
	{
		return null;
	}

	public vx_resp_account_channel_update_t as_vx_resp_account_channel_update()
	{
		return null;
	}

	public vx_resp_account_channel_delete_t as_vx_resp_account_channel_delete()
	{
		return null;
	}

	public vx_resp_account_channel_favorites_get_list_t as_vx_resp_account_channel_favorites_get_list()
	{
		return null;
	}

	public vx_resp_account_channel_favorite_set_t as_vx_resp_account_channel_favorite_set()
	{
		return null;
	}

	public vx_resp_account_channel_favorite_delete_t as_vx_resp_account_channel_favorite_delete()
	{
		return null;
	}

	public vx_resp_account_channel_favorite_group_set_t as_vx_resp_account_channel_favorite_group_set()
	{
		return null;
	}

	public vx_resp_account_channel_favorite_group_delete_t as_vx_resp_account_channel_favorite_group_delete()
	{
		return null;
	}

	public vx_resp_account_channel_get_info_t as_vx_resp_account_channel_get_info()
	{
		return null;
	}

	public vx_resp_account_channel_search_t as_vx_resp_account_channel_search()
	{
		return null;
	}

	public vx_resp_account_buddy_search_t as_vx_resp_account_buddy_search()
	{
		return null;
	}

	public vx_resp_account_channel_add_moderator_t as_vx_resp_account_channel_add_moderator()
	{
		return null;
	}

	public vx_resp_account_channel_remove_moderator_t as_vx_resp_account_channel_remove_moderator()
	{
		return null;
	}

	public vx_resp_account_channel_get_moderators_t as_vx_resp_account_channel_get_moderators()
	{
		return null;
	}

	public vx_resp_account_channel_add_acl_t as_vx_resp_account_channel_add_acl()
	{
		return null;
	}

	public vx_resp_account_channel_remove_acl_t as_vx_resp_account_channel_remove_acl()
	{
		return null;
	}

	public vx_resp_account_channel_get_acl_t as_vx_resp_account_channel_get_acl()
	{
		return null;
	}

	public vx_resp_channel_mute_user_t as_vx_resp_channel_mute_user()
	{
		return null;
	}

	public vx_resp_channel_ban_user_t as_vx_resp_channel_ban_user()
	{
		return null;
	}

	public vx_resp_channel_get_banned_users_t as_vx_resp_channel_get_banned_users()
	{
		return null;
	}

	public vx_resp_channel_kick_user_t as_vx_resp_channel_kick_user()
	{
		return null;
	}

	public vx_resp_channel_mute_all_users_t as_vx_resp_channel_mute_all_users()
	{
		return null;
	}

	public vx_resp_channel_set_lock_mode_t as_vx_resp_channel_set_lock_mode()
	{
		return null;
	}

	public vx_resp_connector_mute_local_mic_t as_vx_resp_connector_mute_local_mic()
	{
		return null;
	}

	public vx_resp_connector_mute_local_speaker_t as_vx_resp_connector_mute_local_speaker()
	{
		return null;
	}

	public vx_resp_connector_set_local_mic_volume_t as_vx_resp_connector_set_local_mic_volume()
	{
		return null;
	}

	public vx_resp_connector_set_local_speaker_volume_t as_vx_resp_connector_set_local_speaker_volume()
	{
		return null;
	}

	public vx_resp_connector_get_local_audio_info_t as_vx_resp_connector_get_local_audio_info()
	{
		return null;
	}

	public vx_resp_account_buddy_set_t as_vx_resp_account_buddy_set()
	{
		return null;
	}

	public vx_resp_account_buddy_delete_t as_vx_resp_account_buddy_delete()
	{
		return null;
	}

	public vx_resp_account_buddygroup_set_t as_vx_resp_account_buddygroup_set()
	{
		return null;
	}

	public vx_resp_account_buddygroup_delete_t as_vx_resp_account_buddygroup_delete()
	{
		return null;
	}

	public vx_resp_account_list_buddies_and_groups_t as_vx_resp_account_list_buddies_and_groups()
	{
		return null;
	}

	public vx_resp_session_send_message_t as_vx_resp_session_send_message()
	{
		return null;
	}

	public vx_resp_session_archive_query_t as_vx_resp_session_archive_query()
	{
		return null;
	}

	public vx_resp_account_set_presence_t as_vx_resp_account_set_presence()
	{
		return null;
	}

	public vx_resp_account_send_subscription_reply_t as_vx_resp_account_send_subscription_reply()
	{
		return null;
	}

	public vx_resp_session_send_notification_t as_vx_resp_session_send_notification()
	{
		return null;
	}

	public vx_resp_session_send_dtmf_t as_vx_resp_session_send_dtmf()
	{
		return null;
	}

	public vx_resp_account_create_block_rule_t as_vx_resp_account_create_block_rule()
	{
		return null;
	}

	public vx_resp_account_delete_block_rule_t as_vx_resp_account_delete_block_rule()
	{
		return null;
	}

	public vx_resp_account_list_block_rules_t as_vx_resp_account_list_block_rules()
	{
		return null;
	}

	public vx_resp_account_create_auto_accept_rule_t as_vx_resp_account_create_auto_accept_rule()
	{
		return null;
	}

	public vx_resp_account_delete_auto_accept_rule_t as_vx_resp_account_delete_auto_accept_rule()
	{
		return null;
	}

	public vx_resp_account_list_auto_accept_rules_t as_vx_resp_account_list_auto_accept_rules()
	{
		return null;
	}

	public vx_resp_account_update_account_t as_vx_resp_account_update_account()
	{
		return null;
	}

	public vx_resp_account_get_account_t as_vx_resp_account_get_account()
	{
		return null;
	}

	public vx_resp_account_send_sms_t as_vx_resp_account_send_sms()
	{
		return null;
	}

	public vx_resp_aux_connectivity_info_t as_vx_resp_aux_connectivity_info()
	{
		return null;
	}

	public vx_resp_aux_get_render_devices_t as_vx_resp_aux_get_render_devices()
	{
		return null;
	}

	public vx_resp_aux_get_capture_devices_t as_vx_resp_aux_get_capture_devices()
	{
		return null;
	}

	public vx_resp_aux_set_render_device_t as_vx_resp_aux_set_render_device()
	{
		return null;
	}

	public vx_resp_aux_set_capture_device_t as_vx_resp_aux_set_capture_device()
	{
		return null;
	}

	public vx_resp_aux_get_mic_level_t as_vx_resp_aux_get_mic_level()
	{
		return null;
	}

	public vx_resp_aux_get_speaker_level_t as_vx_resp_aux_get_speaker_level()
	{
		return null;
	}

	public vx_resp_aux_set_mic_level_t as_vx_resp_aux_set_mic_level()
	{
		return null;
	}

	public vx_resp_aux_set_speaker_level_t as_vx_resp_aux_set_speaker_level()
	{
		return null;
	}

	public vx_resp_aux_render_audio_start_t as_vx_resp_aux_render_audio_start()
	{
		return null;
	}

	public vx_resp_aux_render_audio_modify_t as_vx_resp_aux_render_audio_modify()
	{
		return null;
	}

	public vx_resp_aux_get_vad_properties_t as_vx_resp_aux_get_vad_properties()
	{
		return null;
	}

	public vx_resp_aux_set_vad_properties_t as_vx_resp_aux_set_vad_properties()
	{
		return null;
	}

	public vx_resp_aux_get_derumbler_properties_t as_vx_resp_aux_get_derumbler_properties()
	{
		return null;
	}

	public vx_resp_aux_set_derumbler_properties_t as_vx_resp_aux_set_derumbler_properties()
	{
		return null;
	}

	public vx_resp_aux_render_audio_stop_t as_vx_resp_aux_render_audio_stop()
	{
		return null;
	}

	public vx_resp_aux_capture_audio_start_t as_vx_resp_aux_capture_audio_start()
	{
		return null;
	}

	public vx_resp_aux_capture_audio_stop_t as_vx_resp_aux_capture_audio_stop()
	{
		return null;
	}

	public vx_resp_aux_global_monitor_keyboard_mouse_t as_vx_resp_aux_global_monitor_keyboard_mouse()
	{
		return null;
	}

	public vx_resp_aux_set_idle_timeout_t as_vx_resp_aux_set_idle_timeout()
	{
		return null;
	}

	public vx_resp_aux_create_account_t as_vx_resp_aux_create_account()
	{
		return null;
	}

	public vx_resp_aux_reactivate_account_t as_vx_resp_aux_reactivate_account()
	{
		return null;
	}

	public vx_resp_aux_deactivate_account_t as_vx_resp_aux_deactivate_account()
	{
		return null;
	}

	public vx_resp_account_post_crash_dump_t as_vx_resp_account_post_crash_dump()
	{
		return null;
	}

	public vx_resp_aux_reset_password_t as_vx_resp_aux_reset_password()
	{
		return null;
	}

	public vx_resp_account_get_session_fonts_t as_vx_resp_account_get_session_fonts()
	{
		return null;
	}

	public vx_resp_account_get_template_fonts_t as_vx_resp_account_get_template_fonts()
	{
		return null;
	}

	public vx_resp_aux_start_buffer_capture_t as_vx_resp_aux_start_buffer_capture()
	{
		return null;
	}

	public vx_resp_aux_play_audio_buffer_t as_vx_resp_aux_play_audio_buffer()
	{
		return null;
	}

	public vx_resp_aux_diagnostic_state_dump_t as_vx_resp_aux_diagnostic_state_dump()
	{
		return null;
	}

	public vx_resp_account_web_call_t as_vx_resp_account_web_call()
	{
		return null;
	}

	public vx_resp_sessiongroup_get_stats_t as_vx_resp_sessiongroup_get_stats()
	{
		return null;
	}

	public vx_resp_account_send_message_t as_vx_resp_account_send_message()
	{
		return null;
	}

	public vx_resp_account_archive_query_t as_vx_resp_account_archive_query()
	{
		return null;
	}

	public vx_resp_aux_notify_application_state_change_t as_vx_resp_aux_notify_application_state_change()
	{
		return null;
	}

	public vx_resp_account_control_communications_t as_vx_resp_account_control_communications()
	{
		return null;
	}

	public vx_resp_session_transcription_control_t as_vx_resp_session_transcription_control()
	{
		return null;
	}

	public vx_resp_base_t()
	{
	}
}
