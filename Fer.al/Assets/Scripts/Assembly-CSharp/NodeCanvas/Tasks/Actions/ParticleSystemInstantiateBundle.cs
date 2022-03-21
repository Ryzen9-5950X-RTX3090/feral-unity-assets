using System.Collections;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/ParticleSystem")]
	[Description("Instantiates and plays a bundled particle system")]
	public class ParticleSystemInstantiateBundle : ActionTask<Transform>
	{
		public string particleSystemDefId;

		public string particleSystemName;

		public int destroyDelay;

		private GameObject _gameObject;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnExecute()
		{
		}

		[IteratorStateMachine(typeof(<DestroyDelay>d__7))]
		private IEnumerator DestroyDelay()
		{
			return null;
		}
	}
}
