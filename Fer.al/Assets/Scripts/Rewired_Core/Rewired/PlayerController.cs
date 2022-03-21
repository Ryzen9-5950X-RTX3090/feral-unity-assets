using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	public class PlayerController : IPlayerController
	{
		public class Definition
		{
			public bool enabled;

			public int playerId;

			public ICollection<Element.Definition> elements;
		}

		public static class Factory
		{
			public static PlayerController Create(Definition definition)
			{
				return null;
			}
		}

		public abstract class Element
		{
			[CustomObfuscation]
			internal enum Type
			{
				[CustomObfuscation]
				Button = 0,
				[CustomObfuscation]
				Axis = 1,
				[CustomObfuscation]
				MouseAxis = 2,
				[CustomObfuscation]
				MouseWheelAxis = 3,
				[CustomObfuscation]
				Axis2D = 100,
				[CustomObfuscation]
				MouseAxis2D = 101,
				[CustomObfuscation]
				MouseWheel = 102
			}

			[CustomObfuscation]
			internal enum TypeWithSource
			{
				[CustomObfuscation]
				Button,
				[CustomObfuscation]
				Axis,
				[CustomObfuscation]
				MouseAxis,
				[CustomObfuscation]
				MouseWheelAxis
			}

			[CustomObfuscation]
			internal enum CompoundTypes
			{
				[CustomObfuscation]
				Axis2D = 100,
				[CustomObfuscation]
				MouseAxis2D,
				[CustomObfuscation]
				MouseWheel
			}

			public abstract class Definition
			{
				public bool enabled;

				public string name;

				public Definition()
				{
				}

				internal abstract Element CreateElement(PlayerController P_0);
			}

			internal struct MRSxTLCDMzyoYmLxMtPsgqaOqRM
			{
				public ControllerElementType xeMmavuWtuUUxDhpNKJkwIubLnW;

				public int sTgsnEJuUoRNnuSXfCYtcCJrAEKa;

				public float PLdosENimxvPBjeGrIWuaBaRuLxb;

				public MRSxTLCDMzyoYmLxMtPsgqaOqRM(ControllerElementType elementType, int index, float value)
				{
				}
			}

			[CustomObfuscation]
			internal const bool defaultEnabled = true;

			private readonly PlayerController PdhGYsFKOBEfRexHgTcxFTVoRup;

			private bool mQkcdPwOLpYhTWVqAcbeBDxVqFB;

			private bool RYgMGyqWnNNUOzFUBDIFjvchsBxb;

			private string MYcWDFnyndJzsFpKvFFizAMuaiT;

			private static int[] PXSahuUbHTFSSaAMlGcaxaiteNP;

			private static int[] ZoADVVbThOoxQgYAQShsFjMXvcg;

			protected Player player
			{
				get
				{
					return null;
				}
			}

			protected bool selfAndParentEnabled
			{
				get
				{
					return default(bool);
				}
			}

			internal bool isMemberElement
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public bool enabled
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public string name
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			internal Element(PlayerController parent, Definition definition)
			{
			}

			internal virtual void Update()
			{
			}

			protected virtual void EnabledStateChanged(bool state)
			{
			}

			[CustomObfuscation]
			internal static bool IsTypeWithSource(Type type)
			{
				return default(bool);
			}

			[CustomObfuscation]
			internal static bool IsCompoundType(Type type)
			{
				return default(bool);
			}

			[CustomObfuscation]
			internal static int GetMaxElementCount(Type type)
			{
				return default(int);
			}

			[CustomObfuscation]
			internal static string GetElementTitle(Type type, int index)
			{
				return null;
			}

			[CustomObfuscation]
			internal static Definition CreateDefinition(Type type)
			{
				return null;
			}
		}

		public abstract class ElementWithSource : Element
		{
			public new abstract class Definition : Element.Definition
			{
				private int cjzdzLwOcjfmOCBkTzQRGkafOqG;

				public int actionId
				{
					get
					{
						return default(int);
					}
					set
					{
					}
				}

				public string actionName
				{
					get
					{
						return null;
					}
					set
					{
					}
				}

				public Definition()
				{
				}
			}

			[CustomObfuscation]
			internal const int defaultActionId = -1;

			private int cjzdzLwOcjfmOCBkTzQRGkafOqG;

			public int actionId
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}

			public string actionName
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			internal ElementWithSource(PlayerController parent, Definition definition)
			{
			}
		}

		public class Axis : ElementWithSource
		{
			public new class Definition : ElementWithSource.Definition
			{
				public AxisCoordinateMode coordinateMode;

				public float absoluteToRelativeSensitivity;

				internal override Element CreateElement(PlayerController P_0)
				{
					return null;
				}
			}

			internal const float OrWBWiLwNqnZDmxoCxBcQKPNBnv = 1f;

			[CustomObfuscation]
			internal const AxisCoordinateMode defaultAxisCoordinateMode = AxisCoordinateMode.Absolute;

			private float fiuUYpYCXYmOYvTUhvXpiNXbiMp;

			private AxisCoordinateMode nOaMmPosthuskIXXGxomFGYeVyS;

			private bool JkROLnyJhuWmKzuyOKpacGRAqbA;

			public float absoluteToRelativeSensitivity
			{
				get
				{
					return default(float);
				}
				set
				{
				}
			}

			public AxisCoordinateMode coordinateMode
			{
				get
				{
					return default(AxisCoordinateMode);
				}
			}

			public virtual float value
			{
				get
				{
					return default(float);
				}
			}

			public virtual float valueRaw
			{
				get
				{
					return default(float);
				}
			}

			internal Axis(PlayerController parent, Definition definition)
			{
			}
		}

		public class MouseAxis : Axis
		{
			public new class Definition : Axis.Definition
			{
				internal override Element CreateElement(PlayerController P_0)
				{
					return null;
				}
			}

			[CustomObfuscation]
			internal new const AxisCoordinateMode defaultAxisCoordinateMode = AxisCoordinateMode.Relative;

			[CustomObfuscation]
			internal const float defaultAbsoluteToRelativeSensitivity = 600f;

			public override float value
			{
				get
				{
					return default(float);
				}
			}

			internal MouseAxis(PlayerController parent, Definition definition)
			{
			}
		}

		public abstract class CompoundElement : Element
		{
			public new abstract class Definition : Element.Definition
			{
				public Definition()
				{
				}
			}

			private readonly List<Element> OuMXbYHQWjhHUDiQLPmgBAWEshm;

			internal int elementCount
			{
				get
				{
					return default(int);
				}
			}

			internal CompoundElement(PlayerController parent, Definition definition, Element.Definition[] elementDefinitions)
			{
			}

			internal T UGlMdiDpLKJKtHXHHJEhBRhmhUC<T>(int P_0) where T : Element
			{
				return null;
			}

			internal void VFCQQBTYSyadaLgMiblsyszoGYwh(List<Element> P_0)
			{
			}

			internal void eMLWHPWlVLcjuKEIpkdHeEbTVNGo(Element P_0)
			{
			}
		}

		public class Axis2D : CompoundElement
		{
			public new class Definition : CompoundElement.Definition
			{
				private Axis.Definition VliJwwvajVbJxXXRGIsrSMzSWjL;

				private Axis.Definition NMrHUNqNrEgrMrkSNHUphwfnbeW;

				public Axis.Definition xAxis
				{
					get
					{
						return null;
					}
					set
					{
					}
				}

				public Axis.Definition yAxis
				{
					get
					{
						return null;
					}
					set
					{
					}
				}

				internal override Element CreateElement(PlayerController P_0)
				{
					return null;
				}
			}

			internal const int vMTMrrWvhVGfeqJuWtvMfyPeZcT = 0;

			internal const int rhChdatIyapyNgCVkAAwHxvYlfLJ = 1;

			internal const int jAtgQVtGRPKRJusJhmABUujfutp = 2;

			public Axis xAxis
			{
				get
				{
					return null;
				}
			}

			public Axis yAxis
			{
				get
				{
					return null;
				}
			}

			public virtual Vector2 value
			{
				get
				{
					return default(Vector2);
				}
			}

			public virtual Vector2 valueRaw
			{
				get
				{
					return default(Vector2);
				}
			}

			internal Axis2D(PlayerController parent, Definition definition, Element.Definition[] definitions)
			{
			}

			internal Axis2D(PlayerController parent, Definition definition)
			{
			}
		}

		public sealed class MouseAxis2D : Axis2D
		{
			public new class Definition : Axis2D.Definition
			{
				public new MouseAxis.Definition xAxis
				{
					get
					{
						return null;
					}
					set
					{
					}
				}

				public new MouseAxis.Definition yAxis
				{
					get
					{
						return null;
					}
					set
					{
					}
				}

				internal override Element CreateElement(PlayerController P_0)
				{
					return null;
				}
			}

			public new MouseAxis xAxis
			{
				get
				{
					return null;
				}
			}

			public new MouseAxis yAxis
			{
				get
				{
					return null;
				}
			}

			internal MouseAxis2D(PlayerController parent, Definition definition)
			{
			}
		}

		public sealed class Button : ElementWithSource
		{
			public new class Definition : ElementWithSource.Definition
			{
				internal override Element CreateElement(PlayerController P_0)
				{
					return null;
				}
			}

			public bool value
			{
				get
				{
					return default(bool);
				}
			}

			public bool valuePrev
			{
				get
				{
					return default(bool);
				}
			}

			public bool justPressed
			{
				get
				{
					return default(bool);
				}
			}

			public bool justReleased
			{
				get
				{
					return default(bool);
				}
			}

			internal Button(PlayerController parent, Definition definition)
			{
			}
		}

		public sealed class MouseWheel : Axis2D
		{
			public new class Definition : Axis2D.Definition
			{
				public new MouseWheelAxis.Definition xAxis
				{
					get
					{
						return null;
					}
					set
					{
					}
				}

				public new MouseWheelAxis.Definition yAxis
				{
					get
					{
						return null;
					}
					set
					{
					}
				}

				internal override Element CreateElement(PlayerController P_0)
				{
					return null;
				}
			}

			public new MouseWheelAxis xAxis
			{
				get
				{
					return null;
				}
			}

			public new MouseWheelAxis yAxis
			{
				get
				{
					return null;
				}
			}

			internal MouseWheel(PlayerController parent, Definition definition)
			{
			}
		}

		public sealed class MouseWheelAxis : Axis
		{
			public new class Definition : Axis.Definition
			{
				public float repeatRate;

				internal override Element CreateElement(PlayerController P_0)
				{
					return null;
				}
			}

			[CustomObfuscation]
			internal const float defaultRepeatRate = 4f;

			[CustomObfuscation]
			internal new const AxisCoordinateMode defaultAxisCoordinateMode = AxisCoordinateMode.Relative;

			private const float NnORUHpefPaoPacfdBpHlxUsvoK = 0.01f;

			private float jjHSfqqDeWRWsomgdKSrKqCmiEm;

			private float DyokgikgtwkeAsBaySPCuczefavJ;

			private float FsxdnKHTiBkQzQeLhcyCJCYysFt;

			public float repeatRate
			{
				get
				{
					return default(float);
				}
				set
				{
				}
			}

			public override float value
			{
				get
				{
					return default(float);
				}
			}

			internal MouseWheelAxis(PlayerController parent, Definition definition)
			{
			}

			internal override void Update()
			{
			}

			protected override void EnabledStateChanged(bool state)
			{
			}

			private float JsyZcAsJkGtpxRoNnaQEhifEbJg()
			{
				return default(float);
			}

			private void vMfAexzdpfzhXKkyGdAHmJVnQEr()
			{
			}
		}

		internal readonly int vSShldFHkaZKEuThltrSgFmPfc;

		private bool RYgMGyqWnNNUOzFUBDIFjvchsBxb;

		private int qInCCRhldamcdoUHmMSlSCAIgFUz;

		private readonly AList<Element> OuMXbYHQWjhHUDiQLPmgBAWEshm;

		private readonly AList<Button> fjFgJnkphrVLUzcZIWNBokLGbBNJ;

		private readonly AList<Axis> BqSdtKydcIEkoWCjLJvCiEzwQMG;

		private readonly ReadOnlyCollection<Element> kaRwVFuEhQdielEoQKhHRABCAZN;

		private readonly ReadOnlyCollection<Button> QuTkLcsJfPxBFSRuDfxUaqsjZOb;

		private readonly ReadOnlyCollection<Axis> HgnDXeeXjaKmhoSMUMJYfFspyCX;

		private readonly List<Element.MRSxTLCDMzyoYmLxMtPsgqaOqRM> ioJNlllsMpiwRfzvIjyxgfOErJq;

		private Action<int, bool> QrZsEgKYkcJKmjROaBmabjkSdnR;

		private Action<int, float> dXAglJjpHkbNtdLxhsZnPZwJEng;

		private Action<bool> PqDQtwapHeHHTvTTXUKIVftJHvU;

		public bool enabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int playerId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public IList<Button> buttons
		{
			get
			{
				return null;
			}
		}

		public IList<Axis> axes
		{
			get
			{
				return null;
			}
		}

		public IList<Element> elements
		{
			get
			{
				return null;
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

		public int elementCount
		{
			get
			{
				return default(int);
			}
		}

		internal Player player
		{
			get
			{
				return null;
			}
		}

		public event Action<int, bool> ButtonStateChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<int, float> AxisValueChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<bool> EnabledStateChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal PlayerController(Definition definition)
		{
		}

		~PlayerController()
		{
		}

		public bool GetButton(int index)
		{
			return default(bool);
		}

		public bool GetButtonDown(int index)
		{
			return default(bool);
		}

		public bool GetButtonUp(int index)
		{
			return default(bool);
		}

		public float GetAxis(int index)
		{
			return default(float);
		}

		public float GetAxisRaw(int index)
		{
			return default(float);
		}

		public Element GetElement(int index)
		{
			return null;
		}

		public T GetElement<T>(int index) where T : Element
		{
			return null;
		}

		private void kEjGWRDBbQIibaQyqmAVnMEsGYGe(UpdateLoopType P_0)
		{
		}

		protected virtual bool Update(UpdateLoopType updateLoop)
		{
			return default(bool);
		}

		protected virtual void UpdateFinished()
		{
		}

		protected virtual void ClearVars()
		{
		}

		internal void eMLWHPWlVLcjuKEIpkdHeEbTVNGo(Element P_0)
		{
		}

		private void eMLWHPWlVLcjuKEIpkdHeEbTVNGo(Element P_0, List<Element> P_1, List<Element> P_2, List<Button> P_3, List<Axis> P_4)
		{
		}

		internal static int ewjdgwCsnIlEmBYngRXHuyJOgDwI<T>(IList<T> P_0, Predicate<T> P_1, int P_2) where T : Element
		{
			return default(int);
		}
	}
}
