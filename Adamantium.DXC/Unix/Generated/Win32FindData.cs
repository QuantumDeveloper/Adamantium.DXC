namespace Adamantium.DXC.Unix;

/// <include file='Win32FindData.xml' path='doc/member[@name="Win32FindData"]/*' />
internal unsafe partial struct Win32FindData
{
    /// <include file='Win32FindData.xml' path='doc/member[@name="Win32FindData.dwFileAttributes"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFileAttributes;

    /// <include file='Win32FindData.xml' path='doc/member[@name="Win32FindData.ftCreationTime"]/*' />
    public FILETIME ftCreationTime;

    /// <include file='Win32FindData.xml' path='doc/member[@name="Win32FindData.ftLastAccessTime"]/*' />
    public FILETIME ftLastAccessTime;

    /// <include file='Win32FindData.xml' path='doc/member[@name="Win32FindData.ftLastWriteTime"]/*' />
    public FILETIME ftLastWriteTime;

    /// <include file='Win32FindData.xml' path='doc/member[@name="Win32FindData.nFileSizeHigh"]/*' />
    [NativeTypeName("DWORD")]
    public uint nFileSizeHigh;

    /// <include file='Win32FindData.xml' path='doc/member[@name="Win32FindData.nFileSizeLow"]/*' />
    [NativeTypeName("DWORD")]
    public uint nFileSizeLow;

    /// <include file='Win32FindData.xml' path='doc/member[@name="Win32FindData.dwReserved0"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved0;

    /// <include file='Win32FindData.xml' path='doc/member[@name="Win32FindData.dwReserved1"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved1;

    /// <include file='Win32FindData.xml' path='doc/member[@name="Win32FindData.cFileName"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public fixed uint cFileName[260];

    /// <include file='Win32FindData.xml' path='doc/member[@name="Win32FindData.cAlternateFileName"]/*' />
    [NativeTypeName("WCHAR[14]")]
    public fixed uint cAlternateFileName[14];
}
