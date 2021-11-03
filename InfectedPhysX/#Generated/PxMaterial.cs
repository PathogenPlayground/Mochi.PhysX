// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using Mochi.PhysX.Infrastructure;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Mochi.PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct PxMaterial
    {
        [FieldOffset(0)] public PxBase Base;

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void release()
        {
            fixed (PxMaterial* @this = &this)
            { VirtualMethodTablePointer->release(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getReferenceCount()
        {
            fixed (PxMaterial* @this = &this)
            { return VirtualMethodTablePointer->getReferenceCount(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void acquireReference()
        {
            fixed (PxMaterial* @this = &this)
            { VirtualMethodTablePointer->acquireReference(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setDynamicFriction(float coef)
        {
            fixed (PxMaterial* @this = &this)
            { VirtualMethodTablePointer->setDynamicFriction(@this, coef); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float getDynamicFriction()
        {
            fixed (PxMaterial* @this = &this)
            { return VirtualMethodTablePointer->getDynamicFriction(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setStaticFriction(float coef)
        {
            fixed (PxMaterial* @this = &this)
            { VirtualMethodTablePointer->setStaticFriction(@this, coef); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float getStaticFriction()
        {
            fixed (PxMaterial* @this = &this)
            { return VirtualMethodTablePointer->getStaticFriction(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setRestitution(float rest)
        {
            fixed (PxMaterial* @this = &this)
            { VirtualMethodTablePointer->setRestitution(@this, rest); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float getRestitution()
        {
            fixed (PxMaterial* @this = &this)
            { return VirtualMethodTablePointer->getRestitution(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setFlag(PxMaterialFlags flag, bool b)
        {
            fixed (PxMaterial* @this = &this)
            { VirtualMethodTablePointer->setFlag(@this, flag, b); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setFlags(PxMaterialFlags* flags)
        {
            fixed (PxMaterial* @this = &this)
            { VirtualMethodTablePointer->setFlags(@this, flags); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxMaterialFlags getFlags()
        {
            fixed (PxMaterial* @this = &this)
            {
                PxMaterialFlags __returnBuffer;
                VirtualMethodTablePointer->getFlags(@this, &__returnBuffer);
                return __returnBuffer;
            }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setFrictionCombineMode(PxCombineMode combMode)
        {
            fixed (PxMaterial* @this = &this)
            { VirtualMethodTablePointer->setFrictionCombineMode(@this, combMode); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxCombineMode getFrictionCombineMode()
        {
            fixed (PxMaterial* @this = &this)
            { return VirtualMethodTablePointer->getFrictionCombineMode(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setRestitutionCombineMode(PxCombineMode combMode)
        {
            fixed (PxMaterial* @this = &this)
            { VirtualMethodTablePointer->setRestitutionCombineMode(@this, combMode); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxCombineMode getRestitutionCombineMode()
        {
            fixed (PxMaterial* @this = &this)
            { return VirtualMethodTablePointer->getRestitutionCombineMode(@this); }
        }

        [FieldOffset(16)] public void* userData;

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte* getConcreteTypeName()
        {
            fixed (PxMaterial* @this = &this)
            { return VirtualMethodTablePointer->getConcreteTypeName(@this); }
        }

        [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct VirtualMethodTable
        {
            /// <summary>Virtual method pointer for `release`</summary>
            public delegate* unmanaged[Cdecl]<PxMaterial*, void> release;
            /// <summary>Virtual method pointer for `getConcreteTypeName`</summary>
            public delegate* unmanaged[Cdecl]<PxMaterial*, byte*> getConcreteTypeName;
            /// <summary>Virtual method pointer for `isReleasable`</summary>
            public delegate* unmanaged[Cdecl]<PxMaterial*, NativeBoolean> isReleasable;
            /// <summary>Virtual method pointer for `~PxMaterial`</summary>
            public void* __DeletingDestructorPointer;
            /// <summary>Virtual method pointer for `isKindOf`</summary>
            public void* isKindOf;
            /// <summary>Virtual method pointer for `getReferenceCount`</summary>
            public delegate* unmanaged[Cdecl]<PxMaterial*, uint> getReferenceCount;
            /// <summary>Virtual method pointer for `acquireReference`</summary>
            public delegate* unmanaged[Cdecl]<PxMaterial*, void> acquireReference;
            /// <summary>Virtual method pointer for `setDynamicFriction`</summary>
            public delegate* unmanaged[Cdecl]<PxMaterial*, float, void> setDynamicFriction;
            /// <summary>Virtual method pointer for `getDynamicFriction`</summary>
            public delegate* unmanaged[Cdecl]<PxMaterial*, float> getDynamicFriction;
            /// <summary>Virtual method pointer for `setStaticFriction`</summary>
            public delegate* unmanaged[Cdecl]<PxMaterial*, float, void> setStaticFriction;
            /// <summary>Virtual method pointer for `getStaticFriction`</summary>
            public delegate* unmanaged[Cdecl]<PxMaterial*, float> getStaticFriction;
            /// <summary>Virtual method pointer for `setRestitution`</summary>
            public delegate* unmanaged[Cdecl]<PxMaterial*, float, void> setRestitution;
            /// <summary>Virtual method pointer for `getRestitution`</summary>
            public delegate* unmanaged[Cdecl]<PxMaterial*, float> getRestitution;
            /// <summary>Virtual method pointer for `setFlag`</summary>
            public delegate* unmanaged[Cdecl]<PxMaterial*, PxMaterialFlags, NativeBoolean, void> setFlag;
            /// <summary>Virtual method pointer for `setFlags`</summary>
            public delegate* unmanaged[Cdecl]<PxMaterial*, PxMaterialFlags*, void> setFlags;
            /// <summary>Virtual method pointer for `getFlags`</summary>
            public delegate* unmanaged[Cdecl]<PxMaterial*, PxMaterialFlags*, PxMaterialFlags*> getFlags;
            /// <summary>Virtual method pointer for `setFrictionCombineMode`</summary>
            public delegate* unmanaged[Cdecl]<PxMaterial*, PxCombineMode, void> setFrictionCombineMode;
            /// <summary>Virtual method pointer for `getFrictionCombineMode`</summary>
            public delegate* unmanaged[Cdecl]<PxMaterial*, PxCombineMode> getFrictionCombineMode;
            /// <summary>Virtual method pointer for `setRestitutionCombineMode`</summary>
            public delegate* unmanaged[Cdecl]<PxMaterial*, PxCombineMode, void> setRestitutionCombineMode;
            /// <summary>Virtual method pointer for `getRestitutionCombineMode`</summary>
            public delegate* unmanaged[Cdecl]<PxMaterial*, PxCombineMode> getRestitutionCombineMode;
        }
    }
}
