namespace Adamantium.DXC;

public partial struct FILETIME
{
    [NativeTypeName("DWORD")]
    public uint dwLowDateTime;

    [NativeTypeName("DWORD")]
    public uint dwHighDateTime;
}