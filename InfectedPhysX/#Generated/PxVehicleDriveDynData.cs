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
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public unsafe partial struct PxVehicleDriveDynData
    {
        public const int eMAX_NB_ANALOG_INPUTS = 16;

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setToRestState@PxVehicleDriveDynData@physx@@QEAAXXZ", ExactSpelling = true)]
        private static extern void setToRestState_PInvoke(PxVehicleDriveDynData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setToRestState()
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { setToRestState_PInvoke(@this); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setAnalogInput@PxVehicleDriveDynData@physx@@QEAAXIM@Z", ExactSpelling = true)]
        private static extern void setAnalogInput_PInvoke(PxVehicleDriveDynData* @this, uint type, float analogVal);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setAnalogInput(uint type, float analogVal)
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { setAnalogInput_PInvoke(@this, type, analogVal); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getAnalogInput@PxVehicleDriveDynData@physx@@QEBAMI@Z", ExactSpelling = true)]
        private static extern float getAnalogInput_PInvoke(PxVehicleDriveDynData* @this, uint type);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float getAnalogInput(uint type)
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { return getAnalogInput_PInvoke(@this, type); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setGearUp@PxVehicleDriveDynData@physx@@QEAAX_N@Z", ExactSpelling = true)]
        private static extern void setGearUp_PInvoke(PxVehicleDriveDynData* @this, [MarshalAs(UnmanagedType.I1)] bool digitalVal);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setGearUp(bool digitalVal)
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { setGearUp_PInvoke(@this, digitalVal); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setGearDown@PxVehicleDriveDynData@physx@@QEAAX_N@Z", ExactSpelling = true)]
        private static extern void setGearDown_PInvoke(PxVehicleDriveDynData* @this, [MarshalAs(UnmanagedType.I1)] bool digitalVal);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setGearDown(bool digitalVal)
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { setGearDown_PInvoke(@this, digitalVal); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getGearUp@PxVehicleDriveDynData@physx@@QEBA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool getGearUp_PInvoke(PxVehicleDriveDynData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool getGearUp()
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { return getGearUp_PInvoke(@this); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getGearDown@PxVehicleDriveDynData@physx@@QEBA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool getGearDown_PInvoke(PxVehicleDriveDynData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool getGearDown()
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { return getGearDown_PInvoke(@this); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setUseAutoGears@PxVehicleDriveDynData@physx@@QEAAX_N@Z", ExactSpelling = true)]
        private static extern void setUseAutoGears_PInvoke(PxVehicleDriveDynData* @this, [MarshalAs(UnmanagedType.I1)] bool useAutoGears);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setUseAutoGears(bool useAutoGears)
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { setUseAutoGears_PInvoke(@this, useAutoGears); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getUseAutoGears@PxVehicleDriveDynData@physx@@QEBA_NXZ", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool getUseAutoGears_PInvoke(PxVehicleDriveDynData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool getUseAutoGears()
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { return getUseAutoGears_PInvoke(@this); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?toggleAutoGears@PxVehicleDriveDynData@physx@@QEAAXXZ", ExactSpelling = true)]
        private static extern void toggleAutoGears_PInvoke(PxVehicleDriveDynData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void toggleAutoGears()
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { toggleAutoGears_PInvoke(@this); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setCurrentGear@PxVehicleDriveDynData@physx@@QEAAXI@Z", ExactSpelling = true)]
        private static extern void setCurrentGear_PInvoke(PxVehicleDriveDynData* @this, uint currentGear);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setCurrentGear(uint currentGear)
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { setCurrentGear_PInvoke(@this, currentGear); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getCurrentGear@PxVehicleDriveDynData@physx@@QEBAIXZ", ExactSpelling = true)]
        private static extern uint getCurrentGear_PInvoke(PxVehicleDriveDynData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getCurrentGear()
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { return getCurrentGear_PInvoke(@this); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setTargetGear@PxVehicleDriveDynData@physx@@QEAAXI@Z", ExactSpelling = true)]
        private static extern void setTargetGear_PInvoke(PxVehicleDriveDynData* @this, uint targetGear);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setTargetGear(uint targetGear)
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { setTargetGear_PInvoke(@this, targetGear); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getTargetGear@PxVehicleDriveDynData@physx@@QEBAIXZ", ExactSpelling = true)]
        private static extern uint getTargetGear_PInvoke(PxVehicleDriveDynData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getTargetGear()
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { return getTargetGear_PInvoke(@this); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?startGearChange@PxVehicleDriveDynData@physx@@QEAAXI@Z", ExactSpelling = true)]
        private static extern void startGearChange_PInvoke(PxVehicleDriveDynData* @this, uint targetGear);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void startGearChange(uint targetGear)
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { startGearChange_PInvoke(@this, targetGear); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?forceGearChange@PxVehicleDriveDynData@physx@@QEAAXI@Z", ExactSpelling = true)]
        private static extern void forceGearChange_PInvoke(PxVehicleDriveDynData* @this, uint targetGear);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void forceGearChange(uint targetGear)
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { forceGearChange_PInvoke(@this, targetGear); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setEngineRotationSpeed@PxVehicleDriveDynData@physx@@QEAAXM@Z", ExactSpelling = true)]
        private static extern void setEngineRotationSpeed_PInvoke(PxVehicleDriveDynData* @this, float speed);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setEngineRotationSpeed(float speed)
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { setEngineRotationSpeed_PInvoke(@this, speed); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getEngineRotationSpeed@PxVehicleDriveDynData@physx@@QEBAMXZ", ExactSpelling = true)]
        private static extern float getEngineRotationSpeed_PInvoke(PxVehicleDriveDynData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float getEngineRotationSpeed()
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { return getEngineRotationSpeed_PInvoke(@this); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getGearSwitchTime@PxVehicleDriveDynData@physx@@QEBAMXZ", ExactSpelling = true)]
        private static extern float getGearSwitchTime_PInvoke(PxVehicleDriveDynData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float getGearSwitchTime()
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { return getGearSwitchTime_PInvoke(@this); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getAutoBoxSwitchTime@PxVehicleDriveDynData@physx@@QEBAMXZ", ExactSpelling = true)]
        private static extern float getAutoBoxSwitchTime_PInvoke(PxVehicleDriveDynData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float getAutoBoxSwitchTime()
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { return getAutoBoxSwitchTime_PInvoke(@this); }
        }

        [FieldOffset(0)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxReal_16 mControlAnalogVals;

        [FieldOffset(64)] [MarshalAs(UnmanagedType.I1)] public bool mUseAutoGears;

        [FieldOffset(65)] [MarshalAs(UnmanagedType.I1)] public bool mGearUpPressed;

        [FieldOffset(66)] [MarshalAs(UnmanagedType.I1)] public bool mGearDownPressed;

        [FieldOffset(68)] public uint mCurrentGear;

        [FieldOffset(72)] public uint mTargetGear;

        [FieldOffset(76)] public float mEnginespeed;

        [FieldOffset(80)] public float mGearSwitchTime;

        [FieldOffset(84)] public float mAutoBoxSwitchTime;

        [FieldOffset(88)] public ConstantArray_physx__UNICODE_003A____UNICODE_003A__PxU32_2 mPad;

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0PxVehicleDriveDynData@physx@@QEAA@XZ", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxVehicleDriveDynData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Constructor()
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper214", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(PxVehicleDriveDynData* @this, PxEMPTY arg0);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Constructor(PxEMPTY arg0)
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { Constructor_PInvoke(@this, arg0); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getNbAnalogInput@PxVehicleDriveDynData@physx@@QEBAIXZ", ExactSpelling = true)]
        private static extern uint getNbAnalogInput_PInvoke(PxVehicleDriveDynData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getNbAnalogInput()
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { return getNbAnalogInput_PInvoke(@this); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setGearChange@PxVehicleDriveDynData@physx@@QEAAXI@Z", ExactSpelling = true)]
        private static extern void setGearChange_PInvoke(PxVehicleDriveDynData* @this, uint gearChange);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setGearChange(uint gearChange)
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { setGearChange_PInvoke(@this, gearChange); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?getGearChange@PxVehicleDriveDynData@physx@@QEBAIXZ", ExactSpelling = true)]
        private static extern uint getGearChange_PInvoke(PxVehicleDriveDynData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint getGearChange()
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { return getGearChange_PInvoke(@this); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setGearSwitchTime@PxVehicleDriveDynData@physx@@QEAAXM@Z", ExactSpelling = true)]
        private static extern void setGearSwitchTime_PInvoke(PxVehicleDriveDynData* @this, float switchTime);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setGearSwitchTime(float switchTime)
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { setGearSwitchTime_PInvoke(@this, switchTime); }
        }

        [DllImport("Mochi.PhysX.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?setAutoBoxSwitchTime@PxVehicleDriveDynData@physx@@QEAAXM@Z", ExactSpelling = true)]
        private static extern void setAutoBoxSwitchTime_PInvoke(PxVehicleDriveDynData* @this, float autoBoxSwitchTime);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void setAutoBoxSwitchTime(float autoBoxSwitchTime)
        {
            fixed (PxVehicleDriveDynData* @this = &this)
            { setAutoBoxSwitchTime_PInvoke(@this, autoBoxSwitchTime); }
        }
    }
}
