using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

public class UI_ListItem_AAVPreview : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <SetIsAnimating>d__14 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_ListItem_AAVPreview <>4__this;

		public bool inIsAnimating;

		private UniTask.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <SetAction>d__15 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_ListItem_AAVPreview <>4__this;

		public ActorActionType inAction;

		private UniTask.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private RawImage _rawImage;

	[SerializeField]
	private LayoutElement _layoutElement;

	private ActorInfo _actorInfo;

	private Item _attachedClothingItem;

	private Vector3? _baseOffset;

	private ActorBase Actor
	{
		get
		{
			return null;
		}
	}

	public void Setup(ActorInfo inInfo, bool inUseCombinedMesh)
	{
	}

	public void UpdateRotation(Vector2 inRotateAmount)
	{
	}

	public void UpdateOffset(Vector3 inOffsetAmount)
	{
	}

	public void SetSize(float inSize)
	{
	}

	public void SetClothing(ActorClothingDefComponent inClothingDef)
	{
	}

	public void RemoveClothing()
	{
	}

	public void RemoveClothing(ActorClothingDefComponent inClothingToRemove)
	{
	}

	[AsyncStateMachine(typeof(<SetIsAnimating>d__14))]
	public void SetIsAnimating(bool inIsAnimating)
	{
	}

	[AsyncStateMachine(typeof(<SetAction>d__15))]
	public void SetAction(ActorActionType inAction)
	{
	}
}
