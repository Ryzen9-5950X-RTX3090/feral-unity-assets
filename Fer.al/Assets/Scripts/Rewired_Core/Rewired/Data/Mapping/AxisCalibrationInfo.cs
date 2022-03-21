using System;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Data.Mapping
{
	[Serializable]
	public class AxisCalibrationInfo : IDeepCloneable
	{
		[SerializeField]
		private bool _applyRangeCalibration;

		[SerializeField]
		private bool _invert;

		[SerializeField]
		private float _deadZone;

		[SerializeField]
		private float _zero;

		[SerializeField]
		private float _min;

		[SerializeField]
		private float _max;

		[SerializeField]
		private AxisSensitivityType _sensitivityType;

		[SerializeField]
		private float _sensitivity;

		[SerializeField]
		private AnimationCurve _sensitivityCurve;

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

		public float zero
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float min
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float max
		{
			get
			{
				return default(float);
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

		public AxisCalibrationInfo()
		{
		}

		[CustomObfuscation]
		internal AxisCalibrationInfo(float deadZone, float zero, float min, float max, bool invert, bool applyRangeCalibration, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve)
		{
		}

		public object DeepClone()
		{
			return null;
		}

		internal static AxisCalibrationData LbiWXlbxPxDSZaTtREKkrsmdeyU(AxisCalibrationInfo P_0)
		{
			return default(AxisCalibrationData);
		}

		internal static AxisCalibrationInfo JjVWjhPGZPcNMdeifAPNqWqNdRQ(AxisCalibrationData P_0)
		{
			return null;
		}
	}
}
