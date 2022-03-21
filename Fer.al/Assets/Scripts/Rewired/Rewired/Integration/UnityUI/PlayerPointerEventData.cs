using System.Runtime.CompilerServices;
using Rewired.UI;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
	public class PlayerPointerEventData : PointerEventData
	{
		public int playerId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int inputSourceIndex
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public IMouseInputSource mouseSource
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ITouchInputSource touchSource
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public PointerEventType sourceType
		{
			[CompilerGenerated]
			get
			{
				return default(PointerEventType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int buttonIndex
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public PlayerPointerEventData(EventSystem eventSystem)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
