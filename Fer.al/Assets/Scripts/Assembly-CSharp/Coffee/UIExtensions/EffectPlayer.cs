using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Coffee.UIExtensions
{
	[Serializable]
	public class EffectPlayer
	{
		[Tooltip("Playing.")]
		public bool play;

		[Tooltip("Loop.")]
		public bool loop;

		[Tooltip("Duration.")]
		[Range(0.01f, 10f)]
		public float duration;

		[Tooltip("Delay before looping.")]
		[Range(0f, 10f)]
		public float loopDelay;

		[Tooltip("Update mode")]
		public AnimatorUpdateMode updateMode;

		private static List<Action> s_UpdateActions;

		private float _time;

		private Action<float> _callback;

		public void OnEnable([Optional] Action<float> callback)
		{
		}

		public void OnDisable()
		{
		}

		public void Play([Optional] Action<float> callback)
		{
		}

		public void Stop()
		{
		}

		private void OnWillRenderCanvases()
		{
		}
	}
}
