// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct QUOTA_LIMITS_EX
    {
        [NativeTypeName("SIZE_T")]
        public nuint PagedPoolLimit;

        [NativeTypeName("SIZE_T")]
        public nuint NonPagedPoolLimit;

        [NativeTypeName("SIZE_T")]
        public nuint MinimumWorkingSetSize;

        [NativeTypeName("SIZE_T")]
        public nuint MaximumWorkingSetSize;

        [NativeTypeName("SIZE_T")]
        public nuint PagefileLimit;

        public LARGE_INTEGER TimeLimit;

        [NativeTypeName("SIZE_T")]
        public nuint WorkingSetLimit;

        [NativeTypeName("SIZE_T")]
        public nuint Reserved2;

        [NativeTypeName("SIZE_T")]
        public nuint Reserved3;

        [NativeTypeName("SIZE_T")]
        public nuint Reserved4;

        [NativeTypeName("DWORD")]
        public uint Flags;

        public RATE_QUOTA_LIMIT CpuRateLimit;
    }
}
