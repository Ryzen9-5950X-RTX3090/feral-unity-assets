namespace GestureRecognizer
{
	public class RecognitionResult
	{
		public GesturePattern gesture;

		public Score score;

		public float recognitionTime;

		private static RecognitionResult empty;

		public static RecognitionResult Empty
		{
			get
			{
				return null;
			}
		}
	}
}
