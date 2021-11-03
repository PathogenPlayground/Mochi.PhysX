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
    public unsafe partial struct PxShape
    {
        [FieldOffset(0)] public PxBase Base;

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void release()
        {
            fixed (PxShape* @this = &this)
            { VirtualMethodTablePointer->release(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getReferenceCount()
        {
            fixed (PxShape* @this = &this)
            { return VirtualMethodTablePointer->getReferenceCount(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void acquireReference()
        {
            fixed (PxShape* @this = &this)
            { VirtualMethodTablePointer->acquireReference(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxGeometryType getGeometryType()
        {
            fixed (PxShape* @this = &this)
            { return VirtualMethodTablePointer->getGeometryType(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setGeometry(PxGeometry* geometry)
        {
            fixed (PxShape* @this = &this)
            { VirtualMethodTablePointer->setGeometry(@this, geometry); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxGeometryHolder getGeometry()
        {
            fixed (PxShape* @this = &this)
            {
                PxGeometryHolder __returnBuffer;
                VirtualMethodTablePointer->getGeometry(@this, &__returnBuffer);
                return __returnBuffer;
            }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool getBoxGeometry(PxBoxGeometry* geometry)
        {
            fixed (PxShape* @this = &this)
            { return VirtualMethodTablePointer->getBoxGeometry(@this, geometry); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool getSphereGeometry(PxSphereGeometry* geometry)
        {
            fixed (PxShape* @this = &this)
            { return VirtualMethodTablePointer->getSphereGeometry(@this, geometry); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool getCapsuleGeometry(PxCapsuleGeometry* geometry)
        {
            fixed (PxShape* @this = &this)
            { return VirtualMethodTablePointer->getCapsuleGeometry(@this, geometry); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool getPlaneGeometry(PxPlaneGeometry* geometry)
        {
            fixed (PxShape* @this = &this)
            { return VirtualMethodTablePointer->getPlaneGeometry(@this, geometry); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool getConvexMeshGeometry(PxConvexMeshGeometry* geometry)
        {
            fixed (PxShape* @this = &this)
            { return VirtualMethodTablePointer->getConvexMeshGeometry(@this, geometry); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool getTriangleMeshGeometry(PxTriangleMeshGeometry* geometry)
        {
            fixed (PxShape* @this = &this)
            { return VirtualMethodTablePointer->getTriangleMeshGeometry(@this, geometry); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool getHeightFieldGeometry(PxHeightFieldGeometry* geometry)
        {
            fixed (PxShape* @this = &this)
            { return VirtualMethodTablePointer->getHeightFieldGeometry(@this, geometry); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxRigidActor* getActor()
        {
            fixed (PxShape* @this = &this)
            { return VirtualMethodTablePointer->getActor(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setLocalPose(PxTransform* pose)
        {
            fixed (PxShape* @this = &this)
            { VirtualMethodTablePointer->setLocalPose(@this, pose); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxTransform getLocalPose()
        {
            fixed (PxShape* @this = &this)
            {
                PxTransform __returnBuffer;
                VirtualMethodTablePointer->getLocalPose(@this, &__returnBuffer);
                return __returnBuffer;
            }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setSimulationFilterData(PxFilterData* data)
        {
            fixed (PxShape* @this = &this)
            { VirtualMethodTablePointer->setSimulationFilterData(@this, data); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxFilterData getSimulationFilterData()
        {
            fixed (PxShape* @this = &this)
            {
                PxFilterData __returnBuffer;
                VirtualMethodTablePointer->getSimulationFilterData(@this, &__returnBuffer);
                return __returnBuffer;
            }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setQueryFilterData(PxFilterData* data)
        {
            fixed (PxShape* @this = &this)
            { VirtualMethodTablePointer->setQueryFilterData(@this, data); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxFilterData getQueryFilterData()
        {
            fixed (PxShape* @this = &this)
            {
                PxFilterData __returnBuffer;
                VirtualMethodTablePointer->getQueryFilterData(@this, &__returnBuffer);
                return __returnBuffer;
            }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setMaterials(PxMaterial** materials, ushort materialCount)
        {
            fixed (PxShape* @this = &this)
            { VirtualMethodTablePointer->setMaterials(@this, materials, materialCount); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort getNbMaterials()
        {
            fixed (PxShape* @this = &this)
            { return VirtualMethodTablePointer->getNbMaterials(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getMaterials(PxMaterial** userBuffer, uint bufferSize, uint startIndex = 0)
        {
            fixed (PxShape* @this = &this)
            { return VirtualMethodTablePointer->getMaterials(@this, userBuffer, bufferSize, startIndex); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxMaterial* getMaterialFromInternalFaceIndex(uint faceIndex)
        {
            fixed (PxShape* @this = &this)
            { return VirtualMethodTablePointer->getMaterialFromInternalFaceIndex(@this, faceIndex); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setContactOffset(float contactOffset)
        {
            fixed (PxShape* @this = &this)
            { VirtualMethodTablePointer->setContactOffset(@this, contactOffset); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float getContactOffset()
        {
            fixed (PxShape* @this = &this)
            { return VirtualMethodTablePointer->getContactOffset(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setRestOffset(float restOffset)
        {
            fixed (PxShape* @this = &this)
            { VirtualMethodTablePointer->setRestOffset(@this, restOffset); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float getRestOffset()
        {
            fixed (PxShape* @this = &this)
            { return VirtualMethodTablePointer->getRestOffset(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setTorsionalPatchRadius(float radius)
        {
            fixed (PxShape* @this = &this)
            { VirtualMethodTablePointer->setTorsionalPatchRadius(@this, radius); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float getTorsionalPatchRadius()
        {
            fixed (PxShape* @this = &this)
            { return VirtualMethodTablePointer->getTorsionalPatchRadius(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setMinTorsionalPatchRadius(float radius)
        {
            fixed (PxShape* @this = &this)
            { VirtualMethodTablePointer->setMinTorsionalPatchRadius(@this, radius); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float getMinTorsionalPatchRadius()
        {
            fixed (PxShape* @this = &this)
            { return VirtualMethodTablePointer->getMinTorsionalPatchRadius(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setFlag(PxShapeFlags flag, bool value)
        {
            fixed (PxShape* @this = &this)
            { VirtualMethodTablePointer->setFlag(@this, flag, value); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setFlags(PxShapeFlags* inFlags)
        {
            fixed (PxShape* @this = &this)
            { VirtualMethodTablePointer->setFlags(@this, inFlags); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxShapeFlags getFlags()
        {
            fixed (PxShape* @this = &this)
            {
                PxShapeFlags __returnBuffer;
                VirtualMethodTablePointer->getFlags(@this, &__returnBuffer);
                return __returnBuffer;
            }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool isExclusive()
        {
            fixed (PxShape* @this = &this)
            { return VirtualMethodTablePointer->isExclusive(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setName(byte* name)
        {
            fixed (PxShape* @this = &this)
            { VirtualMethodTablePointer->setName(@this, name); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte* getName()
        {
            fixed (PxShape* @this = &this)
            { return VirtualMethodTablePointer->getName(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte* getConcreteTypeName()
        {
            fixed (PxShape* @this = &this)
            { return VirtualMethodTablePointer->getConcreteTypeName(@this); }
        }

        [FieldOffset(16)] public void* userData;

        [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct VirtualMethodTable
        {
            /// <summary>Virtual method pointer for `release`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, void> release;
            /// <summary>Virtual method pointer for `getConcreteTypeName`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, byte*> getConcreteTypeName;
            /// <summary>Virtual method pointer for `isReleasable`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, NativeBoolean> isReleasable;
            /// <summary>Virtual method pointer for `~PxShape`</summary>
            public void* __DeletingDestructorPointer;
            /// <summary>Virtual method pointer for `isKindOf`</summary>
            public void* isKindOf;
            /// <summary>Virtual method pointer for `getReferenceCount`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, uint> getReferenceCount;
            /// <summary>Virtual method pointer for `acquireReference`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, void> acquireReference;
            /// <summary>Virtual method pointer for `getGeometryType`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, PxGeometryType> getGeometryType;
            /// <summary>Virtual method pointer for `setGeometry`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, PxGeometry*, void> setGeometry;
            /// <summary>Virtual method pointer for `getGeometry`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, PxGeometryHolder*, PxGeometryHolder*> getGeometry;
            /// <summary>Virtual method pointer for `getBoxGeometry`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, PxBoxGeometry*, NativeBoolean> getBoxGeometry;
            /// <summary>Virtual method pointer for `getSphereGeometry`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, PxSphereGeometry*, NativeBoolean> getSphereGeometry;
            /// <summary>Virtual method pointer for `getCapsuleGeometry`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, PxCapsuleGeometry*, NativeBoolean> getCapsuleGeometry;
            /// <summary>Virtual method pointer for `getPlaneGeometry`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, PxPlaneGeometry*, NativeBoolean> getPlaneGeometry;
            /// <summary>Virtual method pointer for `getConvexMeshGeometry`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, PxConvexMeshGeometry*, NativeBoolean> getConvexMeshGeometry;
            /// <summary>Virtual method pointer for `getTriangleMeshGeometry`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, PxTriangleMeshGeometry*, NativeBoolean> getTriangleMeshGeometry;
            /// <summary>Virtual method pointer for `getHeightFieldGeometry`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, PxHeightFieldGeometry*, NativeBoolean> getHeightFieldGeometry;
            /// <summary>Virtual method pointer for `getActor`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, PxRigidActor*> getActor;
            /// <summary>Virtual method pointer for `setLocalPose`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, PxTransform*, void> setLocalPose;
            /// <summary>Virtual method pointer for `getLocalPose`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, PxTransform*, PxTransform*> getLocalPose;
            /// <summary>Virtual method pointer for `setSimulationFilterData`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, PxFilterData*, void> setSimulationFilterData;
            /// <summary>Virtual method pointer for `getSimulationFilterData`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, PxFilterData*, PxFilterData*> getSimulationFilterData;
            /// <summary>Virtual method pointer for `setQueryFilterData`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, PxFilterData*, void> setQueryFilterData;
            /// <summary>Virtual method pointer for `getQueryFilterData`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, PxFilterData*, PxFilterData*> getQueryFilterData;
            /// <summary>Virtual method pointer for `setMaterials`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, PxMaterial**, ushort, void> setMaterials;
            /// <summary>Virtual method pointer for `getNbMaterials`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, ushort> getNbMaterials;
            /// <summary>Virtual method pointer for `getMaterials`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, PxMaterial**, uint, uint, uint> getMaterials;
            /// <summary>Virtual method pointer for `getMaterialFromInternalFaceIndex`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, uint, PxMaterial*> getMaterialFromInternalFaceIndex;
            /// <summary>Virtual method pointer for `setContactOffset`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, float, void> setContactOffset;
            /// <summary>Virtual method pointer for `getContactOffset`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, float> getContactOffset;
            /// <summary>Virtual method pointer for `setRestOffset`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, float, void> setRestOffset;
            /// <summary>Virtual method pointer for `getRestOffset`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, float> getRestOffset;
            /// <summary>Virtual method pointer for `setTorsionalPatchRadius`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, float, void> setTorsionalPatchRadius;
            /// <summary>Virtual method pointer for `getTorsionalPatchRadius`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, float> getTorsionalPatchRadius;
            /// <summary>Virtual method pointer for `setMinTorsionalPatchRadius`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, float, void> setMinTorsionalPatchRadius;
            /// <summary>Virtual method pointer for `getMinTorsionalPatchRadius`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, float> getMinTorsionalPatchRadius;
            /// <summary>Virtual method pointer for `setFlag`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, PxShapeFlags, NativeBoolean, void> setFlag;
            /// <summary>Virtual method pointer for `setFlags`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, PxShapeFlags*, void> setFlags;
            /// <summary>Virtual method pointer for `getFlags`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, PxShapeFlags*, PxShapeFlags*> getFlags;
            /// <summary>Virtual method pointer for `isExclusive`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, NativeBoolean> isExclusive;
            /// <summary>Virtual method pointer for `setName`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, byte*, void> setName;
            /// <summary>Virtual method pointer for `getName`</summary>
            public delegate* unmanaged[Cdecl]<PxShape*, byte*> getName;
        }
    }
}
