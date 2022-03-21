Shader "FX/Hologram" {
	Properties {
		_Color ("Color", Vector) = (0,1,1,1)
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_AlphaTexture ("Alpha Mask (R)", 2D) = "white" {}
		_Scale ("Alpha Tiling", Float) = 3
		_ScrollSpeedV ("Alpha scroll Speed", Range(0, 5)) = 1
		_GlowIntensity ("Glow Intensity", Range(0.01, 1)) = 0.5
		_GlitchSpeed ("Glitch Speed", Range(0, 50)) = 50
		_GlitchIntensity ("Glitch Intensity", Range(0, 0.1)) = 0
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		fixed4 _Color;
		struct Input
		{
			float2 uv_MainTex;
		};
		
		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
}