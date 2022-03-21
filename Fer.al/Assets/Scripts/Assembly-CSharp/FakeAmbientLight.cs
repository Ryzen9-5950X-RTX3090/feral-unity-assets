using UnityEngine;

[ExecuteInEditMode]
public class FakeAmbientLight : MonoBehaviour
{
	public static FakeAmbientLight instance;

	[SerializeField]
	private Color _ambientColor;

	[SerializeField]
	private Color _shadowColor;

	[SerializeField]
	private Light _lightComponent;

	private Color _lastShadowColor;

	private Color _lastAmbientColor;

	private Light LightComponent
	{
		get
		{
			return null;
		}
	}

	private void SetupLightComponent()
	{
	}

	private void SetupGlobalShadowColor()
	{
	}

	private void SetupGlobalAmbientColor()
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public Color GetFinalAmbientColor()
	{
		return default(Color);
	}
}
