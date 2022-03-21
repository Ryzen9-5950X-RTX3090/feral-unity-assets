using System;
using System.Runtime.InteropServices;

public class vx_evt_voice_service_connection_state_changed_t : IDisposable
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

	public int connected
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public string platform
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string version
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string data_directory
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int network_test_run
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int network_test_completed
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int network_test_state
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int network_is_down
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_evt_voice_service_connection_state_changed_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_voice_service_connection_state_changed_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_voice_service_connection_state_changed_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_evt_voice_service_connection_state_changed_t()
	{
	}
}
