// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct TS_SELECTION_ANCHOR
    {
        [NativeTypeName("IAnchor *")]
        public IAnchor* paStart;

        [NativeTypeName("IAnchor *")]
        public IAnchor* paEnd;

        public TS_SELECTIONSTYLE style;
    }
}
