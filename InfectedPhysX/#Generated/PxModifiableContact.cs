// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Runtime.InteropServices;

namespace Mochi.PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct PxModifiableContact
    {
        [FieldOffset(0)] public PxExtendedContact Base;

        [FieldOffset(32)] public PxVec3 normal;

        [FieldOffset(44)] public float restitution;

        [FieldOffset(48)] public uint materialFlags;

        [FieldOffset(52)] public ushort materialIndex0;

        [FieldOffset(54)] public ushort materialIndex1;

        [FieldOffset(56)] public float staticFriction;

        [FieldOffset(60)] public float dynamicFriction;
    }
}
