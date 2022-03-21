using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames.FindMatch
{
	public class FindMatchObject : ManagedBehaviour
	{
		internal int matchObjectIndex;

		public GameObject obj_buttonBack;

		public GameObject obj_imageFront;

		public Button button;

		public Text contentsInfoText;

		public float hideTime;

		public float hideScaleBump;

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

		public FindMatch FindMatchGame
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

		[IteratorStateMachine(typeof(<ShowObject>d__24))]
		public IEnumerator ShowObject(bool inShowFront)
		{
			return null;
		}

		public void ButtonClicked()
		{
		}

		public void Zonk()
		{
		}
	}
}
