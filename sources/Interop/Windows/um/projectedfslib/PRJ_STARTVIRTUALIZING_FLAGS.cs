// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum PRJ_STARTVIRTUALIZING_FLAGS
    {
        PRJ_FLAG_NONE = 0x00000000,
        PRJ_FLAG_USE_NEGATIVE_PATH_CACHE = 0x00000001,
    }
}
