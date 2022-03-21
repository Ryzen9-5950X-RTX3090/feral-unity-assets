using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype.QuickGames
{
	public class WhackAMoleHoleController : MonoBehaviour
	{
		private WhackAMole parentController;

		private GameObject contents;

		private RectTransform contentRectTransform;

		private Vector2 contentDownPosition;

		private Vector2 contentUpPosition;

		private bool _isMoving;

		private Vector2 targetPosition;

		private Vector2 startPosition;

		private float _moveTime;

		private float _currentTime;

		private float _normalizedTime;

		public bool IsDown
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsRare
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void SetUp(WhackAMole parent)
		{
		}

		public void ContentsClicked()
		{
		}

		public void ShowContents()
		{
		}

		public void HideContents()
		{
		}

		public void MakeRare()
		{
		}

		public void MakeNormal()
		{
		}

		[IteratorStateMachine(typeof(<MoveContents>d__25))]
		private IEnumerator MoveContents()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<AnimateMovement>d__26))]
		private IEnumerator AnimateMovement()
		{
			return null;
		}
	}
}
