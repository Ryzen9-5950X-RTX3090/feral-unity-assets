using System.Collections.Generic;
using Unitilities.Tuples;
using UnityEngine;

public abstract class UI_ThemeApplier : MonoBehaviour, ISerializationCallbackReceiver
{
	[SerializeField]
	protected string _dataId;

	[SerializeField]
	protected bool _editMode;

	public abstract List<StringTuple> GetDataOptions();

	public void OnAfterDeserialize()
	{
	}

	public void OnBeforeSerialize()
	{
	}

	public abstract bool AddThemeDataFromTarget(string inName);

	public abstract bool UpdateThemeDataFromTarget(string inId, string inName);

	protected abstract void ApplyTheme();

	protected abstract void DereferenceAssets();

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnThemeChanged(ThemeChangedMessage inMessage)
	{
	}
}
