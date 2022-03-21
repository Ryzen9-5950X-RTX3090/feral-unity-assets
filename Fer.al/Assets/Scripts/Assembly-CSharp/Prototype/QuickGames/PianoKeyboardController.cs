using System.Collections.Generic;
using UnityEngine;

namespace Prototype.QuickGames
{
	public class PianoKeyboardController : MonoBehaviour
	{
		public List<PianoKeyController> keyControllers;

		public NoteTriggerController noteTrigger_Excellent;

		public NoteTriggerController noteTrigger_Good;

		public NoteTriggerController noteTrigger_Fair;

		public NoteTriggerController noteTrigger_Bad;

		public NoteTriggerController noteTrigger_Delete;

		private PianoController parentController;

		private List<bool> keyStates;

		public void SetUp(PianoController pianoController)
		{
		}

		public void UpdateInput()
		{
		}

		public void NoteTriggerEntered(int level, GameObject beatObject)
		{
		}
	}
}
