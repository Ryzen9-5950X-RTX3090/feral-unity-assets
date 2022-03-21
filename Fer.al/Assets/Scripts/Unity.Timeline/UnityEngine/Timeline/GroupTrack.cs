using System;
using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Serializable]
	[ExcludeFromPreset]
	[TrackClipType(typeof(TrackAsset))]
	[SupportsChildTracks(null, int.MaxValue)]
	public class GroupTrack : TrackAsset
	{
		public override IEnumerable<PlayableBinding> outputs
		{
			get
			{
				return null;
			}
		}

		internal override bool CanCompileClips()
		{
			return default(bool);
		}
	}
}
