namespace Adamantium.DXC;

public partial struct HRESULT
{
    public static bool SUCCEEDED(HRESULT hr)
    {
        return hr >= 0;
    }

    public static bool FAILED(HRESULT hr)
    {
        return hr < 0;
    }
    
    [NativeTypeName("#define S_OK ((HRESULT)0L)")]
    public const int OK = ((int)(0));

    [NativeTypeName("#define S_FALSE ((HRESULT)1L)")]
    public const int FALSE = ((int)(1));
}