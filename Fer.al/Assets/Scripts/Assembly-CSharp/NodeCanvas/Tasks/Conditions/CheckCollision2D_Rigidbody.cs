using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("System Events")]
	[Name("Check Collision 2D", 0)]
	public class CheckCollision2D_Rigidbody : ConditionTask<Rigidbody2D>
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

		private void OnCollisionEnter2D(EventData<Collision2D> data)
		{
		}

		private void OnCollisionExit2D(EventData<Collision2D> data)
		{
		}
	}
}
