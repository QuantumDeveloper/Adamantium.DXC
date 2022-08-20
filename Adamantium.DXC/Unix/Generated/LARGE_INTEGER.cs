using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix;

/// <include file='LARGE_INTEGER.xml' path='doc/member[@name="LARGE_INTEGER"]/*' />
[StructLayout(LayoutKind.Explicit)]
internal partial struct LARGE_INTEGER
{
    /// <include file='LARGE_INTEGER.xml' path='doc/member[@name="LARGE_INTEGER.u"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("struct (anonymous struct at /home/den/Загрузки/VulkanSDK/1.3.216.0/source/DirectXShaderCompiler/include/dxc/Support/WinAdapter.h:505:3)")]
    public _u_e__Struct u;

    /// <include file='LARGE_INTEGER.xml' path='doc/member[@name="LARGE_INTEGER.QuadPart"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("LONGLONG")]
    public long QuadPart;

    /// <include file='_u_e__Struct.xml' path='doc/member[@name="_u_e__Struct"]/*' />
    internal partial struct _u_e__Struct
    {
        /// <include file='_u_e__Struct.xml' path='doc/member[@name="_u_e__Struct.LowPart"]/*' />
        [NativeTypeName("DWORD")]
        public uint LowPart;

        /// <include file='_u_e__Struct.xml' path='doc/member[@name="_u_e__Struct.HighPart"]/*' />
        [NativeTypeName("DWORD")]
        public uint HighPart;
    }
}
