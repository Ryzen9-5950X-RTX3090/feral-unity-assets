using UnityEngine;
using UnityEngine.UI;
using VivoxUnity;

public class RosterItem : MonoBehaviour
{
	private VivoxVoiceManager _vivoxVoiceManager;

	public IParticipant Participant;

	public Text PlayerNameText;

	public Image ChatStateImage;

	public Sprite MutedImage;

	public Sprite SpeakingImage;

	public Sprite NotSpeakingImage;

	private bool isMuted;

	private bool isSpeaking;

	public bool IsMuted
	{
		get
		{
			return default(bool);
		}
		private set
		{
		}
	}

	public bool IsSpeaking
	{
		get
		{
			return default(bool);
		}
		private set
		{
		}
	}

	private void UpdateChatStateImage()
	{
	}

	public void SetupRosterItem(IParticipant participant)
	{
	}
}
