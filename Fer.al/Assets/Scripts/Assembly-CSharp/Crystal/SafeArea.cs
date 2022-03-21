using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Crystal
{
	public class SafeArea : MonoBehaviour
	{
		public enum SimDevice
		{
			None,
			iPhoneX,
			iPhoneXsMax,
			Pixel3XL_LSL,
			Pixel3XL_LSR
		}

		public static SimDevice Sim;

		private Rect[] NSA_iPhoneX;

		private Rect[] NSA_iPhoneXsMax;

		private Rect[] NSA_Pixel3XL_LSL;

		private Rect[] NSA_Pixel3XL_LSR;

		private RectTransform Panel;

		private Rect LastSafeArea;

		private Vector2Int LastScreenSize;

		private ScreenOrientation LastOrientation;

		[SerializeField]
		private bool ConformX;

		[SerializeField]
		private bool ConformY;

		[SerializeField]
		private bool Logging;

		private bool _useSafeAreaMargin;

		private float _safeAreaMarginWidth;

		private float _safeAreaMarginHeight;

		private bool _hasBeenInitialized;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void GetDefValues()
		{
		}

		[IteratorStateMachine(typeof(<WaitForCoreAndInit>d__20))]
		private IEnumerator WaitForCoreAndInit()
		{
			return null;
		}

		private void Refresh()
		{
		}

		private Rect GetSafeArea()
		{
			return default(Rect);
		}

		private void ApplyScaledSafeAreaMargin(ref Rect r)
		{
		}

		private void ApplySafeArea(Rect r)
		{
		}
	}
}
