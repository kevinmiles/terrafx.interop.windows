// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D12_FEATURE_VIDEO
    {
        D3D12_FEATURE_VIDEO_DECODE_SUPPORT = 0,
        D3D12_FEATURE_VIDEO_DECODE_PROFILES = 1,
        D3D12_FEATURE_VIDEO_DECODE_FORMATS = 2,
        D3D12_FEATURE_VIDEO_DECODE_CONVERSION_SUPPORT = 3,
        D3D12_FEATURE_VIDEO_PROCESS_SUPPORT = 5,
        D3D12_FEATURE_VIDEO_PROCESS_MAX_INPUT_STREAMS = 6,
        D3D12_FEATURE_VIDEO_PROCESS_REFERENCE_INFO = 7,
        D3D12_FEATURE_VIDEO_DECODER_HEAP_SIZE = 8,
        D3D12_FEATURE_VIDEO_PROCESSOR_SIZE = 9,
        D3D12_FEATURE_VIDEO_DECODE_PROFILE_COUNT = 10,
        D3D12_FEATURE_VIDEO_DECODE_FORMAT_COUNT = 11,
        D3D12_FEATURE_VIDEO_ARCHITECTURE = 17,
        D3D12_FEATURE_VIDEO_DECODE_HISTOGRAM = 18,
        D3D12_FEATURE_VIDEO_FEATURE_AREA_SUPPORT = 19,
        D3D12_FEATURE_VIDEO_MOTION_ESTIMATOR = 20,
        D3D12_FEATURE_VIDEO_MOTION_ESTIMATOR_SIZE = 21,
    }
}