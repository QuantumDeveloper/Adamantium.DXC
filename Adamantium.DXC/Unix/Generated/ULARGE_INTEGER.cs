using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix;

/// <include file='ULARGE_INTEGER.xml' path='doc/member[@name="ULARGE_INTEGER"]/*' />
[StructLayout(LayoutKind.Explicit)]
internal partial struct ULARGE_INTEGER
{
    /// <include file='ULARGE_INTEGER.xml' path='doc/member[@name="ULARGE_INTEGER.u"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("struct (anonymous struct at /home/den/Загрузки/VulkanSDK/1.3.216.0/source/DirectXShaderCompiler/include/dxc/Support/WinAdapter.h:515:3)")]
    public _u_e__Struct u;

    /// <include file='ULARGE_INTEGER.xml' path='doc/member[@name="ULARGE_INTEGER.QuadPart"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("ULONGLONG")]
    public ulong QuadPart;

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
