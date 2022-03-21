using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BestHTTP.Forms
{
	public class HTTPFormBase
	{
		private const int LongLength = 256;

		public List<HTTPFieldData> Fields
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

		public bool IsEmpty
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsChanged
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool HasBinary
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool HasLongValue
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public void AddBinaryData(string fieldName, byte[] content)
		{
		}

		public void AddBinaryData(string fieldName, byte[] content, string fileName)
		{
		}

		public void AddBinaryData(string fieldName, byte[] content, string fileName, string mimeType)
		{
		}

		public void AddField(string fieldName, string value)
		{
		}

		public void AddField(string fieldName, string value, Encoding e)
		{
		}

		public virtual void CopyFrom(HTTPFormBase fields)
		{
		}

		public virtual void PrepareRequest(HTTPRequest request)
		{
		}

		public virtual byte[] GetData()
		{
			return null;
		}
	}
}
