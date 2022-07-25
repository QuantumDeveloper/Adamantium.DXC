namespace Adamantium.DXC.Unix;

public static partial class FILE
{
    [NativeTypeName("#define FILE_TYPE_UNKNOWN 0x0000")]
    public const int FILE_TYPE_UNKNOWN = 0x0000;

    [NativeTypeName("#define FILE_TYPE_DISK 0x0001")]
    public const int FILE_TYPE_DISK = 0x0001;

    [NativeTypeName("#define FILE_TYPE_CHAR 0x0002")]
    public const int FILE_TYPE_CHAR = 0x0002;

    [NativeTypeName("#define FILE_TYPE_PIPE 0x0003")]
    public const int FILE_TYPE_PIPE = 0x0003;

    [NativeTypeName("#define FILE_TYPE_REMOTE 0x8000")]
    public const int FILE_TYPE_REMOTE = 0x8000;

    [NativeTypeName("#define FILE_ATTRIBUTE_NORMAL 0x00000080")]
    public const int FILE_ATTRIBUTE_NORMAL = 0x00000080;

    [NativeTypeName("#define FILE_ATTRIBUTE_DIRECTORY 0x00000010")]
    public const int FILE_ATTRIBUTE_DIRECTORY = 0x00000010;

    [NativeTypeName("#define FILE_SHARE_DELETE 0x00000004")]
    public const int FILE_SHARE_DELETE = 0x00000004;

    [NativeTypeName("#define FILE_SHARE_READ 0x00000001")]
    public const int FILE_SHARE_READ = 0x00000001;

    [NativeTypeName("#define FILE_SHARE_WRITE 0x00000002")]
    public const int FILE_SHARE_WRITE = 0x00000002;
}
