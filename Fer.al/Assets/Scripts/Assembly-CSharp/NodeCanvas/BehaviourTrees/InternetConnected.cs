using System;
using System.Collections;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	[Name("InternetConnected", 8)]
	[Category("WildWorks/Internet")]
	[Description("Check for internet connected.\nIf set to Repeat, the connection check will repeat after each success or failure.")]
	[Icon("Sequencer", false, "")]
	[Color("bf7fff")]
	public class InternetConnected : BTComposite
	{
		public enum ERepeat
		{
			NONE,
			ONFAILURE,
			ONSUCCESS,
			ALWAYS
		}

		public ERepeat repeatType;

		public BBParameter<bool> connected;

		private Status _status;

		private bool _waiting;

		protected override Status OnExecute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		[IteratorStateMachine(typeof(<Connected>d__6))]
		private IEnumerator Connected(Action<bool> internetConnectedCallback)
		{
			return null;
		}
	}
}
