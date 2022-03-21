public interface IWWWCustomResponse<T> where T : new()
{
	void Parse(WWWResponse<T> response);
}
