// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SPC_SP_OPUS_INFO
    {
        [NativeTypeName("LPCWSTR")]
        public ushort* pwszProgramName;

        [NativeTypeName("struct SPC_LINK_ *")]
        public SPC_LINK* pMoreInfo;

        [NativeTypeName("struct SPC_LINK_ *")]
        public SPC_LINK* pPublisherInfo;
    }
}
