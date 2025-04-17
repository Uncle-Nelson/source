using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
    public class App<T> : PlayerSingleton<T> where T : PlayerSingleton<T>
    {
        [OriginalName("Assembly-CSharp.dll", "", "EOrientation")]
        public enum EOrientation
        {
            Horizontal,
            Vertical
        }

        private static readonly System.IntPtr NativeFieldInfoPtr_Apps;

        private static readonly System.IntPtr NativeFieldInfoPtr_AppName;

        private static readonly System.IntPtr NativeFieldInfoPtr_IconLabel;

        private static readonly System.IntPtr NativeFieldInfoPtr_AppIcon;

        private static readonly System.IntPtr NativeFieldInfoPtr_Orientation;

        private static readonly System.IntPtr NativeFieldInfoPtr_AvailableInTutorial;

        private static readonly System.IntPtr NativeFieldInfoPtr_appContainer;

        private static readonly System.IntPtr NativeFieldInfoPtr_notificationContainer;

        private static readonly System.IntPtr NativeFieldInfoPtr_notificationText;

        private static readonly System.IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

        private static readonly System.IntPtr NativeFieldInfoPtr_appIconButton;

        private static readonly System.IntPtr NativeMethodInfoPtr_GetApp_Public_Static_App_1_T_Int32_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_Close_Private_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_IsHoveringButton_Private_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_GenerateHomeScreenIcon_Private_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SetNotificationCount_Public_Void_Int32_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_OnPhoneOpened_Protected_Virtual_New_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_ShortcutClicked_Private_Void_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0;

        private static readonly System.IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_New_Void_Boolean_0;

        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

        public unsafe static List<App<T>> Apps
        {
            get
            {
                System.IntPtr intPtr;
                IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Apps, &intPtr);
                System.IntPtr intPtr2 = intPtr;
                return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<App<T>>>(intPtr2) : null;
            }
            set
            {
                IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Apps, (void*)IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe string AppName
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AppName);
                return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AppName), IL2CPP.ManagedStringToIl2Cpp(value));
            }
        }

        public unsafe string IconLabel
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconLabel);
                return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconLabel), IL2CPP.ManagedStringToIl2Cpp(value));
            }
        }

        public unsafe Sprite AppIcon
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AppIcon);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AppIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe EOrientation Orientation
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Orientation);
                return *(EOrientation*)num;
            }
            set
            {
                //IL_0018: Expected O, but got I4
                // IL cpblk instruction
                System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Orientation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EOrientation>.NativeClassPtr, ref *(uint*)null));
            }
        }

        public unsafe bool AvailableInTutorial
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AvailableInTutorial);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AvailableInTutorial)) = value;
            }
        }

        public unsafe RectTransform appContainer
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appContainer);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe RectTransform notificationContainer
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notificationContainer);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notificationContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe Text notificationText
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notificationText);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Text>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notificationText), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe bool _isOpen_k__BackingField
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isOpen_k__BackingField);
                return *(bool*)num;
            }
            set
            {
                *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
            }
        }

        public unsafe Button appIconButton
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appIconButton);
                System.IntPtr intPtr = *(System.IntPtr*)num;
                return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Button>(intPtr) : null;
            }
            set
            {
                System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appIconButton), IL2CPP.Il2CppObjectBaseToPtr(value));
            }
        }

        public unsafe bool isOpen
        {
            [CallerCount(0)]
            get
            {
                IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
                System.IntPtr* param = null;
                System.IntPtr exc;
                System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
                System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
                Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            }
        }

        static App()
        {
            Il2CppClassPointerStore<App<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "App`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
            IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<App<T>>.NativeClassPtr);
            NativeFieldInfoPtr_Apps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "Apps");
            NativeFieldInfoPtr_AppName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "AppName");
            NativeFieldInfoPtr_IconLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "IconLabel");
            NativeFieldInfoPtr_AppIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "AppIcon");
            NativeFieldInfoPtr_Orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "Orientation");
            NativeFieldInfoPtr_AvailableInTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "AvailableInTutorial");
            NativeFieldInfoPtr_appContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "appContainer");
            NativeFieldInfoPtr_notificationContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "notificationContainer");
            NativeFieldInfoPtr_notificationText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "notificationText");
            NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "<isOpen>k__BackingField");
            NativeFieldInfoPtr_appIconButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "appIconButton");
            NativeMethodInfoPtr_GetApp_Public_Static_App_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681124);
            NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681125);
            NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681126);
            NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681127);
            NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681128);
            NativeMethodInfoPtr_Close_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681129);
            NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681130);
            NativeMethodInfoPtr_IsHoveringButton_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681131);
            NativeMethodInfoPtr_GenerateHomeScreenIcon_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681132);
            NativeMethodInfoPtr_SetNotificationCount_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681133);
            NativeMethodInfoPtr_OnPhoneOpened_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681134);
            NativeMethodInfoPtr_ShortcutClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681135);
            NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681136);
            NativeMethodInfoPtr_SetOpen_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681137);
            NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681138);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260752, XrefRangeEnd = 260765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe static App<T> GetApp(int index)
        {
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&index);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetApp_Public_Static_App_1_T_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<App<T>>(intPtr) : null;
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260765, XrefRangeEnd = 260773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe override void OnStartClient(bool IsOwner)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&IsOwner);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(7)]
        [CachedScanResults(RefRangeStart = 260811, RefRangeEnd = 260818, XrefRangeStart = 260773, XrefRangeEnd = 260811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe override void Start()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        public unsafe void Close()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Close_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(6)]
        [CachedScanResults(RefRangeStart = 260827, RefRangeEnd = 260833, XrefRangeStart = 260818, XrefRangeEnd = 260827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe virtual void Update()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 260852, RefRangeEnd = 260853, XrefRangeStart = 260833, XrefRangeEnd = 260852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe bool IsHoveringButton()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHoveringButton_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260853, XrefRangeEnd = 260882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void GenerateHomeScreenIcon()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateHomeScreenIcon_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 260885, RefRangeEnd = 260886, XrefRangeStart = 260882, XrefRangeEnd = 260885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe void SetNotificationCount(int amount)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&amount);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetNotificationCount_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260886, XrefRangeEnd = 260890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe virtual void OnPhoneOpened()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnPhoneOpened_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        public unsafe void ShortcutClicked()
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShortcutClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 260896, RefRangeEnd = 260897, XrefRangeStart = 260890, XrefRangeEnd = 260896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe virtual void Exit(ExitAction exit)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(7)]
        [CachedScanResults(RefRangeStart = 260960, RefRangeEnd = 260967, XrefRangeStart = 260897, XrefRangeEnd = 260960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe virtual void SetOpen(bool open)
        {
            IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            System.IntPtr* ptr = stackalloc System.IntPtr[1];
            *ptr = (nint)(&open);
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetOpen_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(8)]
        [CachedScanResults(RefRangeStart = 260968, RefRangeEnd = 260976, XrefRangeStart = 260967, XrefRangeEnd = 260968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
        public unsafe App()
            : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<App<T>>.NativeClassPtr))
        {
            System.IntPtr* param = null;
            System.IntPtr exc;
            System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
            Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        public App(System.IntPtr pointer)
            : base(pointer)
        {
        }
    }
}
