// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum STORAGE_ZONE_CONDITION
    {
        ZoneConditionConventional = 0x00,
        ZoneConditionEmpty = 0x01,
        ZoneConditionImplicitlyOpened = 0x02,
        ZoneConditionExplicitlyOpened = 0x03,
        ZoneConditionClosed = 0x04,
        ZoneConditionReadOnly = 0x0D,
        ZoneConditionFull = 0x0E,
        ZoneConditionOffline = 0x0F,
    }
}
