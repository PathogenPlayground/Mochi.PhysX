// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Runtime.InteropServices;

namespace Mochi.PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public unsafe partial struct PxControllerStats
    {
        [FieldOffset(0)] public ushort nbIterations;

        [FieldOffset(2)] public ushort nbFullUpdates;

        [FieldOffset(4)] public ushort nbPartialUpdates;

        [FieldOffset(6)] public ushort nbTessellation;
    }
}
