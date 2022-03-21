using System.Collections.Generic;

namespace Backtrace.Unity.Runtime.Native
{
	internal interface INativeClient
	{
		void GetAttributes(Dictionary<string, string> data);

		void SetAttribute(string key, string value);

		void UpdateClientTime(float time);

		void Disable();

		void PauseAnrThread(bool state);
	}
}
