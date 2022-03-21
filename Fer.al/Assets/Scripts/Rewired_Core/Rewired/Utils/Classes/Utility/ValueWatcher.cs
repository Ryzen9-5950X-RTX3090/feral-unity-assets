using System;

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal abstract class ValueWatcher
	{
		public enum eaksbTCSHXsAACqYSgJAdgGkDQR
		{
			VdITYZTFcrVHpdCrpwWQRGWtOro
		}

		public abstract bool changed { get; }

		public abstract bool autoTriggerEvent { get; set; }

		public abstract bool Update();

		public abstract bool Use();

		public abstract bool TriggerEvent();

		public abstract void AddEventListener(eaksbTCSHXsAACqYSgJAdgGkDQR eventType, Delegate listener);

		public abstract void RemoveEventListener(eaksbTCSHXsAACqYSgJAdgGkDQR eventType, Delegate listener);
	}
}
