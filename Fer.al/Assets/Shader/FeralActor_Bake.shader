Shader "Feral/Actor_Bake" {
	Properties {
		[Header(Base Texture)] [NoScaleOffset] _MainTex ("Texture", 2D) = "white" {}
		[Header(ColorID Texture)] [NoScaleOffset] _ColorIDTex ("Texture", 2D) = "white" {}
		[Editor_HSVMaterialPropertyDrawer] _ColorID1HSV ("1 HSV", Vector) = (0,0.5,0.5,0.5)
		[Editor_HSVMaterialPropertyDrawer] _ColorID2HSV ("2 HSV", Vector) = (0,0.5,0.5,0.5)
		[Editor_HSVMaterialPropertyDrawer] _ColorID3HSV ("3 HSV", Vector) = (0,0.5,0.5,0.5)
		[Editor_HSVMaterialPropertyDrawer] _ColorID4HSV ("4 HSV", Vector) = (0,0.5,0.5,0.5)
		_DecalTex ("Texture", 2D) = "black" {}
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
	Fallback "Diffuse"
}