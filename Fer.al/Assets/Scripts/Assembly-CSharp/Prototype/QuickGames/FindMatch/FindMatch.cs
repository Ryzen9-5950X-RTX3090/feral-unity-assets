using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames.FindMatch
{
	public class FindMatch : QuickGamesBase
	{
		[Header("Intro")]
		public float timeForIntro;

		[Header("Find Match")]
		public Texture[] matchImages;

		public Texture emberImage;

		public FindMatchObject findMatchObject;

		public int gridSpotsX;

		public int gridSpotsY;

		public float emberRiseTime;

		public float emberRiseHeight;

		public float zonkTime;

		[Header("Results")]
		public float resultsFadeTime;

		internal bool canClick;

		private Color _transparentWhite;

		private int _embersFound;

		private int _numberOfObjectsMatched;

		private List<FindMatchObject> _objectsToMatch;

		private int _indexToMatch;

		private List<FindMatchObject> _zonkCards;

		public override void MStart()
		{
		}

		[IteratorStateMachine(typeof(<ShowIntro>d__18))]
		public override IEnumerator ShowIntro()
		{
			return null;
		}

		public void FoundObject(FindMatchObject inObject)
		{
		}

		[IteratorStateMachine(typeof(<EmberRise>d__20))]
		private IEnumerator EmberRise(RawImage inRawImage, Text inContentsInfoText)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<Zonk>d__21))]
		private IEnumerator Zonk()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<ShowResults>d__22))]
		public override IEnumerator ShowResults()
		{
			return null;
		}
	}
}
