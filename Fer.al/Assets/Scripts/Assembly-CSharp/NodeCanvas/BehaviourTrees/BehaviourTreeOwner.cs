using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	[AddComponentMenu("NodeCanvas/Behaviour Tree Owner")]
	public class BehaviourTreeOwner : GraphOwner<BehaviourTree>
	{
		public bool repeat
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float updateInterval
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Status rootStatus
		{
			get
			{
				return default(Status);
			}
		}

		public Status Tick()
		{
			return default(Status);
		}
	}
}
