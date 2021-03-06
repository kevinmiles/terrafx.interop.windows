// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("27354153-9F64-5B0F-8F00-5D77AFBE261E")]
    [NativeTypeName("struct IDiscFormat2Data : IDiscFormat2")]
    public unsafe partial struct IDiscFormat2Data
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, Guid*, void**, int>)(lpVtbl[0]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, uint>)(lpVtbl[1]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, uint>)(lpVtbl[2]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, uint*, int>)(lpVtbl[3]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsRecorderSupported([NativeTypeName("IDiscRecorder2 *")] IDiscRecorder2* recorder, [NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, IDiscRecorder2*, short*, int>)(lpVtbl[7]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), recorder, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsCurrentMediaSupported([NativeTypeName("IDiscRecorder2 *")] IDiscRecorder2* recorder, [NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, IDiscRecorder2*, short*, int>)(lpVtbl[8]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), recorder, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MediaPhysicallyBlank([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short*, int>)(lpVtbl[9]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MediaHeuristicallyBlank([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short*, int>)(lpVtbl[10]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SupportedMediaTypes([NativeTypeName("SAFEARRAY **")] SAFEARRAY** value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, SAFEARRAY**, int>)(lpVtbl[11]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Recorder([NativeTypeName("IDiscRecorder2 *")] IDiscRecorder2* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, IDiscRecorder2*, int>)(lpVtbl[12]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Recorder([NativeTypeName("IDiscRecorder2 **")] IDiscRecorder2** value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, IDiscRecorder2**, int>)(lpVtbl[13]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_BufferUnderrunFreeDisabled([NativeTypeName("VARIANT_BOOL")] short value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short, int>)(lpVtbl[14]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_BufferUnderrunFreeDisabled([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short*, int>)(lpVtbl[15]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_PostgapAlreadyInImage([NativeTypeName("VARIANT_BOOL")] short value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short, int>)(lpVtbl[16]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PostgapAlreadyInImage([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short*, int>)(lpVtbl[17]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CurrentMediaStatus([NativeTypeName("IMAPI_FORMAT2_DATA_MEDIA_STATE *")] IMAPI_FORMAT2_DATA_MEDIA_STATE* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, IMAPI_FORMAT2_DATA_MEDIA_STATE*, int>)(lpVtbl[18]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_WriteProtectStatus([NativeTypeName("IMAPI_MEDIA_WRITE_PROTECT_STATE *")] IMAPI_MEDIA_WRITE_PROTECT_STATE* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, IMAPI_MEDIA_WRITE_PROTECT_STATE*, int>)(lpVtbl[19]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TotalSectorsOnMedia([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, int*, int>)(lpVtbl[20]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FreeSectorsOnMedia([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, int*, int>)(lpVtbl[21]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_NextWritableAddress([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, int*, int>)(lpVtbl[22]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_StartAddressOfPreviousSession([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, int*, int>)(lpVtbl[23]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LastWrittenAddressOfPreviousSession([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, int*, int>)(lpVtbl[24]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_ForceMediaToBeClosed([NativeTypeName("VARIANT_BOOL")] short value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short, int>)(lpVtbl[25]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ForceMediaToBeClosed([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short*, int>)(lpVtbl[26]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_DisableConsumerDvdCompatibilityMode([NativeTypeName("VARIANT_BOOL")] short value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short, int>)(lpVtbl[27]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DisableConsumerDvdCompatibilityMode([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short*, int>)(lpVtbl[28]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CurrentPhysicalMediaType([NativeTypeName("IMAPI_MEDIA_PHYSICAL_TYPE *")] IMAPI_MEDIA_PHYSICAL_TYPE* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, IMAPI_MEDIA_PHYSICAL_TYPE*, int>)(lpVtbl[29]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_ClientName([NativeTypeName("BSTR")] ushort* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, ushort*, int>)(lpVtbl[30]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ClientName([NativeTypeName("BSTR *")] ushort** value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, ushort**, int>)(lpVtbl[31]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_RequestedWriteSpeed([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, int*, int>)(lpVtbl[32]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_RequestedRotationTypeIsPureCAV([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short*, int>)(lpVtbl[33]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CurrentWriteSpeed([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, int*, int>)(lpVtbl[34]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CurrentRotationTypeIsPureCAV([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short*, int>)(lpVtbl[35]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SupportedWriteSpeeds([NativeTypeName("SAFEARRAY **")] SAFEARRAY** supportedSpeeds)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, SAFEARRAY**, int>)(lpVtbl[36]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), supportedSpeeds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SupportedWriteSpeedDescriptors([NativeTypeName("SAFEARRAY **")] SAFEARRAY** supportedSpeedDescriptors)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, SAFEARRAY**, int>)(lpVtbl[37]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), supportedSpeedDescriptors);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_ForceOverwrite([NativeTypeName("VARIANT_BOOL")] short value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short, int>)(lpVtbl[38]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ForceOverwrite([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, short*, int>)(lpVtbl[39]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MultisessionInterfaces([NativeTypeName("SAFEARRAY **")] SAFEARRAY** value)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, SAFEARRAY**, int>)(lpVtbl[40]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Write([NativeTypeName("IStream *")] IStream* data)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, IStream*, int>)(lpVtbl[41]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CancelWrite()
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, int>)(lpVtbl[42]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetWriteSpeed([NativeTypeName("LONG")] int RequestedSectorsPerSecond, [NativeTypeName("VARIANT_BOOL")] short RotationTypeIsPureCAV)
        {
            return ((delegate* unmanaged<IDiscFormat2Data*, int, short, int>)(lpVtbl[43]))((IDiscFormat2Data*)Unsafe.AsPointer(ref this), RequestedSectorsPerSecond, RotationTypeIsPureCAV);
        }
    }
}
