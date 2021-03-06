// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DDF445E1-54BA-11D3-9144-00104BA11C5E")]
    [NativeTypeName("struct IEnumDiscMasterFormats : IUnknown")]
    public unsafe partial struct IEnumDiscMasterFormats
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumDiscMasterFormats*, Guid*, void**, int>)(lpVtbl[0]))((IEnumDiscMasterFormats*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumDiscMasterFormats*, uint>)(lpVtbl[1]))((IEnumDiscMasterFormats*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumDiscMasterFormats*, uint>)(lpVtbl[2]))((IEnumDiscMasterFormats*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint cFormats, [NativeTypeName("LPIID")] Guid* lpiidFormatID, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<IEnumDiscMasterFormats*, uint, Guid*, uint*, int>)(lpVtbl[3]))((IEnumDiscMasterFormats*)Unsafe.AsPointer(ref this), cFormats, lpiidFormatID, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint cFormats)
        {
            return ((delegate* unmanaged<IEnumDiscMasterFormats*, uint, int>)(lpVtbl[4]))((IEnumDiscMasterFormats*)Unsafe.AsPointer(ref this), cFormats);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumDiscMasterFormats*, int>)(lpVtbl[5]))((IEnumDiscMasterFormats*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumDiscMasterFormats **")] IEnumDiscMasterFormats** ppEnum)
        {
            return ((delegate* unmanaged<IEnumDiscMasterFormats*, IEnumDiscMasterFormats**, int>)(lpVtbl[6]))((IEnumDiscMasterFormats*)Unsafe.AsPointer(ref this), ppEnum);
        }
    }
}
