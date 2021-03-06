// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DEVICE_COPY_OFFLOAD_DESCRIPTOR
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint MaximumTokenLifetime;

        [NativeTypeName("DWORD")]
        public uint DefaultTokenLifetime;

        [NativeTypeName("DWORDLONG")]
        public ulong MaximumTransferSize;

        [NativeTypeName("DWORDLONG")]
        public ulong OptimalTransferCount;

        [NativeTypeName("DWORD")]
        public uint MaximumDataDescriptors;

        [NativeTypeName("DWORD")]
        public uint MaximumTransferLengthPerDescriptor;

        [NativeTypeName("DWORD")]
        public uint OptimalTransferLengthPerDescriptor;

        [NativeTypeName("WORD")]
        public ushort OptimalTransferLengthGranularity;

        [NativeTypeName("BYTE [2]")]
        public fixed byte Reserved[2];
    }
}
