// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Mochi.PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct PxSceneLimits
    {
        [FieldOffset(0)] public uint maxNbActors;

        [FieldOffset(4)] public uint maxNbBodies;

        [FieldOffset(8)] public uint maxNbStaticShapes;

        [FieldOffset(12)] public uint maxNbDynamicShapes;

        [FieldOffset(16)] public uint maxNbAggregates;

        [FieldOffset(20)] public uint maxNbConstraints;

        [FieldOffset(24)] public uint maxNbRegions;

        [FieldOffset(28)] public uint maxNbBroadPhaseOverlaps;

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper123", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxSceneLimits* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Constructor()
        {
            fixed (PxSceneLimits* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setToDefault@PxSceneLimits@physx@@QEAAXXZ", ExactSpelling = true)]
        private static extern void setToDefault_PInvoke(PxSceneLimits* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setToDefault()
        {
            fixed (PxSceneLimits* @this = &this)
            { setToDefault_PInvoke(@this); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValid@PxSceneLimits@physx@@QEBA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool isValid_PInvoke(PxSceneLimits* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool isValid()
        {
            fixed (PxSceneLimits* @this = &this)
            { return isValid_PInvoke(@this); }
        }
    }
}
