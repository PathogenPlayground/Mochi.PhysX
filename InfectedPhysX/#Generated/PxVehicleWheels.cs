// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using Mochi.PhysX.Infrastructure;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Mochi.PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 192)]
    public unsafe partial struct PxVehicleWheels
    {
        [FieldOffset(0)] public PxBase Base;

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getVehicleType@PxVehicleWheels@physx@@QEBAIXZ", ExactSpelling = true)]
        private static extern uint getVehicleType_PInvoke(PxVehicleWheels* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getVehicleType()
        {
            fixed (PxVehicleWheels* @this = &this)
            { return getVehicleType_PInvoke(@this); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getRigidDynamicActor@PxVehicleWheels@physx@@QEAAPEAVPxRigidDynamic@2@XZ", ExactSpelling = true)]
        private static extern PxRigidDynamic* getRigidDynamicActor_PInvoke(PxVehicleWheels* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxRigidDynamic* getRigidDynamicActor()
        {
            fixed (PxVehicleWheels* @this = &this)
            { return getRigidDynamicActor_PInvoke(@this); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getRigidDynamicActor@PxVehicleWheels@physx@@QEBAPEBVPxRigidDynamic@2@XZ", ExactSpelling = true)]
        private static extern PxRigidDynamic* getRigidDynamicActor_Const_PInvoke(PxVehicleWheels* @this);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxRigidDynamic* getRigidDynamicActor_Const()
        {
            fixed (PxVehicleWheels* @this = &this)
            { return getRigidDynamicActor_Const_PInvoke(@this); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?computeForwardSpeed@PxVehicleWheels@physx@@QEBAMXZ", ExactSpelling = true)]
        private static extern float computeForwardSpeed_PInvoke(PxVehicleWheels* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float computeForwardSpeed()
        {
            fixed (PxVehicleWheels* @this = &this)
            { return computeForwardSpeed_PInvoke(@this); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?computeSidewaysSpeed@PxVehicleWheels@physx@@QEBAMXZ", ExactSpelling = true)]
        private static extern float computeSidewaysSpeed_PInvoke(PxVehicleWheels* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float computeSidewaysSpeed()
        {
            fixed (PxVehicleWheels* @this = &this)
            { return computeSidewaysSpeed_PInvoke(@this); }
        }

        [FieldOffset(16)] public PxVehicleWheelsSimData mWheelsSimData;

        [FieldOffset(112)] public PxVehicleWheelsDynData mWheelsDynData;

        [FieldOffset(160)] public PxRigidDynamic* mActor;

        [FieldOffset(168)] public uint mNbNonDrivenWheels;

        [FieldOffset(172)] public byte mOnConstraintReleaseCounter;

        [FieldOffset(173)] public byte mType;

        [FieldOffset(174)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxU8_14 mPad0;

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void requiresObjects(PxProcessPxBaseCallback* c)
        {
            fixed (PxVehicleWheels* @this = &this)
            { VirtualMethodTablePointer->requiresObjects(@this, c); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte* getConcreteTypeName()
        {
            fixed (PxVehicleWheels* @this = &this)
            { return VirtualMethodTablePointer->getConcreteTypeName(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool isKindOf(byte* name)
        {
            fixed (PxVehicleWheels* @this = &this)
            { return VirtualMethodTablePointer->isKindOf(@this, name); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void preExportDataReset()
        {
            fixed (PxVehicleWheels* @this = &this)
            { VirtualMethodTablePointer->preExportDataReset(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void exportExtraData(PxSerializationContext* arg0)
        {
            fixed (PxVehicleWheels* @this = &this)
            { VirtualMethodTablePointer->exportExtraData(@this, arg0); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?importExtraData@PxVehicleWheels@physx@@QEAAXAEAVPxDeserializationContext@2@@Z", ExactSpelling = true)]
        private static extern void importExtraData_PInvoke(PxVehicleWheels* @this, PxDeserializationContext* arg0);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void importExtraData(PxDeserializationContext* arg0)
        {
            fixed (PxVehicleWheels* @this = &this)
            { importExtraData_PInvoke(@this, arg0); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?resolveReferences@PxVehicleWheels@physx@@QEAAXAEAVPxDeserializationContext@2@@Z", ExactSpelling = true)]
        private static extern void resolveReferences_PInvoke(PxVehicleWheels* @this, PxDeserializationContext* arg0);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void resolveReferences(PxDeserializationContext* arg0)
        {
            fixed (PxVehicleWheels* @this = &this)
            { resolveReferences_PInvoke(@this, arg0); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getBinaryMetaData@PxVehicleWheels@physx@@SAXAEAVPxOutputStream@2@@Z", ExactSpelling = true)]
        public static extern void getBinaryMetaData(PxOutputStream* stream);

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getNbNonDrivenWheels@PxVehicleWheels@physx@@QEBAIXZ", ExactSpelling = true)]
        private static extern uint getNbNonDrivenWheels_PInvoke(PxVehicleWheels* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getNbNonDrivenWheels()
        {
            fixed (PxVehicleWheels* @this = &this)
            { return getNbNonDrivenWheels_PInvoke(@this); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper210", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxVehicleWheels* @this, ushort concreteType, PxBaseFlags* baseFlags);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Constructor(ushort concreteType, PxBaseFlags* baseFlags)
        {
            fixed (PxVehicleWheels* @this = &this)
            { Constructor_PInvoke(@this, concreteType, baseFlags); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper211", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxVehicleWheels* @this, PxBaseFlags* baseFlags);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Constructor(PxBaseFlags* baseFlags)
        {
            fixed (PxVehicleWheels* @this = &this)
            { Constructor_PInvoke(@this, baseFlags); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Destructor()
        {
            fixed (PxVehicleWheels* @this = &this)
            { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void release()
        {
            fixed (PxVehicleWheels* @this = &this)
            { VirtualMethodTablePointer->release(@this); }
        }

        [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct VirtualMethodTable
        {
            /// <summary>Virtual method pointer for `release`</summary>
            public delegate* unmanaged[Cdecl]<PxVehicleWheels*, void> release;
            /// <summary>Virtual method pointer for `getConcreteTypeName`</summary>
            public delegate* unmanaged[Cdecl]<PxVehicleWheels*, byte*> getConcreteTypeName;
            /// <summary>Virtual method pointer for `isReleasable`</summary>
            public delegate* unmanaged[Cdecl]<PxVehicleWheels*, NativeBoolean> isReleasable;
            /// <summary>Virtual method pointer for `~PxVehicleWheels`</summary>
            public delegate* unmanaged[Cdecl]<PxVehicleWheels*, void> __DeletingDestructorPointer;
            /// <summary>Virtual method pointer for `isKindOf`</summary>
            public delegate* unmanaged[Cdecl]<PxVehicleWheels*, byte*, NativeBoolean> isKindOf;
            /// <summary>Virtual method pointer for `init`</summary>
            public void* init;
            /// <summary>Virtual method pointer for `requiresObjects`</summary>
            public delegate* unmanaged[Cdecl]<PxVehicleWheels*, PxProcessPxBaseCallback*, void> requiresObjects;
            /// <summary>Virtual method pointer for `preExportDataReset`</summary>
            public delegate* unmanaged[Cdecl]<PxVehicleWheels*, void> preExportDataReset;
            /// <summary>Virtual method pointer for `exportExtraData`</summary>
            public delegate* unmanaged[Cdecl]<PxVehicleWheels*, PxSerializationContext*, void> exportExtraData;
        }
    }
}
