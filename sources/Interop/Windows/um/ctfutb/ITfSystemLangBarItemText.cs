// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5C4CE0E5-BA49-4B52-AC6B-3B397B4F701F")]
    [NativeTypeName("struct ITfSystemLangBarItemText : IUnknown")]
    public unsafe partial struct ITfSystemLangBarItemText
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfSystemLangBarItemText*, Guid*, void**, int>)(lpVtbl[0]))((ITfSystemLangBarItemText*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfSystemLangBarItemText*, uint>)(lpVtbl[1]))((ITfSystemLangBarItemText*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfSystemLangBarItemText*, uint>)(lpVtbl[2]))((ITfSystemLangBarItemText*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetItemText([NativeTypeName("const WCHAR *")] ushort* pch, [NativeTypeName("ULONG")] uint cch)
        {
            return ((delegate* unmanaged<ITfSystemLangBarItemText*, ushort*, uint, int>)(lpVtbl[3]))((ITfSystemLangBarItemText*)Unsafe.AsPointer(ref this), pch, cch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemText([NativeTypeName("BSTR *")] ushort** pbstrText)
        {
            return ((delegate* unmanaged<ITfSystemLangBarItemText*, ushort**, int>)(lpVtbl[4]))((ITfSystemLangBarItemText*)Unsafe.AsPointer(ref this), pbstrText);
        }
    }
}
