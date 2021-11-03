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
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public unsafe partial struct PxPhysics
    {
        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Destructor()
        {
            fixed (PxPhysics* @this = &this)
            { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void release()
        {
            fixed (PxPhysics* @this = &this)
            { VirtualMethodTablePointer->release(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxFoundation* getFoundation()
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->getFoundation(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxAggregate* createAggregate(uint maxSize, bool enableSelfCollision)
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->createAggregate(@this, maxSize, enableSelfCollision); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxTolerancesScale* getTolerancesScale()
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->getTolerancesScale(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxTriangleMesh* createTriangleMesh(PxInputStream* stream)
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->createTriangleMesh(@this, stream); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getNbTriangleMeshes()
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->getNbTriangleMeshes(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getTriangleMeshes(PxTriangleMesh** userBuffer, uint bufferSize, uint startIndex = 0)
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->getTriangleMeshes(@this, userBuffer, bufferSize, startIndex); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxHeightField* createHeightField(PxInputStream* stream)
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->createHeightField(@this, stream); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getNbHeightFields()
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->getNbHeightFields(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getHeightFields(PxHeightField** userBuffer, uint bufferSize, uint startIndex = 0)
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->getHeightFields(@this, userBuffer, bufferSize, startIndex); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxConvexMesh* createConvexMesh(PxInputStream* stream)
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->createConvexMesh(@this, stream); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getNbConvexMeshes()
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->getNbConvexMeshes(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getConvexMeshes(PxConvexMesh** userBuffer, uint bufferSize, uint startIndex = 0)
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->getConvexMeshes(@this, userBuffer, bufferSize, startIndex); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxBVHStructure* createBVHStructure(PxInputStream* stream)
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->createBVHStructure(@this, stream); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getNbBVHStructures()
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->getNbBVHStructures(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getBVHStructures(PxBVHStructure** userBuffer, uint bufferSize, uint startIndex = 0)
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->getBVHStructures(@this, userBuffer, bufferSize, startIndex); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxScene* createScene(PxSceneDesc* sceneDesc)
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->createScene(@this, sceneDesc); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getNbScenes()
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->getNbScenes(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getScenes(PxScene** userBuffer, uint bufferSize, uint startIndex = 0)
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->getScenes(@this, userBuffer, bufferSize, startIndex); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxRigidStatic* createRigidStatic(PxTransform* pose)
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->createRigidStatic(@this, pose); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxRigidDynamic* createRigidDynamic(PxTransform* pose)
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->createRigidDynamic(@this, pose); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxPruningStructure* createPruningStructure(PxRigidActor** actors, uint nbActors)
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->createPruningStructure(@this, actors, nbActors); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?createShape@PxPhysics@physx@@QEAAPEAVPxShape@2@AEBVPxGeometry@2@AEBVPxMaterial@2@_NV?$PxFlags@W4Enum@PxShapeFlag@physx@@E@2@@Z", ExactSpelling = true)]
        private static extern PxShape* createShape_PInvoke(PxPhysics* @this, PxGeometry* geometry, PxMaterial* material, [MarshalAs(UnmanagedType.I1)] bool isExclusive, PxShapeFlags* shapeFlags);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxShape* createShape(PxGeometry* geometry, PxMaterial* material, bool isExclusive, PxShapeFlags* shapeFlags)
        {
            fixed (PxPhysics* @this = &this)
            { return createShape_PInvoke(@this, geometry, material, isExclusive, shapeFlags); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxShape* createShape(PxGeometry* geometry, PxMaterial** materials, ushort materialCount, bool isExclusive, PxShapeFlags* shapeFlags)
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->createShape(@this, geometry, materials, materialCount, isExclusive, shapeFlags); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getNbShapes()
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->getNbShapes(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getShapes(PxShape** userBuffer, uint bufferSize, uint startIndex = 0)
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->getShapes(@this, userBuffer, bufferSize, startIndex); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxConstraint* createConstraint(PxRigidActor* actor0, PxRigidActor* actor1, PxConstraintConnector* connector, PxConstraintShaderTable* shaders, uint dataSize)
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->createConstraint(@this, actor0, actor1, connector, shaders, dataSize); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxArticulation* createArticulation()
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->createArticulation(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxArticulationReducedCoordinate* createArticulationReducedCoordinate()
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->createArticulationReducedCoordinate(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxMaterial* createMaterial(float staticFriction, float dynamicFriction, float restitution)
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->createMaterial(@this, staticFriction, dynamicFriction, restitution); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getNbMaterials()
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->getNbMaterials(@this); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getMaterials(PxMaterial** userBuffer, uint bufferSize, uint startIndex = 0)
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->getMaterials(@this, userBuffer, bufferSize, startIndex); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void registerDeletionListener(PxDeletionListener* observer, PxDeletionEventFlags* deletionEvents, bool restrictedObjectSet = false)
        {
            fixed (PxPhysics* @this = &this)
            { VirtualMethodTablePointer->registerDeletionListener(@this, observer, deletionEvents, restrictedObjectSet); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void unregisterDeletionListener(PxDeletionListener* observer)
        {
            fixed (PxPhysics* @this = &this)
            { VirtualMethodTablePointer->unregisterDeletionListener(@this, observer); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void registerDeletionListenerObjects(PxDeletionListener* observer, PxBase** observables, uint observableCount)
        {
            fixed (PxPhysics* @this = &this)
            { VirtualMethodTablePointer->registerDeletionListenerObjects(@this, observer, observables, observableCount); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void unregisterDeletionListenerObjects(PxDeletionListener* observer, PxBase** observables, uint observableCount)
        {
            fixed (PxPhysics* @this = &this)
            { VirtualMethodTablePointer->unregisterDeletionListenerObjects(@this, observer, observables, observableCount); }
        }

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PxPhysicsInsertionCallback* getPhysicsInsertionCallback()
        {
            fixed (PxPhysics* @this = &this)
            { return VirtualMethodTablePointer->getPhysicsInsertionCallback(@this); }
        }

        [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct VirtualMethodTable
        {
            /// <summary>Virtual method pointer for `~PxPhysics`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, void> __DeletingDestructorPointer;
            /// <summary>Virtual method pointer for `release`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, void> release;
            /// <summary>Virtual method pointer for `getFoundation`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, PxFoundation*> getFoundation;
            /// <summary>Virtual method pointer for `createAggregate`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, uint, NativeBoolean, PxAggregate*> createAggregate;
            /// <summary>Virtual method pointer for `getTolerancesScale`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, PxTolerancesScale*> getTolerancesScale;
            /// <summary>Virtual method pointer for `createTriangleMesh`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, PxInputStream*, PxTriangleMesh*> createTriangleMesh;
            /// <summary>Virtual method pointer for `getNbTriangleMeshes`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, uint> getNbTriangleMeshes;
            /// <summary>Virtual method pointer for `getTriangleMeshes`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, PxTriangleMesh**, uint, uint, uint> getTriangleMeshes;
            /// <summary>Virtual method pointer for `createHeightField`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, PxInputStream*, PxHeightField*> createHeightField;
            /// <summary>Virtual method pointer for `getNbHeightFields`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, uint> getNbHeightFields;
            /// <summary>Virtual method pointer for `getHeightFields`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, PxHeightField**, uint, uint, uint> getHeightFields;
            /// <summary>Virtual method pointer for `createConvexMesh`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, PxInputStream*, PxConvexMesh*> createConvexMesh;
            /// <summary>Virtual method pointer for `getNbConvexMeshes`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, uint> getNbConvexMeshes;
            /// <summary>Virtual method pointer for `getConvexMeshes`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, PxConvexMesh**, uint, uint, uint> getConvexMeshes;
            /// <summary>Virtual method pointer for `createBVHStructure`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, PxInputStream*, PxBVHStructure*> createBVHStructure;
            /// <summary>Virtual method pointer for `getNbBVHStructures`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, uint> getNbBVHStructures;
            /// <summary>Virtual method pointer for `getBVHStructures`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, PxBVHStructure**, uint, uint, uint> getBVHStructures;
            /// <summary>Virtual method pointer for `createScene`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, PxSceneDesc*, PxScene*> createScene;
            /// <summary>Virtual method pointer for `getNbScenes`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, uint> getNbScenes;
            /// <summary>Virtual method pointer for `getScenes`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, PxScene**, uint, uint, uint> getScenes;
            /// <summary>Virtual method pointer for `createRigidStatic`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, PxTransform*, PxRigidStatic*> createRigidStatic;
            /// <summary>Virtual method pointer for `createRigidDynamic`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, PxTransform*, PxRigidDynamic*> createRigidDynamic;
            /// <summary>Virtual method pointer for `createPruningStructure`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, PxRigidActor**, uint, PxPruningStructure*> createPruningStructure;
            /// <summary>Virtual method pointer for `createShape`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, PxGeometry*, PxMaterial**, ushort, NativeBoolean, PxShapeFlags*, PxShape*> createShape;
            /// <summary>Virtual method pointer for `getNbShapes`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, uint> getNbShapes;
            /// <summary>Virtual method pointer for `getShapes`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, PxShape**, uint, uint, uint> getShapes;
            /// <summary>Virtual method pointer for `createConstraint`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, PxRigidActor*, PxRigidActor*, PxConstraintConnector*, PxConstraintShaderTable*, uint, PxConstraint*> createConstraint;
            /// <summary>Virtual method pointer for `createArticulation`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, PxArticulation*> createArticulation;
            /// <summary>Virtual method pointer for `createArticulationReducedCoordinate`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, PxArticulationReducedCoordinate*> createArticulationReducedCoordinate;
            /// <summary>Virtual method pointer for `createMaterial`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, float, float, float, PxMaterial*> createMaterial;
            /// <summary>Virtual method pointer for `getNbMaterials`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, uint> getNbMaterials;
            /// <summary>Virtual method pointer for `getMaterials`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, PxMaterial**, uint, uint, uint> getMaterials;
            /// <summary>Virtual method pointer for `registerDeletionListener`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, PxDeletionListener*, PxDeletionEventFlags*, NativeBoolean, void> registerDeletionListener;
            /// <summary>Virtual method pointer for `unregisterDeletionListener`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, PxDeletionListener*, void> unregisterDeletionListener;
            /// <summary>Virtual method pointer for `registerDeletionListenerObjects`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, PxDeletionListener*, PxBase**, uint, void> registerDeletionListenerObjects;
            /// <summary>Virtual method pointer for `unregisterDeletionListenerObjects`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, PxDeletionListener*, PxBase**, uint, void> unregisterDeletionListenerObjects;
            /// <summary>Virtual method pointer for `getPhysicsInsertionCallback`</summary>
            public delegate* unmanaged[Cdecl]<PxPhysics*, PxPhysicsInsertionCallback*> getPhysicsInsertionCallback;
        }
    }
}
