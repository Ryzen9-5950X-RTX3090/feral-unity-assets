using System;
using Rewired.Interfaces;
using Rewired.Utils.Classes.Utility;
using UnityEngine;

namespace Rewired
{
	public sealed class Mouse : ControllerWithAxes
	{
		private TimerAbs mouseAxisPollingTimer;

		private float[] cumulativeMousePollingAxes;

		private Vector2 _screenPosition;

		private Vector2 _screenPositionPrev;

		private int _lastScreenPositionUpdateFrame;

		private readonly IUnifiedMouseSource _source;

		private static Guid s_deviceInstanceGuid;

		public Vector2 screenPosition
		{
			get
			{
				return default(Vector2);
			}
		}

		public Vector2 screenPositionPrev
		{
			get
			{
				return default(Vector2);
			}
		}

		public Vector2 screenPositionDelta
		{
			get
			{
				return default(Vector2);
			}
		}

		public override Guid deviceInstanceGuid
		{
			get
			{
				return default(Guid);
			}
		}

		internal Mouse(string name, IUnifiedMouseSource source)
		{
		}

		private Mouse(int controllerId, InputSource inputSource, string name, string hardwareIdentifier, int axisCount, int buttonCount, HardwareControllerMap_Game hardwareMap, Extension extension, ControllerDataUpdater dataUpdater)
		{
		}

		internal override void UpdateData(UpdateLoopType updateLoop)
		{
		}

		protected override bool IsPolledAxisActive(int index, out Pole pole, out int elementIdentifierId)
		{
			return default(bool);
		}

		internal override void Clear()
		{
		}

		internal override bool SetEnabled(bool state)
		{
			return default(bool);
		}

		private void RecordMouseScreenPosition()
		{
		}
	}
}
