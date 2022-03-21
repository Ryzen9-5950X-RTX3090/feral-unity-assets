namespace StrayTech
{
	public class CameraThirdPersonModifier : CameraStateModifierBase
	{
		public FeralCameraStateSettings stateSettings;

		private FeralCameraStateSettings _feralCameraState;

		public override string Name
		{
			get
			{
				return null;
			}
		}

		protected override void CalculateModification(ICameraState cameraState, float deltaTime)
		{
		}

		public override bool Enable()
		{
			return default(bool);
		}

		public override void Cleanup()
		{
		}
	}
}
