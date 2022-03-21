using System;

namespace Rewired
{
	public struct ControllerIdentifier
	{
		private int tiHDqwuWnAypLNJNoTzBctdWRZt;

		private ControllerType jVRvmdSGLvngKifezJIAQbIZrmi;

		private Guid OYSjChAEXTYpiFBMHycpqxKbEmz;

		private string OdSoWXsumyESESqfPIKsgkcfXAR;

		private Guid HQfpOGFaxPuxONqxAeTQxVlmeig;

		public int controllerId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public ControllerType controllerType
		{
			get
			{
				return default(ControllerType);
			}
			set
			{
			}
		}

		public Guid hardwareTypeGuid
		{
			get
			{
				return default(Guid);
			}
			set
			{
			}
		}

		public string hardwareIdentifier
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Guid deviceInstanceGuid
		{
			get
			{
				return default(Guid);
			}
			set
			{
			}
		}

		public static ControllerIdentifier Blank
		{
			get
			{
				return default(ControllerIdentifier);
			}
		}

		internal ControllerIdentifier(Controller controller)
		{
		}
	}
}
