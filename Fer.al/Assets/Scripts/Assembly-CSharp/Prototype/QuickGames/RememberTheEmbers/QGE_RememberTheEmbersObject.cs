using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames.RememberTheEmbers
{
	public class QGE_RememberTheEmbersObject : ManagedBehaviour
	{
		public enum EMatchObjectType
		{
			EMBER,
			INGREDIENT,
			MATCH1,
			MATCH2,
			MATCH3
		}

		public GameObject obj_buttonBack;

		public GameObject obj_imageFront;

		public Button button;

		public float hideTime;

		public float hideScaleBump;

		public EMatchObjectType MatchObjectType
		{
			[CompilerGenerated]
			get
			{
				return default(EMatchObjectType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public RawImage ImageFront
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

		public RawImage ImageBack
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

		public float RandomRank
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

		public QGE_RememberTheEmbers RememberTheEmbersGame
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

		public override void UAwake()
		{
		}

		[IteratorStateMachine(typeof(<ShowObject>d__27))]
		public IEnumerator ShowObject(bool inShowFront)
		{
			return null;
		}

		public void ButtonClicked()
		{
		}
	}
}
