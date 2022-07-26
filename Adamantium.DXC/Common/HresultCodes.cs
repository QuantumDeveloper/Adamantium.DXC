namespace Adamantium.DXC;

internal static partial class HresultCodes
{
    [NativeTypeName("#define E_ABORT (HRESULT)0x80004004")]
    public const int ABORT = unchecked((int)(0x80004004));

    [NativeTypeName("#define E_ACCESSDENIED (HRESULT)0x80070005")]
    public const int ACCESSDENIED = unchecked((int)(0x80070005));

    [NativeTypeName("#define E_BOUNDS (HRESULT)0x8000000B")]
    public const int BOUNDS = unchecked((int)(0x8000000B));

    [NativeTypeName("#define E_FAIL (HRESULT)0x80004005")]
    public const int FAIL = unchecked((int)(0x80004005));

    [NativeTypeName("#define E_HANDLE (HRESULT)0x80070006")]
    public const int HANDLE = unchecked((int)(0x80070006));

    [NativeTypeName("#define E_INVALIDARG (HRESULT)0x80070057")]
    public const int INVALIDARG = unchecked((int)(0x80070057));

    [NativeTypeName("#define E_NOINTERFACE (HRESULT)0x80004002")]
    public const int NOINTERFACE = unchecked((int)(0x80004002));

    [NativeTypeName("#define E_NOTIMPL (HRESULT)0x80004001")]
    public const int NOTIMPL = unchecked((int)(0x80004001));

    [NativeTypeName("#define E_NOT_VALID_STATE (HRESULT)0x8007139F")]
    public const int NOT_VALID_STATE = unchecked((int)(0x8007139F));

    [NativeTypeName("#define E_OUTOFMEMORY (HRESULT)0x8007000E")]
    public const int OUTOFMEMORY = unchecked((int)(0x8007000E));

    [NativeTypeName("#define E_POINTER (HRESULT)0x80004003")]
    public const int POINTER = unchecked((int)(0x80004003));

    [NativeTypeName("#define E_UNEXPECTED (HRESULT)0x8000FFFF")]
    public const int UNEXPECTED = unchecked((int)(0x8000FFFF));
}
