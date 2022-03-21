using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Audio/VA Audio Source")]
public class VA_AudioSource : MonoBehaviour
{
	[Tooltip("Do you want this sound to emit from more than one shape?")]
	public bool Compound;

	[Tooltip("The shape you want the audio source to emit from")]
	public VA_Shape Shape;

	[Tooltip("The shapes you want the audio source to emit from")]
	public List<VA_Shape> Shapes;

	[Tooltip("The shape you want the audio source to be excluded from")]
	public VA_VolumetricShape ExcludedShape;

	[Tooltip("The shapes you want the audio source to be excluded from")]
	public List<VA_VolumetricShape> ExcludedShapes;

	[Tooltip("Should this sound turn to mono when the listener gets close?")]
	public bool Blend;

	[Tooltip("The distance at which the sound becomes fuly mono")]
	public float BlendMinDistance;

	[Tooltip("The distance at which the sound becomes fuly stereo")]
	public float BlendMaxDistance;

	[Tooltip("The distribution of the mono to stereo ratio")]
	public AnimationCurve BlendCurve;

	[Tooltip("Should this sound change volume as the listener gets close?")]
	public bool Volume;

	[Tooltip("The distance at which the sound becomes maximum volume")]
	public float VolumeMinDistance;

	[Tooltip("The distance at which the sound becomes minimum volume")]
	public float VolumeMaxDistance;

	[Tooltip("The distribution of volume based on its scaled distance")]
	public AnimationCurve VolumeCurve;

	[Tooltip("Should the audio be played on start?")]
	public bool PlayAudioOnStart;

	private FeralAudioEmitter _feralAudioEmitter;

	private AudioSource _audioSource;

	public bool HasVolumetricShape
	{
		get
		{
			return default(bool);
		}
	}

	private void SetAudioSourceAndPosition()
	{
	}

	private void LateUpdate()
	{
	}

	protected virtual void SetPanLevel(float newPanLevel)
	{
	}

	protected virtual void SetVolume(float newVolume)
	{
	}

	private void UpdateShapes()
	{
	}
}
