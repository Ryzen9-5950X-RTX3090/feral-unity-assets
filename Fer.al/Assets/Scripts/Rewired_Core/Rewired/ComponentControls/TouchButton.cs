using System;
using System.Collections;
using System.Collections.Generic;
using Rewired.ComponentControls.Data;
using Rewired.Internal;
using Rewired.Utils.Attributes;
using Rewired.Utils.UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Rewired.ComponentControls
{
	[Serializable]
	[CustomClassObfuscation]
	[DisallowMultipleComponent]
	public sealed class TouchButton : TouchInteractable
	{
		public enum ButtonType
		{
			Standard,
			ToggleSwitch
		}

		private enum nmJOdZmANObDJaNczzHbyFiChru
		{
			PoBZZNoYGVGuWkUBxQqhGBhFqWy,
			mECSSpoPNQyVKtfFebLkjUXhvjOu,
			PRJNKxHAbZjpzWKQNbgkjaPwroE
		}

		private enum dxNLfNtXMVHVLbHogBSUeLBVzVc
		{
			IjuFlluoMybUtpSqFtBQAlMgUyR,
			gNafaKVthTKHmnfzOTdmjsbShkI
		}

		[Serializable]
		public class AxisValueChangedEventHandler : UnityEvent<float>
		{
		}

		[Serializable]
		public class ButtonValueChangedEventHandler : UnityEvent<bool>
		{
		}

		[Serializable]
		public class ButtonDownEventHandler : UnityEvent
		{
		}

		[Serializable]
		public class ButtonUpEventHandler : UnityEvent
		{
		}

		private const float bIrMhBPndqbqBcilJMwjpMxegcN = 20f;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("The Custom Controller element that will receive input values from this control.")]
		private CustomControllerElementTargetSetForFloat _targetCustomControllerElement;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("The type of button.\nStandard: A momentary switch. Returns True while the button is pressed down.\nToggle Switch: Alternately turns on and off with each press.")]
		private ButtonType _buttonType;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("If true, the button can be turned on by a touch swipe that began in an area outside the button region. If false, the button can only be turned on by a direct press.")]
		private bool _activateOnSwipeIn;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("If true, the button will stay on even if the touch that activated it moves outside the button region. If false, the button will turn off once the touch that activated it moves outside the button region.")]
		private bool _stayActiveOnSwipeOut;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Makes the axis value gradually change over time based on gravity and sensitivity as the button is pressed.")]
		private bool _useDigitalAxisSimulation;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Speed (units/sec) that the axis value falls toward 0 when not pressed. A value of 1.0 means an axis value of 1 will drain to 0 over 1 second. A value of 3 equates to 1/3 of a second, and so on.")]
		[FieldRange(0f, float.PositiveInfinity)]
		private float _digitalAxisGravity;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Speed to move toward an axis value of 1.0 in units/sec when pressed. A value of 1.0 means an axis value of 0 will reach 1 over 1 second. A value of 3 equates to 1/3 of a second, and so on.")]
		[FieldRange(0f, float.PositiveInfinity)]
		private float _digitalAxisSensitivity;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("The internal axis of the button. The axis is used for all value calculations.")]
		private StandaloneAxis _axis;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Optional external region to use for hover/click/touch detection. If set, this region will be used for touch detection instead of or in addition to the button's RectTransform. This can be useful if you want a larger area of the screen to act as a button.")]
		private TouchRegion _touchRegion;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("If True, hovers/clicks/touches on the local button will be ignored and only Touch Region touches will be used. Otherwise, both touches on the button and on the Touch Region will be used. This also applies to mouse hover. This setting has no effect if no Touch Region is set.")]
		private bool _useTouchRegionOnly;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("If True, the button will move to the location of the current touch in the Touch Region. This can be used to designate an area of the screen as a hot-spot for a button and have the button graphics follow the users touches. This only has an effect if a Touch Region is set.")]
		private bool _moveToTouchPosition;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("If Move To Touch Position is enabled, this will make the button return to its original position after the press is released. This only has an effect if a Touch Region is set.")]
		private bool _returnOnRelease;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("If True, the button will follow the touch around until released. This setting overrides Move To Touch Position.")]
		private bool _followTouchPosition;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Should the button animate when moving to the touch point? This only has an effect if Move To Touch Position is True and a Touch Region is set. This setting is ignored if Follow Touch Position is True.")]
		private bool _animateOnMoveToTouch;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The speed at which the button will move toward the touch position measured in screens per second (based on the larger of width and height). [1.0 = Move 1 screen/sec]. This only has an effect if Move To Touch Position is True, Animate On Move To Touch is true, and a Touch Region is set. This setting is ignored if Follow Touch Position is True.")]
		[Range(0f, 20f)]
		private float _moveToTouchSpeed;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Should the button animate when moving back to its original position? This only has an effect if Follow Touch Position is True, or if Move To Touch Position is True and a Touch Region is set, and Return on Release is True.")]
		private bool _animateOnReturn;

		[CustomObfuscation]
		[SerializeField]
		[Range(0f, 20f)]
		[Tooltip("The speed at which the button will move back toward its original position measured in screens per second (based on the larger of width and height). [1.0 = Move 1 screen/sec]. This only has an effect if Follow Touch Position is True, or if Move To Touch Position is True and a Touch Region is set, and Return on Release and Animate on Return are both True.")]
		private float _returnSpeed;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("If True, it will attempt to automatically manage Graphic component raycasting for best results based on your current settings.")]
		private bool _manageRaycasting;

		private float zZnZVrLVyeqSsazfkZvelwsSOc;

		private float wlpbaVGQEViyvpKziXzyOTnaBtz;

		private TouchRegion cBhbvMMZNVdkVwMGcOhbZxYnKTO;

		private Vector2 CVNaZFKWpgHSEgdRNrUgPhPiNrX;

		private bool MejCErHRHJfvFEhWTCJGiWTOfjPq;

		private bool PqDTICcamAIrJJSjGLHKIVPznycN;

		private nmJOdZmANObDJaNczzHbyFiChru BuFtCznxroTCJTiccGSuCkoFGWe;

		private int NnlmxMWJcRhEzfWxChxgLDOjRLL;

		private int eLvDEkOWbJEhaAfNqwHMvBxRCnIg;

		[NonSerialized]
		private bool byeanBfvjEeOOwRBSBerFwsuBMBA;

		[NonSerialized]
		private bool IXgubBiHZOnBAjLkDRcJjAfbtyr;

		private IEnumerator iIJgAsbKKxNMNtomWTaEUMVoAnvE;

		private FulEHeUoVkyNDHjDfouzidfyihgB uRBiOcOtAqAvLhajjVPQsbibEfy;

		private Action<nmJOdZmANObDJaNczzHbyFiChru> UStkkCNXENjKTUJtDQelaVCUhFl;

		private Action<nmJOdZmANObDJaNczzHbyFiChru> xuoFMVdYOOMYiQeBvgkKMKxlnlAJ;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Event sent when the axis value changes.")]
		private AxisValueChangedEventHandler _onAxisValueChanged;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Event sent when the button value changes.")]
		private ButtonValueChangedEventHandler _onButtonValueChanged;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Event sent when the button is pressed.")]
		private ButtonDownEventHandler _onButtonDown;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Event sent when the button is released.")]
		private ButtonUpEventHandler _onButtonUp;

		private Dictionary<int, PointerEventData> jYkJWWoFPivcEUzseannefjOlcc;

		public CustomControllerElementTargetSetForFloat targetCustomControllerElement
		{
			get
			{
				return null;
			}
		}

		public ButtonType buttonType
		{
			get
			{
				return default(ButtonType);
			}
			set
			{
			}
		}

		public bool activateOnSwipeIn
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool stayActiveOnSwipeOut
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool useDigitalAxisSimulation
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

		public TouchRegion touchRegion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool useTouchRegionOnly
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool moveToTouchPosition
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool returnOnRelease
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool followTouchPosition
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool animateOnMoveToTouch
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float moveToTouchSpeed
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool animateOnReturn
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float returnSpeed
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool manageRaycasting
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int pointerId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool hasPointer
		{
			get
			{
				return default(bool);
			}
		}

		internal StandaloneAxis axis
		{
			get
			{
				return null;
			}
		}

		private Action<nmJOdZmANObDJaNczzHbyFiChru> moveStartedDelegate
		{
			get
			{
				return null;
			}
		}

		private Action<nmJOdZmANObDJaNczzHbyFiChru> moveEndedDelegate
		{
			get
			{
				return null;
			}
		}

		private float axisValue
		{
			get
			{
				return default(float);
			}
		}

		private float axisValuePrev
		{
			get
			{
				return default(float);
			}
		}

		private bool buttonValue
		{
			get
			{
				return default(bool);
			}
		}

		private bool buttonValuePrev
		{
			get
			{
				return default(bool);
			}
		}

		private int effectivePointerId
		{
			get
			{
				return default(int);
			}
		}

		public event UnityAction<float> AxisValueChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction<bool> ButtonValueChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction ButtonDownEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction ButtonUpEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		[CustomObfuscation]
		private TouchButton()
		{
		}

		public void SetRawValue(float value)
		{
		}

		public void SetDefaultPosition()
		{
		}

		private void dTXVOGLPClUVVAAKVYflcVbiQsm(Vector2 P_0)
		{
		}

		public void ReturnToDefaultPosition(bool instant)
		{
		}

		public void ReturnToDefaultPosition()
		{
		}

		[CustomObfuscation]
		internal override void Awake()
		{
		}

		[CustomObfuscation]
		internal override void OnEnable()
		{
		}

		[CustomObfuscation]
		internal override void OnDisable()
		{
		}

		[CustomObfuscation]
		internal override void OnValidate()
		{
		}

		[CustomObfuscation]
		internal override void Reset()
		{
		}

		internal override void OnUpdate()
		{
		}

		internal override bool OnInitialize()
		{
			return default(bool);
		}

		internal override void OnCustomControllerUpdate()
		{
		}

		internal override void OnSubscribeEvents()
		{
		}

		internal override void OnUnsubscribeEvents()
		{
		}

		internal override void OnSetProperty()
		{
		}

		internal override void OnClear()
		{
		}

		public override void ClearValue()
		{
		}

		internal override bool IsPressed()
		{
			return default(bool);
		}

		internal override bool IsThisOrTouchRegionGameObject(GameObject gameObject)
		{
			return default(bool);
		}

		private void ZjUXNsmnJYWgFlMpjfaunoDKiZE()
		{
		}

		private void vPspgCbeFlfQBjJzbhuEPiZuKGM()
		{
		}

		private void DPDaylhiQRFCvpaPMiWJpjsYBOaI()
		{
		}

		private void lctSXJgIugjfPOOJMCDygMNeadYf(float P_0, bool P_1)
		{
		}

		private void UpKMnFZLnjaykwjUUlIAGqWLQIc()
		{
		}

		private void WhBGgLQWYVaCbYVsfAeFInkuPvfE()
		{
		}

		private void LZtLIradkTZxeuvnkQoCvQBxNXr()
		{
		}

		private void NKNlCydnlBXQIccJquXuGYsvTVq()
		{
		}

		private bool jhXSzEmmmcbBXISYrRykAelTKSy()
		{
			return default(bool);
		}

		private void WJRFWQuAuTbmrIPDuIrBAMWNGJy(TouchRegion P_0)
		{
		}

		private void YqUIagmZmDqhZOmwzYYjTAKNMXM(TouchRegion P_0)
		{
		}

		private void dolfYmltAUQEwCZveRlESRdKGhK()
		{
		}

		private void EJfFBWkyvJGCMjDZNhsCIYvpicRr(Vector2 P_0, bool P_1, float P_2, nmJOdZmANObDJaNczzHbyFiChru P_3)
		{
		}

		private void ETDmhjkAFEjajzDWGdMEpMSELEy(Vector2 P_0, PositionType P_1, bool P_2, float P_3, nmJOdZmANObDJaNczzHbyFiChru P_4)
		{
		}

		private IEnumerator MOcSsANHfuirGhceqnWqTPXDixq(Vector2 P_0, PositionType P_1, float P_2, nmJOdZmANObDJaNczzHbyFiChru P_3)
		{
			return null;
		}

		private void ipDAEIEeQzEPxaXwvPCRTSQaTzs(nmJOdZmANObDJaNczzHbyFiChru P_0, Vector2 P_1, PositionType P_2)
		{
		}

		private void eVfAjyGWfOpyeqSVAiMULCjiULEV(nmJOdZmANObDJaNczzHbyFiChru P_0)
		{
		}

		private void zSKRLImfJTUTUZRnAFIzkXGPEHJ(nmJOdZmANObDJaNczzHbyFiChru P_0)
		{
		}

		private void hYTALhDtqSGyQwuWJydLApykXsV(int P_0)
		{
		}

		private void CThRbRrJcLCZffvskgRNVWKvuHvv()
		{
		}

		private void MsGuhXEMmfanqTAvXbqFjDUICT()
		{
		}

		private bool oXEQziPQfUdlQaIpThRiZSJBOXU()
		{
			return default(bool);
		}

		private void OZFNDbURhVZKFtFmWGnJgPfugYpe()
		{
		}

		private bool dhOQlLJinYpERxCGGhjOgbBZapAV(int P_0)
		{
			return default(bool);
		}

		private PointerEventData LlGMCNteBCahnPiqWbTrHoAGivp(int P_0, GameObject P_1)
		{
			return null;
		}

		private PointerEventData AMQXfcKdkhATGEHBZPeTJWJpfSUA(int P_0)
		{
			return null;
		}

		private void cuuvieNpgXrCVXOlgxCyYFCjPIj(PointerEventData P_0)
		{
		}

		private PointerEventData gEzDDiQGlFHTAMAVPqWluKHtuyP(int P_0)
		{
			return null;
		}

		private void RxEZUnGIHFENEtIpjktQHvdabdW(PointerEventData P_0, dxNLfNtXMVHVLbHogBSUeLBVzVc P_1)
		{
		}

		private void uyQABlNHvFbAnbhXXlzvvLWQhYr(PointerEventData P_0, dxNLfNtXMVHVLbHogBSUeLBVzVc P_1)
		{
		}

		private void cMtnsaxGhUfiDcRwjkYxflgBASiH(PointerEventData P_0, dxNLfNtXMVHVLbHogBSUeLBVzVc P_1)
		{
		}

		private void EzJjjNAhQSmydhBVfCMGbRhVYoAK(PointerEventData P_0, dxNLfNtXMVHVLbHogBSUeLBVzVc P_1)
		{
		}

		private void eCctVKDNgyQGyeaOcqjOyVlLJqO(int P_0, Vector2 P_1, dxNLfNtXMVHVLbHogBSUeLBVzVc P_2)
		{
		}

		private void vFVybIPqofnIcLfQTuNwraHYvlu()
		{
		}

		internal override void OnPointerDown(PointerEventData eventData)
		{
		}

		internal override void OnPointerUp(PointerEventData eventData)
		{
		}

		internal override void OnPointerEnter(PointerEventData eventData)
		{
		}

		internal override void OnPointerExit(PointerEventData eventData)
		{
		}

		private void UNbcuuayGpcyfmiBZBuudIKuPfc(PointerEventData P_0)
		{
		}

		private void dqhSGzzGTuUAkDceFrBwijGXgMqA(PointerEventData P_0)
		{
		}

		private void tXfPLNiZkWIqEpphZBMXLxItsJO(PointerEventData P_0)
		{
		}

		private void wRoAvqliQBrNDpVMGkCGlhCaNXc(PointerEventData P_0)
		{
		}

		private void NwZAfFRzJtqbomIKNDDNEtFbGxU(float P_0)
		{
		}

		private void DgbjMpJNXwVefEGkIZGgDiwZdZOd(bool P_0)
		{
		}

		private void IWFYBZFzWNTQXbIgUrIKvgoPPSA()
		{
		}

		private void rTmCbedKMmviQXkEYfJeKDiyJleM()
		{
		}
	}
}
