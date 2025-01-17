﻿// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Upgrade NOTE: replaced '_World2Object' with 'unity_WorldToObject'

Shader "harry_t/ornament"
{
	Properties
	{
		[HDR] _ReColor("Main Color", Color) = (1,1,1,1)
		_FresnelBias ("Fresnel Bias", Float) = 0
		_FresnelScale ("Fresnel Scale", Float) = 1
		_FresnelPower ("Fresnel Power", Float) = 1

		[Gamma] _Exposure ("Exposure", Range(0, 8)) = 1.0

		[NoScaleOffset] _Cubemap ("Cubemap (HDR)", Cube) = "grey" {}
	}

	SubShader
	{
		Tags { "Queue" = "Geometry" }
		
		//ZWrite Off

		Pass
		{
			//Blend One One

			CGPROGRAM

			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"

			struct appdata_t
			{
				float4 pos : POSITION;
				half3 normal : NORMAL;
			};

			struct v2f
			{
				float4 pos : SV_POSITION;
				float fresnel : TEXCOORD0;
				float3 refcoord : TEXCOORD1;
				float3 refcoord1 : TEXCOORD2;
			};


			float4 _ReColor;
			fixed _FresnelBias;
			fixed _FresnelScale;
			fixed _FresnelPower;

			samplerCUBE _Cubemap;
			half _Exposure;
			
			v2f vert(appdata_t v)
			{
				v2f o;
				o.pos = UnityObjectToClipPos(v.pos);

				float3 i = normalize(ObjSpaceViewDir(v.pos));
				o.fresnel = _FresnelBias + _FresnelScale * pow(1 + dot(i, v.normal), _FresnelPower);

				float3 worldPos = mul(unity_ObjectToWorld, v.pos).xyz;
				float3 worldViewDir = normalize(UnityWorldSpaceViewDir(worldPos));

				float3 baseReflection = normalize( mul( float4( v.normal, 0.0 ), unity_WorldToObject ).xyz );

				o.refcoord = refract( worldViewDir, baseReflection, 1.002 );
				//o.refcoord1 = baseReflection;
				return o;
			}
			
			fixed4 frag(v2f i) : SV_Target
			{
				half4 tex = texCUBElod( _Cubemap, float4( i.refcoord, 3.0 ) );

            half3 c = DecodeHDR (tex, tex);
            c = c * unity_ColorSpaceDouble.rgb;
            c *= _Exposure;

            return float4(c, 1.0); // _Color * i.fresnel +
			}

			ENDCG
		}
	}
}