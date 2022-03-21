using System.Runtime.CompilerServices;
using ThirdParty.Json.LitJson;

namespace Amazon.Runtime.Internal.Transform
{
	public class JsonMarshallerContext : MarshallerContext
	{
		public JsonWriter Writer
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public JsonMarshallerContext(IRequest request, JsonWriter writer)
		{
		}
	}
}
