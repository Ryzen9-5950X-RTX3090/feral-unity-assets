using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype.QuickGames.ScareTheCrows
{
	public class ScareTheCrows : QuickGamesBase
	{
		[Header("Intro")]
		public float timeForIntro;

		[Header("Scare The Crows")]
		public int totalCrows;

		[Header("Mover")]
		public float swatRange;

		[Header("Crows")]
		public Transform crow;

		public Texture crowImage_Down;

		public Texture crowImage_Fly;

		public int minStartCrows;

		public int maxStartCrows;

		public float minCrowSpawnTime;

		public float maxCrowSpawnTime;

		public int minPecks;

		public int maxPecks;

		public float peckTimeDown;

		public float peckTimeUp;

		public float crowSpeed;

		public float flapTime;

		public Vector2 crowCropOffset;

		public Transform[] spawnLocations;

		public GameObject particleSystemPrefab;

		public ParticleSystem particles;

		[Header("Crop")]
		public Transform crop;

		public float cropShrinkTime;

		public Transform[] cropLocations;

		internal Texture crowImage_Up;

		internal List<Transform> allCrops;

		internal List<Transform> pickableCrops;

		internal List<Crow> allCrows;

		private float _crowSpawnTime;

		private int _totalCrows;

		private int _crowsSwatted;

		private RectTransform _hudRect;

		private Vector2 _mousePos;

		private Camera _cam;

		public override void UAwake()
		{
		}

		internal Transform GetNewCrop()
		{
			return null;
		}

		public override void MStart()
		{
		}

		[IteratorStateMachine(typeof(<ShowIntro>d__36))]
		public override IEnumerator ShowIntro()
		{
			return null;
		}

		private void UpdateCrows()
		{
		}

		public override void QuickGameUpdate()
		{
		}

		[IteratorStateMachine(typeof(<ShowResults>d__39))]
		public override IEnumerator ShowResults()
		{
			return null;
		}
	}
}
