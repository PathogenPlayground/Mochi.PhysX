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
    public unsafe partial struct PxAllocInfo
    {
        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper75", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxAllocInfo* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Constructor()
        {
            fixed (PxAllocInfo* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper76", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxAllocInfo* @this, byte* file, int line, byte* allocName, PxAllocId allocId);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Constructor(byte* file, int line, byte* allocName, PxAllocId allocId)
        {
            fixed (PxAllocInfo* @this = &this)
            { Constructor_PInvoke(@this, file, line, allocName, allocId); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getFileName@PxAllocInfo@physx@@QEBAPEBDXZ", ExactSpelling = true)]
        private static extern byte* getFileName_PInvoke(PxAllocInfo* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte* getFileName()
        {
            fixed (PxAllocInfo* @this = &this)
            { return getFileName_PInvoke(@this); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getLine@PxAllocInfo@physx@@QEBAHXZ", ExactSpelling = true)]
        private static extern int getLine_PInvoke(PxAllocInfo* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int getLine()
        {
            fixed (PxAllocInfo* @this = &this)
            { return getLine_PInvoke(@this); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getAllocName@PxAllocInfo@physx@@QEBAPEBDXZ", ExactSpelling = true)]
        private static extern byte* getAllocName_PInvoke(PxAllocInfo* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte* getAllocName()
        {
            fixed (PxAllocInfo* @this = &this)
            { return getAllocName_PInvoke(@this); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getAllocId@PxAllocInfo@physx@@QEBA?AW4Enum@PxAllocId@2@XZ", ExactSpelling = true)]
        private static extern PxAllocId getAllocId_PInvoke(PxAllocInfo* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxAllocId getAllocId()
        {
            fixed (PxAllocInfo* @this = &this)
            { return getAllocId_PInvoke(@this); }
        }

        [FieldOffset(0)] public byte* mFileName;

        [FieldOffset(8)] public int mLine;

        [FieldOffset(16)] public byte* mAllocName;

        [FieldOffset(24)] public PxAllocId mAllocId;
    }
}
