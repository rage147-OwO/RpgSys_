﻿Shader "Yodokorochan/Billboard"
{
	Properties
	{
		_MainTex("Texture", 2D) = "white" {}
	}
		SubShader
		{
			Tags{ "Queue" = "Transparent" "RenderType" = "Transparent"
					"IgnoreProjector" = "True" "DisableBatching" = "True" }
			Lighting Off
			ZWrite Off
			Blend SrcAlpha OneMinusSrcAlpha

			Pass
			{
				CGPROGRAM
				#pragma vertex vert
				#pragma fragment frag
				#pragma multi_compile_fog

				#include "UnityCG.cginc"

				struct appdata
				{
					float4 vertex : POSITION;
					float2 uv : TEXCOORD0;
				};

				struct v2f
				{
					float2 uv : TEXCOORD0;
					UNITY_FOG_COORDS(1)
					float4 vertex : SV_POSITION;
				};

				sampler2D _MainTex;
				float4 _MainTex_ST;

				v2f vert(appdata v)
				{
					v2f o;

					float3 viewPos = UnityObjectToViewPos(float3(0, 0, 0));
					float3 scaleRotatePos = mul((float3x3)unity_ObjectToWorld, v.vertex);
					viewPos += float3(scaleRotatePos.xy, -scaleRotatePos.z);
					o.vertex = mul(UNITY_MATRIX_P, float4(viewPos, 1));

					o.uv = TRANSFORM_TEX(v.uv, _MainTex);
					UNITY_TRANSFER_FOG(o,o.vertex);
					return o;
				}

				fixed4 frag(v2f i) : SV_Target
				{
					fixed4 col = tex2D(_MainTex, i.uv);
					UNITY_APPLY_FOG(i.fogCoord, col);
					return col;
				}
				ENDCG
			}
		}
		Fallback "Transparent/VertexLit"
}