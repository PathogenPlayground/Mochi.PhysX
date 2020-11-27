// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 24)]
public unsafe partial struct PxRevoluteJoint
{
    [FieldOffset(0)] public PxJoint Base;

    public unsafe float getAngle()
    {
        fixed (PxRevoluteJoint* @this = &this)
        { return VirtualMethodTablePointer->getAngle(@this); }
    }

    public unsafe float getVelocity()
    {
        fixed (PxRevoluteJoint* @this = &this)
        { return VirtualMethodTablePointer->getVelocity(@this); }
    }

    public unsafe void setLimit(PxJointAngularLimitPair* limits)
    {
        fixed (PxRevoluteJoint* @this = &this)
        { VirtualMethodTablePointer->setLimit(@this, limits); }
    }

    public unsafe PxJointAngularLimitPair getLimit()
    {
        fixed (PxRevoluteJoint* @this = &this)
        {
            PxJointAngularLimitPair __returnBuffer;
            VirtualMethodTablePointer->getLimit(@this, out __returnBuffer);
            return __returnBuffer;
        }
    }

    public unsafe void setDriveVelocity(float velocity, bool autowake = true)
    {
        fixed (PxRevoluteJoint* @this = &this)
        { VirtualMethodTablePointer->setDriveVelocity(@this, velocity, autowake); }
    }

    public unsafe float getDriveVelocity()
    {
        fixed (PxRevoluteJoint* @this = &this)
        { return VirtualMethodTablePointer->getDriveVelocity(@this); }
    }

    public unsafe void setDriveForceLimit(float limit)
    {
        fixed (PxRevoluteJoint* @this = &this)
        { VirtualMethodTablePointer->setDriveForceLimit(@this, limit); }
    }

    public unsafe float getDriveForceLimit()
    {
        fixed (PxRevoluteJoint* @this = &this)
        { return VirtualMethodTablePointer->getDriveForceLimit(@this); }
    }

    public unsafe void setDriveGearRatio(float ratio)
    {
        fixed (PxRevoluteJoint* @this = &this)
        { VirtualMethodTablePointer->setDriveGearRatio(@this, ratio); }
    }

    public unsafe float getDriveGearRatio()
    {
        fixed (PxRevoluteJoint* @this = &this)
        { return VirtualMethodTablePointer->getDriveGearRatio(@this); }
    }

    public unsafe void setRevoluteJointFlags(PxRevoluteJointFlags flags)
    {
        fixed (PxRevoluteJoint* @this = &this)
        { VirtualMethodTablePointer->setRevoluteJointFlags(@this, flags); }
    }

    public unsafe void setRevoluteJointFlag(PxRevoluteJointFlags flag, bool value)
    {
        fixed (PxRevoluteJoint* @this = &this)
        { VirtualMethodTablePointer->setRevoluteJointFlag(@this, flag, value); }
    }

    public unsafe PxRevoluteJointFlags getRevoluteJointFlags()
    {
        fixed (PxRevoluteJoint* @this = &this)
        { return VirtualMethodTablePointer->getRevoluteJointFlags(@this); }
    }

    public unsafe void setProjectionLinearTolerance(float tolerance)
    {
        fixed (PxRevoluteJoint* @this = &this)
        { VirtualMethodTablePointer->setProjectionLinearTolerance(@this, tolerance); }
    }

    public unsafe float getProjectionLinearTolerance()
    {
        fixed (PxRevoluteJoint* @this = &this)
        { return VirtualMethodTablePointer->getProjectionLinearTolerance(@this); }
    }

    public unsafe void setProjectionAngularTolerance(float tolerance)
    {
        fixed (PxRevoluteJoint* @this = &this)
        { VirtualMethodTablePointer->setProjectionAngularTolerance(@this, tolerance); }
    }

    public unsafe float getProjectionAngularTolerance()
    {
        fixed (PxRevoluteJoint* @this = &this)
        { return VirtualMethodTablePointer->getProjectionAngularTolerance(@this); }
    }

