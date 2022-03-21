using System.Runtime.CompilerServices;

namespace VivoxUnity
{
	public class VivoxConfig
	{
		private vx_sdk_config_t vx_sdk_config;

		public int CodecThreads
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int VoiceThreads
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int WebThreads
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int RenderSourceQueueDepthMax
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int RenderSourceInitialBufferCount
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int UpstreamJitterFrameCount
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int MaxLoginsPerUser
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public vx_log_level InitialLogLevel
		{
			get
			{
				return default(vx_log_level);
			}
			set
			{
			}
		}

		public bool DisableDevicePolling
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool ForceCaptureSilence
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool EnableAdvancedAutoLevels
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int CaptureDeviceBufferSizeIntervals
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int RenderDeviceBufferSizeIntervals
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool DisableAudioDucking
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool EnableDtx
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public MediaCodecType DefaultCodecsMask
		{
			get
			{
				return default(MediaCodecType);
			}
			set
			{
			}
		}

		public bool EnableFastNetworkChangeDetection
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int UseOsProxySettings
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool DynamicVoiceProcessingSwitching
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int NeverRtpTimeoutMs
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int LostRtpTimeoutMs
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool SkipPrepareForVivox
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public vx_sdk_config_t ToVx_Sdk_Config()
		{
			return null;
		}
	}
}
