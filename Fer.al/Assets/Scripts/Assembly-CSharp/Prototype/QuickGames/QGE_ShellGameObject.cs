using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames
{
	public class QGE_ShellGameObject : ManagedBehaviour
	{
		public GameObject obj_show;

		public GameObject obj_hide;

		public Button button;

		public float hideTime;

		public float hideScaleBump;

		public bool HasBall
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 NewPos
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 OldPos
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 MidPos
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public QGE_ShellGame Game
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

		public RawImage Image2fade
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

		public override void UAwake()
		{
		}

		[IteratorStateMachine(typeof(<ShowObject>d__30))]
		public IEnumerator ShowObject(bool inShowFront)
		{
			return null;
		}

		public void Shell_ButtonClick()
		{
		}
	}
}
