using UnityEngine;
using UnityEngine.UI;

public class EmoteTemp : MonoBehaviour
{
	public WWImage emoteIcon;

	public Transform tween;

	public GameObject groupTempThinking;

	private float _tweenTime;

	private float _cachedTweenDefaultScale;

	public void Setup(ActorBase inActorBase)
	{
	}

	public void SetEmote(string inImageDefID, float inTime = -1f)
	{
	}

	public void UnEmote()
	{
	}

	private void ScaleUp(bool inValue)
	{
	}
}
