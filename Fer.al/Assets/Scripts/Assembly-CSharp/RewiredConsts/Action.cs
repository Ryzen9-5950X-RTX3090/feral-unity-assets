using Rewired.Dev;

namespace RewiredConsts
{
	public static class Action
	{
		public static class Default
		{
		}

		public static class Gameplay
		{
			[ActionIdFieldInfo]
			public const int OpenMainMenu = 11;

			[ActionIdFieldInfo]
			public const int Rotate_Horizontal = 8;

			[ActionIdFieldInfo]
			public const int Rotate_Vertical = 9;

			[ActionIdFieldInfo]
			public const int Rotate_Button = 10;

			[ActionIdFieldInfo]
			public const int GameplayBack = 15;

			[ActionIdFieldInfo]
			public const int ExpandMinimap = 21;

			[ActionIdFieldInfo]
			public const int FocusChat = 22;

			[ActionIdFieldInfo]
			public const int A_Button = 2;

			[ActionIdFieldInfo]
			public const int B_Button = 3;

			[ActionIdFieldInfo]
			public const int Interact = 24;

			[ActionIdFieldInfo]
			public const int OpenQuests = 25;

			[ActionIdFieldInfo]
			public const int Sleep = 28;

			[ActionIdFieldInfo]
			public const int OpenSettings = 32;

			[ActionIdFieldInfo]
			public const int Customizer = 33;

			[ActionIdFieldInfo]
			public const int ToggleChat = 34;

			[ActionIdFieldInfo]
			public const int ToggleSocial = 36;

			[ActionIdFieldInfo]
			public const int OpenInventory = 38;

			[ActionIdFieldInfo]
			public const int ToggleEmoteWheel = 39;

			[ActionIdFieldInfo]
			public const int ToggleSelfieMode = 44;

			[ActionIdFieldInfo]
			public const int Pan_Horizontal = 47;

			[ActionIdFieldInfo]
			public const int Pan_Vertical = 48;

			[ActionIdFieldInfo]
			public const int Pan = 49;
		}

		public static class UI
		{
			[ActionIdFieldInfo]
			public const int UICancel = 7;

			[ActionIdFieldInfo]
			public const int UISubmit = 6;

			[ActionIdFieldInfo]
			public const int UIVertical = 5;

			[ActionIdFieldInfo]
			public const int UIHorizontal = 4;

			[ActionIdFieldInfo]
			public const int UIBack = 12;

			[ActionIdFieldInfo]
			public const int UITabRight = 17;

			[ActionIdFieldInfo]
			public const int UITabLeft = 18;

			[ActionIdFieldInfo]
			public const int UIOpenQuickTravel = 23;

			[ActionIdFieldInfo]
			public const int UICloseQuests = 26;

			[ActionIdFieldInfo]
			public const int UIInspirationCombine = 27;

			[ActionIdFieldInfo]
			public const int UICloseMinimap = 37;

			[ActionIdFieldInfo]
			public const int UIToggleChat = 43;
		}

		public static class PlayerMovement
		{
			[ActionIdFieldInfo]
			public const int Move_Horizontal = 0;

			[ActionIdFieldInfo]
			public const int Move_Vertical = 1;

			[ActionIdFieldInfo]
			public const int Jump = 29;

			[ActionIdFieldInfo]
			public const int ToggleAutoRun = 52;

			[ActionIdFieldInfo]
			public const int ToggleRunByDefault = 41;

			[ActionIdFieldInfo]
			public const int Walk = 42;

			[ActionIdFieldInfo]
			public const int CameraZoom = 46;

			[ActionIdFieldInfo]
			public const int Glide = 53;
		}

		public static class TobogganRun
		{
			[ActionIdFieldInfo]
			public const int Move_Sled_Vertical = 50;

			[ActionIdFieldInfo]
			public const int Move_Sled_Horizontal = 51;
		}
	}
}
