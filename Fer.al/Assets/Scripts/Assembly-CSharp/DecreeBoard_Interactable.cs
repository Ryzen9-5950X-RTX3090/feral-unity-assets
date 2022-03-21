using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx.Async;
using UnityEngine;

public class DecreeBoard_Interactable : Interactable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <GetDecrees>d__6 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public DecreeBoard_Interactable <>4__this;

		private UniTask<ListDecreesResponse>.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private MeshRenderer _sign;

	[SerializeField]
	private float _cycleTimer;

	private Material _shaderMaterial;

	private List<string> _imageDefIds;

	public override bool ContinuousHarvest()
	{
		return default(bool);
	}

	public override void MStart()
	{
	}

	[AsyncStateMachine(typeof(<GetDecrees>d__6))]
	private void GetDecrees()
	{
	}

	[IteratorStateMachine(typeof(<CycleImages>d__7))]
	private IEnumerator CycleImages()
	{
		return null;
	}

	public override void RequestInteraction(EInteractableMessage inInteractableMessage)
	{
	}
}
