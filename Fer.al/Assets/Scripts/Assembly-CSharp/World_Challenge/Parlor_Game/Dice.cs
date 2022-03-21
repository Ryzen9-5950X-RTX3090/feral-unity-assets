using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace World_Challenge.Parlor_Game
{
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(MeshCollider))]
	public class Dice : MonoBehaviour
	{
		[Header("Dice")]
		public Rigidbody body;

		public MeshCollider meshCollider;

		[Tooltip("Entry 0 is the center.")]
		public Transform[] sideLocators;

		internal DiceManager diceManager;

		internal int faceValue;

		internal bool canSelect;

		[IteratorStateMachine(typeof(<Shoot>d__6))]
		internal IEnumerator Shoot()
		{
			return null;
		}

		internal void GetFaceValue()
		{
		}

		private void OnMouseDown()
		{
		}

		private void OnMouseUp()
		{
		}

		[IteratorStateMachine(typeof(<Reset>d__10))]
		internal IEnumerator Reset(int inSpawnLocationIndex, Vector3 inOffset, float inRotateAngle)
		{
			return null;
		}
	}
}
