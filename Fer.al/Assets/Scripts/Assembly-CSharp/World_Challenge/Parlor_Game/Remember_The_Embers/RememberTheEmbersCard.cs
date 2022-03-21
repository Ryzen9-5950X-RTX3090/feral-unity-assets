using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace World_Challenge.Parlor_Game.Remember_The_Embers
{
	public class RememberTheEmbersCard : ManagedBehaviour
	{
		internal enum EMatchObjectType
		{
			EMBER,
			MATCH1,
			MATCH2,
			MATCH3
		}

		[Header("Remember The Embers Card")]
		public MeshCollider meshCollider;

		public Renderer frontRenderer;

		internal bool cardFlipped;

		internal float randomRank;

		internal RememberTheEmbers game;

		internal EMatchObjectType MatchObjectType;

		private float _slice;

		private Vector3 _startPos;

		private Vector3 _endPos;

		private float _halfTime;

		private Quaternion _faceUp;

		private Quaternion _faceDown;

		public override void Awake()
		{
		}

		[IteratorStateMachine(typeof(<FlipObject>d__14))]
		internal IEnumerator FlipObject(bool inShowFront)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<ShowObject>d__15))]
		internal IEnumerator ShowObject(bool inShowFront, float inSlice)
		{
			return null;
		}

		private void OnMouseDown()
		{
		}
	}
}
