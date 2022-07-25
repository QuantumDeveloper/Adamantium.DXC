namespace Adamantium.DXC;

public static partial class DxcValidatorFlags
{
    [NativeTypeName("const UINT32")]
    public const uint DxcValidatorFlags_Default = 0;

    [NativeTypeName("const UINT32")]
    public const uint DxcValidatorFlags_InPlaceEdit = 1;

    [NativeTypeName("const UINT32")]
    public const uint DxcValidatorFlags_RootSignatureOnly = 2;

    [NativeTypeName("const UINT32")]
    public const uint DxcValidatorFlags_ModuleOnly = 4;

    [NativeTypeName("const UINT32")]
    public const uint DxcValidatorFlags_ValidMask = 0x7;
}
