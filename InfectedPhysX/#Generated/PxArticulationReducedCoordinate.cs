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
    public unsafe partial struct PxArticulationReducedCoordinate
    {
        [FieldOffset(0)] public PxArticulationBase Base;

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void release()
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { VirtualMethodTablePointer->release(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setArticulationFlags(PxArticulationFlags* flags)
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { VirtualMethodTablePointer->setArticulationFlags(@this, flags); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setArticulationFlag(PxArticulationFlags flag, bool value)
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { VirtualMethodTablePointer->setArticulationFlag(@this, flag, value); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxArticulationFlags getArticulationFlags()
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            {
                PxArticulationFlags __returnBuffer;
                VirtualMethodTablePointer->getArticulationFlags(@this, &__returnBuffer);
                return __returnBuffer;
            }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getDofs()
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { return VirtualMethodTablePointer->getDofs(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxArticulationCache* createCache()
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { return VirtualMethodTablePointer->createCache(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getCacheDataSize()
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { return VirtualMethodTablePointer->getCacheDataSize(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void zeroCache(PxArticulationCache* cache)
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { VirtualMethodTablePointer->zeroCache(@this, cache); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void applyCache(PxArticulationCache* cache, PxArticulationCache.PxArticulationCacheFlags* flag, bool autowake = true)
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { VirtualMethodTablePointer->applyCache(@this, cache, flag, autowake); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void copyInternalStateToCache(PxArticulationCache* cache, PxArticulationCache.PxArticulationCacheFlags* flag)
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { VirtualMethodTablePointer->copyInternalStateToCache(@this, cache, flag); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void releaseCache(PxArticulationCache* cache)
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { VirtualMethodTablePointer->releaseCache(@this, cache); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void packJointData(float* maximum, float* reduced)
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { VirtualMethodTablePointer->packJointData(@this, maximum, reduced); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void unpackJointData(float* reduced, float* maximum)
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { VirtualMethodTablePointer->unpackJointData(@this, reduced, maximum); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void commonInit()
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { VirtualMethodTablePointer->commonInit(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void computeGeneralizedGravityForce(PxArticulationCache* cache)
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { VirtualMethodTablePointer->computeGeneralizedGravityForce(@this, cache); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void computeCoriolisAndCentrifugalForce(PxArticulationCache* cache)
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { VirtualMethodTablePointer->computeCoriolisAndCentrifugalForce(@this, cache); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void computeGeneralizedExternalForce(PxArticulationCache* cache)
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { VirtualMethodTablePointer->computeGeneralizedExternalForce(@this, cache); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void computeJointAcceleration(PxArticulationCache* cache)
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { VirtualMethodTablePointer->computeJointAcceleration(@this, cache); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void computeJointForce(PxArticulationCache* cache)
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { VirtualMethodTablePointer->computeJointForce(@this, cache); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void computeDenseJacobian(PxArticulationCache* cache, uint* nRows, uint* nCols)
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { VirtualMethodTablePointer->computeDenseJacobian(@this, cache, nRows, nCols); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void computeCoefficientMatrix(PxArticulationCache* cache)
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { VirtualMethodTablePointer->computeCoefficientMatrix(@this, cache); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool computeLambda(PxArticulationCache* cache, PxArticulationCache* initialState, float* jointTorque, uint maxIter)
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { return VirtualMethodTablePointer->computeLambda(@this, cache, initialState, jointTorque, maxIter); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void computeGeneralizedMassMatrix(PxArticulationCache* cache)
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { VirtualMethodTablePointer->computeGeneralizedMassMatrix(@this, cache); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void addLoopJoint(PxJoint* joint)
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { VirtualMethodTablePointer->addLoopJoint(@this, joint); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void removeLoopJoint(PxJoint* joint)
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { VirtualMethodTablePointer->removeLoopJoint(@this, joint); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getNbLoopJoints()
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { return VirtualMethodTablePointer->getNbLoopJoints(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getLoopJoints(PxJoint** userBuffer, uint bufferSize, uint startIndex = 0)
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { return VirtualMethodTablePointer->getLoopJoints(@this, userBuffer, bufferSize, startIndex); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getCoefficientMatrixSize()
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { return VirtualMethodTablePointer->getCoefficientMatrixSize(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void teleportRootLink(PxTransform* pose, bool autowake)
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            { VirtualMethodTablePointer->teleportRootLink(@this, pose, autowake); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxSpatialVelocity getLinkVelocity(uint linkId)
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            {
                PxSpatialVelocity __returnBuffer;
                VirtualMethodTablePointer->getLinkVelocity(@this, &__returnBuffer, linkId);
                return __returnBuffer;
            }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxSpatialVelocity getLinkAcceleration(uint linkId)
        {
            fixed (PxArticulationReducedCoordinate* @this = &this)
            {
                PxSpatialVelocity __returnBuffer;
                VirtualMethodTablePointer->getLinkAcceleration(@this, &__returnBuffer, linkId);
                return __returnBuffer;
            }
        }

        [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct VirtualMethodTable
        {
            /// <summary>Virtual method pointer for `release`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, void> release;
            /// <summary>Virtual method pointer for `getConcreteTypeName`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, byte*> getConcreteTypeName;
            /// <summary>Virtual method pointer for `isReleasable`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, NativeBoolean> isReleasable;
            /// <summary>Virtual method pointer for `~PxArticulationReducedCoordinate`</summary>
            public void* __DeletingDestructorPointer;
            /// <summary>Virtual method pointer for `isKindOf`</summary>
            public void* isKindOf;
            /// <summary>Virtual method pointer for `getScene`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxScene*> getScene;
            /// <summary>Virtual method pointer for `setSolverIterationCounts`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, uint, uint, void> setSolverIterationCounts;
            /// <summary>Virtual method pointer for `getSolverIterationCounts`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, uint*, uint*, void> getSolverIterationCounts;
            /// <summary>Virtual method pointer for `isSleeping`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, NativeBoolean> isSleeping;
            /// <summary>Virtual method pointer for `setSleepThreshold`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, float, void> setSleepThreshold;
            /// <summary>Virtual method pointer for `getSleepThreshold`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, float> getSleepThreshold;
            /// <summary>Virtual method pointer for `setStabilizationThreshold`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, float, void> setStabilizationThreshold;
            /// <summary>Virtual method pointer for `getStabilizationThreshold`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, float> getStabilizationThreshold;
            /// <summary>Virtual method pointer for `setWakeCounter`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, float, void> setWakeCounter;
            /// <summary>Virtual method pointer for `getWakeCounter`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, float> getWakeCounter;
            /// <summary>Virtual method pointer for `wakeUp`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, void> wakeUp;
            /// <summary>Virtual method pointer for `putToSleep`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, void> putToSleep;
            /// <summary>Virtual method pointer for `createLink`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxArticulationLink*, PxTransform*, PxArticulationLink*> createLink;
            /// <summary>Virtual method pointer for `getNbLinks`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, uint> getNbLinks;
            /// <summary>Virtual method pointer for `getLinks`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxArticulationLink**, uint, uint, uint> getLinks;
            /// <summary>Virtual method pointer for `setName`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, byte*, void> setName;
            /// <summary>Virtual method pointer for `getName`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, byte*> getName;
            /// <summary>Virtual method pointer for `getWorldBounds`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxBounds3*, float, PxBounds3*> getWorldBounds;
            /// <summary>Virtual method pointer for `getAggregate`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxAggregate*> getAggregate;
            /// <summary>Virtual method pointer for `getImpl`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxArticulationImpl*> getImpl_0;
            /// <summary>Virtual method pointer for `getImpl`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxArticulationImpl*> getImpl_1;
            /// <summary>Virtual method pointer for `createArticulationJoint`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxArticulationLink*, PxTransform*, PxArticulationLink*, PxTransform*, PxArticulationJointBase*> createArticulationJoint;
            /// <summary>Virtual method pointer for `releaseArticulationJoint`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxArticulationJointBase*, void> releaseArticulationJoint;
            /// <summary>Virtual method pointer for `setArticulationFlags`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxArticulationFlags*, void> setArticulationFlags;
            /// <summary>Virtual method pointer for `setArticulationFlag`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxArticulationFlags, NativeBoolean, void> setArticulationFlag;
            /// <summary>Virtual method pointer for `getArticulationFlags`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxArticulationFlags*, PxArticulationFlags*> getArticulationFlags;
            /// <summary>Virtual method pointer for `getDofs`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, uint> getDofs;
            /// <summary>Virtual method pointer for `createCache`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxArticulationCache*> createCache;
            /// <summary>Virtual method pointer for `getCacheDataSize`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, uint> getCacheDataSize;
            /// <summary>Virtual method pointer for `zeroCache`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxArticulationCache*, void> zeroCache;
            /// <summary>Virtual method pointer for `applyCache`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxArticulationCache*, PxArticulationCache.PxArticulationCacheFlags*, NativeBoolean, void> applyCache;
            /// <summary>Virtual method pointer for `copyInternalStateToCache`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxArticulationCache*, PxArticulationCache.PxArticulationCacheFlags*, void> copyInternalStateToCache;
            /// <summary>Virtual method pointer for `releaseCache`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxArticulationCache*, void> releaseCache;
            /// <summary>Virtual method pointer for `packJointData`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, float*, float*, void> packJointData;
            /// <summary>Virtual method pointer for `unpackJointData`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, float*, float*, void> unpackJointData;
            /// <summary>Virtual method pointer for `commonInit`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, void> commonInit;
            /// <summary>Virtual method pointer for `computeGeneralizedGravityForce`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxArticulationCache*, void> computeGeneralizedGravityForce;
            /// <summary>Virtual method pointer for `computeCoriolisAndCentrifugalForce`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxArticulationCache*, void> computeCoriolisAndCentrifugalForce;
            /// <summary>Virtual method pointer for `computeGeneralizedExternalForce`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxArticulationCache*, void> computeGeneralizedExternalForce;
            /// <summary>Virtual method pointer for `computeJointAcceleration`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxArticulationCache*, void> computeJointAcceleration;
            /// <summary>Virtual method pointer for `computeJointForce`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxArticulationCache*, void> computeJointForce;
            /// <summary>Virtual method pointer for `computeDenseJacobian`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxArticulationCache*, uint*, uint*, void> computeDenseJacobian;
            /// <summary>Virtual method pointer for `computeCoefficientMatrix`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxArticulationCache*, void> computeCoefficientMatrix;
            /// <summary>Virtual method pointer for `computeLambda`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxArticulationCache*, PxArticulationCache*, float*, uint, NativeBoolean> computeLambda;
            /// <summary>Virtual method pointer for `computeGeneralizedMassMatrix`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxArticulationCache*, void> computeGeneralizedMassMatrix;
            /// <summary>Virtual method pointer for `addLoopJoint`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxJoint*, void> addLoopJoint;
            /// <summary>Virtual method pointer for `removeLoopJoint`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxJoint*, void> removeLoopJoint;
            /// <summary>Virtual method pointer for `getNbLoopJoints`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, uint> getNbLoopJoints;
            /// <summary>Virtual method pointer for `getLoopJoints`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxJoint**, uint, uint, uint> getLoopJoints;
            /// <summary>Virtual method pointer for `getCoefficientMatrixSize`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, uint> getCoefficientMatrixSize;
            /// <summary>Virtual method pointer for `teleportRootLink`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxTransform*, NativeBoolean, void> teleportRootLink;
            /// <summary>Virtual method pointer for `getLinkVelocity`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxSpatialVelocity*, uint, PxSpatialVelocity*> getLinkVelocity;
            /// <summary>Virtual method pointer for `getLinkAcceleration`</summary>
            public delegate* unmanaged[Cdecl]<PxArticulationReducedCoordinate*, PxSpatialVelocity*, uint, PxSpatialVelocity*> getLinkAcceleration;
        }
    }
}
