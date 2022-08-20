namespace Adamantium.DXC.Unix;

/// <include file='FILETIME.xml' path='doc/member[@name="FILETIME"]/*' />
internal partial struct FILETIME
{
    /// <include file='FILETIME.xml' path='doc/member[@name="FILETIME.dwLowDateTime"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLowDateTime;

    /// <include file='FILETIME.xml' path='doc/member[@name="FILETIME.dwHighDateTime"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwHighDateTime;
}
