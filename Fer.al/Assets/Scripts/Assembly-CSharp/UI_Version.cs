using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UI_Version : MonoBehaviour
{
	[SerializeField]
	private Text _text;

	public static UI_Version instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}
}
