using System;
using System.Runtime.InteropServices;

public class vx_evt_transcribed_message_t : IDisposable
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

	public string sessiongroup_handle
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string session_handle
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string participant_uri
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string language
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int is_current_user
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public string participant_displayname
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_evt_transcribed_message_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_transcribed_message_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_transcribed_message_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_evt_transcribed_message_t()
	{
	}
}
