namespace Adamantium.DXC.Unix;

/// <include file='DxcDefine.xml' path='doc/member[@name="DxcDefine"]/*' />
internal unsafe partial struct DxcDefine
{
    /// <include file='DxcDefine.xml' path='doc/member[@name="DxcDefine.Name"]/*' />
    [NativeTypeName("LPCWSTR")]
    public uint* Name;

    /// <include file='DxcDefine.xml' path='doc/member[@name="DxcDefine.Value"]/*' />
    [NativeTypeName("LPCWSTR")]
    public uint* Value;
}
