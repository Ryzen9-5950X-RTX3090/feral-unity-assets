using System;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : SingletonManagerBase<CursorManager>
{
	public enum MouseCursorType
	{
		Normal = 0,
		DraggableSize_Vertical = 10,
		DraggableSize_Horizontal = 11,
		DraggableSize_Diagonal = 12,
		DraggablePosition = 15,
		InputField = 20,
		SanctuaryCameraMove = 25,
		SanctuaryCameraRotate = 26,
		SanctuaryObjectMove = 27,
		SanctuaryObjectRotate = 28
	}

	[Serializable]
	private class MouseCursorTexture
	{
		public Texture2D texture;

		public Vector2 hotspot;
	}

	[SerializeField]
	[EnumList(typeof(MouseCursorType), 0.35f)]
	private List<MouseCursorTexture> _mouseCursorTextures;

	private Dictionary<GameObject, MouseCursorType> _cursorIconLookup;

	private List<GameObject> _hoveredObjectCandidates;

	public Texture2D DefaultMouseCursorTexture
	{
		get
		{
			return null;
		}
	}

	public void RegisterCursorIcon(GameObject inMouseOverTarget, MouseCursorType inCursorType)
	{
	}

	public void UnregisterCursorIcon(GameObject inMouseOverTarget)
	{
	}

	public void AddHoveredObject(GameObject inHoveredObject)
	{
	}

	public void RemoveHoveredObject(GameObject inHoveredObject)
	{
	}

	private void RefreshCursor()
	{
	}
}
