using System;
using System.Collections.Generic;
using FMOD;
using UnityEngine;

namespace FMODUnityResonance
{
	public static class FmodResonanceAudio
	{
		private struct RoomProperties
		{
			public float positionX;

			public float positionY;

			public float positionZ;

			public float rotationX;

			public float rotationY;

			public float rotationZ;

			public float rotationW;

			public float dimensionsX;

			public float dimensionsY;

			public float dimensionsZ;

			public FmodResonanceAudioRoom.SurfaceMaterial materialLeft;

			public FmodResonanceAudioRoom.SurfaceMaterial materialRight;

			public FmodResonanceAudioRoom.SurfaceMaterial materialBottom;

			public FmodResonanceAudioRoom.SurfaceMaterial materialTop;

			public FmodResonanceAudioRoom.SurfaceMaterial materialFront;

			public FmodResonanceAudioRoom.SurfaceMaterial materialBack;

			public float reflectionScalar;

			public float reverbGain;

			public float reverbTime;

			public float reverbBrightness;
		}

		public const float maxGainDb = 24f;

		public const float minGainDb = -24f;

		public const float maxReverbBrightness = 1f;

		public const float minReverbBrightness = -1f;

		public const float maxReverbTime = 3f;

		public const float maxReflectivity = 2f;

		private static readonly Matrix4x4 flipZ;

		private static readonly string listenerPluginName;

		private static readonly int roomPropertiesSize;

		private static readonly int roomPropertiesIndex;

		private static Bounds bounds;

		private static List<FmodResonanceAudioRoom> enabledRooms;

		private static VECTOR listenerPositionFmod;

		private static DSP listenerPlugin;

		private static DSP ListenerPlugin
		{
			get
			{
				return default(DSP);
			}
		}

		public static void UpdateAudioRoom(FmodResonanceAudioRoom room, bool roomEnabled)
		{
		}

		public static bool IsListenerInsideRoom(FmodResonanceAudioRoom room)
		{
			return default(bool);
		}

		private static float ConvertAmplitudeFromDb(float db)
		{
			return default(float);
		}

		private static void ConvertAudioTransformFromUnity(ref Vector3 position, ref Quaternion rotation)
		{
		}

		private static byte[] GetBytes(IntPtr ptr, int length)
		{
			return null;
		}

		private static RoomProperties GetRoomProperties(FmodResonanceAudioRoom room)
		{
			return default(RoomProperties);
		}

		private static DSP Initialize()
		{
			return default(DSP);
		}
	}
}
