// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Mochi.PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct PxCapsuleObstacle
    {
        [FieldOffset(0)] public PxObstacle Base;

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper147", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxCapsuleObstacle* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Constructor()
        {
            fixed (PxCapsuleObstacle* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [FieldOffset(56)] public float mHalfHeight;

        [FieldOffset(60)] public float mRadius;
    }
}
