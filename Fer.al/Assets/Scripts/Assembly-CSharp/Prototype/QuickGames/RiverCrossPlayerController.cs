using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames
{
	public class RiverCrossPlayerController : MonoBehaviour
	{
		public enum EPlayerState
		{
			ON_GROUND,
			MOVING,
			IN_WATER,
			ON_LOG
		}

		public Image standingImage;

		public Image movingImage;

		private RiverCrossController parentController;

		private Rigidbody2D playerBody;

		private RectTransform playerRectTransform;

		private Vector3 playerRotation;

		private float movementAmount;

		private bool _isMoving;

		private float _moveTime;

		private float _currentTime;

		private float _normalizedTime;

		private Vector2 _originalPos;

		private Vector2 _targetPos;

		private Vector2 _movementDir;

		public EPlayerState state
		{
			[CompilerGenerated]
			get
			{
				return default(EPlayerState);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void SetUp(RiverCrossController parent, float logGap)
		{
		}

		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		private void OnCollisionExit2D(Collision2D collision)
		{
		}

		public void FallInWater()
		{
		}

		public void LandOnLog()
		{
		}

		public void LandOnGround(bool finished)
		{
		}

		public void UpdatePosition(int direction, float speed)
		{
		}

		public void TryMovePlayer(int xDirOverride = 0, int yDirOverride = 0)
		{
		}

		[IteratorStateMachine(typeof(<Move>d__27))]
		private IEnumerator Move()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<AnimateMovement>d__28))]
		private IEnumerator AnimateMovement()
		{
			return null;
		}
	}
}
