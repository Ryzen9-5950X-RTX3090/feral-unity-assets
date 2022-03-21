using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using VivoxUnity;

[Serializable]
public class PositionalVoice : MonoBehaviour
{
	public class OnParticipantProperty : UnityEvent<IParticipant, PropertyChangedEventArgs>
	{
	}

	public OnParticipantProperty m_ParticipantPropertyEvent;

	public GameObject PositionalGameObject;

	private IChannelSession ChannelSession;

	private string positionalChannelName;

	private IParticipant _participant;

	public bool isSpeaking
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Channel3DProperties ChannelProperties
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public IParticipant Participant
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void SetupParticipantHandlers()
	{
	}

	private void Participant_PropertyChanged(object sender, PropertyChangedEventArgs e)
	{
	}

	public void Update3dPosition(Transform listener, Transform speaker)
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}
}
