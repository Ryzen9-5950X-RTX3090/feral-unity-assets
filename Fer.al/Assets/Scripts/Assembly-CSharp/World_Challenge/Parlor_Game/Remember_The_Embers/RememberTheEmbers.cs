using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace World_Challenge.Parlor_Game.Remember_The_Embers
{
	public class RememberTheEmbers : ParlorGame
	{
		[Header("Remember The Embers")]
		public Transform deckLocator;

		public RememberTheEmbersCard card;

		public Texture matchImage1;

		public Texture matchImage2;

		public Texture matchImage3;

		public Texture emberImage;

		public int gridSpotsX;

		public int gridSpotsZ;

		public float cardSpacing;

		public float dealDelay;

		public float dealSpeed;

		public float flipHeight;

		public float flipTime;

		private int _embersFound;

		private int _numberOfObjectsMatched;

		private List<RememberTheEmbersCard> _cardsToMatch;

		private RememberTheEmbersCard.EMatchObjectType _typeToMatch;

		public override void MStart()
		{
		}

		internal override void Intro()
		{
		}

		[IteratorStateMachine(typeof(<Intro_ShowAndHide>d__19))]
		private IEnumerator Intro_ShowAndHide()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<Intro_DealCard>d__20))]
		private IEnumerator Intro_DealCard(int inIndex, Vector3 inEndPos)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<Intro_DealCards>d__21))]
		private IEnumerator Intro_DealCards()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<Results_ReturnCard>d__22))]
		private IEnumerator Results_ReturnCard(int inIndex)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<Results_ReturnCards>d__23))]
		private IEnumerator Results_ReturnCards()
		{
			return null;
		}

		internal void FoundObject(RememberTheEmbersCard.EMatchObjectType inMatchObjectType)
		{
		}

		[IteratorStateMachine(typeof(<ShowResults>d__25))]
		public override IEnumerator ShowResults()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<CleanupResultsCards>d__26))]
		private IEnumerator CleanupResultsCards()
		{
			return null;
		}

		internal override void ResultsDone()
		{
		}
	}
}
