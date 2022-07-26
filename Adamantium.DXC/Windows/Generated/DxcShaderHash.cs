namespace Adamantium.DXC.Windows;

/// <include file='DxcShaderHash.xml' path='doc/member[@name="DxcShaderHash"]/*' />
internal unsafe partial struct DxcShaderHash
{
    /// <include file='DxcShaderHash.xml' path='doc/member[@name="DxcShaderHash.Flags"]/*' />
    [NativeTypeName("UINT32")]
    public uint Flags;

    /// <include file='DxcShaderHash.xml' path='doc/member[@name="DxcShaderHash.HashDigest"]/*' />
    [NativeTypeName("BYTE[16]")]
    public fixed byte HashDigest[16];
}
