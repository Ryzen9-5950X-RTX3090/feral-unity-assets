using System;
using System.Runtime.InteropServices;

public class UI_Window_AstralShopPurchaseConfirmation : UI_Window_YesNoPopup
{
	public new static void OpenWindow(string inTitle = "", string inMessage = "", string inYesBtnText = "", string inNoBtnText = "", [Optional] Action<bool> inResponseCallback)
	{
	}

	public new static void QueueWindow(string inTitle = "", string inMessage = "", string inYesBtnText = "", string inNoBtnText = "", [Optional] Action<bool> inResponseCallback)
	{
	}
}
