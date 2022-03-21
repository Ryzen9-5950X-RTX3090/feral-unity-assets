using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Audio/Stop")]
	public class StopFeralAudioNode : ActionTask<GameObject>
	{
		public BBParameter<AudioScriptableObject> _audioScriptableObject;

		public BBParameter<FeralAudioEmitter> _audioEmitter;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnExecute()
		{
		}
	}
}
