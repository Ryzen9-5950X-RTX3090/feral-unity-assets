using System;

namespace Rewired
{
	public sealed class FlightPedalsTemplate : ControllerTemplate, IFlightPedalsTemplate, IControllerTemplate
	{
		public static readonly Guid typeGuid;

		public const int elementId_leftPedal = 0;

		public const int elementId_rightPedal = 1;

		public const int elementId_slide = 2;

		IControllerTemplateAxis IFlightPedalsTemplate.leftPedal
		{
			get
			{
				return null;
			}
		}

		IControllerTemplateAxis IFlightPedalsTemplate.rightPedal
		{
			get
			{
				return null;
			}
		}

		IControllerTemplateAxis IFlightPedalsTemplate.slide
		{
			get
			{
				return null;
			}
		}

		public FlightPedalsTemplate(object payload)
		{
		}
	}
}
