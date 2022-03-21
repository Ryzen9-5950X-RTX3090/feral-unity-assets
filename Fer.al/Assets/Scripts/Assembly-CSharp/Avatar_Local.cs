using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class Avatar_Local : AvatarBase
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <OnCreate>d__7 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public Avatar_Local <>4__this;

		public ActorInfo inInfo;

		public Action<GameObject, ActorInfo> inFinishedCallback;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public const float MovementSampleInterval = 0.2f;

	public static Avatar_Local instance;

	public static Color persistentDirtTargetColor;

	public static float persistentDirtAccel;

	public static float persistentDirtCurrentLerp;

	public EquippableManager equippableManager;

	private ObscuredVector3 _lastSentPosition;

	private WorldObjectMoverNodeType _lastSentNodeType;

	private ActorActionType _lastSentActionType;

	private float _sendTimer;

	private List<LocationDefComponent> _currentLocationList;

	public static Avatar_Local CreateLocal(Vector3 inPosition, Quaternion inRotation, Action<GameObject, ActorInfo> inFinishedCallback)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<OnCreate>d__7))]
	public override void OnCreate(ActorInfo inInfo, Action<GameObject, ActorInfo> inFinishedCallback)
	{
	}

	public void SetDefault()
	{
	}

	public override void MStart()
	{
	}

	public override void MOnEnable()
	{
	}

	public override void MOnDisable()
	{
	}

	public override void MOnDestroy()
	{
	}

	public static void DestroyInstance()
	{
	}

	public override void MUpdate()
	{
	}

	public void ClearEffectsForTeleport()
	{
	}

	public override void Teleport(ObscuredVector3 inPosition, ObscuredQuaternion inRotation, string inUniqueMapId, string userToGoToId)
	{
	}

	public override void Teleport(ObscuredVector3 inPosition, ObscuredQuaternion inRotation)
	{
	}

	public void TeleportFromMap(Transform inTransform)
	{
	}

	public void TeleportFromMap(WorldMapLocation inWorldMapLocation)
	{
	}

	public void TeleportFromMap(string inUniqueMapId)
	{
	}

	public void SendLatestMovement()
	{
	}

	public override void RegisterListeners()
	{
	}

	public override void UnregisterListeners()
	{
	}

	private void OnLocationChanged(LocationVolumeMessage inMessage)
	{
	}

	public LocationDefComponent GetLocation()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<Build>d__31))]
	public override IEnumerator Build()
	{
		return null;
	}
}
