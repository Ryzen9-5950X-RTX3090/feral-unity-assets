using System;
using System.Runtime.InteropServices;

public class vx_sdk_config_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public static readonly uint configSize;

	public int num_codec_threads
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int num_voice_threads
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int num_web_threads
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int render_source_queue_depth_max
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int render_source_initial_buffer_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int upstream_jitter_frame_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int allow_shared_capture_devices
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int max_logins_per_user
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public string app_id
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string cert_data_dir
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_f_size_t__p_void pf_malloc_func
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_f_p_void__void pf_free_func
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_f_p_void_size_t__p_void pf_realloc_func
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_f_size_t_size_t__p_void pf_calloc_func
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_f_size_t_size_t__p_void pf_malloc_aligned_func
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_f_p_void__void pf_free_aligned_func
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int reserved
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public SWIGTYPE_p_void job_queue_handle
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_f_p_void_p_void_size_t__int pf_queue_job_sync
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_f_p_void_p_void_size_t__int pf_queue_job_async
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public long processor_affinity_mask
	{
		get
		{
			return default(long);
		}
		set
		{
		}
	}

	public SWIGTYPE_p_void callback_handle
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_f_p_void_enum_vx_log_level_p_q_const__char_p_q_const__char__void pf_logging_callback
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_f_p_void__void pf_sdk_message_callback
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public vx_log_level initial_log_level
	{
		get
		{
			return default(vx_log_level);
		}
		set
		{
		}
	}

	public int disable_device_polling
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int force_capture_silence
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int enable_advanced_auto_levels
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char__void pf_on_audio_unit_started
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char__void pf_on_audio_unit_stopped
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char_p_short_int_int_int__void pf_on_audio_unit_after_capture_audio_read
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char_p_short_int_int_int_int__void pf_on_audio_unit_before_capture_audio_sent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char_p_vx_before_recv_audio_mixed_participant_data_t_size_t__void pf_on_audio_unit_before_recv_audio_mixed
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char_p_short_int_int_int_int__void pf_on_audio_unit_before_recv_audio_rendered
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int capture_device_buffer_size_intervals
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int render_device_buffer_size_intervals
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int disable_audio_ducking
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int use_access_tokens
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int enable_multiparty_text
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int enable_dtx
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public uint default_codecs_mask
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public SWIGTYPE_p_f_p_void_enum_vx_udp_frame_type_p_void_int_p_p_void_p_int_p_p_void_p_int__void pf_on_before_udp_frame_transmitted
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_f_p_void_enum_vx_udp_frame_type_p_void_int_p_void_int_p_void_int_int__void pf_on_after_udp_frame_transmitted
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int enable_fast_network_change_detection
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int use_os_proxy_settings
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int enable_persistent_http
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int preferred_sip_port
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int default_render_to_receiver
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public float mic_makeup_gain
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public SWIGTYPE_p_f_p_void_p_q_const__char__void pf_on_thread_created
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_f_p_void__void pf_on_thread_exit
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_f_void__int pf_request_permission_for_network
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int dynamic_voice_processing_switching
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public SWIGTYPE_p_f_int__void pf_on_audio_unit_capture_device_status_changed
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int never_rtp_timeout_ms
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int lost_rtp_timeout_ms
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public SWIGTYPE_p_f_int__void pf_on_assert
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_sdk_config_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_sdk_config_t obj)
	{
		return default(HandleRef);
	}

	~vx_sdk_config_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_sdk_config_t()
	{
	}
}
