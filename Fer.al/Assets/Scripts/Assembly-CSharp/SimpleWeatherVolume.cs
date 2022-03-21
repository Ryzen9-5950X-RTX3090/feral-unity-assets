using UnityEngine;

public class SimpleWeatherVolume : ManagedBehaviour
{
	[SerializeField]
	[Header("Volume Enter")]
	private bool _setOnEnter;

	[SerializeField]
	private WeatherState _stateOnEnter;

	private WeatherState _priorEnterWeatherState;

	[SerializeField]
	[Header("Volume Exit")]
	private bool _setOnExit;

	[SerializeField]
	private WeatherState _stateOnExit;

	private WeatherState _priorExitWeatherState;

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