    public unsafe byte* getConcreteTypeName()
    {
        fixed (PxRevoluteJoint* @this = &this)
        { return VirtualMethodTablePointer->getConcreteTypeName(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxRevoluteJoint@physx@@IEAA@GV?$PxFlags@W4Enum@PxBaseFlag@physx@@G@1@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxRevoluteJoint* @this, ushort concreteType, PxBaseFlags baseFlags);

    public unsafe void Constructor(ushort concreteType, PxBaseFlags baseFlags)
    {
        fixed (PxRevoluteJoint* @this = &this)
        { Constructor_PInvoke(@this, concreteType, baseFlags); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxRevoluteJoint@physx@@IEAA@V?$PxFlags@W4Enum@PxBaseFlag@physx@@G@1@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(PxRevoluteJoint* @this, PxBaseFlags baseFlags);

    public unsafe void Constructor(PxBaseFlags baseFlags)
    {
        fixed (PxRevoluteJoint* @this = &this)
        { Constructor_PInvoke(@this, baseFlags); }
    }

    public unsafe bool isKindOf(byte* name)
    {
        fixed (PxRevoluteJoint* @this = &this)
        { return VirtualMethodTablePointer->isKindOf(@this, name); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PxRevoluteJointCreate@physx@@YAPEAVPxRevoluteJoint@1@AEAVPxPhysics@1@PEAVPxRigidActor@1@AEBVPxTransform@1@12@Z", ExactSpelling = true)]
    public static extern PxRevoluteJoint* PxRevoluteJointCreate(PxPhysics* physics, PxRigidActor* actor0, PxTransform* localFrame0, PxRigidActor* actor1, PxTransform* localFrame1);


    [FieldOffset(0)] public VirtualMethodTable* VirtualMethodTablePointer;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VirtualMethodTable
    {
        /// <summary>Virtual method pointer for `release`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, void> release;
        /// <summary>Virtual method pointer for `getConcreteTypeName`</summary>
        public delegate* unmanaged[Cdecl]<PxRevoluteJoint*, byte*> getConcreteTypeName;
        /// <summary>Virtual method pointer for `isReleasable`</summary>
        public delegate* unmanaged[Cdecl]<PxBase*, NativeBoolean> isReleasable;
        /// <summary>Virtual method pointer for `~PxRevoluteJoint`</summary>
        public delegate* unmanaged[Cdecl]<PxRevoluteJoint*, void> __DeletingDestructorPointer;
        /// <summary>Virtual method pointer for `isKindOf`</summary>
        public delegate* unmanaged[Cdecl]<PxRevoluteJoint*, byte*, NativeBoolean> isKindOf;
        /// <summary>Virtual method pointer for `setActors`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, PxRigidActor*, PxRigidActor*, void> setActors;
        /// <summary>Virtual method pointer for `getActors`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, PxRigidActor**, PxRigidActor**, void> getActors;
        /// <summary>Virtual method pointer for `setLocalPose`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, PxJointActorIndex, PxTransform*, void> setLocalPose;
        /// <summary>Virtual method pointer for `getLocalPose`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, out PxTransform, PxJointActorIndex, void> getLocalPose;
        /// <summary>Virtual method pointer for `getRelativeTransform`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, out PxTransform, void> getRelativeTransform;
        /// <summary>Virtual method pointer for `getRelativeLinearVelocity`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, out PxVec3, void> getRelativeLinearVelocity;
        /// <summary>Virtual method pointer for `getRelativeAngularVelocity`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, out PxVec3, void> getRelativeAngularVelocity;
        /// <summary>Virtual method pointer for `setBreakForce`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, float, float, void> setBreakForce;
        /// <summary>Virtual method pointer for `getBreakForce`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, float*, float*, void> getBreakForce;
        /// <summary>Virtual method pointer for `setConstraintFlags`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, PxConstraintFlags, void> setConstraintFlags;
        /// <summary>Virtual method pointer for `setConstraintFlag`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, PxConstraintFlags, NativeBoolean, void> setConstraintFlag;
        /// <summary>Virtual method pointer for `getConstraintFlags`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, PxConstraintFlags> getConstraintFlags;
        /// <summary>Virtual method pointer for `setInvMassScale0`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, float, void> setInvMassScale0;
        /// <summary>Virtual method pointer for `getInvMassScale0`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, float> getInvMassScale0;
        /// <summary>Virtual method pointer for `setInvInertiaScale0`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, float, void> setInvInertiaScale0;
        /// <summary>Virtual method pointer for `getInvInertiaScale0`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, float> getInvInertiaScale0;
        /// <summary>Virtual method pointer for `setInvMassScale1`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, float, void> setInvMassScale1;
        /// <summary>Virtual method pointer for `getInvMassScale1`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, float> getInvMassScale1;
        /// <summary>Virtual method pointer for `setInvInertiaScale1`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, float, void> setInvInertiaScale1;
        /// <summary>Virtual method pointer for `getInvInertiaScale1`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, float> getInvInertiaScale1;
        /// <summary>Virtual method pointer for `getConstraint`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, PxConstraint*> getConstraint;
        /// <summary>Virtual method pointer for `setName`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, byte*, void> setName;
        /// <summary>Virtual method pointer for `getName`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, byte*> getName;
        /// <summary>Virtual method pointer for `getScene`</summary>
        public delegate* unmanaged[Cdecl]<PxJoint*, PxScene*> getScene;
        /// <summary>Virtual method pointer for `getAngle`</summary>
        public delegate* unmanaged[Cdecl]<PxRevoluteJoint*, float> getAngle;
        /// <summary>Virtual method pointer for `getVelocity`</summary>
        public delegate* unmanaged[Cdecl]<PxRevoluteJoint*, float> getVelocity;
        /// <summary>Virtual method pointer for `setLimit`</summary>
        public delegate* unmanaged[Cdecl]<PxRevoluteJoint*, PxJointAngularLimitPair*, void> setLimit;
        /// <summary>Virtual method pointer for `getLimit`</summary>
        public delegate* unmanaged[Cdecl]<PxRevoluteJoint*, out PxJointAngularLimitPair, void> getLimit;
        /// <summary>Virtual method pointer for `setDriveVelocity`</summary>
        public delegate* unmanaged[Cdecl]<PxRevoluteJoint*, float, NativeBoolean, void> setDriveVelocity;
        /// <summary>Virtual method pointer for `getDriveVelocity`</summary>
        public delegate* unmanaged[Cdecl]<PxRevoluteJoint*, float> getDriveVelocity;
        /// <summary>Virtual method pointer for `setDriveForceLimit`</summary>
        public delegate* unmanaged[Cdecl]<PxRevoluteJoint*, float, void> setDriveForceLimit;
        /// <summary>Virtual method pointer for `getDriveForceLimit`</summary>
        public delegate* unmanaged[Cdecl]<PxRevoluteJoint*, float> getDriveForceLimit;
        /// <summary>Virtual method pointer for `setDriveGearRatio`</summary>
        public delegate* unmanaged[Cdecl]<PxRevoluteJoint*, float, void> setDriveGearRatio;
        /// <summary>Virtual method pointer for `getDriveGearRatio`</summary>
        public delegate* unmanaged[Cdecl]<PxRevoluteJoint*, float> getDriveGearRatio;
        /// <summary>Virtual method pointer for `setRevoluteJointFlags`</summary>
        public delegate* unmanaged[Cdecl]<PxRevoluteJoint*, PxRevoluteJointFlags, void> setRevoluteJointFlags;
        /// <summary>Virtual method pointer for `setRevoluteJointFlag`</summary>
        public delegate* unmanaged[Cdecl]<PxRevoluteJoint*, PxRevoluteJointFlags, NativeBoolean, void> setRevoluteJointFlag;
        /// <summary>Virtual method pointer for `getRevoluteJointFlags`</summary>
        public delegate* unmanaged[Cdecl]<PxRevoluteJoint*, PxRevoluteJointFlags> getRevoluteJointFlags;
        /// <summary>Virtual method pointer for `setProjectionLinearTolerance`</summary>
        public delegate* unmanaged[Cdecl]<PxRevoluteJoint*, float, void> setProjectionLinearTolerance;
        /// <summary>Virtual method pointer for `getProjectionLinearTolerance`</summary>
        public delegate* unmanaged[Cdecl]<PxRevoluteJoint*, float> getProjectionLinearTolerance;
        /// <summary>Virtual method pointer for `setProjectionAngularTolerance`</summary>
        public delegate* unmanaged[Cdecl]<PxRevoluteJoint*, float, void> setProjectionAngularTolerance;
        /// <summary>Virtual method pointer for `getProjectionAngularTolerance`</summary>
        public delegate* unmanaged[Cdecl]<PxRevoluteJoint*, float> getProjectionAngularTolerance;
    }
}
