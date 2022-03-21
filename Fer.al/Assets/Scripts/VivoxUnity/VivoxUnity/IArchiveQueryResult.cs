namespace VivoxUnity
{
	public interface IArchiveQueryResult
	{
		string QueryId { get; }

		int ReturnCode { get; }

		int StatusCode { get; }

		string FirstId { get; }

		string LastId { get; }

		uint FirstIndex { get; }

		uint TotalCount { get; }

		bool Running { get; }
	}
}
