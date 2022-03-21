using UnityEngine.UI;

namespace GestureRecognizer
{
	public class GesturePatternDraw : UILineRenderer
	{
		public GesturePattern pattern;

		public float endingSize;

		private void OnValidate()
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		public void DrawPattern()
		{
		}
	}
}
