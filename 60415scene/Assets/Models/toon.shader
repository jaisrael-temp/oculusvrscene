Shader "Custom/toon" {
	Properties {
		_Color ("Main Color", COLOR) = (1,1,1,0)
		_SpecColor ("Spec Color", Color) = (1,1,1,1)
		_Emission ("Emmisive Color", Color) = (0,0,0,0)
		_Shininess ("Shininess", Range (0.01, 1)) = 0.7
		_MainTex ("Base (RGB)", 2D) = "white" {}
	}
	SubShader {
		Pass {
			Material {
				Diffuse [_Color]
				Ambient [_Color]
				Shininess [_Shininess]
				Specular [_SpecColor]
				Emission [_Emission]
			}
			Lighting On
			SeparateSpecular On
			SetTexture [_MainTex] {
				Combine texture * primary DOUBLE, texture * primary
			}
		}
		Pass {
			CGPROGRAM

			#pragma vertex vert
			#pragma fragment frag

			#include "UnityCG.cginc"

			struct appdata {
				float4 vertex : POSITION;
				float3 normal : NORMAL;
			};

			struct v2f {
				float4 pos : SV_POSITION;
				fixed4 color : COLOR;
				float2 depth : TEXCOORD0;
			};

			v2f vert (appdata v) {
				v2f o;
				o.pos = mul( UNITY_MATRIX_MVP, v.vertex );
				o.color.xyz = v.normal * 0.5 + 0.5;
				o.color.w = 1.0;
				UNITY_TRANSFER_DEPTH(o.depth);
				return o;
			}

			fixed4 frag (v2f i) : COLOR0 { return i.color; }

			ENDCG
		}
	} 
	FallBack "Diffuse"
}