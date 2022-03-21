namespace NodeCanvas.Framework
{
	public interface ITaskAssignable : IGraphElement
	{
		Task task { get; set; }
	}
}
