using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	public abstract class Grounder : MonoBehaviour
	{
		public delegate void GrounderDelegate();

		[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
		[Range(0f, 1f)]
		public float weight;

		[Tooltip("The Grounding solver. Not to confuse with IK solvers.")]
		public Grounding solver;

		public GrounderDelegate OnPreGrounder;

		public GrounderDelegate OnPostGrounder;

		public bool initiated
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public abstract void ResetPosition();

		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		protected void LogWarning(string message)
		{
		}

		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		protected abstract void OpenUserManual();

		protected abstract void OpenScriptReference();
	}
}
