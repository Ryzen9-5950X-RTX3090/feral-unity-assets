using System;
using System.Collections;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/UI")]
	public class OpenShopActionTask : ActionTask
	{
		public string shopName;

		public string shopDefID;

		public bool closeShopToContinue;

		private string _infoText;

		private bool _itemPopupWindowOpen;

		private Type _type;

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

		private void OpenShop()
		{
		}

		[IteratorStateMachine(typeof(<AutoClose>d__10))]
		private IEnumerator AutoClose()
		{
			return null;
		}

		private void OnWindowOpened(WindowOpenedMessage inMessage)
		{
		}

		private void OnWindowClosed(WindowClosedMessage inMessage)
		{
		}
	}
}
