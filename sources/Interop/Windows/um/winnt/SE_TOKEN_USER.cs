// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct SE_TOKEN_USER
    {
        [NativeTypeName("_SE_TOKEN_USER::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:10851:5)")]
        public _Anonymous1_e__Union Anonymous1;

        public ref TOKEN_USER TokenUser
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.TokenUser, 1));
            }
        }

        public ref SID_AND_ATTRIBUTES User
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.User, 1));
            }
        }

        [NativeTypeName("_SE_TOKEN_USER::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:10856:5)")]
        public _Anonymous2_e__Union Anonymous2;

        public ref SID Sid
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.Sid, 1));
            }
        }

        public Span<byte> Buffer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return MemoryMarshal.CreateSpan(ref Anonymous2.Buffer[0], 68);
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            public TOKEN_USER TokenUser;

            [FieldOffset(0)]
            public SID_AND_ATTRIBUTES User;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            public SID Sid;

            [FieldOffset(0)]
            [NativeTypeName("BYTE [68]")]
            public fixed byte Buffer[68];
        }
    }
}
