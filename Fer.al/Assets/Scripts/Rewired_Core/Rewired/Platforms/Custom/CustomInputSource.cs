using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Rewired.Platforms.Custom
{
	public abstract class CustomInputSource : IDisposable
	{
		public abstract class Controller
		{
			protected bool _isConnected;

			protected string _deviceName;

			protected string _customName;

			public string customName
			{
				get
				{
					return null;
				}
			}

			public bool isConnected
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public string deviceName
			{
				get
				{
					return null;
				}
			}

			protected Controller(string deviceName)
			{
			}

			public void Disconnect()
			{
			}

			public void Connect()
			{
			}

			public abstract void Update();
		}

		public abstract class Joystick : Controller
		{
			private long? ZtpFOHCSvVTitFWYQVgBoObqQOKf;

			private int QqpCMJrIsoyyefcScyWUdCeTfPn;

			private readonly Axis[] BqSdtKydcIEkoWCjLJvCiEzwQMG;

			private readonly Button[] fjFgJnkphrVLUzcZIWNBokLGbBNJ;

			private readonly ReadOnlyCollection<Axis> HgnDXeeXjaKmhoSMUMJYfFspyCX;

			private readonly ReadOnlyCollection<Button> QuTkLcsJfPxBFSRuDfxUaqsjZOb;

			private bool bxYnOIxNeRaXtbzEetOhxJbUfsRC;

			private Rewired.Controller.Extension ZXidIbsBtOYiKGegrccafjeNbYN;

			public long? systemId
			{
				get
				{
					return null;
				}
				protected set
				{
				}
			}

			public int unityId
			{
				get
				{
					return default(int);
				}
				protected set
				{
				}
			}

			public IList<Axis> Axes
			{
				get
				{
					return null;
				}
			}

			public IList<Button> Buttons
			{
				get
				{
					return null;
				}
			}

			public bool supportsVibration
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public Rewired.Controller.Extension extension
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public int buttonCount
			{
				get
				{
					return default(int);
				}
			}

			public int axisCount
			{
				get
				{
					return default(int);
				}
			}

			public Joystick(string deviceName, long? systemId, int unityId, int axisCount, int buttonCount)
			{
			}

			public virtual float GetAxisValue(int index)
			{
				return default(float);
			}

			public virtual bool GetButtonValue(int index)
			{
				return default(bool);
			}
		}

		public abstract class Element
		{
		}

		public sealed class Axis : Element
		{
			public float value;
		}

		public sealed class Button : Element
		{
			public bool value;
		}

		private readonly InputSource RwhgOOAwEVeabPZQdQPAoyiygdKN;

		private readonly List<Joystick> UHVUQTqVgIBHblFxLAYzBdaFQh;

		private readonly ReadOnlyCollection<Joystick> nKwZCYrUQaGoXWnUWmHNrSYftMA;

		private bool bXFQDHjZhBmDzpILPGsxNUpEbbQJ;

		private Action QstPIVnMnMgMpgUsSHpIWRGOoMK;

		private Action vYeVUjeOjLfYPnIvVncGdTvXaQm;

		private bool vEblpmllYIOuQHCXVghuIpihdSG;

		public bool useApproximateMatching
		{
			get
			{
				return default(bool);
			}
			protected set
			{
			}
		}

		internal InputSource inputSource
		{
			get
			{
				return default(InputSource);
			}
		}

		public abstract bool isReady { get; }

		private event Action _JoystickConnectedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private event Action _JoystickDisconnectedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal event Action JoystickConnectedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal event Action JoystickDisconnectedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public CustomInputSource(int inputSource)
		{
		}

		public void AddJoystick(Joystick joystick)
		{
		}

		public void RemoveJoystick(Joystick joystick)
		{
		}

		public IList<Joystick> GetJoysticks()
		{
			return null;
		}

		protected virtual void OnJoystickConnected()
		{
		}

		protected virtual void OnJoystickDisconnected()
		{
		}

		internal Joystick[] sYJxMVfMrKvJHvANnWrwXwBXTZG()
		{
			return null;
		}

		public virtual void Dispose()
		{
		}

		~CustomInputSource()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public abstract void Update();
	}
}
