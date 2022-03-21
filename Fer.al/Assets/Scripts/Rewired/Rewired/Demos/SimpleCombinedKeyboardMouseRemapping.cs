using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos
{
	[AddComponentMenu("")]
	public class SimpleCombinedKeyboardMouseRemapping : MonoBehaviour
	{
		private class Row
		{
			public InputAction action;

			public AxisRange actionRange;

			public Button button;

			public Text text;
		}

		private struct TargetMapping
		{
			public ControllerMap controllerMap;

			public int actionElementMapId;
		}

		private const string category = "Default";

		private const string layout = "Default";

		private const string uiCategory = "UI";

		private InputMapper inputMapper_keyboard;

		private InputMapper inputMapper_mouse;

		public GameObject buttonPrefab;

		public GameObject textPrefab;

		public RectTransform fieldGroupTransform;

		public RectTransform actionGroupTransform;

		public Text controllerNameUIText;

		public Text statusUIText;

		private List<Row> rows;

		private TargetMapping _replaceTargetMapping;

		private Player player
		{
			get
			{
				return null;
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void RedrawUI()
		{
		}

		private void ClearUI()
		{
		}

		private void InitializeUI()
		{
		}

		private void CreateUIRow(InputAction action, AxisRange actionRange, string label)
		{
		}

		private void OnInputFieldClicked(int index, int actionElementMapToReplaceId)
		{
		}

		[IteratorStateMachine(typeof(<StartListeningDelayed>d__22))]
		private IEnumerator StartListeningDelayed(int index, ControllerMap keyboardMap, ControllerMap mouseMap, int actionElementMapToReplaceId)
		{
			return null;
		}

		private void OnInputMapped(InputMapper.InputMappedEventData data)
		{
		}

		private void OnStopped(InputMapper.StoppedEventData data)
		{
		}
	}
}
