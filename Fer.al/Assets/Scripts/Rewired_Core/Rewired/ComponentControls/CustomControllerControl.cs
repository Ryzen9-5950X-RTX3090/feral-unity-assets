using System;
using Rewired.ComponentControls.Data;
using UnityEngine;

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent]
	public abstract class CustomControllerControl : ComponentControl
	{
		internal CustomController controller
		{
			get
			{
				return null;
			}
		}

		internal override bool hasController
		{
			get
			{
				return default(bool);
			}
		}

		[CustomObfuscation]
		internal CustomControllerControl()
		{
		}

		internal override void OnSubscribeEvents()
		{
		}

		internal override void OnUnsubscribeEvents()
		{
		}

		[CustomObfuscation]
		internal override IComponentController FindController()
		{
			return null;
		}

		[CustomObfuscation]
		internal override Type GetRequiredControllerType()
		{
			return null;
		}

		internal void dlwdszwdDeKocMSXhvmIcxgUNHA(CustomControllerElementTargetSet P_0, float P_1, float P_2)
		{
		}

		internal void dlwdszwdDeKocMSXhvmIcxgUNHA(CustomControllerElementTargetSet P_0, bool P_1)
		{
		}

		internal abstract void OnCustomControllerUpdate();

		private void dlwdszwdDeKocMSXhvmIcxgUNHA(CustomControllerElementTarget P_0, float P_1, float P_2)
		{
		}

		private void dlwdszwdDeKocMSXhvmIcxgUNHA(CustomControllerElementTarget P_0, bool P_1)
		{
		}

		private void RfZaswuAvIkWkyDeOKtBcJVcYXc()
		{
		}
	}
}
