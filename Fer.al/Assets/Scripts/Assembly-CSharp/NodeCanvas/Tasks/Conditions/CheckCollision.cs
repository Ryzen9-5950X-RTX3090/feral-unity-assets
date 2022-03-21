using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	[DoNotList]
	[Category("System Events")]
	public class CheckCollision : ConditionTask<Collider>
	{
		public CollisionTypes checkType;

		public bool specifiedTagOnly;

		[TagField]
		public string objectTag;

		[BlackboardOnly]
		public BBParameter<GameObject> saveGameObjectAs;

		[BlackboardOnly]
		public BBParameter<Vector3> saveContactPoint;

		[BlackboardOnly]
		public BBParameter<Vector3> saveContactNormal;

		private bool stay;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override bool OnCheck()
		{
			return default(bool);
		}

		public void OnCollisionEnter(EventData<Collision> data)
		{
		}

		public void OnCollisionExit(EventData<Collision> data)
		{
		}
	}
}
