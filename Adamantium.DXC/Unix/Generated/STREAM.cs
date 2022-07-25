namespace Adamantium.DXC.Unix;

public static partial class STREAM
{
    [NativeTypeName("#define STREAM_SEEK_SET 0")]
    public const int STREAM_SEEK_SET = 0;

    [NativeTypeName("#define STREAM_SEEK_CUR 1")]
    public const int STREAM_SEEK_CUR = 1;

    [NativeTypeName("#define STREAM_SEEK_END 2")]
    public const int STREAM_SEEK_END = 2;
}
