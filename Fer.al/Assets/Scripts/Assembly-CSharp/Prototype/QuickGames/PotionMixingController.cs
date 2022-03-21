using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype.QuickGames
{
	public class PotionMixingController : QuickGamesBase
	{
		private class Track
		{
			public string layerName;

			public Color color;

			public List<int> tubeIndices;

			public PotionMixingBottleController topBottleController;

			public PotionMixingBottleController bottomBottleController;

			public Track(string layerName, Color color, List<int> tubeIndices, GameObject topBottle, GameObject bottomBottle)
			{
			}

			public void FinishSetUp(PotionMixingController potionMixingController)
			{
			}

			public void Run()
			{
			}
		}

		public GameObject tubePrefab_1L;

		public GameObject tubePrefab_1R;

		public GameObject tubePrefab_2L;

		public GameObject tubePrefab_2R;

		public GameObject tubePrefab_3L;

		public GameObject tubePrefab_3R;

		public GameObject testBallPrefab;

		public List<Color> bottleColors;

		public List<GameObject> topBottles;

		public List<GameObject> bottomBottles;

		public GameObject tileA;

		public GameObject tileB;

		public GameObject tileC;

		private List<Track> tracks;

		public override void MStart()
		{
		}

		private void Initialize()
		{
		}

		private void SetUpTracks()
		{
		}

		private GameObject GetPrefab(int sI, int eI)
		{
			return null;
		}

		private GameObject GetTubeParent(GameObject tile, int idx)
		{
			return null;
		}

		public override void QuickGameUpdate()
		{
		}

		[IteratorStateMachine(typeof(<ShowResults>d__20))]
		public override IEnumerator ShowResults()
		{
			return null;
		}
	}
}
