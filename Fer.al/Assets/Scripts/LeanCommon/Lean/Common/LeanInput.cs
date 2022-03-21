using UnityEngine;

namespace Lean.Common
{
	public static class LeanInput
	{
		public static int GetTouchCount()
		{
			return default(int);
		}

		public static void GetTouch(int index, out int id, out Vector2 position, out float pressure, out bool set)
		{
		}

		public static Vector2 GetMousePosition()
		{
			return default(Vector2);
		}

		public static bool GetDown(KeyCode oldKey)
		{
			return default(bool);
		}

		public static bool GetPressed(KeyCode oldKey)
		{
			return default(bool);
		}

		public static bool GetUp(KeyCode oldKey)
		{
			return default(bool);
		}

		public static bool GetMouseDown(int index)
		{
			return default(bool);
		}

		public static bool GetMousePressed(int index)
		{
			return default(bool);
		}

		public static bool GetMouseUp(int index)
		{
			return default(bool);
		}

		public static float GetMouseWheelDelta()
		{
			return default(float);
		}

		public static bool GetMouseExists()
		{
			return default(bool);
		}

		public static bool GetKeyboardExists()
		{
			return default(bool);
		}
	}
}
