using UnityEngine;

[CreateAssetMenu]
public class AnimationEventData : ScriptableObject
{
	[SerializeField]
	private string _animationEventID;

	[SerializeField]
	private float _floatData;

	[SerializeField]
	private int _intData;

	[SerializeField]
	private string _stringData;

	[SerializeField]
	private Object _objectData;

	public string AnimationEventID
	{
		get
		{
			return null;
		}
	}

	public float FloatData
	{
		get
		{
			return default(float);
		}
	}

	public int IntData
	{
		get
		{
			return default(int);
		}
	}

	public string StringData
	{
		get
		{
			return null;
		}
	}

	public Object ObjectData
	{
		get
		{
			return null;
		}
	}
}
