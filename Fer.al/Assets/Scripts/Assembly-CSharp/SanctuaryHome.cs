using System.Collections.Generic;
using UnityEngine;

[ManagedBehaviourManager("SanctuaryManager")]
public class SanctuaryHome : ManagedBehaviour
{
	public enum EComponent
	{
		NONE,
		WINDOWS,
		DOORS,
		SHRUBS,
		WALLS,
		ROOF,
		BASE,
		MOLDING
	}

	private Transform _windowsParent;

	private Transform _doorsParent;

	private Transform _shrubsParent;

	private Transform _wallsParent;

	private Transform _roofParent;

	private Transform _moldingParent;

	private Transform _baseParent;

	private List<Transform> _windowLocators;

	private List<Transform> _doorLocators;

	private List<Transform> _shrubLocators;

	private List<Transform> _wallLocators;

	private List<Transform> _roofLocators;

	private List<Transform> _moldingLocators;

	private List<Transform> _baseLocators;

	public override void MStart()
	{
	}

	private void SetLocators()
	{
	}

	public void ChangeLook(EComponent inType, GameObject inPrefab)
	{
	}

	private void CreateLook(EComponent inType, GameObject inPrefab)
	{
	}

	private void DestroyLook(EComponent inType)
	{
	}
}
