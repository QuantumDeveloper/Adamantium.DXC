namespace Adamantium.DXC.Windows;

/// <include file='DxcArgPair.xml' path='doc/member[@name="DxcArgPair"]/*' />
internal unsafe partial struct DxcArgPair
{
    /// <include file='DxcArgPair.xml' path='doc/member[@name="DxcArgPair.pName"]/*' />
    [NativeTypeName("const WCHAR *")]
    public ushort* pName;

    /// <include file='DxcArgPair.xml' path='doc/member[@name="DxcArgPair.pValue"]/*' />
    [NativeTypeName("const WCHAR *")]
    public ushort* pValue;
}
