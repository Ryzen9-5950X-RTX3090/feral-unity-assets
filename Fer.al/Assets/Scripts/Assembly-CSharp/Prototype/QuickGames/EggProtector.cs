using System.Collections.Generic;
using UnityEngine;

namespace Prototype.QuickGames
{
	public class EggProtector : QuickGamesBase
	{
		public GameObject playerPrefab;

		public GameObject eggPrefab;

		public GameObject enemyPrefab;

		private GameObject player;

		private Rigidbody2D playerBody;

		private List<GameObject> eggs;

		private List<GameObject> enemies;

		private GameObject board;

		private Rect boardRect;

		private Rect eggRect;

		private Rect playerRect;

		private Rect enemyRect;

		private int numEggs;

		private float enemySpawnWait;

		private float spawnWait;

		public override void MStart()
		{
		}

		public override void QuickGameUpdate()
		{
		}

		private void Initialize()
		{
		}

		private void SpawnEnemy()
		{
		}

		private void HandleInput()
		{
		}
	}
}
