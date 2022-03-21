using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_RandomSprite : MonoBehaviour
{
	[SerializeField]
	private WWImage _image;

	[SerializeField]
	private List<Sprite> _sprites;

	private void OnEnable()
	{
	}
}
