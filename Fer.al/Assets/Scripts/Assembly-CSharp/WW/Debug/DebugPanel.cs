using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace WW.Debug
{
	public abstract class DebugPanel : MonoBehaviour
	{
		[SerializeField]
		[Header("Properties")]
		protected DebugConsoleWindow _console;

		[SerializeField]
		protected InputField _inputField;

		[SerializeField]
		protected GameObject snapToBottomButton;

		[SerializeField]
		protected ScrollRect logItemsScrollRect;

		protected bool snapToBottom;

		protected PointerEventData nullPointerEventData;

		protected bool _isVisible
		{
			get
			{
				return default(bool);
			}
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void OnConsoleShown()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		public void SetSnapToBottom(bool snapToBottom)
		{
		}

		public void ValidateScrollPosition()
		{
		}

		public virtual void BtnClicked_Clear()
		{
		}
	}
}
