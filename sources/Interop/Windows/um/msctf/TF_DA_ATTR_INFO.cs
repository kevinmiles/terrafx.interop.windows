// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum TF_DA_ATTR_INFO
    {
        TF_ATTR_INPUT = 0,
        TF_ATTR_TARGET_CONVERTED = 1,
        TF_ATTR_CONVERTED = 2,
        TF_ATTR_TARGET_NOTCONVERTED = 3,
        TF_ATTR_INPUT_ERROR = 4,
        TF_ATTR_FIXEDCONVERTED = 5,
        TF_ATTR_OTHER = -1,
    }
}
