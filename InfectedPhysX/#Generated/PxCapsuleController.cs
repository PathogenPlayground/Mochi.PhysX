// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 8)]
public unsafe partial struct PxCapsuleController
{
    [FieldOffset(0)] public PxController Base;

    public unsafe float getRadius()
    {
        fixed (PxCapsuleController* @this = &this)
        { return VirtualMethodTablePointer->getRadius(@this); }
    }

    public unsafe bool setRadius(float radius)
    {
        fixed (PxCapsuleController* @this = &this)
        { return VirtualMethodTablePointer->setRadius(@this, radius); }
    }

    public unsafe float getHeight()
    {
        fixed (PxCapsuleController* @this = &this)
        { return VirtualMethodTablePointer->getHeight(@this); }
    }

    public unsafe bool setHeight(float height)
    {
        fixed (PxCapsuleController* @this = &this)
        { return VirtualMethodTablePointer->setHeight(@this, height); }
    }

    public unsafe PxCapsuleClimbingMode getClimbingMode()
    {
        fixed (PxCapsuleController* @this = &this)
        { return VirtualMethodTablePointer->getClimbingMode(@this); }
    }

    public unsafe bool setClimbingMode(PxCapsuleClimbingMode mode)
    {
        fixed (PxCapsuleController* @this = &this)
        { return VirtualMethodTablePointer->setClimbingMode(@this, mode); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxCapsuleController@physx@@IEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxCapsuleController* @this);

    public unsafe void Constructor()
    {
        fixed (PxCapsuleController* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    public unsafe void Destructor()
    {
        fixed (PxCapsuleController* @this = &this)
        { VirtualMethodTablePointer->__DeletingDestructorPointer(@this); }
    }


    [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VirtualMethodTable
    {
        /// <summary>Virtual method pointer for `getType`</summary>
        public delegate* unmanaged[Cdecl]<PxController*, PxControllerShapeType> getType;
        /// <summary>Virtual method pointer for `release`</summary>
        public delegate* unmanaged[Cdecl]<PxController*, void> release;
        /// <summary>Virtual method pointer for `move`</summary>
        public delegate* unmanaged[Cdecl]<PxController*, PxVec3*, float, float, PxControllerFilters*, PxObstacleContext*, PxControllerCollisionFlags> move;
        /// <summary>Virtual method pointer for `setPosition`</summary>
        public delegate* unmanaged[Cdecl]<PxController*, PxExtendedVec3*, NativeBoolean> setPosition;
        /// <summary>Virtual method pointer for `getPosition`</summary>
        public delegate* unmanaged[Cdecl]<PxController*, PxExtendedVec3*> getPosition;
        /// <summary>Virtual method pointer for `setFootPosition`</summary>
        public delegate* unmanaged[Cdecl]<PxController*, PxExtendedVec3*, NativeBoolean> setFootPosition;
        /// <summary>Virtual method pointer for `getFootPosition`</summary>
        public delegate* unmanaged[Cdecl]<PxController*, out PxExtendedVec3, void> getFootPosition;
        /// <summary>Virtual method pointer for `getActor`</summary>
        public delegate* unmanaged[Cdecl]<PxController*, PxRigidDynamic*> getActor;
        /// <summary>Virtual method pointer for `setStepOffset`</summary>
        public delegate* unmanaged[Cdecl]<PxController*, float, void> setStepOffset;
        /// <summary>Virtual method pointer for `getStepOffset`</summary>
        public delegate* unmanaged[Cdecl]<PxController*, float> getStepOffset;
        /// <summary>Virtual method pointer for `setNonWalkableMode`</summary>
        public delegate* unmanaged[Cdecl]<PxController*, PxControllerNonWalkableMode, void> setNonWalkableMode;
        /// <summary>Virtual method pointer for `getNonWalkableMode`</summary>
        public delegate* unmanaged[Cdecl]<PxController*, PxControllerNonWalkableMode> getNonWalkableMode;
        /// <summary>Virtual method pointer for `getContactOffset`</summary>
        public delegate* unmanaged[Cdecl]<PxController*, float> getContactOffset;
        /// <summary>Virtual method pointer for `setContactOffset`</summary>
        public delegate* unmanaged[Cdecl]<PxController*, float, void> setContactOffset;
        /// <summary>Virtual method pointer for `getUpDirection`</summary>
        public delegate* unmanaged[Cdecl]<PxController*, out PxVec3, void> getUpDirection;
        /// <summary>Virtual method pointer for `setUpDirection`</summary>
        public delegate* unmanaged[Cdecl]<PxController*, PxVec3*, void> setUpDirection;
        /// <summary>Virtual method pointer for `getSlopeLimit`</summary>
        public delegate* unmanaged[Cdecl]<PxController*, float> getSlopeLimit;
        /// <summary>Virtual method pointer for `setSlopeLimit`</summary>
        public delegate* unmanaged[Cdecl]<PxController*, float, void> setSlopeLimit;
        /// <summary>Virtual method pointer for `invalidateCache`</summary>
        public delegate* unmanaged[Cdecl]<PxController*, void> invalidateCache;
        /// <summary>Virtual method pointer for `getScene`</summary>
        public delegate* unmanaged[Cdecl]<PxController*, PxScene*> getScene;
        /// <summary>Virtual method pointer for `getUserData`</summary>
        public delegate* unmanaged[Cdecl]<PxController*, void*> getUserData;
        /// <summary>Virtual method pointer for `setUserData`</summary>
        public delegate* unmanaged[Cdecl]<PxController*, void*, void> setUserData;
        /// <summary>Virtual method pointer for `getState`</summary>
        public delegate* unmanaged[Cdecl]<PxController*, PxControllerState*, void> getState;
        /// <summary>Virtual method pointer for `getStats`</summary>
        public delegate* unmanaged[Cdecl]<PxController*, PxControllerStats*, void> getStats;
        /// <summary>Virtual method pointer for `resize`</summary>
        public delegate* unmanaged[Cdecl]<PxController*, float, void> resize;
        /// <summary>Virtual method pointer for `~PxCapsuleController`</summary>
        public delegate* unmanaged[Cdecl]<PxCapsuleController*, void> __DeletingDestructorPointer;
        /// <summary>Virtual method pointer for `getRadius`</summary>
        public delegate* unmanaged[Cdecl]<PxCapsuleController*, float> getRadius;
        /// <summary>Virtual method pointer for `setRadius`</summary>
        public delegate* unmanaged[Cdecl]<PxCapsuleController*, float, NativeBoolean> setRadius;
        /// <summary>Virtual method pointer for `getHeight`</summary>
        public delegate* unmanaged[Cdecl]<PxCapsuleController*, float> getHeight;
        /// <summary>Virtual method pointer for `setHeight`</summary>
        public delegate* unmanaged[Cdecl]<PxCapsuleController*, float, NativeBoolean> setHeight;
        /// <summary>Virtual method pointer for `getClimbingMode`</summary>
        public delegate* unmanaged[Cdecl]<PxCapsuleController*, PxCapsuleClimbingMode> getClimbingMode;
        /// <summary>Virtual method pointer for `setClimbingMode`</summary>
        public delegate* unmanaged[Cdecl]<PxCapsuleController*, PxCapsuleClimbingMode, NativeBoolean> setClimbingMode;
    }
}
