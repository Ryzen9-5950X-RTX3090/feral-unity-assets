using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/ParticleSystem")]
	[Description("Calls Play or Stop on the supplied list of particleSystems")]
	public class ParticleSystemsPlay : ActionTask
	{
		public enum EActionType
		{
			Play,
			Stop
		}

		public EActionType actionType;

		[ShowIf("actionType", 0)]
		public bool enableFirst;

		public float disableDelay;

		public List<ParticleSystem> particleSystems;

		public List<BBParameter<ParticleSystem>> particleSystemsVARS;

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

		[IteratorStateMachine(typeof(<Disable>d__9))]
		private IEnumerator Disable(float inDelay)
		{
			return null;
		}
	}
}
