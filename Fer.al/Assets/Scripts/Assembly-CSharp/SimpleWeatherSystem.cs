using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using UnityEngine;

public class SimpleWeatherSystem : ManagedBehaviour
{
	public Renderer skybox;

	public Renderer skyboxBottom;

	public Renderer cloudLayer1;

	public Renderer cloudLayer2;

	public Renderer backgroundObj;

	public Light mainSceneLight;

	[Space]
	[Space(6f)]
	[EnumList(typeof(WeatherState), 0.35f)]
	public List<WeatherData> weatherData;

	private Material _skyboxMaterial;

	private Material _skyboxBottomMaterial;

	private Material _cloudLayer1Material;

	private Material _cloudLayer2Material;

	private Material _backgroundObjMaterial;

	private bool _activeSceneSet;

	public static SimpleWeatherSystem instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public WeatherState currentWeather
	{
		[CompilerGenerated]
		get
		{
			return default(WeatherState);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	public override void MUpdate()
	{
	}

	[IteratorStateMachine(typeof(<WaitForScene>d__24))]
	private IEnumerator WaitForScene(Action inCallback)
	{
		return null;
	}

	public void SetWeatherState(WeatherState inState)
	{
	}

	private void UpdateGameObjectRefs(WeatherData inData, bool inEnabled)
	{
	}

	private void StopCurrentWeatherFx()
	{
	}

	private void UpdateSkyboxColors(SkyboxColorInfo skyboxColors)
	{
	}

	private void SetupSkyboxMaterials()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	private void ChangeWeatherNow()
	{
	}

	private void PickNextWeatherState()
	{
	}

	public void ClearWeatherForTeleport()
	{
	}
}
