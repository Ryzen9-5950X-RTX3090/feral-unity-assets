using System;
using System.ComponentModel;

namespace Newtonsoft.Json.Linq
{
	public class JPropertyDescriptor : PropertyDescriptor
	{
		public override Type ComponentType
		{
			get
			{
				return null;
			}
		}

		public override bool IsReadOnly
		{
			get
			{
				return default(bool);
			}
		}

		public override Type PropertyType
		{
			get
			{
				return null;
			}
		}

		protected override int NameHashCode
		{
			get
			{
				return default(int);
			}
		}

		public JPropertyDescriptor(string name)
		{
		}

		public override bool CanResetValue(object component)
		{
			return default(bool);
		}

		public override object GetValue(object component)
		{
			return null;
		}

		public override void ResetValue(object component)
		{
		}

		public override void SetValue(object component, object value)
		{
		}

		public override bool ShouldSerializeValue(object component)
		{
			return default(bool);
		}
	}
}
