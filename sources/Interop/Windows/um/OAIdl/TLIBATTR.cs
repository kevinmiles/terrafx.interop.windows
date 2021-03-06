// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct TLIBATTR
    {
        [NativeTypeName("GUID")]
        public Guid guid;

        [NativeTypeName("LCID")]
        public uint lcid;

        public SYSKIND syskind;

        [NativeTypeName("WORD")]
        public ushort wMajorVerNum;

        [NativeTypeName("WORD")]
        public ushort wMinorVerNum;

        [NativeTypeName("WORD")]
        public ushort wLibFlags;
    }
}
