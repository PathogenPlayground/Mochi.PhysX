// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 56)]
public unsafe partial struct PxLocationHit
{
    [FieldOffset(0)] public PxQueryHit Base;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxLocationHit@physx@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxLocationHit* @this);

    public unsafe void Constructor()
    {
        fixed (PxLocationHit* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?hadInitialOverlap@PxLocationHit@physx@@QEBA_NXZ", ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.I1)]
    private static extern bool hadInitialOverlap_PInvoke(PxLocationHit* @this);

    public unsafe bool hadInitialOverlap()
    {
        fixed (PxLocationHit* @this = &this)
        { return hadInitialOverlap_PInvoke(@this); }
    }

    [FieldOffset(24)] public PxHitFlags flags;

    [FieldOffset(28)] public PxVec3 position;

    [FieldOffset(40)] public PxVec3 normal;

    [FieldOffset(52)] public float distance;
}
