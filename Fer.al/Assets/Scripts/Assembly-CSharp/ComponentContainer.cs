using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class ComponentContainer
{
	private Dictionary<Type, List<ComponentBase>> _components;

	private bool _isEnumerating;

	public IEnumerable<ComponentBase> All
	{
		[IteratorStateMachine(typeof(<get_All>d__3))]
		get
		{
			return null;
		}
	}

	private List<ComponentBase> GetComponentListForType<T>()
	{
		return null;
	}

	private List<ComponentBase> GetComponentListForType(Type inType)
	{
		return null;
	}

	public ComponentBase AddComponent(Type ofType)
	{
		return null;
	}

	public ComponentBase GetComponent(Type ofType)
	{
		return null;
	}

	public T AddComponent<T>() where T : ComponentBase
	{
		return null;
	}

	public T AddComponent<T>(T inComponent) where T : ComponentBase
	{
		return null;
	}

	public T AddComponentByTypeof<T>(T inComponent) where T : ComponentBase
	{
		return null;
	}

	public T GetComponent<T>() where T : ComponentBase
	{
		return null;
	}

	public bool HasComponent<T>() where T : ComponentBase
	{
		return default(bool);
	}

	public void RemoveComponent<T>() where T : ComponentBase
	{
	}

	public void Foreach<T>(Action<T> a) where T : class
	{
	}

	[IteratorStateMachine(typeof(<AllOf>d__15<>))]
	public IEnumerator<T> AllOf<T>() where T : class
	{
		return null;
	}
}
