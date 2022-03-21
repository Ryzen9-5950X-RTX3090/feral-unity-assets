using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames
{
	public class DouseCinder : QuickGamesBase
	{
		private class Cinder : MonoBehaviour
		{
			public RawImage image;

			private Vector3 _fxSmallScale;

			private bool _showingSmoke;

			private Color _deadColor;

			public DouseCinder Game
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

			public float Hps
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float StartHps
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public ParticleSystem CinderFireFX
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

			public ParticleSystem CinderSmokeFX
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

			public Vector3 StartScaleFireFX
			{
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public Vector3 StartScaleSmokeFX
			{
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public Transform TransformFireFX
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

			public Transform TransformSmokeFX
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

			private void Awake()
			{
			}

			private void OnCollisionEnter2D(Collision2D collision)
			{
			}
		}

		[Header("Douse Cinder")]
		public GameObject obj_cloud;

		public GameObject obj_rain;

		public GameObject obj_cinder;

		public ParticleSystem cinderFireFX;

		public ParticleSystem cinderSmokeFX;

		[Tooltip("The 'edges' of the play area that the targets can move to")]
		public float targetMoveDistnceMaxX;

		[Tooltip("The 'edges' of the play area that the cursor can move to")]
		public float cursorMoveDistnceMaxX;

		public float cinderHPS;

		public float cinderMoveSpeed;

		public float rainXoffset;

		public float rainDamage;

		public float minRainStartSpeed;

		public float maxRainStartSpeed;

		public float timeBetweenRain;

		[Header("Intro")]
		public float timeForIntro;

		private bool _draggingCloud;

		private float _playAreaBorderMaxX;

		private float _playAreaBorderMinX;

		private int cloudSiblingIndex;

		private Vector2 _originaCursorPosition;

		private Vector2 _cinderPosition;

		private Vector2 _cinderScale;

		private Vector2 _cinderMoveDir;

		private Vector3 _cursorPosition;

		private Vector3 _lastMousePosition;

		private Vector3 _currentMousePosition;

		private Vector3 _localZreset;

		private Transform _cinderTransform;

		private CircleCollider2D _cloudCollider;

		private RawImage _cloudImage;

		private Color _cloudStartColor;

		private List<GameObject> _rainDrops;

		private Cinder _cinder;

		public override void MStart()
		{
		}

		[IteratorStateMachine(typeof(<ShowIntro>d__35))]
		public override IEnumerator ShowIntro()
		{
			return null;
		}

		private void MoveCinder()
		{
		}

		public override void QuickGameUpdate()
		{
		}

		[IteratorStateMachine(typeof(<MakeRain>d__38))]
		private IEnumerator MakeRain()
		{
			return null;
		}

		private void OnDrawGizmos()
		{
		}

		private void MoveCloud()
		{
		}

		public void CinderOut()
		{
		}

		[IteratorStateMachine(typeof(<RemoveRain>d__42))]
		private IEnumerator RemoveRain()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<ShowResults>d__43))]
		public override IEnumerator ShowResults()
		{
			return null;
		}
	}
}
