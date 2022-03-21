using System;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	public sealed class InputBehavior
	{
		[CustomObfuscation]
		[SerializeField]
		private int _id;

		[CustomObfuscation]
		[SerializeField]
		private string _name;

		[CustomObfuscation]
		[SerializeField]
		private float _joystickAxisSensitivity;

		[CustomObfuscation]
		[SerializeField]
		private bool _digitalAxisSimulation;

		[CustomObfuscation]
		[SerializeField]
		private bool _digitalAxisSnap;

		[CustomObfuscation]
		[SerializeField]
		private bool _digitalAxisInstantReverse;

		[SerializeField]
		[CustomObfuscation]
		private float _digitalAxisGravity;

		[CustomObfuscation]
		[SerializeField]
		private float _digitalAxisSensitivity;

		[CustomObfuscation]
		[SerializeField]
		private MouseXYAxisMode _mouseXYAxisMode;

		[SerializeField]
		[CustomObfuscation]
		private MouseOtherAxisMode _mouseOtherAxisMode;

		[CustomObfuscation]
		[SerializeField]
		private float _mouseXYAxisSensitivity;

		[SerializeField]
		[CustomObfuscation]
		private MouseXYAxisDeltaCalc _mouseXYAxisDeltaCalc;

		[SerializeField]
		[CustomObfuscation]
		private float _mouseOtherAxisSensitivity;

		[CustomObfuscation]
		[SerializeField]
		private float _customControllerAxisSensitivity;

		[CustomObfuscation]
		[SerializeField]
		private float _buttonDoublePressSpeed;

		[SerializeField]
		[CustomObfuscation]
		private float _buttonShortPressTime;

		[SerializeField]
		[CustomObfuscation]
		private float _buttonShortPressExpiresIn;

		[SerializeField]
		[CustomObfuscation]
		private float _buttonLongPressTime;

		[SerializeField]
		[CustomObfuscation]
		private float _buttonLongPressExpiresIn;

		[SerializeField]
		[CustomObfuscation]
		private float _buttonDeadZone;

		[SerializeField]
		[CustomObfuscation]
		private float _buttonDownBuffer;

		[SerializeField]
		[CustomObfuscation]
		private float _buttonRepeatRate;

		[CustomObfuscation]
		[SerializeField]
		private float _buttonRepeatDelay;

		public int id
		{
			get
			{
				return default(int);
			}
			internal set
			{
			}
		}

		public string name
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public float joystickAxisSensitivity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool digitalAxisSimulation
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool digitalAxisSnap
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool digitalAxisInstantReverse
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float digitalAxisGravity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float digitalAxisSensitivity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public MouseXYAxisMode mouseXYAxisMode
		{
			get
			{
				return default(MouseXYAxisMode);
			}
			set
			{
			}
		}

		public MouseOtherAxisMode mouseOtherAxisMode
		{
			get
			{
				return default(MouseOtherAxisMode);
			}
			set
			{
			}
		}

		public float mouseXYAxisSensitivity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public MouseXYAxisDeltaCalc mouseXYAxisDeltaCalc
		{
			get
			{
				return default(MouseXYAxisDeltaCalc);
			}
			set
			{
			}
		}

		public float mouseOtherAxisSensitivity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float customControllerAxisSensitivity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float buttonDoublePressSpeed
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float buttonShortPressTime
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float buttonShortPressExpiresIn
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float buttonLongPressTime
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float buttonLongPressExpiresIn
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float buttonDeadZone
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float buttonDownBuffer
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float buttonRepeatRate
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float buttonRepeatDelay
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public InputBehavior()
		{
		}

		public InputBehavior(InputBehavior source)
		{
		}

		public string ToXmlString()
		{
			return null;
		}

		public bool ImportXmlString(string xmlString)
		{
			return default(bool);
		}

		public string ToJsonString()
		{
			return null;
		}

		public bool ImportJsonString(string jsonString)
		{
			return default(bool);
		}

		public bool ImportData(InputBehavior inputBehavior)
		{
			return default(bool);
		}

		public InputBehavior Clone()
		{
			return null;
		}

		public void Reset()
		{
		}

		internal SerializedObject JijNtvxBfxSyvZqRuViZInoAdyr()
		{
			return null;
		}

		internal void oOJgtRfrJindxeXPtlOXKDmATym(SerializedObject P_0)
		{
		}

		private static void NdcJYipIwyegYQfyTrsLRzhzdYx(InputBehavior P_0, InputBehavior P_1, bool P_2)
		{
		}
	}
}
