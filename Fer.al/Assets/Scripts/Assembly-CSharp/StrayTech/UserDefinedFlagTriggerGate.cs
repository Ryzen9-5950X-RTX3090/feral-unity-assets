using UnityEngine;

namespace StrayTech
{
	public class UserDefinedFlagTriggerGate : MonoBehaviour, ITriggerGate
	{
		[SerializeField]
		[Tooltip("If this user defined flag is false, OnTriggerEnter logic will be bypassed.")]
		private string _userDefinedFlagName;

		public bool IsActive
		{
			get
			{
				return default(bool);
			}
		}

		private void Start()
		{
		}

		public void TriggerWasEntered(Collider other)
		{
		}

		public bool IsTriggerBlocked()
		{
			return default(bool);
		}
	}
}
