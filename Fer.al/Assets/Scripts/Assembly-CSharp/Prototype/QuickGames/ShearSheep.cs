using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames
{
	public class ShearSheep : QuickGamesBase
	{
		[Header("Shear Sheep")]
		public GameObject woolHolder;

		public RawImage sheepImage;

		public Texture scissors_open;

		public Texture scissors_closed;

		public float scissorSpeed;

		public float woolMultiplier;

		public float woolGravity;

		public float woolMass;

		public float clickDistance;

		private Vector2 _woolDir;

		private bool _isClicking;

		private QuickGamesMoveCursor _cursorMover;

		private RawImage _scissors_image;

		private List<Transform> _wools;

		private List<Vector2> _woolsPositions;

		public override void MStart()
		{
		}

		[IteratorStateMachine(typeof(<ScissorShear>d__16))]
		private IEnumerator ScissorShear()
		{
			return null;
		}

		public override void QuickGameUpdate()
		{
		}

		[IteratorStateMachine(typeof(<ShowResults>d__18))]
		public override IEnumerator ShowResults()
		{
			return null;
		}
	}
}
