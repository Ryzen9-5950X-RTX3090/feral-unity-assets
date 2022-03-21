using System.Runtime.InteropServices;
using WW.Debug;

public class UI_Window_Shop_Dye : UI_Window_Shop_CraftableItem
{
	private UI_Stage_DyeShop _stage;

	public UI_Stage_DyeShop Stage
	{
		get
		{
			return null;
		}
	}

	[DebugButton("Open Dye Shop", "Shop", true, true)]
	public static void OpenWindow()
	{
	}

	public new static void OpenWindow([Optional] ShopContentDefComponent inShopDef)
	{
	}

	public new static void QueueWindow([Optional] ShopContentDefComponent inShopDef)
	{
	}

	public new static void CloseWindow()
	{
	}

	public override void Setup([Optional] ShopContentDefComponent inShopDef)
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	private void OnStageLoaded(UIDyeShopStageLoadedMessage inMessage)
	{
	}

	private void OnItemSelected(BaseDef inDef)
	{
	}

	protected override void OnItemCraftInitiated(BaseDef inDef, int inQuantity)
	{
	}

	protected override void OnItemCrafted(BuyItemResponse inMessage)
	{
	}
}
