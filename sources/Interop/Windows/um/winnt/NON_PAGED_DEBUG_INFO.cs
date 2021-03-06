// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct NON_PAGED_DEBUG_INFO
    {
        [NativeTypeName("WORD")]
        public ushort Signature;

        [NativeTypeName("WORD")]
        public ushort Flags;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("WORD")]
        public ushort Machine;

        [NativeTypeName("WORD")]
        public ushort Characteristics;

        [NativeTypeName("DWORD")]
        public uint TimeDateStamp;

        [NativeTypeName("DWORD")]
        public uint CheckSum;

        [NativeTypeName("DWORD")]
        public uint SizeOfImage;

        [NativeTypeName("ULONGLONG")]
        public ulong ImageBase;
    }
}
