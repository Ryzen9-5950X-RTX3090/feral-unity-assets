using System.Collections.Generic;
using Rewired.Interfaces;
using UnityEngine;

namespace Rewired.ControllerExtensions
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal class SteamControllerExtension : Controller.Extension
	{
		private class UyxIImwbEVkthHNahEltiXwAzOS : IControllerExtensionSource
		{
			public readonly ISteamControllerInternal TdwgvaqqNXhCxnZXEasmIqaGgzD;

			public UyxIImwbEVkthHNahEltiXwAzOS(ISteamControllerInternal internalController)
			{
			}
		}

		private UyxIImwbEVkthHNahEltiXwAzOS EWvxEcokoAEStdCudJqOMgkHwwyD;

		private Joystick joystick
		{
			get
			{
				return null;
			}
		}

		internal ISteamControllerInternal internalController
		{
			get
			{
				return null;
			}
		}

		internal SteamControllerExtension(ISteamControllerInternal internalController)
		{
		}

		private SteamControllerExtension(SteamControllerExtension source)
		{
		}

		public ulong GetActionSetHandle(string actionSetName)
		{
			return default(ulong);
		}

		public ulong GetAnalogActionHandle(string actionName)
		{
			return default(ulong);
		}

		public ulong GetDigitalActionHandle(string actionName)
		{
			return default(ulong);
		}

		public string GetActionSetName(ulong actionSetHandle)
		{
			return null;
		}

		public string GetAnalogActionName(ulong actionHandle)
		{
			return null;
		}

		public string GetDigitalActionName(ulong actionHandle)
		{
			return null;
		}

		public Vector2 GetAnalogActionValue(string actionName)
		{
			return default(Vector2);
		}

		public Vector2 GetAnalogActionValue(ulong actionHandle)
		{
			return default(Vector2);
		}

		public bool GetDigitalActionValue(string actionName)
		{
			return default(bool);
		}

		public bool GetDigitalActionValue(ulong actionHandle)
		{
			return default(bool);
		}

		public bool SetActiveActionSet(ulong actionSetHandle)
		{
			return default(bool);
		}

		public bool SetActiveActionSet(string actionSetName)
		{
			return default(bool);
		}

		public ulong GetActiveActionSetHandle()
		{
			return default(ulong);
		}

		public string GetActiveActionSetName()
		{
			return null;
		}

		public void ShowBindingPanel()
		{
		}

		public void SetHapticPulse(SteamControllerPadType targePad, float durationSeconds)
		{
		}

		public void SetHapticPulse(SteamControllerPadType targePad, ushort durationMicroSeconds)
		{
		}

		public IList<SteamControllerActionOrigin> GetDigitalActionOrigins(string actionSetName, string actionName)
		{
			return null;
		}

		public IList<SteamControllerActionOrigin> GetDigitalActionOrigins(ulong actionSetHandle, ulong actionHandle)
		{
			return null;
		}

		public IList<SteamControllerActionOrigin> GetAnalogActionOrigins(string actionSetName, string actionName)
		{
			return null;
		}

		public IList<SteamControllerActionOrigin> GetAnalogActionOrigins(ulong actionSetHandle, ulong actionHandle)
		{
			return null;
		}

		internal override void UpdateData(UpdateLoopType updateLoop)
		{
		}

		internal override void SourceUpdated(IControllerExtensionSource source)
		{
		}

		internal override Controller.Extension Clone()
		{
			return null;
		}

		private void ItdhavHGXcUkAhyjaCFbIXENJheh()
		{
		}
	}
}
