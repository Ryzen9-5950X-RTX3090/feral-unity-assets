using System;

namespace VivoxUnity
{
	public interface IParticipantProperties
	{
		bool IsSelf { get; }

		bool InAudio { get; }

		bool InText { get; }

		bool UnavailableCaptureDevice { get; }

		bool UnavailableRenderDevice { get; }

		bool SpeechDetected { get; }

		double AudioEnergy { get; }

		int LocalVolumeAdjustment { get; set; }

		bool LocalMute { get; set; }

		[Obsolete]
		bool IsTyping { get; }

		bool IsMutedForAll { get; }
	}
}
