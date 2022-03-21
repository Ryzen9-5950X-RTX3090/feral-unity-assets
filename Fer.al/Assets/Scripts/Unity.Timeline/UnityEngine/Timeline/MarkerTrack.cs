using System;
using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Serializable]
	[HideInMenu]
	[ExcludeFromPreset]
	[TrackBindingType(typeof(GameObject))]
	public class MarkerTrack : TrackAsset
	{
		public override IEnumerable<PlayableBinding> outputs
		{
			get
			{
				return null;
			}
		}
	}
}
