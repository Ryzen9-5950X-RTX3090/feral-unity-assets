namespace VivoxUnity
{
	public interface IFailedDirectedTextMessage
	{
		AccountId Sender { get; }

		string RequestId { get; }

		int StatusCode { get; }
	}
}
