using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames
{
	public class MoveTo : QuickGamesBase
	{
		public enum ETargetMoveType
		{
			STRAIGHT,
			PLAYER_BASED
		}

		[Tooltip("The player controlled object - Cursor")]
		public Transform thingToMove;

		[Tooltip("The 'edges' of the play area that the targets and thingToMove can move to")]
		public float moveDistnceMaxX;

		[Tooltip("The 'edges' of the play area that the targets and thingToMove can move to")]
		public float moveDistnceMaxY;

		[Tooltip("What to replace a targets image with when it's hit")]
		public Texture targetHitIMG_WIN;

		public Texture targetHitIMG_LOSE;

		[Tooltip("How close does the cursor have to be to the target to consider it a hit.")]
		public float targetHitDistance;

		[Tooltip("Does hitting a target win, or lose. Also controls if moving targets move towards or away from the player when targetMoveType is set to PLAYER_BASED")]
		public bool hitTargetsToWin;

		[Header("Target Locators")]
		public List<Transform> targetLocators;

		public List<Transform> nonTargetLocators;

		[Header("Click To Hit Info")]
		[Tooltip("If set to true, the thingToMove must be within targetHitDistance of a target and clicked on. If false, simply moving the thingToMove within targetHitDistance of a target will be a hit.")]
		public bool clickTargetToHit;

		[Tooltip("The image that thingToMove will swap to when it's whithin targetHitDistance of a target, and can be clicked to trigger a hit. Only used when clickTargetToHit is true")]
		public Texture targetOverIMG;

		[Header("Randomoze Targets Locations Info")]
		public bool randomizeLocatorsPositions;

		[Tooltip("Min and max distance the targets will spawn from the thingToMove starting point - Requires randomizeLocatorsPositions to be true to have any effect.")]
		public float minRndTargetDist;

		public float maxRndTargetDist;

		[Header("Targets Move Info")]
		public bool targetsMove;

		public float targetMoveSpeedMin;

		public float targetMoveSpeedMax;

		public ETargetMoveType targetMoveType;

		private bool _targetOverX;

		private bool _targetOverY;

		private float _avoidDistance;

		private float _dTime;

		private float _targetSizeX;

		private float _targetSizeY;

		private float _cursorSizeX;

		private float _cursorSizeY;

		private float _playAreaBorderMaxX;

		private float _playAreaBorderMaxY;

		private float _playAreaBorderMinX;

		private float _playAreaBorderMinY;

		private int _oldTargetIndex;

		private int _overTargetIndex;

		private int _targetIndex;

		private int _targetsToHit;

		private Vector3 _tmpV3;

		private Vector3 _lastMousePosition;

		private Vector3 _currentMousePosition;

		private Vector3 _originaCursorPosition;

		private Vector3 _thingToMovePosition;

		private List<Vector3> _targetmoveDirs;

		private List<Vector3> _nonTargetmoveDirs;

		private List<float> _targetMoveSpeed;

		private List<float> _nonTargetMoveSpeed;

		private List<bool> _targetCornered;

		private List<Transform> _placedTargets;

		private Texture _targetNotOverIMG;

		private RawImage _thingToMoveRawImage;

		public override void MStart()
		{
		}

		private void PlaceTargets()
		{
		}

		private Vector3 GetRndPosition()
		{
			return default(Vector3);
		}

		private void SetupMovingTargets()
		{
		}

		public override void QuickGameUpdate()
		{
		}

		private void MoveThingToMove()
		{
		}

		private void OverTargetCheck()
		{
		}

		private void MoveTargets()
		{
		}

		private void TargetHit()
		{
		}
	}
}
