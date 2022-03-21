using System;

namespace RewiredConsts
{
	public static class CustomController
	{
		public static class VirtualControls
		{
			public static class Axis
			{
				public const int Movement_Horizontal = 0;

				public const int Movement_Vertical = 1;

				public const int Rotate_Horizontal = 6;

				public const int Rotate_Vertical = 7;

				public const int Zoom = 12;

				public const int Pan_Horizontal = 14;

				public const int Pan_Vertical = 15;
			}

			public static class Button
			{
				public const int A_Button = 3;

				public const int B_Button = 4;

				public const int Rotate_Button = 10;

				public const int Pan_Button = 13;

				public const int X_Button = 16;
			}

			public const int sourceId = 0;

			public const string name = "VirtualControls";

			public static readonly Guid typeGuid;
		}
	}
}
