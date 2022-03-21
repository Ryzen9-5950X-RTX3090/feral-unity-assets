using UnityEngine;

public class SpawnTexture : ManagedBehaviour
{
	[RootSelector("ImageDefId", "ImageChartData", false, false)]
	public string imageDefId;

	[SerializeField]
	private string _resourcePath;

	[SerializeField]
	private Vector2 _textureSize;

	[SerializeField]
	private Vector3 _offset;

	[SerializeField]
	private Vector3 _localScale;

	private Vector3 _tempSpawnPosition;

	public GameObject resource
	{
		get
		{
			return null;
		}
	}

	public override void MStart()
	{
	}
}
