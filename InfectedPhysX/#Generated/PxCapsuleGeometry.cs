// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 12)]
public unsafe partial struct PxCapsuleGeometry
{
    [FieldOffset(0)] public PxGeometry Base;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxCapsuleGeometry@physx@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxCapsuleGeometry* @this);

    public unsafe void Constructor()
    {
        fixed (PxCapsuleGeometry* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxCapsuleGeometry@physx@@QEAA@MM@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxCapsuleGeometry* @this, float radius_, float halfHeight_);

    public unsafe void Constructor(float radius_, float halfHeight_)
    {
        fixed (PxCapsuleGeometry* @this = &this)
        { Constructor_PInvoke(@this, radius_, halfHeight_); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValid@PxCapsuleGeometry@physx@@QEBA_NXZ", ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.I1)]
    private static extern bool isValid_PInvoke(PxCapsuleGeometry* @this);

    public unsafe bool isValid()
    {
        fixed (PxCapsuleGeometry* @this = &this)
        { return isValid_PInvoke(@this); }
    }

    [FieldOffset(4)] public float radius;

    [FieldOffset(8)] public float halfHeight;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PxTransformFromSegment@physx@@YA?AVPxTransform@1@AEBVPxVec3@1@0PEAM@Z", ExactSpelling = true)]
    public static extern void PxTransformFromSegment(out PxTransform __returnBuffer, PxVec3* p0, PxVec3* p1, float* halfHeight = null);
}
