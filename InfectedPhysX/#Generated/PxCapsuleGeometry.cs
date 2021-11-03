// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Mochi.PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public unsafe partial struct PxCapsuleGeometry
    {
        [FieldOffset(0)] public PxGeometry Base;

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper85", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxCapsuleGeometry* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Constructor()
        {
            fixed (PxCapsuleGeometry* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper86", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxCapsuleGeometry* @this, float radius_, float halfHeight_);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Constructor(float radius_, float halfHeight_)
        {
            fixed (PxCapsuleGeometry* @this = &this)
            { Constructor_PInvoke(@this, radius_, halfHeight_); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?isValid@PxCapsuleGeometry@physx@@QEBA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool isValid_PInvoke(PxCapsuleGeometry* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool isValid()
        {
            fixed (PxCapsuleGeometry* @this = &this)
            { return isValid_PInvoke(@this); }
        }

        [FieldOffset(4)] public float radius;

        [FieldOffset(8)] public float halfHeight;
    }
}
