using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace World_Challenge.Parlor_Game.CeeLo
{
	public class DiceCannonController : MonoBehaviour
	{
		public GameObject diePrefab;

		public Transform dieLocator;

		public Transform aimLocator;

		public GameObject turret;

		public float turretRotationSpeed;

		public float minCannonForce;

		public float maxCannonForce;

		private float cannonForce;

		private CeeLoController parentController;

		private List<GameObject> dice;

		private GameObject loadedDie;

		private int diceOut;

		private bool allDiceCounted;

		private bool isFiringManual;

		private float pivotTime;

		private float elapsedPivotTime;

		private int pivotDir;

		private Quaternion startRotation;

		public bool RollInProgress
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool RollComplete
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsAutomatic
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int DieValueA
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int DieValueB
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int DieValueC
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool AllDiceFired
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void SetUp(CeeLoController parentController, bool isAutomatic)
		{
		}

		public void ResetState()
		{
		}

		public void UpdateManual()
		{
		}

		public void CheckDice()
		{
		}

		public void StartFiring()
		{
		}

		private void LoadDieManual()
		{
		}

		[IteratorStateMachine(typeof(<FireDieManual>d__52))]
		private IEnumerator FireDieManual()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<AutoFire>d__53))]
		private IEnumerator AutoFire()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<Fire>d__54))]
		private IEnumerator Fire()
		{
			return null;
		}

		private int GetDieValue(GameObject dieObject)
		{
			return default(int);
		}
	}
}
