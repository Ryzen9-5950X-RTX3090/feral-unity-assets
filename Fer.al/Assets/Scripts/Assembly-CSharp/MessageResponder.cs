using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[ManagedBehaviourManager("MessageManager")]
public class MessageResponder : ManagedBehaviour
{
	[Serializable]
	public class MessageTriggerEvent : UnityEvent<Message>
	{
	}

	[Serializable]
	public class MessageTrigger
	{
		public string eventID;

		public string tag;

		public MessageTriggerEvent callback;

		public Action<Message> invokeAction;
	}

	[SerializeField]
	private List<MessageTrigger> _triggers;

	private bool _triggersSetup;

	[SerializeField]
	private bool _respondOnMobile;

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	public void SetupTriggers()
	{
	}

	private void DeRegisterTriggers()
	{
	}
}
