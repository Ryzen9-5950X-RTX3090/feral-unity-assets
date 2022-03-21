using System;
using System.Collections.Generic;

public class MessagePool
{
	private Dictionary<Type, Stack<Message>> _messagePool;

	private Dictionary<Type, int> _poolSizes;

	private int _defaultPoolSize;

	public MessagePool(int inDefaultPoolSize)
	{
	}

	public void SetPoolSize<T>(int inPoolSize) where T : Message
	{
	}

	public void AddMessageToPool<T>(T inMessage) where T : Message
	{
	}

	public T RemoveMessageFromPool<T>() where T : Message
	{
		return null;
	}

	private Stack<Message> CreatePool(Type inType, int inCapacity)
	{
		return null;
	}
}
