#ifndef __HSV_UTILS__
#define __HSV_UTILS__

#include "UnityCG.cginc"

float _H;
float _S;
float _V;
sampler2D _HSVMask;

fixed3 RGBConvertToHSV(fixed3 rgb)
{
	fixed R = rgb.x, G = rgb.y, B = rgb.z;
	fixed3 hsv;
	fixed max1 = max(R, max(G, B));
	fixed min1 = min(R, min(G, B));
	if (R == max1)
	{
		hsv.x = (G - B) / (max1 - min1);
	}
	if (G == max1)
	{
		hsv.x = 2 + (B - R) / (max1 - min1);
	}
	if (B == max1)
	{
		hsv.x = 4 + (R - G) / (max1 - min1);
	}
	hsv.x = hsv.x * 60.0;
	if (hsv.x < 0)
		hsv.x = hsv.x + 360;
	hsv.z = max1;
	hsv.y = (max1 - min1) / max1;
	return hsv;
}
fixed3 HSVConvertToRGB(fixed3 hsv)
{
	fixed R, G, B;
	//float3 rgb;
	if (hsv.y == 0)
	{
		R = G = B = hsv.z;
	}
	else
	{
		hsv.x = hsv.x / 60.0;
		int i = (int)hsv.x;
		fixed f = hsv.x - (float)i;
		fixed a = hsv.z * (1 - hsv.y);
		fixed b = hsv.z * (1 - hsv.y * f);
		fixed c = hsv.z * (1 - hsv.y * (1 - f));
		if (i == 0) {
			R = hsv.z;
			G = c;
			B = a;
		}
		else if (i == 1) {
			R = b;
			G = hsv.z;
			B = a;
		}
		else if (i == 2) {
			R = a;
			G = hsv.z;
			B = c;
		}
		else if (i == 3) {
			R = a;
			G = b;
			B = hsv.z;
		}
		else if (i == 4) {
			R = c;
			G = a;
			B = hsv.z;
		}
		else {
			R = hsv.z;
			G = a;
			B = b;
		}


	}
	return fixed3(R, G, B);
}
half3 HSVShading(half3 c, float h, float s, float v)
{
	fixed3 colorHSV;
	colorHSV.xyz = RGBConvertToHSV(c.xyz);
	colorHSV.x += h;
	colorHSV.x = (uint)colorHSV.x % 360;

	colorHSV.y *= s;
	colorHSV.z *= v;

	c.xyz = HSVConvertToRGB(colorHSV.xyz);

	return c;
}

half3 HSV(half3 c, half2 uv)
{
	half4 mask = tex2D(_HSVMask, uv);
	half3 r = HSVShading(c, _H, _S, _V);
	return r * mask.r + c * (1 - mask.r);
}

#endif