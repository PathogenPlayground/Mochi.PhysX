// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 4)]
public unsafe partial struct PxBVH34MidphaseDesc
{
    [FieldOffset(0)] public uint numPrimsPerLeaf;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setToDefault@PxBVH34MidphaseDesc@physx@@QEAAXXZ", ExactSpelling = true)]
    private static extern void setToDefault_PInvoke(PxBVH34MidphaseDesc* @this);

    public unsafe void setToDefault()
    {
        fixed (PxBVH34MidphaseDesc* @this = &this)
        { setToDefault_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValid@PxBVH34MidphaseDesc@physx@@QEBA_NXZ", ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.I1)]
    private static extern bool isValid_PInvoke(PxBVH34MidphaseDesc* @this);

    public unsafe bool isValid()
    {
        fixed (PxBVH34MidphaseDesc* @this = &this)
        { return isValid_PInvoke(@this); }
    }
}
