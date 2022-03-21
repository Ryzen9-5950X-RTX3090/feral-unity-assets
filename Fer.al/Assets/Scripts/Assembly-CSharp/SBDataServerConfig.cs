using UnityEngine;

public class SBDataServerConfig : ScriptableObject
{
	[SerializeField]
	private int _projectID;

	public int ProjectID
	{
		get
		{
			return default(int);
		}
	}

	public void Init(int inProjectiD)
	{
	}
}
