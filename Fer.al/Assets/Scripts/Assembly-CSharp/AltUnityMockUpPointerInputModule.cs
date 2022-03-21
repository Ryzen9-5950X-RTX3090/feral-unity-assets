using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class AltUnityMockUpPointerInputModule : StandaloneInputModule
{
	public PointerEventData ExecuteTouchEvent(Touch touch, [Optional] PointerEventData previousData)
	{
		return null;
	}
}
