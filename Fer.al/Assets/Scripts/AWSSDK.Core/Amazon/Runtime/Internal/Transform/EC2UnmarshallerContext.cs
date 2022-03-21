using System.IO;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime.Internal.Transform
{
	public class EC2UnmarshallerContext : XmlUnmarshallerContext
	{
		public string RequestId
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

		public EC2UnmarshallerContext(Stream responseStream, bool maintainResponseBody, IWebResponseData responseData, bool isException = false)
		{
		}

		public override bool Read()
		{
			return default(bool);
		}
	}
}
