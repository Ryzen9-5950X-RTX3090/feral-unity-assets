using System.Runtime.CompilerServices;

namespace Amazon.Runtime.Internal
{
	public class AsyncResponseContext : ResponseContext, IAsyncResponseContext, IResponseContext
	{
		public RuntimeAsyncResult AsyncResult
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
