using DG.DeInspektor.Attributes;
using UnityEngine;

public class SmoothLayoutTestController : MonoBehaviour
{
	[SerializeField]
	private WWSmoothLayout _smoothLayout;

	[SerializeField]
	private SmoothLayoutTestElement _testElementA;

	[SerializeField]
	private SmoothLayoutTestElement _testElementB;

	[DeMethodButton(null, 0, new object[] { })]
	public void SpawnElementA()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	public void SpawnElementB()
	{
	}
}
