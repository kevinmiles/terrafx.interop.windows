// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_5.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum DXGI_OUTDUPL_FLAG
    {
        DXGI_OUTDUPL_COMPOSITED_UI_CAPTURE_ONLY = 1,
    }
}
