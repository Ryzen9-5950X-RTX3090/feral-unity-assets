using System;
using System.Collections.Generic;
using Rewired.Data.Mapping;
using Rewired.Utils.Attributes;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	[CustomClassObfuscation]
	public sealed class AxisCalibration
	{
		private AlternateAxisCalibrationType _calibrationMode;

		private Dictionary<int, AxisCalibrationInfo> _hardwareCalibrations;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Enables or disables the Axis. A disabled Axis always returns a value of 0.")]
		private bool _enabled;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Enables or disables the Axis. A disabled Axis always returns a value of 0.")]
		private float _deadZone;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Enables or disables the Axis. A disabled Axis always returns a value of 0.")]
		private float _calibratedZero;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Gets or sets the minimum value. This can be used to transform the value to a new range.")]
		private float _calibratedMin;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Gets or sets the maximum value. This can be used to transform the value to a new range.")]
		private float _calibratedMax;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("If true, the final value will be multiplied by -1. This can be used to correct an inverted Axis.")]
		private bool _invert;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Determines how sensitivity will be calculated.\nIf sensitivityType is set to Multiplier or Power, the sensitivity property is used to calculate the value.\nIf sensitivityType is set to Curve, the sensitivityCurve property is used to calculate the value.")]
		private AxisSensitivityType _sensitivityType;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Gets or sets the sensitivity value.")]
		[FieldRange(0f, float.PositiveInfinity)]
		private float _sensitivity;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Gets or sets the sensitivity curve. The curve has no effect unless sensitivityType is set to Curve.")]
		private AnimationCurve _sensitivityCurve;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("If enabled, calibratedMin, calibratedMax, and calibratedZero will be used to convert the value to a new range.\nIf disabled, calibratedMin, calibratedMax, and calibratedZero will have no effect on the final value.")]
		private bool _applyRangeCalibration;

		public bool enabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float deadZone
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float calibratedZero
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float calibratedMin
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float calibratedMax
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool invert
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public AxisSensitivityType sensitivityType
		{
			get
			{
				return default(AxisSensitivityType);
			}
			set
			{
			}
		}

		public float sensitivity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public AnimationCurve sensitivityCurve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool applyRangeCalibration
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		internal AlternateAxisCalibrationType calibrationMode
		{
			get
			{
				return default(AlternateAxisCalibrationType);
			}
			set
			{
			}
		}

		internal AxisCalibration()
		{
		}

		internal AxisCalibration(bool enabled, Dictionary<int, AxisCalibrationInfo> hardwareCalibrations, float deadZone, float calibratedZero, float calibratedMin, float calibratedMax, bool invert, bool applyRangeCalibration, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve)
		{
		}

		internal AxisCalibration(AxisCalibrationData hardwareData)
		{
		}

		internal void CopyFrom(AxisCalibration data, bool copyHardwareData)
		{
		}

		public float GetCalibratedValue(float value)
		{
			return default(float);
		}

		internal float GetCalibratedValue(float value, float customDeadzone, bool applySensitivity, bool applyInversion)
		{
			return default(float);
		}

		public float GetCalibratedValue(float value, AxisRange axisRange)
		{
			return default(float);
		}

		internal float GetCalibratedValue(float value, AxisRange axisRange, float customDeadzone, bool applySensitivity, bool applyInversion)
		{
			return default(float);
		}

		public AxisCalibrationData GetData()
		{
			return default(AxisCalibrationData);
		}

		public void SetData(AxisCalibrationData data)
		{
		}

		public void Reset()
		{
		}

		internal SerializedObject ExportData()
		{
			return null;
		}

		internal void Import(SerializedObject serializedObject)
		{
		}

		private void InitHardwareCalibrations(Dictionary<int, AxisCalibrationInfo> hardwareCalibrations, AxisCalibrationData defaultData)
		{
		}

		private void CreateDefaultHardwareCalibration(AxisCalibrationData defaultData)
		{
		}

		private AxisCalibrationInfo GetHardwareDefault()
		{
			return null;
		}

		internal static AxisCalibration CreateRelative()
		{
			return null;
		}
	}
}
