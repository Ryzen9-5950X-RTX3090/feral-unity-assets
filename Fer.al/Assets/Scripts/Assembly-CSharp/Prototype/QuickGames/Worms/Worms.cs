using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames.Worms
{
	public class Worms : QuickGamesBase
	{
		private class WormMover : UnityEngine.MonoBehaviour
		{
			public float moveSpeed;

			public bool isTarget;

			public Worms wormsGame;

			public RawImage image;

			public Vector2 moveDir;

			private Transform _transform;

			private Vector2 _position;

			private Vector2 _scale;

			private float _targetMoveDistnceMaxX;

			private float _targetMoveDistnceMaxY;

			private bool _pulseIn;

			private Color _pulseOutColor;

			private float _currentPulseTime;

			private void Awake()
			{
			}

			public void Init()
			{
			}

			public void WormUpdate()
			{
			}
		}

		[Header("Worms")]
		public QuickGamesAudio wormsAudio;

		[Tooltip("The player controlled object - Cursor")]
		public Transform cursorObject;

		public Transform targetLocations;

		public Transform target;

		public Transform nonTarget;

		[Tooltip("The 'edges' of the play area that the targets can move to")]
		public float targetMoveDistnceMaxX;

		[Tooltip("The 'edges' of the play area that the targets can move to")]
		public float targetMoveDistnceMaxY;

		[Tooltip("The 'edges' of the play area that the cursor can move to")]
		public float cursorMoveDistnceMaxX;

		[Tooltip("The 'edges' of the play area that the cursor can move to")]
		public float cursorMoveDistnceMaxY;

		public float targetMoveSpeedMin;

		public float targetMoveSpeedMax;

		public float nonTargetMoveSpeedMin;

		public float nonTargetMoveSpeedMax;

		[Tooltip("The number of non targets to spawn. Current limit is 60 because there's 61 Spawnlocations in the prefab.")]
		public int nonTargetCount;

		public float cursorRange;

		public float resultsFadeTime;

		private HashSet<RawImage> allWormsImages;

		private HashSet<WormMover> allWorms;

		private Vector2[] cursorSphere;

		private RectTransform _hudRect;

		private Vector2 _mousePos;

		private Camera _cam;

		public override void MStart()
		{
		}

		private void PlaceTargets()
		{
		}

		private Vector2 RotateV2(Vector2 v, float degrees)
		{
			return default(Vector2);
		}

		private void OnDrawGizmos()
		{
		}

		public override void QuickGameUpdate()
		{
		}

		[IteratorStateMachine(typeof(<ShowResults>d__28))]
		public override IEnumerator ShowResults()
		{
			return null;
		}

		private void MoveCursor()
		{
		}
	}
}
