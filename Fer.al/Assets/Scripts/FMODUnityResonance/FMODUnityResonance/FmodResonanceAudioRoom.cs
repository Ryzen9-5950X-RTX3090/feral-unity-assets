using UnityEngine;

namespace FMODUnityResonance
{
	[AddComponentMenu("ResonanceAudio/FmodResonanceAudioRoom")]
	public class FmodResonanceAudioRoom : MonoBehaviour
	{
		public enum SurfaceMaterial
		{
			Transparent,
			AcousticCeilingTiles,
			BrickBare,
			BrickPainted,
			ConcreteBlockCoarse,
			ConcreteBlockPainted,
			CurtainHeavy,
			FiberglassInsulation,
			GlassThin,
			GlassThick,
			Grass,
			LinoleumOnConcrete,
			Marble,
			Metal,
			ParquetOnConcrete,
			PlasterRough,
			PlasterSmooth,
			PlywoodPanel,
			PolishedConcreteOrTile,
			Sheetrock,
			WaterOrIceSurface,
			WoodCeiling,
			WoodPanel
		}

		public SurfaceMaterial leftWall;

		public SurfaceMaterial rightWall;

		public SurfaceMaterial floor;

		public SurfaceMaterial ceiling;

		public SurfaceMaterial backWall;

		public SurfaceMaterial frontWall;

		public float reflectivity;

		public float reverbGainDb;

		public float reverbBrightness;

		public float reverbTime;

		public Vector3 size;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
