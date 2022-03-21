using System.Collections.Generic;
using NodeCanvas.Framework.Internal;

namespace NodeCanvas.Framework
{
	public interface IGraphAssignable : IGraphElement
	{
		Graph subGraph { get; set; }

		Graph currentInstance { get; set; }

		Dictionary<Graph, Graph> instances { get; set; }

		BBParameter subGraphParameter { get; }

		List<BBMappingParameter> variablesMap { get; set; }
	}
}
