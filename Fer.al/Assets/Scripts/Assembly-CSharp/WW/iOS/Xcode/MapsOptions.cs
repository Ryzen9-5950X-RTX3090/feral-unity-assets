using System;

namespace WW.iOS.Xcode
{
	[Serializable]
	[Flags]
	public enum MapsOptions
	{
		None = 0,
		Airplane = 1,
		Bike = 2,
		Bus = 4,
		Car = 8,
		Ferry = 0x10,
		Pedestrian = 0x20,
		RideSharing = 0x40,
		StreetCar = 0x80,
		Subway = 0x100,
		Taxi = 0x200,
		Train = 0x400,
		Other = 0x800
	}
}
