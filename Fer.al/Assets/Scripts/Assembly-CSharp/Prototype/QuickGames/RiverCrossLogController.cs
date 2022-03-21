using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype.QuickGames
{
	public class RiverCrossLogController : MonoBehaviour
	{
		public float speed;

		public int direction;

		public int type;

		private GameObject log;

		private Rigidbody2D logBody;

		private RectTransform logRectTransform;

		private float minX;

		private float maxX;

		private bool moving;

		private Vector2 positionA;

		private Vector2 positionB;

		private Vector2 nextPosition;

		private bool resetPosition;

		public void SetUp(float speed, int direction, int type, Vector2 position)
		{
		}

		public void Move(bool value)
		{
		}

		[IteratorStateMachine(typeof(<AnimateMovement>d__15))]
		private IEnumerator AnimateMovement()
		{
			return null;
		}

		public void UpdatePosition()
		{
		}
	}
}
