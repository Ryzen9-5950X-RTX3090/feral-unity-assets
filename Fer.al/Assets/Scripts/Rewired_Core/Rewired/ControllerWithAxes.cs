using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Rewired
{
	public abstract class ControllerWithAxes : ControllerWithMap
	{
		protected readonly int _axisCount;

		protected readonly int _axis2DCount;

		protected readonly Axis[] axes;

		protected readonly ReadOnlyCollection<Axis> axes_readOnly;

		protected readonly Axis2D[] axes2D;

		protected readonly ReadOnlyCollection<Axis2D> axes2D_readOnly;

		protected CalibrationMap _calibrationMap;

		private float[] gcUIqYzphGzXesYISQtMAneCyQL;

		private uint PseRHBIlRcUNTLqiVuKUiknWMPT;

		private Func<int, int> EotiliTrgdUTSJkOZdzwhNzvaUiG;

		public int axisCount
		{
			get
			{
				return default(int);
			}
		}

		public int axis2DCount
		{
			get
			{
				return default(int);
			}
		}

		public IList<Axis> Axes
		{
			get
			{
				return null;
			}
		}

		public IList<Axis2D> Axes2D
		{
			get
			{
				return null;
			}
		}

		public CalibrationMap calibrationMap
		{
			get
			{
				return null;
			}
		}

		public IList<ControllerElementIdentifier> AxisElementIdentifiers
		{
			get
			{
				return null;
			}
		}

		internal ControllerWithAxes(int controllerId, InputSource inputSource, string name, string hardwareName, string hardwareIdentifier, ControllerType type, Guid hardwareTypeGuid, int axisCount, int buttonCount, bool[] isButtonPressureSensitive, HardwareControllerMap_Game hardwareMap, Extension extension, ControllerDataUpdater dataUpdater)
		{
		}

		public override Element GetElementById(int elementIdentifierId)
		{
			return null;
		}

		public int GetAxisIndexById(int elementIdentifierId)
		{
			return default(int);
		}

		public float GetAxis(int index)
		{
			return default(float);
		}

		public float GetAxisPrev(int index)
		{
			return default(float);
		}

		public float GetAxisRaw(int index)
		{
			return default(float);
		}

		public float GetAxisRawPrev(int index)
		{
			return default(float);
		}

		public float GetAxisTimeActive(int index)
		{
			return default(float);
		}

		public float GetAxisTimeInactive(int index)
		{
			return default(float);
		}

		public float GetAxisLastTimeActive(int index)
		{
			return default(float);
		}

		public float GetAxisLastTimeInactive(int index)
		{
			return default(float);
		}

		public float GetAxisRawTimeActive(int index)
		{
			return default(float);
		}

		public float GetAxisRawTimeInactive(int index)
		{
			return default(float);
		}

		public float GetAxisRawLastTimeActive(int index)
		{
			return default(float);
		}

		public float GetAxisRawLastTimeInactive(int index)
		{
			return default(float);
		}

		public float GetAxisById(int elementIdentifierId)
		{
			return default(float);
		}

		public float GetAxisPrevById(int elementIdentifierId)
		{
			return default(float);
		}

		public float GetAxisRawById(int elementIdentifierId)
		{
			return default(float);
		}

		public float GetAxisRawPrevById(int elementIdentifierId)
		{
			return default(float);
		}

		public float GetAxisTimeActiveById(int elementIdentifierId)
		{
			return default(float);
		}

		public float GetAxisTimeInactiveById(int elementIdentifierId)
		{
			return default(float);
		}

		public float GetAxisLastTimeActiveById(int elementIdentifierId)
		{
			return default(float);
		}

		public float GetAxisLastTimeInactiveById(int elementIdentifierId)
		{
			return default(float);
		}

		public float GetAxisRawTimeActiveById(int elementIdentifierId)
		{
			return default(float);
		}

		public float GetAxisRawTimeInactiveById(int elementIdentifierId)
		{
			return default(float);
		}

		public float GetAxisRawLastTimeActiveById(int elementIdentifierId)
		{
			return default(float);
		}

		public float GetAxisRawLastTimeInactiveById(int elementIdentifierId)
		{
			return default(float);
		}

		public Vector2 GetAxis2D(int index)
		{
			return default(Vector2);
		}

		public Vector2 GetAxis2DPrev(int index)
		{
			return default(Vector2);
		}

		public Vector2 GetAxis2DRaw(int index)
		{
			return default(Vector2);
		}

		public Vector2 GetAxis2DRawPrev(int index)
		{
			return default(Vector2);
		}

		public override float GetLastTimeActive()
		{
			return default(float);
		}

		public override float GetLastTimeActive(bool useRawValues)
		{
			return default(float);
		}

		public override float GetLastTimeAnyElementChanged()
		{
			return default(float);
		}

		public override float GetLastTimeAnyElementChanged(bool useRawValues)
		{
			return default(float);
		}

		public float GetLastTimeAnyAxisActive()
		{
			return default(float);
		}

		public float GetLastTimeAnyAxisActive(bool useRawValues)
		{
			return default(float);
		}

		public float GetLastTimeAnyAxisChanged()
		{
			return default(float);
		}

		public float GetLastTimeAnyAxisChanged(bool useRawValues)
		{
			return default(float);
		}

		public override ControllerPollingInfo PollForFirstElement()
		{
			return default(ControllerPollingInfo);
		}

		public override ControllerPollingInfo PollForFirstElementDown()
		{
			return default(ControllerPollingInfo);
		}

		public ControllerPollingInfo PollForFirstAxis()
		{
			return default(ControllerPollingInfo);
		}

		public override IEnumerable<ControllerPollingInfo> PollForAllElements()
		{
			return null;
		}

		public override IEnumerable<ControllerPollingInfo> PollForAllElementsDown()
		{
			return null;
		}

		public IEnumerable<ControllerPollingInfo> PollForAllAxes()
		{
			return null;
		}

		private void FWfIShfTbcuUKciiAtgjxfVNQmh()
		{
		}

		protected virtual bool IsPolledAxisActive(int index, out Pole pole, out int elementIdentifierId)
		{
			return default(bool);
		}

		public bool ImportCalibrationMapFromXmlString(string xmlString)
		{
			return default(bool);
		}

		public bool ImportCalibrationMapFromJsonString(string jsonString)
		{
			return default(bool);
		}

		internal override void UpdateData(UpdateLoopType P_0)
		{
		}

		internal bool ZCwSgWICOtGrttGFfncnGpDlgEa(ActionElementMap P_0, int P_1, bool P_2, bool P_3, out float P_4)
		{
			return default(bool);
		}

		internal override void BakeMap(ControllerMap P_0)
		{
		}

		internal override void BakeActionElementMap(ControllerMap P_0, ActionElementMap P_1)
		{
		}

		internal void zqYZancoLvjwyJrtvfMQBRgBvCOJ()
		{
		}

		internal override void Clear()
		{
		}

		[CompilerGenerated]
		private IEnumerable<ControllerPollingInfo> tfjkAeqeyeISOpYFEFSfmAcEdOcE()
		{
			return null;
		}

		[CompilerGenerated]
		private IEnumerable<ControllerPollingInfo> mUZbNIaWJplRJrsbIEGGxbMeJSw()
		{
			return null;
		}
	}
}
