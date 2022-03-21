using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	[DoNotList]
	[Category("System Events")]
	public class CheckTrigger : ConditionTask<Collider>
	{
		public TriggerTypes checkType;

		public bool specifiedTagOnly;

		[TagField]
		[ShowIf("specifiedTagOnly", 1)]
		public string objectTag;

		public string whynot;

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
