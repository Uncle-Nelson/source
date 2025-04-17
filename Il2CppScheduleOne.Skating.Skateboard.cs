using System;
using System.Runtime.CompilerServices;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Tools;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Skating
{
    public class Skateboard : NetworkBehaviour
    {
        [ObfuscatedName("ScheduleOne.Skating.Skateboard+<<Push>g__Push|113_0>d")]
        public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique : Il2CppSystem.Object
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

            public unsafe Skateboard __4__this
            {
                get
                {
                    nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
                    System.IntPtr intPtr = *(System.IntPtr*)num;
                    return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Skateboard>(intPtr) : null;
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

            static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique()
            {
                Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<<Push>g__Push|113_0>d");
                IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr);
                NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, "<>1__state");
                NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, "<>2__current");
                NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, "<>4__this");
                NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, "<i>5__2");
                NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667242);
                NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667243);
                NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667244);
                NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667245);
                NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667246);
                NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667247);
            }

            [CallerCount(61)]
            [CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique(int _003C_003E1__state)
                : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr))
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
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111743, XrefRangeEnd = 111752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111752, XrefRangeEnd = 111757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            public unsafe virtual void System_Collections_IEnumerator_Reset()
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }

            public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique(System.IntPtr pointer)
                : base(pointer)
            {
            }
        }

        [ObfuscatedName("ScheduleOne.Skating.Skateboard+<>c__DisplayClass112_0")]
        public sealed class __c__DisplayClass112_0 : Il2CppSystem.Object
        {
            [ObfuscatedName("ScheduleOne.Skating.Skateboard+<>c__DisplayClass112_0+<<Jump>g__Jump|0>d")]
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

                public unsafe __c__DisplayClass112_0 __4__this
                {
                    get
                    {
                        nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
                        System.IntPtr intPtr = *(System.IntPtr*)num;
                        return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c__DisplayClass112_0>(intPtr) : null;
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
                    Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr, "<<Jump>g__Jump|0>d");
                    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
                    NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
                    NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
                    NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
                    NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<i>5__2");
                    NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667250);
                    NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667251);
                    NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667252);
                    NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667253);
                    NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667254);
                    NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667255);
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
                [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111757, XrefRangeEnd = 111770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
                [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111770, XrefRangeEnd = 111775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

            private static readonly System.IntPtr NativeFieldInfoPtr_JumpDuration;

            private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

            private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

            public unsafe Skateboard __4__this
            {
                get
                {
                    nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
                    System.IntPtr intPtr = *(System.IntPtr*)num;
                    return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Skateboard>(intPtr) : null;
                }
                set
                {
                    System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                    IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
                }
            }

            public unsafe float JumpDuration
            {
                get
                {
                    nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JumpDuration);
                    return *(float*)num;
                }
                set
                {
                    *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JumpDuration)) = value;
                }
            }

            static __c__DisplayClass112_0()
            {
                Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<>c__DisplayClass112_0");
                IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr);
                NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr, "<>4__this");
                NativeFieldInfoPtr_JumpDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr, "JumpDuration");
                NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr, 100667248);
                NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr, 100667249);
            }

            [CallerCount(2259)]
            [CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            public unsafe __c__DisplayClass112_0()
                : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr))
            {
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }

            [CallerCount(0)]
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111775, XrefRangeEnd = 111780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
            }

            public __c__DisplayClass112_0(System.IntPtr pointer)
                : base(pointer)
            {
            }
        }

        private static readonly System.IntPtr NativeFieldInfoPtr_GroundedRaycastDistance;

        private static readonly System.IntPtr NativeFieldInfoPtr_JumpCooldown;

        private static readonly System.IntPtr NativeFieldInfoPtr_JumpForceMin;

        private static readonly System.IntPtr NativeFieldInfoPtr_JumpForceBuildTime;

        private static readonly System.IntPtr NativeFieldInfoPtr_PushCooldown;

        private static readonly System.IntPtr NativeFieldInfoPtr_PushStaminaConsumption;

        private static readonly System.IntPtr NativeFieldInfoPtr_PitchLimit;

        private static readonly System.IntPtr NativeFieldInfoPtr_RollLimit;

        private static readonly System.IntPtr NativeFieldInfoPtr_CurrentSpeed_Kmh;

        private static readonly System.IntPtr NativeFieldInfoPtr__CurrentSteerInput_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__JumpBuildAmount_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr__Rider_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr_Rb;

        private static readonly System.IntPtr NativeFieldInfoPtr_CoM;

        private static readonly System.IntPtr NativeFieldInfoPtr_HoverPoints;

        private static readonly System.IntPtr NativeFieldInfoPtr_FrontAxlePosition;

        private static readonly System.IntPtr NativeFieldInfoPtr_RearAxlePosition;

        private static readonly System.IntPtr NativeFieldInfoPtr_PlayerContainer;

        private static readonly System.IntPtr NativeFieldInfoPtr_Animation;

        private static readonly System.IntPtr NativeFieldInfoPtr_VelocityCalculator;

        private static readonly System.IntPtr NativeFieldInfoPtr_Accelerometer;

        private static readonly System.IntPtr NativeFieldInfoPtr_Equippable;

        private static readonly System.IntPtr NativeFieldInfoPtr_IKAlignmentsContainer;

        private static readonly System.IntPtr NativeFieldInfoPtr_TurnForce;

        private static readonly System.IntPtr NativeFieldInfoPtr_TurnChangeRate;

        private static readonly System.IntPtr NativeFieldInfoPtr_TurnReturnToRestRate;

        private static readonly System.IntPtr NativeFieldInfoPtr_TurnSpeedBoost;

        private static readonly System.IntPtr NativeFieldInfoPtr_TurnForceMap;

        private static readonly System.IntPtr NativeFieldInfoPtr_Gravity;

        private static readonly System.IntPtr NativeFieldInfoPtr_BrakeForce;

        private static readonly System.IntPtr NativeFieldInfoPtr_ReverseTopSpeed_Kmh;

        private static readonly System.IntPtr NativeFieldInfoPtr_GroundDetectionMask;

        private static readonly System.IntPtr NativeFieldInfoPtr_MainColliders;

        private static readonly System.IntPtr NativeFieldInfoPtr_RotationClampForce;

        private static readonly System.IntPtr NativeFieldInfoPtr_FrictionEnabled;

        private static readonly System.IntPtr NativeFieldInfoPtr_LongitudinalFrictionCurve;

        private static readonly System.IntPtr NativeFieldInfoPtr_LongitudinalFrictionMultiplier;

        private static readonly System.IntPtr NativeFieldInfoPtr_LateralFrictionForceMultiplier;

        private static readonly System.IntPtr NativeFieldInfoPtr_JumpForce;

        private static readonly System.IntPtr NativeFieldInfoPtr_JumpDuration_Min;

        private static readonly System.IntPtr NativeFieldInfoPtr_JumpDuration_Max;

        private static readonly System.IntPtr NativeFieldInfoPtr_FrontAxleJumpCurve;

        private static readonly System.IntPtr NativeFieldInfoPtr_RearAxleJumpCurve;

        private static readonly System.IntPtr NativeFieldInfoPtr_JumpForwardForceCurve;

        private static readonly System.IntPtr NativeFieldInfoPtr_JumpForwardBoost;

        private static readonly System.IntPtr NativeFieldInfoPtr_HoverForce;

        private static readonly System.IntPtr NativeFieldInfoPtr_HoverRayLength;

        private static readonly System.IntPtr NativeFieldInfoPtr_HoverHeight;

        private static readonly System.IntPtr NativeFieldInfoPtr_Hover_P;

        private static readonly System.IntPtr NativeFieldInfoPtr_Hover_I;

        private static readonly System.IntPtr NativeFieldInfoPtr_Hover_D;

        private static readonly System.IntPtr NativeFieldInfoPtr_TopSpeed_Kmh;

        private static readonly System.IntPtr NativeFieldInfoPtr_PushForceMultiplier;

        private static readonly System.IntPtr NativeFieldInfoPtr_PushForceMultiplierMap;

        private static readonly System.IntPtr NativeFieldInfoPtr_PushForceDuration;

        private static readonly System.IntPtr NativeFieldInfoPtr_PushDelay;

        private static readonly System.IntPtr NativeFieldInfoPtr_PushForceCurve;

        private static readonly System.IntPtr NativeFieldInfoPtr_AirMovementEnabled;

        private static readonly System.IntPtr NativeFieldInfoPtr_AirMovementForce;

        private static readonly System.IntPtr NativeFieldInfoPtr_AirMovementJumpReductionDuration;

        private static readonly System.IntPtr NativeFieldInfoPtr_AirMovementJumpReductionCurve;

        private static readonly System.IntPtr NativeFieldInfoPtr_OnPushStart;

        private static readonly System.IntPtr NativeFieldInfoPtr_OnJump;

        private static readonly System.IntPtr NativeFieldInfoPtr_OnLand;

        private static readonly System.IntPtr NativeFieldInfoPtr_horizontalInput;

        private static readonly System.IntPtr NativeFieldInfoPtr_jumpReleased;

        private static readonly System.IntPtr NativeFieldInfoPtr_timeSinceLastJump;

        private static readonly System.IntPtr NativeFieldInfoPtr_timeGrounded;

        private static readonly System.IntPtr NativeFieldInfoPtr_timeAirborne;

        private static readonly System.IntPtr NativeFieldInfoPtr_jumpHeldTime;

        private static readonly System.IntPtr NativeFieldInfoPtr_frontAxleForce;

        private static readonly System.IntPtr NativeFieldInfoPtr_rearAxleForce;

        private static readonly System.IntPtr NativeFieldInfoPtr_jumpForwardForce;

        private static readonly System.IntPtr NativeFieldInfoPtr_hoverPIDs;

        private static readonly System.IntPtr NativeFieldInfoPtr_pushQueued;

        private static readonly System.IntPtr NativeFieldInfoPtr_isPushing;

        private static readonly System.IntPtr NativeFieldInfoPtr_thisFramePushForce;

        private static readonly System.IntPtr NativeFieldInfoPtr_timeSincePushStart;

        private static readonly System.IntPtr NativeFieldInfoPtr_braking;

        private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____JumpBuildAmount_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

        private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentSteerInput_Public_get_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentSteerInput_Protected_set_Void_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPushing_Public_get_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeSincePushStart_Public_get_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_isGrounded_Public_get_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_AirTime_Public_get_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_JumpBuildAmount_Public_get_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_JumpBuildAmount_Public_set_Void_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_Rider_Public_get_Player_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_Rider_Private_set_Void_Player_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_TopSpeed_Ms_Public_get_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_GetInput_Private_Void_1;

        private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_1;

        private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_1;

        private static readonly System.IntPtr NativeMethodInfoPtr_ApplyInput_Private_Void_1;

        private static readonly System.IntPtr NativeMethodInfoPtr_ApplyLateralFriction_Private_Void_1;

        private static readonly System.IntPtr NativeMethodInfoPtr_UpdateHover_Private_Void_1;

        private static readonly System.IntPtr NativeMethodInfoPtr_ApplyGravity_Private_Void_1;

        private static readonly System.IntPtr NativeMethodInfoPtr_CheckGrounded_Private_Void_1;

        private static readonly System.IntPtr NativeMethodInfoPtr_CheckJump_Private_Void_1;

        private static readonly System.IntPtr NativeMethodInfoPtr_SendJump_Private_Void_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveJump_Private_Void_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_Jump_Private_Void_1;

        private static readonly System.IntPtr NativeMethodInfoPtr_Push_Private_Void_1;

        private static readonly System.IntPtr NativeMethodInfoPtr_IsGrounded_Public_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_RaycastHit_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_ClampRotation_Private_Void_1;

        private static readonly System.IntPtr NativeMethodInfoPtr_ApplyPlayerScale_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_GetSurfaceSmoothness_Public_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_JumpBuildAmount_431000436_Private_Void_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___set_JumpBuildAmount_431000436_Public_Void_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_set_JumpBuildAmount_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendJump_431000436_Private_Void_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendJump_431000436_Private_Void_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendJump_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveJump_431000436_Private_Void_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveJump_431000436_Private_Void_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveJump_431000436_Private_Void_PooledReader_Channel_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__JumpBuildAmount_k__BackingField_Public_get_Single_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__JumpBuildAmount_k__BackingField_Public_set_Void_Single_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Skating_Skateboard_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

        public unsafe static float GroundedRaycastDistance
        {
            get
            {
                float result;
                IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GroundedRaycastDistance, &result);
                return result;
            }
            set
            {
                IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GroundedRaycastDistance, &value);
            }
        }

        public unsafe static float JumpCooldown
        {
            get
            {
                float result;
                IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_JumpCooldown, &result);
                return result;
            }
            set
            {
                IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_JumpCooldown, &value);
            }
        }

        public unsafe static float JumpForceMin
        {
            get
            {
                float result;
                IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_JumpForceMin, &result);
                return result;
            }
            set
            {
                IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_JumpForceMin, &value);
            }
        }

        public unsafe static float JumpForceBuildTime
        {
            get
            {
                float result;
                IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_JumpForceBuildTime, &result);
                return result;
            }
            set
            {
                IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_JumpForceBuildTime, &value);
            }
        }

        public unsafe static float PushCooldown
        {
            get
            {
                float result;
                IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PushCooldown, &result);
                return result;
            }
            set
            {
                IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PushCooldown, &value);
            }
        }

        public unsafe static float PushStaminaConsumption
        {
            get
            {
                float result;
                IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PushStaminaConsumption, &result);
                return result;
            }
            set
            {
                IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PushStaminaConsumption, &value);
            }
        }

        public unsafe static float PitchLimit
        {
            get
            {
                float result;
                IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PitchLimit, &result);
                return result;
            }
            set
            {
                IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PitchLimit, &value);
            }
        }

        public unsafe static float RollLimit
        {
            get
            {
                float result;
                IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RollLimit, &result);
                return result;
            }
            set
            {
                IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RollLimit, &value);
            }
        }

        public unsafe float CurrentSpeed_Kmh
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentSpeed_Kmh);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentSpeed_Kmh)) = value;
            }
        }

        public unsafe float _CurrentSteerInput_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurrentSteerInput_k__BackingField);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurrentSteerInput_k__BackingField)) = value;
            }
        }

        public unsafe float _JumpBuildAmount_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__JumpBuildAmount_k__BackingField);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__JumpBuildAmount_k__BackingField)) = value;
            }
        }

        public unsafe Player _Rider_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Rider_k__BackingField);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Player>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Rider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe Rigidbody Rb
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rb);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rb), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe Transform CoM
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CoM);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CoM), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe Il2CppReferenceArray<Transform> HoverPoints
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HoverPoints);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HoverPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe Transform FrontAxlePosition
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrontAxlePosition);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrontAxlePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe Transform RearAxlePosition
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RearAxlePosition);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RearAxlePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe Transform PlayerContainer
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerContainer);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe SkateboardAnimation Animation
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Animation);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkateboardAnimation>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Animation), IL2CPP.Il2CppObjectBaseToPtr(value));
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

        public unsafe AverageAcceleration Accelerometer
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Accelerometer);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AverageAcceleration>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Accelerometer), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe Skateboard_Equippable Equippable
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Equippable);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Skateboard_Equippable>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Equippable), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe Transform IKAlignmentsContainer
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IKAlignmentsContainer);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IKAlignmentsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe float TurnForce
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TurnForce);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TurnForce)) = value;
            }
        }

        public unsafe float TurnChangeRate
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TurnChangeRate);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TurnChangeRate)) = value;
            }
        }

        public unsafe float TurnReturnToRestRate
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TurnReturnToRestRate);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TurnReturnToRestRate)) = value;
            }
        }

        public unsafe float TurnSpeedBoost
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TurnSpeedBoost);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TurnSpeedBoost)) = value;
            }
        }

        public unsafe AnimationCurve TurnForceMap
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TurnForceMap);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TurnForceMap), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe float Gravity
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Gravity);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Gravity)) = value;
            }
        }

        public unsafe float BrakeForce
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BrakeForce);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BrakeForce)) = value;
            }
        }

        public unsafe float ReverseTopSpeed_Kmh
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReverseTopSpeed_Kmh);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReverseTopSpeed_Kmh)) = value;
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

        public unsafe Il2CppReferenceArray<Collider> MainColliders
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MainColliders);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MainColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe float RotationClampForce
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RotationClampForce);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RotationClampForce)) = value;
            }
        }

        public unsafe bool FrictionEnabled
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrictionEnabled);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrictionEnabled)) = value;
            }
        }

        public unsafe AnimationCurve LongitudinalFrictionCurve
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LongitudinalFrictionCurve);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LongitudinalFrictionCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe float LongitudinalFrictionMultiplier
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LongitudinalFrictionMultiplier);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LongitudinalFrictionMultiplier)) = value;
            }
        }

        public unsafe float LateralFrictionForceMultiplier
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LateralFrictionForceMultiplier);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LateralFrictionForceMultiplier)) = value;
            }
        }

        public unsafe float JumpForce
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JumpForce);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JumpForce)) = value;
            }
        }

        public unsafe float JumpDuration_Min
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JumpDuration_Min);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JumpDuration_Min)) = value;
            }
        }

        public unsafe float JumpDuration_Max
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JumpDuration_Max);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JumpDuration_Max)) = value;
            }
        }

        public unsafe AnimationCurve FrontAxleJumpCurve
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrontAxleJumpCurve);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrontAxleJumpCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe AnimationCurve RearAxleJumpCurve
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RearAxleJumpCurve);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RearAxleJumpCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe AnimationCurve JumpForwardForceCurve
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JumpForwardForceCurve);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JumpForwardForceCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe float JumpForwardBoost
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JumpForwardBoost);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JumpForwardBoost)) = value;
            }
        }

        public unsafe float HoverForce
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HoverForce);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HoverForce)) = value;
            }
        }

        public unsafe float HoverRayLength
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HoverRayLength);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HoverRayLength)) = value;
            }
        }

        public unsafe float HoverHeight
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HoverHeight);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HoverHeight)) = value;
            }
        }

        public unsafe float Hover_P
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hover_P);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hover_P)) = value;
            }
        }

        public unsafe float Hover_I
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hover_I);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hover_I)) = value;
            }
        }

        public unsafe float Hover_D
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hover_D);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hover_D)) = value;
            }
        }

        public unsafe float TopSpeed_Kmh
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TopSpeed_Kmh);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TopSpeed_Kmh)) = value;
            }
        }

        public unsafe float PushForceMultiplier
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PushForceMultiplier);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PushForceMultiplier)) = value;
            }
        }

        public unsafe AnimationCurve PushForceMultiplierMap
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PushForceMultiplierMap);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PushForceMultiplierMap), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe float PushForceDuration
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PushForceDuration);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PushForceDuration)) = value;
            }
        }

        public unsafe float PushDelay
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PushDelay);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PushDelay)) = value;
            }
        }

        public unsafe AnimationCurve PushForceCurve
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PushForceCurve);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PushForceCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe bool AirMovementEnabled
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AirMovementEnabled);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AirMovementEnabled)) = value;
            }
        }

        public unsafe float AirMovementForce
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AirMovementForce);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AirMovementForce)) = value;
            }
        }

        public unsafe float AirMovementJumpReductionDuration
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AirMovementJumpReductionDuration);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AirMovementJumpReductionDuration)) = value;
            }
        }

        public unsafe AnimationCurve AirMovementJumpReductionCurve
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AirMovementJumpReductionCurve);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AirMovementJumpReductionCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe UnityEvent OnPushStart
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnPushStart);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnPushStart), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe UnityEvent<float> OnJump
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnJump);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent<float>>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnJump), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe UnityEvent OnLand
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnLand);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnLand), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe int horizontalInput
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontalInput);
                return *(int*)num;
            }
            set
            {
                *(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontalInput)) = value;
            }
        }

        public unsafe bool jumpReleased
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jumpReleased);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jumpReleased)) = value;
            }
        }

        public unsafe float timeSinceLastJump
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeSinceLastJump);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeSinceLastJump)) = value;
            }
        }

        public unsafe float timeGrounded
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeGrounded);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeGrounded)) = value;
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

        public unsafe float jumpHeldTime
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jumpHeldTime);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jumpHeldTime)) = value;
            }
        }

        public unsafe float frontAxleForce
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frontAxleForce);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frontAxleForce)) = value;
            }
        }

        public unsafe float rearAxleForce
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rearAxleForce);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rearAxleForce)) = value;
            }
        }

        public unsafe float jumpForwardForce
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jumpForwardForce);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jumpForwardForce)) = value;
            }
        }

        public unsafe List<PID> hoverPIDs
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hoverPIDs);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<PID>>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hoverPIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe bool pushQueued
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pushQueued);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pushQueued)) = value;
            }
        }

        public unsafe bool isPushing
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPushing);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPushing)) = value;
            }
        }

        public unsafe float thisFramePushForce
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisFramePushForce);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisFramePushForce)) = value;
            }
        }

        public unsafe float timeSincePushStart
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeSincePushStart);
                return *(float*)num;
            }
            set
            {
                *(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeSincePushStart)) = value;
            }
        }

        public unsafe bool braking
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_braking);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_braking)) = value;
            }
        }

        public unsafe SyncVar<float> syncVar____JumpBuildAmount_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncVar____JumpBuildAmount_k__BackingField);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncVar____JumpBuildAmount_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
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

        public unsafe float CurrentSteerInput
        {
            [CallerCount(2)]
            [CachedScanResults(RefRangeStart = 86619, RefRangeEnd = 86621, XrefRangeStart = 86619, XrefRangeEnd = 86621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentSteerInput_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CurrentSteerInput_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe bool IsPushing
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsPushing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
            }
        }

        public unsafe float TimeSincePushStart
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TimeSincePushStart_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(float*)IL2CPP.il2cpp_object_unbox(obj);
            }
        }

        public unsafe bool isGrounded
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isGrounded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
            }
        }

        public unsafe float AirTime
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AirTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(float*)IL2CPP.il2cpp_object_unbox(obj);
            }
        }

        public unsafe float JumpBuildAmount
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_JumpBuildAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(float*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(0)]
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111780, XrefRangeEnd = 111809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = (nint)(&value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_JumpBuildAmount_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe Player Rider
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Rider_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Player>(intPtr) : null;
            }
            [CallerCount(0)]
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[1];
                *ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Rider_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        public unsafe float TopSpeed_Ms
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TopSpeed_Ms_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(float*)IL2CPP.il2cpp_object_unbox(obj);
            }
        }

        public unsafe float SyncAccessor__003CJumpBuildAmount_003Ek__BackingField
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sync___get_value__JumpBuildAmount_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
                return *(float*)IL2CPP.il2cpp_object_unbox(obj);
            }
            [CallerCount(0)]
            [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112382, XrefRangeEnd = 112390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
            set
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* ptr = stackalloc System.IntPtr[2];
                *ptr = (nint)(&value);
                *(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
                System.IntPtr exc;
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sync___set_value__JumpBuildAmount_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        static Skateboard()
        {
            Il2CppClassPointerStore<Skateboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Skating", "Skateboard");
            IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Skateboard>.NativeClassPtr);
            NativeFieldInfoPtr_GroundedRaycastDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "GroundedRaycastDistance");
            NativeFieldInfoPtr_JumpCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpCooldown");
            NativeFieldInfoPtr_JumpForceMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpForceMin");
            NativeFieldInfoPtr_JumpForceBuildTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpForceBuildTime");
            NativeFieldInfoPtr_PushCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushCooldown");
            NativeFieldInfoPtr_PushStaminaConsumption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushStaminaConsumption");
            NativeFieldInfoPtr_PitchLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PitchLimit");
            NativeFieldInfoPtr_RollLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "RollLimit");
            NativeFieldInfoPtr_CurrentSpeed_Kmh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "CurrentSpeed_Kmh");
            NativeFieldInfoPtr__CurrentSteerInput_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<CurrentSteerInput>k__BackingField");
            NativeFieldInfoPtr__JumpBuildAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<JumpBuildAmount>k__BackingField");
            NativeFieldInfoPtr__Rider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<Rider>k__BackingField");
            NativeFieldInfoPtr_Rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Rb");
            NativeFieldInfoPtr_CoM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "CoM");
            NativeFieldInfoPtr_HoverPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "HoverPoints");
            NativeFieldInfoPtr_FrontAxlePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "FrontAxlePosition");
            NativeFieldInfoPtr_RearAxlePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "RearAxlePosition");
            NativeFieldInfoPtr_PlayerContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PlayerContainer");
            NativeFieldInfoPtr_Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Animation");
            NativeFieldInfoPtr_VelocityCalculator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "VelocityCalculator");
            NativeFieldInfoPtr_Accelerometer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Accelerometer");
            NativeFieldInfoPtr_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Equippable");
            NativeFieldInfoPtr_IKAlignmentsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "IKAlignmentsContainer");
            NativeFieldInfoPtr_TurnForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TurnForce");
            NativeFieldInfoPtr_TurnChangeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TurnChangeRate");
            NativeFieldInfoPtr_TurnReturnToRestRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TurnReturnToRestRate");
            NativeFieldInfoPtr_TurnSpeedBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TurnSpeedBoost");
            NativeFieldInfoPtr_TurnForceMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TurnForceMap");
            NativeFieldInfoPtr_Gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Gravity");
            NativeFieldInfoPtr_BrakeForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "BrakeForce");
            NativeFieldInfoPtr_ReverseTopSpeed_Kmh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "ReverseTopSpeed_Kmh");
            NativeFieldInfoPtr_GroundDetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "GroundDetectionMask");
            NativeFieldInfoPtr_MainColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "MainColliders");
            NativeFieldInfoPtr_RotationClampForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "RotationClampForce");
            NativeFieldInfoPtr_FrictionEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "FrictionEnabled");
            NativeFieldInfoPtr_LongitudinalFrictionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "LongitudinalFrictionCurve");
            NativeFieldInfoPtr_LongitudinalFrictionMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "LongitudinalFrictionMultiplier");
            NativeFieldInfoPtr_LateralFrictionForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "LateralFrictionForceMultiplier");
            NativeFieldInfoPtr_JumpForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpForce");
            NativeFieldInfoPtr_JumpDuration_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpDuration_Min");
            NativeFieldInfoPtr_JumpDuration_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpDuration_Max");
            NativeFieldInfoPtr_FrontAxleJumpCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "FrontAxleJumpCurve");
            NativeFieldInfoPtr_RearAxleJumpCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "RearAxleJumpCurve");
            NativeFieldInfoPtr_JumpForwardForceCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpForwardForceCurve");
            NativeFieldInfoPtr_JumpForwardBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpForwardBoost");
            NativeFieldInfoPtr_HoverForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "HoverForce");
            NativeFieldInfoPtr_HoverRayLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "HoverRayLength");
            NativeFieldInfoPtr_HoverHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "HoverHeight");
            NativeFieldInfoPtr_Hover_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Hover_P");
            NativeFieldInfoPtr_Hover_I = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Hover_I");
            NativeFieldInfoPtr_Hover_D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Hover_D");
            NativeFieldInfoPtr_TopSpeed_Kmh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TopSpeed_Kmh");
            NativeFieldInfoPtr_PushForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushForceMultiplier");
            NativeFieldInfoPtr_PushForceMultiplierMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushForceMultiplierMap");
            NativeFieldInfoPtr_PushForceDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushForceDuration");
            NativeFieldInfoPtr_PushDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushDelay");
            NativeFieldInfoPtr_PushForceCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushForceCurve");
            NativeFieldInfoPtr_AirMovementEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "AirMovementEnabled");
            NativeFieldInfoPtr_AirMovementForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "AirMovementForce");
            NativeFieldInfoPtr_AirMovementJumpReductionDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "AirMovementJumpReductionDuration");
            NativeFieldInfoPtr_AirMovementJumpReductionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "AirMovementJumpReductionCurve");
            NativeFieldInfoPtr_OnPushStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "OnPushStart");
            NativeFieldInfoPtr_OnJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "OnJump");
            NativeFieldInfoPtr_OnLand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "OnLand");
            NativeFieldInfoPtr_horizontalInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "horizontalInput");
            NativeFieldInfoPtr_jumpReleased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "jumpReleased");
            NativeFieldInfoPtr_timeSinceLastJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "timeSinceLastJump");
            NativeFieldInfoPtr_timeGrounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "timeGrounded");
            NativeFieldInfoPtr_timeAirborne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "timeAirborne");
            NativeFieldInfoPtr_jumpHeldTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "jumpHeldTime");
            NativeFieldInfoPtr_frontAxleForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "frontAxleForce");
            NativeFieldInfoPtr_rearAxleForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "rearAxleForce");
            NativeFieldInfoPtr_jumpForwardForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "jumpForwardForce");
            NativeFieldInfoPtr_hoverPIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "hoverPIDs");
            NativeFieldInfoPtr_pushQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "pushQueued");
            NativeFieldInfoPtr_isPushing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "isPushing");
            NativeFieldInfoPtr_thisFramePushForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "thisFramePushForce");
            NativeFieldInfoPtr_timeSincePushStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "timeSincePushStart");
            NativeFieldInfoPtr_braking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "braking");
            NativeFieldInfoPtr_syncVar____JumpBuildAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "syncVar___<JumpBuildAmount>k__BackingField");
            NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Skating.SkateboardAssembly-CSharp.dll_Excuted");
            NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Skating.SkateboardAssembly-CSharp.dll_Excuted");
            NativeMethodInfoPtr_get_CurrentSteerInput_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667191);
            NativeMethodInfoPtr_set_CurrentSteerInput_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667192);
            NativeMethodInfoPtr_get_IsPushing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667193);
            NativeMethodInfoPtr_get_TimeSincePushStart_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667194);
            NativeMethodInfoPtr_get_isGrounded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667195);
            NativeMethodInfoPtr_get_AirTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667196);
            NativeMethodInfoPtr_get_JumpBuildAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667197);
            NativeMethodInfoPtr_set_JumpBuildAmount_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667198);
            NativeMethodInfoPtr_get_Rider_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667199);
            NativeMethodInfoPtr_set_Rider_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667200);
            NativeMethodInfoPtr_get_TopSpeed_Ms_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667201);
            NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667202);
            NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667203);
            NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667204);
            NativeMethodInfoPtr_GetInput_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667205);
            NativeMethodInfoPtr_FixedUpdate_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667206);
            NativeMethodInfoPtr_LateUpdate_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667207);
            NativeMethodInfoPtr_ApplyInput_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667208);
            NativeMethodInfoPtr_ApplyLateralFriction_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667209);
            NativeMethodInfoPtr_UpdateHover_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667210);
            NativeMethodInfoPtr_ApplyGravity_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667211);
            NativeMethodInfoPtr_CheckGrounded_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667212);
            NativeMethodInfoPtr_CheckJump_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667213);
            NativeMethodInfoPtr_SendJump_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667214);
            NativeMethodInfoPtr_ReceiveJump_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667215);
            NativeMethodInfoPtr_Jump_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667216);
            NativeMethodInfoPtr_Push_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667217);
            NativeMethodInfoPtr_IsGrounded_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667218);
            NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667219);
            NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667220);
            NativeMethodInfoPtr_ClampRotation_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667221);
            NativeMethodInfoPtr_ApplyPlayerScale_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667222);
            NativeMethodInfoPtr_GetSurfaceSmoothness_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667223);
            NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667224);
            NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667225);
            NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667226);
            NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667227);
            NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667228);
            NativeMethodInfoPtr_RpcWriter___Server_set_JumpBuildAmount_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667229);
            NativeMethodInfoPtr_RpcLogic___set_JumpBuildAmount_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667230);
            NativeMethodInfoPtr_RpcReader___Server_set_JumpBuildAmount_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667231);
            NativeMethodInfoPtr_RpcWriter___Server_SendJump_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667232);
            NativeMethodInfoPtr_RpcLogic___SendJump_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667233);
            NativeMethodInfoPtr_RpcReader___Server_SendJump_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667234);
            NativeMethodInfoPtr_RpcWriter___Observers_ReceiveJump_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667235);
            NativeMethodInfoPtr_RpcLogic___ReceiveJump_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667236);
            NativeMethodInfoPtr_RpcReader___Observers_ReceiveJump_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667237);
            NativeMethodInfoPtr_sync___get_value__JumpBuildAmount_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667238);
            NativeMethodInfoPtr_sync___set_value__JumpBuildAmount_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667239);
            NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Skating_Skateboard_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667240);
            NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667241);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111809, XrefRangeEnd = 111810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe override void Awake()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111810, XrefRangeEnd = 111823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe override void OnStartClient()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111823, XrefRangeEnd = 111826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void Update()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 111901, RefRangeEnd = 111902, XrefRangeStart = 111826, XrefRangeEnd = 111901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void GetInput()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInput_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111902, XrefRangeEnd = 111920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void FixedUpdate()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedUpdate_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111920, XrefRangeEnd = 111922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void LateUpdate()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 111972, RefRangeEnd = 111973, XrefRangeStart = 111922, XrefRangeEnd = 111972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void ApplyInput()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyInput_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 112000, RefRangeEnd = 112001, XrefRangeStart = 111973, XrefRangeEnd = 112000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void ApplyLateralFriction()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyLateralFriction_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 112046, RefRangeEnd = 112047, XrefRangeStart = 112001, XrefRangeEnd = 112046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void UpdateHover()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateHover_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112047, XrefRangeEnd = 112059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void ApplyGravity()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyGravity_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 112061, RefRangeEnd = 112062, XrefRangeStart = 112059, XrefRangeEnd = 112061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void CheckGrounded()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckGrounded_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 112093, RefRangeEnd = 112094, XrefRangeStart = 112062, XrefRangeEnd = 112093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void CheckJump()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckJump_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 112127, RefRangeEnd = 112129, XrefRangeStart = 112094, XrefRangeEnd = 112127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SendJump(float jumpHeldTime)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&jumpHeldTime);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendJump_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 112151, RefRangeEnd = 112153, XrefRangeStart = 112129, XrefRangeEnd = 112151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void ReceiveJump(float _jumpHeldTime)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&_jumpHeldTime);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReceiveJump_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112153, XrefRangeEnd = 112168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void Jump()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Jump_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112168, XrefRangeEnd = 112175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void Push()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Push_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112175, XrefRangeEnd = 112176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe bool IsGrounded()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsGrounded_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
        }

        [CallerCount(5)]
        [CachedScanResults(RefRangeStart = 112195, RefRangeEnd = 112200, XrefRangeStart = 112176, XrefRangeEnd = 112195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe bool IsGrounded(out RaycastHit hit)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref hit);
            System.IntPtr exc;
            System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112200, XrefRangeEnd = 112202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SetVelocity(Vector3 velocity)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&velocity);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 112235, RefRangeEnd = 112236, XrefRangeStart = 112202, XrefRangeEnd = 112235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void ClampRotation()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClampRotation_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 112243, RefRangeEnd = 112245, XrefRangeStart = 112236, XrefRangeEnd = 112243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void ApplyPlayerScale()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyPlayerScale_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112245, XrefRangeEnd = 112252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe float GetSurfaceSmoothness()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSurfaceSmoothness_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(float*)IL2CPP.il2cpp_object_unbox(obj);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112252, XrefRangeEnd = 112260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe Skateboard()
            : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Skateboard>.NativeClassPtr))
        {
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112260, XrefRangeEnd = 112265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112265, XrefRangeEnd = 112301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_set_JumpBuildAmount_431000436(float value)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&value);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_set_JumpBuildAmount_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [SpecialName]
        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112301, XrefRangeEnd = 112308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___set_JumpBuildAmount_431000436(float value)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&value);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___set_JumpBuildAmount_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112308, XrefRangeEnd = 112318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_set_JumpBuildAmount_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_set_JumpBuildAmount_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112318, XrefRangeEnd = 112347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Server_SendJump_431000436(float jumpHeldTime)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&jumpHeldTime);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Server_SendJump_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 112151, RefRangeEnd = 112153, XrefRangeStart = 112151, XrefRangeEnd = 112153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___SendJump_431000436(float jumpHeldTime)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&jumpHeldTime);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___SendJump_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112347, XrefRangeEnd = 112352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Server_SendJump_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            *(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(conn);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Server_SendJump_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112352, XrefRangeEnd = 112371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcWriter___Observers_ReceiveJump_431000436(float _jumpHeldTime)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&_jumpHeldTime);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcWriter___Observers_ReceiveJump_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 112375, RefRangeEnd = 112378, XrefRangeStart = 112371, XrefRangeEnd = 112375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcLogic___ReceiveJump_431000436(float _jumpHeldTime)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&_jumpHeldTime);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcLogic___ReceiveJump_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112378, XrefRangeEnd = 112382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void RpcReader___Observers_ReceiveJump_431000436(PooledReader PooledReader0, Channel channel)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[2];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(Channel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RpcReader___Observers_ReceiveJump_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112390, XrefRangeEnd = 112391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe override bool ReadSyncVar___ScheduleOne_Skating_Skateboard(PooledReader PooledReader0, uint UInt321, bool Boolean2)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[3];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
            *(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &UInt321;
            *(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &Boolean2;
            System.IntPtr exc;
            System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Skating_Skateboard_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 112415, RefRangeEnd = 112416, XrefRangeStart = 112391, XrefRangeEnd = 112415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void Method_Private_Void_0()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        public Skateboard(System.IntPtr pointer)
            : base(pointer)
        {
        }
    }
}
