Shader "Bakery/Standard" {
	Properties {
		_Color ("Color", Vector) = (1,1,1,1)
		_MainTex ("Albedo", 2D) = "white" {}
		_Cutoff ("Alpha Cutoff", Range(0, 1)) = 0.5
		_Glossiness ("Smoothness", Range(0, 1)) = 0.5
		_GlossMapScale ("Smoothness Scale", Range(0, 1)) = 1
		[Enum(Metallic Alpha,0,Albedo Alpha,1)] _SmoothnessTextureChannel ("Smoothness texture channel", Float) = 0
		[Gamma] _Metallic ("Metallic", Range(0, 1)) = 0
		_MetallicGlossMap ("Metallic", 2D) = "white" {}
		[ToggleOff] _SpecularHighlights ("Specular Highlights", Float) = 1
		[ToggleOff] _GlossyReflections ("Glossy Reflections", Float) = 1
		_BumpScale ("Scale", Float) = 1
		_BumpMap ("Normal Map", 2D) = "bump" {}
		_Parallax ("Height Scale", Range(0.005, 0.08)) = 0.02
		_ParallaxMap ("Height Map", 2D) = "black" {}
		_OcclusionStrength ("Strength", Range(0, 1)) = 1
		_OcclusionMap ("Occlusion", 2D) = "white" {}
		_EmissionColor ("Color", Vector) = (0,0,0,1)
		_EmissionMap ("Emission", 2D) = "white" {}
		_DetailMask ("Detail Mask", 2D) = "white" {}
		_DetailAlbedoMap ("Detail Albedo x2", 2D) = "grey" {}
		_DetailNormalMapScale ("Scale", Float) = 1
		_DetailNormalMap ("Normal Map", 2D) = "bump" {}
		[Enum(UV0,0,UV1,1)] _UVSec ("UV Set for secondary textures", Float) = 0
		[HideInInspector] _Mode ("__mode", Float) = 0
		[HideInInspector] _SrcBlend ("__src", Float) = 1
		[HideInInspector] _DstBlend ("__dst", Float) = 0
		[HideInInspector] _ZWrite ("__zw", Float) = 1
		[HideInInspector] _BAKERY_2SIDED ("__2s", Float) = 2
		[Toggle(BAKERY_2SIDEDON)] _BAKERY_2SIDEDON ("Double-sided", Float) = 0
		[Toggle(BAKERY_VERTEXLM)] _BAKERY_VERTEXLM ("Enable vertex LM", Float) = 0
		[Toggle(BAKERY_VERTEXLMDIR)] _BAKERY_VERTEXLMDIR ("Enable directional vertex LM", Float) = 0
		[Toggle(BAKERY_VERTEXLMSH)] _BAKERY_VERTEXLMSH ("Enable SH vertex LM", Float) = 0
		[Toggle(BAKERY_VERTEXLMMASK)] _BAKERY_VERTEXLMMASK ("Enable shadowmask vertex LM", Float) = 0
		[Toggle(BAKERY_SH)] _BAKERY_SH ("Enable SH", Float) = 0
		[Toggle(BAKERY_SHNONLINEAR)] _BAKERY_SHNONLINEAR ("SH non-linear mode", Float) = 1
		[Toggle(BAKERY_RNM)] _BAKERY_RNM ("Enable RNM", Float) = 0
		[Toggle(BAKERY_LMSPEC)] _BAKERY_LMSPEC ("Enable Lightmap Specular", Float) = 0
		[Toggle(BAKERY_BICUBIC)] _BAKERY_BICUBIC ("Enable Bicubic Filter", Float) = 0
		[Toggle(BAKERY_PROBESHNONLINEAR)] _BAKERY_PROBESHNONLINEAR ("Use non-linear SH for light probes", Float) = 0
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
	Fallback "VertexLit"
	//CustomEditor "BakeryShaderGUI"
}