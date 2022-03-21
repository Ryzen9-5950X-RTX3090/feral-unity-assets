namespace Rewired.Interfaces
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal interface IControllerAssigner
	{
		bool enabled { get; set; }

		bool CanHandleAssignment(ControllerType controllerType, Controller controller);

		void AssignController(ControllerType controllerType, Controller controller);
	}
}
