Shader "Beautify/BeautifyMobile" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_OverlayTex ("Overlay (RGB)", 2D) = "black" {}
		_DoFTex ("DoF (RGBA)", any) = "black" {}
		_Sharpen ("Sharpen Data", Vector) = (2.5,0.035,0.5,1)
		_ColorBoost ("Color Boost Data", Vector) = (1.1,1.1,0.08,0)
		_Dither ("Dither Data", Vector) = (5,0,0,1)
		_FXColor ("FXColor Color", Vector) = (1,1,1,0)
		_TintColor ("Tint Color Color", Vector) = (1,1,1,0)
		_Vignetting ("Vignetting", Vector) = (0.3,0.3,0.3,0.05)
		_VignettingAspectRatio ("Vignetting Aspect Ratio", Float) = 1
		_VignettingMask ("Mask Texture (A)", 2D) = "white" {}
		_Frame ("Frame Data", Vector) = (50,50,50,0)
		_FrameMask ("Mask Texture (A)", 2D) = "white" {}
		_Outline ("Outline", Vector) = (0,0,0,0.8)
		_Dirt ("Dirt Data", Vector) = (0.5,0.5,0.5,0.5)
		_Bloom ("Bloom Data", Vector) = (0.5,0,0,1)
		_BloomTex ("BloomTex (RGBA)", any) = "black" {}
		_BloomWeights ("Bloom Weights", Vector) = (0.35,0.55,0.7,0.8)
		_BloomWeights2 ("Bloom Weights 2", Vector) = (0.35,0.55,0.7,0.8)
		_ScreenLum ("Luminance Tex (RGBA)", any) = "black" {}
		_CompareParams ("Compare Params", Vector) = (0.7853982,0.001,0,0)
		_AFTint ("Anamorphic Flares Tint", Vector) = (1,1,1,0.5)
		_BokehData ("Bokeh Data", Vector) = (10,1,0,1)
		_DepthTexture ("Depth (RGBA)", 2D) = "black" {}
		_DofExclusionTexture ("DoF Exclusion (R)", 2D) = "white" {}
		_BokehData2 ("Bokeh Data 2", Vector) = (1000,4,0,0)
		_BokehData3 ("Bokeh Data 3", Float) = 1000
		_EyeAdaptation ("Eye Adaptation Data", Vector) = (0.1,2,0.7,1)
		_Purkinje ("Purkinje Data", Vector) = (1,0.15,0,1)
		_BloomDepthTreshold ("Bloom Depth Threshold", Float) = 1
		_SunPos ("SunFlares Sun Screen Position", Vector) = (0.5,0.5,0,0)
		_SunData ("SunFlares Sun Data", Vector) = (0.1,0.05,3.5,0.13)
		_SunCoronaRays1 ("SunFlares Corona Rays 1 Data", Vector) = (0.02,12,0.001,0)
		_SunCoronaRays2 ("SunFlares Corona Rays 2 Data", Vector) = (0.05,12,0.1,0)
		_SunGhosts1 ("SunFlares Ghosts 1 Data", Vector) = (0,0.03,0.6,0.06)
		_SunGhosts2 ("SunFlares Ghosts 2 Data", Vector) = (0,0.1,0.2,0.03)
		_SunHalo ("SunFlares Halo Data", Vector) = (0.22,15.1415,1,1)
		_SunTint ("Sun Flare Tint Color", Vector) = (1,1,1,1)
		_CompareTex ("Compare Image (RGB)", any) = "black" {}
		_BlurScale ("Blur Scale", Float) = 1
		_LUTTex ("Lut Texture (RGB)", 2D) = "white" {}
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
}