using System;

namespace Adamantium.DXC;

internal unsafe partial struct STATSTG
{
    [NativeTypeName("LPOLESTR")]
    public ushort* pwcsName;

    [NativeTypeName("DWORD")]
    public uint type;

    public UInt64 cbSize;

    public FILETIME mtime;

    public FILETIME ctime;

    public FILETIME atime;

    [NativeTypeName("DWORD")]
    public uint grfMode;

    [NativeTypeName("DWORD")]
    public uint grfLocksSupported;

    [NativeTypeName("CLSID")]
    public Guid clsid;

    [NativeTypeName("DWORD")]
    public uint grfStateBits;

    [NativeTypeName("DWORD")]
    public uint reserved;
}