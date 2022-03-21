using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames
{
	public class DiggingCellController : MonoBehaviour
	{
		public List<Sprite> stateFiveSprites;

		public List<Color> stateFiveColors;

		public int stateFiveClicks;

		public List<Sprite> stateFourSprites;

		public List<Color> stateFourColors;

		public int stateFourClicks;

		public List<Sprite> stateThreeSprites;

		public List<Color> stateThreeColors;

		public int stateThreeClicks;

		public List<Sprite> stateTwoSprites;

		public List<Color> stateTwoColors;

		public int stateTwoClicks;

		public List<Sprite> stateOneSprites;

		public List<Color> stateOneColors;

		public int startingState;

		public GameObject particleSystemPrefab;

		public int particlesPerClick;

		private int _emberValue;

		private int stateIdx;

		private bool exposed;

		private bool collected;

		private Button button;

		private Image buttonImage;

		private Digging gameController;

		private List<List<Sprite>> spriteLists;

		private List<Sprite> spriteList;

		private List<List<Color>> colorLists;

		private List<int> clickCounts;

		private int clickCount;

		private int ccMax;

		private Image contents;

		private RectTransform contentsRectTransform;

		private GameObject contentsInfo;

		private Text contentsInfoText;

		private Sprite partialSprite;

		private Sprite exposedSprite;

		private Sprite openSprite;

		private GameObject particleContainer;

		private ParticleSystem particles;

		private ParticleSystem subParticles;

		private bool isOpening;

		private float elapsedTime;

		private float emberCollectionTime;

		private float fadeTime;

		private float textFadeTime;

		private static int MAX_NUM_STATES;

		private static int PARTIAL_STATE;

		private Vector2 posA;

		private Vector2 posB;

		private Color colorA;

		private Color colorB;

		private Vector2 sizeA;

		private Vector2 sizeB;

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

		public bool IsUncommon
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

		public bool IsDifficult
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

		public bool IsOpenable
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

		public bool IsOpen
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

		public bool IsBomb
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

		public int EmberValue
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		public void ButtonClicked()
		{
		}

		public void SetContents(Sprite partial, Sprite exposed, bool isRare = false, bool isUncommon = false, int emberValue = 0)
		{
		}

		public void MakeOpenable(Sprite sprite)
		{
		}

		public void SetGameController(Digging controller)
		{
		}

		private void MakeDifficult()
		{
		}

		private Sprite GetRandomSprite(List<Sprite> sprites)
		{
			return null;
		}

		private void StartCollection()
		{
		}

		[IteratorStateMachine(typeof(<OpenAndCollect>d__88))]
		private IEnumerator OpenAndCollect()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<AnimateChestOpening>d__89))]
		private IEnumerator AnimateChestOpening()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<AnimateEmberCollecting>d__90))]
		private IEnumerator AnimateEmberCollecting()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<AnimateContentFading>d__91))]
		private IEnumerator AnimateContentFading()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<AnimateInfoTextFading>d__92))]
		private IEnumerator AnimateInfoTextFading()
		{
			return null;
		}
	}
}
