// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 28)]
public unsafe partial struct PxMeshScale
{
    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxMeshScale@physx@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxMeshScale* @this);

    public unsafe void Constructor()
    {
        fixed (PxMeshScale* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxMeshScale@physx@@QEAA@M@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxMeshScale* @this, float r);

    public unsafe void Constructor(float r)
    {
        fixed (PxMeshScale* @this = &this)
        { Constructor_PInvoke(@this, r); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxMeshScale@physx@@QEAA@AEBVPxVec3@1@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxMeshScale* @this, PxVec3* s);

    public unsafe void Constructor(PxVec3* s)
    {
        fixed (PxMeshScale* @this = &this)
        { Constructor_PInvoke(@this, s); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxMeshScale@physx@@QEAA@AEBVPxVec3@1@AEBVPxQuat@1@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxMeshScale* @this, PxVec3* s, PxQuat* r);

    public unsafe void Constructor(PxVec3* s, PxQuat* r)
    {
        fixed (PxMeshScale* @this = &this)
        { Constructor_PInvoke(@this, s, r); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isIdentity@PxMeshScale@physx@@QEBA_NXZ", ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.I1)]
    private static extern bool isIdentity_PInvoke(PxMeshScale* @this);

    public unsafe bool isIdentity()
    {
        fixed (PxMeshScale* @this = &this)
        { return isIdentity_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getInverse@PxMeshScale@physx@@QEBA?AV12@XZ", ExactSpelling = true)]
    private static extern void getInverse_PInvoke(PxMeshScale* @this, out PxMeshScale __returnBuffer);

    public unsafe PxMeshScale getInverse()
    {
        fixed (PxMeshScale* @this = &this)
        {
            PxMeshScale __returnBuffer;
            getInverse_PInvoke(@this, out __returnBuffer);
            return __returnBuffer;
        }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?toMat33@PxMeshScale@physx@@QEBA?AVPxMat33@2@XZ", ExactSpelling = true)]
    private static extern void toMat33_PInvoke(PxMeshScale* @this, out PxMat33 __returnBuffer);

    public unsafe PxMat33 toMat33()
    {
        fixed (PxMeshScale* @this = &this)
        {
            PxMat33 __returnBuffer;
            toMat33_PInvoke(@this, out __returnBuffer);
            return __returnBuffer;
        }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?hasNegativeDeterminant@PxMeshScale@physx@@QEBA_NXZ", ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.I1)]
    private static extern bool hasNegativeDeterminant_PInvoke(PxMeshScale* @this);

    public unsafe bool hasNegativeDeterminant()
    {
        fixed (PxMeshScale* @this = &this)
        { return hasNegativeDeterminant_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?transform@PxMeshScale@physx@@QEBA?AVPxVec3@2@AEBV32@@Z", ExactSpelling = true)]
    private static extern void transform_PInvoke(PxMeshScale* @this, out PxVec3 __returnBuffer, PxVec3* v);

    public unsafe PxVec3 transform(PxVec3* v)
    {
        fixed (PxMeshScale* @this = &this)
        {
            PxVec3 __returnBuffer;
            transform_PInvoke(@this, out __returnBuffer, v);
            return __returnBuffer;
        }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValidForTriangleMesh@PxMeshScale@physx@@QEBA_NXZ", ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.I1)]
    private static extern bool isValidForTriangleMesh_PInvoke(PxMeshScale* @this);

    public unsafe bool isValidForTriangleMesh()
    {
        fixed (PxMeshScale* @this = &this)
        { return isValidForTriangleMesh_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValidForConvexMesh@PxMeshScale@physx@@QEBA_NXZ", ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.I1)]
    private static extern bool isValidForConvexMesh_PInvoke(PxMeshScale* @this);

    public unsafe bool isValidForConvexMesh()
    {
        fixed (PxMeshScale* @this = &this)
        { return isValidForConvexMesh_PInvoke(@this); }
    }

    [FieldOffset(0)] public PxVec3 scale;

    [FieldOffset(12)] public PxQuat rotation;
}
