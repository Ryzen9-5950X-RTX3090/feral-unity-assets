using System;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	[CustomClassObfuscation]
	public sealed class Axis2DCalibration
	{
		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The calculation type for the dead zone.")]
		private DeadZone2DType _deadZoneType;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Calculation type for sensitivity on 2D axes.")]
		private AxisSensitivity2DType _sensitivityType;

		public DeadZone2DType deadZoneType
		{
			get
			{
				return default(DeadZone2DType);
			}
			set
			{
			}
		}

		public AxisSensitivity2DType sensitivityType
		{
			get
			{
				return default(AxisSensitivity2DType);
			}
			set
			{
			}
		}

		internal Axis2DCalibration()
		{
		}

		internal Vector2 GetCalibrated2DValue(float valueRawX, float valueRawY, AxisCalibration xAxis, AxisCalibration yAxis)
		{
			return default(Vector2);
		}

		internal static Vector2 GetCalibrated2DValue(float valueRawX, float valueRawY, AxisCalibration xAxis, AxisCalibration yAxis, DeadZone2DType deadZoneType, AxisSensitivity2DType sensitivityType)
		{
			return default(Vector2);
		}
	}
}
