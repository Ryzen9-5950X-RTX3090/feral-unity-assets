Shader "Animal Jam Mobile/Unlit Multi Shader" {
	Properties {
		_Color ("Color Tint", Vector) = (1,1,1,1)
		_MainTex ("Diffuse Texture", 2D) = "white" {}
		_ManualLightmapTex ("Manual Lightmap", 2D) = "white" {}
		_RimColor ("Rim Light Color", Vector) = (1,1,1,1)
		_RimPower ("Rim Power", Range(0.5, 8)) = 3
		_Cutoff ("Alpha Cutoff", Range(0, 1)) = 0.5
		_UVScrollSpeedX ("Scroll Speed X", Range(-1, 1)) = 0
		_UVScrollSpeedY ("Scroll Speed Y", Range(-1, 1)) = 0
		_UVAnimateFramerate ("Animated UV Framerate", Range(0, 1000)) = 0
		_UVAnimateFrameCount ("Animated UV Frame Count", Range(1, 100)) = 1
		_Cube ("Cube Map", Cube) = "" {}
		_CubeOpacity ("Cube Map Opacity", Range(0, 1)) = 1
		_Cull ("__cull", Float) = 2
		_SrcBlend ("__src", Float) = 1
		_DstBlend ("__dst", Float) = 0
		_ZWrite ("__zw", Float) = 1
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
	//CustomEditor "AJMobile_Unlit_Multi_Shader_GUI"
}