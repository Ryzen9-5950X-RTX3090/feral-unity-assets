namespace NodeCanvas.Framework
{
	public interface IGraphAssignable<T> : IGraphAssignable, IGraphElement where T : Graph
	{
		new T subGraph { get; set; }

		new T currentInstance { get; set; }
	}
}
