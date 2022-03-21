using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine.Rendering
{
	public class DebugUI
	{
		public class Container : Widget, IContainer
		{
			public ObservableList<Widget> children
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public override Panel panel
			{
				get
				{
					return null;
				}
				internal set
				{
				}
			}

			public Container()
			{
			}

			public Container(string displayName, ObservableList<Widget> children)
			{
			}

			internal override void GenerateQueryPath()
			{
			}

			protected virtual void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
			{
			}

			protected virtual void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
			{
			}

			public override int GetHashCode()
			{
				return default(int);
			}
		}

		public class Foldout : Container, IValueField
		{
			public bool opened;

			public bool isReadOnly
			{
				get
				{
					return default(bool);
				}
			}

			public string[] columnLabels
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

			public Foldout()
			{
			}

			public Foldout(string displayName, ObservableList<Widget> children, [Optional] string[] columnLabels)
			{
			}

			public bool GetValue()
			{
				return default(bool);
			}

			object IValueField.GetValue()
			{
				return null;
			}

			public void SetValue(object value)
			{
			}

			public object ValidateValue(object value)
			{
				return null;
			}

			public void SetValue(bool value)
			{
			}
		}

		public class HBox : Container
		{
		}

		public class VBox : Container
		{
		}

		public class Table : Container
		{
			public class Row : Foldout
			{
			}

			public bool isReadOnly;

			private bool[] m_Header;

			public bool[] VisibleColumns
			{
				get
				{
					return null;
				}
			}

			public void SetColumnVisibility(int index, bool visible)
			{
			}

			public bool GetColumnVisibility(int index)
			{
				return default(bool);
			}

			protected override void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
			{
			}

			protected override void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
			{
			}
		}

		public abstract class Field<T> : Widget, IValueField
		{
			public Action<Field<T>, T> onValueChanged;

			public Func<T> getter
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

			public Action<T> setter
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

			object IValueField.ValidateValue(object value)
			{
				return null;
			}

			public virtual T ValidateValue(T value)
			{
				return (T)null;
			}

			object IValueField.GetValue()
			{
				return null;
			}

			public T GetValue()
			{
				return (T)null;
			}

			public void SetValue(object value)
			{
			}

			public void SetValue(T value)
			{
			}
		}

		public class BoolField : Field<bool>
		{
		}

		public class HistoryBoolField : BoolField
		{
			public Func<bool>[] historyGetter
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

			public int historyDepth
			{
				get
				{
					return default(int);
				}
			}

			public bool GetHistoryValue(int historyIndex)
			{
				return default(bool);
			}
		}

		public class IntField : Field<int>
		{
			public Func<int> min;

			public Func<int> max;

			public int incStep;

			public int intStepMult;

			public override int ValidateValue(int value)
			{
				return default(int);
			}
		}

		public class UIntField : Field<uint>
		{
			public Func<uint> min;

			public Func<uint> max;

			public uint incStep;

			public uint intStepMult;

			public override uint ValidateValue(uint value)
			{
				return default(uint);
			}
		}

		public class FloatField : Field<float>
		{
			public Func<float> min;

			public Func<float> max;

			public float incStep;

			public float incStepMult;

			public int decimals;

			public override float ValidateValue(float value)
			{
				return default(float);
			}
		}

		public class EnumField : Field<int>
		{
			public GUIContent[] enumNames;

			public int[] enumValues;

			internal int[] quickSeparators;

			internal int[] indexes;

			public Func<int> getIndex
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

			public Action<int> setIndex
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

			public int currentIndex
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}

			public Type autoEnum
			{
				set
				{
				}
			}

			internal void InitQuickSeparators()
			{
			}

			internal void InitIndexes()
			{
			}
		}

		public class HistoryEnumField : EnumField
		{
			public Func<int>[] historyIndexGetter
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

			public int historyDepth
			{
				get
				{
					return default(int);
				}
			}

			public int GetHistoryValue(int historyIndex)
			{
				return default(int);
			}
		}

		public class BitField : Field<Enum>
		{
			internal Type m_EnumType;

			public GUIContent[] enumNames
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int[] enumValues
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public Type enumType
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		public class ColorField : Field<Color>
		{
			public bool hdr;

			public bool showAlpha;

			public bool showPicker;

			public float incStep;

			public float incStepMult;

			public int decimals;

			public override Color ValidateValue(Color value)
			{
				return default(Color);
			}
		}

		public class Vector2Field : Field<Vector2>
		{
			public float incStep;

			public float incStepMult;

			public int decimals;
		}

		public class Vector3Field : Field<Vector3>
		{
			public float incStep;

			public float incStepMult;

			public int decimals;
		}

		public class Vector4Field : Field<Vector4>
		{
			public float incStep;

			public float incStepMult;

			public int decimals;
		}

		public class Panel : IContainer, IComparable<Panel>
		{
			public Flags flags
			{
				[CompilerGenerated]
				get
				{
					return default(Flags);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string displayName
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

			public int groupIndex
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

			public string queryPath
			{
				get
				{
					return null;
				}
			}

			public bool isEditorOnly
			{
				get
				{
					return default(bool);
				}
			}

			public bool isRuntimeOnly
			{
				get
				{
					return default(bool);
				}
			}

			public bool isInactiveInEditor
			{
				get
				{
					return default(bool);
				}
			}

			public bool editorForceUpdate
			{
				get
				{
					return default(bool);
				}
			}

			public ObservableList<Widget> children
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public event Action<Panel> onSetDirty
			{
				[CompilerGenerated]
				add
				{
				}
				[CompilerGenerated]
				remove
				{
				}
			}

			protected virtual void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
			{
			}

			protected virtual void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
			{
			}

			public void SetDirty()
			{
			}

			public override int GetHashCode()
			{
				return default(int);
			}

			int IComparable<Panel>.CompareTo(Panel other)
			{
				return default(int);
			}
		}

		[Flags]
		public enum Flags
		{
			None = 0,
			EditorOnly = 2,
			RuntimeOnly = 4,
			EditorForceUpdate = 8
		}

		public abstract class Widget
		{
			protected Panel m_Panel;

			protected IContainer m_Parent;

			public virtual Panel panel
			{
				get
				{
					return null;
				}
				internal set
				{
				}
			}

			public virtual IContainer parent
			{
				get
				{
					return null;
				}
				internal set
				{
				}
			}

			public Flags flags
			{
				[CompilerGenerated]
				get
				{
					return default(Flags);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string displayName
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

			public string queryPath
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public bool isEditorOnly
			{
				get
				{
					return default(bool);
				}
			}

			public bool isRuntimeOnly
			{
				get
				{
					return default(bool);
				}
			}

			public bool isInactiveInEditor
			{
				get
				{
					return default(bool);
				}
			}

			internal virtual void GenerateQueryPath()
			{
			}

			public override int GetHashCode()
			{
				return default(int);
			}
		}

		public interface IContainer
		{
			ObservableList<Widget> children { get; }

			string displayName { get; set; }

			string queryPath { get; }
		}

		public interface IValueField
		{
			object GetValue();

			void SetValue(object value);

			object ValidateValue(object value);
		}

		public class Button : Widget
		{
			public Action action
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
		}

		public class Value : Widget
		{
			public float refreshRate;

			public Func<object> getter
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

			public object GetValue()
			{
				return null;
			}
		}
	}
}
