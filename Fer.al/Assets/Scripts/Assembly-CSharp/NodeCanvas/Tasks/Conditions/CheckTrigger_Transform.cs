using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("System Events")]
	[Description("The agent is type of Transform so that Triggers can either work with a Collider or a Rigidbody attached.")]
	public class CheckTrigger_Transform : ConditionTask<Transform>
	{
		private static bool avatarUpdated;

		public TriggerTypes checkType;

		public bool specifiedTagOnly;

		[TagField]
		[ShowIf("specifiedTagOnly", 1)]
		public string objectTag;

		[BlackboardOnly]
		public BBParameter<GameObject> saveGameObjectAs;

		private bool stay;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override bool OnCheck()
		{
			return default(bool);
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public void OnTriggerEnter(EventData<Collider> data)
		{
		}

		public void OnTriggerExit(EventData<Collider> data)
		{
		}
	}
}
