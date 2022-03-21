using System;
using System.Runtime.InteropServices;
using AOT;

internal class VivoxCoreInstancePINVOKE
{
	protected class SWIGExceptionHelper
	{
		public delegate void ExceptionDelegate(string message);

		public delegate void ExceptionArgumentDelegate(string message, string paramName);

		private static ExceptionDelegate applicationDelegate;

		private static ExceptionDelegate arithmeticDelegate;

		private static ExceptionDelegate divideByZeroDelegate;

		private static ExceptionDelegate indexOutOfRangeDelegate;

		private static ExceptionDelegate invalidCastDelegate;

		private static ExceptionDelegate invalidOperationDelegate;

		private static ExceptionDelegate ioDelegate;

		private static ExceptionDelegate nullReferenceDelegate;

		private static ExceptionDelegate outOfMemoryDelegate;

		private static ExceptionDelegate overflowDelegate;

		private static ExceptionDelegate systemDelegate;

		private static ExceptionArgumentDelegate argumentDelegate;

		private static ExceptionArgumentDelegate argumentNullDelegate;

		private static ExceptionArgumentDelegate argumentOutOfRangeDelegate;

		public static extern void SWIGRegisterExceptionCallbacks_VivoxCoreInstance(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate);

		public static extern void SWIGRegisterExceptionCallbacksArgument_VivoxCoreInstance(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate);

		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingApplicationException(string message)
		{
		}

		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingArithmeticException(string message)
		{
		}

		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingDivideByZeroException(string message)
		{
		}

		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingIndexOutOfRangeException(string message)
		{
		}

		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingInvalidCastException(string message)
		{
		}

		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingInvalidOperationException(string message)
		{
		}

		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingIOException(string message)
		{
		}

		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingNullReferenceException(string message)
		{
		}

		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingOutOfMemoryException(string message)
		{
		}

		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingOverflowException(string message)
		{
		}

		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingSystemException(string message)
		{
		}

