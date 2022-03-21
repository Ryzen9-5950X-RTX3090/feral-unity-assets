using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuildersFollyUI_GoalListItem : MonoBehaviour
{
	public TextMeshProUGUI goalNameAndPoints;

	public WWImage goalImage;

	public WWImage stationIcon;

	public UI_ColorizedIcon halfStar;

	public UI_ColorizedIcon oneStar;

	public UI_ColorizedIcon oneHalfStar;

	public UI_ColorizedIcon twoStar;

	public UI_ColorizedIcon twoHalfStar;

	public UI_ColorizedIcon threeStar;

	internal Vector3 starStartScale;

	internal BuildersFollyLevel_Scriptable.BuildersFollyGoal buildersFollyGoal;

	private int _maxPoints;

	private BuildersFollyUIManager _uiManager;

	internal void Init(BuildersFollyLevel_Scriptable.BuildersFollyGoal inBuildersFollyGoal)
	{
	}

	public void BtnClicked_GoalSelected()
	{
	}

	internal void InitStars(int inPoints)
	{
	}

	internal void SetStars(int inPoints, bool inOn)
	{
	}

	private void DoStar(UI_ColorizedIcon inStar, Color inColor, bool inPulse = false)
	{
	}
}
