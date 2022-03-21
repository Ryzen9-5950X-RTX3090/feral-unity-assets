using System;
using System.Runtime.InteropServices;

public class vx_participant_t : IDisposable
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

	public string first_name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string last_name
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

	public string username
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int is_moderator
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int is_moderator_muted
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int is_moderator_text_muted
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int is_muted_for_me
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int is_owner
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int account_id
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_participant_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_participant_t obj)
	{
		return default(HandleRef);
	}

	~vx_participant_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_participant_t()
	{
	}
}
