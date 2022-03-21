using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class CameraFader : ManagedBehaviour
	{
		private static CameraFader _current;

		private float alpha;

		private Texture2D _blackTexture;

		private Texture2D blackTexture
		{
			get
			{
				return null;
			}
		}

		public static CameraFader current
		{
			get
			{
				return null;
			}
		}

		public float GetAlpha
		{
			get
			{
				return default(float);
			}
		}

		public void FadeIn(float time)
		{
		}

		public void FadeOut(float time)
		{
		}

		[IteratorStateMachine(typeof(<CoroutineFadeIn>d__11))]
		private IEnumerator CoroutineFadeIn(float time)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<CoroutineFadeOut>d__12))]
		private IEnumerator CoroutineFadeOut(float time)
		{
			return null;
		}

		private void OnGUI()
		{
		}
	}
}
