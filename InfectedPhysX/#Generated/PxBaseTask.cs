// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Mochi.PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct PxBaseTask
    {
        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Destructor()
        {
            fixed (PxBaseTask* @this = &this)
            { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void run()
        {
            fixed (PxBaseTask* @this = &this)
            { VirtualMethodTablePointer->run(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte* getName()
        {
            fixed (PxBaseTask* @this = &this)
            { return VirtualMethodTablePointer->getName(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void addReference()
        {
            fixed (PxBaseTask* @this = &this)
            { VirtualMethodTablePointer->addReference(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void removeReference()
        {
            fixed (PxBaseTask* @this = &this)
            { VirtualMethodTablePointer->removeReference(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int getReference()
        {
            fixed (PxBaseTask* @this = &this)
            { return VirtualMethodTablePointer->getReference(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void release()
        {
            fixed (PxBaseTask* @this = &this)
            { VirtualMethodTablePointer->release(@this); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getTaskManager@PxBaseTask@physx@@QEBAPEAVPxTaskManager@2@XZ", ExactSpelling = true)]
        private static extern PxTaskManager* getTaskManager_PInvoke(PxBaseTask* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxTaskManager* getTaskManager()
        {
            fixed (PxBaseTask* @this = &this)
            { return getTaskManager_PInvoke(@this); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setContextId@PxBaseTask@physx@@QEAAX_K@Z", ExactSpelling = true)]
        private static extern void setContextId_PInvoke(PxBaseTask* @this, ulong id);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setContextId(ulong id)
        {
            fixed (PxBaseTask* @this = &this)
            { setContextId_PInvoke(@this, id); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getContextId@PxBaseTask@physx@@QEBA_KXZ", ExactSpelling = true)]
        private static extern ulong getContextId_PInvoke(PxBaseTask* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong getContextId()
        {
            fixed (PxBaseTask* @this = &this)
            { return getContextId_PInvoke(@this); }
        }

        [FieldOffset(8)] public ulong mContextID;

        [FieldOffset(16)] public PxTaskManager* mTm;

        [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct VirtualMethodTable
        {
            /// <summary>Virtual method pointer for `~PxBaseTask`</summary>
            public delegate* unmanaged[Cdecl]<PxBaseTask*, void> __DeletingDestructorPointer;
            /// <summary>Virtual method pointer for `run`</summary>
            public delegate* unmanaged[Cdecl]<PxBaseTask*, void> run;
            /// <summary>Virtual method pointer for `getName`</summary>
            public delegate* unmanaged[Cdecl]<PxBaseTask*, byte*> getName;
            /// <summary>Virtual method pointer for `addReference`</summary>
            public delegate* unmanaged[Cdecl]<PxBaseTask*, void> addReference;
            /// <summary>Virtual method pointer for `removeReference`</summary>
            public delegate* unmanaged[Cdecl]<PxBaseTask*, void> removeReference;
            /// <summary>Virtual method pointer for `getReference`</summary>
            public delegate* unmanaged[Cdecl]<PxBaseTask*, int> getReference;
            /// <summary>Virtual method pointer for `release`</summary>
            public delegate* unmanaged[Cdecl]<PxBaseTask*, void> release;
        }
    }
}
