public interface IMessage
{
	string EventId { get; set; }

	void ReturnToPool();
}
