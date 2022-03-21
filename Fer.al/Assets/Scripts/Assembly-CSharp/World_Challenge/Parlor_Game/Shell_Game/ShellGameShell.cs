using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace World_Challenge.Parlor_Game.Shell_Game
{
	public class ShellGameShell : ManagedBehaviour
	{
		[Header("Shell Game Shell")]
		public MeshCollider meshCollider;

		[Header("Portals")]
		public Renderer portalPlane;

		internal bool hasBall;

		internal bool isInPortal;

		internal bool right;

		internal int spotsMoved;

		internal int shuffleIndex;

		internal int potentialShuffleIndex;

		internal int shellPortalColorIndex;

		internal Transform portalTrans1;

		internal Transform portalTrans2;

		internal ShellGame game;

		private float _td;

		private float _portalThirds;

		private Vector3 _portalOpenScale;

		private Renderer _portalPlane2;

		public override void MStart()
		{
		}

		internal void Init()
		{
		}

		internal void SetColor()
		{
		}

		[IteratorStateMachine(typeof(<ActivatePortal>d__19))]
		internal IEnumerator ActivatePortal(bool inHide)
		{
			return null;
		}

		private void OnMouseDown()
		{
		}
	}
}
