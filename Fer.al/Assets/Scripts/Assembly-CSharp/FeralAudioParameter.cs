using System;
using UnityEngine;

[Serializable]
public class FeralAudioParameter
{
	[Tooltip("What the code will call to trigger the associated name in FMOD. This should not change once set in code.")]
	public string HelperName;

	[Tooltip("The variable name in FMOD")]
	public string Name;

	public int Value;
}
