using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime
{
	public class StringListParameterValue : ParameterValue
	{
		public List<string> Value
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

		public StringListParameterValue(List<string> values)
		{
		}

		internal StringListParameterValue()
		{
		}
	}
}
