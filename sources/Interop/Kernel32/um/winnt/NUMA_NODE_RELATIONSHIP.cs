// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct NUMA_NODE_RELATIONSHIP
    {
        [NativeTypeName("DWORD")]
        public uint NodeNumber;

        [NativeTypeName("BYTE [20]")]
        public fixed byte Reserved[20];

        public GROUP_AFFINITY GroupMask;
    }
}
