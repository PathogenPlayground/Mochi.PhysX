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
    public unsafe partial struct PxDefaultMemoryInputData
    {
        [FieldOffset(0)] public PxInputData Base;

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxDefaultMemoryInputData@physx@@QEAA@PEAEI@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxDefaultMemoryInputData* @this, byte* data, uint length);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Constructor(byte* data, uint length)
        {
            fixed (PxDefaultMemoryInputData* @this = &this)
            { Constructor_PInvoke(@this, data, length); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint read(void* dest, uint count)
        {
            fixed (PxDefaultMemoryInputData* @this = &this)
            { return VirtualMethodTablePointer->read(@this, dest, count); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getLength()
        {
            fixed (PxDefaultMemoryInputData* @this = &this)
            { return VirtualMethodTablePointer->getLength(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void seek(uint pos)
        {
            fixed (PxDefaultMemoryInputData* @this = &this)
            { VirtualMethodTablePointer->seek(@this, pos); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint tell()
        {
            fixed (PxDefaultMemoryInputData* @this = &this)
            { return VirtualMethodTablePointer->tell(@this); }
        }

        [FieldOffset(8)] public uint mSize;

        [FieldOffset(16)] public byte* mData;

        [FieldOffset(24)] public uint mPos;

        [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct VirtualMethodTable
        {
            /// <summary>Virtual method pointer for `read`</summary>
            public delegate* unmanaged[Cdecl]<PxDefaultMemoryInputData*, void*, uint, uint> read;
            /// <summary>Virtual method pointer for `~PxDefaultMemoryInputData`</summary>
            public void* __DeletingDestructorPointer;
            /// <summary>Virtual method pointer for `getLength`</summary>
            public delegate* unmanaged[Cdecl]<PxDefaultMemoryInputData*, uint> getLength;
            /// <summary>Virtual method pointer for `seek`</summary>
            public delegate* unmanaged[Cdecl]<PxDefaultMemoryInputData*, uint, void> seek;
            /// <summary>Virtual method pointer for `tell`</summary>
            public delegate* unmanaged[Cdecl]<PxDefaultMemoryInputData*, uint> tell;
        }
    }
}
