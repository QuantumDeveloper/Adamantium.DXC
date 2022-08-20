namespace Adamantium.DXC.Windows;

/// <include file='DxcDefine.xml' path='doc/member[@name="DxcDefine"]/*' />
internal unsafe partial struct DxcDefine
{
    /// <include file='DxcDefine.xml' path='doc/member[@name="DxcDefine.Name"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* Name;

    /// <include file='DxcDefine.xml' path='doc/member[@name="DxcDefine.Value"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* Value;
}
