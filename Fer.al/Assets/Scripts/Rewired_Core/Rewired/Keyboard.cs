using System;
using System.Collections.Generic;
using Rewired.Interfaces;
using UnityEngine;

namespace Rewired
{
	public sealed class Keyboard : ControllerWithMap
	{
		private static Keyboard singleton;

		private readonly IUnifiedKeyboardSource _source;

		private ModifierKeyFlags currentModfierKeyFlags;

		private ModifierKeyFlags currentModfierKeyFlagsDouble;

		private Func<KeyboardKeyCode, int> _getKeyIndexDelegate;

		private readonly int[] keyCodeToKeyIndex;

		private static KeyboardKeyCode[] __keyIndexToKeyboardKeyCode;

		private readonly int maxKeyValue;

		private static Guid s_deviceInstanceGuid;

		private static KeyboardKeyCode[] keyIndexToKeyboardKeyCode
		{
			get
			{
				return null;
			}
		}

		public override Guid deviceInstanceGuid
		{
			get
			{
				return default(Guid);
			}
		}

		internal Keyboard(string name, IUnifiedKeyboardSource source)
		{
		}

		private Keyboard(int controllerId, InputSource inputSource, string name, string hardwareIdentifier, HardwareControllerMap_Game hardwareMap, int buttonCount, ControllerDataUpdater dataUpdater)
		{
		}

		public bool GetKey(KeyCode keyCode)
		{
			return default(bool);
		}

		public bool GetKeyDown(KeyCode keyCode)
		{
			return default(bool);
		}

		public bool GetKeyUp(KeyCode keyCode)
		{
			return default(bool);
		}

		public bool GetKeyDoublePressHold(KeyCode keyCode, float speed)
		{
			return default(bool);
		}

		public bool GetKeyDoublePressHold(KeyCode keyCode)
		{
			return default(bool);
		}

		public bool GetKeyDoublePressDown(KeyCode keyCode, float speed)
		{
			return default(bool);
		}

		public bool GetKeyDoublePressDown(KeyCode keyCode)
		{
			return default(bool);
		}

		public bool GetKeyPrev(KeyCode keyCode)
		{
			return default(bool);
		}

		public float GetKeyTimePressed(KeyCode keyCode)
		{
			return default(float);
		}

		public float GetKeyTimeUnpressed(KeyCode keyCode)
		{
			return default(float);
		}

		public bool GetModifierKey(ModifierKey key)
		{
			return default(bool);
		}

		public bool GetModifierKeyDown(ModifierKey key)
		{
			return default(bool);
		}

		public bool GetModifierKeyUp(ModifierKey key)
		{
			return default(bool);
		}

		public bool GetModifierKeyPrev(ModifierKey key)
		{
			return default(bool);
		}

		public float GetModifierKeyTimePressed(ModifierKey key)
		{
			return default(float);
		}

		public float GetModifierKeyTimeUnpressed(ModifierKey key)
		{
			return default(float);
		}

		public KeyCode GetKeyCodeByButtonIndex(int buttonIndex)
		{
			return default(KeyCode);
		}

		public KeyCode GetKeyCodeById(int elementIdentifierId)
		{
			return default(KeyCode);
		}

		public int GetButtonIndexByKeyCode(KeyCode keyCode)
		{
			return default(int);
		}

		public ControllerElementIdentifier GetElementIdentifierByKeyCode(KeyCode keyCode)
		{
			return null;
		}

		public ControllerPollingInfo PollForFirstKey()
		{
			return default(ControllerPollingInfo);
		}

		public IEnumerable<ControllerPollingInfo> PollForAllKeys()
		{
			return null;
		}

		public IEnumerable<ControllerPollingInfo> PollForAllKeysDown()
		{
			return null;
		}

		public ControllerPollingInfo PollForFirstKeyDown()
		{
			return default(ControllerPollingInfo);
		}

		public override ControllerPollingInfo PollForFirstButton()
		{
			return default(ControllerPollingInfo);
		}

		public override ControllerPollingInfo PollForFirstButtonDown()
		{
			return default(ControllerPollingInfo);
		}

		public override IEnumerable<ControllerPollingInfo> PollForAllButtons()
		{
			return null;
		}

