public class WWWResponse<T> where T : new()
{
	public int status;

	public T value;

	public string body;

	public bool IsSuccess
	{
		get
		{
			return default(bool);
		}
	}

	public WWWResponse(int status)
	{
	}

	public WWWResponse(int status, T value)
	{
	}

	public WWWResponse(WWWResponse originalResponse)
	{
	}
}
