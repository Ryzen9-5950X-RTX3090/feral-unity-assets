using UnityEngine;

[CreateAssetMenu]
public class UI_ButtonColorSet : ScriptableObject
{
	[Header("On - Normal")]
	public Color onNormalBGColor;

	public Color onNormalIconColor1;

	public Color onNormalIconColor2;

	public Color onNormalTextColor;

	[Header("On - Highlighted")]
	public Color onHighlightedBGColor;

	public Color onHighlightedIconColor1;

	public Color onHighlightedIconColor2;

	public Color onHighlightedTextColor;

	[Header("On - Disabled")]
	public Color onDisabledBGColor;

	public Color onDisabledIconColor1;

	public Color onDisabledIconColor2;

	public Color onDisabledTextColor;

	[Header("Off - Normal")]
	public Color offNormalBGColor;

	public Color offNormalIconColor1;

	public Color offNormalIconColor2;

	public Color offNormalTextColor;

	[Header("Off - Highlighted")]
	public Color offHighlightedBGColor;

	public Color offHighlightedIconColor1;

	public Color offHighlightedIconColor2;

	public Color offHighlightedTextColor;

	[Header("Off - Disabled")]
	public Color offDisabledBGColor;

	public Color offDisabledIconColor1;

	public Color offDisabledIconColor2;

	public Color offDisabledTextColor;

	[Header("Highlight Transform Properties")]
	public float scale;

	public float rotationOffset;

	[Header("Animation Settings")]
	public float animationDuration;
}
