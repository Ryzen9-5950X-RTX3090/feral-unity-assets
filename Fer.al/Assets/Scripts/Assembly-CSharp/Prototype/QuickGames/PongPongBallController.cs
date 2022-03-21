using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype.QuickGames
{
	public class PongPongBallController : MonoBehaviour
	{
		public float speed;

		private RectTransform rectTransform;

		private Vector2 startPos;

		private PongPongController parentController;

		private bool isAboutToMove;

		private float startDelay;

		private float elapsedDelayTime;

		public Rigidbody2D Body
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void SetUp(Vector2 startPos, PongPongController parent)
		{
		}

		public void Reset()
		{
		}

		public void Serve(float delay)
		{
		}

		public void QuickGameUpdate()
		{
		}

		private void StartMoving()
		{
		}

		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
		}
	}
}
