using System;
using System.Collections.Generic;
using Gaia.FullSerializer.Internal.DirectConverters;

namespace Gaia.FullSerializer
{
	public class fsConverterRegistrar
	{
		public static AnimationCurve_DirectConverter Register_AnimationCurve_DirectConverter;

		public static Bounds_DirectConverter Register_Bounds_DirectConverter;

		public static GameObject_DirectConverter Register_GameObject_DirectConverter;

		public static Gradient_DirectConverter Register_Gradient_DirectConverter;

		public static Keyframe_DirectConverter Register_Keyframe_DirectConverter;

		public static LayerMask_DirectConverter Register_LayerMask_DirectConverter;

		public static Rect_DirectConverter Register_Rect_DirectConverter;

		public static Texture2D_DirectConverter Register_Texture2D_DirectConverter;

		public static List<Type> Converters;

		static fsConverterRegistrar()
		{
		}
	}
}
