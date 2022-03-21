namespace Newtonsoft.Json.Linq
{
	public class JsonLoadSettings
	{
		private CommentHandling _commentHandling;

		private LineInfoHandling _lineInfoHandling;

		private DuplicatePropertyNameHandling _duplicatePropertyNameHandling;

		public CommentHandling CommentHandling
		{
			get
			{
				return default(CommentHandling);
			}
		}

		public LineInfoHandling LineInfoHandling
		{
			get
			{
				return default(LineInfoHandling);
			}
		}

		public DuplicatePropertyNameHandling DuplicatePropertyNameHandling
		{
			get
			{
				return default(DuplicatePropertyNameHandling);
			}
		}
	}
}
