using System.Collections.Generic;
using DG.DeInspektor.Attributes;
using UnityEngine;
using UnityEngine.UI;

public class PooledLayoutTest : MonoBehaviour
{
	[SerializeField]
	private PooledLayoutGroup _layoutGroup;

	private List<PooledLayoutElement> _layoutElements;

	private void Start()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	public void Shuffle()
	{
	}
}
