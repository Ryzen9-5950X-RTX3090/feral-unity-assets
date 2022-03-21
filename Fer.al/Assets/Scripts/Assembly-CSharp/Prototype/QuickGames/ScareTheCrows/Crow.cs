using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames.ScareTheCrows
{
	internal class Crow : UnityEngine.MonoBehaviour
	{
		internal enum EState
		{
			PECKING_UP,
			PECKING_DOWN,
			MOVING,
			FLEEING
		}

		internal ScareTheCrows Game;

		internal float currentStateTimer;

		internal int peckCount;

		internal Transform currentCrop;

		private float _flapTime;

		private bool _flapUp;

		internal Vector3 moveDir;

		internal Vector3 endPosition;

		private RawImage _crowImage;

		internal EState state;

		private void Awake()
		{
		}

		internal void CrowUpdate()
		{
		}

		private void Flap()
		{
		}

		[IteratorStateMachine(typeof(<CropAte>d__14))]
		private IEnumerator CropAte()
		{
			return null;
		}
	}
}
