using System.Collections.Generic;
using Rewired.Data.Mapping;
using UnityEngine;

namespace Rewired
{
	public struct AxisCalibrationData
	{
		public bool enabled;

		public float deadZone;

		public float zero;

		public float min;

		public float max;

		public bool invert;

		public AxisSensitivityType sensitivityType;

		public float sensitivity;

		public AnimationCurve sensitivityCurve;

		public bool applyRangeCalibration;

		[CustomObfuscation]
		internal Dictionary<int, AxisCalibrationInfo> calibrations;

		public static AxisCalibrationData Default
		{
			get
			{
				return default(AxisCalibrationData);
			}
		}

		[CustomObfuscation]
		internal static AxisCalibrationData Raw
		{
			get
			{
				return default(AxisCalibrationData);
			}
		}

		public AxisCalibrationData(bool enabled, float deadZone, float zero, float min, float max, bool invert, bool applyRangeCalibration)
		{
		}

		public AxisCalibrationData(bool enabled, float deadZone, float zero, float min, float max, bool invert, bool applyRangeCalibration, float sensitivity)
		{
		}

		public AxisCalibrationData(bool enabled, float deadZone, float zero, float min, float max, bool invert, bool applyRangeCalibration, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve)
		{
		}
	}
}
