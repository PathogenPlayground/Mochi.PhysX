// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Mochi.PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public unsafe partial struct PxCCDContactModifyCallback
    {
        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void onCCDContactModify(PxContactModifyPair* pairs, uint count)
        {
            fixed (PxCCDContactModifyCallback* @this = &this)
            { VirtualMethodTablePointer->onCCDContactModify(@this, pairs, count); }
        }

        [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct VirtualMethodTable
        {
            /// <summary>Virtual method pointer for `onCCDContactModify`</summary>
            public delegate* unmanaged[Cdecl]<PxCCDContactModifyCallback*, PxContactModifyPair*, uint, void> onCCDContactModify;
            /// <summary>Virtual method pointer for `~PxCCDContactModifyCallback`</summary>
            public void* __DeletingDestructorPointer;
        }
    }
}
