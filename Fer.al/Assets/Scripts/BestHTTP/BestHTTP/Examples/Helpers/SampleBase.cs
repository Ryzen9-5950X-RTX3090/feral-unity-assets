using UnityEngine;

namespace BestHTTP.Examples.Helpers
{
	public abstract class SampleBase : MonoBehaviour
	{
		[Header("Common Properties")]
		public string Category;

		public string DisplayName;

		[TextArea]
		public string Description;

		public RuntimePlatform[] BannedPlatforms;

		protected SampleRoot sampleSelector;

		protected virtual void Start()
		{
		}
	}
}
