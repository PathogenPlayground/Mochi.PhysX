// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Runtime.InteropServices;

namespace Mochi.PhysX
{
    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public unsafe partial struct PxStringTableExt
    {
        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?createStringTable@PxStringTableExt@physx@@SAAEAVPxStringTable@2@AEAVPxAllocatorCallback@2@@Z", ExactSpelling = true)]
        public static extern PxStringTable* createStringTable(PxAllocatorCallback* inAllocator);
    }
}
