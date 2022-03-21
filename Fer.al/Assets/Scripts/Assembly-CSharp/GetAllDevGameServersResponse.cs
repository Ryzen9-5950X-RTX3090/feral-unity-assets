public class GetAllDevGameServersResponse : IWWWCustomResponse<GetAllDevGameServersResponse>
{
	public string[] devGameServers;

	public void Parse(WWWResponse<GetAllDevGameServersResponse> response)
	{
	}
}
