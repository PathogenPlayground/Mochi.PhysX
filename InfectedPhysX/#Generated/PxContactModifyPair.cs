// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using Mochi.PhysX.Infrastructure;
using System.Runtime.InteropServices;

namespace Mochi.PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public unsafe partial struct PxContactModifyPair
    {
        [FieldOffset(0)] public ConstantArray_const__UNICODE_0020__physx__UNICODE_003A____UNICODE_003A__PxRigidActor__UNICODE_0020____UNICODE_002A___2 actor;

        [FieldOffset(16)] public ConstantArray_const__UNICODE_0020__physx__UNICODE_003A____UNICODE_003A__PxShape__UNICODE_0020____UNICODE_002A___2 shape;

        [FieldOffset(32)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxTransform_2 transform;

        [FieldOffset(88)] public PxContactSet contacts;
    }
}
