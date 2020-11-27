// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 1)]
public unsafe partial struct PxSceneQueryExt
{
    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?raycastAny@PxSceneQueryExt@physx@@SA_NAEBVPxScene@2@AEBVPxVec3@2@1MAEAUPxQueryHit@2@AEBUPxQueryFilterData@2@PEAVPxQueryFilterCallback@2@PEBUPxQueryCache@2@@Z", ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.I1)]
    public static extern bool raycastAny(PxScene* scene, PxVec3* origin, PxVec3* unitDir, float distance, PxQueryHit* hit, PxQueryFilterData* filterData, PxQueryFilterCallback* filterCall = null, PxQueryCache* cache = null);

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?raycastSingle@PxSceneQueryExt@physx@@SA_NAEBVPxScene@2@AEBVPxVec3@2@1MV?$PxFlags@W4Enum@PxHitFlag@physx@@G@2@AEAUPxRaycastHit@2@AEBUPxQueryFilterData@2@PEAVPxQueryFilterCallback@2@PEBUPxQueryCache@2@@Z", ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.I1)]
    public static extern bool raycastSingle(PxScene* scene, PxVec3* origin, PxVec3* unitDir, float distance, /* Failed to emit TranslatedParameter outputFlags: Failed to resolve `Ref resolved by PxFlags` during emit time. */
    int outputFlags, PxRaycastHit* hit, PxQueryFilterData* filterData, PxQueryFilterCallback* filterCall = null, PxQueryCache* cache = null);

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?raycastMultiple@PxSceneQueryExt@physx@@SAHAEBVPxScene@2@AEBVPxVec3@2@1MV?$PxFlags@W4Enum@PxHitFlag@physx@@G@2@PEAUPxRaycastHit@2@IAEA_NAEBUPxQueryFilterData@2@PEAVPxQueryFilterCallback@2@PEBUPxQueryCache@2@@Z", ExactSpelling = true)]
    public static extern int raycastMultiple(PxScene* scene, PxVec3* origin, PxVec3* unitDir, float distance, /* Failed to emit TranslatedParameter outputFlags: Failed to resolve `Ref resolved by PxFlags` during emit time. */
    int outputFlags, PxRaycastHit* hitBuffer, uint hitBufferSize, bool* blockingHit, PxQueryFilterData* filterData, PxQueryFilterCallback* filterCall = null, PxQueryCache* cache = null);

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?sweepAny@PxSceneQueryExt@physx@@SA_NAEBVPxScene@2@AEBVPxGeometry@2@AEBVPxTransform@2@AEBVPxVec3@2@MV?$PxFlags@W4Enum@PxHitFlag@physx@@G@2@AEAUPxQueryHit@2@AEBUPxQueryFilterData@2@PEAVPxQueryFilterCallback@2@PEBUPxQueryCache@2@M@Z", ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.I1)]
    public static extern bool sweepAny(PxScene* scene, PxGeometry* geometry, PxTransform* pose, PxVec3* unitDir, float distance, /* Failed to emit TranslatedParameter queryFlags: Failed to resolve `Ref resolved by PxFlags` during emit time. */
    int queryFlags, PxQueryHit* hit, PxQueryFilterData* filterData, PxQueryFilterCallback* filterCall = null, PxQueryCache* cache = null, float inflation = 0f);

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?sweepSingle@PxSceneQueryExt@physx@@SA_NAEBVPxScene@2@AEBVPxGeometry@2@AEBVPxTransform@2@AEBVPxVec3@2@MV?$PxFlags@W4Enum@PxHitFlag@physx@@G@2@AEAUPxSweepHit@2@AEBUPxQueryFilterData@2@PEAVPxQueryFilterCallback@2@PEBUPxQueryCache@2@M@Z", ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.I1)]
    public static extern bool sweepSingle(PxScene* scene, PxGeometry* geometry, PxTransform* pose, PxVec3* unitDir, float distance, /* Failed to emit TranslatedParameter outputFlags: Failed to resolve `Ref resolved by PxFlags` during emit time. */
    int outputFlags, PxSweepHit* hit, PxQueryFilterData* filterData, PxQueryFilterCallback* filterCall = null, PxQueryCache* cache = null, float inflation = 0f);

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?sweepMultiple@PxSceneQueryExt@physx@@SAHAEBVPxScene@2@AEBVPxGeometry@2@AEBVPxTransform@2@AEBVPxVec3@2@MV?$PxFlags@W4Enum@PxHitFlag@physx@@G@2@PEAUPxSweepHit@2@IAEA_NAEBUPxQueryFilterData@2@PEAVPxQueryFilterCallback@2@PEBUPxQueryCache@2@M@Z", ExactSpelling = true)]
    public static extern int sweepMultiple(PxScene* scene, PxGeometry* geometry, PxTransform* pose, PxVec3* unitDir, float distance, /* Failed to emit TranslatedParameter outputFlags: Failed to resolve `Ref resolved by PxFlags` during emit time. */
    int outputFlags, PxSweepHit* hitBuffer, uint hitBufferSize, bool* blockingHit, PxQueryFilterData* filterData, PxQueryFilterCallback* filterCall = null, PxQueryCache* cache = null, float inflation = 0f);

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?overlapMultiple@PxSceneQueryExt@physx@@SAHAEBVPxScene@2@AEBVPxGeometry@2@AEBVPxTransform@2@PEAUPxOverlapHit@2@IAEBUPxQueryFilterData@2@PEAVPxQueryFilterCallback@2@@Z", ExactSpelling = true)]
    public static extern int overlapMultiple(PxScene* scene, PxGeometry* geometry, PxTransform* pose, PxOverlapHit* hitBuffer, uint hitBufferSize, PxQueryFilterData* filterData, PxQueryFilterCallback* filterCall = null);

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?overlapAny@PxSceneQueryExt@physx@@SA_NAEBVPxScene@2@AEBVPxGeometry@2@AEBVPxTransform@2@AEAUPxOverlapHit@2@AEBUPxQueryFilterData@2@PEAVPxQueryFilterCallback@2@@Z", ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.I1)]
    public static extern bool overlapAny(PxScene* scene, PxGeometry* geometry, PxTransform* pose, PxOverlapHit* hit, PxQueryFilterData* filterData, PxQueryFilterCallback* filterCall = null);
}
