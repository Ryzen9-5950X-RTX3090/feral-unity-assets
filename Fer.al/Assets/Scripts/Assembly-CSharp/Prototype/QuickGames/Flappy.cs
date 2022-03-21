using System.Collections.Generic;
using UnityEngine;

namespace Prototype.QuickGames
{
	public class Flappy : QuickGamesBase
	{
		public GameObject playerPrefab;

		public GameObject obstaclePrefab;

		public float movementSpeed;

		public float obstacleGap;

		public float flapForce;

		private GameObject player;

		private Rigidbody2D playerRB;

		private GameObject board;

		private GameObject obstacleHolder;

		private RectTransform obstacleHolderRectTransform;

		private GameObject pipeHolder;

		private List<GameObject> obstacles;

		private Vector2 groundMovement;

		public override void MStart()
		{
		}

		private void Initialize()
		{
		}

		public override void QuickGameUpdate()
		{
		}

		public void PlayerCollision()
		{
		}
	}
}
