// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct SET_DAX_ALLOC_ALIGNMENT_HINT_INPUT
    {
        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint AlignmentShift;

        [NativeTypeName("DWORDLONG")]
        public ulong FileOffsetToAlign;

        [NativeTypeName("DWORD")]
        public uint FallbackAlignmentShift;
    }
}
