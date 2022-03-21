using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype.QuickGames
{
	public class LeadMoth : QuickGamesBase
	{
		[Header("Lead Moth")]
		public Transform torch;

		public Transform spotLight;

		public Transform ember;

		public Transform moth;

		public Transform mothWingLeft;

		public Transform mothWingRight;

		public float mothNoticeEmberDistance;

		public float mothPickupEmberDistance;

		public float mothMinCursorDistance;

		public float mothMidCursorDistance;

		public float mothMaxCursorDistance;

		public float mothMoveSpeed;

		public float flapRate;

		public float flapRange;

		public float placementBuffer;

		public float screenLimitX;

		public float screenLimitY;

		public float emberScaleTime;

		public int numEmbers;

		public float spotlightSmooth;

		public float maxSpotliteRotate;

		public float maxSpotlightSpeed;

		[Header("Intro")]
		public float timeForIntro;

		private Quaternion _spotlightRotate;

		private List<Vector3> _placedPositions;

		private List<Transform> _placedEmbers;

		private Vector2 _mothPostion;

		private int _mothSiblingIndex;

		private Vector3 _emberScale;

		private bool _mothToEmber;

		private int _mothEmberIndex;

		private Vector3 _mothDir;

		private float _mothMoveScaler;

		private bool _isClicking;

		private QuickGamesMoveCursor _cursorMover;

		public override void MStart()
		{
		}

		[IteratorStateMachine(typeof(<FlapWings>d__36))]
		private IEnumerator FlapWings()
		{
			return null;
		}

		public override void QuickGameUpdate()
		{
		}

		[IteratorStateMachine(typeof(<ShowIntro>d__38))]
		public override IEnumerator ShowIntro()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<ScaleEmber>d__39))]
		private IEnumerator ScaleEmber(Transform inTrans, bool inUp)
		{
			return null;
		}

		private Vector3 GetPlacmentPos(int inTries)
		{
			return default(Vector3);
		}

		[IteratorStateMachine(typeof(<ResetSpotlight>d__41))]
		private IEnumerator ResetSpotlight()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<ShowResults>d__42))]
		public override IEnumerator ShowResults()
		{
			return null;
		}
	}
}
