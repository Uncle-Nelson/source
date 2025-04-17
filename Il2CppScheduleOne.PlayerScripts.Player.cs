using System;
using System.Runtime.CompilerServices;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.AvatarFramework.Animation;
using Il2CppScheduleOne.AvatarFramework.Customization;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Money;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.PlayerScripts.Health;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Skating;
using Il2CppScheduleOne.Stealth;
using Il2CppScheduleOne.Tools;
using Il2CppScheduleOne.UI;
using Il2CppScheduleOne.Variables;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.PlayerScripts
{
    public class Player : NetworkBehaviour
    {
        public sealed class VehicleEvent : Il2CppSystem.MulticastDelegate
        {
            private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

            private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LandVehicle_0;

            private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LandVehicle_AsyncCallback_Object_0;

            private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

            static VehicleEvent()
            {
                Il2CppClassPointerStore<VehicleEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player>.NativeClassPtr, "VehicleEvent");
                NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleEvent>.NativeClassPtr, 100673166);
                NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleEvent>.NativeClassPtr, 100673167);
                NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LandVehicle_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleEvent>.NativeClassPtr, 100673168);
                NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleEvent>.NativeClassPtr, 100673169);
            }

            [CallerCount(79)]
            [CachedScanResults(RefRangeStart = 106407, RefRangeEnd = 106486, XrefRangeStart = 106407, XrefRangeEnd = 106486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            public unsafe VehicleEvent(Il2CppSystem.Object @object, System.IntPtr method)
                : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleEvent>.NativeClassPtr))
            {
                System.IntPtr* ptr = stackalloc System.IntPtr[2];
                *ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
                *(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }

            [CallerCount(0)]
            public unsafe virtual void Invoke(LandVehicle vehicle)
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }

            [CallerCount(1)]
            [CachedScanResults(RefRangeStart = 74821, RefRangeEnd = 74822, XrefRangeStart = 74821, XrefRangeEnd = 74822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            public unsafe virtual Il2CppSystem.IAsyncResult BeginInvoke(LandVehicle vehicle, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[3];
                *ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
                *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callback);
                *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(@object);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LandVehicle_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr) : null;
            }

            [CallerCount(1)]
            [CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            public unsafe virtual void EndInvoke(Il2CppSystem.IAsyncResult result)
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }

            public VehicleEvent(System.IntPtr pointer)
                : base(pointer)
            {
            }

            public static implicit operator VehicleEvent(System.Action<LandVehicle> P_0)
            {
                return DelegateSupport.ConvertDelegate<VehicleEvent>(P_0);
            }

            public static VehicleEvent operator +(VehicleEvent P_0, VehicleEvent P_1)
            {
                return Il2CppSystem.Delegate.Combine(P_0, P_1).Cast<VehicleEvent>();
            }

            public static VehicleEvent operator -(VehicleEvent P_0, VehicleEvent P_1)
            {
                object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
                if (obj != null)
                {
                    obj = ((Il2CppObjectBase)obj).Cast<VehicleEvent>();
                }

                return (VehicleEvent)obj;
            }
        }

        public sealed class VehicleTransformEvent : Il2CppSystem.MulticastDelegate
        {
            private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

            private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LandVehicle_Transform_0;

            private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LandVehicle_Transform_AsyncCallback_Object_0;

            private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

            static VehicleTransformEvent()
            {
                Il2CppClassPointerStore<VehicleTransformEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player>.NativeClassPtr, "VehicleTransformEvent");
                NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleTransformEvent>.NativeClassPtr, 100673170);
                NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LandVehicle_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleTransformEvent>.NativeClassPtr, 100673171);
                NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LandVehicle_Transform_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleTransformEvent>.NativeClassPtr, 100673172);
                NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleTransformEvent>.NativeClassPtr, 100673173);
            }

            [CallerCount(177)]
            [CachedScanResults(RefRangeStart = 165953, RefRangeEnd = 166130, XrefRangeStart = 165944, XrefRangeEnd = 165953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            public unsafe VehicleTransformEvent(Il2CppSystem.Object @object, System.IntPtr method)
                : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleTransformEvent>.NativeClassPtr))
            {
                System.IntPtr* ptr = stackalloc System.IntPtr[2];
                *ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
                *(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }

            [CallerCount(0)]
            public unsafe virtual void Invoke(LandVehicle vehicle, Transform exitPoint)
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[2];
                *ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
                *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(exitPoint);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LandVehicle_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }

            [CallerCount(0)]
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            public unsafe virtual Il2CppSystem.IAsyncResult BeginInvoke(LandVehicle vehicle, Transform exitPoint, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[4];
                *ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
                *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(exitPoint);
                *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callback);
                *(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(@object);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LandVehicle_Transform_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr) : null;
            }

            [CallerCount(1)]
            [CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            public unsafe virtual void EndInvoke(Il2CppSystem.IAsyncResult result)
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }

            public VehicleTransformEvent(System.IntPtr pointer)
                : base(pointer)
            {
            }

            public static implicit operator VehicleTransformEvent(System.Action<LandVehicle, Transform> P_0)
            {
                return DelegateSupport.ConvertDelegate<VehicleTransformEvent>(P_0);
            }

            public static VehicleTransformEvent operator +(VehicleTransformEvent P_0, VehicleTransformEvent P_1)
            {
                return Il2CppSystem.Delegate.Combine(P_0, P_1).Cast<VehicleTransformEvent>();
            }

            public static VehicleTransformEvent operator -(VehicleTransformEvent P_0, VehicleTransformEvent P_1)
            {
                object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
                if (obj != null)
                {
                    obj = ((Il2CppObjectBase)obj).Cast<VehicleTransformEvent>();
                }

                return (VehicleTransformEvent)obj;
            }
        }

        [ObfuscatedName("ScheduleOne.PlayerScripts.Player+<<Taze>g__Tase|319_0>d")]
        public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique : Il2CppSystem.Object
        {
            private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

            private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

            private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

            private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

            private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

            private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

            private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

            private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

            private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

            public unsafe int __1__state
            {
                get
                {
                    nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
                    return *(int*)num;
                }
                set
                {
                    *(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = value;
                }
            }

            public unsafe Il2CppSystem.Object __2__current
            {
                get
                {
                    nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
                    System.IntPtr intPtr = *(System.IntPtr*)num;
                    return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
                }
                set
                {
                    System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                    IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
                }
            }

            public unsafe Player __4__this
            {
                get
                {
                    nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
                    System.IntPtr intPtr = *(System.IntPtr*)num;
                    return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Player>(intPtr) : null;
                }
                set
                {
                    System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                    IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
                }
            }

            public unsafe virtual Il2CppSystem.Object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
            {
                [CallerCount(14)]
                [CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
                get
                {
                    IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                    System.IntPtr* param = null;
                    System.IntPtr exc;
                    System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                    Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                    return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
                }
            }

            public unsafe virtual Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
            {
                [CallerCount(14)]
                [CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
                get
                {
                    IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                    System.IntPtr* param = null;
                    System.IntPtr exc;
                    System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                    Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                    return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
                }
            }

            static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique()
            {
                Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player>.NativeClassPtr, "<<Taze>g__Tase|319_0>d");
                IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr);
                NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, "<>1__state");
                NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, "<>2__current");
                NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, "<>4__this");
                NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100673174);
                NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100673175);
                NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100673176);
                NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100673177);
                NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100673178);
                NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100673179);
            }

            [CallerCount(61)]
            [CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique(int _003C_003E1__state)
                : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr))
            {
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = (nint)(&_003C_003E1__state);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }

            [CallerCount(13604)]
            [CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            public unsafe virtual void System_IDisposable_Dispose()
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }

            [CallerCount(0)]
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166130, XrefRangeEnd = 166136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            public unsafe virtual bool MoveNext()
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
            }

            [CallerCount(0)]
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166136, XrefRangeEnd = 166141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            public unsafe virtual void System_Collections_IEnumerator_Reset()
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }

            public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique(System.IntPtr pointer)
                : base(pointer)
            {
            }
        }

        [ObfuscatedName("ScheduleOne.PlayerScripts.Player+<>c__DisplayClass222_0")]
        public sealed class __c__DisplayClass222_0 : Il2CppSystem.Object
        {
            private static readonly System.IntPtr NativeFieldInfoPtr_playerCode;

            private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

            private static readonly System.IntPtr NativeMethodInfoPtr__GetPlayer_b__0_Internal_Boolean_Player_0;

            public unsafe string playerCode
            {
                get
                {
                    nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerCode);
                    return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
                }
                set
                {
                    System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                    IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerCode), IL2CPP.ManagedStringToIl2Cpp(value));
                }
            }

            static __c__DisplayClass222_0()
            {
                Il2CppClassPointerStore<__c__DisplayClass222_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player>.NativeClassPtr, "<>c__DisplayClass222_0");
                IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass222_0>.NativeClassPtr);
                NativeFieldInfoPtr_playerCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass222_0>.NativeClassPtr, "playerCode");
                NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass222_0>.NativeClassPtr, 100673180);
                NativeMethodInfoPtr__GetPlayer_b__0_Internal_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass222_0>.NativeClassPtr, 100673181);
            }

            [CallerCount(2259)]
            [CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            public unsafe __c__DisplayClass222_0()
                : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass222_0>.NativeClassPtr))
            {
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }

            [CallerCount(0)]
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166141, XrefRangeEnd = 166144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            public unsafe bool _GetPlayer_b__0(Player x)
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetPlayer_b__0_Internal_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
            }

            public __c__DisplayClass222_0(System.IntPtr pointer)
                : base(pointer)
            {
            }
        }

        [ObfuscatedName("ScheduleOne.PlayerScripts.Player+<>c__DisplayClass277_0")]
        public sealed class __c__DisplayClass277_0 : Il2CppSystem.Object
        {
            private static readonly System.IntPtr NativeFieldInfoPtr_point;

            private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

            private static readonly System.IntPtr NativeMethodInfoPtr__GetClosestPlayer_b__0_Internal_Single_Player_0;

            public unsafe Vector3 point
            {
                get
                {
                    nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_point);
                    return *(Vector3*)num;
                }
                set
                {
                    *(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_point)) = value;
                }
            }

            static __c__DisplayClass277_0()
            {
                Il2CppClassPointerStore<__c__DisplayClass277_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player>.NativeClassPtr, "<>c__DisplayClass277_0");
                IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass277_0>.NativeClassPtr);
                NativeFieldInfoPtr_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass277_0>.NativeClassPtr, "point");
                NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass277_0>.NativeClassPtr, 100673182);
                NativeMethodInfoPtr__GetClosestPlayer_b__0_Internal_Single_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass277_0>.NativeClassPtr, 100673183);
            }

            [CallerCount(2259)]
            [CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            public unsafe __c__DisplayClass277_0()
                : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass277_0>.NativeClassPtr))
            {
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }

            [CallerCount(0)]
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166144, XrefRangeEnd = 166145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            public unsafe float _GetClosestPlayer_b__0(Player x)
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetClosestPlayer_b__0_Internal_Single_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(float*)IL2CPP.il2cpp_object_unbox(obj);
            }

            public __c__DisplayClass277_0(System.IntPtr pointer)
                : base(pointer)
            {
            }
        }

        [ObfuscatedName("ScheduleOne.PlayerScripts.Player+<>c__DisplayClass281_0")]
        public sealed class __c__DisplayClass281_0 : Il2CppSystem.Object
        {
            [ObfuscatedName("ScheduleOne.PlayerScripts.Player+<>c__DisplayClass281_0+<<SetScale>g__LerpScale|0>d")]
            public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
            {
                private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

                private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

                private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

                private static readonly System.IntPtr NativeFieldInfoPtr__i_5__2;

                private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

                private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

                private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

                private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

                private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

                private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

                public unsafe int __1__state
                {
                    get
                    {
                        nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
                        return *(int*)num;
                    }
                    set
                    {
                        *(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = value;
                    }
                }

                public unsafe Il2CppSystem.Object __2__current
                {
                    get
                    {
                        nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
                        System.IntPtr intPtr = *(System.IntPtr*)num;
                        return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
                    }
                    set
                    {
                        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                        IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
                    }
                }

                public unsafe __c__DisplayClass281_0 __4__this
                {
                    get
                    {
                        nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
                        System.IntPtr intPtr = *(System.IntPtr*)num;
                        return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c__DisplayClass281_0>(intPtr) : null;
                    }
                    set
                    {
                        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                        IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
                    }
                }

                public unsafe float _i_5__2
                {
                    get
                    {
                        nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__i_5__2);
                        return *(float*)num;
                    }
                    set
                    {
                        *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__i_5__2)) = value;
                    }
                }

                public unsafe virtual Il2CppSystem.Object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
                {
                    [CallerCount(14)]
                    [CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
                    get
                    {
                        IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                        System.IntPtr* param = null;
                        System.IntPtr exc;
                        System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                        return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
                    }
                }

                public unsafe virtual Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
                {
                    [CallerCount(14)]
                    [CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
                    get
                    {
                        IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                        System.IntPtr* param = null;
                        System.IntPtr exc;
                        System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                        return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
                    }
                }

                static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
                {
                    Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<__c__DisplayClass281_0>.NativeClassPtr, "<<SetScale>g__LerpScale|0>d");
                    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
                    NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
                    NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
                    NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
                    NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<i>5__2");
                    NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673186);
                    NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673187);
                    NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673188);
                    NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673189);
                    NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673190);
                    NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673191);
                }

                [CallerCount(61)]
                [CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
                public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int _003C_003E1__state)
                    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
                {
                    System.IntPtr* ptr = stackalloc System.IntPtr[1];
                    *ptr = (nint)(&_003C_003E1__state);
                    System.IntPtr exc;
                    System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                    Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                }

                [CallerCount(13604)]
                [CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
                public unsafe virtual void System_IDisposable_Dispose()
                {
                    IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                    System.IntPtr* param = null;
                    System.IntPtr exc;
                    System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                    Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                }

                [CallerCount(0)]
                [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166145, XrefRangeEnd = 166154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
                public unsafe virtual bool MoveNext()
                {
                    IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                    System.IntPtr* param = null;
                    System.IntPtr exc;
                    System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                    Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                    return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
                }

                [CallerCount(0)]
                [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166154, XrefRangeEnd = 166159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
                public unsafe virtual void System_Collections_IEnumerator_Reset()
                {
                    IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                    System.IntPtr* param = null;
                    System.IntPtr exc;
                    System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                    Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                }

                public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(System.IntPtr pointer)
                    : base(pointer)
                {
                }
            }

            private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

            private static readonly System.IntPtr NativeFieldInfoPtr_startScale;

            private static readonly System.IntPtr NativeFieldInfoPtr_scale;

            private static readonly System.IntPtr NativeFieldInfoPtr_lerpTime;

            private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

            private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

            public unsafe Player __4__this
            {
                get
                {
                    nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
                    System.IntPtr intPtr = *(System.IntPtr*)num;
                    return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Player>(intPtr) : null;
                }
                set
                {
                    System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                    IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
                }
            }

            public unsafe float startScale
            {
                get
                {
                    nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startScale);
                    return *(float*)num;
                }
                set
                {
                    *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startScale)) = value;
                }
            }

            public unsafe float scale
            {
                get
                {
                    nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scale);
                    return *(float*)num;
                }
                set
                {
                    *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scale)) = value;
                }
            }

            public unsafe float lerpTime
            {
                get
                {
                    nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lerpTime);
                    return *(float*)num;
                }
                set
                {
                    *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lerpTime)) = value;
                }
            }

            static __c__DisplayClass281_0()
            {
                Il2CppClassPointerStore<__c__DisplayClass281_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player>.NativeClassPtr, "<>c__DisplayClass281_0");
                IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass281_0>.NativeClassPtr);
                NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass281_0>.NativeClassPtr, "<>4__this");
                NativeFieldInfoPtr_startScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass281_0>.NativeClassPtr, "startScale");
                NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass281_0>.NativeClassPtr, "scale");
                NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass281_0>.NativeClassPtr, "lerpTime");
                NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass281_0>.NativeClassPtr, 100673184);
                NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass281_0>.NativeClassPtr, 100673185);
            }

            [CallerCount(2259)]
            [CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            public unsafe __c__DisplayClass281_0()
                : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass281_0>.NativeClassPtr))
            {
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }

            [CallerCount(1)]
            [CachedScanResults(RefRangeStart = 166164, RefRangeEnd = 166165, XrefRangeStart = 166159, XrefRangeEnd = 166164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            public unsafe IEnumerator Method_Internal_IEnumerator_0()
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
            }

            public __c__DisplayClass281_0(System.IntPtr pointer)
                : base(pointer)
            {
            }
        }

        private sealed class MethodInfoStoreGeneric_GetValue_Public_T_String_0<T>
        {
            internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetValue_Public_T_String_0, Il2CppClassPointerStore<Player>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
        }

        private static readonly System.IntPtr NativeFieldInfoPtr_OWNER_PLAYER_CODE;

        private static readonly System.IntPtr NativeFieldInfoPtr_CapColDefaultHeight;

        private static readonly System.IntPtr NativeFieldInfoPtr_objectsTemporarilyOwnedByPlayer;

        private static readonly System.IntPtr NativeFieldInfoPtr_onLocalPlayerSpawned;

        private static readonly System.IntPtr NativeFieldInfoPtr_onPlayerSpawned;

        private static readonly System.IntPtr NativeFieldInfoPtr_onPlayerDespawned;

        private static readonly System.IntPtr NativeFieldInfoPtr_Local;

        private static readonly System.IntPtr NativeFieldInfoPtr_PlayerList;

        private static readonly System.IntPtr NativeFieldInfoPtr_LocalGameObject;

        private static readonly System.IntPtr NativeFieldInfoPtr_Avatar;

        private static readonly System.IntPtr NativeFieldInfoPtr_Anim;

        private static readonly System.IntPtr NativeFieldInfoPtr_VelocityCalculator;

        private static readonly System.IntPtr NativeFieldInfoPtr_EyePosition;

        private static readonly System.IntPtr NativeFieldInfoPtr_TestAvatarSettings;

        private static readonly System.IntPtr NativeFieldInfoPtr_VisualState;

        private static readonly System.IntPtr NativeFieldInfoPtr_Visibility;

        private static readonly System.IntPtr NativeFieldInfoPtr_CapCol;

        private static readonly System.IntPtr NativeFieldInfoPtr_PoI;

        private static readonly System.IntPtr NativeFieldInfoPtr_Health;

        private static readonly System.IntPtr NativeFieldInfoPtr_CrimeData;

        private static readonly System.IntPtr NativeFieldInfoPtr_Energy;

        private static readonly System.IntPtr NativeFieldInfoPtr_MimicCamera;

        private static readonly System.IntPtr NativeFieldInfoPtr_FootstepDetector;

        private static readonly System.IntPtr NativeFieldInfoPtr_LocalFootstepDetector;

        private static readonly System.IntPtr NativeFieldInfoPtr_CharacterController;

        private static readonly System.IntPtr NativeFieldInfoPtr_PunchSound;

        private static readonly System.IntPtr NativeFieldInfoPtr_ThirdPersonFlashlight;

        private static readonly System.IntPtr NativeFieldInfoPtr_NameLabel;

        private static readonly System.IntPtr NativeFieldInfoPtr_Clothing;

        private static readonly System.IntPtr NativeFieldInfoPtr_GroundDetectionMask;

        private static readonly System.IntPtr NativeFieldInfoPtr_AvatarOffset_Standing;

        private static readonly System.IntPtr NativeFieldInfoPtr_AvatarOffset_Crouched;

        private static readonly System.IntPtr NativeFieldInfoPtr_WalkingMapCurve;

        private static readonly System.IntPtr NativeFieldInfoPtr_CrouchWalkMapCurve;

        private static readonly System.IntPtr NativeFieldInfoPtr__PlayerName_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr_Connection;

        private static readonly System.IntPtr NativeFieldInfoPtr__PlayerCode_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__CurrentVehicle_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr_onEnterVehicle;

        private static readonly System.IntPtr NativeFieldInfoPtr_onExitVehicle;

        private static readonly System.IntPtr NativeFieldInfoPtr_LastDrivenVehicle;

        private static readonly System.IntPtr NativeFieldInfoPtr__TimeSinceVehicleExit_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__Crouched_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__CurrentBed_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__IsReadyToSleep_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__IsSkating_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__ActiveSkateboard_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr_onSkateboardMounted;

        private static readonly System.IntPtr NativeFieldInfoPtr_onSkateboardDismounted;

        private static readonly System.IntPtr NativeFieldInfoPtr__IsSleeping_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__IsRagdolled_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__IsArrested_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__IsTased_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__IsUnconscious_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__Scale_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__CurrentProperty_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__LastVisitedProperty_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__CurrentBusiness_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr_HasCompletedIntro;

        private static readonly System.IntPtr NativeFieldInfoPtr__CameraPosition_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__CameraRotation_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr_Inventory;

        private static readonly System.IntPtr NativeFieldInfoPtr__CurrentAvatarSettings_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__ConsumedProduct_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__TimeSinceProductConsumed_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr_DebugAvatarSettings;

        private static readonly System.IntPtr NativeFieldInfoPtr_loader;

        private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr_onRagdoll;

        private static readonly System.IntPtr NativeFieldInfoPtr_onRagdollEnd;

        private static readonly System.IntPtr NativeFieldInfoPtr_onArrested;

        private static readonly System.IntPtr NativeFieldInfoPtr_onFreed;

        private static readonly System.IntPtr NativeFieldInfoPtr_onTased;

        private static readonly System.IntPtr NativeFieldInfoPtr_onTasedEnd;

        private static readonly System.IntPtr NativeFieldInfoPtr_onPassedOut;

        private static readonly System.IntPtr NativeFieldInfoPtr_onPassOutRecovery;

        private static readonly System.IntPtr NativeFieldInfoPtr_PlayerVariables;

        private static readonly System.IntPtr NativeFieldInfoPtr_VariableDict;

        private static readonly System.IntPtr NativeFieldInfoPtr_standingScale;

        private static readonly System.IntPtr NativeFieldInfoPtr_timeAirborne;

        private static readonly System.IntPtr NativeFieldInfoPtr__avatarVisibleToLocalPlayer_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__playerDataRetrieveReturned_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr_taseCoroutine;

        private static readonly System.IntPtr NativeFieldInfoPtr_ragdollForceComponents;

        private static readonly System.IntPtr NativeFieldInfoPtr__playerSaveRequestReturned_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__PlayerInitializedOverNetwork_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr_impactHistory;

        private static readonly System.IntPtr NativeFieldInfoPtr__Paranoid_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__Sneaky_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__Disoriented_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__Seizure_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr_seizureRotations;

        private static readonly System.IntPtr NativeFieldInfoPtr__Slippery_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__Schizophrenic_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr_equippableMessageIDHistory;

        private static readonly System.IntPtr NativeFieldInfoPtr_lerpScaleRoutine;

        private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____PlayerName_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____PlayerCode_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____CurrentVehicle_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____CurrentBed_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____IsReadyToSleep_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____CameraPosition_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____CameraRotation_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

        private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_IsLocalPlayer_Public_get_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerName_Public_get_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerName_Protected_set_Void_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerCode_Public_get_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerCode_Protected_set_Void_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentVehicle_Public_get_NetworkObject_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentVehicle_Public_set_Void_NetworkObject_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeSinceVehicleExit_Public_get_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeSinceVehicleExit_Protected_set_Void_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_Crouched_Public_get_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_Crouched_Private_set_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentBed_Public_get_NetworkObject_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentBed_Public_set_Void_NetworkObject_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_IsReadyToSleep_Public_get_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_IsReadyToSleep_Private_set_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_IsSkating_Public_get_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_IsSkating_Public_set_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveSkateboard_Public_get_Skateboard_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_ActiveSkateboard_Private_set_Void_Skateboard_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_IsSleeping_Public_get_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_IsSleeping_Protected_set_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_IsRagdolled_Public_get_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_IsRagdolled_Protected_set_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_IsArrested_Public_get_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_IsArrested_Protected_set_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_IsTased_Public_get_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_IsTased_Protected_set_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_IsUnconscious_Public_get_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_IsUnconscious_Protected_set_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_Scale_Public_get_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_Scale_Private_set_Void_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentProperty_Protected_set_Void_Property_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_LastVisitedProperty_Public_get_Property_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_LastVisitedProperty_Protected_set_Void_Property_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentBusiness_Public_get_Business_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentBusiness_Protected_set_Void_Business_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerBasePosition_Public_get_Vector3_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_CameraPosition_Public_get_Vector3_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_CameraPosition_Public_set_Void_Vector3_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_CameraRotation_Public_get_Quaternion_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_CameraRotation_Public_set_Void_Quaternion_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentAvatarSettings_Public_get_BasicAvatarSettings_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentAvatarSettings_Protected_set_Void_BasicAvatarSettings_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_ConsumedProduct_Public_get_ProductItemInstance_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_ConsumedProduct_Private_set_Void_ProductItemInstance_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeSinceProductConsumed_Public_get_Int32_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeSinceProductConsumed_Private_set_Void_Int32_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_LoadDebugAvatarSettings_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_avatarVisibleToLocalPlayer_Public_get_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_avatarVisibleToLocalPlayer_Private_set_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_playerDataRetrieveReturned_Public_get_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_playerDataRetrieveReturned_Private_set_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_playerSaveRequestReturned_Public_get_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_playerSaveRequestReturned_Private_set_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerInitializedOverNetwork_Public_get_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerInitializedOverNetwork_Private_set_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_Paranoid_Public_get_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_Paranoid_Public_set_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_Sneaky_Public_get_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_Sneaky_Public_set_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_Disoriented_Public_get_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_Disoriented_Public_set_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_Seizure_Public_get_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_Seizure_Public_set_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_Slippery_Public_get_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_Slippery_Public_set_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_Schizophrenic_Public_get_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_Schizophrenic_Public_set_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayer_Public_Static_Player_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomPlayer_Public_Static_Player_Boolean_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayer_Public_Static_Player_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

        private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1;

        private static readonly System.IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_PlayerLoaded_Private_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RequestSavePlayer_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_ReturnSaveRequest_Private_Void_NetworkConnection_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_HostExitedGame_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_ClientConnectionStateChanged_Private_Void_ClientConnectionStateArgs_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SendPlayerNameData_Public_Void_String_UInt64_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RequestPlayerData_Public_Void_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_MarkPlayerInitialized_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_ReceivePlayerData_Public_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SetGravityMultiplier_Public_Void_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_ReceivePlayerNameData_Private_Void_NetworkConnection_String_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SendFlashlightOn_Public_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SendFlashlightOnNetworked_Private_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SetFlashlightOn_Private_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_OnStopClient_Public_Virtual_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

        private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1;

        private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1;

        private static readonly System.IntPtr NativeMethodInfoPtr_RecalculateCurrentProperty_Private_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_ApplyMovementVisuals_Private_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_PlayJumpAnimation_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_GetIsGrounded_Public_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SendCrouched_Public_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SetCrouchedLocal_Public_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveCrouched_Private_Void_NetworkConnection_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SendAvatarSettings_Public_Void_AvatarSettings_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SetAvatarSettings_Public_Void_AvatarSettings_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SetVisible_Networked_Private_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_EnterVehicle_Public_Void_LandVehicle_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_ExitVehicle_Public_Void_Transform_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_PreDestroyClientObjects_Private_Void_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_CurrentVehicleChanged_Private_Void_NetworkObject_NetworkObject_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_AreAllPlayersReadyToSleep_Public_Static_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SleepStart_Private_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SetReadyToSleep_Public_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SleepEnd_Private_Void_Int32_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_Activate_Public_Static_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_Deactivate_Public_Static_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_ExitAll_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SetVisibleToLocalPlayer_Public_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SetPlayerCode_Public_Void_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SendPunch_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_Punch_Private_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_MarkIntroCompleted_Private_Void_BasicAvatarSettings_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_IsPointVisibleToPlayer_Public_Boolean_Vector3_Single_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_GetClosestPlayer_Public_Static_Player_Vector3_byref_Single_List_1_Player_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SetCapsuleColliderHeight_Public_Void_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SetScale_Public_Void_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SetScale_Public_Void_Single_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_ApplyScale_Protected_Virtual_New_Void_1;

        private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerData_Public_PlayerData_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_GetInventoryString_Public_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_GetAppearanceString_Public_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_GetClothingString_Public_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PlayerData_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PlayerData_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_LoadInventory_Public_Virtual_New_Void_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_LoadAppearance_Public_Virtual_New_Void_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_LoadClothing_Public_Virtual_New_Void_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SetRagdolled_Public_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SendImpact_Public_Virtual_New_Void_Impact_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveImpact_Public_Virtual_New_Void_Impact_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_ProcessImpactForce_Public_Virtual_New_Void_Vector3_Vector3_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_OnDied_Public_Virtual_New_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_OnRevived_Public_Virtual_New_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_Arrest_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_Free_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SendPassOut_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_PassOut_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SendPassOutRecovery_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_PassOutRecovery_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SendEquippable_Networked_Public_Void_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SetEquippable_Networked_Private_Void_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SendEquippableMessage_Networked_Public_Void_String_Int32_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveEquippableMessage_Networked_Private_Void_String_Int32_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SendEquippableMessage_Networked_Vector_Public_Void_String_Int32_Vector3_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveEquippableMessage_Networked_Vector_Private_Void_String_Int32_Vector3_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SendAnimationTrigger_Public_Void_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SetAnimationTrigger_Networked_Public_Void_NetworkConnection_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SetAnimationTrigger_Public_Void_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_ResetAnimationTrigger_Networked_Public_Void_NetworkConnection_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_ResetAnimationTrigger_Public_Void_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SendAnimationBool_Public_Void_String_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SetAnimationBool_Public_Void_String_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_Taze_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SetInventoryItem_Public_Void_Int32_ItemInstance_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_GetNetworth_Private_Void_FloatContainer_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SendAppearance_Public_Void_BasicAvatarSettings_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SetAppearance_Public_Void_BasicAvatarSettings_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_MountSkateboard_Public_Void_Skateboard_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SendMountedSkateboard_Private_Void_NetworkObject_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SetMountedSkateboard_Private_Void_NetworkObject_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_DismountSkateboard_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_ConsumeProduct_Public_Void_ProductItemInstance_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SendConsumeProduct_Private_Void_ProductItemInstance_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveConsumeProduct_Private_Void_ProductItemInstance_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_ConsumeProductInternal_Private_Void_ProductItemInstance_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_ClearProduct_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_CreatePlayerVariables_Private_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_GetVariable_Public_BaseVariable_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_T_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SetVariableValue_Public_Void_String_String_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_AddVariable_Public_Void_BaseVariable_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SendValue_Public_Void_String_String_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveValue_Private_Void_NetworkConnection_String_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveValue_Private_Void_String_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_LoadVariable_Public_Void_VariableData_0;

        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr__RecalculateCurrentProperty_b__248_0_Private_Single_Property_0;

        private static readonly System.IntPtr NativeMethodInfoPtr__RecalculateCurrentProperty_b__248_1_Private_Single_Business_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_CurrentVehicle_3323014238_Private_Void_NetworkObject_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___set_CurrentVehicle_3323014238_Public_Void_NetworkObject_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_set_CurrentVehicle_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_CurrentBed_3323014238_Private_Void_NetworkObject_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___set_CurrentBed_3323014238_Public_Void_NetworkObject_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_set_CurrentBed_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_IsSkating_1140765316_Private_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___set_IsSkating_1140765316_Public_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_set_IsSkating_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_CameraPosition_4276783012_Private_Void_Vector3_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___set_CameraPosition_4276783012_Public_Void_Vector3_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_set_CameraPosition_4276783012_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_CameraRotation_3429297120_Private_Void_Quaternion_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___set_CameraRotation_3429297120_Public_Void_Quaternion_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_set_CameraRotation_3429297120_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_RequestSavePlayer_2166136261_Private_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___RequestSavePlayer_2166136261_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_RequestSavePlayer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReturnSaveRequest_214505783_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_ReturnSaveRequest_214505783_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_HostExitedGame_2166136261_Private_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___HostExitedGame_2166136261_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_HostExitedGame_2166136261_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPlayerNameData_586648380_Private_Void_String_UInt64_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendPlayerNameData_586648380_Public_Void_String_UInt64_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPlayerNameData_586648380_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_RequestPlayerData_3615296227_Private_Void_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___RequestPlayerData_3615296227_Public_Void_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_RequestPlayerData_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_MarkPlayerInitialized_2166136261_Private_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___MarkPlayerInitialized_2166136261_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_MarkPlayerInitialized_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerData_3244732873_Private_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceivePlayerData_3244732873_Public_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerData_3244732873_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerData_3244732873_Private_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerData_3244732873_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerNameData_3895153758_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerNameData_3895153758_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendFlashlightOnNetworked_1140765316_Private_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendFlashlightOnNetworked_1140765316_Private_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendFlashlightOnNetworked_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetFlashlightOn_1140765316_Private_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetFlashlightOn_1140765316_Private_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetFlashlightOn_1140765316_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PlayJumpAnimation_2166136261_Private_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___PlayJumpAnimation_2166136261_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_PlayJumpAnimation_2166136261_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendCrouched_1140765316_Private_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendCrouched_1140765316_Public_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendCrouched_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveCrouched_214505783_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveCrouched_214505783_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendAvatarSettings_4281687581_Private_Void_AvatarSettings_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendAvatarSettings_4281687581_Public_Void_AvatarSettings_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendAvatarSettings_4281687581_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetAvatarSettings_4281687581_Private_Void_AvatarSettings_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetAvatarSettings_4281687581_Public_Void_AvatarSettings_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetAvatarSettings_4281687581_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetVisible_Networked_1140765316_Private_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetVisible_Networked_1140765316_Private_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetVisible_Networked_1140765316_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetReadyToSleep_1140765316_Private_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetReadyToSleep_1140765316_Public_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SetReadyToSleep_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerCode_3615296227_Private_Void_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetPlayerCode_3615296227_Public_Void_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetPlayerCode_3615296227_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPunch_2166136261_Private_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendPunch_2166136261_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPunch_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Punch_2166136261_Private_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___Punch_2166136261_Private_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_Punch_2166136261_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_MarkIntroCompleted_3281254764_Private_Void_BasicAvatarSettings_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___MarkIntroCompleted_3281254764_Private_Void_BasicAvatarSettings_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_MarkIntroCompleted_3281254764_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendImpact_427288424_Private_Void_Impact_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendImpact_427288424_Public_Virtual_New_Void_Impact_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendImpact_427288424_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveImpact_427288424_Private_Void_Impact_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveImpact_427288424_Public_Virtual_New_Void_Impact_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveImpact_427288424_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Arrest_2166136261_Private_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___Arrest_2166136261_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_Arrest_2166136261_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPassOut_2166136261_Private_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendPassOut_2166136261_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPassOut_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PassOut_2166136261_Private_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___PassOut_2166136261_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_PassOut_2166136261_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPassOutRecovery_2166136261_Private_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendPassOutRecovery_2166136261_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPassOutRecovery_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PassOutRecovery_2166136261_Private_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___PassOutRecovery_2166136261_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_PassOutRecovery_2166136261_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendEquippable_Networked_3615296227_Private_Void_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendEquippable_Networked_3615296227_Public_Void_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendEquippable_Networked_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetEquippable_Networked_3615296227_Private_Void_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetEquippable_Networked_3615296227_Private_Void_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetEquippable_Networked_3615296227_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendEquippableMessage_Networked_3643459082_Public_Void_String_Int32_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendEquippableMessage_Networked_3643459082_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveEquippableMessage_Networked_3643459082_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendEquippableMessage_Networked_Vector_3190074053_Public_Void_String_Int32_Vector3_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendEquippableMessage_Networked_Vector_3190074053_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendAnimationTrigger_3615296227_Private_Void_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendAnimationTrigger_3615296227_Public_Void_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendAnimationTrigger_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetAnimationTrigger_Networked_2971853958_Public_Void_NetworkConnection_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_SetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ResetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ResetAnimationTrigger_Networked_2971853958_Public_Void_NetworkConnection_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ResetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_ResetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_ResetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendAnimationBool_310431262_Private_Void_String_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendAnimationBool_310431262_Public_Void_String_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendAnimationBool_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetAnimationBool_310431262_Private_Void_String_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetAnimationBool_310431262_Public_Void_String_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetAnimationBool_310431262_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Taze_2166136261_Private_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___Taze_2166136261_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_Taze_2166136261_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetInventoryItem_2317364410_Private_Void_Int32_ItemInstance_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetInventoryItem_2317364410_Public_Void_Int32_ItemInstance_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SetInventoryItem_2317364410_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendAppearance_3281254764_Private_Void_BasicAvatarSettings_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendAppearance_3281254764_Public_Void_BasicAvatarSettings_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendAppearance_3281254764_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetAppearance_2139595489_Private_Void_BasicAvatarSettings_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetAppearance_2139595489_Public_Void_BasicAvatarSettings_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetAppearance_2139595489_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendMountedSkateboard_3323014238_Private_Void_NetworkObject_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendMountedSkateboard_3323014238_Private_Void_NetworkObject_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendMountedSkateboard_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetMountedSkateboard_3323014238_Private_Void_NetworkObject_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetMountedSkateboard_3323014238_Private_Void_NetworkObject_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetMountedSkateboard_3323014238_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendConsumeProduct_2622925554_Private_Void_ProductItemInstance_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendConsumeProduct_2622925554_Private_Void_ProductItemInstance_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendConsumeProduct_2622925554_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveConsumeProduct_2622925554_Private_Void_ProductItemInstance_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveConsumeProduct_2622925554_Private_Void_ProductItemInstance_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveConsumeProduct_2622925554_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendValue_3589193952_Private_Void_String_String_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendValue_3589193952_Public_Void_String_String_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendValue_3589193952_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveValue_3895153758_Private_Void_NetworkConnection_String_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveValue_3895153758_Private_Void_NetworkConnection_String_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveValue_3895153758_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__PlayerName_k__BackingField_Public_get_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__PlayerName_k__BackingField_Public_set_Void_String_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_PlayerScripts_Player_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__PlayerCode_k__BackingField_Public_get_String_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__PlayerCode_k__BackingField_Public_set_Void_String_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__CurrentVehicle_k__BackingField_Public_get_NetworkObject_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__CurrentVehicle_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__CurrentBed_k__BackingField_Public_get_NetworkObject_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__CurrentBed_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__IsReadyToSleep_k__BackingField_Public_get_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__IsReadyToSleep_k__BackingField_Public_set_Void_Boolean_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__CameraPosition_k__BackingField_Public_get_Vector3_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__CameraPosition_k__BackingField_Public_set_Void_Vector3_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__CameraRotation_k__BackingField_Public_get_Quaternion_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__CameraRotation_k__BackingField_Public_set_Void_Quaternion_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

        public unsafe static string OWNER_PLAYER_CODE
        {
            get
            {
                System.IntPtr il2CppString;
                IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OWNER_PLAYER_CODE, &il2CppString);
                return IL2CPP.Il2CppStringToManaged(il2CppString);
            }
            set
            {
                IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OWNER_PLAYER_CODE, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
            }
        }

        public unsafe static float CapColDefaultHeight
        {
            get
            {
                float result;
                IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CapColDefaultHeight, &result);
                return result;
            }
            set
            {
                IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CapColDefaultHeight, &value);
            }
        }

        public unsafe List<NetworkObject> objectsTemporarilyOwnedByPlayer
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectsTemporarilyOwnedByPlayer);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NetworkObject>>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectsTemporarilyOwnedByPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe static Il2CppSystem.Action onLocalPlayerSpawned
        {
            get
            {
                System.IntPtr intPtr;
                IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onLocalPlayerSpawned, &intPtr);
                System.IntPtr intPtr2 = intPtr;
                return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
            }
            set
            {
                IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onLocalPlayerSpawned, (void*)IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe static Il2CppSystem.Action<Player> onPlayerSpawned
        {
            get
            {
                System.IntPtr intPtr;
                IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onPlayerSpawned, &intPtr);
                System.IntPtr intPtr2 = intPtr;
                return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Player>>(intPtr2) : null;
            }
            set
            {
                IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onPlayerSpawned, (void*)IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe static Il2CppSystem.Action<Player> onPlayerDespawned
        {
            get
            {
                System.IntPtr intPtr;
                IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onPlayerDespawned, &intPtr);
                System.IntPtr intPtr2 = intPtr;
                return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Player>>(intPtr2) : null;
            }
            set
            {
                IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onPlayerDespawned, (void*)IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe static Player Local
        {
            get
            {
                System.IntPtr intPtr;
                IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Local, &intPtr);
                System.IntPtr intPtr2 = intPtr;
                return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
            }
            set
            {
                IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Local, (void*)IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe static List<Player> PlayerList
        {
            get
            {
                System.IntPtr intPtr;
                IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayerList, &intPtr);
                System.IntPtr intPtr2 = intPtr;
                return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
            }
            set
            {
                IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayerList, (void*)IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe GameObject LocalGameObject
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocalGameObject);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocalGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe Avatar Avatar
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Avatar);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Avatar>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe AvatarAnimation Anim
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Anim);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AvatarAnimation>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe SmoothedVelocityCalculator VelocityCalculator
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VelocityCalculator);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VelocityCalculator), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe Vector3 EyePosition
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EyePosition);
                return *(Vector3*)num;
            }
            set
            {
                *(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EyePosition)) = value;
            }
        }

        public unsafe AvatarSettings TestAvatarSettings
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TestAvatarSettings);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TestAvatarSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe PlayerVisualState VisualState
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VisualState);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerVisualState>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VisualState), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe PlayerVisibility Visibility
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Visibility);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerVisibility>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Visibility), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe CapsuleCollider CapCol
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CapCol);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CapsuleCollider>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CapCol), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe POI PoI
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PoI);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<POI>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PoI), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe PlayerHealth Health
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Health);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerHealth>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Health), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe PlayerCrimeData CrimeData
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CrimeData);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerCrimeData>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CrimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe PlayerEnergy Energy
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Energy);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerEnergy>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Energy), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe Transform MimicCamera
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MimicCamera);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MimicCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe AvatarFootstepDetector FootstepDetector
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FootstepDetector);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AvatarFootstepDetector>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FootstepDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe LocalPlayerFootstepGenerator LocalFootstepDetector
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocalFootstepDetector);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LocalPlayerFootstepGenerator>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocalFootstepDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe CharacterController CharacterController
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CharacterController);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterController>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CharacterController), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe AudioSourceController PunchSound
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PunchSound);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PunchSound), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe OptimizedLight ThirdPersonFlashlight
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ThirdPersonFlashlight);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OptimizedLight>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ThirdPersonFlashlight), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe WorldspaceDialogueRenderer NameLabel
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NameLabel);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldspaceDialogueRenderer>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe PlayerClothing Clothing
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Clothing);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerClothing>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Clothing), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe LayerMask GroundDetectionMask
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GroundDetectionMask);
                return *(LayerMask*)num;
            }
            set
            {
                *(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GroundDetectionMask)) = value;
            }
        }

        public unsafe float AvatarOffset_Standing
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AvatarOffset_Standing);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AvatarOffset_Standing)) = value;
            }
        }

        public unsafe float AvatarOffset_Crouched
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AvatarOffset_Crouched);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AvatarOffset_Crouched)) = value;
            }
        }

        public unsafe AnimationCurve WalkingMapCurve
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WalkingMapCurve);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WalkingMapCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe AnimationCurve CrouchWalkMapCurve
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CrouchWalkMapCurve);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CrouchWalkMapCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe string _PlayerName_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerName_k__BackingField);
                return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
            }
        }

        public unsafe NetworkConnection Connection
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Connection);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Connection), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe string _PlayerCode_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerCode_k__BackingField);
                return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerCode_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
            }
        }

        public unsafe NetworkObject _CurrentVehicle_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurrentVehicle_k__BackingField);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurrentVehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe VehicleEvent onEnterVehicle
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onEnterVehicle);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<VehicleEvent>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onEnterVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe VehicleTransformEvent onExitVehicle
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onExitVehicle);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<VehicleTransformEvent>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onExitVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe LandVehicle LastDrivenVehicle
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastDrivenVehicle);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastDrivenVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe float _TimeSinceVehicleExit_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TimeSinceVehicleExit_k__BackingField);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TimeSinceVehicleExit_k__BackingField)) = value;
            }
        }

        public unsafe bool _Crouched_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Crouched_k__BackingField);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Crouched_k__BackingField)) = value;
            }
        }

        public unsafe NetworkObject _CurrentBed_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurrentBed_k__BackingField);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurrentBed_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe bool _IsReadyToSleep_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsReadyToSleep_k__BackingField);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsReadyToSleep_k__BackingField)) = value;
            }
        }

        public unsafe bool _IsSkating_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsSkating_k__BackingField);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsSkating_k__BackingField)) = value;
            }
        }

        public unsafe Skateboard _ActiveSkateboard_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ActiveSkateboard_k__BackingField);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Skateboard>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ActiveSkateboard_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe Il2CppSystem.Action<Skateboard> onSkateboardMounted
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onSkateboardMounted);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Skateboard>>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onSkateboardMounted), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe Il2CppSystem.Action onSkateboardDismounted
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onSkateboardDismounted);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onSkateboardDismounted), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe bool _IsSleeping_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsSleeping_k__BackingField);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsSleeping_k__BackingField)) = value;
            }
        }

        public unsafe bool _IsRagdolled_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsRagdolled_k__BackingField);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsRagdolled_k__BackingField)) = value;
            }
        }

        public unsafe bool _IsArrested_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsArrested_k__BackingField);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsArrested_k__BackingField)) = value;
            }
        }

        public unsafe bool _IsTased_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsTased_k__BackingField);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsTased_k__BackingField)) = value;
            }
        }

        public unsafe bool _IsUnconscious_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsUnconscious_k__BackingField);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsUnconscious_k__BackingField)) = value;
            }
        }

        public unsafe float _Scale_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Scale_k__BackingField);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Scale_k__BackingField)) = value;
            }
        }

        public unsafe Il2CppScheduleOne.Property.Property _CurrentProperty_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurrentProperty_k__BackingField);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.Property.Property>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurrentProperty_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe Il2CppScheduleOne.Property.Property _LastVisitedProperty_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LastVisitedProperty_k__BackingField);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.Property.Property>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LastVisitedProperty_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe Business _CurrentBusiness_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurrentBusiness_k__BackingField);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Business>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurrentBusiness_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe bool HasCompletedIntro
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HasCompletedIntro);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HasCompletedIntro)) = value;
            }
        }

        public unsafe Vector3 _CameraPosition_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CameraPosition_k__BackingField);
                return *(Vector3*)num;
            }
            set
            {
                *(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CameraPosition_k__BackingField)) = value;
            }
        }

        public unsafe Quaternion _CameraRotation_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CameraRotation_k__BackingField);
                return *(Quaternion*)num;
            }
            set
            {
                *(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CameraRotation_k__BackingField)) = value;
            }
        }

        public unsafe Il2CppReferenceArray<ItemSlot> Inventory
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Inventory);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlot>>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Inventory), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe BasicAvatarSettings _CurrentAvatarSettings_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurrentAvatarSettings_k__BackingField);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurrentAvatarSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe ProductItemInstance _ConsumedProduct_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ConsumedProduct_k__BackingField);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ConsumedProduct_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe int _TimeSinceProductConsumed_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TimeSinceProductConsumed_k__BackingField);
                return *(int*)num;
            }
            set
            {
                *(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TimeSinceProductConsumed_k__BackingField)) = value;
            }
        }

        public unsafe BasicAvatarSettings DebugAvatarSettings
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugAvatarSettings);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugAvatarSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe PlayerLoader loader
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loader);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerLoader>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe List<string> _LocalExtraFiles_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe List<string> _LocalExtraFolders_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe bool _HasChanged_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HasChanged_k__BackingField);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
            }
        }

        public unsafe UnityEvent onRagdoll
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onRagdoll);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onRagdoll), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe UnityEvent onRagdollEnd
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onRagdollEnd);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onRagdollEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe UnityEvent onArrested
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onArrested);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onArrested), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe UnityEvent onFreed
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onFreed);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onFreed), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe UnityEvent onTased
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onTased);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onTased), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe UnityEvent onTasedEnd
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onTasedEnd);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onTasedEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe UnityEvent onPassedOut
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onPassedOut);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onPassedOut), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe UnityEvent onPassOutRecovery
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onPassOutRecovery);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onPassOutRecovery), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe List<BaseVariable> PlayerVariables
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerVariables);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BaseVariable>>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerVariables), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe Dictionary<string, BaseVariable> VariableDict
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VariableDict);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, BaseVariable>>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VariableDict), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe float standingScale
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_standingScale);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_standingScale)) = value;
            }
        }

        public unsafe float timeAirborne
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeAirborne);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeAirborne)) = value;
            }
        }

        public unsafe bool _avatarVisibleToLocalPlayer_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__avatarVisibleToLocalPlayer_k__BackingField);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__avatarVisibleToLocalPlayer_k__BackingField)) = value;
            }
        }

        public unsafe bool _playerDataRetrieveReturned_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playerDataRetrieveReturned_k__BackingField);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playerDataRetrieveReturned_k__BackingField)) = value;
            }
        }

        public unsafe Coroutine taseCoroutine
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taseCoroutine);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Coroutine>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taseCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe List<ConstantForce> ragdollForceComponents
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollForceComponents);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ConstantForce>>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollForceComponents), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe bool _playerSaveRequestReturned_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playerSaveRequestReturned_k__BackingField);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playerSaveRequestReturned_k__BackingField)) = value;
            }
        }

        public unsafe bool _PlayerInitializedOverNetwork_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerInitializedOverNetwork_k__BackingField);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerInitializedOverNetwork_k__BackingField)) = value;
            }
        }

        public unsafe List<int> impactHistory
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_impactHistory);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_impactHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe bool _Paranoid_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Paranoid_k__BackingField);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Paranoid_k__BackingField)) = value;
            }
        }

        public unsafe bool _Sneaky_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Sneaky_k__BackingField);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Sneaky_k__BackingField)) = value;
            }
        }

        public unsafe bool _Disoriented_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Disoriented_k__BackingField);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Disoriented_k__BackingField)) = value;
            }
        }

        public unsafe bool _Seizure_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Seizure_k__BackingField);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Seizure_k__BackingField)) = value;
            }
        }

        public unsafe List<Quaternion> seizureRotations
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seizureRotations);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Quaternion>>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seizureRotations), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe bool _Slippery_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Slippery_k__BackingField);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Slippery_k__BackingField)) = value;
            }
        }

        public unsafe bool _Schizophrenic_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Schizophrenic_k__BackingField);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Schizophrenic_k__BackingField)) = value;
            }
        }

        public unsafe List<int> equippableMessageIDHistory
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equippableMessageIDHistory);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equippableMessageIDHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe Coroutine lerpScaleRoutine
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lerpScaleRoutine);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Coroutine>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lerpScaleRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe SyncVar<string> syncVar____PlayerName_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncVar____PlayerName_k__BackingField);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SyncVar<string>>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncVar____PlayerName_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe SyncVar<string> syncVar____PlayerCode_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncVar____PlayerCode_k__BackingField);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SyncVar<string>>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncVar____PlayerCode_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe SyncVar<NetworkObject> syncVar____CurrentVehicle_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncVar____CurrentVehicle_k__BackingField);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncVar____CurrentVehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe SyncVar<NetworkObject> syncVar____CurrentBed_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncVar____CurrentBed_k__BackingField);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncVar____CurrentBed_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe SyncVar<bool> syncVar____IsReadyToSleep_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncVar____IsReadyToSleep_k__BackingField);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncVar____IsReadyToSleep_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe SyncVar<Vector3> syncVar____CameraPosition_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncVar____CameraPosition_k__BackingField);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SyncVar<Vector3>>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncVar____CameraPosition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe SyncVar<Quaternion> syncVar____CameraRotation_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncVar____CameraRotation_k__BackingField);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SyncVar<Quaternion>>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncVar____CameraRotation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe bool field_Private_Boolean_0
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field_Private_Boolean_0);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
            }
        }

        public unsafe bool field_Private_Boolean_1
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field_Private_Boolean_1);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
            }
        }

        public unsafe bool IsLocalPlayer
        {
            [CallerCount(13)]
            [CachedScanResults(RefRangeStart = 166166, RefRangeEnd = 166179, XrefRangeStart = 166165, XrefRangeEnd = 166166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsLocalPlayer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
            }
        }

        public unsafe string PlayerName
        {
            [CallerCount(15)]
            [CachedScanResults(RefRangeStart = 166179, RefRangeEnd = 166194, XrefRangeStart = 166179, XrefRangeEnd = 166179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return IL2CPP.Il2CppStringToManaged(il2CppString);
            }
            [CallerCount(2)]
            [CachedScanResults(RefRangeStart = 166202, RefRangeEnd = 166204, XrefRangeStart = 166194, XrefRangeEnd = 166202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = IL2CPP.ManagedStringToIl2Cpp(value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_PlayerName_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe string PlayerCode
        {
            [CallerCount(9)]
            [CachedScanResults(RefRangeStart = 166204, RefRangeEnd = 166213, XrefRangeStart = 166204, XrefRangeEnd = 166204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerCode_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return IL2CPP.Il2CppStringToManaged(il2CppString);
            }
            [CallerCount(4)]
            [CachedScanResults(RefRangeStart = 166221, RefRangeEnd = 166225, XrefRangeStart = 166213, XrefRangeEnd = 166221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = IL2CPP.ManagedStringToIl2Cpp(value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_PlayerCode_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe NetworkObject CurrentVehicle
        {
            [CallerCount(14)]
            [CachedScanResults(RefRangeStart = 166225, RefRangeEnd = 166239, XrefRangeStart = 166225, XrefRangeEnd = 166225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentVehicle_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr) : null;
            }
            [CallerCount(3)]
            [CachedScanResults(RefRangeStart = 166272, RefRangeEnd = 166275, XrefRangeStart = 166239, XrefRangeEnd = 166272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CurrentVehicle_Public_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe float TimeSinceVehicleExit
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TimeSinceVehicleExit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(float*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(0)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = (nint)(&value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TimeSinceVehicleExit_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe bool Crouched
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Crouched_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(1)]
            [CachedScanResults(RefRangeStart = 166275, RefRangeEnd = 166276, XrefRangeStart = 166275, XrefRangeEnd = 166275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = (nint)(&value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Crouched_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe NetworkObject CurrentBed
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentBed_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr) : null;
            }
            [CallerCount(2)]
            [CachedScanResults(RefRangeStart = 166305, RefRangeEnd = 166307, XrefRangeStart = 166276, XrefRangeEnd = 166305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CurrentBed_Public_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe bool IsReadyToSleep
        {
            [CallerCount(3)]
            [CachedScanResults(RefRangeStart = 166307, RefRangeEnd = 166310, XrefRangeStart = 166307, XrefRangeEnd = 166307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsReadyToSleep_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(2)]
            [CachedScanResults(RefRangeStart = 166317, RefRangeEnd = 166319, XrefRangeStart = 166310, XrefRangeEnd = 166317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = (nint)(&value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsReadyToSleep_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe bool IsSkating
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsSkating_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(1)]
            [CachedScanResults(RefRangeStart = 166348, RefRangeEnd = 166349, XrefRangeStart = 166319, XrefRangeEnd = 166348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = (nint)(&value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsSkating_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe Skateboard ActiveSkateboard
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ActiveSkateboard_Public_get_Skateboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Skateboard>(intPtr) : null;
            }
            [CallerCount(0)]
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ActiveSkateboard_Private_set_Void_Skateboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe bool IsSleeping
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsSleeping_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(0)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = (nint)(&value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsSleeping_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe bool IsRagdolled
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsRagdolled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(0)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = (nint)(&value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsRagdolled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe bool IsArrested
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsArrested_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(0)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = (nint)(&value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsArrested_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe bool IsTased
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsTased_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(0)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = (nint)(&value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsTased_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe bool IsUnconscious
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsUnconscious_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(0)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = (nint)(&value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsUnconscious_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe float Scale
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Scale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(float*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(0)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = (nint)(&value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Scale_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe Il2CppScheduleOne.Property.Property CurrentProperty
        {
            [CallerCount(1)]
            [CachedScanResults(RefRangeStart = 166349, RefRangeEnd = 166350, XrefRangeStart = 166349, XrefRangeEnd = 166349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.Property.Property>(intPtr) : null;
            }
            [CallerCount(0)]
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166350, XrefRangeEnd = 166351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CurrentProperty_Protected_set_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe Il2CppScheduleOne.Property.Property LastVisitedProperty
        {
            [CallerCount(4)]
            [CachedScanResults(RefRangeStart = 166351, RefRangeEnd = 166355, XrefRangeStart = 166351, XrefRangeEnd = 166351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LastVisitedProperty_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.Property.Property>(intPtr) : null;
            }
            [CallerCount(0)]
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166355, XrefRangeEnd = 166356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LastVisitedProperty_Protected_set_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe Business CurrentBusiness
        {
            [CallerCount(15)]
            [CachedScanResults(RefRangeStart = 166356, RefRangeEnd = 166371, XrefRangeStart = 166356, XrefRangeEnd = 166356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentBusiness_Public_get_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Business>(intPtr) : null;
            }
            [CallerCount(0)]
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166371, XrefRangeEnd = 166372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CurrentBusiness_Protected_set_Void_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe Vector3 PlayerBasePosition
        {
            [CallerCount(2)]
            [CachedScanResults(RefRangeStart = 166377, RefRangeEnd = 166379, XrefRangeStart = 166372, XrefRangeEnd = 166377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerBasePosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
            }
        }

        public unsafe Vector3 CameraPosition
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CameraPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(0)]
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166379, XrefRangeEnd = 166380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = (nint)(&value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CameraPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe Quaternion CameraRotation
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CameraRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(0)]
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166380, XrefRangeEnd = 166409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = (nint)(&value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CameraRotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe BasicAvatarSettings CurrentAvatarSettings
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentAvatarSettings_Public_get_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr) : null;
            }
            [CallerCount(0)]
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166409, XrefRangeEnd = 166410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CurrentAvatarSettings_Protected_set_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe ProductItemInstance ConsumedProduct
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ConsumedProduct_Public_get_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr) : null;
            }
            [CallerCount(0)]
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166410, XrefRangeEnd = 166411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ConsumedProduct_Private_set_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe int TimeSinceProductConsumed
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TimeSinceProductConsumed_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(int*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(0)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = (nint)(&value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TimeSinceProductConsumed_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe virtual string SaveFolderName
        {
            [CallerCount(5)]
            [CachedScanResults(RefRangeStart = 166417, RefRangeEnd = 166422, XrefRangeStart = 166412, XrefRangeEnd = 166417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return IL2CPP.Il2CppStringToManaged(il2CppString);
            }
        }

        public unsafe virtual string SaveFileName
        {
            [CallerCount(0)]
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166422, XrefRangeEnd = 166424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return IL2CPP.Il2CppStringToManaged(il2CppString);
            }
        }

        public unsafe virtual Loader Loader
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Loader>(intPtr) : null;
            }
        }

        public unsafe virtual bool ShouldSaveUnderFolder
        {
            [CallerCount(20)]
            [CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
            }
        }

        public unsafe virtual List<string> LocalExtraFiles
        {
            [CallerCount(1)]
            [CachedScanResults(RefRangeStart = 118902, RefRangeEnd = 118903, XrefRangeStart = 118902, XrefRangeEnd = 118903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
            }
            [CallerCount(0)]
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166424, XrefRangeEnd = 166425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe virtual List<string> LocalExtraFolders
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
            }
            [CallerCount(0)]
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166425, XrefRangeEnd = 166426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe virtual bool HasChanged
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(0)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = (nint)(&value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe bool avatarVisibleToLocalPlayer
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_avatarVisibleToLocalPlayer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(0)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = (nint)(&value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_avatarVisibleToLocalPlayer_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe bool playerDataRetrieveReturned
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playerDataRetrieveReturned_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(0)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = (nint)(&value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_playerDataRetrieveReturned_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe bool playerSaveRequestReturned
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playerSaveRequestReturned_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(0)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = (nint)(&value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_playerSaveRequestReturned_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe bool PlayerInitializedOverNetwork
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerInitializedOverNetwork_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(0)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = (nint)(&value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_PlayerInitializedOverNetwork_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe bool Paranoid
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Paranoid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(0)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = (nint)(&value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Paranoid_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe bool Sneaky
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Sneaky_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(0)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = (nint)(&value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Sneaky_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe bool Disoriented
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Disoriented_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(0)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = (nint)(&value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Disoriented_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe bool Seizure
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Seizure_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(0)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = (nint)(&value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Seizure_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe bool Slippery
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Slippery_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(0)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = (nint)(&value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Slippery_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe bool Schizophrenic
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Schizophrenic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(0)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = (nint)(&value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Schizophrenic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe string SyncAccessor__003CPlayerName_003Ek__BackingField
        {
            [CallerCount(15)]
            [CachedScanResults(RefRangeStart = 166179, RefRangeEnd = 166194, XrefRangeStart = 166179, XrefRangeEnd = 166194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sync___get_value__PlayerName_k__BackingField_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return IL2CPP.Il2CppStringToManaged(il2CppString);
            }
            [CallerCount(1)]
            [CachedScanResults(RefRangeStart = 171789, RefRangeEnd = 171790, XrefRangeStart = 171780, XrefRangeEnd = 171789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[2];
                *ptr = IL2CPP.ManagedStringToIl2Cpp(value);
                *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sync___set_value__PlayerName_k__BackingField_Public_set_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe string SyncAccessor__003CPlayerCode_003Ek__BackingField
        {
            [CallerCount(9)]
            [CachedScanResults(RefRangeStart = 166204, RefRangeEnd = 166213, XrefRangeStart = 166204, XrefRangeEnd = 166213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sync___get_value__PlayerCode_k__BackingField_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return IL2CPP.Il2CppStringToManaged(il2CppString);
            }
            [CallerCount(0)]
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171798, XrefRangeEnd = 171807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[2];
                *ptr = IL2CPP.ManagedStringToIl2Cpp(value);
                *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sync___set_value__PlayerCode_k__BackingField_Public_set_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe NetworkObject SyncAccessor__003CCurrentVehicle_003Ek__BackingField
        {
            [CallerCount(14)]
            [CachedScanResults(RefRangeStart = 166225, RefRangeEnd = 166239, XrefRangeStart = 166225, XrefRangeEnd = 166239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sync___get_value__CurrentVehicle_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr) : null;
            }
            [CallerCount(0)]
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171807, XrefRangeEnd = 171816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[2];
                *ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
                *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sync___set_value__CurrentVehicle_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe NetworkObject SyncAccessor__003CCurrentBed_003Ek__BackingField
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sync___get_value__CurrentBed_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr) : null;
            }
            [CallerCount(0)]
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171816, XrefRangeEnd = 171825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[2];
                *ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
                *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sync___set_value__CurrentBed_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe bool SyncAccessor__003CIsReadyToSleep_003Ek__BackingField
        {
            [CallerCount(3)]
            [CachedScanResults(RefRangeStart = 166307, RefRangeEnd = 166310, XrefRangeStart = 166307, XrefRangeEnd = 166310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sync___get_value__IsReadyToSleep_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(0)]
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171825, XrefRangeEnd = 171833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[2];
                *ptr = (nint)(&value);
                *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sync___set_value__IsReadyToSleep_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe Vector3 SyncAccessor__003CCameraPosition_003Ek__BackingField
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sync___get_value__CameraPosition_k__BackingField_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(0)]
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171833, XrefRangeEnd = 171841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[2];
                *ptr = (nint)(&value);
                *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sync___set_value__CameraPosition_k__BackingField_Public_set_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe Quaternion SyncAccessor__003CCameraRotation_003Ek__BackingField
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sync___get_value__CameraRotation_k__BackingField_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(0)]
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171841, XrefRangeEnd = 171849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[2];
                *ptr = (nint)(&value);
                *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sync___set_value__CameraRotation_k__BackingField_Public_set_Void_Quaternion_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        static Player()
        {
            Il2CppClassPointerStore<Player>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "Player");
            IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player>.NativeClassPtr);
            NativeFieldInfoPtr_OWNER_PLAYER_CODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "OWNER_PLAYER_CODE");
            NativeFieldInfoPtr_CapColDefaultHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "CapColDefaultHeight");
            NativeFieldInfoPtr_objectsTemporarilyOwnedByPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "objectsTemporarilyOwnedByPlayer");
            NativeFieldInfoPtr_onLocalPlayerSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onLocalPlayerSpawned");
            NativeFieldInfoPtr_onPlayerSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onPlayerSpawned");
            NativeFieldInfoPtr_onPlayerDespawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onPlayerDespawned");
            NativeFieldInfoPtr_Local = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Local");
            NativeFieldInfoPtr_PlayerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "PlayerList");
            NativeFieldInfoPtr_LocalGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "LocalGameObject");
            NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Avatar");
            NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Anim");
            NativeFieldInfoPtr_VelocityCalculator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "VelocityCalculator");
            NativeFieldInfoPtr_EyePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "EyePosition");
            NativeFieldInfoPtr_TestAvatarSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "TestAvatarSettings");
            NativeFieldInfoPtr_VisualState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "VisualState");
            NativeFieldInfoPtr_Visibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Visibility");
            NativeFieldInfoPtr_CapCol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "CapCol");
            NativeFieldInfoPtr_PoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "PoI");
            NativeFieldInfoPtr_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Health");
            NativeFieldInfoPtr_CrimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "CrimeData");
            NativeFieldInfoPtr_Energy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Energy");
            NativeFieldInfoPtr_MimicCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "MimicCamera");
            NativeFieldInfoPtr_FootstepDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "FootstepDetector");
            NativeFieldInfoPtr_LocalFootstepDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "LocalFootstepDetector");
            NativeFieldInfoPtr_CharacterController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "CharacterController");
            NativeFieldInfoPtr_PunchSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "PunchSound");
            NativeFieldInfoPtr_ThirdPersonFlashlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "ThirdPersonFlashlight");
            NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "NameLabel");
            NativeFieldInfoPtr_Clothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Clothing");
            NativeFieldInfoPtr_GroundDetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "GroundDetectionMask");
            NativeFieldInfoPtr_AvatarOffset_Standing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "AvatarOffset_Standing");
            NativeFieldInfoPtr_AvatarOffset_Crouched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "AvatarOffset_Crouched");
            NativeFieldInfoPtr_WalkingMapCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "WalkingMapCurve");
            NativeFieldInfoPtr_CrouchWalkMapCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "CrouchWalkMapCurve");
            NativeFieldInfoPtr__PlayerName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<PlayerName>k__BackingField");
            NativeFieldInfoPtr_Connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Connection");
            NativeFieldInfoPtr__PlayerCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<PlayerCode>k__BackingField");
            NativeFieldInfoPtr__CurrentVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<CurrentVehicle>k__BackingField");
            NativeFieldInfoPtr_onEnterVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onEnterVehicle");
            NativeFieldInfoPtr_onExitVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onExitVehicle");
            NativeFieldInfoPtr_LastDrivenVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "LastDrivenVehicle");
            NativeFieldInfoPtr__TimeSinceVehicleExit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<TimeSinceVehicleExit>k__BackingField");
            NativeFieldInfoPtr__Crouched_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<Crouched>k__BackingField");
            NativeFieldInfoPtr__CurrentBed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<CurrentBed>k__BackingField");
            NativeFieldInfoPtr__IsReadyToSleep_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<IsReadyToSleep>k__BackingField");
            NativeFieldInfoPtr__IsSkating_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<IsSkating>k__BackingField");
            NativeFieldInfoPtr__ActiveSkateboard_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<ActiveSkateboard>k__BackingField");
            NativeFieldInfoPtr_onSkateboardMounted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onSkateboardMounted");
            NativeFieldInfoPtr_onSkateboardDismounted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onSkateboardDismounted");
            NativeFieldInfoPtr__IsSleeping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<IsSleeping>k__BackingField");
            NativeFieldInfoPtr__IsRagdolled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<IsRagdolled>k__BackingField");
            NativeFieldInfoPtr__IsArrested_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<IsArrested>k__BackingField");
            NativeFieldInfoPtr__IsTased_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<IsTased>k__BackingField");
            NativeFieldInfoPtr__IsUnconscious_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<IsUnconscious>k__BackingField");
            NativeFieldInfoPtr__Scale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<Scale>k__BackingField");
            NativeFieldInfoPtr__CurrentProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<CurrentProperty>k__BackingField");
            NativeFieldInfoPtr__LastVisitedProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<LastVisitedProperty>k__BackingField");
            NativeFieldInfoPtr__CurrentBusiness_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<CurrentBusiness>k__BackingField");
            NativeFieldInfoPtr_HasCompletedIntro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "HasCompletedIntro");
            NativeFieldInfoPtr__CameraPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<CameraPosition>k__BackingField");
            NativeFieldInfoPtr__CameraRotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<CameraRotation>k__BackingField");
            NativeFieldInfoPtr_Inventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Inventory");
            NativeFieldInfoPtr__CurrentAvatarSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<CurrentAvatarSettings>k__BackingField");
            NativeFieldInfoPtr__ConsumedProduct_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<ConsumedProduct>k__BackingField");
            NativeFieldInfoPtr__TimeSinceProductConsumed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<TimeSinceProductConsumed>k__BackingField");
            NativeFieldInfoPtr_DebugAvatarSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "DebugAvatarSettings");
            NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "loader");
            NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
            NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
            NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<HasChanged>k__BackingField");
            NativeFieldInfoPtr_onRagdoll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onRagdoll");
            NativeFieldInfoPtr_onRagdollEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onRagdollEnd");
            NativeFieldInfoPtr_onArrested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onArrested");
            NativeFieldInfoPtr_onFreed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onFreed");
            NativeFieldInfoPtr_onTased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onTased");
            NativeFieldInfoPtr_onTasedEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onTasedEnd");
            NativeFieldInfoPtr_onPassedOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onPassedOut");
            NativeFieldInfoPtr_onPassOutRecovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onPassOutRecovery");
            NativeFieldInfoPtr_PlayerVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "PlayerVariables");
            NativeFieldInfoPtr_VariableDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "VariableDict");
            NativeFieldInfoPtr_standingScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "standingScale");
            NativeFieldInfoPtr_timeAirborne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "timeAirborne");
            NativeFieldInfoPtr__avatarVisibleToLocalPlayer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<avatarVisibleToLocalPlayer>k__BackingField");
            NativeFieldInfoPtr__playerDataRetrieveReturned_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<playerDataRetrieveReturned>k__BackingField");
            NativeFieldInfoPtr_taseCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "taseCoroutine");
            NativeFieldInfoPtr_ragdollForceComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "ragdollForceComponents");
            NativeFieldInfoPtr__playerSaveRequestReturned_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<playerSaveRequestReturned>k__BackingField");
            NativeFieldInfoPtr__PlayerInitializedOverNetwork_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<PlayerInitializedOverNetwork>k__BackingField");
            NativeFieldInfoPtr_impactHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "impactHistory");
            NativeFieldInfoPtr__Paranoid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<Paranoid>k__BackingField");
            NativeFieldInfoPtr__Sneaky_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<Sneaky>k__BackingField");
            NativeFieldInfoPtr__Disoriented_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<Disoriented>k__BackingField");
            NativeFieldInfoPtr__Seizure_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<Seizure>k__BackingField");
            NativeFieldInfoPtr_seizureRotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "seizureRotations");
            NativeFieldInfoPtr__Slippery_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<Slippery>k__BackingField");
            NativeFieldInfoPtr__Schizophrenic_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<Schizophrenic>k__BackingField");
            NativeFieldInfoPtr_equippableMessageIDHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "equippableMessageIDHistory");
            NativeFieldInfoPtr_lerpScaleRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "lerpScaleRoutine");
            NativeFieldInfoPtr_syncVar____PlayerName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "syncVar___<PlayerName>k__BackingField");
            NativeFieldInfoPtr_syncVar____PlayerCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "syncVar___<PlayerCode>k__BackingField");
            NativeFieldInfoPtr_syncVar____CurrentVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "syncVar___<CurrentVehicle>k__BackingField");
            NativeFieldInfoPtr_syncVar____CurrentBed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "syncVar___<CurrentBed>k__BackingField");
            NativeFieldInfoPtr_syncVar____IsReadyToSleep_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "syncVar___<IsReadyToSleep>k__BackingField");
            NativeFieldInfoPtr_syncVar____CameraPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "syncVar___<CameraPosition>k__BackingField");
            NativeFieldInfoPtr_syncVar____CameraRotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "syncVar___<CameraRotation>k__BackingField");
            NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.PlayerScripts.PlayerAssembly-CSharp.dll_Excuted");
            NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.PlayerScripts.PlayerAssembly-CSharp.dll_Excuted");
            NativeMethodInfoPtr_get_IsLocalPlayer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672768);
            NativeMethodInfoPtr_get_PlayerName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672769);
            NativeMethodInfoPtr_set_PlayerName_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672770);
            NativeMethodInfoPtr_get_PlayerCode_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672771);
            NativeMethodInfoPtr_set_PlayerCode_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672772);
            NativeMethodInfoPtr_get_CurrentVehicle_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672773);
            NativeMethodInfoPtr_set_CurrentVehicle_Public_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672774);
            NativeMethodInfoPtr_get_TimeSinceVehicleExit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672775);
            NativeMethodInfoPtr_set_TimeSinceVehicleExit_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672776);
            NativeMethodInfoPtr_get_Crouched_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672777);
            NativeMethodInfoPtr_set_Crouched_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672778);
            NativeMethodInfoPtr_get_CurrentBed_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672779);
            NativeMethodInfoPtr_set_CurrentBed_Public_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672780);
            NativeMethodInfoPtr_get_IsReadyToSleep_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672781);
            NativeMethodInfoPtr_set_IsReadyToSleep_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672782);
            NativeMethodInfoPtr_get_IsSkating_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672783);
            NativeMethodInfoPtr_set_IsSkating_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672784);
            NativeMethodInfoPtr_get_ActiveSkateboard_Public_get_Skateboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672785);
            NativeMethodInfoPtr_set_ActiveSkateboard_Private_set_Void_Skateboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672786);
            NativeMethodInfoPtr_get_IsSleeping_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672787);
            NativeMethodInfoPtr_set_IsSleeping_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672788);
            NativeMethodInfoPtr_get_IsRagdolled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672789);
            NativeMethodInfoPtr_set_IsRagdolled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672790);
            NativeMethodInfoPtr_get_IsArrested_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672791);
            NativeMethodInfoPtr_set_IsArrested_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672792);
            NativeMethodInfoPtr_get_IsTased_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672793);
            NativeMethodInfoPtr_set_IsTased_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672794);
            NativeMethodInfoPtr_get_IsUnconscious_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672795);
            NativeMethodInfoPtr_set_IsUnconscious_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672796);
            NativeMethodInfoPtr_get_Scale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672797);
            NativeMethodInfoPtr_set_Scale_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672798);
            NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672799);
            NativeMethodInfoPtr_set_CurrentProperty_Protected_set_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672800);
            NativeMethodInfoPtr_get_LastVisitedProperty_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672801);
            NativeMethodInfoPtr_set_LastVisitedProperty_Protected_set_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672802);
            NativeMethodInfoPtr_get_CurrentBusiness_Public_get_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672803);
            NativeMethodInfoPtr_set_CurrentBusiness_Protected_set_Void_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672804);
            NativeMethodInfoPtr_get_PlayerBasePosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672805);
            NativeMethodInfoPtr_get_CameraPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672806);
            NativeMethodInfoPtr_set_CameraPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672807);
            NativeMethodInfoPtr_get_CameraRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672808);
            NativeMethodInfoPtr_set_CameraRotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672809);
            NativeMethodInfoPtr_get_CurrentAvatarSettings_Public_get_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672810);
            NativeMethodInfoPtr_set_CurrentAvatarSettings_Protected_set_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672811);
            NativeMethodInfoPtr_get_ConsumedProduct_Public_get_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672812);
            NativeMethodInfoPtr_set_ConsumedProduct_Private_set_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672813);
            NativeMethodInfoPtr_get_TimeSinceProductConsumed_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672814);
            NativeMethodInfoPtr_set_TimeSinceProductConsumed_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672815);
            NativeMethodInfoPtr_LoadDebugAvatarSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672816);
            NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672817);
            NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672818);
            NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672819);
            NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672820);
            NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672821);
            NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672822);
            NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672823);
            NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672824);
            NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672825);
            NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672826);
            NativeMethodInfoPtr_get_avatarVisibleToLocalPlayer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672827);
            NativeMethodInfoPtr_set_avatarVisibleToLocalPlayer_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672828);
            NativeMethodInfoPtr_get_playerDataRetrieveReturned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672829);
            NativeMethodInfoPtr_set_playerDataRetrieveReturned_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672830);
            NativeMethodInfoPtr_get_playerSaveRequestReturned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672831);
            NativeMethodInfoPtr_set_playerSaveRequestReturned_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672832);
            NativeMethodInfoPtr_get_PlayerInitializedOverNetwork_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672833);
            NativeMethodInfoPtr_set_PlayerInitializedOverNetwork_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672834);
            NativeMethodInfoPtr_get_Paranoid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672835);
            NativeMethodInfoPtr_set_Paranoid_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672836);
            NativeMethodInfoPtr_get_Sneaky_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672837);
            NativeMethodInfoPtr_set_Sneaky_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672838);
            NativeMethodInfoPtr_get_Disoriented_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672839);
            NativeMethodInfoPtr_set_Disoriented_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672840);
            NativeMethodInfoPtr_get_Seizure_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672841);
            NativeMethodInfoPtr_set_Seizure_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672842);
            NativeMethodInfoPtr_get_Slippery_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672843);
            NativeMethodInfoPtr_set_Slippery_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672844);
            NativeMethodInfoPtr_get_Schizophrenic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672845);
            NativeMethodInfoPtr_set_Schizophrenic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672846);
            NativeMethodInfoPtr_GetPlayer_Public_Static_Player_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672847);
            NativeMethodInfoPtr_GetRandomPlayer_Public_Static_Player_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672848);
            NativeMethodInfoPtr_GetPlayer_Public_Static_Player_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672849);
            NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672850);
            NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672851);
            NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672852);
            NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672853);
            NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672854);
            NativeMethodInfoPtr_PlayerLoaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672855);
            NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672856);
            NativeMethodInfoPtr_RequestSavePlayer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672857);
            NativeMethodInfoPtr_ReturnSaveRequest_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672858);
            NativeMethodInfoPtr_HostExitedGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672859);
            NativeMethodInfoPtr_ClientConnectionStateChanged_Private_Void_ClientConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672860);
            NativeMethodInfoPtr_SendPlayerNameData_Public_Void_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672861);
            NativeMethodInfoPtr_RequestPlayerData_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672862);
            NativeMethodInfoPtr_MarkPlayerInitialized_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672863);
            NativeMethodInfoPtr_ReceivePlayerData_Public_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672864);
            NativeMethodInfoPtr_SetGravityMultiplier_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672865);
            NativeMethodInfoPtr_ReceivePlayerNameData_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672866);
            NativeMethodInfoPtr_SendFlashlightOn_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672867);
            NativeMethodInfoPtr_SendFlashlightOnNetworked_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672868);
            NativeMethodInfoPtr_SetFlashlightOn_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672869);
            NativeMethodInfoPtr_OnStopClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672870);
            NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672871);
            NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672872);
            NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672873);
            NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672874);
            NativeMethodInfoPtr_RecalculateCurrentProperty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672875);
            NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672876);
            NativeMethodInfoPtr_ApplyMovementVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672877);
            NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672878);
            NativeMethodInfoPtr_PlayJumpAnimation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672879);
            NativeMethodInfoPtr_GetIsGrounded_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672880);
            NativeMethodInfoPtr_SendCrouched_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672881);
            NativeMethodInfoPtr_SetCrouchedLocal_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672882);
            NativeMethodInfoPtr_ReceiveCrouched_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672883);
            NativeMethodInfoPtr_SendAvatarSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672884);
            NativeMethodInfoPtr_SetAvatarSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672885);
            NativeMethodInfoPtr_SetVisible_Networked_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672886);
            NativeMethodInfoPtr_EnterVehicle_Public_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672887);
            NativeMethodInfoPtr_ExitVehicle_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672888);
            NativeMethodInfoPtr_PreDestroyClientObjects_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672889);
            NativeMethodInfoPtr_CurrentVehicleChanged_Private_Void_NetworkObject_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672890);
            NativeMethodInfoPtr_AreAllPlayersReadyToSleep_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672891);
            NativeMethodInfoPtr_SleepStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672892);
            NativeMethodInfoPtr_SetReadyToSleep_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672893);
            NativeMethodInfoPtr_SleepEnd_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672894);
            NativeMethodInfoPtr_Activate_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672895);
            NativeMethodInfoPtr_Deactivate_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672896);
            NativeMethodInfoPtr_ExitAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672897);
            NativeMethodInfoPtr_SetVisibleToLocalPlayer_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672898);
            NativeMethodInfoPtr_SetPlayerCode_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672899);
            NativeMethodInfoPtr_SendPunch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672900);
            NativeMethodInfoPtr_Punch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672901);
            NativeMethodInfoPtr_MarkIntroCompleted_Private_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672902);
            NativeMethodInfoPtr_IsPointVisibleToPlayer_Public_Boolean_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672903);
            NativeMethodInfoPtr_GetClosestPlayer_Public_Static_Player_Vector3_byref_Single_List_1_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672904);
            NativeMethodInfoPtr_SetCapsuleColliderHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672905);
            NativeMethodInfoPtr_SetScale_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672906);
            NativeMethodInfoPtr_SetScale_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672907);
            NativeMethodInfoPtr_ApplyScale_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672908);
            NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672909);
            NativeMethodInfoPtr_GetPlayerData_Public_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672910);
            NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672911);
            NativeMethodInfoPtr_GetInventoryString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672912);
            NativeMethodInfoPtr_GetAppearanceString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672913);
            NativeMethodInfoPtr_GetClothingString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672914);
            NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PlayerData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672915);
            NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672916);
            NativeMethodInfoPtr_LoadInventory_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672917);
            NativeMethodInfoPtr_LoadAppearance_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672918);
            NativeMethodInfoPtr_LoadClothing_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672919);
            NativeMethodInfoPtr_SetRagdolled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672920);
            NativeMethodInfoPtr_SendImpact_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672921);
            NativeMethodInfoPtr_ReceiveImpact_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672922);
            NativeMethodInfoPtr_ProcessImpactForce_Public_Virtual_New_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672923);
            NativeMethodInfoPtr_OnDied_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672924);
            NativeMethodInfoPtr_OnRevived_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672925);
            NativeMethodInfoPtr_Arrest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672926);
            NativeMethodInfoPtr_Free_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672927);
            NativeMethodInfoPtr_SendPassOut_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672928);
            NativeMethodInfoPtr_PassOut_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672929);
            NativeMethodInfoPtr_SendPassOutRecovery_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672930);
            NativeMethodInfoPtr_PassOutRecovery_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672931);
            NativeMethodInfoPtr_SendEquippable_Networked_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672932);
            NativeMethodInfoPtr_SetEquippable_Networked_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672933);
            NativeMethodInfoPtr_SendEquippableMessage_Networked_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672934);
            NativeMethodInfoPtr_ReceiveEquippableMessage_Networked_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672935);
            NativeMethodInfoPtr_SendEquippableMessage_Networked_Vector_Public_Void_String_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672936);
            NativeMethodInfoPtr_ReceiveEquippableMessage_Networked_Vector_Private_Void_String_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672937);
            NativeMethodInfoPtr_SendAnimationTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672938);
            NativeMethodInfoPtr_SetAnimationTrigger_Networked_Public_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672939);
            NativeMethodInfoPtr_SetAnimationTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672940);
            NativeMethodInfoPtr_ResetAnimationTrigger_Networked_Public_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672941);
            NativeMethodInfoPtr_ResetAnimationTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672942);
            NativeMethodInfoPtr_SendAnimationBool_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672943);
            NativeMethodInfoPtr_SetAnimationBool_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672944);
            NativeMethodInfoPtr_Taze_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672945);
            NativeMethodInfoPtr_SetInventoryItem_Public_Void_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672946);
            NativeMethodInfoPtr_GetNetworth_Private_Void_FloatContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672947);
            NativeMethodInfoPtr_SendAppearance_Public_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672948);
            NativeMethodInfoPtr_SetAppearance_Public_Void_BasicAvatarSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672949);
            NativeMethodInfoPtr_MountSkateboard_Public_Void_Skateboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672950);
            NativeMethodInfoPtr_SendMountedSkateboard_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672951);
            NativeMethodInfoPtr_SetMountedSkateboard_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672952);
            NativeMethodInfoPtr_DismountSkateboard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672953);
            NativeMethodInfoPtr_ConsumeProduct_Public_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672954);
            NativeMethodInfoPtr_SendConsumeProduct_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672955);
            NativeMethodInfoPtr_ReceiveConsumeProduct_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672956);
            NativeMethodInfoPtr_ConsumeProductInternal_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672957);
            NativeMethodInfoPtr_ClearProduct_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672958);
            NativeMethodInfoPtr_CreatePlayerVariables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672959);
            NativeMethodInfoPtr_GetVariable_Public_BaseVariable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672960);
            NativeMethodInfoPtr_GetValue_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672961);
            NativeMethodInfoPtr_SetVariableValue_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672962);
            NativeMethodInfoPtr_AddVariable_Public_Void_BaseVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672963);
            NativeMethodInfoPtr_SendValue_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672964);
            NativeMethodInfoPtr_ReceiveValue_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672965);
            NativeMethodInfoPtr_ReceiveValue_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672966);
            NativeMethodInfoPtr_LoadVariable_Public_Void_VariableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672967);
            NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672968);
            NativeMethodInfoPtr__RecalculateCurrentProperty_b__248_0_Private_Single_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672970);
            NativeMethodInfoPtr__RecalculateCurrentProperty_b__248_1_Private_Single_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672971);
            NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672972);
            NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672973);
            NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672974);
            NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672975);
            NativeMethodInfoPtr_RpcWriter___Server_set_CurrentVehicle_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672976);
            NativeMethodInfoPtr_RpcLogic___set_CurrentVehicle_3323014238_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672977);
            NativeMethodInfoPtr_RpcReader___Server_set_CurrentVehicle_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672978);
            NativeMethodInfoPtr_RpcWriter___Server_set_CurrentBed_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672979);
            NativeMethodInfoPtr_RpcLogic___set_CurrentBed_3323014238_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672980);
            NativeMethodInfoPtr_RpcReader___Server_set_CurrentBed_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672981);
            NativeMethodInfoPtr_RpcWriter___Server_set_IsSkating_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672982);
            NativeMethodInfoPtr_RpcLogic___set_IsSkating_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672983);
            NativeMethodInfoPtr_RpcReader___Server_set_IsSkating_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672984);
            NativeMethodInfoPtr_RpcWriter___Server_set_CameraPosition_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672985);
            NativeMethodInfoPtr_RpcLogic___set_CameraPosition_4276783012_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672986);
            NativeMethodInfoPtr_RpcReader___Server_set_CameraPosition_4276783012_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672987);
            NativeMethodInfoPtr_RpcWriter___Server_set_CameraRotation_3429297120_Private_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672988);
            NativeMethodInfoPtr_RpcLogic___set_CameraRotation_3429297120_Public_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672989);
            NativeMethodInfoPtr_RpcReader___Server_set_CameraRotation_3429297120_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672990);
            NativeMethodInfoPtr_RpcWriter___Server_RequestSavePlayer_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672991);
            NativeMethodInfoPtr_RpcLogic___RequestSavePlayer_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672992);
            NativeMethodInfoPtr_RpcReader___Server_RequestSavePlayer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672993);
            NativeMethodInfoPtr_RpcWriter___Observers_ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672994);
            NativeMethodInfoPtr_RpcLogic___ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672995);
            NativeMethodInfoPtr_RpcReader___Observers_ReturnSaveRequest_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672996);
            NativeMethodInfoPtr_RpcWriter___Target_ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672997);
            NativeMethodInfoPtr_RpcReader___Target_ReturnSaveRequest_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672998);
            NativeMethodInfoPtr_RpcWriter___Observers_HostExitedGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672999);
            NativeMethodInfoPtr_RpcLogic___HostExitedGame_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673000);
            NativeMethodInfoPtr_RpcReader___Observers_HostExitedGame_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673001);
            NativeMethodInfoPtr_RpcWriter___Server_SendPlayerNameData_586648380_Private_Void_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673002);
            NativeMethodInfoPtr_RpcLogic___SendPlayerNameData_586648380_Public_Void_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673003);
            NativeMethodInfoPtr_RpcReader___Server_SendPlayerNameData_586648380_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673004);
            NativeMethodInfoPtr_RpcWriter___Server_RequestPlayerData_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673005);
            NativeMethodInfoPtr_RpcLogic___RequestPlayerData_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673006);
            NativeMethodInfoPtr_RpcReader___Server_RequestPlayerData_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673007);
            NativeMethodInfoPtr_RpcWriter___Server_MarkPlayerInitialized_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673008);
            NativeMethodInfoPtr_RpcLogic___MarkPlayerInitialized_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673009);
            NativeMethodInfoPtr_RpcReader___Server_MarkPlayerInitialized_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673010);
            NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerData_3244732873_Private_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673011);
            NativeMethodInfoPtr_RpcLogic___ReceivePlayerData_3244732873_Public_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673012);
            NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerData_3244732873_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673013);
            NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerData_3244732873_Private_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673014);
            NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerData_3244732873_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673015);
            NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673016);
            NativeMethodInfoPtr_RpcLogic___ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673017);
            NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerNameData_3895153758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673018);
            NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673019);
            NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerNameData_3895153758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673020);
            NativeMethodInfoPtr_RpcWriter___Server_SendFlashlightOnNetworked_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673021);
            NativeMethodInfoPtr_RpcLogic___SendFlashlightOnNetworked_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673022);
            NativeMethodInfoPtr_RpcReader___Server_SendFlashlightOnNetworked_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673023);
            NativeMethodInfoPtr_RpcWriter___Observers_SetFlashlightOn_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673024);
            NativeMethodInfoPtr_RpcLogic___SetFlashlightOn_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673025);
            NativeMethodInfoPtr_RpcReader___Observers_SetFlashlightOn_1140765316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673026);
            NativeMethodInfoPtr_RpcWriter___Observers_PlayJumpAnimation_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673027);
            NativeMethodInfoPtr_RpcLogic___PlayJumpAnimation_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673028);
            NativeMethodInfoPtr_RpcReader___Observers_PlayJumpAnimation_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673029);
            NativeMethodInfoPtr_RpcWriter___Server_SendCrouched_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673030);
            NativeMethodInfoPtr_RpcLogic___SendCrouched_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673031);
            NativeMethodInfoPtr_RpcReader___Server_SendCrouched_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673032);
            NativeMethodInfoPtr_RpcWriter___Target_ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673033);
            NativeMethodInfoPtr_RpcLogic___ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673034);
            NativeMethodInfoPtr_RpcReader___Target_ReceiveCrouched_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673035);
            NativeMethodInfoPtr_RpcWriter___Observers_ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673036);
            NativeMethodInfoPtr_RpcReader___Observers_ReceiveCrouched_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673037);
            NativeMethodInfoPtr_RpcWriter___Server_SendAvatarSettings_4281687581_Private_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673038);
            NativeMethodInfoPtr_RpcLogic___SendAvatarSettings_4281687581_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673039);
            NativeMethodInfoPtr_RpcReader___Server_SendAvatarSettings_4281687581_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673040);
            NativeMethodInfoPtr_RpcWriter___Observers_SetAvatarSettings_4281687581_Private_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673041);
            NativeMethodInfoPtr_RpcLogic___SetAvatarSettings_4281687581_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673042);
            NativeMethodInfoPtr_RpcReader___Observers_SetAvatarSettings_4281687581_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673043);
            NativeMethodInfoPtr_RpcWriter___Observers_SetVisible_Networked_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673044);
            NativeMethodInfoPtr_RpcLogic___SetVisible_Networked_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673045);
            NativeMethodInfoPtr_RpcReader___Observers_SetVisible_Networked_1140765316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673046);
            NativeMethodInfoPtr_RpcWriter___Server_SetReadyToSleep_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673047);
            NativeMethodInfoPtr_RpcLogic___SetReadyToSleep_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673048);
            NativeMethodInfoPtr_RpcReader___Server_SetReadyToSleep_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673049);
            NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerCode_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673050);
            NativeMethodInfoPtr_RpcLogic___SetPlayerCode_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673051);
            NativeMethodInfoPtr_RpcReader___Observers_SetPlayerCode_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673052);
            NativeMethodInfoPtr_RpcWriter___Server_SendPunch_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673053);
            NativeMethodInfoPtr_RpcLogic___SendPunch_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673054);
            NativeMethodInfoPtr_RpcReader___Server_SendPunch_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673055);
            NativeMethodInfoPtr_RpcWriter___Observers_Punch_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673056);
            NativeMethodInfoPtr_RpcLogic___Punch_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673057);
            NativeMethodInfoPtr_RpcReader___Observers_Punch_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673058);
            NativeMethodInfoPtr_RpcWriter___Server_MarkIntroCompleted_3281254764_Private_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673059);
            NativeMethodInfoPtr_RpcLogic___MarkIntroCompleted_3281254764_Private_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673060);
            NativeMethodInfoPtr_RpcReader___Server_MarkIntroCompleted_3281254764_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673061);
            NativeMethodInfoPtr_RpcWriter___Server_SendImpact_427288424_Private_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673062);
            NativeMethodInfoPtr_RpcLogic___SendImpact_427288424_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673063);
            NativeMethodInfoPtr_RpcReader___Server_SendImpact_427288424_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673064);
            NativeMethodInfoPtr_RpcWriter___Observers_ReceiveImpact_427288424_Private_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673065);
            NativeMethodInfoPtr_RpcLogic___ReceiveImpact_427288424_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673066);
            NativeMethodInfoPtr_RpcReader___Observers_ReceiveImpact_427288424_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673067);
            NativeMethodInfoPtr_RpcWriter___Observers_Arrest_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673068);
            NativeMethodInfoPtr_RpcLogic___Arrest_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673069);
            NativeMethodInfoPtr_RpcReader___Observers_Arrest_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673070);
            NativeMethodInfoPtr_RpcWriter___Server_SendPassOut_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673071);
            NativeMethodInfoPtr_RpcLogic___SendPassOut_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673072);
            NativeMethodInfoPtr_RpcReader___Server_SendPassOut_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673073);
            NativeMethodInfoPtr_RpcWriter___Observers_PassOut_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673074);
            NativeMethodInfoPtr_RpcLogic___PassOut_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673075);
            NativeMethodInfoPtr_RpcReader___Observers_PassOut_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673076);
            NativeMethodInfoPtr_RpcWriter___Server_SendPassOutRecovery_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673077);
            NativeMethodInfoPtr_RpcLogic___SendPassOutRecovery_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673078);
            NativeMethodInfoPtr_RpcReader___Server_SendPassOutRecovery_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673079);
            NativeMethodInfoPtr_RpcWriter___Observers_PassOutRecovery_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673080);
            NativeMethodInfoPtr_RpcLogic___PassOutRecovery_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673081);
            NativeMethodInfoPtr_RpcReader___Observers_PassOutRecovery_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673082);
            NativeMethodInfoPtr_RpcWriter___Server_SendEquippable_Networked_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673083);
            NativeMethodInfoPtr_RpcLogic___SendEquippable_Networked_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673084);
            NativeMethodInfoPtr_RpcReader___Server_SendEquippable_Networked_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673085);
            NativeMethodInfoPtr_RpcWriter___Observers_SetEquippable_Networked_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673086);
            NativeMethodInfoPtr_RpcLogic___SetEquippable_Networked_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673087);
            NativeMethodInfoPtr_RpcReader___Observers_SetEquippable_Networked_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673088);
            NativeMethodInfoPtr_RpcWriter___Server_SendEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673089);
            NativeMethodInfoPtr_RpcLogic___SendEquippableMessage_Networked_3643459082_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673090);
            NativeMethodInfoPtr_RpcReader___Server_SendEquippableMessage_Networked_3643459082_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673091);
            NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673092);
            NativeMethodInfoPtr_RpcLogic___ReceiveEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673093);
            NativeMethodInfoPtr_RpcReader___Observers_ReceiveEquippableMessage_Networked_3643459082_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673094);
            NativeMethodInfoPtr_RpcWriter___Server_SendEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673095);
            NativeMethodInfoPtr_RpcLogic___SendEquippableMessage_Networked_Vector_3190074053_Public_Void_String_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673096);
            NativeMethodInfoPtr_RpcReader___Server_SendEquippableMessage_Networked_Vector_3190074053_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673097);
            NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673098);
            NativeMethodInfoPtr_RpcLogic___ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673099);
            NativeMethodInfoPtr_RpcReader___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673100);
            NativeMethodInfoPtr_RpcWriter___Server_SendAnimationTrigger_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673101);
            NativeMethodInfoPtr_RpcLogic___SendAnimationTrigger_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673102);
            NativeMethodInfoPtr_RpcReader___Server_SendAnimationTrigger_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673103);
            NativeMethodInfoPtr_RpcWriter___Observers_SetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673104);
            NativeMethodInfoPtr_RpcLogic___SetAnimationTrigger_Networked_2971853958_Public_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673105);
            NativeMethodInfoPtr_RpcReader___Observers_SetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673106);
            NativeMethodInfoPtr_RpcWriter___Target_SetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673107);
            NativeMethodInfoPtr_RpcReader___Target_SetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673108);
            NativeMethodInfoPtr_RpcWriter___Observers_ResetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673109);
            NativeMethodInfoPtr_RpcLogic___ResetAnimationTrigger_Networked_2971853958_Public_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673110);
            NativeMethodInfoPtr_RpcReader___Observers_ResetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673111);
            NativeMethodInfoPtr_RpcWriter___Target_ResetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673112);
            NativeMethodInfoPtr_RpcReader___Target_ResetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673113);
            NativeMethodInfoPtr_RpcWriter___Server_SendAnimationBool_310431262_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673114);
            NativeMethodInfoPtr_RpcLogic___SendAnimationBool_310431262_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673115);
            NativeMethodInfoPtr_RpcReader___Server_SendAnimationBool_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673116);
            NativeMethodInfoPtr_RpcWriter___Observers_SetAnimationBool_310431262_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673117);
            NativeMethodInfoPtr_RpcLogic___SetAnimationBool_310431262_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673118);
            NativeMethodInfoPtr_RpcReader___Observers_SetAnimationBool_310431262_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673119);
            NativeMethodInfoPtr_RpcWriter___Observers_Taze_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673120);
            NativeMethodInfoPtr_RpcLogic___Taze_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673121);
            NativeMethodInfoPtr_RpcReader___Observers_Taze_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673122);
            NativeMethodInfoPtr_RpcWriter___Server_SetInventoryItem_2317364410_Private_Void_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673123);
            NativeMethodInfoPtr_RpcLogic___SetInventoryItem_2317364410_Public_Void_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673124);
            NativeMethodInfoPtr_RpcReader___Server_SetInventoryItem_2317364410_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673125);
            NativeMethodInfoPtr_RpcWriter___Server_SendAppearance_3281254764_Private_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673126);
            NativeMethodInfoPtr_RpcLogic___SendAppearance_3281254764_Public_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673127);
            NativeMethodInfoPtr_RpcReader___Server_SendAppearance_3281254764_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673128);
            NativeMethodInfoPtr_RpcWriter___Observers_SetAppearance_2139595489_Private_Void_BasicAvatarSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673129);
            NativeMethodInfoPtr_RpcLogic___SetAppearance_2139595489_Public_Void_BasicAvatarSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673130);
            NativeMethodInfoPtr_RpcReader___Observers_SetAppearance_2139595489_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673131);
            NativeMethodInfoPtr_RpcWriter___Server_SendMountedSkateboard_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673132);
            NativeMethodInfoPtr_RpcLogic___SendMountedSkateboard_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673133);
            NativeMethodInfoPtr_RpcReader___Server_SendMountedSkateboard_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673134);
            NativeMethodInfoPtr_RpcWriter___Observers_SetMountedSkateboard_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673135);
            NativeMethodInfoPtr_RpcLogic___SetMountedSkateboard_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673136);
            NativeMethodInfoPtr_RpcReader___Observers_SetMountedSkateboard_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673137);
            NativeMethodInfoPtr_RpcWriter___Server_SendConsumeProduct_2622925554_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673138);
            NativeMethodInfoPtr_RpcLogic___SendConsumeProduct_2622925554_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673139);
            NativeMethodInfoPtr_RpcReader___Server_SendConsumeProduct_2622925554_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673140);
            NativeMethodInfoPtr_RpcWriter___Observers_ReceiveConsumeProduct_2622925554_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673141);
            NativeMethodInfoPtr_RpcLogic___ReceiveConsumeProduct_2622925554_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673142);
            NativeMethodInfoPtr_RpcReader___Observers_ReceiveConsumeProduct_2622925554_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673143);
            NativeMethodInfoPtr_RpcWriter___Server_SendValue_3589193952_Private_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673144);
            NativeMethodInfoPtr_RpcLogic___SendValue_3589193952_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673145);
            NativeMethodInfoPtr_RpcReader___Server_SendValue_3589193952_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673146);
            NativeMethodInfoPtr_RpcWriter___Target_ReceiveValue_3895153758_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673147);
            NativeMethodInfoPtr_RpcLogic___ReceiveValue_3895153758_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673148);
            NativeMethodInfoPtr_RpcReader___Target_ReceiveValue_3895153758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673149);
            NativeMethodInfoPtr_sync___get_value__PlayerName_k__BackingField_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673150);
            NativeMethodInfoPtr_sync___set_value__PlayerName_k__BackingField_Public_set_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673151);
            NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_PlayerScripts_Player_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673152);
            NativeMethodInfoPtr_sync___get_value__PlayerCode_k__BackingField_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673153);
            NativeMethodInfoPtr_sync___set_value__PlayerCode_k__BackingField_Public_set_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673154);
            NativeMethodInfoPtr_sync___get_value__CurrentVehicle_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673155);
            NativeMethodInfoPtr_sync___set_value__CurrentVehicle_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673156);
            NativeMethodInfoPtr_sync___get_value__CurrentBed_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673157);
            NativeMethodInfoPtr_sync___set_value__CurrentBed_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673158);
            NativeMethodInfoPtr_sync___get_value__IsReadyToSleep_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673159);
            NativeMethodInfoPtr_sync___set_value__IsReadyToSleep_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673160);
            NativeMethodInfoPtr_sync___get_value__CameraPosition_k__BackingField_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673161);
            NativeMethodInfoPtr_sync___set_value__CameraPosition_k__BackingField_Public_set_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673162);
            NativeMethodInfoPtr_sync___get_value__CameraRotation_k__BackingField_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673163);
            NativeMethodInfoPtr_sync___set_value__CameraRotation_k__BackingField_Public_set_Void_Quaternion_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673164);
            NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673165);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166411, XrefRangeEnd = 166412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void LoadDebugAvatarSettings()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadDebugAvatarSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(9)]
        [CachedScanResults(RefRangeStart = 166443, RefRangeEnd = 166452, XrefRangeStart = 166426, XrefRangeEnd = 166443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe static Player GetPlayer(NetworkConnection conn)
        {
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlayer_Public_Static_Player_NetworkConnection_0, (System.IntPtr)0, (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Player>(intPtr) : null;
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 166490, RefRangeEnd = 166492, XrefRangeStart = 166452, XrefRangeEnd = 166490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe static Player GetRandomPlayer(bool excludeArrestedOrDead = true, bool excludeSleeping = true)
        {
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = (nint)(&excludeArrestedOrDead);
            *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &excludeSleeping;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomPlayer_Public_Static_Player_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Player>(intPtr) : null;
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 166511, RefRangeEnd = 166512, XrefRangeStart = 166492, XrefRangeEnd = 166511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe static Player GetPlayer(string playerCode)
        {
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlayer_Public_Static_Player_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Player>(intPtr) : null;
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166512, XrefRangeEnd = 166513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe override void Awake()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166513, XrefRangeEnd = 166519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe virtual void InitializeSaveable()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166519, XrefRangeEnd = 166554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe virtual void Start()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166554, XrefRangeEnd = 166590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe virtual void OnDestroy()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166590, XrefRangeEnd = 166762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe override void OnStartClient()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 166866, RefRangeEnd = 166868, XrefRangeStart = 166762, XrefRangeEnd = 166866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void PlayerLoaded()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayerLoaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166868, XrefRangeEnd = 166891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe override void OnSpawnServer(NetworkConnection connection)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 166912, RefRangeEnd = 166914, XrefRangeStart = 166891, XrefRangeEnd = 166912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RequestSavePlayer()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequestSavePlayer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 166945, RefRangeEnd = 166946, XrefRangeStart = 166914, XrefRangeEnd = 166945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void ReturnSaveRequest(NetworkConnection conn, bool successful)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &successful;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReturnSaveRequest_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 166967, RefRangeEnd = 166968, XrefRangeStart = 166946, XrefRangeEnd = 166967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void HostExitedGame()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HostExitedGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166968, XrefRangeEnd = 166998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void ClientConnectionStateChanged(ClientConnectionStateArgs args)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&args);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClientConnectionStateChanged_Private_Void_ClientConnectionStateArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166998, XrefRangeEnd = 167000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SendPlayerNameData(string playerName, ulong id)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(playerName);
            *(ulong**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendPlayerNameData_Public_Void_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167000, XrefRangeEnd = 167019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RequestPlayerData(string playerCode)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequestPlayerData_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167019, XrefRangeEnd = 167051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void MarkPlayerInitialized()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkPlayerInitialized_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 167101, RefRangeEnd = 167103, XrefRangeStart = 167051, XrefRangeEnd = 167101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void ReceivePlayerData(NetworkConnection conn, PlayerData data, string inventoryString, string appearanceString, string clothigString, Il2CppReferenceArray<VariableData> vars)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[6];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(data);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(inventoryString);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(appearanceString);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(clothigString);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(vars);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReceivePlayerData_Public_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 167134, RefRangeEnd = 167137, XrefRangeStart = 167103, XrefRangeEnd = 167134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SetGravityMultiplier(float multiplier)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&multiplier);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGravityMultiplier_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 167181, RefRangeEnd = 167183, XrefRangeStart = 167137, XrefRangeEnd = 167181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void ReceivePlayerNameData(NetworkConnection conn, string playerName, string id)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(playerName);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(id);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReceivePlayerNameData_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 167205, RefRangeEnd = 167207, XrefRangeStart = 167183, XrefRangeEnd = 167205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SendFlashlightOn(bool on)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&on);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendFlashlightOn_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 167205, RefRangeEnd = 167207, XrefRangeStart = 167205, XrefRangeEnd = 167207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SendFlashlightOnNetworked(bool on)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&on);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendFlashlightOnNetworked_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 167231, RefRangeEnd = 167234, XrefRangeStart = 167207, XrefRangeEnd = 167231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SetFlashlightOn(bool on)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&on);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFlashlightOn_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167234, XrefRangeEnd = 167243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe override void OnStopClient()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnStopClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167243, XrefRangeEnd = 167253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe override void OnStartServer()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167253, XrefRangeEnd = 167305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe virtual void Update()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167305, XrefRangeEnd = 167309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe virtual void MinPass()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167309, XrefRangeEnd = 167382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe virtual void LateUpdate()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167382, XrefRangeEnd = 167431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RecalculateCurrentProperty()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecalculateCurrentProperty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167431, XrefRangeEnd = 167432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void FixedUpdate()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 167490, RefRangeEnd = 167491, XrefRangeStart = 167432, XrefRangeEnd = 167490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void ApplyMovementVisuals()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyMovementVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 167503, RefRangeEnd = 167505, XrefRangeStart = 167491, XrefRangeEnd = 167503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SetVisible(bool vis, bool network = false)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = (nint)(&vis);
            *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &network;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 167523, RefRangeEnd = 167524, XrefRangeStart = 167505, XrefRangeEnd = 167523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void PlayJumpAnimation()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayJumpAnimation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 167543, RefRangeEnd = 167545, XrefRangeStart = 167524, XrefRangeEnd = 167543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe bool GetIsGrounded()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIsGrounded_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 167567, RefRangeEnd = 167568, XrefRangeStart = 167545, XrefRangeEnd = 167567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SendCrouched(bool crouched)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&crouched);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendCrouched_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 166275, RefRangeEnd = 166276, XrefRangeStart = 166275, XrefRangeEnd = 166276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SetCrouchedLocal(bool crouched)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&crouched);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCrouchedLocal_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(4)]
        [CachedScanResults(RefRangeStart = 167578, RefRangeEnd = 167582, XrefRangeStart = 167568, XrefRangeEnd = 167578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void ReceiveCrouched(NetworkConnection conn, bool crouched)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &crouched;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReceiveCrouched_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167582, XrefRangeEnd = 167615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SendAvatarSettings(AvatarSettings settings)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendAvatarSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 167637, RefRangeEnd = 167640, XrefRangeStart = 167615, XrefRangeEnd = 167637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SetAvatarSettings(AvatarSettings settings)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAvatarSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167640, XrefRangeEnd = 167659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SetVisible_Networked(bool vis)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&vis);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVisible_Networked_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 167674, RefRangeEnd = 167675, XrefRangeStart = 167659, XrefRangeEnd = 167674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void EnterVehicle(LandVehicle vehicle)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnterVehicle_Public_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 167716, RefRangeEnd = 167717, XrefRangeStart = 167675, XrefRangeEnd = 167716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void ExitVehicle(Transform exitPoint)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(exitPoint);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExitVehicle_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167717, XrefRangeEnd = 167742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void PreDestroyClientObjects(NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreDestroyClientObjects_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167742, XrefRangeEnd = 167763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void CurrentVehicleChanged(NetworkObject oldVeh, NetworkObject newVeh, bool asServer)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(oldVeh);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newVeh);
            *(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &asServer;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CurrentVehicleChanged_Private_Void_NetworkObject_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 167786, RefRangeEnd = 167787, XrefRangeStart = 167763, XrefRangeEnd = 167786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe static bool AreAllPlayersReadyToSleep()
        {
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AreAllPlayersReadyToSleep_Public_Static_Boolean_0, (System.IntPtr)0, (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167787, XrefRangeEnd = 167788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SleepStart()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SleepStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 167810, RefRangeEnd = 167813, XrefRangeStart = 167788, XrefRangeEnd = 167810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SetReadyToSleep(bool ready)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&ready);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetReadyToSleep_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        public unsafe void SleepEnd(int minsSlept)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&minsSlept);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SleepEnd_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 167837, RefRangeEnd = 167838, XrefRangeStart = 167813, XrefRangeEnd = 167837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe static void Activate()
        {
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Activate_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 167860, RefRangeEnd = 167862, XrefRangeStart = 167838, XrefRangeEnd = 167860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe static void Deactivate(bool freeMouse)
        {
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&freeMouse);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deactivate_Public_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 167901, RefRangeEnd = 167904, XrefRangeStart = 167862, XrefRangeEnd = 167901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void ExitAll()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExitAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(4)]
        [CachedScanResults(RefRangeStart = 167914, RefRangeEnd = 167918, XrefRangeStart = 167904, XrefRangeEnd = 167914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SetVisibleToLocalPlayer(bool vis)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&vis);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVisibleToLocalPlayer_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167918, XrefRangeEnd = 167940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SetPlayerCode(string code)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(code);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPlayerCode_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 167968, RefRangeEnd = 167969, XrefRangeStart = 167940, XrefRangeEnd = 167968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SendPunch()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendPunch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167969, XrefRangeEnd = 167987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void Punch()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Punch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167987, XrefRangeEnd = 168020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void MarkIntroCompleted(BasicAvatarSettings appearance)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(appearance);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkIntroCompleted_Private_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 168047, RefRangeEnd = 168049, XrefRangeStart = 168020, XrefRangeEnd = 168047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe bool IsPointVisibleToPlayer(Vector3 point, float maxDistance_Visible = 30f, float minDistance_Invisible = 5f)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = (nint)(&point);
            *(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance_Visible;
            *(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &minDistance_Invisible;
            System.IntPtr exc;
            System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPointVisibleToPlayer_Public_Boolean_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
        }

        [CallerCount(18)]
        [CachedScanResults(RefRangeStart = 168088, RefRangeEnd = 168106, XrefRangeStart = 168049, XrefRangeEnd = 168088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe static Player GetClosestPlayer(Vector3 point, out float distance, List<Player> exclude = null)
        {
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = (nint)(&point);
            *(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref distance);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(exclude);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetClosestPlayer_Public_Static_Player_Vector3_byref_Single_List_1_Player_0, (System.IntPtr)0, (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Player>(intPtr) : null;
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 168109, RefRangeEnd = 168110, XrefRangeStart = 168106, XrefRangeEnd = 168109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SetCapsuleColliderHeight(float normalizedHeight)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&normalizedHeight);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCapsuleColliderHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 168110, RefRangeEnd = 168111, XrefRangeStart = 168110, XrefRangeEnd = 168110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SetScale(float scale)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&scale);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetScale_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 168125, RefRangeEnd = 168127, XrefRangeStart = 168111, XrefRangeEnd = 168125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SetScale(float scale, float lerpTime)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = (nint)(&scale);
            *(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lerpTime;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetScale_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168127, XrefRangeEnd = 168133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe virtual void ApplyScale()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ApplyScale_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168133, XrefRangeEnd = 168142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe virtual string GetSaveString()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            return IL2CPP.Il2CppStringToManaged(il2CppString);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 168150, RefRangeEnd = 168152, XrefRangeStart = 168142, XrefRangeEnd = 168150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe PlayerData GetPlayerData()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlayerData_Public_PlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerData>(intPtr) : null;
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168152, XrefRangeEnd = 168229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe virtual List<string> WriteData(string parentFolderPath)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168229, XrefRangeEnd = 168238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe string GetInventoryString()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInventoryString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            return IL2CPP.Il2CppStringToManaged(il2CppString);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168238, XrefRangeEnd = 168244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe string GetAppearanceString()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAppearanceString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            return IL2CPP.Il2CppStringToManaged(il2CppString);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 168253, RefRangeEnd = 168255, XrefRangeStart = 168244, XrefRangeEnd = 168253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe string GetClothingString()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetClothingString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            return IL2CPP.Il2CppStringToManaged(il2CppString);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168255, XrefRangeEnd = 168310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe virtual void Load(PlayerData data, string containerPath)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(containerPath);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PlayerData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168310, XrefRangeEnd = 168319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe virtual void Load(PlayerData data)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PlayerData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168319, XrefRangeEnd = 168348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe virtual void LoadInventory(string contentsString)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(contentsString);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_LoadInventory_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168348, XrefRangeEnd = 168360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe virtual void LoadAppearance(string appearanceString)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(appearanceString);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_LoadAppearance_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168360, XrefRangeEnd = 168380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe virtual void LoadClothing(string contentsString)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(contentsString);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_LoadClothing_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(4)]
        [CachedScanResults(RefRangeStart = 168395, RefRangeEnd = 168399, XrefRangeStart = 168380, XrefRangeEnd = 168395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SetRagdolled(bool ragdolled)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&ragdolled);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRagdolled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168399, XrefRangeEnd = 168420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe virtual void SendImpact(Impact impact)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SendImpact_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168420, XrefRangeEnd = 168442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe virtual void ReceiveImpact(Impact impact)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ReceiveImpact_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168442, XrefRangeEnd = 168443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe virtual void ProcessImpactForce(Vector3 forcePoint, Vector3 forceDirection, float force)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = (nint)(&forcePoint);
            *(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceDirection;
            *(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &force;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ProcessImpactForce_Public_Virtual_New_Void_Vector3_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168443, XrefRangeEnd = 168496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe virtual void OnDied()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnDied_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168496, XrefRangeEnd = 168514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe virtual void OnRevived()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnRevived_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 168535, RefRangeEnd = 168537, XrefRangeStart = 168514, XrefRangeEnd = 168535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void Arrest()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Arrest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 168593, RefRangeEnd = 168595, XrefRangeStart = 168537, XrefRangeEnd = 168593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void Free()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Free_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168595, XrefRangeEnd = 168627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SendPassOut()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendPassOut_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 168648, RefRangeEnd = 168650, XrefRangeStart = 168627, XrefRangeEnd = 168648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void PassOut()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PassOut_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 168682, RefRangeEnd = 168683, XrefRangeStart = 168650, XrefRangeEnd = 168682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SendPassOutRecovery()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendPassOutRecovery_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 168704, RefRangeEnd = 168706, XrefRangeStart = 168683, XrefRangeEnd = 168704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void PassOutRecovery()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PassOutRecovery_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(6)]
        [CachedScanResults(RefRangeStart = 168728, RefRangeEnd = 168734, XrefRangeStart = 168706, XrefRangeEnd = 168728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SendEquippable_Networked(string assetPath)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendEquippable_Networked_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 168755, RefRangeEnd = 168757, XrefRangeStart = 168734, XrefRangeEnd = 168755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SetEquippable_Networked(string assetPath)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEquippable_Networked_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 168759, RefRangeEnd = 168760, XrefRangeStart = 168757, XrefRangeEnd = 168759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SendEquippableMessage_Networked(string message, int receipt)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(message);
            *(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &receipt;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendEquippableMessage_Networked_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 168784, RefRangeEnd = 168786, XrefRangeStart = 168760, XrefRangeEnd = 168784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void ReceiveEquippableMessage_Networked(string message, int receipt)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(message);
            *(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &receipt;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReceiveEquippableMessage_Networked_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 168788, RefRangeEnd = 168789, XrefRangeStart = 168786, XrefRangeEnd = 168788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SendEquippableMessage_Networked_Vector(string message, int receipt, Vector3 data)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(message);
            *(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &receipt;
            *(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &data;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendEquippableMessage_Networked_Vector_Public_Void_String_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 168815, RefRangeEnd = 168818, XrefRangeStart = 168789, XrefRangeEnd = 168815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void ReceiveEquippableMessage_Networked_Vector(string message, int receipt, Vector3 data)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(message);
            *(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &receipt;
            *(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &data;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReceiveEquippableMessage_Networked_Vector_Private_Void_String_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 168851, RefRangeEnd = 168854, XrefRangeStart = 168818, XrefRangeEnd = 168851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SendAnimationTrigger(string trigger)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendAnimationTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 168864, RefRangeEnd = 168867, XrefRangeStart = 168854, XrefRangeEnd = 168864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SetAnimationTrigger_Networked(NetworkConnection conn, string trigger)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(trigger);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAnimationTrigger_Networked_Public_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168867, XrefRangeEnd = 168869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SetAnimationTrigger(string trigger)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAnimationTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168869, XrefRangeEnd = 168879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void ResetAnimationTrigger_Networked(NetworkConnection conn, string trigger)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(trigger);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetAnimationTrigger_Networked_Public_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168879, XrefRangeEnd = 168881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void ResetAnimationTrigger(string trigger)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetAnimationTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 168883, RefRangeEnd = 168886, XrefRangeStart = 168881, XrefRangeEnd = 168883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SendAnimationBool(string name, bool val)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(name);
            *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendAnimationBool_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 168909, RefRangeEnd = 168911, XrefRangeStart = 168886, XrefRangeEnd = 168909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SetAnimationBool(string name, bool val)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(name);
            *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAnimationBool_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 168929, RefRangeEnd = 168930, XrefRangeStart = 168911, XrefRangeEnd = 168929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void Taze()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Taze_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(4)]
        [CachedScanResults(RefRangeStart = 168933, RefRangeEnd = 168937, XrefRangeStart = 168930, XrefRangeEnd = 168933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SetInventoryItem(int index, ItemInstance item)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = (nint)(&index);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(item);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInventoryItem_Public_Void_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168937, XrefRangeEnd = 168939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void GetNetworth(MoneyManager.FloatContainer container)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNetworth_Private_Void_FloatContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 168972, RefRangeEnd = 168973, XrefRangeStart = 168939, XrefRangeEnd = 168972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SendAppearance(BasicAvatarSettings settings)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendAppearance_Public_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(7)]
        [CachedScanResults(RefRangeStart = 168996, RefRangeEnd = 169003, XrefRangeStart = 168973, XrefRangeEnd = 168996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SetAppearance(BasicAvatarSettings settings, bool refreshClothing)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
            *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &refreshClothing;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAppearance_Public_Void_BasicAvatarSettings_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 169078, RefRangeEnd = 169079, XrefRangeStart = 169003, XrefRangeEnd = 169078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void MountSkateboard(Skateboard board)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(board);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MountSkateboard_Public_Void_Skateboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 169112, RefRangeEnd = 169114, XrefRangeStart = 169079, XrefRangeEnd = 169112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SendMountedSkateboard(NetworkObject skateboardObj)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(skateboardObj);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendMountedSkateboard_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 169136, RefRangeEnd = 169138, XrefRangeStart = 169114, XrefRangeEnd = 169136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SetMountedSkateboard(NetworkObject skateboardObj)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(skateboardObj);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMountedSkateboard_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 169183, RefRangeEnd = 169184, XrefRangeStart = 169138, XrefRangeEnd = 169183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void DismountSkateboard()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DismountSkateboard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 169207, RefRangeEnd = 169209, XrefRangeStart = 169184, XrefRangeEnd = 169207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void ConsumeProduct(ProductItemInstance product)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConsumeProduct_Public_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169209, XrefRangeEnd = 169228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SendConsumeProduct(ProductItemInstance product)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendConsumeProduct_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169228, XrefRangeEnd = 169247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void ReceiveConsumeProduct(ProductItemInstance product)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReceiveConsumeProduct_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169247, XrefRangeEnd = 169250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void ConsumeProductInternal(ProductItemInstance product)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConsumeProductInternal_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 169251, RefRangeEnd = 169252, XrefRangeStart = 169250, XrefRangeEnd = 169251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void ClearProduct()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearProduct_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 169298, RefRangeEnd = 169299, XrefRangeStart = 169252, XrefRangeEnd = 169298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void CreatePlayerVariables()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreatePlayerVariables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169299, XrefRangeEnd = 169311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe BaseVariable GetVariable(string variableName)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVariable_Public_BaseVariable_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseVariable>(intPtr) : null;
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169311, XrefRangeEnd = 169326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe T GetValue<T>(string variableName)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
            System.IntPtr exc;
            System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetValue_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 169338, RefRangeEnd = 169339, XrefRangeStart = 169326, XrefRangeEnd = 169338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SetVariableValue(string variableName, string value, bool network = true)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
            *(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &network;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVariableValue_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 169363, RefRangeEnd = 169364, XrefRangeStart = 169339, XrefRangeEnd = 169363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void AddVariable(BaseVariable variable)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(variable);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddVariable_Public_Void_BaseVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 169388, RefRangeEnd = 169389, XrefRangeStart = 169364, XrefRangeEnd = 169388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SendValue(string variableName, string value, bool sendToOwner)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
            *(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sendToOwner;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendValue_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169389, XrefRangeEnd = 169400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void ReceiveValue(NetworkConnection conn, string variableName, string value)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(variableName);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReceiveValue_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 169415, RefRangeEnd = 169418, XrefRangeStart = 169400, XrefRangeEnd = 169415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void ReceiveValue(string variableName, string value)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReceiveValue_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 169440, RefRangeEnd = 169442, XrefRangeStart = 169418, XrefRangeEnd = 169440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void LoadVariable(VariableData data)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadVariable_Public_Void_VariableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169442, XrefRangeEnd = 169551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe Player()
            : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player>.NativeClassPtr))
        {
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169551, XrefRangeEnd = 169557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe float _RecalculateCurrentProperty_b__248_0(Il2CppScheduleOne.Property.Property x)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
            System.IntPtr exc;
            System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RecalculateCurrentProperty_b__248_0_Private_Single_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(float*)IL2CPP.il2cpp_object_unbox(obj);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe float _RecalculateCurrentProperty_b__248_1(Business x)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
            System.IntPtr exc;
            System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RecalculateCurrentProperty_b__248_1_Private_Single_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(float*)IL2CPP.il2cpp_object_unbox(obj);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169557, XrefRangeEnd = 169562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169562, XrefRangeEnd = 169999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe override void NetworkInitialize___Early()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        public unsafe override void NetworkInitialize__Late()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        public unsafe override void NetworkInitializeIfDisabled()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169999, XrefRangeEnd = 170028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_set_CurrentVehicle_3323014238(NetworkObject value)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_set_CurrentVehicle_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [SpecialName]
        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 170036, RefRangeEnd = 170038, XrefRangeStart = 170028, XrefRangeEnd = 170036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___set_CurrentVehicle_3323014238(NetworkObject value)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___set_CurrentVehicle_3323014238_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170038, XrefRangeEnd = 170043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_set_CurrentVehicle_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_set_CurrentVehicle_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 166305, RefRangeEnd = 166307, XrefRangeStart = 166305, XrefRangeEnd = 166307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_set_CurrentBed_3323014238(NetworkObject value)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_set_CurrentBed_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [SpecialName]
        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170043, XrefRangeEnd = 170051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___set_CurrentBed_3323014238(NetworkObject value)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___set_CurrentBed_3323014238_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170051, XrefRangeEnd = 170062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_set_CurrentBed_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_set_CurrentBed_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 166348, RefRangeEnd = 166349, XrefRangeStart = 166348, XrefRangeEnd = 166349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_set_IsSkating_1140765316(bool value)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&value);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_set_IsSkating_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [SpecialName]
        [CallerCount(0)]
        public unsafe void RpcLogic___set_IsSkating_1140765316(bool value)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&value);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___set_IsSkating_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170062, XrefRangeEnd = 170064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_set_IsSkating_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_set_IsSkating_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 170095, RefRangeEnd = 170097, XrefRangeStart = 170064, XrefRangeEnd = 170095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_set_CameraPosition_4276783012(Vector3 value)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&value);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_set_CameraPosition_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [SpecialName]
        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170097, XrefRangeEnd = 170104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___set_CameraPosition_4276783012(Vector3 value)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&value);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___set_CameraPosition_4276783012_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170104, XrefRangeEnd = 170116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_set_CameraPosition_4276783012(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_set_CameraPosition_4276783012_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_set_CameraRotation_3429297120(Quaternion value)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&value);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_set_CameraRotation_3429297120_Private_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [SpecialName]
        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170116, XrefRangeEnd = 170123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___set_CameraRotation_3429297120(Quaternion value)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&value);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___set_CameraRotation_3429297120_Public_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170123, XrefRangeEnd = 170134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_set_CameraRotation_3429297120(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_set_CameraRotation_3429297120_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170134, XrefRangeEnd = 170152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_RequestSavePlayer_2166136261()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_RequestSavePlayer_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 170166, RefRangeEnd = 170168, XrefRangeStart = 170152, XrefRangeEnd = 170166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___RequestSavePlayer_2166136261()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___RequestSavePlayer_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170168, XrefRangeEnd = 170171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_RequestSavePlayer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_RequestSavePlayer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170171, XrefRangeEnd = 170190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Observers_ReturnSaveRequest_214505783(NetworkConnection conn, bool successful)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &successful;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Observers_ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 170201, RefRangeEnd = 170203, XrefRangeStart = 170190, XrefRangeEnd = 170201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___ReturnSaveRequest_214505783(NetworkConnection conn, bool successful)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &successful;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170203, XrefRangeEnd = 170205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Observers_ReturnSaveRequest_214505783(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Observers_ReturnSaveRequest_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170205, XrefRangeEnd = 170224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Target_ReturnSaveRequest_214505783(NetworkConnection conn, bool successful)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &successful;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Target_ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170224, XrefRangeEnd = 170227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Target_ReturnSaveRequest_214505783(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Target_ReturnSaveRequest_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170227, XrefRangeEnd = 170245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Observers_HostExitedGame_2166136261()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Observers_HostExitedGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 170271, RefRangeEnd = 170274, XrefRangeStart = 170245, XrefRangeEnd = 170271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___HostExitedGame_2166136261()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___HostExitedGame_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170274, XrefRangeEnd = 170277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Observers_HostExitedGame_2166136261(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Observers_HostExitedGame_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 170308, RefRangeEnd = 170310, XrefRangeStart = 170277, XrefRangeEnd = 170308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_SendPlayerNameData_586648380(string playerName, ulong id)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(playerName);
            *(ulong**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_SendPlayerNameData_586648380_Private_Void_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 170329, RefRangeEnd = 170332, XrefRangeStart = 170310, XrefRangeEnd = 170329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SendPlayerNameData_586648380(string playerName, ulong id)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(playerName);
            *(ulong**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SendPlayerNameData_586648380_Public_Void_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170332, XrefRangeEnd = 170338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_SendPlayerNameData_586648380(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_SendPlayerNameData_586648380_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_RequestPlayerData_3615296227(string playerCode)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_RequestPlayerData_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 170364, RefRangeEnd = 170365, XrefRangeStart = 170338, XrefRangeEnd = 170364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___RequestPlayerData_3615296227(string playerCode)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___RequestPlayerData_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170365, XrefRangeEnd = 170368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_RequestPlayerData_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_RequestPlayerData_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170368, XrefRangeEnd = 170396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_MarkPlayerInitialized_2166136261()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_MarkPlayerInitialized_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 170403, RefRangeEnd = 170406, XrefRangeStart = 170396, XrefRangeEnd = 170403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___MarkPlayerInitialized_2166136261()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___MarkPlayerInitialized_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170406, XrefRangeEnd = 170410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_MarkPlayerInitialized_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_MarkPlayerInitialized_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170410, XrefRangeEnd = 170433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Observers_ReceivePlayerData_3244732873(NetworkConnection conn, PlayerData data, string inventoryString, string appearanceString, string clothigString, Il2CppReferenceArray<VariableData> vars)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[6];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(data);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(inventoryString);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(appearanceString);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(clothigString);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(vars);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerData_3244732873_Private_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 170448, RefRangeEnd = 170451, XrefRangeStart = 170433, XrefRangeEnd = 170448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___ReceivePlayerData_3244732873(NetworkConnection conn, PlayerData data, string inventoryString, string appearanceString, string clothigString, Il2CppReferenceArray<VariableData> vars)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[6];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(data);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(inventoryString);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(appearanceString);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(clothigString);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(vars);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___ReceivePlayerData_3244732873_Public_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170451, XrefRangeEnd = 170459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Observers_ReceivePlayerData_3244732873(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerData_3244732873_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170459, XrefRangeEnd = 170473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Target_ReceivePlayerData_3244732873(NetworkConnection conn, PlayerData data, string inventoryString, string appearanceString, string clothigString, Il2CppReferenceArray<VariableData> vars)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[6];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(data);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(inventoryString);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(appearanceString);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(clothigString);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(vars);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerData_3244732873_Private_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170473, XrefRangeEnd = 170481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Target_ReceivePlayerData_3244732873(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerData_3244732873_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170481, XrefRangeEnd = 170501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Observers_ReceivePlayerNameData_3895153758(NetworkConnection conn, string playerName, string id)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(playerName);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(id);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 170513, RefRangeEnd = 170516, XrefRangeStart = 170501, XrefRangeEnd = 170513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___ReceivePlayerNameData_3895153758(NetworkConnection conn, string playerName, string id)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(playerName);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(id);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170516, XrefRangeEnd = 170521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Observers_ReceivePlayerNameData_3895153758(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerNameData_3895153758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170521, XrefRangeEnd = 170532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Target_ReceivePlayerNameData_3895153758(NetworkConnection conn, string playerName, string id)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(playerName);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(id);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170532, XrefRangeEnd = 170537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Target_ReceivePlayerNameData_3895153758(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerNameData_3895153758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170537, XrefRangeEnd = 170556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_SendFlashlightOnNetworked_1140765316(bool on)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&on);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_SendFlashlightOnNetworked_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 167231, RefRangeEnd = 167234, XrefRangeStart = 167231, XrefRangeEnd = 167234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SendFlashlightOnNetworked_1140765316(bool on)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&on);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SendFlashlightOnNetworked_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170556, XrefRangeEnd = 170559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_SendFlashlightOnNetworked_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_SendFlashlightOnNetworked_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170559, XrefRangeEnd = 170578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Observers_SetFlashlightOn_1140765316(bool on)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&on);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Observers_SetFlashlightOn_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 170583, RefRangeEnd = 170584, XrefRangeStart = 170578, XrefRangeEnd = 170583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SetFlashlightOn_1140765316(bool on)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&on);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SetFlashlightOn_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170584, XrefRangeEnd = 170587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Observers_SetFlashlightOn_1140765316(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Observers_SetFlashlightOn_1140765316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 167523, RefRangeEnd = 167524, XrefRangeStart = 167523, XrefRangeEnd = 167524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Observers_PlayJumpAnimation_2166136261()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Observers_PlayJumpAnimation_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170587, XrefRangeEnd = 170589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___PlayJumpAnimation_2166136261()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___PlayJumpAnimation_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170589, XrefRangeEnd = 170591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Observers_PlayJumpAnimation_2166136261(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Observers_PlayJumpAnimation_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170591, XrefRangeEnd = 170610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_SendCrouched_1140765316(bool crouched)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&crouched);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_SendCrouched_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170610, XrefRangeEnd = 170611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SendCrouched_1140765316(bool crouched)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&crouched);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SendCrouched_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170611, XrefRangeEnd = 170614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_SendCrouched_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_SendCrouched_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170614, XrefRangeEnd = 170633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Target_ReceiveCrouched_214505783(NetworkConnection conn, bool crouched)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &crouched;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Target_ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170633, XrefRangeEnd = 170635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___ReceiveCrouched_214505783(NetworkConnection conn, bool crouched)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &crouched;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170635, XrefRangeEnd = 170639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Target_ReceiveCrouched_214505783(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Target_ReceiveCrouched_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170639, XrefRangeEnd = 170658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Observers_ReceiveCrouched_214505783(NetworkConnection conn, bool crouched)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &crouched;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Observers_ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170658, XrefRangeEnd = 170662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Observers_ReceiveCrouched_214505783(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Observers_ReceiveCrouched_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170662, XrefRangeEnd = 170691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_SendAvatarSettings_4281687581(AvatarSettings settings)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_SendAvatarSettings_4281687581_Private_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 167637, RefRangeEnd = 167640, XrefRangeStart = 167637, XrefRangeEnd = 167640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SendAvatarSettings_4281687581(AvatarSettings settings)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SendAvatarSettings_4281687581_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170691, XrefRangeEnd = 170696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_SendAvatarSettings_4281687581(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_SendAvatarSettings_4281687581_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170696, XrefRangeEnd = 170715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Observers_SetAvatarSettings_4281687581(AvatarSettings settings)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Observers_SetAvatarSettings_4281687581_Private_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 170722, RefRangeEnd = 170725, XrefRangeStart = 170715, XrefRangeEnd = 170722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SetAvatarSettings_4281687581(AvatarSettings settings)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SetAvatarSettings_4281687581_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170725, XrefRangeEnd = 170729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Observers_SetAvatarSettings_4281687581(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Observers_SetAvatarSettings_4281687581_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Observers_SetVisible_Networked_1140765316(bool vis)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&vis);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Observers_SetVisible_Networked_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170729, XrefRangeEnd = 170732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SetVisible_Networked_1140765316(bool vis)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&vis);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SetVisible_Networked_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170732, XrefRangeEnd = 170735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Observers_SetVisible_Networked_1140765316(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Observers_SetVisible_Networked_1140765316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170735, XrefRangeEnd = 170754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_SetReadyToSleep_1140765316(bool ready)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&ready);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_SetReadyToSleep_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 166317, RefRangeEnd = 166319, XrefRangeStart = 166317, XrefRangeEnd = 166319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SetReadyToSleep_1140765316(bool ready)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&ready);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SetReadyToSleep_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170754, XrefRangeEnd = 170757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_SetReadyToSleep_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_SetReadyToSleep_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170757, XrefRangeEnd = 170776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Observers_SetPlayerCode_3615296227(string code)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(code);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerCode_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170776, XrefRangeEnd = 170777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SetPlayerCode_3615296227(string code)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(code);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SetPlayerCode_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170777, XrefRangeEnd = 170781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Observers_SetPlayerCode_3615296227(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Observers_SetPlayerCode_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 167968, RefRangeEnd = 167969, XrefRangeStart = 167968, XrefRangeEnd = 167969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_SendPunch_2166136261()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_SendPunch_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SendPunch_2166136261()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SendPunch_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170781, XrefRangeEnd = 170800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_SendPunch_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_SendPunch_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Observers_Punch_2166136261()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Observers_Punch_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170800, XrefRangeEnd = 170804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___Punch_2166136261()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___Punch_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170804, XrefRangeEnd = 170809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Observers_Punch_2166136261(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Observers_Punch_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170809, XrefRangeEnd = 170838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_MarkIntroCompleted_3281254764(BasicAvatarSettings appearance)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(appearance);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_MarkIntroCompleted_3281254764_Private_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 170846, RefRangeEnd = 170848, XrefRangeStart = 170838, XrefRangeEnd = 170846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___MarkIntroCompleted_3281254764(BasicAvatarSettings appearance)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(appearance);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___MarkIntroCompleted_3281254764_Private_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170848, XrefRangeEnd = 170853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_MarkIntroCompleted_3281254764(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_MarkIntroCompleted_3281254764_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170853, XrefRangeEnd = 170872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_SendImpact_427288424(Impact impact)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_SendImpact_427288424_Private_Void_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        public unsafe virtual void RpcLogic___SendImpact_427288424(Impact impact)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_RpcLogic___SendImpact_427288424_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170872, XrefRangeEnd = 170875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_SendImpact_427288424(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_SendImpact_427288424_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170875, XrefRangeEnd = 170894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Observers_ReceiveImpact_427288424(Impact impact)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Observers_ReceiveImpact_427288424_Private_Void_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 170909, RefRangeEnd = 170911, XrefRangeStart = 170894, XrefRangeEnd = 170909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe virtual void RpcLogic___ReceiveImpact_427288424(Impact impact)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_RpcLogic___ReceiveImpact_427288424_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170911, XrefRangeEnd = 170915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Observers_ReceiveImpact_427288424(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Observers_ReceiveImpact_427288424_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170915, XrefRangeEnd = 170933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Observers_Arrest_2166136261()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Observers_Arrest_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 170958, RefRangeEnd = 170960, XrefRangeStart = 170933, XrefRangeEnd = 170958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___Arrest_2166136261()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___Arrest_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170960, XrefRangeEnd = 170963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Observers_Arrest_2166136261(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Observers_Arrest_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170963, XrefRangeEnd = 170991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_SendPassOut_2166136261()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_SendPassOut_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 168648, RefRangeEnd = 168650, XrefRangeStart = 168648, XrefRangeEnd = 168650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SendPassOut_2166136261()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SendPassOut_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170991, XrefRangeEnd = 170995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_SendPassOut_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_SendPassOut_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170995, XrefRangeEnd = 171013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Observers_PassOut_2166136261()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Observers_PassOut_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 171036, RefRangeEnd = 171039, XrefRangeStart = 171013, XrefRangeEnd = 171036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___PassOut_2166136261()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___PassOut_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171039, XrefRangeEnd = 171042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Observers_PassOut_2166136261(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Observers_PassOut_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171042, XrefRangeEnd = 171070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_SendPassOutRecovery_2166136261()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_SendPassOutRecovery_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 168704, RefRangeEnd = 168706, XrefRangeStart = 168704, XrefRangeEnd = 168706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SendPassOutRecovery_2166136261()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SendPassOutRecovery_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171070, XrefRangeEnd = 171074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_SendPassOutRecovery_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_SendPassOutRecovery_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171074, XrefRangeEnd = 171092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Observers_PassOutRecovery_2166136261()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Observers_PassOutRecovery_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 171115, RefRangeEnd = 171118, XrefRangeStart = 171092, XrefRangeEnd = 171115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___PassOutRecovery_2166136261()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___PassOutRecovery_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171118, XrefRangeEnd = 171121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Observers_PassOutRecovery_2166136261(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Observers_PassOutRecovery_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171121, XrefRangeEnd = 171140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_SendEquippable_Networked_3615296227(string assetPath)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_SendEquippable_Networked_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 168755, RefRangeEnd = 168757, XrefRangeStart = 168755, XrefRangeEnd = 168757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SendEquippable_Networked_3615296227(string assetPath)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SendEquippable_Networked_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171140, XrefRangeEnd = 171144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_SendEquippable_Networked_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_SendEquippable_Networked_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171144, XrefRangeEnd = 171163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Observers_SetEquippable_Networked_3615296227(string assetPath)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Observers_SetEquippable_Networked_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171163, XrefRangeEnd = 171164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SetEquippable_Networked_3615296227(string assetPath)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SetEquippable_Networked_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171164, XrefRangeEnd = 171167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Observers_SetEquippable_Networked_3615296227(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Observers_SetEquippable_Networked_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 171198, RefRangeEnd = 171199, XrefRangeStart = 171167, XrefRangeEnd = 171198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_SendEquippableMessage_Networked_3643459082(string message, int receipt)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(message);
            *(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &receipt;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_SendEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 168784, RefRangeEnd = 168786, XrefRangeStart = 168784, XrefRangeEnd = 168786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SendEquippableMessage_Networked_3643459082(string message, int receipt)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(message);
            *(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &receipt;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SendEquippableMessage_Networked_3643459082_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171199, XrefRangeEnd = 171206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_SendEquippableMessage_Networked_3643459082(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_SendEquippableMessage_Networked_3643459082_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171206, XrefRangeEnd = 171227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Observers_ReceiveEquippableMessage_Networked_3643459082(string message, int receipt)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(message);
            *(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &receipt;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 171234, RefRangeEnd = 171237, XrefRangeStart = 171227, XrefRangeEnd = 171234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___ReceiveEquippableMessage_Networked_3643459082(string message, int receipt)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(message);
            *(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &receipt;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___ReceiveEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171237, XrefRangeEnd = 171243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Observers_ReceiveEquippableMessage_Networked_3643459082(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Observers_ReceiveEquippableMessage_Networked_3643459082_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 171260, RefRangeEnd = 171261, XrefRangeStart = 171243, XrefRangeEnd = 171260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_SendEquippableMessage_Networked_Vector_3190074053(string message, int receipt, Vector3 data)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(message);
            *(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &receipt;
            *(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &data;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_SendEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171261, XrefRangeEnd = 171262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SendEquippableMessage_Networked_Vector_3190074053(string message, int receipt, Vector3 data)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(message);
            *(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &receipt;
            *(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &data;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SendEquippableMessage_Networked_Vector_3190074053_Public_Void_String_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171262, XrefRangeEnd = 171272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_SendEquippableMessage_Networked_Vector_3190074053(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_SendEquippableMessage_Networked_Vector_3190074053_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171272, XrefRangeEnd = 171287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053(string message, int receipt, Vector3 data)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(message);
            *(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &receipt;
            *(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &data;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 171297, RefRangeEnd = 171299, XrefRangeStart = 171287, XrefRangeEnd = 171297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___ReceiveEquippableMessage_Networked_Vector_3190074053(string message, int receipt, Vector3 data)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(message);
            *(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &receipt;
            *(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &data;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171299, XrefRangeEnd = 171308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171308, XrefRangeEnd = 171337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_SendAnimationTrigger_3615296227(string trigger)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_SendAnimationTrigger_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171337, XrefRangeEnd = 171338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SendAnimationTrigger_3615296227(string trigger)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SendAnimationTrigger_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171338, XrefRangeEnd = 171343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_SendAnimationTrigger_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_SendAnimationTrigger_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171343, XrefRangeEnd = 171362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Observers_SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(trigger);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Observers_SetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171362, XrefRangeEnd = 171364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(trigger);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SetAnimationTrigger_Networked_2971853958_Public_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171364, XrefRangeEnd = 171368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Observers_SetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Observers_SetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171368, XrefRangeEnd = 171387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Target_SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(trigger);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Target_SetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171387, XrefRangeEnd = 171391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Target_SetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Target_SetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171391, XrefRangeEnd = 171410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Observers_ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(trigger);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Observers_ResetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171410, XrefRangeEnd = 171412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(trigger);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___ResetAnimationTrigger_Networked_2971853958_Public_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171412, XrefRangeEnd = 171416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Observers_ResetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Observers_ResetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171416, XrefRangeEnd = 171435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Target_ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(trigger);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Target_ResetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171435, XrefRangeEnd = 171439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Target_ResetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Target_ResetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 171469, RefRangeEnd = 171470, XrefRangeStart = 171439, XrefRangeEnd = 171469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_SendAnimationBool_310431262(string name, bool val)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(name);
            *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_SendAnimationBool_310431262_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 168909, RefRangeEnd = 168911, XrefRangeStart = 168909, XrefRangeEnd = 168911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SendAnimationBool_310431262(string name, bool val)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(name);
            *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SendAnimationBool_310431262_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171470, XrefRangeEnd = 171475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_SendAnimationBool_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_SendAnimationBool_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171475, XrefRangeEnd = 171495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Observers_SetAnimationBool_310431262(string name, bool val)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(name);
            *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Observers_SetAnimationBool_310431262_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171495, XrefRangeEnd = 171497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SetAnimationBool_310431262(string name, bool val)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(name);
            *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SetAnimationBool_310431262_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171497, XrefRangeEnd = 171501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Observers_SetAnimationBool_310431262(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Observers_SetAnimationBool_310431262_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 168929, RefRangeEnd = 168930, XrefRangeStart = 168929, XrefRangeEnd = 168930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Observers_Taze_2166136261()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Observers_Taze_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171501, XrefRangeEnd = 171511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___Taze_2166136261()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___Taze_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171511, XrefRangeEnd = 171521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Observers_Taze_2166136261(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Observers_Taze_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 171552, RefRangeEnd = 171553, XrefRangeStart = 171521, XrefRangeEnd = 171552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_SetInventoryItem_2317364410(int index, ItemInstance item)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = (nint)(&index);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(item);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_SetInventoryItem_2317364410_Private_Void_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171553, XrefRangeEnd = 171555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SetInventoryItem_2317364410(int index, ItemInstance item)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = (nint)(&index);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(item);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SetInventoryItem_2317364410_Public_Void_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171555, XrefRangeEnd = 171561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_SetInventoryItem_2317364410(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_SetInventoryItem_2317364410_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171561, XrefRangeEnd = 171590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_SendAppearance_3281254764(BasicAvatarSettings settings)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_SendAppearance_3281254764_Private_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171590, XrefRangeEnd = 171591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SendAppearance_3281254764(BasicAvatarSettings settings)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SendAppearance_3281254764_Public_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171591, XrefRangeEnd = 171596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_SendAppearance_3281254764(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_SendAppearance_3281254764_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171596, XrefRangeEnd = 171616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Observers_SetAppearance_2139595489(BasicAvatarSettings settings, bool refreshClothing)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
            *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &refreshClothing;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Observers_SetAppearance_2139595489_Private_Void_BasicAvatarSettings_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 171622, RefRangeEnd = 171624, XrefRangeStart = 171616, XrefRangeEnd = 171622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SetAppearance_2139595489(BasicAvatarSettings settings, bool refreshClothing)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
            *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &refreshClothing;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SetAppearance_2139595489_Public_Void_BasicAvatarSettings_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171624, XrefRangeEnd = 171628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Observers_SetAppearance_2139595489(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Observers_SetAppearance_2139595489_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171628, XrefRangeEnd = 171657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_SendMountedSkateboard_3323014238(NetworkObject skateboardObj)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(skateboardObj);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_SendMountedSkateboard_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 169136, RefRangeEnd = 169138, XrefRangeStart = 169136, XrefRangeEnd = 169138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SendMountedSkateboard_3323014238(NetworkObject skateboardObj)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(skateboardObj);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SendMountedSkateboard_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171657, XrefRangeEnd = 171662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_SendMountedSkateboard_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_SendMountedSkateboard_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171662, XrefRangeEnd = 171681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Observers_SetMountedSkateboard_3323014238(NetworkObject skateboardObj)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(skateboardObj);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Observers_SetMountedSkateboard_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 171704, RefRangeEnd = 171707, XrefRangeStart = 171681, XrefRangeEnd = 171704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SetMountedSkateboard_3323014238(NetworkObject skateboardObj)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(skateboardObj);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SetMountedSkateboard_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171707, XrefRangeEnd = 171711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Observers_SetMountedSkateboard_3323014238(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Observers_SetMountedSkateboard_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_SendConsumeProduct_2622925554(ProductItemInstance product)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_SendConsumeProduct_2622925554_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SendConsumeProduct_2622925554(ProductItemInstance product)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SendConsumeProduct_2622925554_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171711, XrefRangeEnd = 171723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_SendConsumeProduct_2622925554(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_SendConsumeProduct_2622925554_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Observers_ReceiveConsumeProduct_2622925554(ProductItemInstance product)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Observers_ReceiveConsumeProduct_2622925554_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171723, XrefRangeEnd = 171726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___ReceiveConsumeProduct_2622925554(ProductItemInstance product)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___ReceiveConsumeProduct_2622925554_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171726, XrefRangeEnd = 171731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Observers_ReceiveConsumeProduct_2622925554(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Observers_ReceiveConsumeProduct_2622925554_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171731, XrefRangeEnd = 171743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_SendValue_3589193952(string variableName, string value, bool sendToOwner)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
            *(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sendToOwner;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_SendValue_3589193952_Private_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 171767, RefRangeEnd = 171769, XrefRangeStart = 171743, XrefRangeEnd = 171767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SendValue_3589193952(string variableName, string value, bool sendToOwner)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
            *(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sendToOwner;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SendValue_3589193952_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171769, XrefRangeEnd = 171774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_SendValue_3589193952(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_SendValue_3589193952_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Target_ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(variableName);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Target_ReceiveValue_3895153758_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171774, XrefRangeEnd = 171775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(variableName);
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___ReceiveValue_3895153758_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171775, XrefRangeEnd = 171780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Target_ReceiveValue_3895153758(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Target_ReceiveValue_3895153758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171790, XrefRangeEnd = 171798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe override bool ReadSyncVar___ScheduleOne_PlayerScripts_Player(PooledReader PooledReader0, uint UInt321, bool Boolean2)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &UInt321;
            *(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &Boolean2;
            System.IntPtr exc;
            System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_PlayerScripts_Player_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 171950, RefRangeEnd = 171951, XrefRangeStart = 171849, XrefRangeEnd = 171950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe virtual void Method_Protected_Virtual_New_Void_0()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        public Player(System.IntPtr pointer)
            : base(pointer)
        {
        }
    }
}
