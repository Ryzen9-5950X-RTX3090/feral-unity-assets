using DG.DeInspektor.Attributes;
using UnityEngine.UI;

public class LazyLayoutTest : MonoBehaviour
{
	public LazyLayoutGroup layout;

	public ScrollRect scrollRect;

	private VisibilityCalculator _visibilityCalculator;

	private void Start()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	public void Shuffle()
	{
	}
}
