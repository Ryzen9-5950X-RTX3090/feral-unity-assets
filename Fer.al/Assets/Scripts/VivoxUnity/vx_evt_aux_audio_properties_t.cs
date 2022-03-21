using System;
using System.Runtime.InteropServices;

public class vx_evt_aux_audio_properties_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public vx_evt_base_t base_
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public vx_aux_audio_properties_state state
	{
		get
		{
			return default(vx_aux_audio_properties_state);
		}
		set
		{
		}
	}

	public int mic_is_active
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int mic_volume
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public double mic_energy
	{
		get
		{
			return default(double);
		}
		set
		{
		}
	}

	public int speaker_volume
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public double speaker_energy
	{
		get
		{
			return default(double);
		}
		set
		{
		}
	}

	public int speaker_is_active
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public double fast_energy_meter
	{
		get
		{
			return default(double);
		}
		set
		{
		}
	}

	public double noise_floor_meter
	{
		get
		{
			return default(double);
		}
		set
		{
		}
	}

	public double speech_threshold_meter
	{
		get
		{
			return default(double);
		}
		set
		{
		}
	}

	internal vx_evt_aux_audio_properties_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_aux_audio_properties_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_aux_audio_properties_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_evt_aux_audio_properties_t()
	{
	}
}
