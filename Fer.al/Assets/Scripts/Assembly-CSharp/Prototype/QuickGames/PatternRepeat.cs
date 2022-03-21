using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype.QuickGames
{
	public class PatternRepeat : QuickGamesBase
	{
		[Header("Pattern Repeat")]
		public PatternRepeatObject objectToRepeat;

		public Texture offImage;

		public Texture onImage;

		public Texture goodImage;

		public Texture badImage;

		public int numberOfObjectsToChooseFrom;

		public float distanceFromCenterToPlace;

		public int numberOfobjectsInPattern;

		[Header("Intro")]
		public float timeToShowGood;

		public float timeBetweenShowing;

		private int _repeatIndex;

		private List<PatternRepeatObject> _repeatingObjects;

		private List<PatternRepeatObject> _allObjects;

		public override void MStart()
		{
		}

		private Vector2 RotateV2(Vector2 v, float degrees)
		{
			return default(Vector2);
		}

		[IteratorStateMachine(typeof(<ShowIntro>d__15))]
		public override IEnumerator ShowIntro()
		{
			return null;
		}

		public bool ButtonClick(int inIndex)
		{
			return default(bool);
		}

		[IteratorStateMachine(typeof(<ShowResults>d__17))]
		public override IEnumerator ShowResults()
		{
			return null;
		}
	}
}
