// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("743ABD5F-F26D-48DF-8CC5-238492419B64")]
    [NativeTypeName("struct ITfCompartmentEventSink : IUnknown")]
    public unsafe partial struct ITfCompartmentEventSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfCompartmentEventSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfCompartmentEventSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfCompartmentEventSink*, uint>)(lpVtbl[1]))((ITfCompartmentEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfCompartmentEventSink*, uint>)(lpVtbl[2]))((ITfCompartmentEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnChange([NativeTypeName("const GUID &")] Guid* rguid)
        {
            return ((delegate* unmanaged<ITfCompartmentEventSink*, Guid*, int>)(lpVtbl[3]))((ITfCompartmentEventSink*)Unsafe.AsPointer(ref this), rguid);
        }
    }
}
