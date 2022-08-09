#include "structs.hlsl"

float4x4 wvp;
float4 fillColor;
sampler sampleType;
Texture2D shaderTexture;

float zNear;
float zFar;
float transparency = 1;

//struct PixelInputType
//{
//	float4 position : SV_POSITION;
//	float4 color: COLOR;
//};
//
//struct VertexInputType
//{
//	float4 position : SV_POSITION;
//};
//
//struct TexturedVertexInputType
//{
//	float4 position : SV_POSITION;
//	float4 color: COLOR;
//	float2 texcoord: TEXCOORD;
//};
//
//struct TexturedPixelInputType
//{
//	float4 position : SV_POSITION;
//	float2 texcoord: TEXCOORD;
//};

////////////////////////////////////////////////////////////////////////////////
// Vertex Shader
////////////////////////////////////////////////////////////////////////////////
PixelInputType LightVertexShader(TexturedVertexInputType input)
{
	PixelInputType output;
	output.color = input.color;
	output.position = float4(input.position.xyz, 1);

	return output;
}

TexturedPixelInputType TexturedVertexShader(TexturedVertexInputType input)
{
    TexturedPixelInputType output;
    // Change the position vector to be 4 units for proper matrix calculations.
    output.position = float4(input.position.xyz, 1);
    // Calculate the position of the vertex against the world, view, and projection matrices.
	output.position = mul(output.position, wvp);
	output.texcoord = input.texcoord;

	return output;
}

float4 LightPixelShader(PixelInputType input) : SV_TARGET
{
	float4 result = fillColor;
   //input.color.a = transparency;
   return result;
}

float4 SolidColorPixelShader(TexturedPixelInputType input) : SV_TARGET
{
   float4 result = fillColor;
   return result;
}

float4 TexturedPixelShader(TexturedPixelInputType input) : SV_TARGET
{
   float4 color = shaderTexture.Sample(sampleType, input.texcoord) * fillColor;
   return color;
	/*float4 color = float4(input.texcoord, 0, 1);
   return color;*/
}


technique Render
{
	pass Debug
	{
		Profile = 5.1;
		VertexShader = LightVertexShader;
		PixelShader = LightPixelShader;
	}

	pass SolidColor
	{
		Profile = 5.1;
		VertexShader = TexturedVertexShader;
		PixelShader = SolidColorPixelShader;
	}

	pass Textured
	{
		Profile = 5.1;
		VertexShader = TexturedVertexShader;
		PixelShader = TexturedPixelShader;
	}
}