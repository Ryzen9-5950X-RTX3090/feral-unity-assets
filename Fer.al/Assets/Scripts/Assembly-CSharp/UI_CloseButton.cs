using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(WWButton))]
public class UI_CloseButton : MonoBehaviour
{
	public enum CloseButtonType
	{
		ParentWindow,
		SpecificWindows,
		AllWindows
	}

	[SerializeField]
	private CloseButtonType _closeButtonType;

	[SerializeField]
	private WWButton _button;

	[SerializeField]
	private UI_Window _window;

	[SerializeField]
	private List<string> _windowIDs;

	[SerializeField]
	private bool _includeWindowLayer;

	[SerializeField]
	private bool _includeOverlayLayer;

	[SerializeField]
	private bool _includePopupLayer;

	private void Start()
	{
	}

	private void Reset()
	{
	}

	private void OnCloseButtonTypeModified()
	{
	}
}
