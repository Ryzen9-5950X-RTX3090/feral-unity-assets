using System;

namespace Rewired.Internal
{
	public static class ControllerTemplateFactory
	{
		private static readonly Type[] _defaultTemplateTypes;

		private static readonly Type[] _defaultTemplateInterfaceTypes;

		public static Type[] templateTypes
		{
			get
			{
				return null;
			}
		}

		public static Type[] templateInterfaceTypes
		{
			get
			{
				return null;
			}
		}

		public static IControllerTemplate Create(Guid typeGuid, object payload)
		{
			return null;
		}
	}
}
