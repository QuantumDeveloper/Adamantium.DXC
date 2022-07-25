using System;

namespace Adamantium.DXC.Unix;

/// <include file='STATSTG.xml' path='doc/member[@name="STATSTG"]/*' />
internal unsafe partial struct STATSTG
{
    /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.pwcsName"]/*' />
    [NativeTypeName("LPOLESTR")]
    public uint* pwcsName;

    /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.type"]/*' />
    [NativeTypeName("DWORD")]
    public uint type;

    /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.cbSize"]/*' />
    public ULARGE_INTEGER cbSize;

    /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.mtime"]/*' />
    public FILETIME mtime;

    /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.ctime"]/*' />
    public FILETIME ctime;

    /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.atime"]/*' />
    public FILETIME atime;

    /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.grfMode"]/*' />
    [NativeTypeName("DWORD")]
    public uint grfMode;

    /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.grfLocksSupported"]/*' />
    [NativeTypeName("DWORD")]
    public uint grfLocksSupported;

    /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.clsid"]/*' />
    [NativeTypeName("CLSID")]
    public Guid clsid;

    /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.grfStateBits"]/*' />
    [NativeTypeName("DWORD")]
    public uint grfStateBits;

    /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.reserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint reserved;
}
