// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using Mochi.PhysX.Infrastructure;
using System.Runtime.InteropServices;

namespace Mochi.PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct PxConstraintShaderTable
    {
        public const int eMAX_SOLVERPRPEP_DATASIZE = 400;

        [FieldOffset(0)] public delegate* unmanaged[Cdecl]<Px1DConstraint*, PxVec3*, uint, PxConstraintInvMassScale*, void*, PxTransform*, PxTransform*, NativeBoolean, PxVec3*, PxVec3*, uint> solverPrep;

        [FieldOffset(8)] public delegate* unmanaged[Cdecl]<void*, PxTransform*, PxTransform*, NativeBoolean, void> project;

        [FieldOffset(16)] public delegate* unmanaged[Cdecl]<PxConstraintVisualizer*, void*, PxTransform*, PxTransform*, uint, void> visualize;

        [FieldOffset(24)] public PxConstraintFlags flag;
    }
}
