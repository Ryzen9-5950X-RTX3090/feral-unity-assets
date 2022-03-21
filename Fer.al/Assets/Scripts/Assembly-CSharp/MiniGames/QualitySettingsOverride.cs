using System;
using UnityEngine;

namespace MiniGames
{
	public class QualitySettingsOverride : MonoBehaviour
	{
		[Serializable]
		public class OverrideValues
		{
			public float shadowDistance;

			public ShadowProjection shadowProjectionOverride;
		}

		public OverrideValues overrides;

		private OverrideValues _savedValues;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