		[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
		private static void SetPendingArgumentException(string message, string paramName)
		{
		}

		[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
		private static void SetPendingArgumentNullException(string message, string paramName)
		{
		}

		[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
		private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
		{
		}

		static SWIGExceptionHelper()
		{
		}
	}

	public class SWIGPendingException
	{
		[ThreadStatic]
		private static Exception pendingException;

		private static int numExceptionsPending;

		public static bool Pending
		{
			get
			{
				return default(bool);
			}
		}

		public static void Set(Exception e)
		{
		}

		public static Exception Retrieve()
		{
			return null;
		}
	}

	protected class SWIGStringHelper
	{
		public delegate string SWIGStringDelegate(string message);

		private static SWIGStringDelegate stringDelegate;

		public static extern void SWIGRegisterStringCallback_VivoxCoreInstance(SWIGStringDelegate stringDelegate);

		[MonoPInvokeCallback(typeof(SWIGStringDelegate))]
		private static string CreateString(string cString)
		{
			return null;
		}

		static SWIGStringHelper()
		{
		}
	}

	public class SWIGLogHelper
	{
		public delegate void SWIGLogDelegate(vx_log_level severity, string source, string message);

		private static SWIGLogDelegate stringDelegate;

		public static extern void SWIGRegisterLogCallback_VivoxCoreInstance(SWIGLogDelegate stringDelegate);

		[MonoPInvokeCallback(typeof(SWIGLogDelegate))]
		private static void Vx_Log_Event(vx_log_level severity, string source, string message)
		{
		}

		static SWIGLogHelper()
		{
		}
	}

	private const string nativeLib = "VivoxNative";

	private const string dllName = "VivoxNative";

	protected static SWIGExceptionHelper swigExceptionHelper;

	protected static SWIGStringHelper swigStringHelper;

	protected static SWIGLogHelper logHelper;

	static VivoxCoreInstancePINVOKE()
	{
	}

	public static extern void vx_initialized_set(bool jarg1);

	public static extern bool vx_initialized_get();

	public static extern string APP_UNIQUE_3_LETTERS_USER_AGENT_ID_STRING_get();

	public static extern int SWIG_get();

	public static extern void vx_before_recv_audio_mixed_participant_data_t_participant_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_before_recv_audio_mixed_participant_data_t_participant_uri_get(HandleRef jarg1);

	public static extern void vx_before_recv_audio_mixed_participant_data_t_pcm_frames_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_before_recv_audio_mixed_participant_data_t_pcm_frames_get(HandleRef jarg1);

	public static extern void vx_before_recv_audio_mixed_participant_data_t_pcm_frame_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_before_recv_audio_mixed_participant_data_t_pcm_frame_count_get(HandleRef jarg1);

	public static extern void vx_before_recv_audio_mixed_participant_data_t_audio_frame_rate_set(HandleRef jarg1, int jarg2);

	public static extern int vx_before_recv_audio_mixed_participant_data_t_audio_frame_rate_get(HandleRef jarg1);

	public static extern void vx_before_recv_audio_mixed_participant_data_t_channels_per_frame_set(HandleRef jarg1, int jarg2);

	public static extern int vx_before_recv_audio_mixed_participant_data_t_channels_per_frame_get(HandleRef jarg1);

	public static extern IntPtr new_vx_before_recv_audio_mixed_participant_data_t();

	public static extern void delete_vx_before_recv_audio_mixed_participant_data_t(HandleRef jarg1);

	public static extern void vx_sdk_config_t_num_codec_threads_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_num_codec_threads_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_num_voice_threads_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_num_voice_threads_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_num_web_threads_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_num_web_threads_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_render_source_queue_depth_max_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_render_source_queue_depth_max_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_render_source_initial_buffer_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_render_source_initial_buffer_count_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_upstream_jitter_frame_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_upstream_jitter_frame_count_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_allow_shared_capture_devices_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_allow_shared_capture_devices_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_max_logins_per_user_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_max_logins_per_user_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_app_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_sdk_config_t_app_id_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_cert_data_dir_set(HandleRef jarg1, string jarg2);

	public static extern string vx_sdk_config_t_cert_data_dir_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_pf_malloc_func_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_sdk_config_t_pf_malloc_func_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_pf_free_func_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_sdk_config_t_pf_free_func_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_pf_realloc_func_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_sdk_config_t_pf_realloc_func_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_pf_calloc_func_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_sdk_config_t_pf_calloc_func_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_pf_malloc_aligned_func_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_sdk_config_t_pf_malloc_aligned_func_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_pf_free_aligned_func_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_sdk_config_t_pf_free_aligned_func_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_reserved_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_reserved_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_job_queue_handle_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_sdk_config_t_job_queue_handle_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_pf_queue_job_sync_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_sdk_config_t_pf_queue_job_sync_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_pf_queue_job_async_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_sdk_config_t_pf_queue_job_async_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_processor_affinity_mask_set(HandleRef jarg1, long jarg2);

	public static extern long vx_sdk_config_t_processor_affinity_mask_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_callback_handle_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_sdk_config_t_callback_handle_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_pf_logging_callback_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_sdk_config_t_pf_logging_callback_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_pf_sdk_message_callback_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_sdk_config_t_pf_sdk_message_callback_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_initial_log_level_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_initial_log_level_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_disable_device_polling_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_disable_device_polling_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_force_capture_silence_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_force_capture_silence_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_enable_advanced_auto_levels_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_enable_advanced_auto_levels_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_pf_on_audio_unit_started_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_sdk_config_t_pf_on_audio_unit_started_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_pf_on_audio_unit_stopped_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_sdk_config_t_pf_on_audio_unit_stopped_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_pf_on_audio_unit_after_capture_audio_read_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_sdk_config_t_pf_on_audio_unit_after_capture_audio_read_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_pf_on_audio_unit_before_capture_audio_sent_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_sdk_config_t_pf_on_audio_unit_before_capture_audio_sent_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_pf_on_audio_unit_before_recv_audio_mixed_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_sdk_config_t_pf_on_audio_unit_before_recv_audio_mixed_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_pf_on_audio_unit_before_recv_audio_rendered_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_sdk_config_t_pf_on_audio_unit_before_recv_audio_rendered_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_capture_device_buffer_size_intervals_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_capture_device_buffer_size_intervals_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_render_device_buffer_size_intervals_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_render_device_buffer_size_intervals_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_disable_audio_ducking_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_disable_audio_ducking_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_use_access_tokens_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_use_access_tokens_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_enable_multiparty_text_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_enable_multiparty_text_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_enable_dtx_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_enable_dtx_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_default_codecs_mask_set(HandleRef jarg1, uint jarg2);

	public static extern uint vx_sdk_config_t_default_codecs_mask_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_pf_on_before_udp_frame_transmitted_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_sdk_config_t_pf_on_before_udp_frame_transmitted_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_pf_on_after_udp_frame_transmitted_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_sdk_config_t_pf_on_after_udp_frame_transmitted_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_enable_fast_network_change_detection_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_enable_fast_network_change_detection_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_use_os_proxy_settings_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_use_os_proxy_settings_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_enable_persistent_http_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_enable_persistent_http_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_preferred_sip_port_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_preferred_sip_port_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_default_render_to_receiver_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_default_render_to_receiver_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_mic_makeup_gain_set(HandleRef jarg1, float jarg2);

	public static extern float vx_sdk_config_t_mic_makeup_gain_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_pf_on_thread_created_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_sdk_config_t_pf_on_thread_created_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_pf_on_thread_exit_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_sdk_config_t_pf_on_thread_exit_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_pf_request_permission_for_network_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_sdk_config_t_pf_request_permission_for_network_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_dynamic_voice_processing_switching_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_dynamic_voice_processing_switching_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_pf_on_audio_unit_capture_device_status_changed_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_sdk_config_t_pf_on_audio_unit_capture_device_status_changed_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_never_rtp_timeout_ms_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_never_rtp_timeout_ms_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_lost_rtp_timeout_ms_set(HandleRef jarg1, int jarg2);

	public static extern int vx_sdk_config_t_lost_rtp_timeout_ms_get(HandleRef jarg1);

	public static extern void vx_sdk_config_t_pf_on_assert_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_sdk_config_t_pf_on_assert_get(HandleRef jarg1);

	public static extern uint vx_sdk_config_t_configSize_get();

	public static extern IntPtr new_vx_sdk_config_t();

	public static extern void delete_vx_sdk_config_t(HandleRef jarg1);

	public static extern int VX_E_NO_MESSAGE_AVAILABLE_get();

	public static extern int VX_E_SUCCESS_get();

	public static extern int VX_E_INVALID_XML_get();

	public static extern int VX_E_NO_EXIST_get();

	public static extern int VX_E_MAX_CONNECTOR_LIMIT_EXCEEDED_get();

	public static extern int VX_E_MAX_SESSION_LIMIT_EXCEEDED_get();

	public static extern int VX_E_FAILED_get();

	public static extern int VX_E_ALREADY_LOGGED_IN_get();

	public static extern int VX_E_ALREADY_LOGGED_OUT_get();

	public static extern int VX_E_NOT_LOGGED_IN_get();

	public static extern int VX_E_INVALID_ARGUMENT_get();

	public static extern int VX_E_INVALID_USERNAME_OR_PASSWORD_get();

	public static extern int VX_E_INSUFFICIENT_PRIVILEGE_get();

	public static extern int VX_E_NO_SUCH_SESSION_get();

	public static extern int VX_E_NOT_INITIALIZED_get();

	public static extern int VX_E_REQUESTCONTEXT_NOT_FOUND_get();

	public static extern int VX_E_LOGIN_FAILED_get();

	public static extern int VX_E_SESSION_MAX_get();

	public static extern int VX_E_WRONG_CONNECTOR_get();

	public static extern int VX_E_NOT_IMPL_get();

	public static extern int VX_E_REQUEST_CANCELLED_get();

	public static extern int VX_E_INVALID_SESSION_STATE_get();

	public static extern int VX_E_SESSION_CREATE_PENDING_get();

	public static extern int VX_E_SESSION_TERMINATE_PENDING_get();

	public static extern int VX_E_SESSION_CHANNEL_TEXT_DENIED_get();

	public static extern int VX_E_SESSION_TEXT_DENIED_get();

	public static extern int VX_E_SESSION_MESSAGE_BUILD_FAILED_get();

	public static extern int VX_E_SESSION_MSG_CONTENT_TYPE_FAILED_get();

	public static extern int VX_E_SESSION_MEDIA_CONNECT_FAILED_get();

	public static extern int VX_E_SESSION_MEDIA_DISCONNECT_FAILED_get();

	public static extern int VX_E_SESSION_DOES_NOT_HAVE_TEXT_get();

	public static extern int VX_E_SESSION_DOES_NOT_HAVE_AUDIO_get();

	public static extern int VX_E_SESSION_MUST_HAVE_MEDIA_get();

	public static extern int VX_E_SESSION_IS_NOT_3D_get();

	public static extern int VX_E_SESSIONGROUP_NOT_FOUND_get();

	public static extern int VX_E_REQUEST_TYPE_NOT_SUPPORTED_get();

	public static extern int VX_E_REQUEST_NOT_SUPPORTED_get();

	public static extern int VX_E_MULTI_CHANNEL_DENIED_get();

	public static extern int VX_E_MEDIA_DISCONNECT_NOT_ALLOWED_get();

	public static extern int VX_E_PRELOGIN_INFO_NOT_RETURNED_get();

	public static extern int VX_E_SUBSCRIPTION_NOT_FOUND_get();

	public static extern int VX_E_INVALID_SUBSCRIPTION_RULE_TYPE_get();

	public static extern int VX_E_INVALID_MASK_get();

	public static extern int VX_E_INVALID_CONNECTOR_STATE_get();

	public static extern int VX_E_BUFSIZE_get();

	public static extern int VX_E_FILE_OPEN_FAILED_get();

	public static extern int VX_E_FILE_CORRUPT_get();

	public static extern int VX_E_FILE_WRITE_FAILED_get();

	public static extern int VX_E_INVALID_FILE_OPERATION_get();

	public static extern int VX_E_NO_MORE_FRAMES_get();

	public static extern int VX_E_UNEXPECTED_END_OF_FILE_get();

	public static extern int VX_E_FILE_WRITE_FAILED_REACHED_MAX_FILESIZE_get();

	public static extern int VX_E_TERMINATESESSION_NOT_VALID_get();

	public static extern int VX_E_MAX_PLAYBACK_SESSIONGROUPS_EXCEEDED_get();

	public static extern int VX_E_TEXT_DISCONNECT_NOT_ALLOWED_get();

	public static extern int VX_E_TEXT_CONNECT_NOT_ALLOWED_get();

	public static extern int VX_E_SESSION_TEXT_DISABLED_get();

	public static extern int VX_E_SESSIONGROUP_TRANSMIT_NOT_ALLOWED_get();

	public static extern int VX_E_CALL_CREATION_FAILED_get();

	public static extern int VX_E_RTP_TIMEOUT_get();

	public static extern int VX_E_ACCOUNT_MISCONFIGURED_get();

	public static extern int VX_E_MAXIMUM_NUMBER_OF_CALLS_EXCEEEDED_get();

	public static extern int VX_E_NO_SESSION_PORTS_AVAILABLE_get();

	public static extern int VX_E_INVALID_MEDIA_FORMAT_get();

	public static extern int VX_E_INVALID_CODEC_TYPE_get();

	public static extern int VX_E_RENDER_DEVICE_DOES_NOT_EXIST_get();

	public static extern int VX_E_RENDER_CONTEXT_DOES_NOT_EXIST_get();

	public static extern int VX_E_RENDER_SOURCE_DOES_NOT_EXIST_get();

	public static extern int VX_E_RECORDING_ALREADY_ACTIVE_get();

	public static extern int VX_E_RECORDING_LOOP_BUFFER_EMPTY_get();

	public static extern int VX_E_STREAM_READ_FAILED_get();

	public static extern int VX_E_INVALID_SDK_HANDLE_get();

	public static extern int VX_E_FAILED_TO_CONNECT_TO_VOICE_SERVICE_get();

	public static extern int VX_E_FAILED_TO_SEND_REQUEST_TO_VOICE_SERVICE_get();

	public static extern int VX_E_MAX_LOGINS_PER_USER_EXCEEDED_get();

	public static extern int VX_E_MAX_HTTP_DATA_RESPONSE_SIZE_EXCEEDED_get();

	public static extern int VX_E_CHANNEL_URI_REQUIRED_get();

	public static extern int VX_E_INVALID_CAPTURE_DEVICE_FOR_REQUESTED_OPERATION_get();

	public static extern int VX_E_LOOP_MODE_RECORDING_NOT_ENABLED_get();

	public static extern int VX_E_TEXT_DISABLED_get();

	public static extern int VX_E_VOICE_FONT_NOT_FOUND_get();

	public static extern int VX_E_CROSS_DOMAIN_LOGINS_DISABLED_get();

	public static extern int VX_E_INVALID_AUTH_TOKEN_get();

	public static extern int VX_E_INVALID_APP_TOKEN_get();

	public static extern int VX_E_CAPACITY_EXCEEDED_get();

	public static extern int VX_E_ALREADY_INITIALIZED_get();

	public static extern int VX_E_NOT_UNINITIALIZED_YET_get();

	public static extern int VX_E_NETWORK_ADDRESS_CHANGE_get();

	public static extern int VX_E_NETWORK_DOWN_get();

	public static extern int VX_E_POWER_STATE_CHANGE_get();

	public static extern int VX_E_HANDLE_ALREADY_TAKEN_get();

	public static extern int VX_E_HANDLE_IS_RESERVED_get();

	public static extern int VX_E_NO_XLSP_CONFIGURED_get();

	public static extern int VX_E_XNETCONNECT_FAILED_get();

	public static extern int VX_E_REQUEST_CANCELED_get();

	public static extern int VX_E_CALL_TERMINATED_NO_RTP_RXED_get();

	public static extern int VX_E_CALL_TERMINATED_NO_ANSWER_LOCAL_get();

	public static extern int VX_E_CHANNEL_URI_TOO_LONG_get();

	public static extern int VX_E_CALL_TERMINATED_BAN_get();

	public static extern int VX_E_CALL_TERMINATED_KICK_get();

	public static extern int VX_E_CALL_TERMINATED_BY_SERVER_get();

	public static extern int VX_E_ALREADY_EXIST_get();

	public static extern int VX_E_FEATURE_DISABLED_get();

	public static extern int VX_E_SIZE_LIMIT_EXCEEDED_get();

	public static extern int VX_E_RTP_SESSION_SOCKET_ERROR_get();

	public static extern int VX_E_SIP_BACKEND_REQUIRED_get();

	public static extern int VX_E_DEPRECATED_get();

	public static extern int VX_E_NO_RENDER_DEVICES_FOUND_get();

	public static extern int VX_E_NO_CAPTURE_DEVICES_FOUND_get();

	public static extern int VX_E_INVALID_RENDER_DEVICE_SPECIFIER_get();

	public static extern int VX_E_RENDER_DEVICE_IN_USE_get();

	public static extern int VX_E_INVALID_CAPTURE_DEVICE_SPECIFIER_get();

	public static extern int VX_E_CAPTURE_DEVICE_IN_USE_get();

	public static extern int VX_E_UNABLE_TO_OPEN_CAPTURE_DEVICE_get();

	public static extern int VX_E_FAILED_TO_CONNECT_TO_SERVER_get();

	public static extern int VX_E_ACCESSTOKEN_ALREADY_USED_get();

	public static extern int VX_E_ACCESSTOKEN_EXPIRED_get();

	public static extern int VX_E_ACCESSTOKEN_INVALID_SIGNATURE_get();

	public static extern int VX_E_ACCESSTOKEN_CLAIMS_MISMATCH_get();

	public static extern int VX_E_ACCESSTOKEN_MALFORMED_get();

	public static extern int VX_E_ACCESSTOKEN_INTERNAL_ERROR_get();

	public static extern int VX_E_ACCESSTOKEN_SERVICE_UNAVAILABLE_get();

	public static extern int VX_E_ACCESSTOKEN_ISSUER_MISMATCH_get();

	public static extern int VxErrorNoMessageAvailable_get();

	public static extern int VxErrorSuccess_get();

	public static extern int VxErrorAsyncOperationCanceled_get();

	public static extern int VxErrorCaptureDeviceInUse_get();

	public static extern int VxErrorConnectionTerminated_get();

	public static extern int VxErrorFileOpenFailed_get();

	public static extern int VxErrorHandleReserved_get();

	public static extern int VxErrorHandleTaken_get();

	public static extern int VxErrorInternalError_get();

	public static extern int VxErrorInvalidArgument_get();

	public static extern int VxErrorInvalidFormat_get();

	public static extern int VxErrorInvalidOperation_get();

	public static extern int VxErrorInvalidState_get();

	public static extern int VxErrorInvalidValueTypeXmlQuery_get();

	public static extern int VxErrorNoMatchingXmlAttributeFound_get();

	public static extern int VxErrorNoMatchingXmlNodeFound_get();

	public static extern int VxErrorNoMemory_get();

	public static extern int VxErrorNoMoreData_get();

	public static extern int VxErrorNoXLSPConfigured_get();

	public static extern int VxErrorNotSupported_get();

	public static extern int VxErrorPortNotAvailable_get();

	public static extern int VxErrorRtpTimeout_get();

	public static extern int VxErrorUnableToOpenCaptureDevice_get();

	public static extern int VxErrorXLSPConnectFailed_get();

	public static extern int VxErrorXmppBackEndRequired_get();

	public static extern int VxErrorPreloginDownloadFailed_get();

	public static extern int VxErrorNotLoggedIn_get();

	public static extern int VxErrorPresenceMustBeEnabled_get();

	public static extern int VxErrorConnectorLimitExceeded_get();

	public static extern int VxErrorTargetObjectNotRelated_get();

	public static extern int VxErrorTargetObjectDoesNotExist_get();

	public static extern int VxErrorMaxLoginsPerUserExceeded_get();

	public static extern int VxErrorRequestCanceled_get();

	public static extern int VxErrorBuddyDoesNotExist_get();

	public static extern int VxErrorChannelUriRequired_get();

	public static extern int VxErrorTargetObjectAlreadyExists_get();

	public static extern int VxErrorInvalidCaptureDeviceForRequestedOperation_get();

	public static extern int VxErrorInvalidCaptureDeviceSpecifier_get();

	public static extern int VxErrorInvalidRenderDeviceSpecifier_get();

	public static extern int VxErrorDeviceLimitReached_get();

	public static extern int VxErrorInvalidEventType_get();

	public static extern int VxErrorNotInitialized_get();

	public static extern int VxErrorAlreadyInitialized_get();

	public static extern int VxErrorNotImplemented_get();

	public static extern int VxErrorTimeout_get();

	public static extern int VxNoAuthenticationStanzaReceived_get();

	public static extern int VxFailedToConnectToXmppServer_get();

	public static extern int VxSSLNegotiationToXmppServerFailed_get();

	public static extern int VxErrorUserOffLineOrDoesNotExist_get();

	public static extern int VxErrorCaptureDeviceInvalidated_get();

	public static extern int VxErrorMaxEtherChannelLimitReached_get();

	public static extern int VxErrorHostUnknown_get();

	public static extern int VxErrorChannelUriTooLong_get();

	public static extern int VxErrorUserUriTooLong_get();

	public static extern int VxErrorInvalidChannelUri_get();

	public static extern int VxErrorCrossDomainLoginDisabled_get();

	public static extern int VxErrorSipRegistrationAuthorizationFailure_get();

	public static extern int VxErrorUserAlreadyLoggingOut_get();

	public static extern int VxErrorBuddyGroupDoesNotExist_get();

	public static extern int VxErrorPowerEvent_get();

	public static extern int VxErrorNetworkAddressChanged_get();

	public static extern int VxErrorNetworkDown_get();

	public static extern int VxErrorNotUninitializedYet_get();

	public static extern int VxErrorCallTerminatedBanned_get();

	public static extern int VxErrorCallTerminatedKick_get();

	public static extern int VxErrorCallTerminatedByServer_get();

	public static extern int VxErrorServerRtpTimeout_get();

	public static extern int VxErrorDeprecated_get();

	public static extern int VxErrorUserBlocked_get();

	public static extern int VxErrorMessageTextTooLong_get();

	public static extern int VxErrorNoMicrophonePermission_get();

	public static extern int VxXmppErrorCodesRangeStart_get();

	public static extern int VxUnknownXmppError_get();

	public static extern int VxAccessTokenAlreadyUsed_get();

	public static extern int VxAccessTokenExpired_get();

	public static extern int VxAccessTokenInvalidSignature_get();

	public static extern int VxAccessTokenClaimsMismatch_get();

	public static extern int VxAccessTokenMalformed_get();

	public static extern int VxAccessTokenInternalError_get();

	public static extern int VxAccessTokenServiceUnavailable_get();

	public static extern int VxAccessTokenIssuerMismatch_get();

	public static extern int VxXmppErrorBadRequest_get();

	public static extern int VxXmppInternalServerError_get();

	public static extern int VxXmppServerErrorServiceUnavailable_get();

	public static extern int VxXmppErrorServiceUnavailable_get();

	public static extern int VxXmppErrorCodesRangeEnd_get();

	public static extern int VxErrorXmppServerResponseMalformed_get();

	public static extern int VxErrorXmppServerResponseBadSdp_get();

	public static extern int VxErrorXmppServerResponseInviteMissing_get();

	public static extern int VxErrorXmppServerResponseChanAddMissing_get();

	public static extern int VxNetworkNameResolutionFailed_get();

	public static extern int VxNetworkUnableToConnectToServer_get();

	public static extern int VxNetworkHttpTimeout_get();

	public static extern int VxNetworkHttpInvalidUrl_get();

	public static extern int VxNetworkHttpInvalidCertificate_get();

	public static extern int VxNetworkHttpConnectionReset_get();

	public static extern int VxNetworkHttpInvalidServerResponse_get();

	public static extern int VxNetworkHttpGeneralConnectionFailure_get();

	public static extern int VxNetworkReconnectFailure_get();

	public static extern int VX_E_XMPP_BACKEND_REQUIRED_get();

	public static extern int VxErrorSipBackEndRequired_get();

	public static extern string vx_get_error_string(int jarg1);

	public static extern string vx_get_request_type_string(int jarg1);

	public static extern string vx_get_response_type_string(int jarg1);

	public static extern string vx_get_event_type_string(int jarg1);

	public static extern string vx_get_login_state_string(int jarg1);

	public static extern string vx_get_presence_state_string(int jarg1);

	public static extern string vx_get_notification_type_string(int jarg1);

	public static extern string vx_get_session_media_state_string(int jarg1);

	public static extern string vx_get_session_text_state_string(int jarg1);

	public static extern string vx_get_media_completion_type_string(int jarg1);

	public static extern string vx_get_audio_device_hot_swap_type_string(int jarg1);

	public static extern string vx_get_participant_removed_reason_string(int jarg1);

	public static extern string vx_get_tts_dest_string(int jarg1);

	public static extern string vx_get_log_level_string(int jarg1);

	public static extern void vx_evt_account_login_state_change_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_account_login_state_change_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_account_login_state_change_t_state_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_account_login_state_change_t_state_get(HandleRef jarg1);

	public static extern void vx_evt_account_login_state_change_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_account_login_state_change_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_evt_account_login_state_change_t_status_code_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_account_login_state_change_t_status_code_get(HandleRef jarg1);

	public static extern void vx_evt_account_login_state_change_t_status_string_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_account_login_state_change_t_status_string_get(HandleRef jarg1);

	public static extern void vx_evt_account_login_state_change_t_cookie_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_account_login_state_change_t_cookie_get(HandleRef jarg1);

	public static extern void vx_evt_account_login_state_change_t_vcookie_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_account_login_state_change_t_vcookie_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_account_login_state_change_t();

	public static extern void delete_vx_evt_account_login_state_change_t(HandleRef jarg1);

	public static extern void vx_evt_buddy_presence_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_buddy_presence_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_buddy_presence_t_state_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_buddy_presence_t_state_get(HandleRef jarg1);

	public static extern void vx_evt_buddy_presence_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_buddy_presence_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_evt_buddy_presence_t_buddy_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_buddy_presence_t_buddy_uri_get(HandleRef jarg1);

	public static extern void vx_evt_buddy_presence_t_presence_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_buddy_presence_t_presence_get(HandleRef jarg1);

	public static extern void vx_evt_buddy_presence_t_custom_message_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_buddy_presence_t_custom_message_get(HandleRef jarg1);

	public static extern void vx_evt_buddy_presence_t_displayname_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_buddy_presence_t_displayname_get(HandleRef jarg1);

	public static extern void vx_evt_buddy_presence_t_application_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_buddy_presence_t_application_get(HandleRef jarg1);

	public static extern void vx_evt_buddy_presence_t_contact_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_buddy_presence_t_contact_get(HandleRef jarg1);

	public static extern void vx_evt_buddy_presence_t_priority_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_buddy_presence_t_priority_get(HandleRef jarg1);

	public static extern void vx_evt_buddy_presence_t_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_buddy_presence_t_id_get(HandleRef jarg1);

	public static extern void vx_evt_buddy_presence_t_encoded_uri_with_tag_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_buddy_presence_t_encoded_uri_with_tag_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_buddy_presence_t();

	public static extern void delete_vx_evt_buddy_presence_t(HandleRef jarg1);

	public static extern void vx_evt_subscription_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_subscription_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_subscription_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_subscription_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_evt_subscription_t_buddy_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_subscription_t_buddy_uri_get(HandleRef jarg1);

	public static extern void vx_evt_subscription_t_subscription_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_subscription_t_subscription_handle_get(HandleRef jarg1);

	public static extern void vx_evt_subscription_t_subscription_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_subscription_t_subscription_type_get(HandleRef jarg1);

	public static extern void vx_evt_subscription_t_displayname_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_subscription_t_displayname_get(HandleRef jarg1);

	public static extern void vx_evt_subscription_t_application_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_subscription_t_application_get(HandleRef jarg1);

	public static extern void vx_evt_subscription_t_message_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_subscription_t_message_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_subscription_t();

	public static extern void delete_vx_evt_subscription_t(HandleRef jarg1);

	public static extern void vx_evt_session_notification_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_session_notification_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_session_notification_t_state_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_session_notification_t_state_get(HandleRef jarg1);

	public static extern void vx_evt_session_notification_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_notification_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_evt_session_notification_t_participant_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_notification_t_participant_uri_get(HandleRef jarg1);

	public static extern void vx_evt_session_notification_t_notification_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_session_notification_t_notification_type_get(HandleRef jarg1);

	public static extern void vx_evt_session_notification_t_encoded_uri_with_tag_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_notification_t_encoded_uri_with_tag_get(HandleRef jarg1);

	public static extern void vx_evt_session_notification_t_is_current_user_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_session_notification_t_is_current_user_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_session_notification_t();

	public static extern void delete_vx_evt_session_notification_t(HandleRef jarg1);

	public static extern void vx_evt_message_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_message_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_message_t_state_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_message_t_state_get(HandleRef jarg1);

	public static extern void vx_evt_message_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_message_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_evt_message_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_message_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_evt_message_t_participant_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_message_t_participant_uri_get(HandleRef jarg1);

	public static extern void vx_evt_message_t_message_header_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_message_t_message_header_get(HandleRef jarg1);

	public static extern void vx_evt_message_t_message_body_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_message_t_message_body_get(HandleRef jarg1);

	public static extern void vx_evt_message_t_participant_displayname_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_message_t_participant_displayname_get(HandleRef jarg1);

	public static extern void vx_evt_message_t_application_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_message_t_application_get(HandleRef jarg1);

	public static extern void vx_evt_message_t_alias_username_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_message_t_alias_username_get(HandleRef jarg1);

	public static extern void vx_evt_message_t_encoded_uri_with_tag_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_message_t_encoded_uri_with_tag_get(HandleRef jarg1);

	public static extern void vx_evt_message_t_is_current_user_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_message_t_is_current_user_get(HandleRef jarg1);

	public static extern void vx_evt_message_t_language_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_message_t_language_get(HandleRef jarg1);

	public static extern void vx_evt_message_t_application_stanza_namespace_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_message_t_application_stanza_namespace_get(HandleRef jarg1);

	public static extern void vx_evt_message_t_application_stanza_body_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_message_t_application_stanza_body_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_message_t();

	public static extern void delete_vx_evt_message_t(HandleRef jarg1);

	public static extern void vx_evt_session_archive_message_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_session_archive_message_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_session_archive_message_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_archive_message_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_evt_session_archive_message_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_archive_message_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_evt_session_archive_message_t_query_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_archive_message_t_query_id_get(HandleRef jarg1);

	public static extern void vx_evt_session_archive_message_t_time_stamp_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_archive_message_t_time_stamp_get(HandleRef jarg1);

	public static extern void vx_evt_session_archive_message_t_participant_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_archive_message_t_participant_uri_get(HandleRef jarg1);

	public static extern void vx_evt_session_archive_message_t_message_body_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_archive_message_t_message_body_get(HandleRef jarg1);

	public static extern void vx_evt_session_archive_message_t_message_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_archive_message_t_message_id_get(HandleRef jarg1);

	public static extern void vx_evt_session_archive_message_t_encoded_uri_with_tag_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_archive_message_t_encoded_uri_with_tag_get(HandleRef jarg1);

	public static extern void vx_evt_session_archive_message_t_is_current_user_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_session_archive_message_t_is_current_user_get(HandleRef jarg1);

	public static extern void vx_evt_session_archive_message_t_language_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_archive_message_t_language_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_session_archive_message_t();

	public static extern void delete_vx_evt_session_archive_message_t(HandleRef jarg1);

	public static extern void vx_evt_transcribed_message_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_transcribed_message_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_transcribed_message_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_transcribed_message_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_evt_transcribed_message_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_transcribed_message_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_evt_transcribed_message_t_participant_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_transcribed_message_t_participant_uri_get(HandleRef jarg1);

	public static extern void vx_evt_transcribed_message_t_text_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_transcribed_message_t_text_get(HandleRef jarg1);

	public static extern void vx_evt_transcribed_message_t_language_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_transcribed_message_t_language_get(HandleRef jarg1);

	public static extern void vx_evt_transcribed_message_t_is_current_user_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_transcribed_message_t_is_current_user_get(HandleRef jarg1);

	public static extern void vx_evt_transcribed_message_t_participant_displayname_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_transcribed_message_t_participant_displayname_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_transcribed_message_t();

	public static extern void delete_vx_evt_transcribed_message_t(HandleRef jarg1);

	public static extern void vx_evt_session_archive_query_end_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_session_archive_query_end_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_session_archive_query_end_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_archive_query_end_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_evt_session_archive_query_end_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_archive_query_end_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_evt_session_archive_query_end_t_query_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_archive_query_end_t_query_id_get(HandleRef jarg1);

	public static extern void vx_evt_session_archive_query_end_t_return_code_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_session_archive_query_end_t_return_code_get(HandleRef jarg1);

	public static extern void vx_evt_session_archive_query_end_t_status_code_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_session_archive_query_end_t_status_code_get(HandleRef jarg1);

	public static extern void vx_evt_session_archive_query_end_t_first_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_archive_query_end_t_first_id_get(HandleRef jarg1);

	public static extern void vx_evt_session_archive_query_end_t_last_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_archive_query_end_t_last_id_get(HandleRef jarg1);

	public static extern void vx_evt_session_archive_query_end_t_first_index_set(HandleRef jarg1, uint jarg2);

	public static extern uint vx_evt_session_archive_query_end_t_first_index_get(HandleRef jarg1);

	public static extern void vx_evt_session_archive_query_end_t_count_set(HandleRef jarg1, uint jarg2);

	public static extern uint vx_evt_session_archive_query_end_t_count_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_session_archive_query_end_t();

	public static extern void delete_vx_evt_session_archive_query_end_t(HandleRef jarg1);

	public static extern void vx_evt_aux_audio_properties_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_aux_audio_properties_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_aux_audio_properties_t_state_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_aux_audio_properties_t_state_get(HandleRef jarg1);

	public static extern void vx_evt_aux_audio_properties_t_mic_is_active_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_aux_audio_properties_t_mic_is_active_get(HandleRef jarg1);

	public static extern void vx_evt_aux_audio_properties_t_mic_volume_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_aux_audio_properties_t_mic_volume_get(HandleRef jarg1);

	public static extern void vx_evt_aux_audio_properties_t_mic_energy_set(HandleRef jarg1, double jarg2);

	public static extern double vx_evt_aux_audio_properties_t_mic_energy_get(HandleRef jarg1);

	public static extern void vx_evt_aux_audio_properties_t_speaker_volume_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_aux_audio_properties_t_speaker_volume_get(HandleRef jarg1);

	public static extern void vx_evt_aux_audio_properties_t_speaker_energy_set(HandleRef jarg1, double jarg2);

	public static extern double vx_evt_aux_audio_properties_t_speaker_energy_get(HandleRef jarg1);

	public static extern void vx_evt_aux_audio_properties_t_speaker_is_active_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_aux_audio_properties_t_speaker_is_active_get(HandleRef jarg1);

	public static extern void vx_evt_aux_audio_properties_t_fast_energy_meter_set(HandleRef jarg1, double jarg2);

	public static extern double vx_evt_aux_audio_properties_t_fast_energy_meter_get(HandleRef jarg1);

	public static extern void vx_evt_aux_audio_properties_t_noise_floor_meter_set(HandleRef jarg1, double jarg2);

	public static extern double vx_evt_aux_audio_properties_t_noise_floor_meter_get(HandleRef jarg1);

	public static extern void vx_evt_aux_audio_properties_t_speech_threshold_meter_set(HandleRef jarg1, double jarg2);

	public static extern double vx_evt_aux_audio_properties_t_speech_threshold_meter_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_aux_audio_properties_t();

	public static extern void delete_vx_evt_aux_audio_properties_t(HandleRef jarg1);

	public static extern void vx_evt_buddy_changed_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_buddy_changed_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_buddy_changed_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_buddy_changed_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_evt_buddy_changed_t_change_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_buddy_changed_t_change_type_get(HandleRef jarg1);

	public static extern void vx_evt_buddy_changed_t_buddy_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_buddy_changed_t_buddy_uri_get(HandleRef jarg1);

	public static extern void vx_evt_buddy_changed_t_display_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_buddy_changed_t_display_name_get(HandleRef jarg1);

	public static extern void vx_evt_buddy_changed_t_buddy_data_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_buddy_changed_t_buddy_data_get(HandleRef jarg1);

	public static extern void vx_evt_buddy_changed_t_group_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_buddy_changed_t_group_id_get(HandleRef jarg1);

	public static extern void vx_evt_buddy_changed_t_account_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_buddy_changed_t_account_id_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_buddy_changed_t();

	public static extern void delete_vx_evt_buddy_changed_t(HandleRef jarg1);

	public static extern void vx_evt_buddy_group_changed_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_buddy_group_changed_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_buddy_group_changed_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_buddy_group_changed_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_evt_buddy_group_changed_t_change_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_buddy_group_changed_t_change_type_get(HandleRef jarg1);

	public static extern void vx_evt_buddy_group_changed_t_group_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_buddy_group_changed_t_group_id_get(HandleRef jarg1);

	public static extern void vx_evt_buddy_group_changed_t_group_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_buddy_group_changed_t_group_name_get(HandleRef jarg1);

	public static extern void vx_evt_buddy_group_changed_t_group_data_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_buddy_group_changed_t_group_data_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_buddy_group_changed_t();

	public static extern void delete_vx_evt_buddy_group_changed_t(HandleRef jarg1);

	public static extern void vx_evt_buddy_and_group_list_changed_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_buddy_and_group_list_changed_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_buddy_and_group_list_changed_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_buddy_and_group_list_changed_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_evt_buddy_and_group_list_changed_t_buddy_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_buddy_and_group_list_changed_t_buddy_count_get(HandleRef jarg1);

	public static extern void vx_evt_buddy_and_group_list_changed_t_buddies_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_buddy_and_group_list_changed_t_buddies_get(HandleRef jarg1);

	public static extern void vx_evt_buddy_and_group_list_changed_t_group_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_buddy_and_group_list_changed_t_group_count_get(HandleRef jarg1);

	public static extern void vx_evt_buddy_and_group_list_changed_t_groups_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_buddy_and_group_list_changed_t_groups_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_buddy_and_group_list_changed_t();

	public static extern void delete_vx_evt_buddy_and_group_list_changed_t(HandleRef jarg1);

	public static extern void vx_evt_keyboard_mouse_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_keyboard_mouse_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_keyboard_mouse_t_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_keyboard_mouse_t_name_get(HandleRef jarg1);

	public static extern void vx_evt_keyboard_mouse_t_is_down_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_keyboard_mouse_t_is_down_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_keyboard_mouse_t();

	public static extern void delete_vx_evt_keyboard_mouse_t(HandleRef jarg1);

	public static extern void vx_evt_idle_state_changed_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_idle_state_changed_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_idle_state_changed_t_is_idle_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_idle_state_changed_t_is_idle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_idle_state_changed_t();

	public static extern void delete_vx_evt_idle_state_changed_t(HandleRef jarg1);

	public static extern void vx_call_stats_t_insufficient_bandwidth_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_insufficient_bandwidth_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_min_bars_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_min_bars_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_max_bars_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_max_bars_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_current_bars_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_current_bars_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_pk_loss_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_pk_loss_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_incoming_received_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_incoming_received_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_incoming_expected_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_incoming_expected_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_incoming_packetloss_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_incoming_packetloss_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_incoming_out_of_time_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_incoming_out_of_time_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_incoming_discarded_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_incoming_discarded_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_outgoing_sent_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_outgoing_sent_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_render_device_underruns_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_render_device_underruns_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_render_device_overruns_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_render_device_overruns_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_render_device_errors_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_render_device_errors_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_call_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_call_stats_t_call_id_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_plc_on_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_plc_on_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_plc_synthetic_frames_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_plc_synthetic_frames_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_codec_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_call_stats_t_codec_name_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_codec_mode_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_codec_mode_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_min_latency_set(HandleRef jarg1, double jarg2);

	public static extern double vx_call_stats_t_min_latency_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_max_latency_set(HandleRef jarg1, double jarg2);

	public static extern double vx_call_stats_t_max_latency_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_latency_measurement_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_latency_measurement_count_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_latency_sum_set(HandleRef jarg1, double jarg2);

	public static extern double vx_call_stats_t_latency_sum_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_last_latency_measured_set(HandleRef jarg1, double jarg2);

	public static extern double vx_call_stats_t_last_latency_measured_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_latency_packets_lost_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_latency_packets_lost_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_r_factor_set(HandleRef jarg1, double jarg2);

	public static extern double vx_call_stats_t_r_factor_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_latency_packets_sent_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_latency_packets_sent_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_latency_packets_dropped_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_latency_packets_dropped_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_latency_packets_malformed_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_latency_packets_malformed_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_latency_packets_negative_latency_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_latency_packets_negative_latency_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_sample_interval_begin_set(HandleRef jarg1, double jarg2);

	public static extern double vx_call_stats_t_sample_interval_begin_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_sample_interval_end_set(HandleRef jarg1, double jarg2);

	public static extern double vx_call_stats_t_sample_interval_end_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_capture_device_consecutively_read_count_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_call_stats_t_capture_device_consecutively_read_count_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_current_opus_bit_rate_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_current_opus_bit_rate_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_current_opus_complexity_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_current_opus_complexity_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_current_opus_vbr_mode_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_current_opus_vbr_mode_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_current_opus_bandwidth_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_current_opus_bandwidth_get(HandleRef jarg1);

	public static extern void vx_call_stats_t_current_opus_max_packet_size_set(HandleRef jarg1, int jarg2);

	public static extern int vx_call_stats_t_current_opus_max_packet_size_get(HandleRef jarg1);

	public static extern IntPtr new_vx_call_stats_t();

	public static extern void delete_vx_call_stats_t(HandleRef jarg1);

	public static extern void vx_evt_media_stream_updated_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_media_stream_updated_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_media_stream_updated_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_media_stream_updated_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_evt_media_stream_updated_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_media_stream_updated_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_evt_media_stream_updated_t_status_code_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_media_stream_updated_t_status_code_get(HandleRef jarg1);

	public static extern void vx_evt_media_stream_updated_t_status_string_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_media_stream_updated_t_status_string_get(HandleRef jarg1);

	public static extern void vx_evt_media_stream_updated_t_state_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_media_stream_updated_t_state_get(HandleRef jarg1);

	public static extern void vx_evt_media_stream_updated_t_incoming_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_media_stream_updated_t_incoming_get(HandleRef jarg1);

	public static extern void vx_evt_media_stream_updated_t_durable_media_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_media_stream_updated_t_durable_media_id_get(HandleRef jarg1);

	public static extern void vx_evt_media_stream_updated_t_media_probe_server_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_media_stream_updated_t_media_probe_server_get(HandleRef jarg1);

	public static extern void vx_evt_media_stream_updated_t_call_stats_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_media_stream_updated_t_call_stats_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_media_stream_updated_t();

	public static extern void delete_vx_evt_media_stream_updated_t(HandleRef jarg1);

	public static extern void vx_evt_text_stream_updated_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_text_stream_updated_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_text_stream_updated_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_text_stream_updated_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_evt_text_stream_updated_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_text_stream_updated_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_evt_text_stream_updated_t_enabled_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_text_stream_updated_t_enabled_get(HandleRef jarg1);

	public static extern void vx_evt_text_stream_updated_t_state_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_text_stream_updated_t_state_get(HandleRef jarg1);

	public static extern void vx_evt_text_stream_updated_t_incoming_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_text_stream_updated_t_incoming_get(HandleRef jarg1);

	public static extern void vx_evt_text_stream_updated_t_status_code_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_text_stream_updated_t_status_code_get(HandleRef jarg1);

	public static extern void vx_evt_text_stream_updated_t_status_string_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_text_stream_updated_t_status_string_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_text_stream_updated_t();

	public static extern void delete_vx_evt_text_stream_updated_t(HandleRef jarg1);

	public static extern void vx_evt_sessiongroup_added_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_sessiongroup_added_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_sessiongroup_added_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_sessiongroup_added_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_evt_sessiongroup_added_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_sessiongroup_added_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_evt_sessiongroup_added_t_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_sessiongroup_added_t_type_get(HandleRef jarg1);

	public static extern void vx_evt_sessiongroup_added_t_alias_username_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_sessiongroup_added_t_alias_username_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_sessiongroup_added_t();

	public static extern void delete_vx_evt_sessiongroup_added_t(HandleRef jarg1);

	public static extern void vx_evt_sessiongroup_removed_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_sessiongroup_removed_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_sessiongroup_removed_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_sessiongroup_removed_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_sessiongroup_removed_t();

	public static extern void delete_vx_evt_sessiongroup_removed_t(HandleRef jarg1);

	public static extern void vx_evt_session_added_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_session_added_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_session_added_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_added_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_evt_session_added_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_added_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_evt_session_added_t_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_added_t_uri_get(HandleRef jarg1);

	public static extern void vx_evt_session_added_t_is_channel_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_session_added_t_is_channel_get(HandleRef jarg1);

	public static extern void vx_evt_session_added_t_incoming_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_session_added_t_incoming_get(HandleRef jarg1);

	public static extern void vx_evt_session_added_t_channel_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_added_t_channel_name_get(HandleRef jarg1);

	public static extern void vx_evt_session_added_t_displayname_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_added_t_displayname_get(HandleRef jarg1);

	public static extern void vx_evt_session_added_t_application_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_added_t_application_get(HandleRef jarg1);

	public static extern void vx_evt_session_added_t_alias_username_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_added_t_alias_username_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_session_added_t();

	public static extern void delete_vx_evt_session_added_t(HandleRef jarg1);

	public static extern void vx_evt_session_removed_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_session_removed_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_session_removed_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_removed_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_evt_session_removed_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_removed_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_evt_session_removed_t_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_removed_t_uri_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_session_removed_t();

	public static extern void delete_vx_evt_session_removed_t(HandleRef jarg1);

	public static extern void vx_evt_participant_added_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_participant_added_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_participant_added_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_participant_added_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_evt_participant_added_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_participant_added_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_evt_participant_added_t_participant_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_participant_added_t_participant_uri_get(HandleRef jarg1);

	public static extern void vx_evt_participant_added_t_account_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_participant_added_t_account_name_get(HandleRef jarg1);

	public static extern void vx_evt_participant_added_t_display_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_participant_added_t_display_name_get(HandleRef jarg1);

	public static extern void vx_evt_participant_added_t_participant_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_participant_added_t_participant_type_get(HandleRef jarg1);

	public static extern void vx_evt_participant_added_t_application_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_participant_added_t_application_get(HandleRef jarg1);

	public static extern void vx_evt_participant_added_t_is_anonymous_login_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_participant_added_t_is_anonymous_login_get(HandleRef jarg1);

	public static extern void vx_evt_participant_added_t_displayname_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_participant_added_t_displayname_get(HandleRef jarg1);

	public static extern void vx_evt_participant_added_t_alias_username_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_participant_added_t_alias_username_get(HandleRef jarg1);

	public static extern void vx_evt_participant_added_t_encoded_uri_with_tag_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_participant_added_t_encoded_uri_with_tag_get(HandleRef jarg1);

	public static extern void vx_evt_participant_added_t_is_current_user_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_participant_added_t_is_current_user_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_participant_added_t();

	public static extern void delete_vx_evt_participant_added_t(HandleRef jarg1);

	public static extern void vx_evt_participant_removed_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_participant_removed_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_participant_removed_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_participant_removed_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_evt_participant_removed_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_participant_removed_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_evt_participant_removed_t_participant_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_participant_removed_t_participant_uri_get(HandleRef jarg1);

	public static extern void vx_evt_participant_removed_t_account_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_participant_removed_t_account_name_get(HandleRef jarg1);

	public static extern void vx_evt_participant_removed_t_reason_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_participant_removed_t_reason_get(HandleRef jarg1);

	public static extern void vx_evt_participant_removed_t_alias_username_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_participant_removed_t_alias_username_get(HandleRef jarg1);

	public static extern void vx_evt_participant_removed_t_encoded_uri_with_tag_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_participant_removed_t_encoded_uri_with_tag_get(HandleRef jarg1);

	public static extern void vx_evt_participant_removed_t_is_current_user_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_participant_removed_t_is_current_user_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_participant_removed_t();

	public static extern void delete_vx_evt_participant_removed_t(HandleRef jarg1);

	public static extern void vx_evt_participant_updated_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_participant_updated_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_participant_updated_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_participant_updated_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_evt_participant_updated_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_participant_updated_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_evt_participant_updated_t_participant_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_participant_updated_t_participant_uri_get(HandleRef jarg1);

	public static extern void vx_evt_participant_updated_t_is_moderator_muted_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_participant_updated_t_is_moderator_muted_get(HandleRef jarg1);

	public static extern void vx_evt_participant_updated_t_is_speaking_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_participant_updated_t_is_speaking_get(HandleRef jarg1);

	public static extern void vx_evt_participant_updated_t_volume_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_participant_updated_t_volume_get(HandleRef jarg1);

	public static extern void vx_evt_participant_updated_t_energy_set(HandleRef jarg1, double jarg2);

	public static extern double vx_evt_participant_updated_t_energy_get(HandleRef jarg1);

	public static extern void vx_evt_participant_updated_t_active_media_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_participant_updated_t_active_media_get(HandleRef jarg1);

	public static extern void vx_evt_participant_updated_t_is_muted_for_me_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_participant_updated_t_is_muted_for_me_get(HandleRef jarg1);

	public static extern void vx_evt_participant_updated_t_is_text_muted_for_me_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_participant_updated_t_is_text_muted_for_me_get(HandleRef jarg1);

	public static extern void vx_evt_participant_updated_t_is_moderator_text_muted_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_participant_updated_t_is_moderator_text_muted_get(HandleRef jarg1);

	public static extern void vx_evt_participant_updated_t_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_participant_updated_t_type_get(HandleRef jarg1);

	public static extern void vx_evt_participant_updated_t_diagnostic_states_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_participant_updated_t_diagnostic_states_get(HandleRef jarg1);

	public static extern void vx_evt_participant_updated_t_diagnostic_state_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_participant_updated_t_diagnostic_state_count_get(HandleRef jarg1);

	public static extern void vx_evt_participant_updated_t_alias_username_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_participant_updated_t_alias_username_get(HandleRef jarg1);

	public static extern void vx_evt_participant_updated_t_encoded_uri_with_tag_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_participant_updated_t_encoded_uri_with_tag_get(HandleRef jarg1);

	public static extern void vx_evt_participant_updated_t_is_current_user_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_participant_updated_t_is_current_user_get(HandleRef jarg1);

	public static extern void vx_evt_participant_updated_t_has_unavailable_capture_device_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_participant_updated_t_has_unavailable_capture_device_get(HandleRef jarg1);

	public static extern void vx_evt_participant_updated_t_has_unavailable_render_device_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_participant_updated_t_has_unavailable_render_device_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_participant_updated_t();

	public static extern void delete_vx_evt_participant_updated_t(HandleRef jarg1);

	public static extern void vx_evt_sessiongroup_playback_frame_played_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_sessiongroup_playback_frame_played_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_sessiongroup_playback_frame_played_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_sessiongroup_playback_frame_played_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_evt_sessiongroup_playback_frame_played_t_first_frame_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_sessiongroup_playback_frame_played_t_first_frame_get(HandleRef jarg1);

	public static extern void vx_evt_sessiongroup_playback_frame_played_t_current_frame_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_sessiongroup_playback_frame_played_t_current_frame_get(HandleRef jarg1);

	public static extern void vx_evt_sessiongroup_playback_frame_played_t_total_frames_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_sessiongroup_playback_frame_played_t_total_frames_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_sessiongroup_playback_frame_played_t();

	public static extern void delete_vx_evt_sessiongroup_playback_frame_played_t(HandleRef jarg1);

	public static extern void vx_evt_session_updated_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_session_updated_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_session_updated_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_updated_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_evt_session_updated_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_updated_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_evt_session_updated_t_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_session_updated_t_uri_get(HandleRef jarg1);

	public static extern void vx_evt_session_updated_t_is_muted_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_session_updated_t_is_muted_get(HandleRef jarg1);

	public static extern void vx_evt_session_updated_t_volume_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_session_updated_t_volume_get(HandleRef jarg1);

	public static extern void vx_evt_session_updated_t_transmit_enabled_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_session_updated_t_transmit_enabled_get(HandleRef jarg1);

	public static extern void vx_evt_session_updated_t_is_focused_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_session_updated_t_is_focused_get(HandleRef jarg1);

	public static extern void vx_evt_session_updated_t_speaker_position_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_session_updated_t_speaker_position_get(HandleRef jarg1);

	public static extern void vx_evt_session_updated_t_session_font_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_session_updated_t_session_font_id_get(HandleRef jarg1);

	public static extern void vx_evt_session_updated_t_is_text_muted_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_session_updated_t_is_text_muted_get(HandleRef jarg1);

	public static extern void vx_evt_session_updated_t_is_ad_playing_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_session_updated_t_is_ad_playing_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_session_updated_t();

	public static extern void delete_vx_evt_session_updated_t(HandleRef jarg1);

	public static extern void vx_evt_sessiongroup_updated_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_sessiongroup_updated_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_sessiongroup_updated_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_sessiongroup_updated_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_evt_sessiongroup_updated_t_in_delayed_playback_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_sessiongroup_updated_t_in_delayed_playback_get(HandleRef jarg1);

	public static extern void vx_evt_sessiongroup_updated_t_current_playback_speed_set(HandleRef jarg1, double jarg2);

	public static extern double vx_evt_sessiongroup_updated_t_current_playback_speed_get(HandleRef jarg1);

	public static extern void vx_evt_sessiongroup_updated_t_current_playback_mode_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_sessiongroup_updated_t_current_playback_mode_get(HandleRef jarg1);

	public static extern void vx_evt_sessiongroup_updated_t_playback_paused_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_sessiongroup_updated_t_playback_paused_get(HandleRef jarg1);

	public static extern void vx_evt_sessiongroup_updated_t_loop_buffer_capacity_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_sessiongroup_updated_t_loop_buffer_capacity_get(HandleRef jarg1);

	public static extern void vx_evt_sessiongroup_updated_t_first_loop_frame_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_sessiongroup_updated_t_first_loop_frame_get(HandleRef jarg1);

	public static extern void vx_evt_sessiongroup_updated_t_total_loop_frames_captured_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_sessiongroup_updated_t_total_loop_frames_captured_get(HandleRef jarg1);

	public static extern void vx_evt_sessiongroup_updated_t_last_loop_frame_played_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_sessiongroup_updated_t_last_loop_frame_played_get(HandleRef jarg1);

	public static extern void vx_evt_sessiongroup_updated_t_current_recording_filename_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_sessiongroup_updated_t_current_recording_filename_get(HandleRef jarg1);

	public static extern void vx_evt_sessiongroup_updated_t_total_recorded_frames_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_sessiongroup_updated_t_total_recorded_frames_get(HandleRef jarg1);

	public static extern void vx_evt_sessiongroup_updated_t_first_frame_timestamp_us_set(HandleRef jarg1, long jarg2);

	public static extern long vx_evt_sessiongroup_updated_t_first_frame_timestamp_us_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_sessiongroup_updated_t();

	public static extern void delete_vx_evt_sessiongroup_updated_t(HandleRef jarg1);

	public static extern void vx_evt_media_completion_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_media_completion_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_media_completion_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_media_completion_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_evt_media_completion_t_completion_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_media_completion_t_completion_type_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_media_completion_t();

	public static extern void delete_vx_evt_media_completion_t(HandleRef jarg1);

	public static extern void vx_evt_server_app_data_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_server_app_data_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_server_app_data_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_server_app_data_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_evt_server_app_data_t_content_type_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_server_app_data_t_content_type_get(HandleRef jarg1);

	public static extern void vx_evt_server_app_data_t_content_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_server_app_data_t_content_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_server_app_data_t();

	public static extern void delete_vx_evt_server_app_data_t(HandleRef jarg1);

	public static extern void vx_evt_user_app_data_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_user_app_data_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_user_app_data_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_user_app_data_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_evt_user_app_data_t_from_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_user_app_data_t_from_uri_get(HandleRef jarg1);

	public static extern void vx_evt_user_app_data_t_content_type_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_user_app_data_t_content_type_get(HandleRef jarg1);

	public static extern void vx_evt_user_app_data_t_content_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_user_app_data_t_content_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_user_app_data_t();

	public static extern void delete_vx_evt_user_app_data_t(HandleRef jarg1);

	public static extern void vx_evt_network_message_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_network_message_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_network_message_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_network_message_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_evt_network_message_t_network_message_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_network_message_t_network_message_type_get(HandleRef jarg1);

	public static extern void vx_evt_network_message_t_content_type_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_network_message_t_content_type_get(HandleRef jarg1);

	public static extern void vx_evt_network_message_t_content_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_network_message_t_content_get(HandleRef jarg1);

	public static extern void vx_evt_network_message_t_sender_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_network_message_t_sender_uri_get(HandleRef jarg1);

	public static extern void vx_evt_network_message_t_sender_display_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_network_message_t_sender_display_name_get(HandleRef jarg1);

	public static extern void vx_evt_network_message_t_sender_alias_username_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_network_message_t_sender_alias_username_get(HandleRef jarg1);

	public static extern void vx_evt_network_message_t_receiver_alias_username_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_network_message_t_receiver_alias_username_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_network_message_t();

	public static extern void delete_vx_evt_network_message_t(HandleRef jarg1);

	public static extern void vx_evt_voice_service_connection_state_changed_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_voice_service_connection_state_changed_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_voice_service_connection_state_changed_t_connected_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_voice_service_connection_state_changed_t_connected_get(HandleRef jarg1);

	public static extern void vx_evt_voice_service_connection_state_changed_t_platform_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_voice_service_connection_state_changed_t_platform_get(HandleRef jarg1);

	public static extern void vx_evt_voice_service_connection_state_changed_t_version_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_voice_service_connection_state_changed_t_version_get(HandleRef jarg1);

	public static extern void vx_evt_voice_service_connection_state_changed_t_data_directory_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_voice_service_connection_state_changed_t_data_directory_get(HandleRef jarg1);

	public static extern void vx_evt_voice_service_connection_state_changed_t_network_test_run_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_voice_service_connection_state_changed_t_network_test_run_get(HandleRef jarg1);

	public static extern void vx_evt_voice_service_connection_state_changed_t_network_test_completed_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_voice_service_connection_state_changed_t_network_test_completed_get(HandleRef jarg1);

	public static extern void vx_evt_voice_service_connection_state_changed_t_network_test_state_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_voice_service_connection_state_changed_t_network_test_state_get(HandleRef jarg1);

	public static extern void vx_evt_voice_service_connection_state_changed_t_network_is_down_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_voice_service_connection_state_changed_t_network_is_down_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_voice_service_connection_state_changed_t();

	public static extern void delete_vx_evt_voice_service_connection_state_changed_t(HandleRef jarg1);

	public static extern void vx_evt_publication_state_changed_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_publication_state_changed_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_publication_state_changed_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_publication_state_changed_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_evt_publication_state_changed_t_alias_username_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_publication_state_changed_t_alias_username_get(HandleRef jarg1);

	public static extern void vx_evt_publication_state_changed_t_state_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_publication_state_changed_t_state_get(HandleRef jarg1);

	public static extern void vx_evt_publication_state_changed_t_presence_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_publication_state_changed_t_presence_get(HandleRef jarg1);

	public static extern void vx_evt_publication_state_changed_t_custom_message_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_publication_state_changed_t_custom_message_get(HandleRef jarg1);

	public static extern void vx_evt_publication_state_changed_t_status_code_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_publication_state_changed_t_status_code_get(HandleRef jarg1);

	public static extern void vx_evt_publication_state_changed_t_status_string_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_publication_state_changed_t_status_string_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_publication_state_changed_t();

	public static extern void delete_vx_evt_publication_state_changed_t(HandleRef jarg1);

	public static extern void vx_evt_audio_device_hot_swap_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_audio_device_hot_swap_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_audio_device_hot_swap_t_event_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_audio_device_hot_swap_t_event_type_get(HandleRef jarg1);

	public static extern void vx_evt_audio_device_hot_swap_t_relevant_device_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_audio_device_hot_swap_t_relevant_device_get(HandleRef jarg1);

	public static extern void vx_evt_audio_device_hot_swap_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_audio_device_hot_swap_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_audio_device_hot_swap_t();

	public static extern void delete_vx_evt_audio_device_hot_swap_t(HandleRef jarg1);

	public static extern void vx_evt_user_to_user_message_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_user_to_user_message_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_user_to_user_message_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_user_to_user_message_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_evt_user_to_user_message_t_from_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_user_to_user_message_t_from_uri_get(HandleRef jarg1);

	public static extern void vx_evt_user_to_user_message_t_encoded_uri_with_tag_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_user_to_user_message_t_encoded_uri_with_tag_get(HandleRef jarg1);

	public static extern void vx_evt_user_to_user_message_t_message_body_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_user_to_user_message_t_message_body_get(HandleRef jarg1);

	public static extern void vx_evt_user_to_user_message_t_language_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_user_to_user_message_t_language_get(HandleRef jarg1);

	public static extern void vx_evt_user_to_user_message_t_application_stanza_namespace_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_user_to_user_message_t_application_stanza_namespace_get(HandleRef jarg1);

	public static extern void vx_evt_user_to_user_message_t_application_stanza_body_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_user_to_user_message_t_application_stanza_body_get(HandleRef jarg1);

	public static extern void vx_evt_user_to_user_message_t_from_displayname_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_user_to_user_message_t_from_displayname_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_user_to_user_message_t();

	public static extern void delete_vx_evt_user_to_user_message_t(HandleRef jarg1);

	public static extern void vx_evt_account_archive_message_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_account_archive_message_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_account_archive_message_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_account_archive_message_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_evt_account_archive_message_t_query_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_account_archive_message_t_query_id_get(HandleRef jarg1);

	public static extern void vx_evt_account_archive_message_t_time_stamp_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_account_archive_message_t_time_stamp_get(HandleRef jarg1);

	public static extern void vx_evt_account_archive_message_t_channel_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_account_archive_message_t_channel_uri_get(HandleRef jarg1);

	public static extern void vx_evt_account_archive_message_t_participant_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_account_archive_message_t_participant_uri_get(HandleRef jarg1);

	public static extern void vx_evt_account_archive_message_t_is_inbound_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_account_archive_message_t_is_inbound_get(HandleRef jarg1);

	public static extern void vx_evt_account_archive_message_t_message_body_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_account_archive_message_t_message_body_get(HandleRef jarg1);

	public static extern void vx_evt_account_archive_message_t_message_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_account_archive_message_t_message_id_get(HandleRef jarg1);

	public static extern void vx_evt_account_archive_message_t_encoded_uri_with_tag_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_account_archive_message_t_encoded_uri_with_tag_get(HandleRef jarg1);

	public static extern void vx_evt_account_archive_message_t_language_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_account_archive_message_t_language_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_account_archive_message_t();

	public static extern void delete_vx_evt_account_archive_message_t(HandleRef jarg1);

	public static extern void vx_evt_account_archive_query_end_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_account_archive_query_end_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_account_archive_query_end_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_account_archive_query_end_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_evt_account_archive_query_end_t_query_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_account_archive_query_end_t_query_id_get(HandleRef jarg1);

	public static extern void vx_evt_account_archive_query_end_t_return_code_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_account_archive_query_end_t_return_code_get(HandleRef jarg1);

	public static extern void vx_evt_account_archive_query_end_t_status_code_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_account_archive_query_end_t_status_code_get(HandleRef jarg1);

	public static extern void vx_evt_account_archive_query_end_t_first_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_account_archive_query_end_t_first_id_get(HandleRef jarg1);

	public static extern void vx_evt_account_archive_query_end_t_last_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_account_archive_query_end_t_last_id_get(HandleRef jarg1);

	public static extern void vx_evt_account_archive_query_end_t_first_index_set(HandleRef jarg1, uint jarg2);

	public static extern uint vx_evt_account_archive_query_end_t_first_index_get(HandleRef jarg1);

	public static extern void vx_evt_account_archive_query_end_t_count_set(HandleRef jarg1, uint jarg2);

	public static extern uint vx_evt_account_archive_query_end_t_count_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_account_archive_query_end_t();

	public static extern void delete_vx_evt_account_archive_query_end_t(HandleRef jarg1);

	public static extern void vx_evt_account_send_message_failed_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_account_send_message_failed_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_account_send_message_failed_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_account_send_message_failed_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_evt_account_send_message_failed_t_request_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_account_send_message_failed_t_request_id_get(HandleRef jarg1);

	public static extern void vx_evt_account_send_message_failed_t_status_code_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_account_send_message_failed_t_status_code_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_account_send_message_failed_t();

	public static extern void delete_vx_evt_account_send_message_failed_t(HandleRef jarg1);

	public static extern void vx_evt_tts_injection_started_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_tts_injection_started_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_tts_injection_started_t_num_consumers_set(HandleRef jarg1, uint jarg2);

	public static extern uint vx_evt_tts_injection_started_t_num_consumers_get(HandleRef jarg1);

	public static extern void vx_evt_tts_injection_started_t_utterance_id_set(HandleRef jarg1, uint jarg2);

	public static extern uint vx_evt_tts_injection_started_t_utterance_id_get(HandleRef jarg1);

	public static extern void vx_evt_tts_injection_started_t_utterance_duration_set(HandleRef jarg1, double jarg2);

	public static extern double vx_evt_tts_injection_started_t_utterance_duration_get(HandleRef jarg1);

	public static extern void vx_evt_tts_injection_started_t_tts_destination_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_tts_injection_started_t_tts_destination_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_tts_injection_started_t();

	public static extern void delete_vx_evt_tts_injection_started_t(HandleRef jarg1);

	public static extern void vx_evt_tts_injection_ended_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_tts_injection_ended_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_tts_injection_ended_t_num_consumers_set(HandleRef jarg1, uint jarg2);

	public static extern uint vx_evt_tts_injection_ended_t_num_consumers_get(HandleRef jarg1);

	public static extern void vx_evt_tts_injection_ended_t_utterance_id_set(HandleRef jarg1, uint jarg2);

	public static extern uint vx_evt_tts_injection_ended_t_utterance_id_get(HandleRef jarg1);

	public static extern void vx_evt_tts_injection_ended_t_tts_destination_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_tts_injection_ended_t_tts_destination_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_tts_injection_ended_t();

	public static extern void delete_vx_evt_tts_injection_ended_t(HandleRef jarg1);

	public static extern void vx_evt_tts_injection_failed_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_tts_injection_failed_t_base__get(HandleRef jarg1);

	public static extern void vx_evt_tts_injection_failed_t_status_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_tts_injection_failed_t_status_get(HandleRef jarg1);

	public static extern void vx_evt_tts_injection_failed_t_utterance_id_set(HandleRef jarg1, uint jarg2);

	public static extern uint vx_evt_tts_injection_failed_t_utterance_id_get(HandleRef jarg1);

	public static extern void vx_evt_tts_injection_failed_t_tts_destination_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_tts_injection_failed_t_tts_destination_get(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_tts_injection_failed_t();

	public static extern void delete_vx_evt_tts_injection_failed_t(HandleRef jarg1);

	public static extern int destroy_evt(HandleRef jarg1);

	public static extern int VX_USE_PLATFORM_SPECIFIC_PORT_RANGE_get();

	public static extern int MAX_CHANNEL_URI_LENGTH_get();

	public static extern void vx_req_connector_create_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_connector_create_t_base__get(HandleRef jarg1);

	public static extern void vx_req_connector_create_t_client_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_connector_create_t_client_name_get(HandleRef jarg1);

	public static extern void vx_req_connector_create_t_acct_mgmt_server_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_connector_create_t_acct_mgmt_server_get(HandleRef jarg1);

	public static extern void vx_req_connector_create_t_minimum_port_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_connector_create_t_minimum_port_get(HandleRef jarg1);

	public static extern void vx_req_connector_create_t_maximum_port_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_connector_create_t_maximum_port_get(HandleRef jarg1);

	public static extern void vx_req_connector_create_t_attempt_stun_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_connector_create_t_attempt_stun_get(HandleRef jarg1);

	public static extern void vx_req_connector_create_t_mode_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_connector_create_t_mode_get(HandleRef jarg1);

	public static extern void vx_req_connector_create_t_log_folder_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_connector_create_t_log_folder_get(HandleRef jarg1);

	public static extern void vx_req_connector_create_t_log_filename_prefix_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_connector_create_t_log_filename_prefix_get(HandleRef jarg1);

	public static extern void vx_req_connector_create_t_log_filename_suffix_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_connector_create_t_log_filename_suffix_get(HandleRef jarg1);

	public static extern void vx_req_connector_create_t_log_level_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_connector_create_t_log_level_get(HandleRef jarg1);

	public static extern void vx_req_connector_create_t_session_handle_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_connector_create_t_session_handle_type_get(HandleRef jarg1);

	public static extern void vx_req_connector_create_t_application_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_connector_create_t_application_get(HandleRef jarg1);

	public static extern void vx_req_connector_create_t_max_calls_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_connector_create_t_max_calls_get(HandleRef jarg1);

	public static extern void vx_req_connector_create_t_allow_cross_domain_logins_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_connector_create_t_allow_cross_domain_logins_get(HandleRef jarg1);

	public static extern void vx_req_connector_create_t_default_codec_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_connector_create_t_default_codec_get(HandleRef jarg1);

	public static extern void vx_req_connector_create_t_user_agent_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_connector_create_t_user_agent_id_get(HandleRef jarg1);

	public static extern void vx_req_connector_create_t_media_probe_server_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_connector_create_t_media_probe_server_get(HandleRef jarg1);

	public static extern void vx_req_connector_create_t_http_proxy_server_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_connector_create_t_http_proxy_server_name_get(HandleRef jarg1);

	public static extern void vx_req_connector_create_t_http_proxy_server_port_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_connector_create_t_http_proxy_server_port_get(HandleRef jarg1);

	public static extern void vx_req_connector_create_t_enable_duplicate_participant_uris_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_connector_create_t_enable_duplicate_participant_uris_get(HandleRef jarg1);

	public static extern void vx_req_connector_create_t_connector_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_connector_create_t_connector_handle_get(HandleRef jarg1);

	public static extern void vx_req_connector_create_t_configured_codecs_set(HandleRef jarg1, uint jarg2);

	public static extern uint vx_req_connector_create_t_configured_codecs_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_connector_create_t();

	public static extern void delete_vx_req_connector_create_t(HandleRef jarg1);

	public static extern int vx_req_connector_create_create(HandleRef jarg1);

	public static extern void vx_req_connector_initiate_shutdown_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_connector_initiate_shutdown_t_base__get(HandleRef jarg1);

	public static extern void vx_req_connector_initiate_shutdown_t_connector_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_connector_initiate_shutdown_t_connector_handle_get(HandleRef jarg1);

	public static extern void vx_req_connector_initiate_shutdown_t_client_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_connector_initiate_shutdown_t_client_name_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_connector_initiate_shutdown_t();

	public static extern void delete_vx_req_connector_initiate_shutdown_t(HandleRef jarg1);

	public static extern int vx_req_connector_initiate_shutdown_create(HandleRef jarg1);

	public static extern void vx_req_account_login_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_login_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_login_t_connector_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_login_t_connector_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_login_t_acct_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_login_t_acct_name_get(HandleRef jarg1);

	public static extern void vx_req_account_login_t_acct_password_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_login_t_acct_password_get(HandleRef jarg1);

	public static extern void vx_req_account_login_t_answer_mode_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_login_t_answer_mode_get(HandleRef jarg1);

	public static extern void vx_req_account_login_t_enable_text_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_login_t_enable_text_get(HandleRef jarg1);

	public static extern void vx_req_account_login_t_participant_property_frequency_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_login_t_participant_property_frequency_get(HandleRef jarg1);

	public static extern void vx_req_account_login_t_enable_buddies_and_presence_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_login_t_enable_buddies_and_presence_get(HandleRef jarg1);

	public static extern void vx_req_account_login_t_buddy_management_mode_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_login_t_buddy_management_mode_get(HandleRef jarg1);

	public static extern void vx_req_account_login_t_enable_client_ringback_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_login_t_enable_client_ringback_get(HandleRef jarg1);

	public static extern void vx_req_account_login_t_autopost_crash_dumps_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_login_t_autopost_crash_dumps_get(HandleRef jarg1);

	public static extern void vx_req_account_login_t_acct_mgmt_server_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_login_t_acct_mgmt_server_get(HandleRef jarg1);

	public static extern void vx_req_account_login_t_application_token_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_login_t_application_token_get(HandleRef jarg1);

	public static extern void vx_req_account_login_t_application_override_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_login_t_application_override_get(HandleRef jarg1);

	public static extern void vx_req_account_login_t_client_ip_override_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_login_t_client_ip_override_get(HandleRef jarg1);

	public static extern void vx_req_account_login_t_enable_presence_persistence_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_login_t_enable_presence_persistence_get(HandleRef jarg1);

	public static extern void vx_req_account_login_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_login_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_login_t();

	public static extern void delete_vx_req_account_login_t(HandleRef jarg1);

	public static extern int vx_req_account_login_create(HandleRef jarg1);

	public static extern void vx_req_account_authtoken_login_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_authtoken_login_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_authtoken_login_t_connector_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_authtoken_login_t_connector_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_authtoken_login_t_authtoken_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_authtoken_login_t_authtoken_get(HandleRef jarg1);

	public static extern void vx_req_account_authtoken_login_t_enable_text_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_authtoken_login_t_enable_text_get(HandleRef jarg1);

	public static extern void vx_req_account_authtoken_login_t_participant_property_frequency_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_authtoken_login_t_participant_property_frequency_get(HandleRef jarg1);

	public static extern void vx_req_account_authtoken_login_t_enable_buddies_and_presence_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_authtoken_login_t_enable_buddies_and_presence_get(HandleRef jarg1);

	public static extern void vx_req_account_authtoken_login_t_buddy_management_mode_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_authtoken_login_t_buddy_management_mode_get(HandleRef jarg1);

	public static extern void vx_req_account_authtoken_login_t_autopost_crash_dumps_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_authtoken_login_t_autopost_crash_dumps_get(HandleRef jarg1);

	public static extern void vx_req_account_authtoken_login_t_acct_mgmt_server_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_authtoken_login_t_acct_mgmt_server_get(HandleRef jarg1);

	public static extern void vx_req_account_authtoken_login_t_application_token_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_authtoken_login_t_application_token_get(HandleRef jarg1);

	public static extern void vx_req_account_authtoken_login_t_application_override_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_authtoken_login_t_application_override_get(HandleRef jarg1);

	public static extern void vx_req_account_authtoken_login_t_answer_mode_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_authtoken_login_t_answer_mode_get(HandleRef jarg1);

	public static extern void vx_req_account_authtoken_login_t_client_ip_override_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_authtoken_login_t_client_ip_override_get(HandleRef jarg1);

	public static extern void vx_req_account_authtoken_login_t_enable_presence_persistence_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_authtoken_login_t_enable_presence_persistence_get(HandleRef jarg1);

	public static extern void vx_req_account_authtoken_login_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_authtoken_login_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_authtoken_login_t();

	public static extern void delete_vx_req_account_authtoken_login_t(HandleRef jarg1);

	public static extern int vx_req_account_authtoken_login_create(HandleRef jarg1);

	public static extern void vx_req_account_anonymous_login_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_anonymous_login_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_anonymous_login_t_connector_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_anonymous_login_t_connector_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_anonymous_login_t_displayname_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_anonymous_login_t_displayname_get(HandleRef jarg1);

	public static extern void vx_req_account_anonymous_login_t_participant_property_frequency_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_anonymous_login_t_participant_property_frequency_get(HandleRef jarg1);

	public static extern void vx_req_account_anonymous_login_t_enable_buddies_and_presence_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_anonymous_login_t_enable_buddies_and_presence_get(HandleRef jarg1);

	public static extern void vx_req_account_anonymous_login_t_buddy_management_mode_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_anonymous_login_t_buddy_management_mode_get(HandleRef jarg1);

	public static extern void vx_req_account_anonymous_login_t_autopost_crash_dumps_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_anonymous_login_t_autopost_crash_dumps_get(HandleRef jarg1);

	public static extern void vx_req_account_anonymous_login_t_acct_mgmt_server_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_anonymous_login_t_acct_mgmt_server_get(HandleRef jarg1);

	public static extern void vx_req_account_anonymous_login_t_application_token_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_anonymous_login_t_application_token_get(HandleRef jarg1);

	public static extern void vx_req_account_anonymous_login_t_application_override_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_anonymous_login_t_application_override_get(HandleRef jarg1);

	public static extern void vx_req_account_anonymous_login_t_client_ip_override_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_anonymous_login_t_client_ip_override_get(HandleRef jarg1);

	public static extern void vx_req_account_anonymous_login_t_enable_presence_persistence_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_anonymous_login_t_enable_presence_persistence_get(HandleRef jarg1);

	public static extern void vx_req_account_anonymous_login_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_anonymous_login_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_anonymous_login_t_acct_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_anonymous_login_t_acct_name_get(HandleRef jarg1);

	public static extern void vx_req_account_anonymous_login_t_access_token_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_anonymous_login_t_access_token_get(HandleRef jarg1);

	public static extern void vx_req_account_anonymous_login_t_initial_buddy_uris_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_anonymous_login_t_initial_buddy_uris_get(HandleRef jarg1);

	public static extern void vx_req_account_anonymous_login_t_initial_blocked_uris_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_anonymous_login_t_initial_blocked_uris_get(HandleRef jarg1);

	public static extern void vx_req_account_anonymous_login_t_initial_blocked_uris_presence_only_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_anonymous_login_t_initial_blocked_uris_presence_only_get(HandleRef jarg1);

	public static extern void vx_req_account_anonymous_login_t_initial_allowed_uris_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_anonymous_login_t_initial_allowed_uris_get(HandleRef jarg1);

	public static extern void vx_req_account_anonymous_login_t_languages_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_anonymous_login_t_languages_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_anonymous_login_t();

	public static extern void delete_vx_req_account_anonymous_login_t(HandleRef jarg1);

	public static extern int vx_req_account_anonymous_login_create(HandleRef jarg1);

	public static extern void vx_req_account_logout_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_logout_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_logout_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_logout_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_logout_t_logout_reason_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_logout_t_logout_reason_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_logout_t();

	public static extern void delete_vx_req_account_logout_t(HandleRef jarg1);

	public static extern int vx_req_account_logout_create(HandleRef jarg1);

	public static extern void vx_req_account_set_login_properties_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_set_login_properties_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_set_login_properties_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_set_login_properties_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_set_login_properties_t_answer_mode_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_set_login_properties_t_answer_mode_get(HandleRef jarg1);

	public static extern void vx_req_account_set_login_properties_t_participant_property_frequency_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_set_login_properties_t_participant_property_frequency_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_set_login_properties_t();

	public static extern void delete_vx_req_account_set_login_properties_t(HandleRef jarg1);

	public static extern int vx_req_account_set_login_properties_create(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_create_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_sessiongroup_create_t_base__get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_create_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_create_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_create_t_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_sessiongroup_create_t_type_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_create_t_loop_mode_duration_seconds_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_sessiongroup_create_t_loop_mode_duration_seconds_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_create_t_capture_device_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_create_t_capture_device_id_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_create_t_render_device_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_create_t_render_device_id_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_create_t_alias_username_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_create_t_alias_username_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_create_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_create_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_sessiongroup_create_t();

	public static extern void delete_vx_req_sessiongroup_create_t(HandleRef jarg1);

	public static extern int vx_req_sessiongroup_create_create(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_terminate_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_sessiongroup_terminate_t_base__get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_terminate_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_terminate_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_sessiongroup_terminate_t();

	public static extern void delete_vx_req_sessiongroup_terminate_t(HandleRef jarg1);

	public static extern int vx_req_sessiongroup_terminate_create(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_add_session_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_sessiongroup_add_session_t_base__get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_add_session_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_add_session_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_add_session_t_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_add_session_t_uri_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_add_session_t_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_add_session_t_name_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_add_session_t_password_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_add_session_t_password_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_add_session_t_connect_audio_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_sessiongroup_add_session_t_connect_audio_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_add_session_t_password_hash_algorithm_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_sessiongroup_add_session_t_password_hash_algorithm_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_add_session_t_session_font_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_sessiongroup_add_session_t_session_font_id_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_add_session_t_connect_text_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_sessiongroup_add_session_t_connect_text_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_add_session_t_jitter_compensation_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_sessiongroup_add_session_t_jitter_compensation_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_add_session_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_add_session_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_add_session_t_access_token_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_add_session_t_access_token_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_add_session_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_add_session_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_sessiongroup_add_session_t();

	public static extern void delete_vx_req_sessiongroup_add_session_t(HandleRef jarg1);

	public static extern int vx_req_sessiongroup_add_session_create(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_remove_session_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_sessiongroup_remove_session_t_base__get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_remove_session_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_remove_session_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_remove_session_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_remove_session_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_sessiongroup_remove_session_t();

	public static extern void delete_vx_req_sessiongroup_remove_session_t(HandleRef jarg1);

	public static extern int vx_req_sessiongroup_remove_session_create(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_set_focus_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_sessiongroup_set_focus_t_base__get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_set_focus_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_set_focus_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_set_focus_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_set_focus_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_sessiongroup_set_focus_t();

	public static extern void delete_vx_req_sessiongroup_set_focus_t(HandleRef jarg1);

	public static extern int vx_req_sessiongroup_set_focus_create(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_unset_focus_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_sessiongroup_unset_focus_t_base__get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_unset_focus_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_unset_focus_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_unset_focus_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_unset_focus_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_sessiongroup_unset_focus_t();

	public static extern void delete_vx_req_sessiongroup_unset_focus_t(HandleRef jarg1);

	public static extern int vx_req_sessiongroup_unset_focus_create(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_reset_focus_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_sessiongroup_reset_focus_t_base__get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_reset_focus_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_reset_focus_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_sessiongroup_reset_focus_t();

	public static extern void delete_vx_req_sessiongroup_reset_focus_t(HandleRef jarg1);

	public static extern int vx_req_sessiongroup_reset_focus_create(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_set_tx_session_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_sessiongroup_set_tx_session_t_base__get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_set_tx_session_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_set_tx_session_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_set_tx_session_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_set_tx_session_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_sessiongroup_set_tx_session_t();

	public static extern void delete_vx_req_sessiongroup_set_tx_session_t(HandleRef jarg1);

	public static extern int vx_req_sessiongroup_set_tx_session_create(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_set_tx_all_sessions_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_sessiongroup_set_tx_all_sessions_t_base__get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_set_tx_all_sessions_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_set_tx_all_sessions_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_sessiongroup_set_tx_all_sessions_t();

	public static extern void delete_vx_req_sessiongroup_set_tx_all_sessions_t(HandleRef jarg1);

	public static extern int vx_req_sessiongroup_set_tx_all_sessions_create(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_set_tx_no_session_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_sessiongroup_set_tx_no_session_t_base__get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_set_tx_no_session_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_set_tx_no_session_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_sessiongroup_set_tx_no_session_t();

	public static extern void delete_vx_req_sessiongroup_set_tx_no_session_t(HandleRef jarg1);

	public static extern int vx_req_sessiongroup_set_tx_no_session_create(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_set_session_3d_position_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_sessiongroup_set_session_3d_position_t_base__get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_set_session_3d_position_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_set_session_3d_position_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_set_session_3d_position_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_set_session_3d_position_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_set_session_3d_position_t_speaker_position_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_sessiongroup_set_session_3d_position_t_speaker_position_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_set_session_3d_position_t_speaker_at_orientation_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_sessiongroup_set_session_3d_position_t_speaker_at_orientation_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_sessiongroup_set_session_3d_position_t();

	public static extern void delete_vx_req_sessiongroup_set_session_3d_position_t(HandleRef jarg1);

	public static extern int vx_req_sessiongroup_set_session_3d_position_create(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_control_audio_injection_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_sessiongroup_control_audio_injection_t_base__get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_control_audio_injection_t_audio_injection_control_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_sessiongroup_control_audio_injection_t_audio_injection_control_type_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_control_audio_injection_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_control_audio_injection_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_control_audio_injection_t_filename_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_control_audio_injection_t_filename_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_sessiongroup_control_audio_injection_t();

	public static extern void delete_vx_req_sessiongroup_control_audio_injection_t(HandleRef jarg1);

	public static extern int vx_req_sessiongroup_control_audio_injection_create(HandleRef jarg1);

	public static extern void vx_req_session_create_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_create_t_base__get(HandleRef jarg1);

	public static extern void vx_req_session_create_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_create_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_session_create_t_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_create_t_name_get(HandleRef jarg1);

	public static extern void vx_req_session_create_t_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_create_t_uri_get(HandleRef jarg1);

	public static extern void vx_req_session_create_t_password_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_create_t_password_get(HandleRef jarg1);

	public static extern void vx_req_session_create_t_connect_audio_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_create_t_connect_audio_get(HandleRef jarg1);

	public static extern void vx_req_session_create_t_join_audio_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_create_t_join_audio_get(HandleRef jarg1);

	public static extern void vx_req_session_create_t_join_text_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_create_t_join_text_get(HandleRef jarg1);

	public static extern void vx_req_session_create_t_password_hash_algorithm_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_create_t_password_hash_algorithm_get(HandleRef jarg1);

	public static extern void vx_req_session_create_t_connect_text_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_create_t_connect_text_get(HandleRef jarg1);

	public static extern void vx_req_session_create_t_session_font_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_create_t_session_font_id_get(HandleRef jarg1);

	public static extern void vx_req_session_create_t_jitter_compensation_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_create_t_jitter_compensation_get(HandleRef jarg1);

	public static extern void vx_req_session_create_t_alias_username_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_create_t_alias_username_get(HandleRef jarg1);

	public static extern void vx_req_session_create_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_create_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_req_session_create_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_create_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_req_session_create_t_access_token_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_create_t_access_token_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_session_create_t();

	public static extern void delete_vx_req_session_create_t(HandleRef jarg1);

	public static extern int vx_req_session_create_create(HandleRef jarg1);

	public static extern void vx_req_session_media_connect_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_media_connect_t_base__get(HandleRef jarg1);

	public static extern void vx_req_session_media_connect_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_media_connect_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_req_session_media_connect_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_media_connect_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_req_session_media_connect_t_session_font_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_media_connect_t_session_font_id_get(HandleRef jarg1);

	public static extern void vx_req_session_media_connect_t_media_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_media_connect_t_media_get(HandleRef jarg1);

	public static extern void vx_req_session_media_connect_t_capture_device_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_media_connect_t_capture_device_id_get(HandleRef jarg1);

	public static extern void vx_req_session_media_connect_t_render_device_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_media_connect_t_render_device_id_get(HandleRef jarg1);

	public static extern void vx_req_session_media_connect_t_jitter_compensation_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_media_connect_t_jitter_compensation_get(HandleRef jarg1);

	public static extern void vx_req_session_media_connect_t_loop_mode_duration_seconds_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_media_connect_t_loop_mode_duration_seconds_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_session_media_connect_t();

	public static extern void delete_vx_req_session_media_connect_t(HandleRef jarg1);

	public static extern int vx_req_session_media_connect_create(HandleRef jarg1);

	public static extern void vx_req_session_media_disconnect_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_media_disconnect_t_base__get(HandleRef jarg1);

	public static extern void vx_req_session_media_disconnect_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_media_disconnect_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_req_session_media_disconnect_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_media_disconnect_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_req_session_media_disconnect_t_media_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_media_disconnect_t_media_get(HandleRef jarg1);

	public static extern void vx_req_session_media_disconnect_t_termination_status_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_media_disconnect_t_termination_status_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_session_media_disconnect_t();

	public static extern void delete_vx_req_session_media_disconnect_t(HandleRef jarg1);

	public static extern int vx_req_session_media_disconnect_create(HandleRef jarg1);

	public static extern void vx_req_session_text_connect_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_text_connect_t_base__get(HandleRef jarg1);

	public static extern void vx_req_session_text_connect_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_text_connect_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_req_session_text_connect_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_text_connect_t_session_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_session_text_connect_t();

	public static extern void delete_vx_req_session_text_connect_t(HandleRef jarg1);

	public static extern int vx_req_session_text_connect_create(HandleRef jarg1);

	public static extern void vx_req_session_text_disconnect_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_text_disconnect_t_base__get(HandleRef jarg1);

	public static extern void vx_req_session_text_disconnect_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_text_disconnect_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_req_session_text_disconnect_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_text_disconnect_t_session_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_session_text_disconnect_t();

	public static extern void delete_vx_req_session_text_disconnect_t(HandleRef jarg1);

	public static extern int vx_req_session_text_disconnect_create(HandleRef jarg1);

	public static extern void vx_req_session_terminate_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_terminate_t_base__get(HandleRef jarg1);

	public static extern void vx_req_session_terminate_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_terminate_t_session_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_session_terminate_t();

	public static extern void delete_vx_req_session_terminate_t(HandleRef jarg1);

	public static extern int vx_req_session_terminate_create(HandleRef jarg1);

	public static extern void vx_req_session_mute_local_speaker_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_mute_local_speaker_t_base__get(HandleRef jarg1);

	public static extern void vx_req_session_mute_local_speaker_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_mute_local_speaker_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_req_session_mute_local_speaker_t_mute_level_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_mute_local_speaker_t_mute_level_get(HandleRef jarg1);

	public static extern void vx_req_session_mute_local_speaker_t_scope_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_mute_local_speaker_t_scope_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_session_mute_local_speaker_t();

	public static extern void delete_vx_req_session_mute_local_speaker_t(HandleRef jarg1);

	public static extern int vx_req_session_mute_local_speaker_create(HandleRef jarg1);

	public static extern void vx_req_session_set_local_render_volume_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_set_local_render_volume_t_base__get(HandleRef jarg1);

	public static extern void vx_req_session_set_local_render_volume_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_set_local_render_volume_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_req_session_set_local_render_volume_t_volume_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_set_local_render_volume_t_volume_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_session_set_local_render_volume_t();

	public static extern void delete_vx_req_session_set_local_render_volume_t(HandleRef jarg1);

	public static extern int vx_req_session_set_local_render_volume_create(HandleRef jarg1);

	public static extern void vx_req_session_set_local_speaker_volume_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_set_local_speaker_volume_t_base__get(HandleRef jarg1);

	public static extern void vx_req_session_set_local_speaker_volume_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_set_local_speaker_volume_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_req_session_set_local_speaker_volume_t_volume_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_set_local_speaker_volume_t_volume_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_session_set_local_speaker_volume_t();

	public static extern void delete_vx_req_session_set_local_speaker_volume_t(HandleRef jarg1);

	public static extern int vx_req_session_set_local_speaker_volume_create(HandleRef jarg1);

	public static extern void vx_req_session_channel_invite_user_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_channel_invite_user_t_base__get(HandleRef jarg1);

	public static extern void vx_req_session_channel_invite_user_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_channel_invite_user_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_req_session_channel_invite_user_t_participant_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_channel_invite_user_t_participant_uri_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_session_channel_invite_user_t();

	public static extern void delete_vx_req_session_channel_invite_user_t(HandleRef jarg1);

	public static extern int vx_req_session_channel_invite_user_create(HandleRef jarg1);

	public static extern void vx_req_session_set_participant_volume_for_me_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_set_participant_volume_for_me_t_base__get(HandleRef jarg1);

	public static extern void vx_req_session_set_participant_volume_for_me_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_set_participant_volume_for_me_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_req_session_set_participant_volume_for_me_t_participant_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_set_participant_volume_for_me_t_participant_uri_get(HandleRef jarg1);

	public static extern void vx_req_session_set_participant_volume_for_me_t_volume_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_set_participant_volume_for_me_t_volume_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_session_set_participant_volume_for_me_t();

	public static extern void delete_vx_req_session_set_participant_volume_for_me_t(HandleRef jarg1);

	public static extern int vx_req_session_set_participant_volume_for_me_create(HandleRef jarg1);

	public static extern void vx_req_session_set_participant_mute_for_me_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_set_participant_mute_for_me_t_base__get(HandleRef jarg1);

	public static extern void vx_req_session_set_participant_mute_for_me_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_set_participant_mute_for_me_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_req_session_set_participant_mute_for_me_t_participant_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_set_participant_mute_for_me_t_participant_uri_get(HandleRef jarg1);

	public static extern void vx_req_session_set_participant_mute_for_me_t_mute_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_set_participant_mute_for_me_t_mute_get(HandleRef jarg1);

	public static extern void vx_req_session_set_participant_mute_for_me_t_scope_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_set_participant_mute_for_me_t_scope_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_session_set_participant_mute_for_me_t();

	public static extern void delete_vx_req_session_set_participant_mute_for_me_t(HandleRef jarg1);

	public static extern int vx_req_session_set_participant_mute_for_me_create(HandleRef jarg1);

	public static extern void vx_req_session_set_3d_position_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_set_3d_position_t_base__get(HandleRef jarg1);

	public static extern void vx_req_session_set_3d_position_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_set_3d_position_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_req_session_set_3d_position_t_speaker_position_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_set_3d_position_t_speaker_position_get(HandleRef jarg1);

	public static extern void vx_req_session_set_3d_position_t_speaker_velocity_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_set_3d_position_t_speaker_velocity_get(HandleRef jarg1);

	public static extern void vx_req_session_set_3d_position_t_speaker_at_orientation_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_set_3d_position_t_speaker_at_orientation_get(HandleRef jarg1);

	public static extern void vx_req_session_set_3d_position_t_speaker_up_orientation_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_set_3d_position_t_speaker_up_orientation_get(HandleRef jarg1);

	public static extern void vx_req_session_set_3d_position_t_speaker_left_orientation_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_set_3d_position_t_speaker_left_orientation_get(HandleRef jarg1);

	public static extern void vx_req_session_set_3d_position_t_listener_position_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_set_3d_position_t_listener_position_get(HandleRef jarg1);

	public static extern void vx_req_session_set_3d_position_t_listener_velocity_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_set_3d_position_t_listener_velocity_get(HandleRef jarg1);

	public static extern void vx_req_session_set_3d_position_t_listener_at_orientation_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_set_3d_position_t_listener_at_orientation_get(HandleRef jarg1);

	public static extern void vx_req_session_set_3d_position_t_listener_up_orientation_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_set_3d_position_t_listener_up_orientation_get(HandleRef jarg1);

	public static extern void vx_req_session_set_3d_position_t_listener_left_orientation_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_set_3d_position_t_listener_left_orientation_get(HandleRef jarg1);

	public static extern void vx_req_session_set_3d_position_t_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_set_3d_position_t_type_get(HandleRef jarg1);

	public static extern void vx_req_session_set_3d_position_t_req_disposition_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_set_3d_position_t_req_disposition_type_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_session_set_3d_position_t();

	public static extern void delete_vx_req_session_set_3d_position_t(HandleRef jarg1);

	public static extern void vx_req_session_set_3d_position_t_Set3DPosition(HandleRef jarg1, [In] float[] jarg2, [In] float[] jarg3, [In] float[] jarg4, [In] float[] jarg5);

	public static extern int vx_req_session_set_3d_position_create(HandleRef jarg1);

	public static extern void vx_req_session_set_voice_font_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_set_voice_font_t_base__get(HandleRef jarg1);

	public static extern void vx_req_session_set_voice_font_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_set_voice_font_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_req_session_set_voice_font_t_session_font_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_set_voice_font_t_session_font_id_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_session_set_voice_font_t();

	public static extern void delete_vx_req_session_set_voice_font_t(HandleRef jarg1);

	public static extern int vx_req_session_set_voice_font_create(HandleRef jarg1);

	public static extern void vx_req_account_channel_get_participants_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_channel_get_participants_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_channel_get_participants_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_get_participants_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_get_participants_t_channel_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_get_participants_t_channel_uri_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_get_participants_t_page_number_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_get_participants_t_page_number_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_get_participants_t_page_size_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_get_participants_t_page_size_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_channel_get_participants_t();

	public static extern void delete_vx_req_account_channel_get_participants_t(HandleRef jarg1);

	public static extern int vx_req_account_channel_get_participants_create(HandleRef jarg1);

	public static extern void vx_req_account_channel_change_owner_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_channel_change_owner_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_channel_change_owner_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_change_owner_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_change_owner_t_channel_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_change_owner_t_channel_uri_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_change_owner_t_new_owner_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_change_owner_t_new_owner_uri_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_channel_change_owner_t();

	public static extern void delete_vx_req_account_channel_change_owner_t(HandleRef jarg1);

	public static extern int vx_req_account_channel_change_owner_create(HandleRef jarg1);

	public static extern void vx_req_account_send_user_app_data_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_send_user_app_data_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_send_user_app_data_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_send_user_app_data_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_send_user_app_data_t_to_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_send_user_app_data_t_to_uri_get(HandleRef jarg1);

	public static extern void vx_req_account_send_user_app_data_t_content_type_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_send_user_app_data_t_content_type_get(HandleRef jarg1);

	public static extern void vx_req_account_send_user_app_data_t_content_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_send_user_app_data_t_content_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_send_user_app_data_t();

	public static extern void delete_vx_req_account_send_user_app_data_t(HandleRef jarg1);

	public static extern int vx_req_account_send_user_app_data_create(HandleRef jarg1);

	public static extern void vx_req_account_channel_create_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_channel_create_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_channel_create_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_create_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_create_t_channel_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_create_t_channel_name_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_create_t_channel_desc_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_create_t_channel_desc_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_create_t_channel_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_create_t_channel_type_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_create_t_set_persistent_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_create_t_set_persistent_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_create_t_set_protected_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_create_t_set_protected_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_create_t_protected_password_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_create_t_protected_password_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_create_t_capacity_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_create_t_capacity_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_create_t_max_participants_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_create_t_max_participants_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_create_t_channel_mode_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_create_t_channel_mode_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_create_t_max_range_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_create_t_max_range_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_create_t_clamping_dist_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_create_t_clamping_dist_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_create_t_roll_off_set(HandleRef jarg1, double jarg2);

	public static extern double vx_req_account_channel_create_t_roll_off_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_create_t_max_gain_set(HandleRef jarg1, double jarg2);

	public static extern double vx_req_account_channel_create_t_max_gain_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_create_t_dist_model_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_create_t_dist_model_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_create_t_encrypt_audio_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_create_t_encrypt_audio_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_channel_create_t();

	public static extern void delete_vx_req_account_channel_create_t(HandleRef jarg1);

	public static extern int vx_req_account_channel_create_create(HandleRef jarg1);

	public static extern void vx_req_account_channel_update_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_channel_update_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_channel_update_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_update_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_update_t_channel_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_update_t_channel_uri_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_update_t_channel_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_update_t_channel_name_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_update_t_channel_desc_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_update_t_channel_desc_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_update_t_set_persistent_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_update_t_set_persistent_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_update_t_set_protected_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_update_t_set_protected_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_update_t_protected_password_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_update_t_protected_password_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_update_t_capacity_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_update_t_capacity_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_update_t_max_participants_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_update_t_max_participants_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_update_t_channel_mode_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_update_t_channel_mode_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_update_t_max_range_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_update_t_max_range_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_update_t_clamping_dist_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_update_t_clamping_dist_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_update_t_roll_off_set(HandleRef jarg1, double jarg2);

	public static extern double vx_req_account_channel_update_t_roll_off_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_update_t_max_gain_set(HandleRef jarg1, double jarg2);

	public static extern double vx_req_account_channel_update_t_max_gain_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_update_t_dist_model_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_update_t_dist_model_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_update_t_encrypt_audio_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_update_t_encrypt_audio_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_channel_update_t();

	public static extern void delete_vx_req_account_channel_update_t(HandleRef jarg1);

	public static extern int vx_req_account_channel_update_create(HandleRef jarg1);

	public static extern void vx_req_account_channel_delete_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_channel_delete_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_channel_delete_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_delete_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_delete_t_channel_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_delete_t_channel_uri_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_channel_delete_t();

	public static extern void delete_vx_req_account_channel_delete_t(HandleRef jarg1);

	public static extern int vx_req_account_channel_delete_create(HandleRef jarg1);

	public static extern void vx_req_account_channel_favorites_get_list_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_channel_favorites_get_list_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_channel_favorites_get_list_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_favorites_get_list_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_channel_favorites_get_list_t();

	public static extern void delete_vx_req_account_channel_favorites_get_list_t(HandleRef jarg1);

	public static extern int vx_req_account_channel_favorites_get_list_create(HandleRef jarg1);

	public static extern void vx_req_account_channel_favorite_set_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_channel_favorite_set_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_channel_favorite_set_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_favorite_set_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_favorite_set_t_channel_favorite_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_favorite_set_t_channel_favorite_id_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_favorite_set_t_channel_favorite_label_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_favorite_set_t_channel_favorite_label_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_favorite_set_t_channel_favorite_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_favorite_set_t_channel_favorite_uri_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_favorite_set_t_channel_favorite_data_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_favorite_set_t_channel_favorite_data_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_favorite_set_t_channel_favorite_group_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_favorite_set_t_channel_favorite_group_id_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_channel_favorite_set_t();

	public static extern void delete_vx_req_account_channel_favorite_set_t(HandleRef jarg1);

	public static extern int vx_req_account_channel_favorite_set_create(HandleRef jarg1);

	public static extern void vx_req_account_channel_favorite_delete_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_channel_favorite_delete_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_channel_favorite_delete_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_favorite_delete_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_favorite_delete_t_channel_favorite_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_favorite_delete_t_channel_favorite_id_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_channel_favorite_delete_t();

	public static extern void delete_vx_req_account_channel_favorite_delete_t(HandleRef jarg1);

	public static extern int vx_req_account_channel_favorite_delete_create(HandleRef jarg1);

	public static extern void vx_req_account_channel_favorite_group_set_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_channel_favorite_group_set_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_channel_favorite_group_set_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_favorite_group_set_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_favorite_group_set_t_channel_favorite_group_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_favorite_group_set_t_channel_favorite_group_id_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_favorite_group_set_t_channel_favorite_group_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_favorite_group_set_t_channel_favorite_group_name_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_favorite_group_set_t_channel_favorite_group_data_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_favorite_group_set_t_channel_favorite_group_data_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_channel_favorite_group_set_t();

	public static extern void delete_vx_req_account_channel_favorite_group_set_t(HandleRef jarg1);

	public static extern int vx_req_account_channel_favorite_group_set_create(HandleRef jarg1);

	public static extern void vx_req_account_channel_favorite_group_delete_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_channel_favorite_group_delete_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_channel_favorite_group_delete_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_favorite_group_delete_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_favorite_group_delete_t_channel_favorite_group_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_favorite_group_delete_t_channel_favorite_group_id_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_channel_favorite_group_delete_t();

	public static extern void delete_vx_req_account_channel_favorite_group_delete_t(HandleRef jarg1);

	public static extern int vx_req_account_channel_favorite_group_delete_create(HandleRef jarg1);

	public static extern void vx_req_account_channel_get_info_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_channel_get_info_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_channel_get_info_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_get_info_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_get_info_t_channel_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_get_info_t_channel_uri_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_channel_get_info_t();

	public static extern void delete_vx_req_account_channel_get_info_t(HandleRef jarg1);

	public static extern int vx_req_account_channel_get_info_create(HandleRef jarg1);

	public static extern void vx_req_account_channel_search_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_channel_search_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_channel_search_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_search_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_search_t_page_number_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_search_t_page_number_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_search_t_page_size_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_search_t_page_size_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_search_t_channel_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_search_t_channel_name_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_search_t_channel_description_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_search_t_channel_description_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_search_t_channel_active_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_search_t_channel_active_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_search_t_channel_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_search_t_channel_type_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_search_t_moderation_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_search_t_moderation_type_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_search_t_begins_with_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_channel_search_t_begins_with_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_channel_search_t();

	public static extern void delete_vx_req_account_channel_search_t(HandleRef jarg1);

	public static extern int vx_req_account_channel_search_create(HandleRef jarg1);

	public static extern void vx_req_account_buddy_search_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_buddy_search_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_buddy_search_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_buddy_search_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_buddy_search_t_page_number_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_buddy_search_t_page_number_get(HandleRef jarg1);

	public static extern void vx_req_account_buddy_search_t_page_size_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_buddy_search_t_page_size_get(HandleRef jarg1);

	public static extern void vx_req_account_buddy_search_t_buddy_first_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_buddy_search_t_buddy_first_name_get(HandleRef jarg1);

	public static extern void vx_req_account_buddy_search_t_buddy_last_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_buddy_search_t_buddy_last_name_get(HandleRef jarg1);

	public static extern void vx_req_account_buddy_search_t_buddy_user_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_buddy_search_t_buddy_user_name_get(HandleRef jarg1);

	public static extern void vx_req_account_buddy_search_t_buddy_email_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_buddy_search_t_buddy_email_get(HandleRef jarg1);

	public static extern void vx_req_account_buddy_search_t_begins_with_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_buddy_search_t_begins_with_get(HandleRef jarg1);

	public static extern void vx_req_account_buddy_search_t_buddy_display_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_buddy_search_t_buddy_display_name_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_buddy_search_t();

	public static extern void delete_vx_req_account_buddy_search_t(HandleRef jarg1);

	public static extern int vx_req_account_buddy_search_create(HandleRef jarg1);

	public static extern void vx_req_account_channel_add_moderator_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_channel_add_moderator_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_channel_add_moderator_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_add_moderator_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_add_moderator_t_channel_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_add_moderator_t_channel_uri_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_add_moderator_t_channel_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_add_moderator_t_channel_name_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_add_moderator_t_moderator_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_add_moderator_t_moderator_uri_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_channel_add_moderator_t();

	public static extern void delete_vx_req_account_channel_add_moderator_t(HandleRef jarg1);

	public static extern int vx_req_account_channel_add_moderator_create(HandleRef jarg1);

	public static extern void vx_req_account_channel_remove_moderator_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_channel_remove_moderator_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_channel_remove_moderator_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_remove_moderator_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_remove_moderator_t_channel_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_remove_moderator_t_channel_uri_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_remove_moderator_t_channel_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_remove_moderator_t_channel_name_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_remove_moderator_t_moderator_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_remove_moderator_t_moderator_uri_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_channel_remove_moderator_t();

	public static extern void delete_vx_req_account_channel_remove_moderator_t(HandleRef jarg1);

	public static extern int vx_req_account_channel_remove_moderator_create(HandleRef jarg1);

	public static extern void vx_req_account_channel_get_moderators_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_channel_get_moderators_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_channel_get_moderators_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_get_moderators_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_get_moderators_t_channel_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_get_moderators_t_channel_uri_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_channel_get_moderators_t();

	public static extern void delete_vx_req_account_channel_get_moderators_t(HandleRef jarg1);

	public static extern int vx_req_account_channel_get_moderators_create(HandleRef jarg1);

	public static extern void vx_req_account_channel_add_acl_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_channel_add_acl_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_channel_add_acl_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_add_acl_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_add_acl_t_channel_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_add_acl_t_channel_uri_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_add_acl_t_acl_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_add_acl_t_acl_uri_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_channel_add_acl_t();

	public static extern void delete_vx_req_account_channel_add_acl_t(HandleRef jarg1);

	public static extern int vx_req_account_channel_add_acl_create(HandleRef jarg1);

	public static extern void vx_req_account_channel_remove_acl_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_channel_remove_acl_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_channel_remove_acl_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_remove_acl_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_remove_acl_t_channel_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_remove_acl_t_channel_uri_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_remove_acl_t_acl_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_remove_acl_t_acl_uri_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_channel_remove_acl_t();

	public static extern void delete_vx_req_account_channel_remove_acl_t(HandleRef jarg1);

	public static extern int vx_req_account_channel_remove_acl_create(HandleRef jarg1);

	public static extern void vx_req_account_channel_get_acl_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_channel_get_acl_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_channel_get_acl_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_get_acl_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_channel_get_acl_t_channel_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_channel_get_acl_t_channel_uri_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_channel_get_acl_t();

	public static extern void delete_vx_req_account_channel_get_acl_t(HandleRef jarg1);

	public static extern int vx_req_account_channel_get_acl_create(HandleRef jarg1);

	public static extern void vx_req_channel_mute_user_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_channel_mute_user_t_base__get(HandleRef jarg1);

	public static extern void vx_req_channel_mute_user_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_channel_mute_user_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_channel_mute_user_t_channel_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_channel_mute_user_t_channel_name_get(HandleRef jarg1);

	public static extern void vx_req_channel_mute_user_t_channel_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_channel_mute_user_t_channel_uri_get(HandleRef jarg1);

	public static extern void vx_req_channel_mute_user_t_participant_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_channel_mute_user_t_participant_uri_get(HandleRef jarg1);

	public static extern void vx_req_channel_mute_user_t_set_muted_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_channel_mute_user_t_set_muted_get(HandleRef jarg1);

	public static extern void vx_req_channel_mute_user_t_scope_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_channel_mute_user_t_scope_get(HandleRef jarg1);

	public static extern void vx_req_channel_mute_user_t_access_token_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_channel_mute_user_t_access_token_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_channel_mute_user_t();

	public static extern void delete_vx_req_channel_mute_user_t(HandleRef jarg1);

	public static extern int vx_req_channel_mute_user_create(HandleRef jarg1);

	public static extern void vx_req_channel_ban_user_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_channel_ban_user_t_base__get(HandleRef jarg1);

	public static extern void vx_req_channel_ban_user_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_channel_ban_user_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_channel_ban_user_t_channel_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_channel_ban_user_t_channel_name_get(HandleRef jarg1);

	public static extern void vx_req_channel_ban_user_t_channel_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_channel_ban_user_t_channel_uri_get(HandleRef jarg1);

	public static extern void vx_req_channel_ban_user_t_participant_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_channel_ban_user_t_participant_uri_get(HandleRef jarg1);

	public static extern void vx_req_channel_ban_user_t_set_banned_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_channel_ban_user_t_set_banned_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_channel_ban_user_t();

	public static extern void delete_vx_req_channel_ban_user_t(HandleRef jarg1);

	public static extern int vx_req_channel_ban_user_create(HandleRef jarg1);

	public static extern void vx_req_channel_get_banned_users_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_channel_get_banned_users_t_base__get(HandleRef jarg1);

	public static extern void vx_req_channel_get_banned_users_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_channel_get_banned_users_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_channel_get_banned_users_t_channel_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_channel_get_banned_users_t_channel_uri_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_channel_get_banned_users_t();

	public static extern void delete_vx_req_channel_get_banned_users_t(HandleRef jarg1);

	public static extern int vx_req_channel_get_banned_users_create(HandleRef jarg1);

	public static extern void vx_req_channel_kick_user_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_channel_kick_user_t_base__get(HandleRef jarg1);

	public static extern void vx_req_channel_kick_user_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_channel_kick_user_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_channel_kick_user_t_channel_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_channel_kick_user_t_channel_name_get(HandleRef jarg1);

	public static extern void vx_req_channel_kick_user_t_channel_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_channel_kick_user_t_channel_uri_get(HandleRef jarg1);

	public static extern void vx_req_channel_kick_user_t_participant_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_channel_kick_user_t_participant_uri_get(HandleRef jarg1);

	public static extern void vx_req_channel_kick_user_t_access_token_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_channel_kick_user_t_access_token_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_channel_kick_user_t();

	public static extern void delete_vx_req_channel_kick_user_t(HandleRef jarg1);

	public static extern int vx_req_channel_kick_user_create(HandleRef jarg1);

	public static extern void vx_req_channel_mute_all_users_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_channel_mute_all_users_t_base__get(HandleRef jarg1);

	public static extern void vx_req_channel_mute_all_users_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_channel_mute_all_users_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_channel_mute_all_users_t_channel_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_channel_mute_all_users_t_channel_name_get(HandleRef jarg1);

	public static extern void vx_req_channel_mute_all_users_t_channel_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_channel_mute_all_users_t_channel_uri_get(HandleRef jarg1);

	public static extern void vx_req_channel_mute_all_users_t_set_muted_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_channel_mute_all_users_t_set_muted_get(HandleRef jarg1);

	public static extern void vx_req_channel_mute_all_users_t_scope_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_channel_mute_all_users_t_scope_get(HandleRef jarg1);

	public static extern void vx_req_channel_mute_all_users_t_access_token_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_channel_mute_all_users_t_access_token_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_channel_mute_all_users_t();

	public static extern void delete_vx_req_channel_mute_all_users_t(HandleRef jarg1);

	public static extern int vx_req_channel_mute_all_users_create(HandleRef jarg1);

	public static extern void vx_req_channel_set_lock_mode_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_channel_set_lock_mode_t_base__get(HandleRef jarg1);

	public static extern void vx_req_channel_set_lock_mode_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_channel_set_lock_mode_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_channel_set_lock_mode_t_channel_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_channel_set_lock_mode_t_channel_uri_get(HandleRef jarg1);

	public static extern void vx_req_channel_set_lock_mode_t_lock_mode_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_channel_set_lock_mode_t_lock_mode_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_channel_set_lock_mode_t();

	public static extern void delete_vx_req_channel_set_lock_mode_t(HandleRef jarg1);

	public static extern int vx_req_channel_set_lock_mode_create(HandleRef jarg1);

	public static extern void vx_req_connector_mute_local_mic_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_connector_mute_local_mic_t_base__get(HandleRef jarg1);

	public static extern void vx_req_connector_mute_local_mic_t_connector_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_connector_mute_local_mic_t_connector_handle_get(HandleRef jarg1);

	public static extern void vx_req_connector_mute_local_mic_t_mute_level_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_connector_mute_local_mic_t_mute_level_get(HandleRef jarg1);

	public static extern void vx_req_connector_mute_local_mic_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_connector_mute_local_mic_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_connector_mute_local_mic_t();

	public static extern void delete_vx_req_connector_mute_local_mic_t(HandleRef jarg1);

	public static extern int vx_req_connector_mute_local_mic_create(HandleRef jarg1);

	public static extern void vx_req_connector_mute_local_speaker_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_connector_mute_local_speaker_t_base__get(HandleRef jarg1);

	public static extern void vx_req_connector_mute_local_speaker_t_connector_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_connector_mute_local_speaker_t_connector_handle_get(HandleRef jarg1);

	public static extern void vx_req_connector_mute_local_speaker_t_mute_level_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_connector_mute_local_speaker_t_mute_level_get(HandleRef jarg1);

	public static extern void vx_req_connector_mute_local_speaker_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_connector_mute_local_speaker_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_connector_mute_local_speaker_t();

	public static extern void delete_vx_req_connector_mute_local_speaker_t(HandleRef jarg1);

	public static extern int vx_req_connector_mute_local_speaker_create(HandleRef jarg1);

	public static extern void vx_req_connector_set_local_mic_volume_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_connector_set_local_mic_volume_t_base__get(HandleRef jarg1);

	public static extern void vx_req_connector_set_local_mic_volume_t_connector_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_connector_set_local_mic_volume_t_connector_handle_get(HandleRef jarg1);

	public static extern void vx_req_connector_set_local_mic_volume_t_volume_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_connector_set_local_mic_volume_t_volume_get(HandleRef jarg1);

	public static extern void vx_req_connector_set_local_mic_volume_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_connector_set_local_mic_volume_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_connector_set_local_mic_volume_t();

	public static extern void delete_vx_req_connector_set_local_mic_volume_t(HandleRef jarg1);

	public static extern int vx_req_connector_set_local_mic_volume_create(HandleRef jarg1);

	public static extern void vx_req_connector_set_local_speaker_volume_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_connector_set_local_speaker_volume_t_base__get(HandleRef jarg1);

	public static extern void vx_req_connector_set_local_speaker_volume_t_connector_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_connector_set_local_speaker_volume_t_connector_handle_get(HandleRef jarg1);

	public static extern void vx_req_connector_set_local_speaker_volume_t_volume_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_connector_set_local_speaker_volume_t_volume_get(HandleRef jarg1);

	public static extern void vx_req_connector_set_local_speaker_volume_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_connector_set_local_speaker_volume_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_connector_set_local_speaker_volume_t();

	public static extern void delete_vx_req_connector_set_local_speaker_volume_t(HandleRef jarg1);

	public static extern int vx_req_connector_set_local_speaker_volume_create(HandleRef jarg1);

	public static extern void vx_req_connector_get_local_audio_info_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_connector_get_local_audio_info_t_base__get(HandleRef jarg1);

	public static extern void vx_req_connector_get_local_audio_info_t_connector_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_connector_get_local_audio_info_t_connector_handle_get(HandleRef jarg1);

	public static extern void vx_req_connector_get_local_audio_info_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_connector_get_local_audio_info_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_connector_get_local_audio_info_t();

	public static extern void delete_vx_req_connector_get_local_audio_info_t(HandleRef jarg1);

	public static extern int vx_req_connector_get_local_audio_info_create(HandleRef jarg1);

	public static extern void vx_req_account_buddy_set_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_buddy_set_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_buddy_set_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_buddy_set_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_buddy_set_t_buddy_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_buddy_set_t_buddy_uri_get(HandleRef jarg1);

	public static extern void vx_req_account_buddy_set_t_display_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_buddy_set_t_display_name_get(HandleRef jarg1);

	public static extern void vx_req_account_buddy_set_t_buddy_data_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_buddy_set_t_buddy_data_get(HandleRef jarg1);

	public static extern void vx_req_account_buddy_set_t_group_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_buddy_set_t_group_id_get(HandleRef jarg1);

	public static extern void vx_req_account_buddy_set_t_message_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_buddy_set_t_message_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_buddy_set_t();

	public static extern void delete_vx_req_account_buddy_set_t(HandleRef jarg1);

	public static extern int vx_req_account_buddy_set_create(HandleRef jarg1);

	public static extern void vx_req_account_buddy_delete_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_buddy_delete_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_buddy_delete_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_buddy_delete_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_buddy_delete_t_buddy_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_buddy_delete_t_buddy_uri_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_buddy_delete_t();

	public static extern void delete_vx_req_account_buddy_delete_t(HandleRef jarg1);

	public static extern int vx_req_account_buddy_delete_create(HandleRef jarg1);

	public static extern void vx_req_account_buddygroup_set_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_buddygroup_set_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_buddygroup_set_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_buddygroup_set_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_buddygroup_set_t_group_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_buddygroup_set_t_group_id_get(HandleRef jarg1);

	public static extern void vx_req_account_buddygroup_set_t_group_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_buddygroup_set_t_group_name_get(HandleRef jarg1);

	public static extern void vx_req_account_buddygroup_set_t_group_data_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_buddygroup_set_t_group_data_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_buddygroup_set_t();

	public static extern void delete_vx_req_account_buddygroup_set_t(HandleRef jarg1);

	public static extern int vx_req_account_buddygroup_set_create(HandleRef jarg1);

	public static extern void vx_req_account_buddygroup_delete_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_buddygroup_delete_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_buddygroup_delete_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_buddygroup_delete_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_buddygroup_delete_t_group_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_buddygroup_delete_t_group_id_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_buddygroup_delete_t();

	public static extern void delete_vx_req_account_buddygroup_delete_t(HandleRef jarg1);

	public static extern int vx_req_account_buddygroup_delete_create(HandleRef jarg1);

	public static extern void vx_req_account_list_buddies_and_groups_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_list_buddies_and_groups_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_list_buddies_and_groups_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_list_buddies_and_groups_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_list_buddies_and_groups_t_refresh_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_list_buddies_and_groups_t_refresh_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_list_buddies_and_groups_t();

	public static extern void delete_vx_req_account_list_buddies_and_groups_t(HandleRef jarg1);

	public static extern int vx_req_account_list_buddies_and_groups_create(HandleRef jarg1);

	public static extern void vx_req_session_send_message_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_send_message_t_base__get(HandleRef jarg1);

	public static extern void vx_req_session_send_message_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_send_message_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_req_session_send_message_t_message_header_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_send_message_t_message_header_get(HandleRef jarg1);

	public static extern void vx_req_session_send_message_t_message_body_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_send_message_t_message_body_get(HandleRef jarg1);

	public static extern void vx_req_session_send_message_t_language_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_send_message_t_language_get(HandleRef jarg1);

	public static extern void vx_req_session_send_message_t_application_stanza_namespace_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_send_message_t_application_stanza_namespace_get(HandleRef jarg1);

	public static extern void vx_req_session_send_message_t_application_stanza_body_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_send_message_t_application_stanza_body_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_session_send_message_t();

	public static extern void delete_vx_req_session_send_message_t(HandleRef jarg1);

	public static extern int vx_req_session_send_message_create(HandleRef jarg1);

	public static extern void vx_req_session_archive_query_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_archive_query_t_base__get(HandleRef jarg1);

	public static extern void vx_req_session_archive_query_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_archive_query_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_req_session_archive_query_t_time_start_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_archive_query_t_time_start_get(HandleRef jarg1);

	public static extern void vx_req_session_archive_query_t_time_end_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_archive_query_t_time_end_get(HandleRef jarg1);

	public static extern void vx_req_session_archive_query_t_search_text_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_archive_query_t_search_text_get(HandleRef jarg1);

	public static extern void vx_req_session_archive_query_t_participant_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_archive_query_t_participant_uri_get(HandleRef jarg1);

	public static extern void vx_req_session_archive_query_t_max_set(HandleRef jarg1, uint jarg2);

	public static extern uint vx_req_session_archive_query_t_max_get(HandleRef jarg1);

	public static extern void vx_req_session_archive_query_t_before_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_archive_query_t_before_id_get(HandleRef jarg1);

	public static extern void vx_req_session_archive_query_t_after_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_archive_query_t_after_id_get(HandleRef jarg1);

	public static extern void vx_req_session_archive_query_t_first_message_index_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_archive_query_t_first_message_index_get(HandleRef jarg1);

	public static extern void vx_req_session_archive_query_t_application_stanza_namespace_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_archive_query_t_application_stanza_namespace_get(HandleRef jarg1);

	public static extern void vx_req_session_archive_query_t_application_stanza_body_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_archive_query_t_application_stanza_body_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_session_archive_query_t();

	public static extern void delete_vx_req_session_archive_query_t(HandleRef jarg1);

	public static extern int vx_req_session_archive_query_create(HandleRef jarg1);

	public static extern void vx_req_account_set_presence_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_set_presence_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_set_presence_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_set_presence_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_set_presence_t_presence_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_set_presence_t_presence_get(HandleRef jarg1);

	public static extern void vx_req_account_set_presence_t_custom_message_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_set_presence_t_custom_message_get(HandleRef jarg1);

	public static extern void vx_req_account_set_presence_t_alias_username_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_set_presence_t_alias_username_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_set_presence_t();

	public static extern void delete_vx_req_account_set_presence_t(HandleRef jarg1);

	public static extern int vx_req_account_set_presence_create(HandleRef jarg1);

	public static extern void vx_req_account_send_subscription_reply_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_send_subscription_reply_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_send_subscription_reply_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_send_subscription_reply_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_send_subscription_reply_t_rule_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_send_subscription_reply_t_rule_type_get(HandleRef jarg1);

	public static extern void vx_req_account_send_subscription_reply_t_auto_accept_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_send_subscription_reply_t_auto_accept_get(HandleRef jarg1);

	public static extern void vx_req_account_send_subscription_reply_t_buddy_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_send_subscription_reply_t_buddy_uri_get(HandleRef jarg1);

	public static extern void vx_req_account_send_subscription_reply_t_subscription_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_send_subscription_reply_t_subscription_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_send_subscription_reply_t();

	public static extern void delete_vx_req_account_send_subscription_reply_t(HandleRef jarg1);

	public static extern int vx_req_account_send_subscription_reply_create(HandleRef jarg1);

	public static extern void vx_req_session_send_notification_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_send_notification_t_base__get(HandleRef jarg1);

	public static extern void vx_req_session_send_notification_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_send_notification_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_req_session_send_notification_t_notification_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_send_notification_t_notification_type_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_session_send_notification_t();

	public static extern void delete_vx_req_session_send_notification_t(HandleRef jarg1);

	public static extern int vx_req_session_send_notification_create(HandleRef jarg1);

	public static extern void vx_req_session_send_dtmf_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_send_dtmf_t_base__get(HandleRef jarg1);

	public static extern void vx_req_session_send_dtmf_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_send_dtmf_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_req_session_send_dtmf_t_dtmf_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_send_dtmf_t_dtmf_type_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_session_send_dtmf_t();

	public static extern void delete_vx_req_session_send_dtmf_t(HandleRef jarg1);

	public static extern int vx_req_session_send_dtmf_create(HandleRef jarg1);

	public static extern void vx_req_account_create_block_rule_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_create_block_rule_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_create_block_rule_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_create_block_rule_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_create_block_rule_t_block_mask_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_create_block_rule_t_block_mask_get(HandleRef jarg1);

	public static extern void vx_req_account_create_block_rule_t_presence_only_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_create_block_rule_t_presence_only_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_create_block_rule_t();

	public static extern void delete_vx_req_account_create_block_rule_t(HandleRef jarg1);

	public static extern int vx_req_account_create_block_rule_create(HandleRef jarg1);

	public static extern void vx_req_account_delete_block_rule_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_delete_block_rule_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_delete_block_rule_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_delete_block_rule_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_delete_block_rule_t_block_mask_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_delete_block_rule_t_block_mask_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_delete_block_rule_t();

	public static extern void delete_vx_req_account_delete_block_rule_t(HandleRef jarg1);

	public static extern int vx_req_account_delete_block_rule_create(HandleRef jarg1);

	public static extern void vx_req_account_list_block_rules_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_list_block_rules_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_list_block_rules_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_list_block_rules_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_list_block_rules_t_refresh_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_list_block_rules_t_refresh_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_list_block_rules_t();

	public static extern void delete_vx_req_account_list_block_rules_t(HandleRef jarg1);

	public static extern int vx_req_account_list_block_rules_create(HandleRef jarg1);

	public static extern void vx_req_account_create_auto_accept_rule_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_create_auto_accept_rule_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_create_auto_accept_rule_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_create_auto_accept_rule_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_create_auto_accept_rule_t_auto_accept_mask_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_create_auto_accept_rule_t_auto_accept_mask_get(HandleRef jarg1);

	public static extern void vx_req_account_create_auto_accept_rule_t_auto_add_as_buddy_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_create_auto_accept_rule_t_auto_add_as_buddy_get(HandleRef jarg1);

	public static extern void vx_req_account_create_auto_accept_rule_t_auto_accept_nickname_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_create_auto_accept_rule_t_auto_accept_nickname_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_create_auto_accept_rule_t();

	public static extern void delete_vx_req_account_create_auto_accept_rule_t(HandleRef jarg1);

	public static extern int vx_req_account_create_auto_accept_rule_create(HandleRef jarg1);

	public static extern void vx_req_account_delete_auto_accept_rule_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_delete_auto_accept_rule_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_delete_auto_accept_rule_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_delete_auto_accept_rule_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_delete_auto_accept_rule_t_auto_accept_mask_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_delete_auto_accept_rule_t_auto_accept_mask_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_delete_auto_accept_rule_t();

	public static extern void delete_vx_req_account_delete_auto_accept_rule_t(HandleRef jarg1);

	public static extern int vx_req_account_delete_auto_accept_rule_create(HandleRef jarg1);

	public static extern void vx_req_account_list_auto_accept_rules_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_list_auto_accept_rules_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_list_auto_accept_rules_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_list_auto_accept_rules_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_list_auto_accept_rules_t();

	public static extern void delete_vx_req_account_list_auto_accept_rules_t(HandleRef jarg1);

	public static extern int vx_req_account_list_auto_accept_rules_create(HandleRef jarg1);

	public static extern void vx_req_account_update_account_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_update_account_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_update_account_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_update_account_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_update_account_t_displayname_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_update_account_t_displayname_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_update_account_t();

	public static extern void delete_vx_req_account_update_account_t(HandleRef jarg1);

	public static extern int vx_req_account_update_account_create(HandleRef jarg1);

	public static extern void vx_req_account_get_account_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_get_account_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_get_account_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_get_account_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_get_account_t_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_get_account_t_uri_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_get_account_t();

	public static extern void delete_vx_req_account_get_account_t(HandleRef jarg1);

	public static extern int vx_req_account_get_account_create(HandleRef jarg1);

	public static extern void vx_req_account_send_sms_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_send_sms_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_send_sms_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_send_sms_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_send_sms_t_recipient_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_send_sms_t_recipient_uri_get(HandleRef jarg1);

	public static extern void vx_req_account_send_sms_t_content_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_send_sms_t_content_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_send_sms_t();

	public static extern void delete_vx_req_account_send_sms_t(HandleRef jarg1);

	public static extern int vx_req_account_send_sms_create(HandleRef jarg1);

	public static extern void vx_req_aux_connectivity_info_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_connectivity_info_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_connectivity_info_t_well_known_ip_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_connectivity_info_t_well_known_ip_get(HandleRef jarg1);

	public static extern void vx_req_aux_connectivity_info_t_stun_server_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_connectivity_info_t_stun_server_get(HandleRef jarg1);

	public static extern void vx_req_aux_connectivity_info_t_echo_server_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_connectivity_info_t_echo_server_get(HandleRef jarg1);

	public static extern void vx_req_aux_connectivity_info_t_echo_port_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_aux_connectivity_info_t_echo_port_get(HandleRef jarg1);

	public static extern void vx_req_aux_connectivity_info_t_timeout_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_aux_connectivity_info_t_timeout_get(HandleRef jarg1);

	public static extern void vx_req_aux_connectivity_info_t_acct_mgmt_server_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_connectivity_info_t_acct_mgmt_server_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_connectivity_info_t();

	public static extern void delete_vx_req_aux_connectivity_info_t(HandleRef jarg1);

	public static extern int vx_req_aux_connectivity_info_create(HandleRef jarg1);

	public static extern void vx_req_aux_get_render_devices_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_get_render_devices_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_get_render_devices_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_get_render_devices_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_get_render_devices_t();

	public static extern void delete_vx_req_aux_get_render_devices_t(HandleRef jarg1);

	public static extern int vx_req_aux_get_render_devices_create(HandleRef jarg1);

	public static extern void vx_req_aux_get_capture_devices_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_get_capture_devices_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_get_capture_devices_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_get_capture_devices_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_get_capture_devices_t();

	public static extern void delete_vx_req_aux_get_capture_devices_t(HandleRef jarg1);

	public static extern int vx_req_aux_get_capture_devices_create(HandleRef jarg1);

	public static extern void vx_req_aux_set_render_device_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_set_render_device_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_set_render_device_t_render_device_specifier_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_set_render_device_t_render_device_specifier_get(HandleRef jarg1);

	public static extern void vx_req_aux_set_render_device_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_set_render_device_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_set_render_device_t();

	public static extern void delete_vx_req_aux_set_render_device_t(HandleRef jarg1);

	public static extern int vx_req_aux_set_render_device_create(HandleRef jarg1);

	public static extern void vx_req_aux_set_capture_device_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_set_capture_device_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_set_capture_device_t_capture_device_specifier_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_set_capture_device_t_capture_device_specifier_get(HandleRef jarg1);

	public static extern void vx_req_aux_set_capture_device_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_set_capture_device_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_set_capture_device_t();

	public static extern void delete_vx_req_aux_set_capture_device_t(HandleRef jarg1);

	public static extern int vx_req_aux_set_capture_device_create(HandleRef jarg1);

	public static extern void vx_req_aux_get_mic_level_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_get_mic_level_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_get_mic_level_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_get_mic_level_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_get_mic_level_t();

	public static extern void delete_vx_req_aux_get_mic_level_t(HandleRef jarg1);

	public static extern int vx_req_aux_get_mic_level_create(HandleRef jarg1);

	public static extern void vx_req_aux_get_speaker_level_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_get_speaker_level_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_get_speaker_level_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_get_speaker_level_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_get_speaker_level_t();

	public static extern void delete_vx_req_aux_get_speaker_level_t(HandleRef jarg1);

	public static extern int vx_req_aux_get_speaker_level_create(HandleRef jarg1);

	public static extern void vx_req_aux_set_mic_level_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_set_mic_level_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_set_mic_level_t_level_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_aux_set_mic_level_t_level_get(HandleRef jarg1);

	public static extern void vx_req_aux_set_mic_level_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_set_mic_level_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_set_mic_level_t();

	public static extern void delete_vx_req_aux_set_mic_level_t(HandleRef jarg1);

	public static extern int vx_req_aux_set_mic_level_create(HandleRef jarg1);

	public static extern void vx_req_aux_set_speaker_level_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_set_speaker_level_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_set_speaker_level_t_level_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_aux_set_speaker_level_t_level_get(HandleRef jarg1);

	public static extern void vx_req_aux_set_speaker_level_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_set_speaker_level_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_set_speaker_level_t();

	public static extern void delete_vx_req_aux_set_speaker_level_t(HandleRef jarg1);

	public static extern int vx_req_aux_set_speaker_level_create(HandleRef jarg1);

	public static extern void vx_req_aux_render_audio_start_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_render_audio_start_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_render_audio_start_t_sound_file_path_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_render_audio_start_t_sound_file_path_get(HandleRef jarg1);

	public static extern void vx_req_aux_render_audio_start_t_loop_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_aux_render_audio_start_t_loop_get(HandleRef jarg1);

	public static extern void vx_req_aux_render_audio_start_t_path_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_render_audio_start_t_path_get(HandleRef jarg1);

	public static extern void vx_req_aux_render_audio_start_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_render_audio_start_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_render_audio_start_t();

	public static extern void delete_vx_req_aux_render_audio_start_t(HandleRef jarg1);

	public static extern int vx_req_aux_render_audio_start_create(HandleRef jarg1);

	public static extern void vx_req_aux_render_audio_modify_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_render_audio_modify_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_render_audio_modify_t_font_str_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_render_audio_modify_t_font_str_get(HandleRef jarg1);

	public static extern void vx_req_aux_render_audio_modify_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_render_audio_modify_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_render_audio_modify_t();

	public static extern void delete_vx_req_aux_render_audio_modify_t(HandleRef jarg1);

	public static extern int vx_req_aux_render_audio_modify_create(HandleRef jarg1);

	public static extern void vx_req_aux_get_vad_properties_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_get_vad_properties_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_get_vad_properties_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_get_vad_properties_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_get_vad_properties_t();

	public static extern void delete_vx_req_aux_get_vad_properties_t(HandleRef jarg1);

	public static extern int vx_req_aux_get_vad_properties_create(HandleRef jarg1);

	public static extern void vx_req_aux_set_vad_properties_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_set_vad_properties_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_set_vad_properties_t_vad_hangover_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_aux_set_vad_properties_t_vad_hangover_get(HandleRef jarg1);

	public static extern void vx_req_aux_set_vad_properties_t_vad_sensitivity_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_aux_set_vad_properties_t_vad_sensitivity_get(HandleRef jarg1);

	public static extern void vx_req_aux_set_vad_properties_t_vad_noise_floor_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_aux_set_vad_properties_t_vad_noise_floor_get(HandleRef jarg1);

	public static extern void vx_req_aux_set_vad_properties_t_vad_auto_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_aux_set_vad_properties_t_vad_auto_get(HandleRef jarg1);

	public static extern void vx_req_aux_set_vad_properties_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_set_vad_properties_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_set_vad_properties_t();

	public static extern void delete_vx_req_aux_set_vad_properties_t(HandleRef jarg1);

	public static extern int vx_req_aux_set_vad_properties_create(HandleRef jarg1);

	public static extern void vx_req_aux_get_derumbler_properties_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_get_derumbler_properties_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_get_derumbler_properties_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_get_derumbler_properties_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_get_derumbler_properties_t();

	public static extern void delete_vx_req_aux_get_derumbler_properties_t(HandleRef jarg1);

	public static extern int vx_req_aux_get_derumbler_properties_create(HandleRef jarg1);

	public static extern void vx_req_aux_set_derumbler_properties_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_set_derumbler_properties_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_set_derumbler_properties_t_enabled_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_aux_set_derumbler_properties_t_enabled_get(HandleRef jarg1);

	public static extern void vx_req_aux_set_derumbler_properties_t_stopband_corner_frequency_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_aux_set_derumbler_properties_t_stopband_corner_frequency_get(HandleRef jarg1);

	public static extern void vx_req_aux_set_derumbler_properties_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_set_derumbler_properties_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_set_derumbler_properties_t();

	public static extern void delete_vx_req_aux_set_derumbler_properties_t(HandleRef jarg1);

	public static extern int vx_req_aux_set_derumbler_properties_create(HandleRef jarg1);

	public static extern void vx_req_aux_render_audio_stop_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_render_audio_stop_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_render_audio_stop_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_render_audio_stop_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_render_audio_stop_t();

	public static extern void delete_vx_req_aux_render_audio_stop_t(HandleRef jarg1);

	public static extern int vx_req_aux_render_audio_stop_create(HandleRef jarg1);

	public static extern void vx_req_aux_capture_audio_start_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_capture_audio_start_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_capture_audio_start_t_duration_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_aux_capture_audio_start_t_duration_get(HandleRef jarg1);

	public static extern void vx_req_aux_capture_audio_start_t_loop_to_render_device_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_aux_capture_audio_start_t_loop_to_render_device_get(HandleRef jarg1);

	public static extern void vx_req_aux_capture_audio_start_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_capture_audio_start_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_capture_audio_start_t();

	public static extern void delete_vx_req_aux_capture_audio_start_t(HandleRef jarg1);

	public static extern int vx_req_aux_capture_audio_start_create(HandleRef jarg1);

	public static extern void vx_req_aux_capture_audio_stop_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_capture_audio_stop_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_capture_audio_stop_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_capture_audio_stop_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_capture_audio_stop_t();

	public static extern void delete_vx_req_aux_capture_audio_stop_t(HandleRef jarg1);

	public static extern int vx_req_aux_capture_audio_stop_create(HandleRef jarg1);

	public static extern void vx_req_account_get_session_fonts_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_get_session_fonts_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_get_session_fonts_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_get_session_fonts_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_get_session_fonts_t();

	public static extern void delete_vx_req_account_get_session_fonts_t(HandleRef jarg1);

	public static extern int vx_req_account_get_session_fonts_create(HandleRef jarg1);

	public static extern void vx_req_account_get_template_fonts_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_get_template_fonts_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_get_template_fonts_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_get_template_fonts_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_get_template_fonts_t();

	public static extern void delete_vx_req_account_get_template_fonts_t(HandleRef jarg1);

	public static extern int vx_req_account_get_template_fonts_create(HandleRef jarg1);

	public static extern void vx_req_aux_start_buffer_capture_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_start_buffer_capture_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_start_buffer_capture_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_start_buffer_capture_t_account_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_start_buffer_capture_t();

	public static extern void delete_vx_req_aux_start_buffer_capture_t(HandleRef jarg1);

	public static extern int vx_req_aux_start_buffer_capture_create(HandleRef jarg1);

	public static extern void vx_req_aux_play_audio_buffer_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_play_audio_buffer_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_play_audio_buffer_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_play_audio_buffer_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_aux_play_audio_buffer_t_template_font_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_aux_play_audio_buffer_t_template_font_id_get(HandleRef jarg1);

	public static extern void vx_req_aux_play_audio_buffer_t_font_delta_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_play_audio_buffer_t_font_delta_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_play_audio_buffer_t();

	public static extern void delete_vx_req_aux_play_audio_buffer_t(HandleRef jarg1);

	public static extern int vx_req_aux_play_audio_buffer_create(HandleRef jarg1);

	public static extern void vx_req_aux_global_monitor_keyboard_mouse_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_global_monitor_keyboard_mouse_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_global_monitor_keyboard_mouse_t_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_global_monitor_keyboard_mouse_t_name_get(HandleRef jarg1);

	public static extern void vx_req_aux_global_monitor_keyboard_mouse_t_code_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_aux_global_monitor_keyboard_mouse_t_code_count_get(HandleRef jarg1);

	public static extern void vx_req_aux_global_monitor_keyboard_mouse_t_codes_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_global_monitor_keyboard_mouse_t_codes_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_global_monitor_keyboard_mouse_t();

	public static extern void delete_vx_req_aux_global_monitor_keyboard_mouse_t(HandleRef jarg1);

	public static extern int vx_req_aux_global_monitor_keyboard_mouse_create(HandleRef jarg1);

	public static extern void vx_req_aux_set_idle_timeout_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_set_idle_timeout_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_set_idle_timeout_t_seconds_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_aux_set_idle_timeout_t_seconds_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_set_idle_timeout_t();

	public static extern void delete_vx_req_aux_set_idle_timeout_t(HandleRef jarg1);

	public static extern int vx_req_aux_set_idle_timeout_create(HandleRef jarg1);

	public static extern void vx_generic_credentials_admin_username_set(HandleRef jarg1, string jarg2);

	public static extern string vx_generic_credentials_admin_username_get(HandleRef jarg1);

	public static extern void vx_generic_credentials_admin_password_set(HandleRef jarg1, string jarg2);

	public static extern string vx_generic_credentials_admin_password_get(HandleRef jarg1);

	public static extern void vx_generic_credentials_grant_document_set(HandleRef jarg1, string jarg2);

	public static extern string vx_generic_credentials_grant_document_get(HandleRef jarg1);

	public static extern void vx_generic_credentials_server_url_set(HandleRef jarg1, string jarg2);

	public static extern string vx_generic_credentials_server_url_get(HandleRef jarg1);

	public static extern IntPtr new_vx_generic_credentials();

	public static extern void delete_vx_generic_credentials(HandleRef jarg1);

	public static extern void vx_req_aux_create_account_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_create_account_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_create_account_t_credentials_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_create_account_t_credentials_get(HandleRef jarg1);

	public static extern void vx_req_aux_create_account_t_user_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_create_account_t_user_name_get(HandleRef jarg1);

	public static extern void vx_req_aux_create_account_t_password_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_create_account_t_password_get(HandleRef jarg1);

	public static extern void vx_req_aux_create_account_t_email_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_create_account_t_email_get(HandleRef jarg1);

	public static extern void vx_req_aux_create_account_t_number_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_create_account_t_number_get(HandleRef jarg1);

	public static extern void vx_req_aux_create_account_t_displayname_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_create_account_t_displayname_get(HandleRef jarg1);

	public static extern void vx_req_aux_create_account_t_firstname_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_create_account_t_firstname_get(HandleRef jarg1);

	public static extern void vx_req_aux_create_account_t_lastname_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_create_account_t_lastname_get(HandleRef jarg1);

	public static extern void vx_req_aux_create_account_t_phone_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_create_account_t_phone_get(HandleRef jarg1);

	public static extern void vx_req_aux_create_account_t_lang_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_create_account_t_lang_get(HandleRef jarg1);

	public static extern void vx_req_aux_create_account_t_age_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_create_account_t_age_get(HandleRef jarg1);

	public static extern void vx_req_aux_create_account_t_gender_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_create_account_t_gender_get(HandleRef jarg1);

	public static extern void vx_req_aux_create_account_t_timezone_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_create_account_t_timezone_get(HandleRef jarg1);

	public static extern void vx_req_aux_create_account_t_ext_profile_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_create_account_t_ext_profile_get(HandleRef jarg1);

	public static extern void vx_req_aux_create_account_t_ext_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_create_account_t_ext_id_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_create_account_t();

	public static extern void delete_vx_req_aux_create_account_t(HandleRef jarg1);

	public static extern int vx_req_aux_create_account_create(HandleRef jarg1);

	public static extern void vx_req_aux_reactivate_account_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_reactivate_account_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_reactivate_account_t_credentials_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_reactivate_account_t_credentials_get(HandleRef jarg1);

	public static extern void vx_req_aux_reactivate_account_t_user_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_reactivate_account_t_user_name_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_reactivate_account_t();

	public static extern void delete_vx_req_aux_reactivate_account_t(HandleRef jarg1);

	public static extern int vx_req_aux_reactivate_account_create(HandleRef jarg1);

	public static extern void vx_req_aux_deactivate_account_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_deactivate_account_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_deactivate_account_t_credentials_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_deactivate_account_t_credentials_get(HandleRef jarg1);

	public static extern void vx_req_aux_deactivate_account_t_user_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_deactivate_account_t_user_name_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_deactivate_account_t();

	public static extern void delete_vx_req_aux_deactivate_account_t(HandleRef jarg1);

	public static extern int vx_req_aux_deactivate_account_create(HandleRef jarg1);

	public static extern void vx_req_account_post_crash_dump_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_post_crash_dump_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_post_crash_dump_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_post_crash_dump_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_post_crash_dump_t_crash_dump_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_post_crash_dump_t_crash_dump_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_post_crash_dump_t();

	public static extern void delete_vx_req_account_post_crash_dump_t(HandleRef jarg1);

	public static extern int vx_req_account_post_crash_dump_create(HandleRef jarg1);

	public static extern void vx_req_aux_reset_password_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_reset_password_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_reset_password_t_user_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_reset_password_t_user_uri_get(HandleRef jarg1);

	public static extern void vx_req_aux_reset_password_t_user_email_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_reset_password_t_user_email_get(HandleRef jarg1);

	public static extern void vx_req_aux_reset_password_t_server_url_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_aux_reset_password_t_server_url_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_reset_password_t();

	public static extern void delete_vx_req_aux_reset_password_t(HandleRef jarg1);

	public static extern int vx_req_aux_reset_password_create(HandleRef jarg1);

	public static extern void vx_req_aux_diagnostic_state_dump_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_diagnostic_state_dump_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_diagnostic_state_dump_t_level_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_aux_diagnostic_state_dump_t_level_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_diagnostic_state_dump_t();

	public static extern void delete_vx_req_aux_diagnostic_state_dump_t(HandleRef jarg1);

	public static extern int vx_req_aux_diagnostic_state_dump_create(HandleRef jarg1);

	public static extern void vx_req_account_web_call_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_web_call_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_web_call_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_web_call_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_web_call_t_relative_path_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_web_call_t_relative_path_get(HandleRef jarg1);

	public static extern void vx_req_account_web_call_t_parameter_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_web_call_t_parameter_count_get(HandleRef jarg1);

	public static extern void vx_req_account_web_call_t_parameters_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_web_call_t_parameters_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_web_call_t();

	public static extern void delete_vx_req_account_web_call_t(HandleRef jarg1);

	public static extern int vx_req_account_web_call_create(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_get_stats_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_sessiongroup_get_stats_t_base__get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_get_stats_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_sessiongroup_get_stats_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_req_sessiongroup_get_stats_t_reset_stats_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_sessiongroup_get_stats_t_reset_stats_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_sessiongroup_get_stats_t();

	public static extern void delete_vx_req_sessiongroup_get_stats_t(HandleRef jarg1);

	public static extern int vx_req_sessiongroup_get_stats_create(HandleRef jarg1);

	public static extern void vx_req_account_send_message_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_send_message_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_send_message_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_send_message_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_send_message_t_user_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_send_message_t_user_uri_get(HandleRef jarg1);

	public static extern void vx_req_account_send_message_t_message_header_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_send_message_t_message_header_get(HandleRef jarg1);

	public static extern void vx_req_account_send_message_t_message_body_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_send_message_t_message_body_get(HandleRef jarg1);

	public static extern void vx_req_account_send_message_t_alias_username_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_send_message_t_alias_username_get(HandleRef jarg1);

	public static extern void vx_req_account_send_message_t_language_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_send_message_t_language_get(HandleRef jarg1);

	public static extern void vx_req_account_send_message_t_application_stanza_namespace_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_send_message_t_application_stanza_namespace_get(HandleRef jarg1);

	public static extern void vx_req_account_send_message_t_application_stanza_body_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_send_message_t_application_stanza_body_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_send_message_t();

	public static extern void delete_vx_req_account_send_message_t(HandleRef jarg1);

	public static extern int vx_req_account_send_message_create(HandleRef jarg1);

	public static extern void vx_req_account_archive_query_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_archive_query_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_archive_query_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_archive_query_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_archive_query_t_time_start_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_archive_query_t_time_start_get(HandleRef jarg1);

	public static extern void vx_req_account_archive_query_t_time_end_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_archive_query_t_time_end_get(HandleRef jarg1);

	public static extern void vx_req_account_archive_query_t_search_text_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_archive_query_t_search_text_get(HandleRef jarg1);

	public static extern void vx_req_account_archive_query_t_channel_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_archive_query_t_channel_uri_get(HandleRef jarg1);

	public static extern void vx_req_account_archive_query_t_participant_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_archive_query_t_participant_uri_get(HandleRef jarg1);

	public static extern void vx_req_account_archive_query_t_max_set(HandleRef jarg1, uint jarg2);

	public static extern uint vx_req_account_archive_query_t_max_get(HandleRef jarg1);

	public static extern void vx_req_account_archive_query_t_before_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_archive_query_t_before_id_get(HandleRef jarg1);

	public static extern void vx_req_account_archive_query_t_after_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_archive_query_t_after_id_get(HandleRef jarg1);

	public static extern void vx_req_account_archive_query_t_first_message_index_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_archive_query_t_first_message_index_get(HandleRef jarg1);

	public static extern void vx_req_account_archive_query_t_application_stanza_namespace_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_archive_query_t_application_stanza_namespace_get(HandleRef jarg1);

	public static extern void vx_req_account_archive_query_t_application_stanza_body_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_archive_query_t_application_stanza_body_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_archive_query_t();

	public static extern void delete_vx_req_account_archive_query_t(HandleRef jarg1);

	public static extern int vx_req_account_archive_query_create(HandleRef jarg1);

	public static extern void vx_req_aux_notify_application_state_change_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_aux_notify_application_state_change_t_base__get(HandleRef jarg1);

	public static extern void vx_req_aux_notify_application_state_change_t_notification_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_aux_notify_application_state_change_t_notification_type_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_aux_notify_application_state_change_t();

	public static extern void delete_vx_req_aux_notify_application_state_change_t(HandleRef jarg1);

	public static extern int vx_req_aux_notify_application_state_change_create(HandleRef jarg1);

	public static extern void vx_req_account_control_communications_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_account_control_communications_t_base__get(HandleRef jarg1);

	public static extern void vx_req_account_control_communications_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_control_communications_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_req_account_control_communications_t_operation_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_control_communications_t_operation_get(HandleRef jarg1);

	public static extern void vx_req_account_control_communications_t_user_uris_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_account_control_communications_t_user_uris_get(HandleRef jarg1);

	public static extern void vx_req_account_control_communications_t_scope_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_account_control_communications_t_scope_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_account_control_communications_t();

	public static extern void delete_vx_req_account_control_communications_t(HandleRef jarg1);

	public static extern int vx_req_account_control_communications_create(HandleRef jarg1);

	public static extern void vx_req_session_transcription_control_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_session_transcription_control_t_base__get(HandleRef jarg1);

	public static extern void vx_req_session_transcription_control_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_transcription_control_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_req_session_transcription_control_t_enable_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_session_transcription_control_t_enable_get(HandleRef jarg1);

	public static extern void vx_req_session_transcription_control_t_access_token_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_session_transcription_control_t_access_token_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_session_transcription_control_t();

	public static extern void delete_vx_req_session_transcription_control_t(HandleRef jarg1);

	public static extern int vx_req_session_transcription_control_create(HandleRef jarg1);

	public static extern int destroy_req(HandleRef jarg1);

	public static extern void vx_resp_connector_create_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_connector_create_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_connector_create_t_connector_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_connector_create_t_connector_handle_get(HandleRef jarg1);

	public static extern void vx_resp_connector_create_t_version_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_connector_create_t_version_id_get(HandleRef jarg1);

	public static extern void vx_resp_connector_create_t_backend_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_connector_create_t_backend_type_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_connector_create_t();

	public static extern void delete_vx_resp_connector_create_t(HandleRef jarg1);

	public static extern void vx_resp_connector_initiate_shutdown_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_connector_initiate_shutdown_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_connector_initiate_shutdown_t_client_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_connector_initiate_shutdown_t_client_name_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_connector_initiate_shutdown_t();

	public static extern void delete_vx_resp_connector_initiate_shutdown_t(HandleRef jarg1);

	public static extern void vx_resp_account_login_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_login_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_account_login_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_account_login_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_resp_account_login_t_account_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_login_t_account_id_get(HandleRef jarg1);

	public static extern void vx_resp_account_login_t_display_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_account_login_t_display_name_get(HandleRef jarg1);

	public static extern void vx_resp_account_login_t_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_account_login_t_uri_get(HandleRef jarg1);

	public static extern void vx_resp_account_login_t_num_aliases_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_login_t_num_aliases_get(HandleRef jarg1);

	public static extern void vx_resp_account_login_t_buddy_list_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_account_login_t_buddy_list_uri_get(HandleRef jarg1);

	public static extern void vx_resp_account_login_t_encoded_uri_with_tag_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_account_login_t_encoded_uri_with_tag_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_login_t();

	public static extern void delete_vx_resp_account_login_t(HandleRef jarg1);

	public static extern void vx_resp_account_authtoken_login_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_authtoken_login_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_account_authtoken_login_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_account_authtoken_login_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_resp_account_authtoken_login_t_account_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_authtoken_login_t_account_id_get(HandleRef jarg1);

	public static extern void vx_resp_account_authtoken_login_t_user_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_account_authtoken_login_t_user_name_get(HandleRef jarg1);

	public static extern void vx_resp_account_authtoken_login_t_display_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_account_authtoken_login_t_display_name_get(HandleRef jarg1);

	public static extern void vx_resp_account_authtoken_login_t_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_account_authtoken_login_t_uri_get(HandleRef jarg1);

	public static extern void vx_resp_account_authtoken_login_t_num_aliases_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_authtoken_login_t_num_aliases_get(HandleRef jarg1);

	public static extern void vx_resp_account_authtoken_login_t_buddy_list_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_account_authtoken_login_t_buddy_list_uri_get(HandleRef jarg1);

	public static extern void vx_resp_account_authtoken_login_t_encoded_uri_with_tag_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_account_authtoken_login_t_encoded_uri_with_tag_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_authtoken_login_t();

	public static extern void delete_vx_resp_account_authtoken_login_t(HandleRef jarg1);

	public static extern void vx_resp_account_anonymous_login_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_anonymous_login_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_account_anonymous_login_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_account_anonymous_login_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_resp_account_anonymous_login_t_account_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_anonymous_login_t_account_id_get(HandleRef jarg1);

	public static extern void vx_resp_account_anonymous_login_t_displayname_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_account_anonymous_login_t_displayname_get(HandleRef jarg1);

	public static extern void vx_resp_account_anonymous_login_t_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_account_anonymous_login_t_uri_get(HandleRef jarg1);

	public static extern void vx_resp_account_anonymous_login_t_encoded_uri_with_tag_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_account_anonymous_login_t_encoded_uri_with_tag_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_anonymous_login_t();

	public static extern void delete_vx_resp_account_anonymous_login_t(HandleRef jarg1);

	public static extern void vx_resp_account_logout_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_logout_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_logout_t();

	public static extern void delete_vx_resp_account_logout_t(HandleRef jarg1);

	public static extern void vx_resp_account_set_login_properties_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_set_login_properties_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_set_login_properties_t();

	public static extern void delete_vx_resp_account_set_login_properties_t(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_create_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_sessiongroup_create_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_create_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_sessiongroup_create_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_sessiongroup_create_t();

	public static extern void delete_vx_resp_sessiongroup_create_t(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_terminate_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_sessiongroup_terminate_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_sessiongroup_terminate_t();

	public static extern void delete_vx_resp_sessiongroup_terminate_t(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_add_session_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_sessiongroup_add_session_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_add_session_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_sessiongroup_add_session_t_session_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_sessiongroup_add_session_t();

	public static extern void delete_vx_resp_sessiongroup_add_session_t(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_remove_session_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_sessiongroup_remove_session_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_sessiongroup_remove_session_t();

	public static extern void delete_vx_resp_sessiongroup_remove_session_t(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_set_focus_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_sessiongroup_set_focus_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_sessiongroup_set_focus_t();

	public static extern void delete_vx_resp_sessiongroup_set_focus_t(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_unset_focus_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_sessiongroup_unset_focus_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_sessiongroup_unset_focus_t();

	public static extern void delete_vx_resp_sessiongroup_unset_focus_t(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_reset_focus_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_sessiongroup_reset_focus_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_sessiongroup_reset_focus_t();

	public static extern void delete_vx_resp_sessiongroup_reset_focus_t(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_set_tx_session_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_sessiongroup_set_tx_session_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_sessiongroup_set_tx_session_t();

	public static extern void delete_vx_resp_sessiongroup_set_tx_session_t(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_set_tx_all_sessions_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_sessiongroup_set_tx_all_sessions_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_sessiongroup_set_tx_all_sessions_t();

	public static extern void delete_vx_resp_sessiongroup_set_tx_all_sessions_t(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_set_tx_no_session_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_sessiongroup_set_tx_no_session_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_sessiongroup_set_tx_no_session_t();

	public static extern void delete_vx_resp_sessiongroup_set_tx_no_session_t(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_set_session_3d_position_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_sessiongroup_set_session_3d_position_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_sessiongroup_set_session_3d_position_t();

	public static extern void delete_vx_resp_sessiongroup_set_session_3d_position_t(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_control_audio_injection_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_sessiongroup_control_audio_injection_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_sessiongroup_control_audio_injection_t();

	public static extern void delete_vx_resp_sessiongroup_control_audio_injection_t(HandleRef jarg1);

	public static extern void vx_resp_session_create_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_session_create_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_session_create_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_session_create_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_resp_session_create_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_session_create_t_session_handle_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_session_create_t();

	public static extern void delete_vx_resp_session_create_t(HandleRef jarg1);

	public static extern void vx_resp_session_media_connect_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_session_media_connect_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_session_media_connect_t();

	public static extern void delete_vx_resp_session_media_connect_t(HandleRef jarg1);

	public static extern void vx_resp_session_media_disconnect_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_session_media_disconnect_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_session_media_disconnect_t();

	public static extern void delete_vx_resp_session_media_disconnect_t(HandleRef jarg1);

	public static extern void vx_resp_session_text_connect_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_session_text_connect_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_session_text_connect_t();

	public static extern void delete_vx_resp_session_text_connect_t(HandleRef jarg1);

	public static extern void vx_resp_session_text_disconnect_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_session_text_disconnect_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_session_text_disconnect_t();

	public static extern void delete_vx_resp_session_text_disconnect_t(HandleRef jarg1);

	public static extern void vx_resp_session_terminate_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_session_terminate_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_session_terminate_t();

	public static extern void delete_vx_resp_session_terminate_t(HandleRef jarg1);

	public static extern void vx_resp_session_mute_local_speaker_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_session_mute_local_speaker_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_session_mute_local_speaker_t();

	public static extern void delete_vx_resp_session_mute_local_speaker_t(HandleRef jarg1);

	public static extern void vx_resp_session_set_local_speaker_volume_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_session_set_local_speaker_volume_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_session_set_local_speaker_volume_t();

	public static extern void delete_vx_resp_session_set_local_speaker_volume_t(HandleRef jarg1);

	public static extern void vx_resp_session_set_local_render_volume_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_session_set_local_render_volume_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_session_set_local_render_volume_t();

	public static extern void delete_vx_resp_session_set_local_render_volume_t(HandleRef jarg1);

	public static extern void vx_resp_session_channel_invite_user_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_session_channel_invite_user_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_session_channel_invite_user_t();

	public static extern void delete_vx_resp_session_channel_invite_user_t(HandleRef jarg1);

	public static extern void vx_resp_session_set_participant_volume_for_me_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_session_set_participant_volume_for_me_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_session_set_participant_volume_for_me_t();

	public static extern void delete_vx_resp_session_set_participant_volume_for_me_t(HandleRef jarg1);

	public static extern void vx_resp_session_set_participant_mute_for_me_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_session_set_participant_mute_for_me_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_session_set_participant_mute_for_me_t();

	public static extern void delete_vx_resp_session_set_participant_mute_for_me_t(HandleRef jarg1);

	public static extern void vx_resp_session_set_3d_position_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_session_set_3d_position_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_session_set_3d_position_t();

	public static extern void delete_vx_resp_session_set_3d_position_t(HandleRef jarg1);

	public static extern void vx_resp_session_set_voice_font_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_session_set_voice_font_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_session_set_voice_font_t();

	public static extern void delete_vx_resp_session_set_voice_font_t(HandleRef jarg1);

	public static extern void vx_resp_account_channel_get_participants_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_channel_get_participants_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_account_channel_get_participants_t_participant_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_channel_get_participants_t_participant_count_get(HandleRef jarg1);

	public static extern void vx_resp_account_channel_get_participants_t_participants_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_channel_get_participants_t_participants_get(HandleRef jarg1);

	public static extern void vx_resp_account_channel_get_participants_t_page_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_channel_get_participants_t_page_get(HandleRef jarg1);

	public static extern void vx_resp_account_channel_get_participants_t_from_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_channel_get_participants_t_from_get(HandleRef jarg1);

	public static extern void vx_resp_account_channel_get_participants_t_to_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_channel_get_participants_t_to_get(HandleRef jarg1);

	public static extern void vx_resp_account_channel_get_participants_t_total_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_channel_get_participants_t_total_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_channel_get_participants_t();

	public static extern void delete_vx_resp_account_channel_get_participants_t(HandleRef jarg1);

	public static extern void vx_resp_account_channel_change_owner_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_channel_change_owner_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_channel_change_owner_t();

	public static extern void delete_vx_resp_account_channel_change_owner_t(HandleRef jarg1);

	public static extern void vx_resp_account_send_user_app_data_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_send_user_app_data_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_send_user_app_data_t();

	public static extern void delete_vx_resp_account_send_user_app_data_t(HandleRef jarg1);

	public static extern void vx_resp_account_channel_create_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_channel_create_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_account_channel_create_t_channel_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_account_channel_create_t_channel_uri_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_channel_create_t();

	public static extern void delete_vx_resp_account_channel_create_t(HandleRef jarg1);

	public static extern void vx_resp_account_channel_update_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_channel_update_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_channel_update_t();

	public static extern void delete_vx_resp_account_channel_update_t(HandleRef jarg1);

	public static extern void vx_resp_account_channel_delete_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_channel_delete_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_channel_delete_t();

	public static extern void delete_vx_resp_account_channel_delete_t(HandleRef jarg1);

	public static extern void vx_resp_account_channel_favorites_get_list_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_channel_favorites_get_list_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_account_channel_favorites_get_list_t_group_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_channel_favorites_get_list_t_group_count_get(HandleRef jarg1);

	public static extern void vx_resp_account_channel_favorites_get_list_t_favorite_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_channel_favorites_get_list_t_favorite_count_get(HandleRef jarg1);

	public static extern void vx_resp_account_channel_favorites_get_list_t_groups_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_channel_favorites_get_list_t_groups_get(HandleRef jarg1);

	public static extern void vx_resp_account_channel_favorites_get_list_t_favorites_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_channel_favorites_get_list_t_favorites_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_channel_favorites_get_list_t();

	public static extern void delete_vx_resp_account_channel_favorites_get_list_t(HandleRef jarg1);

	public static extern void vx_resp_account_channel_favorite_set_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_channel_favorite_set_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_account_channel_favorite_set_t_channel_favorite_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_channel_favorite_set_t_channel_favorite_id_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_channel_favorite_set_t();

	public static extern void delete_vx_resp_account_channel_favorite_set_t(HandleRef jarg1);

	public static extern void vx_resp_account_channel_favorite_delete_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_channel_favorite_delete_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_channel_favorite_delete_t();

	public static extern void delete_vx_resp_account_channel_favorite_delete_t(HandleRef jarg1);

	public static extern void vx_resp_account_channel_favorite_group_set_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_channel_favorite_group_set_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_account_channel_favorite_group_set_t_group_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_channel_favorite_group_set_t_group_id_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_channel_favorite_group_set_t();

	public static extern void delete_vx_resp_account_channel_favorite_group_set_t(HandleRef jarg1);

	public static extern void vx_resp_account_channel_favorite_group_delete_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_channel_favorite_group_delete_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_channel_favorite_group_delete_t();

	public static extern void delete_vx_resp_account_channel_favorite_group_delete_t(HandleRef jarg1);

	public static extern void vx_resp_account_channel_get_info_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_channel_get_info_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_account_channel_get_info_t_channel_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_channel_get_info_t_channel_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_channel_get_info_t();

	public static extern void delete_vx_resp_account_channel_get_info_t(HandleRef jarg1);

	public static extern void vx_resp_account_channel_search_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_channel_search_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_account_channel_search_t_page_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_channel_search_t_page_get(HandleRef jarg1);

	public static extern void vx_resp_account_channel_search_t_from_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_channel_search_t_from_get(HandleRef jarg1);

	public static extern void vx_resp_account_channel_search_t_to_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_channel_search_t_to_get(HandleRef jarg1);

	public static extern void vx_resp_account_channel_search_t_channel_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_channel_search_t_channel_count_get(HandleRef jarg1);

	public static extern void vx_resp_account_channel_search_t_channels_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_channel_search_t_channels_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_channel_search_t();

	public static extern void delete_vx_resp_account_channel_search_t(HandleRef jarg1);

	public static extern void vx_resp_account_buddy_search_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_buddy_search_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_account_buddy_search_t_page_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_buddy_search_t_page_get(HandleRef jarg1);

	public static extern void vx_resp_account_buddy_search_t_from_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_buddy_search_t_from_get(HandleRef jarg1);

	public static extern void vx_resp_account_buddy_search_t_to_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_buddy_search_t_to_get(HandleRef jarg1);

	public static extern void vx_resp_account_buddy_search_t_buddy_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_buddy_search_t_buddy_count_get(HandleRef jarg1);

	public static extern void vx_resp_account_buddy_search_t_buddies_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_buddy_search_t_buddies_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_buddy_search_t();

	public static extern void delete_vx_resp_account_buddy_search_t(HandleRef jarg1);

	public static extern void vx_resp_account_channel_add_moderator_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_channel_add_moderator_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_channel_add_moderator_t();

	public static extern void delete_vx_resp_account_channel_add_moderator_t(HandleRef jarg1);

	public static extern void vx_resp_account_channel_remove_moderator_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_channel_remove_moderator_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_channel_remove_moderator_t();

	public static extern void delete_vx_resp_account_channel_remove_moderator_t(HandleRef jarg1);

	public static extern void vx_resp_account_channel_get_moderators_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_channel_get_moderators_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_account_channel_get_moderators_t_participants_size_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_channel_get_moderators_t_participants_size_get(HandleRef jarg1);

	public static extern void vx_resp_account_channel_get_moderators_t_participants_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_channel_get_moderators_t_participants_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_channel_get_moderators_t();

	public static extern void delete_vx_resp_account_channel_get_moderators_t(HandleRef jarg1);

	public static extern void vx_resp_account_channel_add_acl_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_channel_add_acl_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_channel_add_acl_t();

	public static extern void delete_vx_resp_account_channel_add_acl_t(HandleRef jarg1);

	public static extern void vx_resp_account_channel_remove_acl_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_channel_remove_acl_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_channel_remove_acl_t();

	public static extern void delete_vx_resp_account_channel_remove_acl_t(HandleRef jarg1);

	public static extern void vx_resp_account_channel_get_acl_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_channel_get_acl_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_account_channel_get_acl_t_participants_size_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_channel_get_acl_t_participants_size_get(HandleRef jarg1);

	public static extern void vx_resp_account_channel_get_acl_t_participants_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_channel_get_acl_t_participants_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_channel_get_acl_t();

	public static extern void delete_vx_resp_account_channel_get_acl_t(HandleRef jarg1);

	public static extern void vx_resp_channel_mute_user_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_channel_mute_user_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_channel_mute_user_t();

	public static extern void delete_vx_resp_channel_mute_user_t(HandleRef jarg1);

	public static extern void vx_resp_channel_ban_user_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_channel_ban_user_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_channel_ban_user_t();

	public static extern void delete_vx_resp_channel_ban_user_t(HandleRef jarg1);

	public static extern void vx_resp_channel_get_banned_users_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_channel_get_banned_users_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_channel_get_banned_users_t_banned_users_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_channel_get_banned_users_t_banned_users_count_get(HandleRef jarg1);

	public static extern void vx_resp_channel_get_banned_users_t_banned_users_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_channel_get_banned_users_t_banned_users_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_channel_get_banned_users_t();

	public static extern void delete_vx_resp_channel_get_banned_users_t(HandleRef jarg1);

	public static extern void vx_resp_channel_kick_user_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_channel_kick_user_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_channel_kick_user_t();

	public static extern void delete_vx_resp_channel_kick_user_t(HandleRef jarg1);

	public static extern void vx_resp_channel_mute_all_users_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_channel_mute_all_users_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_channel_mute_all_users_t();

	public static extern void delete_vx_resp_channel_mute_all_users_t(HandleRef jarg1);

	public static extern void vx_resp_channel_set_lock_mode_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_channel_set_lock_mode_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_channel_set_lock_mode_t();

	public static extern void delete_vx_resp_channel_set_lock_mode_t(HandleRef jarg1);

	public static extern void vx_resp_connector_mute_local_mic_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_connector_mute_local_mic_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_connector_mute_local_mic_t();

	public static extern void delete_vx_resp_connector_mute_local_mic_t(HandleRef jarg1);

	public static extern void vx_resp_connector_mute_local_speaker_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_connector_mute_local_speaker_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_connector_mute_local_speaker_t();

	public static extern void delete_vx_resp_connector_mute_local_speaker_t(HandleRef jarg1);

	public static extern void vx_resp_connector_set_local_mic_volume_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_connector_set_local_mic_volume_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_connector_set_local_mic_volume_t();

	public static extern void delete_vx_resp_connector_set_local_mic_volume_t(HandleRef jarg1);

	public static extern void vx_resp_connector_set_local_speaker_volume_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_connector_set_local_speaker_volume_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_connector_set_local_speaker_volume_t();

	public static extern void delete_vx_resp_connector_set_local_speaker_volume_t(HandleRef jarg1);

	public static extern void vx_resp_connector_get_local_audio_info_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_connector_get_local_audio_info_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_connector_get_local_audio_info_t_speaker_volume_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_connector_get_local_audio_info_t_speaker_volume_get(HandleRef jarg1);

	public static extern void vx_resp_connector_get_local_audio_info_t_is_speaker_muted_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_connector_get_local_audio_info_t_is_speaker_muted_get(HandleRef jarg1);

	public static extern void vx_resp_connector_get_local_audio_info_t_mic_volume_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_connector_get_local_audio_info_t_mic_volume_get(HandleRef jarg1);

	public static extern void vx_resp_connector_get_local_audio_info_t_is_mic_muted_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_connector_get_local_audio_info_t_is_mic_muted_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_connector_get_local_audio_info_t();

	public static extern void delete_vx_resp_connector_get_local_audio_info_t(HandleRef jarg1);

	public static extern void vx_resp_account_buddy_set_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_buddy_set_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_account_buddy_set_t_account_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_buddy_set_t_account_id_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_buddy_set_t();

	public static extern void delete_vx_resp_account_buddy_set_t(HandleRef jarg1);

	public static extern void vx_resp_account_buddy_delete_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_buddy_delete_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_buddy_delete_t();

	public static extern void delete_vx_resp_account_buddy_delete_t(HandleRef jarg1);

	public static extern void vx_resp_account_buddygroup_set_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_buddygroup_set_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_account_buddygroup_set_t_group_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_buddygroup_set_t_group_id_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_buddygroup_set_t();

	public static extern void delete_vx_resp_account_buddygroup_set_t(HandleRef jarg1);

	public static extern void vx_resp_account_buddygroup_delete_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_buddygroup_delete_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_buddygroup_delete_t();

	public static extern void delete_vx_resp_account_buddygroup_delete_t(HandleRef jarg1);

	public static extern void vx_resp_account_list_buddies_and_groups_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_list_buddies_and_groups_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_account_list_buddies_and_groups_t_buddy_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_list_buddies_and_groups_t_buddy_count_get(HandleRef jarg1);

	public static extern void vx_resp_account_list_buddies_and_groups_t_group_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_list_buddies_and_groups_t_group_count_get(HandleRef jarg1);

	public static extern void vx_resp_account_list_buddies_and_groups_t_buddies_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_list_buddies_and_groups_t_buddies_get(HandleRef jarg1);

	public static extern void vx_resp_account_list_buddies_and_groups_t_groups_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_list_buddies_and_groups_t_groups_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_list_buddies_and_groups_t();

	public static extern void delete_vx_resp_account_list_buddies_and_groups_t(HandleRef jarg1);

	public static extern void vx_resp_session_send_message_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_session_send_message_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_session_send_message_t();

	public static extern void delete_vx_resp_session_send_message_t(HandleRef jarg1);

	public static extern void vx_resp_session_archive_query_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_session_archive_query_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_session_archive_query_t_query_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_session_archive_query_t_query_id_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_session_archive_query_t();

	public static extern void delete_vx_resp_session_archive_query_t(HandleRef jarg1);

	public static extern void vx_resp_account_set_presence_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_set_presence_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_set_presence_t();

	public static extern void delete_vx_resp_account_set_presence_t(HandleRef jarg1);

	public static extern void vx_resp_account_send_subscription_reply_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_send_subscription_reply_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_send_subscription_reply_t();

	public static extern void delete_vx_resp_account_send_subscription_reply_t(HandleRef jarg1);

	public static extern void vx_resp_session_send_notification_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_session_send_notification_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_session_send_notification_t();

	public static extern void delete_vx_resp_session_send_notification_t(HandleRef jarg1);

	public static extern void vx_resp_session_send_dtmf_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_session_send_dtmf_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_session_send_dtmf_t();

	public static extern void delete_vx_resp_session_send_dtmf_t(HandleRef jarg1);

	public static extern void vx_resp_account_create_block_rule_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_create_block_rule_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_create_block_rule_t();

	public static extern void delete_vx_resp_account_create_block_rule_t(HandleRef jarg1);

	public static extern void vx_resp_account_delete_block_rule_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_delete_block_rule_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_delete_block_rule_t();

	public static extern void delete_vx_resp_account_delete_block_rule_t(HandleRef jarg1);

	public static extern void vx_resp_account_list_block_rules_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_list_block_rules_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_account_list_block_rules_t_rule_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_list_block_rules_t_rule_count_get(HandleRef jarg1);

	public static extern void vx_resp_account_list_block_rules_t_block_rules_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_list_block_rules_t_block_rules_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_list_block_rules_t();

	public static extern void delete_vx_resp_account_list_block_rules_t(HandleRef jarg1);

	public static extern void vx_resp_account_create_auto_accept_rule_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_create_auto_accept_rule_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_create_auto_accept_rule_t();

	public static extern void delete_vx_resp_account_create_auto_accept_rule_t(HandleRef jarg1);

	public static extern void vx_resp_account_delete_auto_accept_rule_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_delete_auto_accept_rule_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_delete_auto_accept_rule_t();

	public static extern void delete_vx_resp_account_delete_auto_accept_rule_t(HandleRef jarg1);

	public static extern void vx_resp_account_list_auto_accept_rules_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_list_auto_accept_rules_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_account_list_auto_accept_rules_t_rule_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_list_auto_accept_rules_t_rule_count_get(HandleRef jarg1);

	public static extern void vx_resp_account_list_auto_accept_rules_t_auto_accept_rules_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_list_auto_accept_rules_t_auto_accept_rules_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_list_auto_accept_rules_t();

	public static extern void delete_vx_resp_account_list_auto_accept_rules_t(HandleRef jarg1);

	public static extern void vx_resp_account_update_account_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_update_account_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_update_account_t();

	public static extern void delete_vx_resp_account_update_account_t(HandleRef jarg1);

	public static extern void vx_resp_account_get_account_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_get_account_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_account_get_account_t_account_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_get_account_t_account_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_get_account_t();

	public static extern void delete_vx_resp_account_get_account_t(HandleRef jarg1);

	public static extern void vx_resp_account_send_sms_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_send_sms_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_send_sms_t();

	public static extern void delete_vx_resp_account_send_sms_t(HandleRef jarg1);

	public static extern void vx_resp_aux_connectivity_info_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_connectivity_info_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_aux_connectivity_info_t_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_aux_connectivity_info_t_count_get(HandleRef jarg1);

	public static extern void vx_resp_aux_connectivity_info_t_test_results_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_connectivity_info_t_test_results_get(HandleRef jarg1);

	public static extern void vx_resp_aux_connectivity_info_t_well_known_ip_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_aux_connectivity_info_t_well_known_ip_get(HandleRef jarg1);

	public static extern void vx_resp_aux_connectivity_info_t_stun_server_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_aux_connectivity_info_t_stun_server_get(HandleRef jarg1);

	public static extern void vx_resp_aux_connectivity_info_t_echo_server_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_aux_connectivity_info_t_echo_server_get(HandleRef jarg1);

	public static extern void vx_resp_aux_connectivity_info_t_echo_port_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_aux_connectivity_info_t_echo_port_get(HandleRef jarg1);

	public static extern void vx_resp_aux_connectivity_info_t_timeout_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_aux_connectivity_info_t_timeout_get(HandleRef jarg1);

	public static extern void vx_resp_aux_connectivity_info_t_first_sip_port_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_aux_connectivity_info_t_first_sip_port_get(HandleRef jarg1);

	public static extern void vx_resp_aux_connectivity_info_t_second_sip_port_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_aux_connectivity_info_t_second_sip_port_get(HandleRef jarg1);

	public static extern void vx_resp_aux_connectivity_info_t_rtp_port_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_aux_connectivity_info_t_rtp_port_get(HandleRef jarg1);

	public static extern void vx_resp_aux_connectivity_info_t_rtcp_port_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_aux_connectivity_info_t_rtcp_port_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_connectivity_info_t();

	public static extern void delete_vx_resp_aux_connectivity_info_t(HandleRef jarg1);

	public static extern void vx_resp_aux_get_render_devices_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_get_render_devices_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_aux_get_render_devices_t_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_aux_get_render_devices_t_count_get(HandleRef jarg1);

	public static extern void vx_resp_aux_get_render_devices_t_render_devices_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_get_render_devices_t_render_devices_get(HandleRef jarg1);

	public static extern void vx_resp_aux_get_render_devices_t_current_render_device_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_get_render_devices_t_current_render_device_get(HandleRef jarg1);

	public static extern void vx_resp_aux_get_render_devices_t_effective_render_device_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_get_render_devices_t_effective_render_device_get(HandleRef jarg1);

	public static extern void vx_resp_aux_get_render_devices_t_default_render_device_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_get_render_devices_t_default_render_device_get(HandleRef jarg1);

	public static extern void vx_resp_aux_get_render_devices_t_default_communication_render_device_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_get_render_devices_t_default_communication_render_device_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_get_render_devices_t();

	public static extern void delete_vx_resp_aux_get_render_devices_t(HandleRef jarg1);

	public static extern void vx_resp_aux_get_capture_devices_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_get_capture_devices_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_aux_get_capture_devices_t_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_aux_get_capture_devices_t_count_get(HandleRef jarg1);

	public static extern void vx_resp_aux_get_capture_devices_t_capture_devices_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_get_capture_devices_t_capture_devices_get(HandleRef jarg1);

	public static extern void vx_resp_aux_get_capture_devices_t_current_capture_device_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_get_capture_devices_t_current_capture_device_get(HandleRef jarg1);

	public static extern void vx_resp_aux_get_capture_devices_t_effective_capture_device_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_get_capture_devices_t_effective_capture_device_get(HandleRef jarg1);

	public static extern void vx_resp_aux_get_capture_devices_t_default_capture_device_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_get_capture_devices_t_default_capture_device_get(HandleRef jarg1);

	public static extern void vx_resp_aux_get_capture_devices_t_default_communication_capture_device_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_get_capture_devices_t_default_communication_capture_device_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_get_capture_devices_t();

	public static extern void delete_vx_resp_aux_get_capture_devices_t(HandleRef jarg1);

	public static extern void vx_resp_aux_set_render_device_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_set_render_device_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_aux_set_render_device_t_open_render_device_guid_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_aux_set_render_device_t_open_render_device_guid_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_set_render_device_t();

	public static extern void delete_vx_resp_aux_set_render_device_t(HandleRef jarg1);

	public static extern void vx_resp_aux_set_capture_device_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_set_capture_device_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_aux_set_capture_device_t_open_capture_device_guid_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_aux_set_capture_device_t_open_capture_device_guid_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_set_capture_device_t();

	public static extern void delete_vx_resp_aux_set_capture_device_t(HandleRef jarg1);

	public static extern void vx_resp_aux_get_mic_level_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_get_mic_level_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_aux_get_mic_level_t_level_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_aux_get_mic_level_t_level_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_get_mic_level_t();

	public static extern void delete_vx_resp_aux_get_mic_level_t(HandleRef jarg1);

	public static extern void vx_resp_aux_get_speaker_level_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_get_speaker_level_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_aux_get_speaker_level_t_level_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_aux_get_speaker_level_t_level_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_get_speaker_level_t();

	public static extern void delete_vx_resp_aux_get_speaker_level_t(HandleRef jarg1);

	public static extern void vx_resp_aux_set_mic_level_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_set_mic_level_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_set_mic_level_t();

	public static extern void delete_vx_resp_aux_set_mic_level_t(HandleRef jarg1);

	public static extern void vx_resp_aux_set_speaker_level_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_set_speaker_level_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_set_speaker_level_t();

	public static extern void delete_vx_resp_aux_set_speaker_level_t(HandleRef jarg1);

	public static extern void vx_resp_aux_render_audio_start_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_render_audio_start_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_render_audio_start_t();

	public static extern void delete_vx_resp_aux_render_audio_start_t(HandleRef jarg1);

	public static extern void vx_resp_aux_render_audio_modify_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_render_audio_modify_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_render_audio_modify_t();

	public static extern void delete_vx_resp_aux_render_audio_modify_t(HandleRef jarg1);

	public static extern void vx_resp_aux_get_vad_properties_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_get_vad_properties_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_aux_get_vad_properties_t_vad_hangover_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_aux_get_vad_properties_t_vad_hangover_get(HandleRef jarg1);

	public static extern void vx_resp_aux_get_vad_properties_t_vad_sensitivity_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_aux_get_vad_properties_t_vad_sensitivity_get(HandleRef jarg1);

	public static extern void vx_resp_aux_get_vad_properties_t_vad_noise_floor_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_aux_get_vad_properties_t_vad_noise_floor_get(HandleRef jarg1);

	public static extern void vx_resp_aux_get_vad_properties_t_vad_auto_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_aux_get_vad_properties_t_vad_auto_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_get_vad_properties_t();

	public static extern void delete_vx_resp_aux_get_vad_properties_t(HandleRef jarg1);

	public static extern void vx_resp_aux_set_vad_properties_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_set_vad_properties_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_set_vad_properties_t();

	public static extern void delete_vx_resp_aux_set_vad_properties_t(HandleRef jarg1);

	public static extern void vx_resp_aux_get_derumbler_properties_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_get_derumbler_properties_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_aux_get_derumbler_properties_t_enabled_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_aux_get_derumbler_properties_t_enabled_get(HandleRef jarg1);

	public static extern void vx_resp_aux_get_derumbler_properties_t_stopband_corner_frequency_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_aux_get_derumbler_properties_t_stopband_corner_frequency_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_get_derumbler_properties_t();

	public static extern void delete_vx_resp_aux_get_derumbler_properties_t(HandleRef jarg1);

	public static extern void vx_resp_aux_set_derumbler_properties_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_set_derumbler_properties_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_set_derumbler_properties_t();

	public static extern void delete_vx_resp_aux_set_derumbler_properties_t(HandleRef jarg1);

	public static extern void vx_resp_aux_render_audio_stop_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_render_audio_stop_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_render_audio_stop_t();

	public static extern void delete_vx_resp_aux_render_audio_stop_t(HandleRef jarg1);

	public static extern void vx_resp_aux_capture_audio_start_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_capture_audio_start_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_capture_audio_start_t();

	public static extern void delete_vx_resp_aux_capture_audio_start_t(HandleRef jarg1);

	public static extern void vx_resp_aux_capture_audio_stop_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_capture_audio_stop_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_aux_capture_audio_stop_t_audioBufferPtr_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_capture_audio_stop_t_audioBufferPtr_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_capture_audio_stop_t();

	public static extern void delete_vx_resp_aux_capture_audio_stop_t(HandleRef jarg1);

	public static extern void vx_resp_aux_global_monitor_keyboard_mouse_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_global_monitor_keyboard_mouse_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_global_monitor_keyboard_mouse_t();

	public static extern void delete_vx_resp_aux_global_monitor_keyboard_mouse_t(HandleRef jarg1);

	public static extern void vx_resp_aux_set_idle_timeout_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_set_idle_timeout_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_set_idle_timeout_t();

	public static extern void delete_vx_resp_aux_set_idle_timeout_t(HandleRef jarg1);

	public static extern void vx_resp_aux_create_account_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_create_account_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_create_account_t();

	public static extern void delete_vx_resp_aux_create_account_t(HandleRef jarg1);

	public static extern void vx_resp_aux_reactivate_account_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_reactivate_account_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_reactivate_account_t();

	public static extern void delete_vx_resp_aux_reactivate_account_t(HandleRef jarg1);

	public static extern void vx_resp_aux_deactivate_account_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_deactivate_account_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_deactivate_account_t();

	public static extern void delete_vx_resp_aux_deactivate_account_t(HandleRef jarg1);

	public static extern void vx_resp_account_post_crash_dump_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_post_crash_dump_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_post_crash_dump_t();

	public static extern void delete_vx_resp_account_post_crash_dump_t(HandleRef jarg1);

	public static extern void vx_resp_aux_reset_password_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_reset_password_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_reset_password_t();

	public static extern void delete_vx_resp_aux_reset_password_t(HandleRef jarg1);

	public static extern void vx_resp_account_get_session_fonts_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_get_session_fonts_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_account_get_session_fonts_t_session_fonts_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_get_session_fonts_t_session_fonts_get(HandleRef jarg1);

	public static extern void vx_resp_account_get_session_fonts_t_session_font_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_get_session_fonts_t_session_font_count_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_get_session_fonts_t();

	public static extern void delete_vx_resp_account_get_session_fonts_t(HandleRef jarg1);

	public static extern void vx_resp_account_get_template_fonts_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_get_template_fonts_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_account_get_template_fonts_t_template_fonts_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_get_template_fonts_t_template_fonts_get(HandleRef jarg1);

	public static extern void vx_resp_account_get_template_fonts_t_template_font_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_get_template_fonts_t_template_font_count_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_get_template_fonts_t();

	public static extern void delete_vx_resp_account_get_template_fonts_t(HandleRef jarg1);

	public static extern void vx_resp_aux_start_buffer_capture_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_start_buffer_capture_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_start_buffer_capture_t();

	public static extern void delete_vx_resp_aux_start_buffer_capture_t(HandleRef jarg1);

	public static extern void vx_resp_aux_play_audio_buffer_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_play_audio_buffer_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_play_audio_buffer_t();

	public static extern void delete_vx_resp_aux_play_audio_buffer_t(HandleRef jarg1);

	public static extern void vx_resp_aux_diagnostic_state_dump_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_diagnostic_state_dump_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_aux_diagnostic_state_dump_t_state_connector_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_aux_diagnostic_state_dump_t_state_connector_count_get(HandleRef jarg1);

	public static extern void vx_resp_aux_diagnostic_state_dump_t_state_connectors_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_diagnostic_state_dump_t_state_connectors_get(HandleRef jarg1);

	public static extern void vx_resp_aux_diagnostic_state_dump_t_current_render_device_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_diagnostic_state_dump_t_current_render_device_get(HandleRef jarg1);

	public static extern void vx_resp_aux_diagnostic_state_dump_t_effective_render_device_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_diagnostic_state_dump_t_effective_render_device_get(HandleRef jarg1);

	public static extern void vx_resp_aux_diagnostic_state_dump_t_current_capture_device_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_diagnostic_state_dump_t_current_capture_device_get(HandleRef jarg1);

	public static extern void vx_resp_aux_diagnostic_state_dump_t_effective_capture_device_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_diagnostic_state_dump_t_effective_capture_device_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_diagnostic_state_dump_t();

	public static extern void delete_vx_resp_aux_diagnostic_state_dump_t(HandleRef jarg1);

	public static extern void vx_resp_account_web_call_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_web_call_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_account_web_call_t_content_type_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_account_web_call_t_content_type_get(HandleRef jarg1);

	public static extern void vx_resp_account_web_call_t_content_length_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_account_web_call_t_content_length_get(HandleRef jarg1);

	public static extern void vx_resp_account_web_call_t_content_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_account_web_call_t_content_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_web_call_t();

	public static extern void delete_vx_resp_account_web_call_t(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_sessiongroup_get_stats_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_insufficient_bandwidth_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_insufficient_bandwidth_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_min_bars_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_min_bars_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_max_bars_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_max_bars_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_current_bars_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_current_bars_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_pk_loss_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_pk_loss_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_incoming_received_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_incoming_received_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_incoming_expected_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_incoming_expected_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_incoming_packetloss_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_incoming_packetloss_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_incoming_out_of_time_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_incoming_out_of_time_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_incoming_discarded_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_incoming_discarded_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_outgoing_sent_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_outgoing_sent_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_render_device_underruns_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_render_device_underruns_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_render_device_overruns_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_render_device_overruns_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_render_device_errors_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_render_device_errors_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_call_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_sessiongroup_get_stats_t_call_id_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_plc_on_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_plc_on_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_plc_synthetic_frames_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_plc_synthetic_frames_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_codec_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_sessiongroup_get_stats_t_codec_name_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_codec_mode_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_codec_mode_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_min_latency_set(HandleRef jarg1, double jarg2);

	public static extern double vx_resp_sessiongroup_get_stats_t_min_latency_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_max_latency_set(HandleRef jarg1, double jarg2);

	public static extern double vx_resp_sessiongroup_get_stats_t_max_latency_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_latency_measurement_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_latency_measurement_count_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_latency_sum_set(HandleRef jarg1, double jarg2);

	public static extern double vx_resp_sessiongroup_get_stats_t_latency_sum_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_last_latency_measured_set(HandleRef jarg1, double jarg2);

	public static extern double vx_resp_sessiongroup_get_stats_t_last_latency_measured_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_latency_packets_lost_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_latency_packets_lost_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_r_factor_set(HandleRef jarg1, double jarg2);

	public static extern double vx_resp_sessiongroup_get_stats_t_r_factor_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_latency_packets_sent_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_latency_packets_sent_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_latency_packets_dropped_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_latency_packets_dropped_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_latency_packets_malformed_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_latency_packets_malformed_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_latency_packets_negative_latency_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_latency_packets_negative_latency_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_sample_interval_begin_set(HandleRef jarg1, double jarg2);

	public static extern double vx_resp_sessiongroup_get_stats_t_sample_interval_begin_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_sample_interval_end_set(HandleRef jarg1, double jarg2);

	public static extern double vx_resp_sessiongroup_get_stats_t_sample_interval_end_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_capture_device_consecutively_read_count_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_sessiongroup_get_stats_t_capture_device_consecutively_read_count_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_current_opus_bit_rate_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_current_opus_bit_rate_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_current_opus_complexity_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_current_opus_complexity_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_current_opus_vbr_mode_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_current_opus_vbr_mode_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_current_opus_bandwidth_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_current_opus_bandwidth_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_current_opus_max_packet_size_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_current_opus_max_packet_size_get(HandleRef jarg1);

	public static extern void vx_resp_sessiongroup_get_stats_t_signal_secure_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_sessiongroup_get_stats_t_signal_secure_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_sessiongroup_get_stats_t();

	public static extern void delete_vx_resp_sessiongroup_get_stats_t(HandleRef jarg1);

	public static extern void vx_resp_account_send_message_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_send_message_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_account_send_message_t_request_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_account_send_message_t_request_id_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_send_message_t();

	public static extern void delete_vx_resp_account_send_message_t(HandleRef jarg1);

	public static extern void vx_resp_account_archive_query_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_archive_query_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_account_archive_query_t_query_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_account_archive_query_t_query_id_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_archive_query_t();

	public static extern void delete_vx_resp_account_archive_query_t(HandleRef jarg1);

	public static extern void vx_resp_aux_notify_application_state_change_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_aux_notify_application_state_change_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_aux_notify_application_state_change_t();

	public static extern void delete_vx_resp_aux_notify_application_state_change_t(HandleRef jarg1);

	public static extern void vx_resp_account_control_communications_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_account_control_communications_t_base__get(HandleRef jarg1);

	public static extern void vx_resp_account_control_communications_t_blocked_uris_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_account_control_communications_t_blocked_uris_get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_account_control_communications_t();

	public static extern void delete_vx_resp_account_control_communications_t(HandleRef jarg1);

	public static extern void vx_resp_session_transcription_control_t_base__set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_session_transcription_control_t_base__get(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_session_transcription_control_t();

	public static extern void delete_vx_resp_session_transcription_control_t(HandleRef jarg1);

	public static extern int destroy_resp(HandleRef jarg1);

	public static extern void send_log(int jarg1, string jarg2, string jarg3);

	public static extern string vx_debug_generate_token(string jarg1, int jarg2, string jarg3, ulong jarg4, string jarg5, string jarg6, string jarg7, string jarg8);

	public static extern IntPtr vx_get_message__SWIG_0();

	public static extern int GetDefaultConfig(HandleRef jarg1);

	public static extern bool IsAudioEchoCancellationEnabled();

	public static extern int IssueRequest(HandleRef jarg1);

	public static extern int Initialize(HandleRef jarg1);

	public static extern int Uninitialize();

	public static extern IntPtr get_device(int jarg1, HandleRef jarg2);

	public static extern IntPtr vx_tts_voice_list_t_Get(HandleRef jarg1, int jarg2);

	public static extern void vx_tts_voice_list_t_Voices_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_tts_voice_list_t_Voices_get(HandleRef jarg1);

	public static extern void vx_tts_voice_list_t_Length_set(HandleRef jarg1, int jarg2);

	public static extern int vx_tts_voice_list_t_Length_get(HandleRef jarg1);

	public static extern IntPtr new_vx_tts_voice_list_t();

	public static extern void delete_vx_tts_voice_list_t(HandleRef jarg1);

	public static extern IntPtr vx_tts_get_voices(uint jarg1);

	public static extern int vx_tts_shutdown__SWIG_0();

	public static extern int vx_tts_shutdown__SWIG_1(uint jarg1);

	public static extern int VIVOX_SDK_HAS_CRASH_REPORTING_get();

	public static extern int VIVOX_SDK_HAS_VOICE_FONTS_get();

	public static extern int VIVOX_SDK_HAS_GROUP_IM_get();

	public static extern int VIVOX_SDK_HAS_MUTE_SCOPE_get();

	public static extern int VIVOX_SDK_HAS_PARTICIPANT_TYPE_get();

	public static extern int VIVOX_SDK_HAS_NETWORK_MESSAGE_get();

	public static extern int VIVOX_SDK_HAS_AUX_DIAGNOSTIC_STATE_get();

	public static extern int VIVOX_SDK_SESSION_RENDER_AUDIO_OBSOLETE_get();

	public static extern int VIVOX_SDK_SESSION_GET_LOCAL_AUDIO_INFO_OBSOLETE_get();

	public static extern int VIVOX_SDK_SESSION_MEDIA_RINGBACK_OBSOLETE_get();

	public static extern int VIVOX_SDK_SESSION_CONNECT_OBSOLETE_get();

	public static extern int VIVOX_SDK_SESSION_CHANNEL_GET_PARTICIPANTS_OBSOLETE_get();

	public static extern int VIVOX_SDK_ACCOUNT_CHANNEL_CREATE_AND_INVITE_OBSOLETE_get();

	public static extern int VIVOX_SDK_EVT_SESSION_PARTICIPANT_LIST_OBSOLETE_get();

	public static extern int VIVOX_SDK_HAS_INTEGRATED_PROXY_get();

	public static extern int VIVOX_SDK_HAS_NO_CHANNEL_FOLDERS_get();

	public static extern int VIVOX_SDK_HAS_NO_SCORE_get();

	public static extern int VIVOX_SDK_HAS_GENERIC_APP_NOTIFICATIONS_ONLY_get();

	public static extern int VIVOX_SDK_HAS_FRAME_TOTALS_get();

	public static extern int VIVOX_SDK_NO_LEGACY_RECORDING_get();

	public static extern int VIVOX_SDK_NO_IS_AD_PLAYING_get();

	public static extern int VIVOX_SDK_HAS_ACCOUNT_SEND_MSG_get();

	public static extern int VIVOX_SDK_HAS_PLC_STATS_get();

	public static extern int VIVOX_SDK_HAS_DEVICE_ADDED_REMOVED_get();

	public static extern int VIVOX_SDK_HAS_ADVANCED_AUDIO_LEVELS_get();

	public static extern int VIVOX_SDK_HAS_AUDIO_UNIT_CALLBACKS_get();

	public static extern int vx_cookie_create(string jarg1, HandleRef jarg2);

	public static extern int vx_cookie_free(HandleRef jarg1);

	public static extern void vx_message_base_t_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_message_base_t_type_get(HandleRef jarg1);

	public static extern void vx_message_base_t_sdk_handle_set(HandleRef jarg1, uint jarg2);

	public static extern uint vx_message_base_t_sdk_handle_get(HandleRef jarg1);

	public static extern void vx_message_base_t_create_time_ms_set(HandleRef jarg1, ulong jarg2);

	public static extern ulong vx_message_base_t_create_time_ms_get(HandleRef jarg1);

	public static extern void vx_message_base_t_last_step_ms_set(HandleRef jarg1, ulong jarg2);

	public static extern ulong vx_message_base_t_last_step_ms_get(HandleRef jarg1);

	public static extern IntPtr vx_message_base_t_as_resp_base(HandleRef jarg1);

	public static extern IntPtr vx_message_base_t_as_evt_base(HandleRef jarg1);

	public static extern void delete_vx_message_base_t(HandleRef jarg1);

	public static extern IntPtr new_vx_message_base_t();

	public static extern void vx_req_base_t_message_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_base_t_message_get(HandleRef jarg1);

	public static extern void vx_req_base_t_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_req_base_t_type_get(HandleRef jarg1);

	public static extern void vx_req_base_t_cookie_set(HandleRef jarg1, string jarg2);

	public static extern string vx_req_base_t_cookie_get(HandleRef jarg1);

	public static extern void vx_req_base_t_vcookie_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_req_base_t_vcookie_get(HandleRef jarg1);

	public static extern IntPtr new_vx_req_base_t();

	public static extern void delete_vx_req_base_t(HandleRef jarg1);

	public static extern void vx_resp_base_t_message_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_base_t_message_get(HandleRef jarg1);

	public static extern void vx_resp_base_t_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_base_t_type_get(HandleRef jarg1);

	public static extern void vx_resp_base_t_return_code_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_base_t_return_code_get(HandleRef jarg1);

	public static extern void vx_resp_base_t_status_code_set(HandleRef jarg1, int jarg2);

	public static extern int vx_resp_base_t_status_code_get(HandleRef jarg1);

	public static extern void vx_resp_base_t_status_string_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_base_t_status_string_get(HandleRef jarg1);

	public static extern void vx_resp_base_t_request_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_resp_base_t_request_get(HandleRef jarg1);

	public static extern void vx_resp_base_t_extended_status_info_set(HandleRef jarg1, string jarg2);

	public static extern string vx_resp_base_t_extended_status_info_get(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_connector_create(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_connector_initiate_shutdown(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_login(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_authtoken_login(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_anonymous_login(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_logout(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_set_login_properties(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_sessiongroup_create(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_sessiongroup_terminate(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_sessiongroup_add_session(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_sessiongroup_remove_session(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_sessiongroup_set_focus(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_sessiongroup_unset_focus(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_sessiongroup_reset_focus(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_sessiongroup_set_tx_session(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_sessiongroup_set_tx_all_sessions(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_sessiongroup_set_tx_no_session(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_sessiongroup_set_session_3d_position(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_sessiongroup_control_audio_injection(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_session_create(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_session_media_connect(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_session_media_disconnect(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_session_text_connect(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_session_text_disconnect(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_session_terminate(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_session_mute_local_speaker(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_session_set_local_speaker_volume(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_session_set_local_render_volume(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_session_channel_invite_user(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_session_set_participant_volume_for_me(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_session_set_participant_mute_for_me(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_session_set_3d_position(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_session_set_voice_font(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_channel_get_participants(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_channel_change_owner(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_send_user_app_data(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_channel_create(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_channel_update(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_channel_delete(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_channel_favorites_get_list(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_channel_favorite_set(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_channel_favorite_delete(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_channel_favorite_group_set(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_channel_favorite_group_delete(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_channel_get_info(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_channel_search(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_buddy_search(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_channel_add_moderator(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_channel_remove_moderator(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_channel_get_moderators(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_channel_add_acl(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_channel_remove_acl(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_channel_get_acl(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_channel_mute_user(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_channel_ban_user(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_channel_get_banned_users(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_channel_kick_user(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_channel_mute_all_users(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_channel_set_lock_mode(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_connector_mute_local_mic(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_connector_mute_local_speaker(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_connector_set_local_mic_volume(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_connector_set_local_speaker_volume(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_connector_get_local_audio_info(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_buddy_set(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_buddy_delete(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_buddygroup_set(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_buddygroup_delete(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_list_buddies_and_groups(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_session_send_message(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_session_archive_query(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_set_presence(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_send_subscription_reply(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_session_send_notification(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_session_send_dtmf(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_create_block_rule(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_delete_block_rule(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_list_block_rules(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_create_auto_accept_rule(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_delete_auto_accept_rule(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_list_auto_accept_rules(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_update_account(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_get_account(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_send_sms(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_connectivity_info(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_get_render_devices(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_get_capture_devices(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_set_render_device(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_set_capture_device(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_get_mic_level(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_get_speaker_level(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_set_mic_level(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_set_speaker_level(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_render_audio_start(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_render_audio_modify(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_get_vad_properties(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_set_vad_properties(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_get_derumbler_properties(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_set_derumbler_properties(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_render_audio_stop(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_capture_audio_start(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_capture_audio_stop(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_global_monitor_keyboard_mouse(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_set_idle_timeout(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_create_account(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_reactivate_account(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_deactivate_account(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_post_crash_dump(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_reset_password(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_get_session_fonts(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_get_template_fonts(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_start_buffer_capture(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_play_audio_buffer(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_diagnostic_state_dump(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_web_call(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_sessiongroup_get_stats(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_send_message(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_archive_query(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_aux_notify_application_state_change(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_account_control_communications(HandleRef jarg1);

	public static extern IntPtr vx_resp_base_t_as_vx_resp_session_transcription_control(HandleRef jarg1);

	public static extern IntPtr new_vx_resp_base_t();

	public static extern void delete_vx_resp_base_t(HandleRef jarg1);

	public static extern void vx_evt_base_t_message_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_evt_base_t_message_get(HandleRef jarg1);

	public static extern void vx_evt_base_t_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_evt_base_t_type_get(HandleRef jarg1);

	public static extern void vx_evt_base_t_extended_status_info_set(HandleRef jarg1, string jarg2);

	public static extern string vx_evt_base_t_extended_status_info_get(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_account_login_state_change(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_buddy_presence(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_subscription(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_session_notification(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_message(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_session_archive_message(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_transcribed_message(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_session_archive_query_end(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_aux_audio_properties(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_buddy_changed(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_buddy_group_changed(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_buddy_and_group_list_changed(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_keyboard_mouse(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_idle_state_changed(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_media_stream_updated(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_text_stream_updated(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_sessiongroup_added(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_sessiongroup_removed(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_session_added(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_session_removed(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_participant_added(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_participant_removed(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_participant_updated(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_sessiongroup_playback_frame_played(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_session_updated(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_sessiongroup_updated(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_media_completion(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_server_app_data(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_user_app_data(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_network_message(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_voice_service_connection_state_changed(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_publication_state_changed(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_audio_device_hot_swap(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_user_to_user_message(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_account_archive_message(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_account_archive_query_end(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_account_send_message_failed(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_tts_injection_started(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_tts_injection_ended(HandleRef jarg1);

	public static extern IntPtr vx_evt_base_t_as_vx_evt_tts_injection_failed(HandleRef jarg1);

	public static extern void delete_vx_evt_base_t(HandleRef jarg1);

	public static extern IntPtr new_vx_evt_base_t();

	public static extern int VX_MEDIA_FLAGS_AUDIO_get();

	public static extern int VX_MEDIA_FLAGS_TEXT_get();

	public static extern void vx_state_buddy_contact_t_presence_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_buddy_contact_t_presence_get(HandleRef jarg1);

	public static extern void vx_state_buddy_contact_t_display_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_state_buddy_contact_t_display_name_get(HandleRef jarg1);

	public static extern void vx_state_buddy_contact_t_application_set(HandleRef jarg1, string jarg2);

	public static extern string vx_state_buddy_contact_t_application_get(HandleRef jarg1);

	public static extern void vx_state_buddy_contact_t_custom_message_set(HandleRef jarg1, string jarg2);

	public static extern string vx_state_buddy_contact_t_custom_message_get(HandleRef jarg1);

	public static extern void vx_state_buddy_contact_t_contact_set(HandleRef jarg1, string jarg2);

	public static extern string vx_state_buddy_contact_t_contact_get(HandleRef jarg1);

	public static extern void vx_state_buddy_contact_t_priority_set(HandleRef jarg1, string jarg2);

	public static extern string vx_state_buddy_contact_t_priority_get(HandleRef jarg1);

	public static extern void vx_state_buddy_contact_t_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_state_buddy_contact_t_id_get(HandleRef jarg1);

	public static extern IntPtr new_vx_state_buddy_contact_t();

	public static extern void delete_vx_state_buddy_contact_t(HandleRef jarg1);

	public static extern int vx_state_buddy_contact_create(HandleRef jarg1);

	public static extern int vx_state_buddy_contact_free(HandleRef jarg1);

	public static extern int vx_state_buddy_contact_list_create(int jarg1, HandleRef jarg2);

	public static extern int vx_state_buddy_contact_list_free(HandleRef jarg1, int jarg2);

	public static extern void vx_state_buddy_t_buddy_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_state_buddy_t_buddy_uri_get(HandleRef jarg1);

	public static extern void vx_state_buddy_t_display_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_state_buddy_t_display_name_get(HandleRef jarg1);

	public static extern void vx_state_buddy_t_parent_group_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_buddy_t_parent_group_id_get(HandleRef jarg1);

	public static extern void vx_state_buddy_t_buddy_data_set(HandleRef jarg1, string jarg2);

	public static extern string vx_state_buddy_t_buddy_data_get(HandleRef jarg1);

	public static extern void vx_state_buddy_t_state_buddy_contact_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_buddy_t_state_buddy_contact_count_get(HandleRef jarg1);

	public static extern void vx_state_buddy_t_state_buddy_contacts_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_state_buddy_t_state_buddy_contacts_get(HandleRef jarg1);

	public static extern IntPtr new_vx_state_buddy_t();

	public static extern void delete_vx_state_buddy_t(HandleRef jarg1);

	public static extern int vx_state_buddy_create(HandleRef jarg1);

	public static extern int vx_state_buddy_free(HandleRef jarg1);

	public static extern int vx_state_buddy_list_create(int jarg1, HandleRef jarg2);

	public static extern int vx_state_buddy_list_free(HandleRef jarg1, int jarg2);

	public static extern void vx_state_buddy_group_t_group_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_buddy_group_t_group_id_get(HandleRef jarg1);

	public static extern void vx_state_buddy_group_t_group_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_state_buddy_group_t_group_name_get(HandleRef jarg1);

	public static extern void vx_state_buddy_group_t_group_data_set(HandleRef jarg1, string jarg2);

	public static extern string vx_state_buddy_group_t_group_data_get(HandleRef jarg1);

	public static extern IntPtr new_vx_state_buddy_group_t();

	public static extern void delete_vx_state_buddy_group_t(HandleRef jarg1);

	public static extern int vx_state_buddy_group_create(HandleRef jarg1);

	public static extern int vx_state_buddy_group_free(HandleRef jarg1);

	public static extern int vx_state_buddy_group_list_create(int jarg1, HandleRef jarg2);

	public static extern int vx_state_buddy_group_list_free(HandleRef jarg1, int jarg2);

	public static extern void vx_participant_t_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_participant_t_uri_get(HandleRef jarg1);

	public static extern void vx_participant_t_first_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_participant_t_first_name_get(HandleRef jarg1);

	public static extern void vx_participant_t_last_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_participant_t_last_name_get(HandleRef jarg1);

	public static extern void vx_participant_t_display_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_participant_t_display_name_get(HandleRef jarg1);

	public static extern void vx_participant_t_username_set(HandleRef jarg1, string jarg2);

	public static extern string vx_participant_t_username_get(HandleRef jarg1);

	public static extern void vx_participant_t_is_moderator_set(HandleRef jarg1, int jarg2);

	public static extern int vx_participant_t_is_moderator_get(HandleRef jarg1);

	public static extern void vx_participant_t_is_moderator_muted_set(HandleRef jarg1, int jarg2);

	public static extern int vx_participant_t_is_moderator_muted_get(HandleRef jarg1);

	public static extern void vx_participant_t_is_moderator_text_muted_set(HandleRef jarg1, int jarg2);

	public static extern int vx_participant_t_is_moderator_text_muted_get(HandleRef jarg1);

	public static extern void vx_participant_t_is_muted_for_me_set(HandleRef jarg1, int jarg2);

	public static extern int vx_participant_t_is_muted_for_me_get(HandleRef jarg1);

	public static extern void vx_participant_t_is_owner_set(HandleRef jarg1, int jarg2);

	public static extern int vx_participant_t_is_owner_get(HandleRef jarg1);

	public static extern void vx_participant_t_account_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_participant_t_account_id_get(HandleRef jarg1);

	public static extern IntPtr new_vx_participant_t();

	public static extern void delete_vx_participant_t(HandleRef jarg1);

	public static extern int vx_participant_create(HandleRef jarg1);

	public static extern int vx_participant_free(HandleRef jarg1);

	public static extern int vx_participant_list_create(int jarg1, HandleRef jarg2);

	public static extern int vx_participant_list_free(HandleRef jarg1, int jarg2);

	public static extern void vx_state_participant_t_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_state_participant_t_uri_get(HandleRef jarg1);

	public static extern void vx_state_participant_t_display_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_state_participant_t_display_name_get(HandleRef jarg1);

	public static extern void vx_state_participant_t_is_audio_enabled_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_participant_t_is_audio_enabled_get(HandleRef jarg1);

	public static extern void vx_state_participant_t_is_text_enabled_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_participant_t_is_text_enabled_get(HandleRef jarg1);

	public static extern void vx_state_participant_t_is_audio_muted_for_me_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_participant_t_is_audio_muted_for_me_get(HandleRef jarg1);

	public static extern void vx_state_participant_t_is_text_muted_for_me_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_participant_t_is_text_muted_for_me_get(HandleRef jarg1);

	public static extern void vx_state_participant_t_is_audio_moderator_muted_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_participant_t_is_audio_moderator_muted_get(HandleRef jarg1);

	public static extern void vx_state_participant_t_is_text_moderator_muted_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_participant_t_is_text_moderator_muted_get(HandleRef jarg1);

	public static extern void vx_state_participant_t_is_hand_raised_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_participant_t_is_hand_raised_get(HandleRef jarg1);

	public static extern void vx_state_participant_t_is_typing_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_participant_t_is_typing_get(HandleRef jarg1);

	public static extern void vx_state_participant_t_is_speaking_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_participant_t_is_speaking_get(HandleRef jarg1);

	public static extern void vx_state_participant_t_volume_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_participant_t_volume_get(HandleRef jarg1);

	public static extern void vx_state_participant_t_energy_set(HandleRef jarg1, double jarg2);

	public static extern double vx_state_participant_t_energy_get(HandleRef jarg1);

	public static extern void vx_state_participant_t_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_participant_t_type_get(HandleRef jarg1);

	public static extern void vx_state_participant_t_is_anonymous_login_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_participant_t_is_anonymous_login_get(HandleRef jarg1);

	public static extern IntPtr new_vx_state_participant_t();

	public static extern void delete_vx_state_participant_t(HandleRef jarg1);

	public static extern int vx_state_participant_create(HandleRef jarg1);

	public static extern int vx_state_participant_free(HandleRef jarg1);

	public static extern int vx_state_participant_list_create(int jarg1, HandleRef jarg2);

	public static extern int vx_state_participant_list_free(HandleRef jarg1, int jarg2);

	public static extern void vx_state_session_t_session_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_state_session_t_session_handle_get(HandleRef jarg1);

	public static extern void vx_state_session_t_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_state_session_t_uri_get(HandleRef jarg1);

	public static extern void vx_state_session_t_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_state_session_t_name_get(HandleRef jarg1);

	public static extern void vx_state_session_t_is_audio_muted_for_me_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_session_t_is_audio_muted_for_me_get(HandleRef jarg1);

	public static extern void vx_state_session_t_is_text_muted_for_me_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_session_t_is_text_muted_for_me_get(HandleRef jarg1);

	public static extern void vx_state_session_t_is_transmitting_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_session_t_is_transmitting_get(HandleRef jarg1);

	public static extern void vx_state_session_t_is_focused_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_session_t_is_focused_get(HandleRef jarg1);

	public static extern void vx_state_session_t_volume_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_session_t_volume_get(HandleRef jarg1);

	public static extern void vx_state_session_t_session_font_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_session_t_session_font_id_get(HandleRef jarg1);

	public static extern void vx_state_session_t_has_audio_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_session_t_has_audio_get(HandleRef jarg1);

	public static extern void vx_state_session_t_has_text_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_session_t_has_text_get(HandleRef jarg1);

	public static extern void vx_state_session_t_is_incoming_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_session_t_is_incoming_get(HandleRef jarg1);

	public static extern void vx_state_session_t_is_positional_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_session_t_is_positional_get(HandleRef jarg1);

	public static extern void vx_state_session_t_is_connected_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_session_t_is_connected_get(HandleRef jarg1);

	public static extern void vx_state_session_t_state_participant_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_session_t_state_participant_count_get(HandleRef jarg1);

	public static extern void vx_state_session_t_state_participants_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_state_session_t_state_participants_get(HandleRef jarg1);

	public static extern void vx_state_session_t_durable_media_id_set(HandleRef jarg1, string jarg2);

	public static extern string vx_state_session_t_durable_media_id_get(HandleRef jarg1);

	public static extern IntPtr new_vx_state_session_t();

	public static extern void delete_vx_state_session_t(HandleRef jarg1);

	public static extern int vx_state_session_create(HandleRef jarg1);

	public static extern int vx_state_session_free(HandleRef jarg1);

	public static extern int vx_state_session_list_create(int jarg1, HandleRef jarg2);

	public static extern int vx_state_session_list_free(HandleRef jarg1, int jarg2);

	public static extern void vx_state_sessiongroup_t_sessiongroup_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_state_sessiongroup_t_sessiongroup_handle_get(HandleRef jarg1);

	public static extern void vx_state_sessiongroup_t_state_sessions_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_sessiongroup_t_state_sessions_count_get(HandleRef jarg1);

	public static extern void vx_state_sessiongroup_t_state_sessions_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_state_sessiongroup_t_state_sessions_get(HandleRef jarg1);

	public static extern void vx_state_sessiongroup_t_in_delayed_playback_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_sessiongroup_t_in_delayed_playback_get(HandleRef jarg1);

	public static extern void vx_state_sessiongroup_t_current_playback_speed_set(HandleRef jarg1, double jarg2);

	public static extern double vx_state_sessiongroup_t_current_playback_speed_get(HandleRef jarg1);

	public static extern void vx_state_sessiongroup_t_current_playback_mode_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_sessiongroup_t_current_playback_mode_get(HandleRef jarg1);

	public static extern void vx_state_sessiongroup_t_playback_paused_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_sessiongroup_t_playback_paused_get(HandleRef jarg1);

	public static extern void vx_state_sessiongroup_t_loop_buffer_capacity_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_sessiongroup_t_loop_buffer_capacity_get(HandleRef jarg1);

	public static extern void vx_state_sessiongroup_t_first_loop_frame_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_sessiongroup_t_first_loop_frame_get(HandleRef jarg1);

	public static extern void vx_state_sessiongroup_t_total_loop_frames_captured_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_sessiongroup_t_total_loop_frames_captured_get(HandleRef jarg1);

	public static extern void vx_state_sessiongroup_t_last_loop_frame_played_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_sessiongroup_t_last_loop_frame_played_get(HandleRef jarg1);

	public static extern void vx_state_sessiongroup_t_current_recording_filename_set(HandleRef jarg1, string jarg2);

	public static extern string vx_state_sessiongroup_t_current_recording_filename_get(HandleRef jarg1);

	public static extern void vx_state_sessiongroup_t_total_recorded_frames_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_sessiongroup_t_total_recorded_frames_get(HandleRef jarg1);

	public static extern IntPtr new_vx_state_sessiongroup_t();

	public static extern void delete_vx_state_sessiongroup_t(HandleRef jarg1);

	public static extern int vx_state_sessiongroup_create(HandleRef jarg1);

	public static extern int vx_state_sessiongroup_free(HandleRef jarg1);

	public static extern int vx_state_sessiongroup_list_create(int jarg1, HandleRef jarg2);

	public static extern int vx_state_sessiongroup_list_free(HandleRef jarg1, int jarg2);

	public static extern void vx_state_account_t_account_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_state_account_t_account_handle_get(HandleRef jarg1);

	public static extern void vx_state_account_t_account_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_state_account_t_account_uri_get(HandleRef jarg1);

	public static extern void vx_state_account_t_display_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_state_account_t_display_name_get(HandleRef jarg1);

	public static extern void vx_state_account_t_is_anonymous_login_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_account_t_is_anonymous_login_get(HandleRef jarg1);

	public static extern void vx_state_account_t_state_sessiongroups_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_account_t_state_sessiongroups_count_get(HandleRef jarg1);

	public static extern void vx_state_account_t_state_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_account_t_state_get(HandleRef jarg1);

	public static extern void vx_state_account_t_state_sessiongroups_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_state_account_t_state_sessiongroups_get(HandleRef jarg1);

	public static extern void vx_state_account_t_state_buddy_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_account_t_state_buddy_count_get(HandleRef jarg1);

	public static extern void vx_state_account_t_state_buddy_group_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_account_t_state_buddy_group_count_get(HandleRef jarg1);

	public static extern void vx_state_account_t_state_buddies_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_state_account_t_state_buddies_get(HandleRef jarg1);

	public static extern void vx_state_account_t_state_buddy_groups_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_state_account_t_state_buddy_groups_get(HandleRef jarg1);

	public static extern IntPtr new_vx_state_account_t();

	public static extern void delete_vx_state_account_t(HandleRef jarg1);

	public static extern int vx_state_account_create(HandleRef jarg1);

	public static extern int vx_state_account_free(HandleRef jarg1);

	public static extern int vx_state_account_list_create(int jarg1, HandleRef jarg2);

	public static extern int vx_state_account_list_free(HandleRef jarg1, int jarg2);

	public static extern void vx_state_connector_t_connector_handle_set(HandleRef jarg1, string jarg2);

	public static extern string vx_state_connector_t_connector_handle_get(HandleRef jarg1);

	public static extern void vx_state_connector_t_state_accounts_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_connector_t_state_accounts_count_get(HandleRef jarg1);

	public static extern void vx_state_connector_t_state_accounts_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_state_connector_t_state_accounts_get(HandleRef jarg1);

	public static extern void vx_state_connector_t_mic_vol_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_connector_t_mic_vol_get(HandleRef jarg1);

	public static extern void vx_state_connector_t_mic_mute_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_connector_t_mic_mute_get(HandleRef jarg1);

	public static extern void vx_state_connector_t_speaker_vol_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_connector_t_speaker_vol_get(HandleRef jarg1);

	public static extern void vx_state_connector_t_speaker_mute_set(HandleRef jarg1, int jarg2);

	public static extern int vx_state_connector_t_speaker_mute_get(HandleRef jarg1);

	public static extern IntPtr new_vx_state_connector_t();

	public static extern void delete_vx_state_connector_t(HandleRef jarg1);

	public static extern int vx_state_connector_create(HandleRef jarg1);

	public static extern int vx_state_connector_free(HandleRef jarg1);

	public static extern int vx_state_connector_list_create(int jarg1, HandleRef jarg2);

	public static extern int vx_state_connector_list_free(HandleRef jarg1, int jarg2);

	public static extern void vx_channel_t_channel_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_channel_t_channel_name_get(HandleRef jarg1);

	public static extern void vx_channel_t_channel_desc_set(HandleRef jarg1, string jarg2);

	public static extern string vx_channel_t_channel_desc_get(HandleRef jarg1);

	public static extern void vx_channel_t_host_set(HandleRef jarg1, string jarg2);

	public static extern string vx_channel_t_host_get(HandleRef jarg1);

	public static extern void vx_channel_t_channel_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_channel_t_channel_id_get(HandleRef jarg1);

	public static extern void vx_channel_t_limit_set(HandleRef jarg1, int jarg2);

	public static extern int vx_channel_t_limit_get(HandleRef jarg1);

	public static extern void vx_channel_t_capacity_set(HandleRef jarg1, int jarg2);

	public static extern int vx_channel_t_capacity_get(HandleRef jarg1);

	public static extern void vx_channel_t_modified_set(HandleRef jarg1, string jarg2);

	public static extern string vx_channel_t_modified_get(HandleRef jarg1);

	public static extern void vx_channel_t_owner_set(HandleRef jarg1, string jarg2);

	public static extern string vx_channel_t_owner_get(HandleRef jarg1);

	public static extern void vx_channel_t_owner_user_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_channel_t_owner_user_name_get(HandleRef jarg1);

	public static extern void vx_channel_t_is_persistent_set(HandleRef jarg1, int jarg2);

	public static extern int vx_channel_t_is_persistent_get(HandleRef jarg1);

	public static extern void vx_channel_t_is_protected_set(HandleRef jarg1, int jarg2);

	public static extern int vx_channel_t_is_protected_get(HandleRef jarg1);

	public static extern void vx_channel_t_size_set(HandleRef jarg1, int jarg2);

	public static extern int vx_channel_t_size_get(HandleRef jarg1);

	public static extern void vx_channel_t_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_channel_t_type_get(HandleRef jarg1);

	public static extern void vx_channel_t_mode_set(HandleRef jarg1, int jarg2);

	public static extern int vx_channel_t_mode_get(HandleRef jarg1);

	public static extern void vx_channel_t_channel_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_channel_t_channel_uri_get(HandleRef jarg1);

	public static extern void vx_channel_t_max_range_set(HandleRef jarg1, int jarg2);

	public static extern int vx_channel_t_max_range_get(HandleRef jarg1);

	public static extern void vx_channel_t_clamping_dist_set(HandleRef jarg1, int jarg2);

	public static extern int vx_channel_t_clamping_dist_get(HandleRef jarg1);

	public static extern void vx_channel_t_roll_off_set(HandleRef jarg1, double jarg2);

	public static extern double vx_channel_t_roll_off_get(HandleRef jarg1);

	public static extern void vx_channel_t_max_gain_set(HandleRef jarg1, double jarg2);

	public static extern double vx_channel_t_max_gain_get(HandleRef jarg1);

	public static extern void vx_channel_t_dist_model_set(HandleRef jarg1, int jarg2);

	public static extern int vx_channel_t_dist_model_get(HandleRef jarg1);

	public static extern void vx_channel_t_encrypt_audio_set(HandleRef jarg1, int jarg2);

	public static extern int vx_channel_t_encrypt_audio_get(HandleRef jarg1);

	public static extern void vx_channel_t_owner_display_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_channel_t_owner_display_name_get(HandleRef jarg1);

	public static extern void vx_channel_t_active_participants_set(HandleRef jarg1, int jarg2);

	public static extern int vx_channel_t_active_participants_get(HandleRef jarg1);

	public static extern IntPtr new_vx_channel_t();

	public static extern void delete_vx_channel_t(HandleRef jarg1);

	public static extern int vx_channel_create(HandleRef jarg1);

	public static extern int vx_channel_free(HandleRef jarg1);

	public static extern int vx_channel_list_create(int jarg1, HandleRef jarg2);

	public static extern int vx_channel_list_free(HandleRef jarg1, int jarg2);

	public static extern void vx_channel_favorite_t_favorite_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_channel_favorite_t_favorite_id_get(HandleRef jarg1);

	public static extern void vx_channel_favorite_t_favorite_group_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_channel_favorite_t_favorite_group_id_get(HandleRef jarg1);

	public static extern void vx_channel_favorite_t_favorite_display_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_channel_favorite_t_favorite_display_name_get(HandleRef jarg1);

	public static extern void vx_channel_favorite_t_favorite_data_set(HandleRef jarg1, string jarg2);

	public static extern string vx_channel_favorite_t_favorite_data_get(HandleRef jarg1);

	public static extern void vx_channel_favorite_t_channel_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_channel_favorite_t_channel_uri_get(HandleRef jarg1);

	public static extern void vx_channel_favorite_t_channel_description_set(HandleRef jarg1, string jarg2);

	public static extern string vx_channel_favorite_t_channel_description_get(HandleRef jarg1);

	public static extern void vx_channel_favorite_t_channel_limit_set(HandleRef jarg1, int jarg2);

	public static extern int vx_channel_favorite_t_channel_limit_get(HandleRef jarg1);

	public static extern void vx_channel_favorite_t_channel_capacity_set(HandleRef jarg1, int jarg2);

	public static extern int vx_channel_favorite_t_channel_capacity_get(HandleRef jarg1);

	public static extern void vx_channel_favorite_t_channel_modified_set(HandleRef jarg1, string jarg2);

	public static extern string vx_channel_favorite_t_channel_modified_get(HandleRef jarg1);

	public static extern void vx_channel_favorite_t_channel_owner_user_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_channel_favorite_t_channel_owner_user_name_get(HandleRef jarg1);

	public static extern void vx_channel_favorite_t_channel_is_persistent_set(HandleRef jarg1, int jarg2);

	public static extern int vx_channel_favorite_t_channel_is_persistent_get(HandleRef jarg1);

	public static extern void vx_channel_favorite_t_channel_is_protected_set(HandleRef jarg1, int jarg2);

	public static extern int vx_channel_favorite_t_channel_is_protected_get(HandleRef jarg1);

	public static extern void vx_channel_favorite_t_channel_size_set(HandleRef jarg1, int jarg2);

	public static extern int vx_channel_favorite_t_channel_size_get(HandleRef jarg1);

	public static extern void vx_channel_favorite_t_channel_owner_set(HandleRef jarg1, string jarg2);

	public static extern string vx_channel_favorite_t_channel_owner_get(HandleRef jarg1);

	public static extern void vx_channel_favorite_t_channel_owner_display_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_channel_favorite_t_channel_owner_display_name_get(HandleRef jarg1);

	public static extern void vx_channel_favorite_t_channel_active_participants_set(HandleRef jarg1, int jarg2);

	public static extern int vx_channel_favorite_t_channel_active_participants_get(HandleRef jarg1);

	public static extern IntPtr new_vx_channel_favorite_t();

	public static extern void delete_vx_channel_favorite_t(HandleRef jarg1);

	public static extern int vx_channel_favorite_create(HandleRef jarg1);

	public static extern int vx_channel_favorite_free(HandleRef jarg1);

	public static extern int vx_channel_favorite_list_create(int jarg1, HandleRef jarg2);

	public static extern int vx_channel_favorite_list_free(HandleRef jarg1, int jarg2);

	public static extern void vx_channel_favorite_group_t_favorite_group_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_channel_favorite_group_t_favorite_group_id_get(HandleRef jarg1);

	public static extern void vx_channel_favorite_group_t_favorite_group_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_channel_favorite_group_t_favorite_group_name_get(HandleRef jarg1);

	public static extern void vx_channel_favorite_group_t_favorite_group_data_set(HandleRef jarg1, string jarg2);

	public static extern string vx_channel_favorite_group_t_favorite_group_data_get(HandleRef jarg1);

	public static extern void vx_channel_favorite_group_t_favorite_group_modified_set(HandleRef jarg1, string jarg2);

	public static extern string vx_channel_favorite_group_t_favorite_group_modified_get(HandleRef jarg1);

	public static extern IntPtr new_vx_channel_favorite_group_t();

	public static extern void delete_vx_channel_favorite_group_t(HandleRef jarg1);

	public static extern int vx_channel_favorite_group_create(HandleRef jarg1);

	public static extern int vx_channel_favorite_group_free(HandleRef jarg1);

	public static extern int vx_channel_favorite_group_list_create(int jarg1, HandleRef jarg2);

	public static extern int vx_channel_favorite_group_list_free(HandleRef jarg1, int jarg2);

	public static extern void vx_voice_font_t_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_voice_font_t_id_get(HandleRef jarg1);

	public static extern void vx_voice_font_t_parent_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_voice_font_t_parent_id_get(HandleRef jarg1);

	public static extern void vx_voice_font_t_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_voice_font_t_type_get(HandleRef jarg1);

	public static extern void vx_voice_font_t_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_voice_font_t_name_get(HandleRef jarg1);

	public static extern void vx_voice_font_t_description_set(HandleRef jarg1, string jarg2);

	public static extern string vx_voice_font_t_description_get(HandleRef jarg1);

	public static extern void vx_voice_font_t_expiration_date_set(HandleRef jarg1, string jarg2);

	public static extern string vx_voice_font_t_expiration_date_get(HandleRef jarg1);

	public static extern void vx_voice_font_t_expired_set(HandleRef jarg1, int jarg2);

	public static extern int vx_voice_font_t_expired_get(HandleRef jarg1);

	public static extern void vx_voice_font_t_font_delta_set(HandleRef jarg1, string jarg2);

	public static extern string vx_voice_font_t_font_delta_get(HandleRef jarg1);

	public static extern void vx_voice_font_t_font_rules_set(HandleRef jarg1, string jarg2);

	public static extern string vx_voice_font_t_font_rules_get(HandleRef jarg1);

	public static extern void vx_voice_font_t_status_set(HandleRef jarg1, int jarg2);

	public static extern int vx_voice_font_t_status_get(HandleRef jarg1);

	public static extern IntPtr new_vx_voice_font_t();

	public static extern void delete_vx_voice_font_t(HandleRef jarg1);

	public static extern int vx_voice_font_create(HandleRef jarg1);

	public static extern int vx_voice_font_free(HandleRef jarg1);

	public static extern int vx_voice_font_list_create(int jarg1, HandleRef jarg2);

	public static extern int vx_voice_font_list_free(HandleRef jarg1, int jarg2);

	public static extern int vx_string_list_create(int jarg1, HandleRef jarg2);

	public static extern int vx_string_list_free(HandleRef jarg1);

	public static extern void vx_block_rule_t_block_mask_set(HandleRef jarg1, string jarg2);

	public static extern string vx_block_rule_t_block_mask_get(HandleRef jarg1);

	public static extern void vx_block_rule_t_presence_only_set(HandleRef jarg1, int jarg2);

	public static extern int vx_block_rule_t_presence_only_get(HandleRef jarg1);

	public static extern IntPtr new_vx_block_rule_t();

	public static extern void delete_vx_block_rule_t(HandleRef jarg1);

	public static extern int vx_block_rule_create(HandleRef jarg1);

	public static extern int vx_block_rule_free(HandleRef jarg1);

	public static extern int vx_block_rules_create(int jarg1, HandleRef jarg2);

	public static extern int vx_block_rules_free(HandleRef jarg1, int jarg2);

	public static extern void vx_auto_accept_rule_t_auto_accept_mask_set(HandleRef jarg1, string jarg2);

	public static extern string vx_auto_accept_rule_t_auto_accept_mask_get(HandleRef jarg1);

	public static extern void vx_auto_accept_rule_t_auto_add_as_buddy_set(HandleRef jarg1, int jarg2);

	public static extern int vx_auto_accept_rule_t_auto_add_as_buddy_get(HandleRef jarg1);

	public static extern void vx_auto_accept_rule_t_auto_accept_nickname_set(HandleRef jarg1, string jarg2);

	public static extern string vx_auto_accept_rule_t_auto_accept_nickname_get(HandleRef jarg1);

	public static extern IntPtr new_vx_auto_accept_rule_t();

	public static extern void delete_vx_auto_accept_rule_t(HandleRef jarg1);

	public static extern int vx_auto_accept_rule_create(HandleRef jarg1);

	public static extern int vx_auto_accept_rule_free(HandleRef jarg1);

	public static extern int vx_auto_accept_rules_create(int jarg1, HandleRef jarg2);

	public static extern int vx_auto_accept_rules_free(HandleRef jarg1, int jarg2);

	public static extern void vx_user_channel_t_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_user_channel_t_uri_get(HandleRef jarg1);

	public static extern void vx_user_channel_t_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_user_channel_t_name_get(HandleRef jarg1);

	public static extern IntPtr new_vx_user_channel_t();

	public static extern void delete_vx_user_channel_t(HandleRef jarg1);

	public static extern int vx_user_channel_create(HandleRef jarg1);

	public static extern int vx_user_channel_free(HandleRef jarg1);

	public static extern int vx_user_channels_create(int jarg1, HandleRef jarg2);

	public static extern int vx_user_channels_free(HandleRef jarg1, int jarg2);

	public static extern void vx_connectivity_test_result_t_test_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_connectivity_test_result_t_test_type_get(HandleRef jarg1);

	public static extern void vx_connectivity_test_result_t_test_error_code_set(HandleRef jarg1, int jarg2);

	public static extern int vx_connectivity_test_result_t_test_error_code_get(HandleRef jarg1);

	public static extern void vx_connectivity_test_result_t_test_additional_info_set(HandleRef jarg1, string jarg2);

	public static extern string vx_connectivity_test_result_t_test_additional_info_get(HandleRef jarg1);

	public static extern IntPtr new_vx_connectivity_test_result_t();

	public static extern void delete_vx_connectivity_test_result_t(HandleRef jarg1);

	public static extern int vx_connectivity_test_result_create(HandleRef jarg1, int jarg2);

	public static extern int vx_connectivity_test_result_free(HandleRef jarg1);

	public static extern int vx_connectivity_test_results_create(int jarg1, HandleRef jarg2);

	public static extern int vx_connectivity_test_results_free(HandleRef jarg1, int jarg2);

	public static extern void vx_account_t_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_account_t_uri_get(HandleRef jarg1);

	public static extern void vx_account_t_firstname_set(HandleRef jarg1, string jarg2);

	public static extern string vx_account_t_firstname_get(HandleRef jarg1);

	public static extern void vx_account_t_lastname_set(HandleRef jarg1, string jarg2);

	public static extern string vx_account_t_lastname_get(HandleRef jarg1);

	public static extern void vx_account_t_username_set(HandleRef jarg1, string jarg2);

	public static extern string vx_account_t_username_get(HandleRef jarg1);

	public static extern void vx_account_t_displayname_set(HandleRef jarg1, string jarg2);

	public static extern string vx_account_t_displayname_get(HandleRef jarg1);

	public static extern void vx_account_t_email_set(HandleRef jarg1, string jarg2);

	public static extern string vx_account_t_email_get(HandleRef jarg1);

	public static extern void vx_account_t_phone_set(HandleRef jarg1, string jarg2);

	public static extern string vx_account_t_phone_get(HandleRef jarg1);

	public static extern void vx_account_t_carrier_set(HandleRef jarg1, string jarg2);

	public static extern string vx_account_t_carrier_get(HandleRef jarg1);

	public static extern void vx_account_t_created_date_set(HandleRef jarg1, string jarg2);

	public static extern string vx_account_t_created_date_get(HandleRef jarg1);

	public static extern IntPtr new_vx_account_t();

	public static extern void delete_vx_account_t(HandleRef jarg1);

	public static extern int vx_account_create(HandleRef jarg1);

	public static extern int vx_account_free(HandleRef jarg1);

	public static extern void vx_device_t_device_set(HandleRef jarg1, string jarg2);

	public static extern string vx_device_t_device_get(HandleRef jarg1);

	public static extern void vx_device_t_display_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_device_t_display_name_get(HandleRef jarg1);

	public static extern void vx_device_t_device_type_set(HandleRef jarg1, int jarg2);

	public static extern int vx_device_t_device_type_get(HandleRef jarg1);

	public static extern IntPtr new_vx_device_t();

	public static extern void delete_vx_device_t(HandleRef jarg1);

	public static extern int vx_device_create(HandleRef jarg1);

	public static extern int vx_device_free(HandleRef jarg1);

	public static extern int vx_devices_create(int jarg1, HandleRef jarg2);

	public static extern int vx_devices_free(HandleRef jarg1, int jarg2);

	public static extern void vx_buddy_t_buddy_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_buddy_t_buddy_uri_get(HandleRef jarg1);

	public static extern void vx_buddy_t_display_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_buddy_t_display_name_get(HandleRef jarg1);

	public static extern void vx_buddy_t_parent_group_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_buddy_t_parent_group_id_get(HandleRef jarg1);

	public static extern void vx_buddy_t_buddy_data_set(HandleRef jarg1, string jarg2);

	public static extern string vx_buddy_t_buddy_data_get(HandleRef jarg1);

	public static extern void vx_buddy_t_account_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_buddy_t_account_id_get(HandleRef jarg1);

	public static extern void vx_buddy_t_account_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_buddy_t_account_name_get(HandleRef jarg1);

	public static extern IntPtr new_vx_buddy_t();

	public static extern void delete_vx_buddy_t(HandleRef jarg1);

	public static extern int vx_buddy_create(HandleRef jarg1);

	public static extern int vx_buddy_free(HandleRef jarg1);

	public static extern int vx_buddy_list_create(int jarg1, HandleRef jarg2);

	public static extern int vx_buddy_list_free(HandleRef jarg1, int jarg2);

	public static extern void vx_group_t_group_id_set(HandleRef jarg1, int jarg2);

	public static extern int vx_group_t_group_id_get(HandleRef jarg1);

	public static extern void vx_group_t_group_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_group_t_group_name_get(HandleRef jarg1);

	public static extern void vx_group_t_group_data_set(HandleRef jarg1, string jarg2);

	public static extern string vx_group_t_group_data_get(HandleRef jarg1);

	public static extern IntPtr new_vx_group_t();

	public static extern void delete_vx_group_t(HandleRef jarg1);

	public static extern int vx_group_create(HandleRef jarg1);

	public static extern int vx_group_free(HandleRef jarg1);

	public static extern int vx_group_list_create(int jarg1, HandleRef jarg2);

	public static extern int vx_group_list_free(HandleRef jarg1, int jarg2);

	public static extern void vx_name_value_pair_t_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_name_value_pair_t_name_get(HandleRef jarg1);

	public static extern void vx_name_value_pair_t_value_set(HandleRef jarg1, string jarg2);

	public static extern string vx_name_value_pair_t_value_get(HandleRef jarg1);

	public static extern IntPtr new_vx_name_value_pair_t();

	public static extern void delete_vx_name_value_pair_t(HandleRef jarg1);

	public static extern int vx_name_value_pair_create(HandleRef jarg1);

	public static extern int vx_name_value_pair_free(HandleRef jarg1);

	public static extern int vx_name_value_pairs_create(int jarg1, HandleRef jarg2);

	public static extern int vx_name_value_pairs_free(HandleRef jarg1, int jarg2);

	public static extern string vx_strdup(string jarg1);

	public static extern int vx_free(string jarg1);

	public static extern int vx_unallocate(HandleRef jarg1);

	public static extern IntPtr vx_allocate(uint jarg1);

	public static extern IntPtr vx_reallocate(HandleRef jarg1, uint jarg2);

	public static extern IntPtr vx_calloc(uint jarg1, uint jarg2);

	public static extern IntPtr vx_allocate_aligned(uint jarg1, uint jarg2);

	public static extern int vx_unallocate_aligned(HandleRef jarg1);

	public static extern int VX_GET_MESSAGE_NO_MESSAGE_get();

	public static extern int VX_GET_MESSAGE_AVAILABLE_get();

	public static extern int VX_GET_MESSAGE_FAILURE_get();

	public static extern int vx_get_message__SWIG_1(HandleRef jarg1);

	public static extern int vx_issue_request2(HandleRef jarg1);

	public static extern int vx_issue_request3(HandleRef jarg1, out int jarg2);

	public static extern int vx_request_to_xml(HandleRef jarg1, HandleRef jarg2);

	public static extern int vx_xml_to_request(string jarg1, HandleRef jarg2, HandleRef jarg3);

	public static extern int vx_response_to_xml(HandleRef jarg1, HandleRef jarg2);

	public static extern int vx_xml_to_response(string jarg1, HandleRef jarg2, HandleRef jarg3);

	public static extern int vx_event_to_xml(HandleRef jarg1, HandleRef jarg2);

	public static extern int vx_xml_to_event(string jarg1, HandleRef jarg2, HandleRef jarg3);

	public static extern int vx_get_message_type(string jarg1);

	public static extern ulong vx_get_time_ms();

	public static extern ulong vx_get_time_milli_seconds();

	public static extern ulong vx_get_time_micro_seconds();

	public static extern long vx_sleep_milli_seconds(ulong jarg1);

	public static extern int vx_register_message_notification_handler(HandleRef jarg1, HandleRef jarg2);

	public static extern int vx_unregister_message_notification_handler(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_wait_for_message(int jarg1);

	public static extern int vx_register_logging_initialization(int jarg1, string jarg2, string jarg3, string jarg4, int jarg5, HandleRef jarg6);

	public static extern string vx_get_log_file_path();

	public static extern int vx_unregister_logging_handler(HandleRef jarg1, HandleRef jarg2);

	public static extern int vx_create_account(string jarg1, string jarg2, string jarg3, string jarg4, string jarg5);

	public static extern int vx_get_crash_dump_count();

	public static extern int vx_set_crash_dump_generation_enabled(int jarg1);

	public static extern int vx_get_crash_dump_generation();

	public static extern string vx_read_crash_dump(int jarg1);

	public static extern IntPtr vx_get_crash_dump_timestamp(int jarg1);

	public static extern int vx_delete_crash_dump(int jarg1);

	public static extern int vx_on_application_exit();

	public static extern string vx_get_sdk_version_info();

	public static extern string vx_get_sdk_version_info_ex();

	public static extern int vx_apply_font_to_file(string jarg1, string jarg2, string jarg3);

	public static extern int vx_apply_font_to_file_return_energy_ratio(string jarg1, string jarg2, string jarg3, out double jarg4);

	public static extern int vx_apply_font_to_vxz_file_return_energy_ratio(string jarg1, string jarg2, string jarg3, out double jarg4);

	public static extern IntPtr vx_copy_audioBuffer(HandleRef jarg1);

	public static extern double vx_get_audioBuffer_duration(HandleRef jarg1);

	public static extern int vx_get_audioBuffer_sample_rate(HandleRef jarg1);

	public static extern int vx_free_audioBuffer(HandleRef jarg1);

	public static extern int vx_export_audioBuffer_to_pcm(HandleRef jarg1, HandleRef jarg2, int jarg3);

	public static extern int vx_export_audioBuffer_to_wav_file(HandleRef jarg1, string jarg2);

	public static extern int vx_export_audioBuffer_to_memory(HandleRef jarg1, HandleRef jarg2, out int jarg3, out int jarg4, out int jarg5);

	public static extern int vx_set_out_of_process_server_address(string jarg1, ushort jarg2);

	public static extern int vx_alloc_sdk_handle(string jarg1, ushort jarg2, out uint jarg3);

	public static extern int vx_free_sdk_handle(uint jarg1);

	public static extern int vx_initialize2(HandleRef jarg1);

	public static extern int vx_initialize3(HandleRef jarg1, uint jarg2);

	public static extern int vx_is_initialized();

	public static extern int vx_get_default_config3(HandleRef jarg1, uint jarg2);

	public static extern int VIVOX_V_V2_AUDIO_DATA_MONO_SIREN14_32000_EXPANDED_get();

	public static extern int VIVOX_V_V2_AUDIO_DATA_MONO_SIREN14_32000_get();

	public static extern int VIVOX_V_V2_AUDIO_DATA_MONO_SIREN7_16000_EXPANDED_get();

	public static extern int VIVOX_V_V2_AUDIO_DATA_MONO_OPUS_48000_EXPANDED_get();

	public static extern int VIVOX_V_V2_AUDIO_DATA_MONO_PCMU_8000_COLLAPSED_get();

	public static extern int VIVOX_V_V2_AUDIO_DATA_MONO_PCMU_get();

	public static extern int VIVOX_V_V2_AUDIO_DATA_MONO_PCMU_8000_EXPANDED_get();

	public static extern int VIVOX_VANI_PCMU_get();

	public static extern int VIVOX_VANI_SIREN7_get();

	public static extern int VIVOX_VANI_SIREN14_get();

	public static extern int VIVOX_VANI_LEGACY_MASK_get();

	public static extern int VIVOX_VANI_OPUS8_get();

	public static extern int VIVOX_VANI_OPUS40_get();

	public static extern int VIVOX_VANI_OPUS57_get();

	public static extern int VIVOX_VANI_OPUS72_get();

	public static extern int VIVOX_VANI_OPUS_get();

	public static extern int VIVOX_VANI_OPUS_MASK_get();

	public static extern void vx_stat_sample_t_sample_count_set(HandleRef jarg1, double jarg2);

	public static extern double vx_stat_sample_t_sample_count_get(HandleRef jarg1);

	public static extern void vx_stat_sample_t_sum_set(HandleRef jarg1, double jarg2);

	public static extern double vx_stat_sample_t_sum_get(HandleRef jarg1);

	public static extern void vx_stat_sample_t_sum_of_squares_set(HandleRef jarg1, double jarg2);

	public static extern double vx_stat_sample_t_sum_of_squares_get(HandleRef jarg1);

	public static extern void vx_stat_sample_t_mean_set(HandleRef jarg1, double jarg2);

	public static extern double vx_stat_sample_t_mean_get(HandleRef jarg1);

	public static extern void vx_stat_sample_t_stddev_set(HandleRef jarg1, double jarg2);

	public static extern double vx_stat_sample_t_stddev_get(HandleRef jarg1);

	public static extern void vx_stat_sample_t_min_set(HandleRef jarg1, double jarg2);

	public static extern double vx_stat_sample_t_min_get(HandleRef jarg1);

	public static extern void vx_stat_sample_t_max_set(HandleRef jarg1, double jarg2);

	public static extern double vx_stat_sample_t_max_get(HandleRef jarg1);

	public static extern void vx_stat_sample_t_last_set(HandleRef jarg1, double jarg2);

	public static extern double vx_stat_sample_t_last_get(HandleRef jarg1);

	public static extern IntPtr new_vx_stat_sample_t();

	public static extern void delete_vx_stat_sample_t(HandleRef jarg1);

	public static extern void vx_stat_thread_t_interval_set(HandleRef jarg1, int jarg2);

	public static extern int vx_stat_thread_t_interval_get(HandleRef jarg1);

	public static extern void vx_stat_thread_t_count_poll_lt_1ms_set(HandleRef jarg1, int jarg2);

	public static extern int vx_stat_thread_t_count_poll_lt_1ms_get(HandleRef jarg1);

	public static extern void vx_stat_thread_t_count_poll_lt_5ms_set(HandleRef jarg1, int jarg2);

	public static extern int vx_stat_thread_t_count_poll_lt_5ms_get(HandleRef jarg1);

	public static extern void vx_stat_thread_t_count_poll_lt_10ms_set(HandleRef jarg1, int jarg2);

	public static extern int vx_stat_thread_t_count_poll_lt_10ms_get(HandleRef jarg1);

	public static extern void vx_stat_thread_t_count_poll_lt_16ms_set(HandleRef jarg1, int jarg2);

	public static extern int vx_stat_thread_t_count_poll_lt_16ms_get(HandleRef jarg1);

	public static extern void vx_stat_thread_t_count_poll_lt_20ms_set(HandleRef jarg1, int jarg2);

	public static extern int vx_stat_thread_t_count_poll_lt_20ms_get(HandleRef jarg1);

	public static extern void vx_stat_thread_t_count_poll_lt_25ms_set(HandleRef jarg1, int jarg2);

	public static extern int vx_stat_thread_t_count_poll_lt_25ms_get(HandleRef jarg1);

	public static extern void vx_stat_thread_t_count_poll_gte_25ms_set(HandleRef jarg1, int jarg2);

	public static extern int vx_stat_thread_t_count_poll_gte_25ms_get(HandleRef jarg1);

	public static extern IntPtr new_vx_stat_thread_t();

	public static extern void delete_vx_stat_thread_t(HandleRef jarg1);

	public static extern void vx_system_stats_t_ss_size_set(HandleRef jarg1, int jarg2);

	public static extern int vx_system_stats_t_ss_size_get(HandleRef jarg1);

	public static extern void vx_system_stats_t_ar_source_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_system_stats_t_ar_source_count_get(HandleRef jarg1);

	public static extern void vx_system_stats_t_ar_source_queue_limit_set(HandleRef jarg1, int jarg2);

	public static extern int vx_system_stats_t_ar_source_queue_limit_get(HandleRef jarg1);

	public static extern void vx_system_stats_t_ar_source_queue_overflows_set(HandleRef jarg1, int jarg2);

	public static extern int vx_system_stats_t_ar_source_queue_overflows_get(HandleRef jarg1);

	public static extern void vx_system_stats_t_ar_source_poll_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_system_stats_t_ar_source_poll_count_get(HandleRef jarg1);

	public static extern void vx_system_stats_t_msgovrld_count_set(HandleRef jarg1, uint jarg2);

	public static extern uint vx_system_stats_t_msgovrld_count_get(HandleRef jarg1);

	public static extern void vx_system_stats_t_ar_source_free_buffers_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_system_stats_t_ar_source_free_buffers_get(HandleRef jarg1);

	public static extern void vx_system_stats_t_ar_source_queue_depth_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_system_stats_t_ar_source_queue_depth_get(HandleRef jarg1);

	public static extern void vx_system_stats_t_vp_thread_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_system_stats_t_vp_thread_get(HandleRef jarg1);

	public static extern void vx_system_stats_t_ticker_thread_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_system_stats_t_ticker_thread_get(HandleRef jarg1);

	public static extern void vx_system_stats_t_clnt_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_system_stats_t_clnt_count_get(HandleRef jarg1);

	public static extern void vx_system_stats_t_lc_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_system_stats_t_lc_count_get(HandleRef jarg1);

	public static extern void vx_system_stats_t_mps_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_system_stats_t_mps_count_get(HandleRef jarg1);

	public static extern void vx_system_stats_t_mpsg_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_system_stats_t_mpsg_count_get(HandleRef jarg1);

	public static extern void vx_system_stats_t_strms_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_system_stats_t_strms_count_get(HandleRef jarg1);

	public static extern void vx_system_stats_t_strr_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_system_stats_t_strr_count_get(HandleRef jarg1);

	public static extern void vx_system_stats_t_strss_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_system_stats_t_strss_count_get(HandleRef jarg1);

	public static extern void vx_system_stats_t_vp_count_set(HandleRef jarg1, int jarg2);

	public static extern int vx_system_stats_t_vp_count_get(HandleRef jarg1);

	public static extern IntPtr new_vx_system_stats_t();

	public static extern void delete_vx_system_stats_t(HandleRef jarg1);

	public static extern int vx_debug_call(HandleRef jarg1);

	public static extern int vx_get_system_stats(HandleRef jarg1);

	public static extern string VX_VAR_DECODER_COUNT_LIMIT_get();

	public static extern string VX_VAR_DECODER_HANGOVER_LIMIT_get();

	public static extern string VX_VAR_RTP_ENCRYPTION_get();

	public static extern int vx_get_int_var(string jarg1, out int jarg2);

	public static extern int vx_set_int_var(string jarg1, int jarg2);

	public static extern int vx_destroy_message(HandleRef jarg1);

	public static extern void vxa_capture_device_stats_t_buffer_underrun_count_set(HandleRef jarg1, int jarg2);

	public static extern int vxa_capture_device_stats_t_buffer_underrun_count_get(HandleRef jarg1);

	public static extern void vxa_capture_device_stats_t_buffer_overrun_count_set(HandleRef jarg1, int jarg2);

	public static extern int vxa_capture_device_stats_t_buffer_overrun_count_get(HandleRef jarg1);

	public static extern void vxa_capture_device_stats_t_other_error_count_set(HandleRef jarg1, int jarg2);

	public static extern int vxa_capture_device_stats_t_other_error_count_get(HandleRef jarg1);

	public static extern void vxa_capture_device_stats_t_audio_queue_read_count_set(HandleRef jarg1, int jarg2);

	public static extern int vxa_capture_device_stats_t_audio_queue_read_count_get(HandleRef jarg1);

	public static extern void vxa_capture_device_stats_t_audio_queue_write_count_set(HandleRef jarg1, int jarg2);

	public static extern int vxa_capture_device_stats_t_audio_queue_write_count_get(HandleRef jarg1);

	public static extern IntPtr new_vxa_capture_device_stats_t();

	public static extern void delete_vxa_capture_device_stats_t(HandleRef jarg1);

	public static extern void vxa_apcd_t_pf_get_display_name_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vxa_apcd_t_pf_get_display_name_get(HandleRef jarg1);

	public static extern void vxa_apcd_t_pf_get_internal_name_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vxa_apcd_t_pf_get_internal_name_get(HandleRef jarg1);

	public static extern void vxa_apcd_t_pf_open_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vxa_apcd_t_pf_open_get(HandleRef jarg1);

	public static extern void vxa_apcd_t_pf_is_open_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vxa_apcd_t_pf_is_open_get(HandleRef jarg1);

	public static extern void vxa_apcd_t_pf_read_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vxa_apcd_t_pf_read_get(HandleRef jarg1);

	public static extern void vxa_apcd_t_pf_get_stats_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vxa_apcd_t_pf_get_stats_get(HandleRef jarg1);

	public static extern void vxa_apcd_t_pf_close_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vxa_apcd_t_pf_close_get(HandleRef jarg1);

	public static extern IntPtr new_vxa_apcd_t();

	public static extern void delete_vxa_apcd_t(HandleRef jarg1);

	public static extern void vxa_render_device_stats_t_current_output_queue_depth_milliseconds_set(HandleRef jarg1, int jarg2);

	public static extern int vxa_render_device_stats_t_current_output_queue_depth_milliseconds_get(HandleRef jarg1);

	public static extern void vxa_render_device_stats_t_buffer_underrun_count_set(HandleRef jarg1, int jarg2);

	public static extern int vxa_render_device_stats_t_buffer_underrun_count_get(HandleRef jarg1);

	public static extern void vxa_render_device_stats_t_buffer_overrun_count_set(HandleRef jarg1, int jarg2);

	public static extern int vxa_render_device_stats_t_buffer_overrun_count_get(HandleRef jarg1);

	public static extern void vxa_render_device_stats_t_other_error_count_set(HandleRef jarg1, int jarg2);

	public static extern int vxa_render_device_stats_t_other_error_count_get(HandleRef jarg1);

	public static extern void vxa_render_device_stats_t_audio_queue_read_count_set(HandleRef jarg1, int jarg2);

	public static extern int vxa_render_device_stats_t_audio_queue_read_count_get(HandleRef jarg1);

	public static extern void vxa_render_device_stats_t_audio_queue_write_count_set(HandleRef jarg1, int jarg2);

	public static extern int vxa_render_device_stats_t_audio_queue_write_count_get(HandleRef jarg1);

	public static extern void vxa_render_device_stats_t_hardware_output_channels_set(HandleRef jarg1, int jarg2);

	public static extern int vxa_render_device_stats_t_hardware_output_channels_get(HandleRef jarg1);

	public static extern void vxa_render_device_stats_t_hardware_preferred_samplerate_set(HandleRef jarg1, int jarg2);

	public static extern int vxa_render_device_stats_t_hardware_preferred_samplerate_get(HandleRef jarg1);

	public static extern void vxa_render_device_stats_t_hardware_preferred_buffer_duration_set(HandleRef jarg1, int jarg2);

	public static extern int vxa_render_device_stats_t_hardware_preferred_buffer_duration_get(HandleRef jarg1);

	public static extern IntPtr new_vxa_render_device_stats_t();

	public static extern void delete_vxa_render_device_stats_t(HandleRef jarg1);

	public static extern void vxa_aprd_t_pf_get_display_name_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vxa_aprd_t_pf_get_display_name_get(HandleRef jarg1);

	public static extern void vxa_aprd_t_pf_get_internal_name_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vxa_aprd_t_pf_get_internal_name_get(HandleRef jarg1);

	public static extern void vxa_aprd_t_pf_open_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vxa_aprd_t_pf_open_get(HandleRef jarg1);

	public static extern void vxa_aprd_t_pf_is_open_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vxa_aprd_t_pf_is_open_get(HandleRef jarg1);

	public static extern void vxa_aprd_t_pf_get_buffer_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vxa_aprd_t_pf_get_buffer_get(HandleRef jarg1);

	public static extern void vxa_aprd_t_pf_release_buffer_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vxa_aprd_t_pf_release_buffer_get(HandleRef jarg1);

	public static extern void vxa_aprd_t_pf_get_stats_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vxa_aprd_t_pf_get_stats_get(HandleRef jarg1);

	public static extern void vxa_aprd_t_pf_close_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vxa_aprd_t_pf_close_get(HandleRef jarg1);

	public static extern IntPtr new_vxa_aprd_t();

	public static extern void delete_vxa_aprd_t(HandleRef jarg1);

	public static extern int MAX_VXA_DEVICE_COUNT_get();

	public static extern int vxa_apcd_create(HandleRef jarg1, out int jarg2);

	public static extern int vxa_apcd_destroy(int jarg1);

	public static extern int vxa_aprd_create(HandleRef jarg1, out int jarg2);

	public static extern int vxa_aprd_destroy(int jarg1);

	public static extern uint vx_get_http(string jarg1, out uint jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, HandleRef jarg6);

	public static extern int vx_free_http(HandleRef jarg1, HandleRef jarg2);

	public static extern string vx_get_random_user_id(string jarg1);

	public static extern string vx_get_random_user_id_ex(string jarg1, string jarg2);

	public static extern string vx_get_random_channel_uri(string jarg1, string jarg2);

	public static extern string vx_get_random_channel_uri_ex(string jarg1, string jarg2, string jarg3);

	public static extern int vx_opus_set_bit_rate(int jarg1);

	public static extern int vx_opus_get_bit_rate(out int jarg1);

	public static extern int vx_opus_set_complexity(int jarg1);

	public static extern int vx_opus_get_complexity(out int jarg1);

	public static extern int vx_opus_set_vbr_mode(int jarg1);

	public static extern int vx_opus_get_vbr_mode(out int jarg1);

	public static extern int vx_opus_set_bandwidth(int jarg1);

	public static extern int vx_opus_get_bandwidth(out int jarg1);

	public static extern uint vx_get_available_codecs_mask();

	public static extern uint vx_get_default_codecs_mask();

	public static extern int vx_crash_test(int jarg1);

	public static extern int vx_set_message_rate_params(uint jarg1, float jarg2, int jarg3);

	public static extern int vx_set_default_message_rate_params();

	public static extern int vx_internal_enable_debug_mode_disable_strict_checks();

	public static extern int vx_internal_disable_debug_mode_enable_strict_checks();

	public static extern int vx_is_access_token_well_formed(string jarg1, HandleRef jarg2);

	public static extern void vx_vxd_t_version_set(HandleRef jarg1, uint jarg2);

	public static extern uint vx_vxd_t_version_get(HandleRef jarg1);

	public static extern void vx_vxd_t_participant_uri_set(HandleRef jarg1, string jarg2);

	public static extern string vx_vxd_t_participant_uri_get(HandleRef jarg1);

	public static extern void vx_vxd_t_data_set(HandleRef jarg1, string jarg2);

	public static extern string vx_vxd_t_data_get(HandleRef jarg1);

	public static extern void vx_vxd_t_data_size_set(HandleRef jarg1, uint jarg2);

	public static extern uint vx_vxd_t_data_size_get(HandleRef jarg1);

	public static extern IntPtr new_vx_vxd_t();

	public static extern void delete_vx_vxd_t(HandleRef jarg1);

	public static extern int vx_vxd_send(string jarg1, string jarg2, uint jarg3);

	public static extern int vx_vxd_recv(string jarg1, HandleRef jarg2);

	public static extern int vx_vxd_destroy(HandleRef jarg1);

	public static extern string vx_get_path(uint jarg1);

	public static extern int vx_get_dynamic_voice_processing_switching_enabled(out int jarg1);

	public static extern int vx_set_dynamic_voice_processing_switching_enabled(int jarg1);

	public static extern int vx_get_platform_aec_enabled(out int jarg1);

	public static extern int vx_set_platform_aec_enabled(int jarg1);

	public static extern int vx_set_vivox_aec_enabled(int jarg1);

	public static extern int vx_get_vivox_aec_enabled(out int jarg1);

	public static extern int vx_set_agc_enabled(int jarg1);

	public static extern int vx_get_agc_enabled(out int jarg1);

	public static extern int VX_TTS_CHARACTER_COUNT_LIMIT_get();

	public static extern int VX_TTS_MAX_DESTINATION_QUEUE_SIZE_get();

	public static extern IntPtr vx_tts_utterance_t_utterance_obj_get(HandleRef jarg1);

	public static extern void vx_tts_utterance_t_speech_buffer_set(HandleRef jarg1, HandleRef jarg2);

	public static extern IntPtr vx_tts_utterance_t_speech_buffer_get(HandleRef jarg1);

	public static extern void vx_tts_utterance_t_sample_rate_set(HandleRef jarg1, int jarg2);

	public static extern int vx_tts_utterance_t_sample_rate_get(HandleRef jarg1);

	public static extern void vx_tts_utterance_t_num_frames_set(HandleRef jarg1, int jarg2);

	public static extern int vx_tts_utterance_t_num_frames_get(HandleRef jarg1);

	public static extern void vx_tts_utterance_t_num_channels_set(HandleRef jarg1, int jarg2);

	public static extern int vx_tts_utterance_t_num_channels_get(HandleRef jarg1);

	public static extern IntPtr new_vx_tts_utterance_t();

	public static extern void delete_vx_tts_utterance_t(HandleRef jarg1);

	public static extern void vx_tts_voice_t_voice_id_set(HandleRef jarg1, uint jarg2);

	public static extern uint vx_tts_voice_t_voice_id_get(HandleRef jarg1);

	public static extern void vx_tts_voice_t_name_set(HandleRef jarg1, string jarg2);

	public static extern string vx_tts_voice_t_name_get(HandleRef jarg1);

	public static extern IntPtr new_vx_tts_voice_t();

	public static extern void delete_vx_tts_voice_t(HandleRef jarg1);

	public static extern int vx_tts_initialize(int jarg1, out uint jarg2);

	public static extern string vx_get_tts_status_string(int jarg1);

	public static extern int vx_tts_speak(uint jarg1, uint jarg2, string jarg3, int jarg4, out uint jarg5);

	public static extern int vx_tts_speak_to_buffer(uint jarg1, uint jarg2, string jarg3, HandleRef jarg4);

	public static extern int vx_tts_destroy_utterance(uint jarg1, HandleRef jarg2);

	public static extern int vx_tts_cancel_utterance(uint jarg1, uint jarg2);

	public static extern int vx_tts_cancel_all_in_dest(uint jarg1, int jarg2);

	public static extern int vx_tts_cancel_all(uint jarg1);
}
