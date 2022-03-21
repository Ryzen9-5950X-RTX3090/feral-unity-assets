using System;
using UnityEngine;

namespace Rewired.Internal
{
	[Serializable]
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal sealed class StandaloneAxis
	{
		[CustomObfuscation]
		public delegate void AxisValueChangedEventHandler(float value);

		[CustomObfuscation]
		public delegate void ButtonValueChangedEventHandler(bool value);

		[CustomObfuscation]
		public delegate void ButtonDownEventHandler();

		[CustomObfuscation]
		public delegate void ButtonUpEventHandler();

		[CustomObfuscation]
		[SerializeField]
		[Range(0f, 1f)]
		[Tooltip("The axis value at or above which the buttonValue property will return True. This will also return true for negative values below the inverse of this threshold.")]
		private float _buttonActivationThreshold;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Contains calibration settings for the axis.")]
		private AxisCalibration _calibration;

		[CustomObfuscation]
		private float _valueRaw;

		[CustomObfuscation]
		private float _valueRawPrev;

		private AxisValueChangedEventHandler dXAglJjpHkbNtdLxhsZnPZwJEng;

		private AxisValueChangedEventHandler TaQyEdYwYVHQUwxJDzTbodieLtP;

		private ButtonDownEventHandler OLmLRwxptWfeNuvRgDhkOVwWUsu;

		private ButtonUpEventHandler gETnJjGtNYDZZudXLejAQtgkEQM;

		private ButtonValueChangedEventHandler wFejUNCquyLBROLHKlxMOSVfUXM;

		private ButtonDownEventHandler eCajIQOTOCtTifwJnxBRfZhyEtz;

		private ButtonUpEventHandler tajjrYdwibecwImnKNvoVUyDgJzI;

		private ButtonValueChangedEventHandler fUohedelHJVYiCjiMehPipaUDlv;

		public float buttonActivationThreshold
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public AxisCalibration calibration
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public float valueRaw
		{
			get
			{
				return default(float);
			}
			private set
			{
			}
		}

		public float valueRawPrev
		{
			get
			{
				return default(float);
			}
			private set
			{
			}
		}

		public float valueRawDelta
		{
			get
			{
				return default(float);
			}
		}

		public float value
		{
			get
			{
				return default(float);
			}
		}

		public float valuePrev
		{
			get
			{
				return default(float);
			}
		}

		public float valueDelta
		{
			get
			{
				return default(float);
			}
		}

		public bool rawButtonValue
		{
			get
			{
				return default(bool);
			}
		}

		public bool rawButtonValuePrev
		{
			get
			{
				return default(bool);
			}
		}

		public bool buttonValue
		{
			get
			{
				return default(bool);
			}
		}

		public bool buttonValuePrev
		{
			get
			{
				return default(bool);
			}
		}

		internal float rawMin
		{
			get
			{
				return default(float);
			}
		}

		internal float rawMax
		{
			get
			{
				return default(float);
			}
		}

		internal float rawZero
		{
			get
			{
				return default(float);
			}
		}

		private event AxisValueChangedEventHandler _AxisValueChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event AxisValueChangedEventHandler AxisValueChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private event AxisValueChangedEventHandler _RawAxisValueChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event AxisValueChangedEventHandler RawAxisValueChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private event ButtonDownEventHandler _ButtonDownEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event ButtonDownEventHandler ButtonDownEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private event ButtonUpEventHandler _ButtonUpEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event ButtonUpEventHandler ButtonUpEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private event ButtonValueChangedEventHandler _ButtonValueChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event ButtonValueChangedEventHandler ButtonValueChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private event ButtonDownEventHandler _RawButtonDownEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event ButtonDownEventHandler RawButtonDownEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private event ButtonUpEventHandler _RawButtonUpEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event ButtonUpEventHandler RawButtonUpEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private event ButtonValueChangedEventHandler _RawButtonValueChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event ButtonValueChangedEventHandler RawButtonValueChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal StandaloneAxis()
		{
		}

		public void SetRawValue(float value)
		{
		}

		public void Clear()
		{
		}

		[CustomObfuscation]
		internal static StandaloneAxis CreateRelative()
		{
			return null;
		}
	}
}
