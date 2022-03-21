using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Prototype.QuickGames
{
	public class MatchThreeCellController : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		public enum EKeyState
		{
			LOCKED,
			LOCKED_NEXT_TARGET,
			OPENED,
			COLLECTING,
			COLLECTED
		}

		public List<Sprite> standardSprites;

		public List<Sprite> specialSprites;

		public List<Sprite> selectedStandardSprites;

		public List<Sprite> selectedSpecialSprites;

		public List<Sprite> keySprites;

		public List<Sprite> selectedKeySprites;

		public List<Sprite> typeSprites;

		private List<Sprite> allSprites;

		private List<Sprite> selectedSprites;

		private Sprite selectedSprite;

		private int rareType;

		private GameObject glow;

		private Image glowImage;

		private Image contents;

		private Image keyImage;

		private GameObject hint;

		private RectTransform hintRectTransform;

		private Image hintImage;

		private bool showHint;

		private bool glimmerPlaying;

		private GameObject glimmer;

		private RectTransform glimmerRectTransform;

		private Image glimmerImage;

		private Vector2 glimmerOrigin;

		private Vector2 glimmerDestination;

		private float glimmerTime;

		private float elapsedTime;

		private float normalizedTime;

		private MatchThree parentController;

		private bool _oldIsMatched;

		private Vector3 hintRotation;

		private bool collecting;

		private Vector2 keyPosA;

		private Vector2 keyPosB;

		private float collectionTime;

		private float elapsedCollectionTime;

		private float normalizedCollectionTime;

		private RectTransform keyRectTransform;

		public int Type
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int Generation
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsRare
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsMatched
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsSpecial
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsKey
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsUnlocked
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int KeyType
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int X
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int Y
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public EKeyState KeyState
		{
			[CompilerGenerated]
			get
			{
				return default(EKeyState);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void Awake()
		{
		}

		public void SetUp(int type, int x, int y, MatchThree parent)
		{
		}

		private void SetController(MatchThree matchThree)
		{
		}

		private void SetType(int value)
		{
		}

		public void OnPointerDown(PointerEventData pointerEventData)
		{
		}

		public void OnPointerUp(PointerEventData pointerEventData)
		{
		}

		public bool Matches(MatchThreeCellController other)
		{
			return default(bool);
		}

		public void MatchPreCheck()
		{
		}

		public void SetMatch(bool status, int generation)
		{
		}

		public void GlimmerIfChanged()
		{
		}

		[IteratorStateMachine(typeof(<Glimmer>d__85))]
		private IEnumerator Glimmer()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<AnimateGlimmer>d__86))]
		private IEnumerator AnimateGlimmer()
		{
			return null;
		}

		private void MakeSpecial()
		{
		}

		public void MakeKey()
		{
		}

		public void MakeKeyDependent()
		{
		}

		public void UpdateKeyState(bool previousKeyState, bool state)
		{
		}

		public void UpdateDependentKeyState(EKeyState rootState)
		{
		}

		private void GiveHint()
		{
		}

		private void StopHint()
		{
		}

		[IteratorStateMachine(typeof(<AnimateHint>d__95))]
		private IEnumerator AnimateHint()
		{
			return null;
		}

		public void CollectKey(GameObject keySlot)
		{
		}

		[IteratorStateMachine(typeof(<MoveKey>d__104))]
		private IEnumerator MoveKey()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<AnimateKeyMovement>d__105))]
		private IEnumerator AnimateKeyMovement()
		{
			return null;
		}
	}
}
