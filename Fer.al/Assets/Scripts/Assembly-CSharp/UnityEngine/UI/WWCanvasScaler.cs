namespace UnityEngine.UI
{
	[ExecuteAlways]
	[RequireComponent(typeof(Canvas))]
	[AddComponentMenu("Layout/WW Canvas Scaler", 101)]
	public class WWCanvasScaler : CanvasScaler
	{
		[SerializeField]
		private float _targetDPIMultiplier;

		[SerializeField]
		[Tooltip("set negative to use Screen.dpi")]
		private float _simulatedDPI;

		[SerializeField]
		private bool _scaleWithScreenSizeInEditor;

		[SerializeField]
		[Tooltip("Leave true if needing to interact with child UI elements while recording")]
		private bool _screenScaleOnly;

		private Canvas _localCanvas;

		private const float kLogBase = 2f;

		protected override void Start()
		{
		}

		protected override void HandleConstantPhysicalSize()
		{
		}

		protected override void HandleScaleWithScreenSize()
		{
		}
	}
}
