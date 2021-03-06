// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct MFP_MEDIAITEM_CLEARED_EVENT
    {
        public MFP_EVENT_HEADER header;

        [NativeTypeName("IMFPMediaItem *")]
        public IMFPMediaItem* pMediaItem;
    }
}
