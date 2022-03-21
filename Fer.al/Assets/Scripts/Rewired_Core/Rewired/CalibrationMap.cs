using System.Collections.Generic;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	[CustomClassObfuscation]
	public sealed class CalibrationMap
	{
		private AxisCalibration[] BqSdtKydcIEkoWCjLJvCiEzwQMG;

		private IList<AxisCalibration> rqqsgekTexjiWgufmqhWDSQKukG;

		private readonly int vSShldFHkaZKEuThltrSgFmPfc;

		public IList<AxisCalibration> Axes
		{
			get
			{
				return null;
			}
		}

		public int axisCount
		{
			get
			{
				return default(int);
			}
		}

		private CalibrationMap()
		{
		}

		internal CalibrationMap(AxisCalibrationData[] hardwareAxisCalibrationData)
		{
		}

		public CalibrationMap(AxisCalibration[] axisCalibrations)
		{
		}

		public void Reset()
		{
		}

		public AxisCalibration GetAxis(int index)
		{
			return null;
		}

		public float GetCalibratedValue(int axisIndex, float value)
		{
			return default(float);
		}

		public bool SetAxisData(int index, AxisCalibrationData data)
		{
			return default(bool);
		}

		public AxisCalibrationData GetAxisData(int index)
		{
			return default(AxisCalibrationData);
		}

		internal void CopyFrom(CalibrationMap map, bool copyHardwareDeadzone)
		{
		}

		public string ToXmlString()
		{
			return null;
		}

		public string ToJsonString()
		{
			return null;
		}

		public bool ImportXmlString(string xmlString)
		{
			return default(bool);
		}

		public bool ImportJsonString(string jsonString)
		{
			return default(bool);
		}

		private SerializedObject uJZpqEBLkJUYeZxXRkMWiNxeekH()
		{
			return null;
		}

		private void BxoFMvWmvalDyQMZPpCVmdbosOa(SerializedObject P_0)
		{
		}

		internal Vector2 GetCalibrated2DValue(int xAxisIndex, int yAxisIndex, float valueRawX, float valueRawY, DeadZone2DType deadZoneType, AxisSensitivity2DType sensitivityType)
		{
			return default(Vector2);
		}
	}
}
