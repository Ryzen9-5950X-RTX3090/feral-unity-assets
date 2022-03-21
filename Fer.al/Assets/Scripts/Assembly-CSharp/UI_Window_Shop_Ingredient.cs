using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using WW.Debug;

public class UI_Window_Shop_Ingredient : UI_Window_Shop_CraftableItem
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <OnItemSelected>d__11 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_Shop_Ingredient <>4__this;

		public BaseDef inDef;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	[Header("Furniture Shop")]
	private UI_StageSubjectPositioner _stagePositioner;

	private UI_Stage_3DItem _itemStage;

	[DebugButton("Open Ingredient Shop", "Shop", true, true)]
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

	private void OnStageLoaded(UI3DItemStageLoadedMessage inMessage)
	{
	}

	private void OnStageInitialized(UI3DItemStageInitializedMessage inMessage)
	{
	}

	[AsyncStateMachine(typeof(<OnItemSelected>d__11))]
	private void OnItemSelected(BaseDef inDef)
	{
	}
}
