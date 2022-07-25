namespace Adamantium.DXC.Unix;

/// <include file='DxcArgPair.xml' path='doc/member[@name="DxcArgPair"]/*' />
internal unsafe partial struct DxcArgPair
{
    /// <include file='DxcArgPair.xml' path='doc/member[@name="DxcArgPair.pName"]/*' />
    [NativeTypeName("const WCHAR *")]
    public uint* pName;

    /// <include file='DxcArgPair.xml' path='doc/member[@name="DxcArgPair.pValue"]/*' />
    [NativeTypeName("const WCHAR *")]
    public uint* pValue;
}
