using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
	[DisallowMultipleComponent]
	public sealed class TouchJoystick : TouchInteractable
	{
		public enum AxisDirection
		{
			Both,
			Horizontal,
			Vertical
		}

		public enum JoystickMode
		{
			Analog,
			Digital
		}

		public enum SnapDirections
		{
			None = 0,
			Four = 4,
			Eight = 8,
			Sixteen = 0x10,
			ThirtyTwo = 0x20,
			SixtyFour = 0x40
		}

		private enum gcXbbdhodwurOwnETJBwcylSiar
		{
			PoBZZNoYGVGuWkUBxQqhGBhFqWy,
			mECSSpoPNQyVKtfFebLkjUXhvjOu,
			PRJNKxHAbZjpzWKQNbgkjaPwroE
		}

		private enum dQfHNopHjGTKEUqCqpYYwYyguiA
		{
			IjuFlluoMybUtpSqFtBQAlMgUyR,
			gNafaKVthTKHmnfzOTdmjsbShkI
		}

		public enum StickBounds
		{
			Circle,
			Square
		}

		[Serializable]
		public class ValueChangedEventHandler : UnityEvent<Vector2>
		{
		}

		[Serializable]
		public class StickPositionChangedEventHandler : UnityEvent<Vector2>
		{
		}

		[Serializable]
		public class TapEventHandler : UnityEvent
		{
		}

		[Serializable]
		public class TouchStartedEventHandler : UnityEvent
		{
		}

		[Serializable]
		public class TouchEndedEventHandler : UnityEvent
		{
		}

		public interface IValueChangedHandler
		{
			void OnValueChanged(Vector2 value);
		}

		public interface IStickPositionChangedHandler
		{
			void OnStickPositionChanged(Vector2 value);
		}

		private const float MAX_MOVE_SPEED = 20f;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The Custom Controller element(s) that will receive input values from the joystick's X axis.")]
		private CustomControllerElementTargetSetForFloat _horizontalAxisCustomControllerElement;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("The Custom Controller element(s) that will receive input values from the joystick's Y axis.")]
		private CustomControllerElementTargetSetForFloat _verticalAxisCustomControllerElement;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The Custom Controller element that will receive input values from taps.")]
		private CustomControllerElementTargetSetForBoolean _tapCustomControllerElement;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The Rect Transform of the stick disc. This is moved around by the user when manipulating the joystick.")]
		private RectTransform _stickTransform;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("The joystick's mode of operation. Set this to Digital to simulate a D-Pad which has only On/Off states. If you want mimic a real D-Pad, you should also set Snap Directions to 8.")]
		private JoystickMode _joystickMode;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("A dead zone which is applied when Stick Mode is set to Digital. This is used to filter out tiny stick movements near 0, 0.")]
		[Range(0f, 1f)]
		private float _digitalModeDeadZone;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The range of movement of the stick in Canvas pixels. The larger the number, the further the stick must be moved from center to register movement.")]
		[Range(0.01f, 1000f)]
		private float _stickRange;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("If enabled, the stick range will scale with parent controls. Otherwise, the stick range will remain constant.")]
		private bool _scaleStickRange;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The shape of the range of movement of the joystick.")]
		private StickBounds _stickBounds;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The axis directions in which movement is allowed. You can restrict movement to one or both axes.")]
		private AxisDirection _axesToUse;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Snaps joystick movement to a fixed number of directions. This can be used to create a D-Pad, for example, setting it to 4 or 8 directions. If you want a true D-Pad, Stick Mode should be set to digital.")]
		private SnapDirections _snapDirections;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("If true, the stick disc will snap immediately to the touch position when initially touched. This results in the stick disc being centered to the touch position. This will cause the stick to generate input immediately when touched if not touched perfectly centered.If false, the stick disc will remain in its current position on touch, and when dragged will retain the same offset. The stick's center point will be set to the position of the touch. The initial touch will not cause the stick to pop in any direction.")]
		private bool _snapStickToTouch;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("If true, the stick will return to the center after it is released. Otherwise, the stick will remain in the last position and continue to return input.")]
		private bool _centerStickOnRelease;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The underlying Axis 2D.")]
		private StandaloneAxis2D _axis2D;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("If true, the joystick can be activated by a touch swipe that began in an area outside the joystick region. If false, the joystick can only be activated by a direct touch.")]
		private bool _activateOnSwipeIn;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("If true, the joystick will stay engaged even if the touch that activated it moves outside the joystick region. If false, the joystick will be released once the touch that activated it moves outside the joystick region.")]
		private bool _stayActiveOnSwipeOut;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Should taps on the touch pad be processed?")]
		private bool _allowTap;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("The maximum touch duration allowed for the touch to be considered a tap. A touch that lasts longer than this value will not trigger a tap when released.")]
		[FieldRange(0f, float.MaxValue)]
		private float _tapTimeout;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("The maximum movement distance allowed in pixels since the touch began for the touch to be considered a tap. [-1 = no limit]")]
		[FieldRange(-1, int.MaxValue)]
		private int _tapDistanceLimit;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Optional external region to use for hover/click/touch detection. If set, this region will be used for touch detection instead of or in addition to the joystick's RectTransform. This can be useful if you want a larger area of the screen to act as a joystick.")]
		private TouchRegion _touchRegion;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("If True, hovers/clicks/touches on the local joystick will be ignored and only Touch Region touches will be used. Otherwise, both touches on the joystick and on the Touch Region will be used. This also applies to mouse hover. This setting has no effect if no Touch Region is set.")]
		private bool _useTouchRegionOnly;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("If True, the joystick will move to the location of the current touch in the Touch Region. This can be used to designate an area of the screen as a hot-spot for a joystick and have the joystick graphics follow the users touches. This only has an effect if a Touch Region is set.")]
		private bool _moveToTouchPosition;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("If Move To Touch Position is enabled, this will make the joystick return to its original position after the press is released. This only has an effect if a Touch Region is set.")]
		private bool _returnOnRelease;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("If True, the joystick will follow the touch around until released. This setting overrides Move To Touch Position.")]
		private bool _followTouchPosition;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Should the joystick animate when moving to the touch point? This only has an effect if Move To Touch Position is True and a Touch Region is set. This setting is ignored if Follow Touch Position is True.")]
		private bool _animateOnMoveToTouch;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("The speed at which the joystick will move toward the touch position measured in screens per second (based on the larger of width and height). [1.0 = Move 1 screen/sec]. This only has an effect if Move To Touch Position is True, Animate On Move To Touch is true, and a Touch Region is set. This setting is ignored if Follow Touch Position is True.")]
		[Range(0f, 20f)]
		private float _moveToTouchSpeed;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Should the joystick animate when moving back to its original position? This only has an effect if Follow Touch Position is True, or if Move To Touch Position is True and a Touch Region is set, and Return on Release is True.")]
		private bool _animateOnReturn;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The speed at which the joystick will move back toward its original position measured in screens per second (based on the larger of width and height). [1.0 = Move 1 screen/sec]. This only has an effect if Follow Touch Position is True, or if Move To Touch Position is True and a Touch Region is set, and Return on Release and Animate on Return are both True.")]
		[Range(0f, 20f)]
		private float _returnSpeed;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("If True, it will attempt to automatically manage Graphic component raycasting for best results based on your current settings.")]
		private bool _manageRaycasting;

		private bool _useXAxis;

		private bool _useYAxis;

		private QGjnOCnHKfrjIqlAonYthHKMREQ.HierarchyEventHelper<IValueChangedHandler, Vector2> _hierarchyValueChangedHandlers;

		private QGjnOCnHKfrjIqlAonYthHKMREQ.HierarchyEventHelper<IStickPositionChangedHandler, Vector2> _hierarchyStickPositionChangedHandlers;

		private TouchRegion _workingTouchRegion;

		private Vector2 _origAnchoredPosition;

		private Vector2 _origStickAnchoredPosition;

		private Vector2 _lastPressAnchoredPosition;

		private bool _isMoving;

		private bool _isMovedFromDefaultPosition;

		private gcXbbdhodwurOwnETJBwcylSiar _moveDirection;

		private int _pointerId;

		private int _realMousePointerId;

		[NonSerialized]
		private bool byeanBfvjEeOOwRBSBerFwsuBMBA;

		[NonSerialized]
		private bool IXgubBiHZOnBAjLkDRcJjAfbtyr;

		private bool _pointerDownIsFake;

		private Vector2 _lastPressStartingValue;

		private dQfHNopHjGTKEUqCqpYYwYyguiA _lastClaimSource;

		private float _touchStartTime;

		private Vector2 _touchStartPosition;

		private IEnumerator _coroutineMove;

		private FulEHeUoVkyNDHjDfouzidfyihgB _imageRaycastHelper;

		private int _calculatedStickRange_lastUpdatedFrame;

		private int _lastTapFrame;

		private bool _isEligibleForTap;

		private float __calculatedStickRange_cachedValue;

		private Action<gcXbbdhodwurOwnETJBwcylSiar> __moveStartedDelegate;

		private Action<gcXbbdhodwurOwnETJBwcylSiar> __moveEndedDelegate;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Event sent when the joystick value changes.")]
		private ValueChangedEventHandler _onValueChanged;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Event sent when the joystick's stick position changes.")]
		private ValueChangedEventHandler _onStickPositionChanged;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Event sent when the joystick is touched.")]
		private TouchStartedEventHandler _onTouchStarted;

		[CustomObfuscation]
		[SerializeField]
		private TouchEndedEventHandler _onTouchEnded;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Event sent when the touch pad is tapped. This event will only be sent if allowTap is True.")]
		private TapEventHandler _onTap;

		private Dictionary<int, PointerEventData> __fakePointerEventData;

		private static QGjnOCnHKfrjIqlAonYthHKMREQ.EventFunction<IValueChangedHandler, Vector2> __valueChangedHandlerDelegate;

		private static QGjnOCnHKfrjIqlAonYthHKMREQ.EventFunction<IStickPositionChangedHandler, Vector2> __stickPositionChangedHandlerDelegate;

		public CustomControllerElementTargetSetForFloat horizontalAxisCustomControllerElement
		{
			get
			{
				return null;
			}
		}

		public CustomControllerElementTargetSetForFloat verticalAxisCustomControllerElement
		{
			get
			{
				return null;
			}
		}

		public CustomControllerElementTargetSetForBoolean tapCustomControllerElement
		{
			get
			{
				return null;
			}
		}

		public RectTransform stickTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public JoystickMode joystickMode
		{
			get
			{
				return default(JoystickMode);
			}
			set
			{
			}
		}

		public float digitalModeDeadZone
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float stickRange
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool scaleStickRange
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		private StickBounds stickBounds
		{
			get
			{
				return default(StickBounds);
			}
			set
			{
			}
		}

		public AxisDirection axesToUse
		{
			get
			{
				return default(AxisDirection);
			}
			set
			{
			}
		}

		public SnapDirections snapDirections
		{
			get
			{
				return default(SnapDirections);
			}
			set
			{
			}
		}

		public bool snapStickToTouch
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool centerStickOnRelease
		{
			get
			{
				return default(bool);
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

		public bool allowTap
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float tapTimeout
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public int tapDistanceLimit
		{
			get
			{
				return default(int);
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

		private bool tapValue
		{
			get
			{
				return default(bool);
			}
		}

		internal StandaloneAxis2D axis2D
		{
			get
			{
				return null;
			}
		}

		private Action<gcXbbdhodwurOwnETJBwcylSiar> moveStartedDelegate
		{
			get
			{
				return null;
			}
		}

		private Action<gcXbbdhodwurOwnETJBwcylSiar> moveEndedDelegate
		{
			get
			{
				return null;
			}
		}

		private int effectivePointerId
		{
			get
			{
				return default(int);
			}
		}

		private RectTransform touchReferenceTransform
		{
			get
			{
				return null;
			}
		}

		private float calculatedStickRange
		{
			get
			{
				return default(float);
			}
		}

		internal static QGjnOCnHKfrjIqlAonYthHKMREQ.EventFunction<IValueChangedHandler, Vector2> valueChangedHandlerDelegate
		{
			get
			{
				return null;
			}
		}

		internal static QGjnOCnHKfrjIqlAonYthHKMREQ.EventFunction<IStickPositionChangedHandler, Vector2> stickPositionChangedHandlerDelegate
		{
			get
			{
				return null;
			}
		}

		public event UnityAction<Vector2> ValueChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction<Vector2> StickPositionChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction TouchDownEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction TouchUpEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction TapEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		[CustomObfuscation]
		private TouchJoystick()
		{
		}

		public Vector2 GetValue()
		{
			return default(Vector2);
		}

		public Vector2 GetRawValue()
		{
			return default(Vector2);
		}

		public void SetRawValue(Vector2 value)
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

		internal override void FindEventHandlers()
		{
		}

		public override void ClearValue()
		{
		}

		internal override bool IsPressed()
		{
			return default(bool);
		}

		internal override bool IsThisOrTouchRegionGameObject(GameObject P_0)
		{
			return default(bool);
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

		private void EJfFBWkyvJGCMjDZNhsCIYvpicRr(Vector2 P_0, bool P_1, float P_2, gcXbbdhodwurOwnETJBwcylSiar P_3)
		{
		}

		private void ETDmhjkAFEjajzDWGdMEpMSELEy(Vector2 P_0, PositionType P_1, bool P_2, float P_3, gcXbbdhodwurOwnETJBwcylSiar P_4)
		{
		}

		private IEnumerator MOcSsANHfuirGhceqnWqTPXDixq(Vector2 P_0, PositionType P_1, float P_2, gcXbbdhodwurOwnETJBwcylSiar P_3)
		{
			return null;
		}

		private void ipDAEIEeQzEPxaXwvPCRTSQaTzs(gcXbbdhodwurOwnETJBwcylSiar P_0, Vector2 P_1, PositionType P_2)
		{
		}

		private void eVfAjyGWfOpyeqSVAiMULCjiULEV(gcXbbdhodwurOwnETJBwcylSiar P_0)
		{
		}

		private void zSKRLImfJTUTUZRnAFIzkXGPEHJ(gcXbbdhodwurOwnETJBwcylSiar P_0)
		{
		}

		private void CThRbRrJcLCZffvskgRNVWKvuHvv()
		{
		}

		private void hYTALhDtqSGyQwuWJydLApykXsV(int P_0, Vector2 P_1, PositionType P_2)
		{
		}

		private void MsGuhXEMmfanqTAvXbqFjDUICT()
		{
		}

		private void ZZYGIlXqqUsylsfQBQmTnvRyFpn()
		{
		}

		private void zxcfAcvnwhOviPQlyJevzmGbgxl(ref Vector2 P_0)
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

		private PointerEventData IeozbiZwrTQxWvulmeRKsKBLdtja(int P_0, GameObject P_1)
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

		private void tKykQvIfDZdusfkIyNODKYFDRBzn(PointerEventData P_0, dQfHNopHjGTKEUqCqpYYwYyguiA P_1)
		{
		}

		private PointerEventData gEzDDiQGlFHTAMAVPqWluKHtuyP(int P_0)
		{
			return null;
		}

		private void ngSCpflbmnAmEnJEbHrUjRCLHCB()
		{
		}

		private void dzynYViRaRMlteHKPpYVKSjcRik(AxisDirection P_0)
		{
		}

		private void RxEZUnGIHFENEtIpjktQHvdabdW(PointerEventData P_0, dQfHNopHjGTKEUqCqpYYwYyguiA P_1)
		{
		}

		private void uyQABlNHvFbAnbhXXlzvvLWQhYr(PointerEventData P_0, dQfHNopHjGTKEUqCqpYYwYyguiA P_1)
		{
		}

		private void cMtnsaxGhUfiDcRwjkYxflgBASiH(PointerEventData P_0, dQfHNopHjGTKEUqCqpYYwYyguiA P_1)
		{
		}

		private void EzJjjNAhQSmydhBVfCMGbRhVYoAK(PointerEventData P_0, dQfHNopHjGTKEUqCqpYYwYyguiA P_1)
		{
		}

		private void NaxMXWWrcEDWOMwpOBVjxDXfhyc(PointerEventData P_0, dQfHNopHjGTKEUqCqpYYwYyguiA P_1)
		{
		}

		private void czKUQrdBFVztjcAEscNnkHonxUYG(PointerEventData P_0, dQfHNopHjGTKEUqCqpYYwYyguiA P_1)
		{
		}

		private void gYIxSjvLpDuDJzEvUgsIBEBNzaca(PointerEventData P_0, dQfHNopHjGTKEUqCqpYYwYyguiA P_1)
		{
		}

		private void eCctVKDNgyQGyeaOcqjOyVlLJqO(int P_0, Vector2 P_1, dQfHNopHjGTKEUqCqpYYwYyguiA P_2)
		{
		}

		private void vFVybIPqofnIcLfQTuNwraHYvlu()
		{
		}

		internal override void OnPointerUp(PointerEventData eventData)
		{
		}

		internal override void OnPointerDown(PointerEventData eventData)
		{
		}

		internal override void OnPointerEnter(PointerEventData eventData)
		{
		}

		internal override void OnPointerExit(PointerEventData eventData)
		{
		}

		internal override void OnBeginDrag(PointerEventData eventData)
		{
		}

		internal override void OnDrag(PointerEventData eventData)
		{
		}

		internal override void OnEndDrag(PointerEventData eventData)
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

		private void veoAvtETrmSVgFBRnPEzNfqYUnP(PointerEventData P_0)
		{
		}

		private void VyQIRuOzDcNxlMozvtpmjYdwota(PointerEventData P_0)
		{
		}

		private void ShGddjbrphbUjSnkvkwcNqVZYzF(PointerEventData P_0)
		{
		}

		private void NwZAfFRzJtqbomIKNDDNEtFbGxU(Vector2 P_0)
		{
		}

		[CompilerGenerated]
		private static void xiDAyOOljHLvPHitOKirhftKRdS(IValueChangedHandler P_0, Vector2 P_1)
		{
		}

		[CompilerGenerated]
		private static void qtchySVbZFsyqXnAewCIpkJMuVz(IStickPositionChangedHandler P_0, Vector2 P_1)
		{
		}
	}
}
