// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Mochi.PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public unsafe partial struct PxJointLimitPyramid
    {
        [FieldOffset(0)] public PxJointLimitParameters Base;

        [FieldOffset(20)] public float yAngleMin;

        [FieldOffset(24)] public float yAngleMax;

        [FieldOffset(28)] public float zAngleMin;

        [FieldOffset(32)] public float zAngleMax;

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper171", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxJointLimitPyramid* @this, float yLimitAngleMin, float yLimitAngleMax, float zLimitAngleMin, float zLimitAngleMax, float contactDist);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Constructor(float yLimitAngleMin, float yLimitAngleMax, float zLimitAngleMin, float zLimitAngleMax, float contactDist = -1f)
        {
            fixed (PxJointLimitPyramid* @this = &this)
            { Constructor_PInvoke(@this, yLimitAngleMin, yLimitAngleMax, zLimitAngleMin, zLimitAngleMax, contactDist); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper172", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxJointLimitPyramid* @this, float yLimitAngleMin, float yLimitAngleMax, float zLimitAngleMin, float zLimitAngleMax, PxSpring* spring);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Constructor(float yLimitAngleMin, float yLimitAngleMax, float zLimitAngleMin, float zLimitAngleMax, PxSpring* spring)
        {
            fixed (PxJointLimitPyramid* @this = &this)
            { Constructor_PInvoke(@this, yLimitAngleMin, yLimitAngleMax, zLimitAngleMin, zLimitAngleMax, spring); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValid@PxJointLimitPyramid@physx@@QEBA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool isValid_PInvoke(PxJointLimitPyramid* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool isValid()
        {
            fixed (PxJointLimitPyramid* @this = &this)
            { return isValid_PInvoke(@this); }
        }
    }
}
