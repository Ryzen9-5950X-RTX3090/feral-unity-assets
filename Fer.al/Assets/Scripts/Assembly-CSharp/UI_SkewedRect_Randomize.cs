using System;
using DG.DeInspektor.Attributes;
using ThisOtherThing.UI.Shapes;
using UnityEngine;

public class UI_SkewedRect_Randomize : MonoBehaviour
{
	[SerializeField]
	private Rectangle _rectangle;

	[SerializeField]
	private float _maxDistance;

	[SerializeField]
	private bool _randomizeOnEnable;

	public Action OnRandomized;

	public bool RandomizeOnEnable
	{
		get
		{
			return default(bool);
		}
	}

	[DeMethodButton(null, 0, new object[] { })]
	public void Randomize()
	{
	}

	private void OnEnable()
	{
	}

	private void Reset()
	{
	}
}
