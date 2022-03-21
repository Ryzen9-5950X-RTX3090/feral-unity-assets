using System.Collections.Generic;
using Rewired.Config;
using Rewired.Data.Mapping;

namespace Rewired
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal static class EnumConverter
	{
		public static int ToUpdateLoopTypes(UpdateLoopSetting updateLoopSetting, List<UpdateLoopType> results)
		{
			return default(int);
		}

		public static AlternateAxisCalibrationType ToAlternateAxisCalibrationType(ThrottleCalibrationMode throttleCalibrationMode)
		{
			return default(AlternateAxisCalibrationType);
		}
	}
}
