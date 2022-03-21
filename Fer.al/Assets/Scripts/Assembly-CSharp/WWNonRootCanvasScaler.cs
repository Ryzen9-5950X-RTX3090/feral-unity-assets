using DG.DeInspektor.Attributes;
using UnityEngine;

[RequireComponent(typeof(Canvas))]
[DeComponentDescription("Scales a full-screen canvas that is the child of a root canvas.")]
public class WWNonRootCanvasScaler : MonoBehaviour
{
	[SerializeField]
	private float _canvasScale;

	private Canvas _canvas;

	private Canvas Canvas
	{
		get
		{
			return null;
		}
	}

	private void Update()
	{
	}
}
