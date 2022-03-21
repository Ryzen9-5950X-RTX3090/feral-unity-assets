using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Private
{
	internal class ChannelParticipant : IParticipant, IKeyedItemNotifyPropertyChanged<string>, INotifyPropertyChanged, IParticipantProperties
	{
		private readonly ChannelSession _parent;

		private bool _speechDetected;

		private bool _isTyping;

		private bool _textActive;

		private bool _audioActive;

		private double _audioEnergy;

		private bool _isMutedForEveryone;

		private bool _unavailableCaptureDevice;

		private bool _unavailableRenderDevice;

		private bool _localMute;

		private int _localVolumeAdjustment;

		[CompilerGenerated]
		private readonly bool <IsSelf>k__BackingField;

		[CompilerGenerated]
		private readonly AccountId <Account>k__BackingField;

		[CompilerGenerated]
		private readonly string <Key>k__BackingField;

		internal bool _internalMute
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		internal int _internalVolumeAdjustment
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public IChannelSession ParentChannelSession
		{
			get
			{
				return null;
			}
		}

		public bool IsSelf
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		public AccountId Account
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string Key
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public bool SpeechDetected
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool IsMutedForAll
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool LocalMute
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int LocalVolumeAdjustment
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool IsTyping
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool InText
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool InAudio
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool UnavailableCaptureDevice
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool UnavailableRenderDevice
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public double AudioEnergy
		{
			get
			{
				return default(double);
			}
			set
			{
			}
		}

		public string ParticipantId
		{
			get
			{
				return null;
			}
		}

		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public ChannelParticipant(ChannelSession parent, vx_evt_participant_added_t theEvent)
		{
		}

		public IAsyncResult SetIsMuteForAll(string accountHandle, bool setMuted, string accessToken, AsyncCallback callback)
		{
			return null;
		}
	}
}
