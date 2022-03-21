using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
	public class Tag
	{
		private string _key;

		private string _value;

		[AWSProperty]
		public string Key
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetKey()
		{
			return default(bool);
		}

		internal bool IsSetValue()
		{
			return default(bool);
		}
	}
}
