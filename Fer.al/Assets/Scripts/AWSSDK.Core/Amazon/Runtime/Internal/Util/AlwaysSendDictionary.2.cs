using System.Collections.Generic;

namespace Amazon.Runtime.Internal.Util
{
	internal class AlwaysSendDictionary<TKey, TValue> : Dictionary<TKey, TValue>
	{
		public AlwaysSendDictionary()
		{
		}

		public AlwaysSendDictionary(IEqualityComparer<TKey> comparer)
		{
		}

		public AlwaysSendDictionary(IDictionary<TKey, TValue> dictionary)
		{
		}
	}
}
