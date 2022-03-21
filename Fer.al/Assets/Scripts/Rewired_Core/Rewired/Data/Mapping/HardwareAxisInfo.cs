using System;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Data.Mapping
{
	[Serializable]
	public class HardwareAxisInfo : IDeepCloneable
	{
		[SerializeField]
		internal AxisCoordinateMode _dataFormat;

		[SerializeField]
		internal bool _excludeFromPolling;

		[SerializeField]
		internal SpecialAxisType _specialAxisType;

		public AxisCoordinateMode dataFormat
		{
			get
			{
				return default(AxisCoordinateMode);
			}
		}

		public bool excludeFromPolling
		{
			get
			{
				return default(bool);
			}
		}

		public SpecialAxisType specialAxisType
		{
			get
			{
				return default(SpecialAxisType);
			}
		}

		[CustomObfuscation]
		internal static HardwareAxisInfo Default
		{
			get
			{
				return null;
			}
		}

		public HardwareAxisInfo()
		{
		}

		[CustomObfuscation]
		internal HardwareAxisInfo(AxisCoordinateMode dataFormat, bool excludeFromPolling, SpecialAxisType specialAxisType)
		{
		}

		public object DeepClone()
		{
			return null;
		}
	}
}
