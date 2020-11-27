// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 224)]
public unsafe partial struct PxTGSSolverConstraintPrepDesc
{
    [FieldOffset(0)] public PxTGSSolverConstraintPrepDescBase Base;

    [FieldOffset(144)] public Px1DConstraint* rows;

    [FieldOffset(152)] public uint numRows;

    [FieldOffset(156)] public float linBreakForce;

    [FieldOffset(160)] public float angBreakForce;

    [FieldOffset(164)] public float minResponseThreshold;

    [FieldOffset(168)] public void* writeback;

    [FieldOffset(176)] [MarshalAs(UnmanagedType.I1)] public bool disablePreprocessing;

    [FieldOffset(177)] [MarshalAs(UnmanagedType.I1)] public bool improvedSlerp;

    [FieldOffset(178)] [MarshalAs(UnmanagedType.I1)] public bool driveLimitsAreForces;

    [FieldOffset(179)] [MarshalAs(UnmanagedType.I1)] public bool extendedLimits;

    [FieldOffset(180)] public PxVec3 body0WorldOffset;

    [FieldOffset(192)] public PxVec3 cA2w;

    [FieldOffset(204)] public PxVec3 cB2w;
}
