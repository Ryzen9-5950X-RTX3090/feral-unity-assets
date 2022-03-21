using System;
using System.Runtime.InteropServices;

public class vx_state_participant_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public string uri
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string display_name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int is_audio_enabled
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int is_text_enabled
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int is_audio_muted_for_me
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int is_text_muted_for_me
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int is_audio_moderator_muted
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int is_text_moderator_muted
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int is_hand_raised
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int is_typing
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int is_speaking
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int volume
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public double energy
	{
		get
		{
			return default(double);
		}
		set
		{
		}
	}

	public vx_participant_type type
	{
		get
		{
			return default(vx_participant_type);
		}
		set
		{
		}
	}

	public int is_anonymous_login
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_state_participant_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_state_participant_t obj)
	{
		return default(HandleRef);
	}

	~vx_state_participant_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_state_participant_t()
	{
	}
}
