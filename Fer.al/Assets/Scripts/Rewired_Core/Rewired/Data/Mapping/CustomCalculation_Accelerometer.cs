using System;
using Rewired.Utils.Classes.Data;

namespace Rewired.Data.Mapping
{
	[Serializable]
	public sealed class CustomCalculation_Accelerometer : CustomCalculation
	{
		public enum CalculationType
		{
			Pitch,
			Roll
		}

		public enum OutputType
		{
			Axis,
			Angle
		}

		public enum InputType
		{
			Acceleration,
			UserAcceleration,
			Gravity
		}

		public CalculationType _calculationType;

		public InputType _inputType;

		public OutputType _outputType;

		internal override TypeWrapper.DataType ResultType
		{
			get
			{
				return default(TypeWrapper.DataType);
			}
		}

		internal override bool Process()
		{
			return default(bool);
		}

		private float VlFbFkKNFShaBpZYQmudNCSgmlkH()
		{
			return default(float);
		}

		private float zyHIVCjgmZsZjkMMGrqJKeZqzGw()
		{
			return default(float);
		}

		private float FebQTanNEDhUxWgOBFPSIeJPXSh(float P_0)
		{
			return default(float);
		}
	}
}
