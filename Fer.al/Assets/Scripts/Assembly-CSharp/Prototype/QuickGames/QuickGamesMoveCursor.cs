using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype.QuickGames
{
	public class QuickGamesMoveCursor : ManagedBehaviour
	{
		[Tooltip("The player controlled object - Cursor")]
		public Transform cursorObject;

		[Tooltip("The 'edges' of the play area that the cursor can move to")]
		public float cursorMoveDistnceMaxX;

		[Tooltip("The 'edges' of the play area that the cursor can move to")]
		public float cursorMoveDistnceMaxY;

		private QuickGamesBase _game;

		private Vector2 _lastMousePosition;

		private Vector2 _currentMousePosition;

		private Vector2 _originaCursorPosition;

		private float _playAreaBorderMaxX;

		private float _playAreaBorderMaxY;

		private float _playAreaBorderMinX;

		private float _playAreaBorderMinY;

		private Vector3 _localZreset;

		public Vector2 CursorPosition
		{
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector2 moveDir
		{
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public override void MStart()
		{
		}

		public void ShowCursor(bool inShow)
		{
		}

		public void MoveCursor()
		{
		}
	}
}
