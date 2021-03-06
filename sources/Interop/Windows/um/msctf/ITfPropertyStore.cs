// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6834B120-88CB-11D2-BF45-00105A2799B5")]
    [NativeTypeName("struct ITfPropertyStore : IUnknown")]
    public unsafe partial struct ITfPropertyStore
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfPropertyStore*, Guid*, void**, int>)(lpVtbl[0]))((ITfPropertyStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfPropertyStore*, uint>)(lpVtbl[1]))((ITfPropertyStore*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfPropertyStore*, uint>)(lpVtbl[2]))((ITfPropertyStore*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetType([NativeTypeName("GUID *")] Guid* pguid)
        {
            return ((delegate* unmanaged<ITfPropertyStore*, Guid*, int>)(lpVtbl[3]))((ITfPropertyStore*)Unsafe.AsPointer(ref this), pguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDataType([NativeTypeName("DWORD *")] uint* pdwReserved)
        {
            return ((delegate* unmanaged<ITfPropertyStore*, uint*, int>)(lpVtbl[4]))((ITfPropertyStore*)Unsafe.AsPointer(ref this), pdwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetData([NativeTypeName("VARIANT *")] VARIANT* pvarValue)
        {
            return ((delegate* unmanaged<ITfPropertyStore*, VARIANT*, int>)(lpVtbl[5]))((ITfPropertyStore*)Unsafe.AsPointer(ref this), pvarValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnTextUpdated([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ITfRange *")] ITfRange* pRangeNew, [NativeTypeName("BOOL *")] int* pfAccept)
        {
            return ((delegate* unmanaged<ITfPropertyStore*, uint, ITfRange*, int*, int>)(lpVtbl[6]))((ITfPropertyStore*)Unsafe.AsPointer(ref this), dwFlags, pRangeNew, pfAccept);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Shrink([NativeTypeName("ITfRange *")] ITfRange* pRangeNew, [NativeTypeName("BOOL *")] int* pfFree)
        {
            return ((delegate* unmanaged<ITfPropertyStore*, ITfRange*, int*, int>)(lpVtbl[7]))((ITfPropertyStore*)Unsafe.AsPointer(ref this), pRangeNew, pfFree);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Divide([NativeTypeName("ITfRange *")] ITfRange* pRangeThis, [NativeTypeName("ITfRange *")] ITfRange* pRangeNew, [NativeTypeName("ITfPropertyStore **")] ITfPropertyStore** ppPropStore)
        {
            return ((delegate* unmanaged<ITfPropertyStore*, ITfRange*, ITfRange*, ITfPropertyStore**, int>)(lpVtbl[8]))((ITfPropertyStore*)Unsafe.AsPointer(ref this), pRangeThis, pRangeNew, ppPropStore);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("ITfPropertyStore **")] ITfPropertyStore** pPropStore)
        {
            return ((delegate* unmanaged<ITfPropertyStore*, ITfPropertyStore**, int>)(lpVtbl[9]))((ITfPropertyStore*)Unsafe.AsPointer(ref this), pPropStore);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyRangeCreator([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return ((delegate* unmanaged<ITfPropertyStore*, Guid*, int>)(lpVtbl[10]))((ITfPropertyStore*)Unsafe.AsPointer(ref this), pclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Serialize([NativeTypeName("IStream *")] IStream* pStream, [NativeTypeName("ULONG *")] uint* pcb)
        {
            return ((delegate* unmanaged<ITfPropertyStore*, IStream*, uint*, int>)(lpVtbl[11]))((ITfPropertyStore*)Unsafe.AsPointer(ref this), pStream, pcb);
        }
    }
}