		public override IEnumerable<ControllerPollingInfo> PollForAllButtonsDown()
		{
			return null;
		}

		public static bool IsModifierKey(KeyCode key)
		{
			return default(bool);
		}

		internal static bool IsModifierKey(KeyboardKeyCode key)
		{
			return default(bool);
		}

		public static ModifierKey KeyCodeToModifierKey(KeyCode key)
		{
			return default(ModifierKey);
		}

		public static ModifierKeyFlags KeyCodeToModifierKeyFlags(KeyCode key)
		{
			return default(ModifierKeyFlags);
		}

		public static bool ModifierKeyFlagsContain(ModifierKeyFlags flags, ModifierKey key)
		{
			return default(bool);
		}

		public static bool ModifierKeyFlagsContain(ModifierKeyFlags flags, KeyCode key)
		{
			return default(bool);
		}

		public static ModifierKey ModifierKeyFlagsToModifierKey(ModifierKeyFlags flags)
		{
			return default(ModifierKey);
		}

		public static KeyCode ModifierKeyFlagsToKeyCode(ModifierKeyFlags flags)
		{
			return default(KeyCode);
		}

		public static ModifierKeyFlags ModifierKeyToModifierKeyFlags(ModifierKey key)
		{
			return default(ModifierKeyFlags);
		}

		public static string GetKeyName(KeyCode key)
		{
			return null;
		}

		public static string GetKeyName(KeyCode key, ModifierKeyFlags flags)
		{
			return null;
		}

		public static string ModifierKeyFlagsToString(ModifierKeyFlags flags, bool abbreviate)
		{
			return null;
		}

		public static string ModifierKeyFlagsToString(ModifierKeyFlags flags)
		{
			return null;
		}

		internal static KeyboardKeyCode KeyCodeToKeyboardKeyCode(KeyCode keyCode)
		{
			return default(KeyboardKeyCode);
		}

		internal static KeyCode KeyboardKeyCodeToKeyCode(KeyboardKeyCode keyCode)
		{
			return default(KeyCode);
		}

		internal static ModifierKeyFlags ConvertModifierKeyFlagsSingleToDouble(ModifierKeyFlags flags)
		{
			return default(ModifierKeyFlags);
		}

		internal static int GetDoubledModifierKeyCount(ModifierKeyFlags flags)
		{
			return default(int);
		}

		[CustomObfuscation]
		internal static KeyboardKeyCode GetKeyboardKeyCodeByButtonIndex(int buttonIndex)
		{
			return default(KeyboardKeyCode);
		}

		internal static int GetElementIdentifierIdByKeyCode(KeyboardKeyCode keyCode)
		{
			return default(int);
		}

		internal static void FixKeyboardAssignments(ref int elementIdentifierId, ref KeyCode keyCode)
		{
		}

		internal override void UpdateData(UpdateLoopType updateLoop)
		{
		}

		internal void UpdateData_AndroidKeyboardDisabled(UpdateLoopType updateLoop)
		{
		}

		internal bool GetKey(KeyboardKeyCode keyCode)
		{
			return default(bool);
		}

		internal bool GetKeyPrev(KeyboardKeyCode keyCode)
		{
			return default(bool);
		}

		internal bool AllRequiredKeysPressed(KeyboardKeyCode keyCode, ModifierKeyFlags doubledFlags)
		{
			return default(bool);
		}

		internal bool IsAnyComponentKeyActive(KeyboardKeyCode keyCode, ModifierKeyFlags doubledFlags)
		{
			return default(bool);
		}

		[CustomObfuscation]
		internal int GetButtonIndex(KeyboardKeyCode keyCode)
		{
			return default(int);
		}

		[CustomObfuscation]
		internal override void BakeMap(ControllerMap controllerMap)
		{
		}

		[CustomObfuscation]
		internal override void BakeActionElementMap(ControllerMap controllerMap, ActionElementMap map)
		{
		}

		internal override void Clear()
		{
		}

		private bool GetControlButtons(out Button leftButton, out Button rightButton, ModifierKey key)
		{
			return default(bool);
		}

		private void UpdateCurrentModifierKeyFlags()
		{
		}
	}
}
