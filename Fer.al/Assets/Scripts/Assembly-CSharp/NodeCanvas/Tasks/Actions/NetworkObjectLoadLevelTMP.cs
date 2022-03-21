using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Network/Messages")]
	[Description("Send a load level network message. Probably not how it's going to be done so probably don't use this.")]
	public class NetworkObjectLoadLevelTMP : ActionTask
	{
		[SerializeField]
		private string sceneName;

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
	}
}
