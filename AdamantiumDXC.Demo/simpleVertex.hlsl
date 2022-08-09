//
matrix wvp;

struct VertexInputType
{
   float4 position : SV_POSITION;
   float4 color: COLOR;
};

struct PixelInputType
{
   float4 position : SV_POSITION;
   float4 color: COLOR;
};

////////////////////////////////////////////////////////////////////////////////
// Vertex Shader
////////////////////////////////////////////////////////////////////////////////
PixelInputType LightVertexShader(VertexInputType input)
{
   PixelInputType output;
   output.color = float4(0, 0, 0, 0);
   output.position = float4(0, 0, 0, 0);


   // Change the position vector to be 4 units for proper matrix calculations.
   input.position.w = 1.0f;

   // Calculate the position of the vertex against the world, view, and projection matrices.

   output.position = mul(input.position, wvp);
   
   output.color = input.color;

   return output;
}