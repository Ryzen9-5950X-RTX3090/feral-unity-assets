using System.Collections.Generic;

namespace Amazon.Util
{
	internal class Marker<U>
	{
		private List<U> data;

		private string nextToken;

		internal List<U> Data
		{
			get
			{
				return null;
			}
		}

		internal string NextToken
		{
			get
			{
				return null;
			}
		}

		internal Marker(List<U> data, string nextToken)
		{
		}
	}
}
