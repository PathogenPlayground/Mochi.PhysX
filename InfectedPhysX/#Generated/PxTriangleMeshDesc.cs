// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 72)]
public unsafe partial struct PxTriangleMeshDesc
{
    [FieldOffset(0)] public PxSimpleTriangleMesh Base;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxTriangleMeshDesc@physx@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxTriangleMeshDesc* @this);

    public unsafe void Constructor()
    {
        fixed (PxTriangleMeshDesc* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setToDefault@PxTriangleMeshDesc@physx@@QEAAXXZ", ExactSpelling = true)]
    private static extern void setToDefault_PInvoke(PxTriangleMeshDesc* @this);

    public unsafe void setToDefault()
    {
        fixed (PxTriangleMeshDesc* @this = &this)
        { setToDefault_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValid@PxTriangleMeshDesc@physx@@QEBA_NXZ", ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.I1)]
    private static extern bool isValid_PInvoke(PxTriangleMeshDesc* @this);

    public unsafe bool isValid()
    {
        fixed (PxTriangleMeshDesc* @this = &this)
        { return isValid_PInvoke(@this); }
    }
}
