// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("862494C6-1310-4AAD-B3CD-2DBEEBF670D3")]
    [NativeTypeName("struct IXmlWriterLite : IUnknown")]
    public unsafe partial struct IXmlWriterLite
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, Guid*, void**, int>)(lpVtbl[0]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IXmlWriterLite*, uint>)(lpVtbl[1]))((IXmlWriterLite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IXmlWriterLite*, uint>)(lpVtbl[2]))((IXmlWriterLite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutput([NativeTypeName("IUnknown *")] IUnknown* pOutput)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, IUnknown*, int>)(lpVtbl[3]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProperty([NativeTypeName("UINT")] uint nProperty, [NativeTypeName("LONG_PTR *")] nint* ppValue)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, uint, nint*, int>)(lpVtbl[4]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), nProperty, ppValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetProperty([NativeTypeName("UINT")] uint nProperty, [NativeTypeName("LONG_PTR")] nint pValue)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, uint, nint, int>)(lpVtbl[5]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), nProperty, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteAttributes([NativeTypeName("IXmlReader *")] IXmlReader* pReader, [NativeTypeName("BOOL")] int fWriteDefaultAttributes)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, IXmlReader*, int, int>)(lpVtbl[6]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pReader, fWriteDefaultAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteAttributeString([NativeTypeName("const WCHAR *")] ushort* pwszQName, [NativeTypeName("UINT")] uint cwszQName, [NativeTypeName("const WCHAR *")] ushort* pwszValue, [NativeTypeName("UINT")] uint cwszValue)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, ushort*, uint, ushort*, uint, int>)(lpVtbl[7]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszQName, cwszQName, pwszValue, cwszValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteCData([NativeTypeName("LPCWSTR")] ushort* pwszText)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, ushort*, int>)(lpVtbl[8]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteCharEntity([NativeTypeName("WCHAR")] ushort wch)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, ushort, int>)(lpVtbl[9]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), wch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteChars([NativeTypeName("const WCHAR *")] ushort* pwch, [NativeTypeName("UINT")] uint cwch)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, ushort*, uint, int>)(lpVtbl[10]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwch, cwch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteComment([NativeTypeName("LPCWSTR")] ushort* pwszComment)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, ushort*, int>)(lpVtbl[11]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszComment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteDocType([NativeTypeName("LPCWSTR")] ushort* pwszName, [NativeTypeName("LPCWSTR")] ushort* pwszPublicId, [NativeTypeName("LPCWSTR")] ushort* pwszSystemId, [NativeTypeName("LPCWSTR")] ushort* pwszSubset)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, ushort*, ushort*, ushort*, ushort*, int>)(lpVtbl[12]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszName, pwszPublicId, pwszSystemId, pwszSubset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteElementString([NativeTypeName("const WCHAR *")] ushort* pwszQName, [NativeTypeName("UINT")] uint cwszQName, [NativeTypeName("LPCWSTR")] ushort* pwszValue)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, ushort*, uint, ushort*, int>)(lpVtbl[13]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszQName, cwszQName, pwszValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteEndDocument()
        {
            return ((delegate* unmanaged<IXmlWriterLite*, int>)(lpVtbl[14]))((IXmlWriterLite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteEndElement([NativeTypeName("const WCHAR *")] ushort* pwszQName, [NativeTypeName("UINT")] uint cwszQName)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, ushort*, uint, int>)(lpVtbl[15]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszQName, cwszQName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteEntityRef([NativeTypeName("LPCWSTR")] ushort* pwszName)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, ushort*, int>)(lpVtbl[16]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteFullEndElement([NativeTypeName("const WCHAR *")] ushort* pwszQName, [NativeTypeName("UINT")] uint cwszQName)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, ushort*, uint, int>)(lpVtbl[17]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszQName, cwszQName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteName([NativeTypeName("LPCWSTR")] ushort* pwszName)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, ushort*, int>)(lpVtbl[18]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteNmToken([NativeTypeName("LPCWSTR")] ushort* pwszNmToken)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, ushort*, int>)(lpVtbl[19]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszNmToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteNode([NativeTypeName("IXmlReader *")] IXmlReader* pReader, [NativeTypeName("BOOL")] int fWriteDefaultAttributes)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, IXmlReader*, int, int>)(lpVtbl[20]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pReader, fWriteDefaultAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteNodeShallow([NativeTypeName("IXmlReader *")] IXmlReader* pReader, [NativeTypeName("BOOL")] int fWriteDefaultAttributes)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, IXmlReader*, int, int>)(lpVtbl[21]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pReader, fWriteDefaultAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteProcessingInstruction([NativeTypeName("LPCWSTR")] ushort* pwszName, [NativeTypeName("LPCWSTR")] ushort* pwszText)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, ushort*, ushort*, int>)(lpVtbl[22]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszName, pwszText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteRaw([NativeTypeName("LPCWSTR")] ushort* pwszData)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, ushort*, int>)(lpVtbl[23]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteRawChars([NativeTypeName("const WCHAR *")] ushort* pwch, [NativeTypeName("UINT")] uint cwch)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, ushort*, uint, int>)(lpVtbl[24]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwch, cwch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteStartDocument(XmlStandalone standalone)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, XmlStandalone, int>)(lpVtbl[25]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), standalone);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteStartElement([NativeTypeName("const WCHAR *")] ushort* pwszQName, [NativeTypeName("UINT")] uint cwszQName)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, ushort*, uint, int>)(lpVtbl[26]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszQName, cwszQName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteString([NativeTypeName("LPCWSTR")] ushort* pwszText)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, ushort*, int>)(lpVtbl[27]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteSurrogateCharEntity([NativeTypeName("WCHAR")] ushort wchLow, [NativeTypeName("WCHAR")] ushort wchHigh)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, ushort, ushort, int>)(lpVtbl[28]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), wchLow, wchHigh);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteWhitespace([NativeTypeName("LPCWSTR")] ushort* pwszWhitespace)
        {
            return ((delegate* unmanaged<IXmlWriterLite*, ushort*, int>)(lpVtbl[29]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszWhitespace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Flush()
        {
            return ((delegate* unmanaged<IXmlWriterLite*, int>)(lpVtbl[30]))((IXmlWriterLite*)Unsafe.AsPointer(ref this));
        }
    }
}
