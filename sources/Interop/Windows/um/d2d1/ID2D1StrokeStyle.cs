// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2CD9069D-12E2-11DC-9FED-001143A055F9")]
    public unsafe partial struct ID2D1StrokeStyle
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1StrokeStyle* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1StrokeStyle* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1StrokeStyle* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetFactory(ID2D1StrokeStyle* pThis, [NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate D2D1_CAP_STYLE _GetStartCap(ID2D1StrokeStyle* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate D2D1_CAP_STYLE _GetEndCap(ID2D1StrokeStyle* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate D2D1_CAP_STYLE _GetDashCap(ID2D1StrokeStyle* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetMiterLimit(ID2D1StrokeStyle* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate D2D1_LINE_JOIN _GetLineJoin(ID2D1StrokeStyle* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetDashOffset(ID2D1StrokeStyle* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate D2D1_DASH_STYLE _GetDashStyle(ID2D1StrokeStyle* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetDashesCount(ID2D1StrokeStyle* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetDashes(ID2D1StrokeStyle* pThis, [NativeTypeName("FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this), factory);
        }

        public D2D1_CAP_STYLE GetStartCap()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetStartCap>(lpVtbl->GetStartCap)((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        public D2D1_CAP_STYLE GetEndCap()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetEndCap>(lpVtbl->GetEndCap)((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        public D2D1_CAP_STYLE GetDashCap()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDashCap>(lpVtbl->GetDashCap)((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetMiterLimit()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMiterLimit>(lpVtbl->GetMiterLimit)((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        public D2D1_LINE_JOIN GetLineJoin()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLineJoin>(lpVtbl->GetLineJoin)((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetDashOffset()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDashOffset>(lpVtbl->GetDashOffset)((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        public D2D1_DASH_STYLE GetDashStyle()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDashStyle>(lpVtbl->GetDashStyle)((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetDashesCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDashesCount>(lpVtbl->GetDashesCount)((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        public void GetDashes([NativeTypeName("FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount)
        {
            Marshal.GetDelegateForFunctionPointer<_GetDashes>(lpVtbl->GetDashes)((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this), dashes, dashesCount);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFactory;

            [NativeTypeName("D2D1_CAP_STYLE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetStartCap;

            [NativeTypeName("D2D1_CAP_STYLE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetEndCap;

            [NativeTypeName("D2D1_CAP_STYLE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDashCap;

            [NativeTypeName("FLOAT () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMiterLimit;

            [NativeTypeName("D2D1_LINE_JOIN () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetLineJoin;

            [NativeTypeName("FLOAT () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDashOffset;

            [NativeTypeName("D2D1_DASH_STYLE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDashStyle;

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDashesCount;

            [NativeTypeName("void (FLOAT *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDashes;
        }
    }
}