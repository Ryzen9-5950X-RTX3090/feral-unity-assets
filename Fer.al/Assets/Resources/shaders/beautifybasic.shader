Shader "Beautify/BeautifyBasic" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_Sharpen ("Sharpen Data", Vector) = (2.5,0.035,0.5,1)
		_ColorBoost ("Color Boost Data", Vector) = (1.1,1.1,0.08,0)
		_CompareTex ("Compare Image (RGB)", 2D) = "black" {}
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