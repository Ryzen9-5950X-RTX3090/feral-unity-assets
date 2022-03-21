using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	internal class XProcessingInstructionWrapper : XObjectWrapper
	{
		private XProcessingInstruction ProcessingInstruction
		{
			get
			{
				return null;
			}
		}

		public override string LocalName
		{
			get
			{
				return null;
			}
		}

		public override string Value
		{
			get
			{
				return null;
			}
		}

		public XProcessingInstructionWrapper(XProcessingInstruction processingInstruction)
		{
		}
	}
}
