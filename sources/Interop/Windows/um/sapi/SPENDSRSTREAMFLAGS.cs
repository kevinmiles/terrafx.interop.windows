// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum SPENDSRSTREAMFLAGS
    {
        SPESF_NONE = 0,
        SPESF_STREAM_RELEASED = (1 << 0),
        SPESF_EMULATED = (1 << 1),
    }
}
