using System;
using Rewired.ComponentControls.Data;
using Rewired.Internal;
using UnityEngine;

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent]
	public sealed class TiltControl : CustomControllerControl
	{
		public enum TiltDirection
		{
			Both,
			Horizontal,
			Forward
		}

		private const float maxFullTiltAngle = 180f;

		private const float maxAngleOffset = 90f;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The tilt directions in which movement is allowed. You can restrict movement to one or both directions.")]
		private TiltDirection _allowedTiltDirections;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The Custom Controller element that will receive input values from the X axis.")]
		private CustomControllerElementTargetSetForFloat _horizontalTiltCustomControllerElement;

		[CustomObfuscation]
		[SerializeField]
		[Range(0f, 180f)]
		[Tooltip("The maximum horizontal tilt angle in degrees. When the device is tilted to this angle or further in either direction, the axis will return a value of 1/-1.")]
		private float _horizontalTiltLimit;

		[SerializeField]
		[CustomObfuscation]
		[Range(-90f, 90f)]
		[Tooltip("The offset angle from horizontal which will be considered the resting angle. This represents the angle at which the user holds the device without generating tilt.")]
		private float _horizontalRestAngle;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("The Custom Controller element that will receive input values from the Y axis.")]
		private CustomControllerElementTargetSetForFloat _forwardTiltCustomControllerElement;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The maximum forward tilt angle in degrees. When the device is tilted to this angle or further in either direction, the axis will return a value of 1/-1.")]
		[Range(0f, 180f)]
		private float _forwardTiltLimit;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("The offset angle from vertical which will be considered the resting angle. This represents the angle at which the user holds the device without generating tilt. A typical value would be around 40 degrees.")]
		[Range(-90f, 90f)]
		private float _forwardRestAngle;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("The underlying 2D axis.")]
		private StandaloneAxis2D _axis2D;

		private bool _useHAxis;

		private bool _useFAxis;

		private Func<Vector3> _getAccelerationValue;

		public TiltDirection axesToUse
		{
			get
			{
				return default(TiltDirection);
			}
			set
			{
			}
		}

		public CustomControllerElementTargetSetForFloat horizontalTiltCustomControllerElement
		{
			get
			{
				return null;
			}
		}

		public float horizontalTiltLimit
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float horizontalRestAngle
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public CustomControllerElementTargetSetForFloat forwardTiltCustomControllerElement
		{
			get
			{
				return null;
			}
		}

		public float forwardTiltLimit
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float forwardRestAngle
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public AxisCalibration horizontalAxisCalibration
		{
			get
			{
				return null;
			}
		}

		public AxisCalibration verticalAxisCalibration
		{
			get
			{
				return null;
			}
		}

		[Obsolete]
		public Axis2DCalibration deadZoneType
		{
			get
			{
				return null;
			}
		}

		public Axis2DCalibration axis2DCalibration
		{
			get
			{
				return null;
			}
		}

		internal StandaloneAxis2D axis2D
		{
			get
			{
				return null;
			}
		}

		private Vector3 acceleration
		{
			get
			{
				return default(Vector3);
			}
		}

		[CustomObfuscation]
		internal TiltControl()
		{
		}

		public void SetAccelerationSourceCallback(Func<Vector3> callback)
		{
		}

		public void SetRestOrientation()
		{
		}

		[CustomObfuscation]
		internal override void OnValidate()
		{
		}

		internal override bool OnInitialize()
		{
			return default(bool);
		}

		internal override void OnUpdate()
		{
		}

		internal override void OnCustomControllerUpdate()
		{
		}

		public override void ClearValue()
		{
		}

		private void yoIzXjrqilGxCRhYNevhdDdokJQ()
		{
		}

		private void IXEKEFykLRaswFEjRpcTUAFhbDi()
		{
		}

		private void dzynYViRaRMlteHKPpYVKSjcRik(TiltDirection P_0)
		{
		}
	}
}
