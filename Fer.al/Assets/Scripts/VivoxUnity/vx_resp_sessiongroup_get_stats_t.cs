using System;
using System.Runtime.InteropServices;

public class vx_resp_sessiongroup_get_stats_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public vx_resp_base_t base_
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int insufficient_bandwidth
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int min_bars
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int max_bars
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int current_bars
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int pk_loss
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int incoming_received
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int incoming_expected
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int incoming_packetloss
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int incoming_out_of_time
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int incoming_discarded
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int outgoing_sent
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int render_device_underruns
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int render_device_overruns
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int render_device_errors
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public string call_id
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int plc_on
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int plc_synthetic_frames
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public string codec_name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int codec_mode
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public double min_latency
	{
		get
		{
			return default(double);
		}
		set
		{
		}
	}

	public double max_latency
	{
		get
		{
			return default(double);
		}
		set
		{
		}
	}

	public int latency_measurement_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public double latency_sum
	{
		get
		{
			return default(double);
		}
		set
		{
		}
	}

	public double last_latency_measured
	{
		get
		{
			return default(double);
		}
		set
		{
		}
	}

	public int latency_packets_lost
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public double r_factor
	{
		get
		{
			return default(double);
		}
		set
		{
		}
	}

	public int latency_packets_sent
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int latency_packets_dropped
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int latency_packets_malformed
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int latency_packets_negative_latency
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public double sample_interval_begin
	{
		get
		{
			return default(double);
		}
		set
		{
		}
	}

	public double sample_interval_end
	{
		get
		{
			return default(double);
		}
		set
		{
		}
	}

	public SWIGTYPE_p_int capture_device_consecutively_read_count
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int current_opus_bit_rate
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int current_opus_complexity
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int current_opus_vbr_mode
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int current_opus_bandwidth
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int current_opus_max_packet_size
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int signal_secure
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_resp_sessiongroup_get_stats_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_resp_sessiongroup_get_stats_t obj)
	{
		return default(HandleRef);
	}

	~vx_resp_sessiongroup_get_stats_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_resp_sessiongroup_get_stats_t()
	{
	}
}
