using UnityEngine;

[CreateAssetMenu]
public class FeralServerEnvironment : ServerEnvironment
{
	[Header("Feral Services")]
	public string directorHost;

	public string paymentsServiceHost;

	public string serviceApiHost;

	[Header("Chat")]
	public string chatHost;

	public int chatPort;

	[Header("Voice Chat")]
	public string voiceChatHost;

	public int voiceChatPort;

	[Header("Legacy")]
	public string jamNetHost;

	[Header("Debug")]
	[Range(0f, 1f)]
	[Tooltip("Percentage of packets lost over network")]
	public float simulatedPacketLoss;

	[Range(0f, 10f)]
	[Tooltip("Minimum one-way seconds between server responses")]
	public float simulatedMinimumLatency;

	[Range(0f, 10f)]
	[Tooltip("Random second variance in one-way time between server responses")]
	public float simulatedRandomLatency;
}
