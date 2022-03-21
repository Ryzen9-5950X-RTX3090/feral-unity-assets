using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype.QuickGames.RememberTheEmbers
{
	public class QGE_RememberTheEmbers : QuickGamesBase
	{
		[Header("Find Match")]
		public GameObject instructions;

		public Texture matchImage1;

		public Texture matchImage2;

		public Texture matchImage3;

		public Texture ingredientImage;

		public Texture emberImage;

		public QGE_RememberTheEmbersObject findMatchObject;

		public int gridSpotsX;

		public int gridSpotsY;

		[Header("Intro")]
		public float timeForIntro;

		[Header("Results")]
		public float resultsFadeTime;

		private bool _foundIngredient;

		private int _embersFound;

		private int _numberOfObjectsMatched;

		private List<QGE_RememberTheEmbersObject> _objectsToMatch;

		private QGE_RememberTheEmbersObject.EMatchObjectType _typeToMatch;

		public override void MStart()
		{
		}

		[IteratorStateMachine(typeof(<ShowIntro>d__17))]
		public override IEnumerator ShowIntro()
		{
			return null;
		}

		public void FoundObject(QGE_RememberTheEmbersObject.EMatchObjectType inMatchObjectType)
		{
		}

		[IteratorStateMachine(typeof(<ShowResults>d__19))]
		public override IEnumerator ShowResults()
		{
			return null;
		}
	}
}
