using UnityEngine;
using UnityEngine.EventSystems;

namespace Prototype.QuickGames
{
	public class PongPongPaddleController : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		private PongPongController parentController;

		private PongPongBallController ballController;

		private RectTransform rectTransform;

		private Rigidbody2D body;

		private float speed;

		private bool isEnemy;

		private Vector2 startPos;

		private Vector2 targetPos;

		private Vector2 prevPos;

		private bool isMoving;

		private Vector2 velocity;

		private int mcu;

		private int mc;

		private bool enemyOnRight;

		private bool pointerDown;

		public void SetUp(Vector2 startPos, float speed, bool isEnemy, PongPongController parentController, PongPongBallController ballController)
		{
		}

		public void OnPointerDown(PointerEventData pointerEventData)
		{
		}

		public void OnPointerUp(PointerEventData pointerEventData)
		{
		}

		public void QuickGameUpdate()
		{
		}

		private void FixedUpdate()
		{
		}

		private void HandleMovement()
		{
		}

		public Vector2 GetStrikeForce()
		{
			return default(Vector2);
		}

		public void Reset()
		{
		}
	}
}
