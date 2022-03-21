using UnityEngine;

public class UI_LoginAndRegistrationStage : MonoBehaviour
{
	public static UI_LoginAndRegistrationStage instance;

	[SerializeField]
	private Transform _foxParent;

	[SerializeField]
	private Transform _catParent;

	private GameObject _fox;

	private GameObject _cat;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void SpawnAvatars()
	{
	}

	public void ShowAvatars(bool inShow)
	{
	}

	public void RemoveScene()
	{
	}
}
