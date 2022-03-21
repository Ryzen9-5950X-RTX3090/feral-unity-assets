using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Cinemachine
{
	[Serializable]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public struct LensSettings
	{
		public static LensSettings Default;

		[Range(1f, 179f)]
		[Tooltip("This is the camera view in vertical degrees. For cinematic people, a 50mm lens on a super-35mm sensor would equal a 19.6 degree FOV")]
		public float FieldOfView;

		[Tooltip("When using an orthographic camera, this defines the half-height, in world coordinates, of the camera view.")]
		public float OrthographicSize;

		[Tooltip("This defines the near region in the renderable range of the camera frustum. Raising this value will stop the game from drawing things near the camera, which can sometimes come in handy.  Larger values will also increase your shadow resolution.")]
		public float NearClipPlane;

		[Tooltip("This defines the far region of the renderable range of the camera frustum. Typically you want to set this value as low as possible without cutting off desired distant objects")]
		public float FarClipPlane;

		[Tooltip("Camera Z roll, or tilt, in degrees.")]
		[Range(-180f, 180f)]
		public float Dutch;

		public Vector2 LensShift;

		public bool Orthographic
		{
			[IsReadOnly]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector2 SensorSize
		{
			[IsReadOnly]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float Aspect
		{
			get
			{
				return default(float);
			}
		}

		public bool IsPhysicalCamera
		{
			[CompilerGenerated]
			[IsReadOnly]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static LensSettings FromCamera(Camera fromCamera)
		{
			return default(LensSettings);
		}

		public void SnapshotCameraReadOnlyProperties(Camera camera)
		{
		}

		public LensSettings(float fov, float orthographicSize, float nearClip, float farClip, float dutch)
		{
		}

		public static LensSettings Lerp(LensSettings lensA, LensSettings lensB, float t)
		{
			return default(LensSettings);
		}

		public void Validate()
		{
		}
	}
}
