using System.IO;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
	public class Record
	{
		private MemoryStream _data;

		[AWSProperty]
		public MemoryStream Data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetData()
		{
			return default(bool);
		}
	}
}
