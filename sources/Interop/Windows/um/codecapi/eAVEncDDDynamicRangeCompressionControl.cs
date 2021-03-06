// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum eAVEncDDDynamicRangeCompressionControl
    {
        eAVEncDDDynamicRangeCompressionControl_None = 0,
        eAVEncDDDynamicRangeCompressionControl_FilmStandard = 1,
        eAVEncDDDynamicRangeCompressionControl_FilmLight = 2,
        eAVEncDDDynamicRangeCompressionControl_MusicStandard = 3,
        eAVEncDDDynamicRangeCompressionControl_MusicLight = 4,
        eAVEncDDDynamicRangeCompressionControl_Speech = 5,
    }
}
