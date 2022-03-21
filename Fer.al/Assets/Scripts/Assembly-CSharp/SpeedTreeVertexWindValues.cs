using DG.DeInspektor.Attributes;
using UnityEngine;

[DeComponentDescription("Use this to override wind values for the modified SpeedTree Wind shaders. Two modes:\n \t-Set Values from Wind Zone (Requires WindZone component)\n\t-Set Values from This Component")]
public class SpeedTreeVertexWindValues : MonoBehaviour
{
	public enum WindValuesMode
	{
		SetFromWindZone,
		SetFromValues
	}

	public WindValuesMode mode;

	[DeComment("Wind Zone:\n-Wind Dir: Set the transform's rotation to set the wind's direction\n-Wind Strength, set Wind Zone's \"Main\" value, default is 0.7\n-Wind Frequency, set Wind Zone's \"Turbulence\" value, default is 15\n\nThe Wind Zone's Pulse Magnitude and Frequency are not used.", "mode", 0, Condition.Is, ConditionalBehaviour.Hide)]
	[DeConditional("__notForDisplay", true, ConditionalBehaviour.Hide)]
	public bool __notForDisplay;

	[DeBeginGroup]
	[DeComment("Wind Values:\n-Wind Dir: Set the transform's rotation to set the wind's direction\n-Wind Strength - Strength/Magnitude of wind (default = 0.7)\n-Wind Frequency - Frequency or wave size of wind (default = 15)", "mode", 1, Condition.Is, ConditionalBehaviour.Hide)]
	[DeBeginDisabled("mode", 0, Condition.Is)]
	public float windStrength;

	[DeEndGroup]
	[DeEndDisabled]
	[DeRange(5f, 50f, null)]
	public float windFrequency;

	[Space]
	[Space(8f)]
	[DeToggleButton("Edit Advanced Values", DePosition.HExtended, "332020", "1F3322", "B4B4B4", "B4B4B4")]
	public bool showAdvancedOptions;

	[Space]
	[DeBeginGroup]
	[DeBeginDisabled("showAdvancedOptions", true)]
	[DeRange(0f, 10f, null)]
	public float treeSwaySpeed;

	[DeRange(0f, 1f, null)]
	public float treeSwayDisplacement;

	[DeRange(0f, 10f, null)]
	public float treeSwayStutter;

	[DeRange(0f, 1f, null)]
	public float treeSwayStutterInfluence;

	public float leavesWiggleDisplacement;

	public float leavesWiggleSpeed;

	[DeRange(0f, 0.5f, null)]
	public float branchDisplacement;

	[Space]
	[DeRange(0f, 1f, null)]
	[Space(6f)]
	public float redVertColorInfluence;

	[DeEndGroup]
	[DeEndDisabled]
	[DeRange(0f, 1f, null)]
	public float blueVertColorInfluence;

	[DeConditional("__notForDisplay", true, ConditionalBehaviour.Hide)]
	public bool __notForDisplay2;

	private WindZone _windZone;

	private float _lastWindZoneMain;

	private float _lastWindZoneTurbulence;

	private Quaternion _lastRotaton;

	private void Start()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	public void ApplyWindValues()
	{
	}

	private void OnValidate()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	private void LogWindDirMag()
	{
	}
}
