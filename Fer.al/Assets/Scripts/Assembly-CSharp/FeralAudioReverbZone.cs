using FMOD;
using UnityEngine;

[ManagedBehaviourManager("FeralAudioManager")]
public class FeralAudioReverbZone : ManagedBehaviour
{
	public SphereCollider mainZone;

	private Reverb3D reverb;

	private REVERB_PROPERTIES reverb_properties;
}
