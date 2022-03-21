using System;

[Serializable]
public class RoomData
{
	public int roomIndex;

	public float brightness;

	public string color;

	public float rotation;

	public string roomName;

	public RoomData(int roomIndex, float brightness, string color, float rotation, string roomName)
	{
	}

	public RoomData Clone()
	{
		return null;
	}
}
