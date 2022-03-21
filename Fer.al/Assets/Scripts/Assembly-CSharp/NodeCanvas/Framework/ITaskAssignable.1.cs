namespace NodeCanvas.Framework
{
	public interface ITaskAssignable<T> : ITaskAssignable, IGraphElement where T : Task
	{
	}
}
