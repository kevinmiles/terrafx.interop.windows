// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct SecPkgContext_ConnectionInfo
    {
        [NativeTypeName("DWORD")]
        public uint dwProtocol;

        [NativeTypeName("ALG_ID")]
        public uint aiCipher;

        [NativeTypeName("DWORD")]
        public uint dwCipherStrength;

        [NativeTypeName("ALG_ID")]
        public uint aiHash;

        [NativeTypeName("DWORD")]
        public uint dwHashStrength;

        [NativeTypeName("ALG_ID")]
        public uint aiExch;

        [NativeTypeName("DWORD")]
        public uint dwExchStrength;
    }
}
