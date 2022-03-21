using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ParadoxNotion
{
	public class HierarchyTree
	{
		public class Element
		{
			private object _reference;

			private Element _parent;

			private List<Element> _children;

			public object reference
			{
				get
				{
					return null;
				}
			}

			public Element parent
			{
				get
				{
					return null;
				}
			}

			public IEnumerable<Element> children
			{
				get
				{
					return null;
				}
			}

			public Element(object reference)
			{
			}

			public Element AddChild(Element child)
			{
				return null;
			}

			public void RemoveChild(Element child)
			{
			}

			public Element GetRoot()
			{
				return null;
			}

			public Element FindReferenceElement(object target)
			{
				return null;
			}

			public T GetFirstParentReferenceOfType<T>()
			{
				return (T)null;
			}

			[IteratorStateMachine(typeof(<GetAllChildrenReferencesOfType>d__15<>))]
			public IEnumerable<T> GetAllChildrenReferencesOfType<T>()
			{
				return null;
			}
		}
	}
}
