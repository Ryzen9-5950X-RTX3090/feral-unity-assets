namespace UnityEngine.UI.Extensions
{
	[ExecuteAlways]
	[AddComponentMenu("UI/Extensions/Primitives/UI Callout Tail")]
	public class UICalloutTail : UIPrimitiveBase
	{
		public Transform target;

		[SerializeField]
		private Vector2 _targetPosition;

		[SerializeField]
		private float _maxLength;

		private void Update()
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}
	}
}
