// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B7E4C8F-342C-4106-A19F-4F2704F689F0")]
    [NativeTypeName("struct ID3D10Device1 : ID3D10Device")]
    public unsafe partial struct ID3D10Device1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D10Device1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D10Device1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D10Device1*, uint>)(lpVtbl[1]))((ID3D10Device1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D10Device1*, uint>)(lpVtbl[2]))((ID3D10Device1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VSSetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D10Buffer *const *")] ID3D10Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10Buffer**, void>)(lpVtbl[3]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PSSetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D10ShaderResourceView *const *")] ID3D10ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10ShaderResourceView**, void>)(lpVtbl[4]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PSSetShader([NativeTypeName("ID3D10PixelShader *")] ID3D10PixelShader* pPixelShader)
        {
            ((delegate* unmanaged<ID3D10Device1*, ID3D10PixelShader*, void>)(lpVtbl[5]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pPixelShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PSSetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D10SamplerState *const *")] ID3D10SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10SamplerState**, void>)(lpVtbl[6]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VSSetShader([NativeTypeName("ID3D10VertexShader *")] ID3D10VertexShader* pVertexShader)
        {
            ((delegate* unmanaged<ID3D10Device1*, ID3D10VertexShader*, void>)(lpVtbl[7]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pVertexShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawIndexed([NativeTypeName("UINT")] uint IndexCount, [NativeTypeName("UINT")] uint StartIndexLocation, [NativeTypeName("INT")] int BaseVertexLocation)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, uint, int, void>)(lpVtbl[8]))((ID3D10Device1*)Unsafe.AsPointer(ref this), IndexCount, StartIndexLocation, BaseVertexLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Draw([NativeTypeName("UINT")] uint VertexCount, [NativeTypeName("UINT")] uint StartVertexLocation)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, uint, void>)(lpVtbl[9]))((ID3D10Device1*)Unsafe.AsPointer(ref this), VertexCount, StartVertexLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PSSetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D10Buffer *const *")] ID3D10Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10Buffer**, void>)(lpVtbl[10]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void IASetInputLayout([NativeTypeName("ID3D10InputLayout *")] ID3D10InputLayout* pInputLayout)
        {
            ((delegate* unmanaged<ID3D10Device1*, ID3D10InputLayout*, void>)(lpVtbl[11]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pInputLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void IASetVertexBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D10Buffer *const *")] ID3D10Buffer** ppVertexBuffers, [NativeTypeName("const UINT *")] uint* pStrides, [NativeTypeName("const UINT *")] uint* pOffsets)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10Buffer**, uint*, uint*, void>)(lpVtbl[12]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void IASetIndexBuffer([NativeTypeName("ID3D10Buffer *")] ID3D10Buffer* pIndexBuffer, DXGI_FORMAT Format, [NativeTypeName("UINT")] uint Offset)
        {
            ((delegate* unmanaged<ID3D10Device1*, ID3D10Buffer*, DXGI_FORMAT, uint, void>)(lpVtbl[13]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pIndexBuffer, Format, Offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawIndexedInstanced([NativeTypeName("UINT")] uint IndexCountPerInstance, [NativeTypeName("UINT")] uint InstanceCount, [NativeTypeName("UINT")] uint StartIndexLocation, [NativeTypeName("INT")] int BaseVertexLocation, [NativeTypeName("UINT")] uint StartInstanceLocation)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, uint, uint, int, uint, void>)(lpVtbl[14]))((ID3D10Device1*)Unsafe.AsPointer(ref this), IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawInstanced([NativeTypeName("UINT")] uint VertexCountPerInstance, [NativeTypeName("UINT")] uint InstanceCount, [NativeTypeName("UINT")] uint StartVertexLocation, [NativeTypeName("UINT")] uint StartInstanceLocation)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, uint, uint, uint, void>)(lpVtbl[15]))((ID3D10Device1*)Unsafe.AsPointer(ref this), VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GSSetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D10Buffer *const *")] ID3D10Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10Buffer**, void>)(lpVtbl[16]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GSSetShader([NativeTypeName("ID3D10GeometryShader *")] ID3D10GeometryShader* pShader)
        {
            ((delegate* unmanaged<ID3D10Device1*, ID3D10GeometryShader*, void>)(lpVtbl[17]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void IASetPrimitiveTopology([NativeTypeName("D3D10_PRIMITIVE_TOPOLOGY")] D3D_PRIMITIVE_TOPOLOGY Topology)
        {
            ((delegate* unmanaged<ID3D10Device1*, D3D_PRIMITIVE_TOPOLOGY, void>)(lpVtbl[18]))((ID3D10Device1*)Unsafe.AsPointer(ref this), Topology);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VSSetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D10ShaderResourceView *const *")] ID3D10ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10ShaderResourceView**, void>)(lpVtbl[19]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VSSetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D10SamplerState *const *")] ID3D10SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10SamplerState**, void>)(lpVtbl[20]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetPredication([NativeTypeName("ID3D10Predicate *")] ID3D10Predicate* pPredicate, [NativeTypeName("BOOL")] int PredicateValue)
        {
            ((delegate* unmanaged<ID3D10Device1*, ID3D10Predicate*, int, void>)(lpVtbl[21]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pPredicate, PredicateValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GSSetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D10ShaderResourceView *const *")] ID3D10ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10ShaderResourceView**, void>)(lpVtbl[22]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GSSetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D10SamplerState *const *")] ID3D10SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10SamplerState**, void>)(lpVtbl[23]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OMSetRenderTargets([NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D10RenderTargetView *const *")] ID3D10RenderTargetView** ppRenderTargetViews, [NativeTypeName("ID3D10DepthStencilView *")] ID3D10DepthStencilView* pDepthStencilView)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, ID3D10RenderTargetView**, ID3D10DepthStencilView*, void>)(lpVtbl[24]))((ID3D10Device1*)Unsafe.AsPointer(ref this), NumViews, ppRenderTargetViews, pDepthStencilView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OMSetBlendState([NativeTypeName("ID3D10BlendState *")] ID3D10BlendState* pBlendState, [NativeTypeName("const FLOAT [4]")] float* BlendFactor, [NativeTypeName("UINT")] uint SampleMask)
        {
            ((delegate* unmanaged<ID3D10Device1*, ID3D10BlendState*, float*, uint, void>)(lpVtbl[25]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pBlendState, BlendFactor, SampleMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OMSetDepthStencilState([NativeTypeName("ID3D10DepthStencilState *")] ID3D10DepthStencilState* pDepthStencilState, [NativeTypeName("UINT")] uint StencilRef)
        {
            ((delegate* unmanaged<ID3D10Device1*, ID3D10DepthStencilState*, uint, void>)(lpVtbl[26]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pDepthStencilState, StencilRef);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SOSetTargets([NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D10Buffer *const *")] ID3D10Buffer** ppSOTargets, [NativeTypeName("const UINT *")] uint* pOffsets)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, ID3D10Buffer**, uint*, void>)(lpVtbl[27]))((ID3D10Device1*)Unsafe.AsPointer(ref this), NumBuffers, ppSOTargets, pOffsets);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DrawAuto()
        {
            ((delegate* unmanaged<ID3D10Device1*, void>)(lpVtbl[28]))((ID3D10Device1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RSSetState([NativeTypeName("ID3D10RasterizerState *")] ID3D10RasterizerState* pRasterizerState)
        {
            ((delegate* unmanaged<ID3D10Device1*, ID3D10RasterizerState*, void>)(lpVtbl[29]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pRasterizerState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RSSetViewports([NativeTypeName("UINT")] uint NumViewports, [NativeTypeName("const D3D10_VIEWPORT *")] D3D10_VIEWPORT* pViewports)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, D3D10_VIEWPORT*, void>)(lpVtbl[30]))((ID3D10Device1*)Unsafe.AsPointer(ref this), NumViewports, pViewports);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RSSetScissorRects([NativeTypeName("UINT")] uint NumRects, [NativeTypeName("const D3D10_RECT *")] RECT* pRects)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, RECT*, void>)(lpVtbl[31]))((ID3D10Device1*)Unsafe.AsPointer(ref this), NumRects, pRects);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopySubresourceRegion([NativeTypeName("ID3D10Resource *")] ID3D10Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("UINT")] uint DstX, [NativeTypeName("UINT")] uint DstY, [NativeTypeName("UINT")] uint DstZ, [NativeTypeName("ID3D10Resource *")] ID3D10Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, [NativeTypeName("const D3D10_BOX *")] D3D10_BOX* pSrcBox)
        {
            ((delegate* unmanaged<ID3D10Device1*, ID3D10Resource*, uint, uint, uint, uint, ID3D10Resource*, uint, D3D10_BOX*, void>)(lpVtbl[32]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyResource([NativeTypeName("ID3D10Resource *")] ID3D10Resource* pDstResource, [NativeTypeName("ID3D10Resource *")] ID3D10Resource* pSrcResource)
        {
            ((delegate* unmanaged<ID3D10Device1*, ID3D10Resource*, ID3D10Resource*, void>)(lpVtbl[33]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pDstResource, pSrcResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void UpdateSubresource([NativeTypeName("ID3D10Resource *")] ID3D10Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("const D3D10_BOX *")] D3D10_BOX* pDstBox, [NativeTypeName("const void *")] void* pSrcData, [NativeTypeName("UINT")] uint SrcRowPitch, [NativeTypeName("UINT")] uint SrcDepthPitch)
        {
            ((delegate* unmanaged<ID3D10Device1*, ID3D10Resource*, uint, D3D10_BOX*, void*, uint, uint, void>)(lpVtbl[34]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ClearRenderTargetView([NativeTypeName("ID3D10RenderTargetView *")] ID3D10RenderTargetView* pRenderTargetView, [NativeTypeName("const FLOAT [4]")] float* ColorRGBA)
        {
            ((delegate* unmanaged<ID3D10Device1*, ID3D10RenderTargetView*, float*, void>)(lpVtbl[35]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pRenderTargetView, ColorRGBA);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ClearDepthStencilView([NativeTypeName("ID3D10DepthStencilView *")] ID3D10DepthStencilView* pDepthStencilView, [NativeTypeName("UINT")] uint ClearFlags, [NativeTypeName("FLOAT")] float Depth, [NativeTypeName("UINT8")] byte Stencil)
        {
            ((delegate* unmanaged<ID3D10Device1*, ID3D10DepthStencilView*, uint, float, byte, void>)(lpVtbl[36]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pDepthStencilView, ClearFlags, Depth, Stencil);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GenerateMips([NativeTypeName("ID3D10ShaderResourceView *")] ID3D10ShaderResourceView* pShaderResourceView)
        {
            ((delegate* unmanaged<ID3D10Device1*, ID3D10ShaderResourceView*, void>)(lpVtbl[37]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pShaderResourceView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ResolveSubresource([NativeTypeName("ID3D10Resource *")] ID3D10Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("ID3D10Resource *")] ID3D10Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, DXGI_FORMAT Format)
        {
            ((delegate* unmanaged<ID3D10Device1*, ID3D10Resource*, uint, ID3D10Resource*, uint, DXGI_FORMAT, void>)(lpVtbl[38]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VSGetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D10Buffer **")] ID3D10Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10Buffer**, void>)(lpVtbl[39]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PSGetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D10ShaderResourceView **")] ID3D10ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10ShaderResourceView**, void>)(lpVtbl[40]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PSGetShader([NativeTypeName("ID3D10PixelShader **")] ID3D10PixelShader** ppPixelShader)
        {
            ((delegate* unmanaged<ID3D10Device1*, ID3D10PixelShader**, void>)(lpVtbl[41]))((ID3D10Device1*)Unsafe.AsPointer(ref this), ppPixelShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PSGetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D10SamplerState **")] ID3D10SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10SamplerState**, void>)(lpVtbl[42]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VSGetShader([NativeTypeName("ID3D10VertexShader **")] ID3D10VertexShader** ppVertexShader)
        {
            ((delegate* unmanaged<ID3D10Device1*, ID3D10VertexShader**, void>)(lpVtbl[43]))((ID3D10Device1*)Unsafe.AsPointer(ref this), ppVertexShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PSGetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D10Buffer **")] ID3D10Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10Buffer**, void>)(lpVtbl[44]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void IAGetInputLayout([NativeTypeName("ID3D10InputLayout **")] ID3D10InputLayout** ppInputLayout)
        {
            ((delegate* unmanaged<ID3D10Device1*, ID3D10InputLayout**, void>)(lpVtbl[45]))((ID3D10Device1*)Unsafe.AsPointer(ref this), ppInputLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void IAGetVertexBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D10Buffer **")] ID3D10Buffer** ppVertexBuffers, [NativeTypeName("UINT *")] uint* pStrides, [NativeTypeName("UINT *")] uint* pOffsets)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10Buffer**, uint*, uint*, void>)(lpVtbl[46]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void IAGetIndexBuffer([NativeTypeName("ID3D10Buffer **")] ID3D10Buffer** pIndexBuffer, [NativeTypeName("DXGI_FORMAT *")] DXGI_FORMAT* Format, [NativeTypeName("UINT *")] uint* Offset)
        {
            ((delegate* unmanaged<ID3D10Device1*, ID3D10Buffer**, DXGI_FORMAT*, uint*, void>)(lpVtbl[47]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pIndexBuffer, Format, Offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GSGetConstantBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D10Buffer **")] ID3D10Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10Buffer**, void>)(lpVtbl[48]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GSGetShader([NativeTypeName("ID3D10GeometryShader **")] ID3D10GeometryShader** ppGeometryShader)
        {
            ((delegate* unmanaged<ID3D10Device1*, ID3D10GeometryShader**, void>)(lpVtbl[49]))((ID3D10Device1*)Unsafe.AsPointer(ref this), ppGeometryShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void IAGetPrimitiveTopology([NativeTypeName("D3D10_PRIMITIVE_TOPOLOGY *")] D3D_PRIMITIVE_TOPOLOGY* pTopology)
        {
            ((delegate* unmanaged<ID3D10Device1*, D3D_PRIMITIVE_TOPOLOGY*, void>)(lpVtbl[50]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pTopology);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VSGetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D10ShaderResourceView **")] ID3D10ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10ShaderResourceView**, void>)(lpVtbl[51]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void VSGetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D10SamplerState **")] ID3D10SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10SamplerState**, void>)(lpVtbl[52]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetPredication([NativeTypeName("ID3D10Predicate **")] ID3D10Predicate** ppPredicate, [NativeTypeName("BOOL *")] int* pPredicateValue)
        {
            ((delegate* unmanaged<ID3D10Device1*, ID3D10Predicate**, int*, void>)(lpVtbl[53]))((ID3D10Device1*)Unsafe.AsPointer(ref this), ppPredicate, pPredicateValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GSGetShaderResources([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D10ShaderResourceView **")] ID3D10ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10ShaderResourceView**, void>)(lpVtbl[54]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GSGetSamplers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumSamplers, [NativeTypeName("ID3D10SamplerState **")] ID3D10SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10SamplerState**, void>)(lpVtbl[55]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OMGetRenderTargets([NativeTypeName("UINT")] uint NumViews, [NativeTypeName("ID3D10RenderTargetView **")] ID3D10RenderTargetView** ppRenderTargetViews, [NativeTypeName("ID3D10DepthStencilView **")] ID3D10DepthStencilView** ppDepthStencilView)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, ID3D10RenderTargetView**, ID3D10DepthStencilView**, void>)(lpVtbl[56]))((ID3D10Device1*)Unsafe.AsPointer(ref this), NumViews, ppRenderTargetViews, ppDepthStencilView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OMGetBlendState([NativeTypeName("ID3D10BlendState **")] ID3D10BlendState** ppBlendState, [NativeTypeName("FLOAT [4]")] float* BlendFactor, [NativeTypeName("UINT *")] uint* pSampleMask)
        {
            ((delegate* unmanaged<ID3D10Device1*, ID3D10BlendState**, float*, uint*, void>)(lpVtbl[57]))((ID3D10Device1*)Unsafe.AsPointer(ref this), ppBlendState, BlendFactor, pSampleMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OMGetDepthStencilState([NativeTypeName("ID3D10DepthStencilState **")] ID3D10DepthStencilState** ppDepthStencilState, [NativeTypeName("UINT *")] uint* pStencilRef)
        {
            ((delegate* unmanaged<ID3D10Device1*, ID3D10DepthStencilState**, uint*, void>)(lpVtbl[58]))((ID3D10Device1*)Unsafe.AsPointer(ref this), ppDepthStencilState, pStencilRef);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SOGetTargets([NativeTypeName("UINT")] uint NumBuffers, [NativeTypeName("ID3D10Buffer **")] ID3D10Buffer** ppSOTargets, [NativeTypeName("UINT *")] uint* pOffsets)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, ID3D10Buffer**, uint*, void>)(lpVtbl[59]))((ID3D10Device1*)Unsafe.AsPointer(ref this), NumBuffers, ppSOTargets, pOffsets);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RSGetState([NativeTypeName("ID3D10RasterizerState **")] ID3D10RasterizerState** ppRasterizerState)
        {
            ((delegate* unmanaged<ID3D10Device1*, ID3D10RasterizerState**, void>)(lpVtbl[60]))((ID3D10Device1*)Unsafe.AsPointer(ref this), ppRasterizerState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RSGetViewports([NativeTypeName("UINT *")] uint* NumViewports, [NativeTypeName("D3D10_VIEWPORT *")] D3D10_VIEWPORT* pViewports)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint*, D3D10_VIEWPORT*, void>)(lpVtbl[61]))((ID3D10Device1*)Unsafe.AsPointer(ref this), NumViewports, pViewports);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RSGetScissorRects([NativeTypeName("UINT *")] uint* NumRects, [NativeTypeName("D3D10_RECT *")] RECT* pRects)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint*, RECT*, void>)(lpVtbl[62]))((ID3D10Device1*)Unsafe.AsPointer(ref this), NumRects, pRects);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceRemovedReason()
        {
            return ((delegate* unmanaged<ID3D10Device1*, int>)(lpVtbl[63]))((ID3D10Device1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetExceptionMode([NativeTypeName("UINT")] uint RaiseFlags)
        {
            return ((delegate* unmanaged<ID3D10Device1*, uint, int>)(lpVtbl[64]))((ID3D10Device1*)Unsafe.AsPointer(ref this), RaiseFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT")]
        public uint GetExceptionMode()
        {
            return ((delegate* unmanaged<ID3D10Device1*, uint>)(lpVtbl[65]))((ID3D10Device1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D10Device1*, Guid*, uint*, void*, int>)(lpVtbl[66]))((ID3D10Device1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D10Device1*, Guid*, uint, void*, int>)(lpVtbl[67]))((ID3D10Device1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D10Device1*, Guid*, IUnknown*, int>)(lpVtbl[68]))((ID3D10Device1*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ClearState()
        {
            ((delegate* unmanaged<ID3D10Device1*, void>)(lpVtbl[69]))((ID3D10Device1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Flush()
        {
            ((delegate* unmanaged<ID3D10Device1*, void>)(lpVtbl[70]))((ID3D10Device1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBuffer([NativeTypeName("const D3D10_BUFFER_DESC *")] D3D10_BUFFER_DESC* pDesc, [NativeTypeName("const D3D10_SUBRESOURCE_DATA *")] D3D10_SUBRESOURCE_DATA* pInitialData, [NativeTypeName("ID3D10Buffer **")] ID3D10Buffer** ppBuffer)
        {
            return ((delegate* unmanaged<ID3D10Device1*, D3D10_BUFFER_DESC*, D3D10_SUBRESOURCE_DATA*, ID3D10Buffer**, int>)(lpVtbl[71]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTexture1D([NativeTypeName("const D3D10_TEXTURE1D_DESC *")] D3D10_TEXTURE1D_DESC* pDesc, [NativeTypeName("const D3D10_SUBRESOURCE_DATA *")] D3D10_SUBRESOURCE_DATA* pInitialData, [NativeTypeName("ID3D10Texture1D **")] ID3D10Texture1D** ppTexture1D)
        {
            return ((delegate* unmanaged<ID3D10Device1*, D3D10_TEXTURE1D_DESC*, D3D10_SUBRESOURCE_DATA*, ID3D10Texture1D**, int>)(lpVtbl[72]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture1D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTexture2D([NativeTypeName("const D3D10_TEXTURE2D_DESC *")] D3D10_TEXTURE2D_DESC* pDesc, [NativeTypeName("const D3D10_SUBRESOURCE_DATA *")] D3D10_SUBRESOURCE_DATA* pInitialData, [NativeTypeName("ID3D10Texture2D **")] ID3D10Texture2D** ppTexture2D)
        {
            return ((delegate* unmanaged<ID3D10Device1*, D3D10_TEXTURE2D_DESC*, D3D10_SUBRESOURCE_DATA*, ID3D10Texture2D**, int>)(lpVtbl[73]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture2D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTexture3D([NativeTypeName("const D3D10_TEXTURE3D_DESC *")] D3D10_TEXTURE3D_DESC* pDesc, [NativeTypeName("const D3D10_SUBRESOURCE_DATA *")] D3D10_SUBRESOURCE_DATA* pInitialData, [NativeTypeName("ID3D10Texture3D **")] ID3D10Texture3D** ppTexture3D)
        {
            return ((delegate* unmanaged<ID3D10Device1*, D3D10_TEXTURE3D_DESC*, D3D10_SUBRESOURCE_DATA*, ID3D10Texture3D**, int>)(lpVtbl[74]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture3D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateShaderResourceView([NativeTypeName("ID3D10Resource *")] ID3D10Resource* pResource, [NativeTypeName("const D3D10_SHADER_RESOURCE_VIEW_DESC *")] D3D10_SHADER_RESOURCE_VIEW_DESC* pDesc, [NativeTypeName("ID3D10ShaderResourceView **")] ID3D10ShaderResourceView** ppSRView)
        {
            return ((delegate* unmanaged<ID3D10Device1*, ID3D10Resource*, D3D10_SHADER_RESOURCE_VIEW_DESC*, ID3D10ShaderResourceView**, int>)(lpVtbl[75]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pResource, pDesc, ppSRView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRenderTargetView([NativeTypeName("ID3D10Resource *")] ID3D10Resource* pResource, [NativeTypeName("const D3D10_RENDER_TARGET_VIEW_DESC *")] D3D10_RENDER_TARGET_VIEW_DESC* pDesc, [NativeTypeName("ID3D10RenderTargetView **")] ID3D10RenderTargetView** ppRTView)
        {
            return ((delegate* unmanaged<ID3D10Device1*, ID3D10Resource*, D3D10_RENDER_TARGET_VIEW_DESC*, ID3D10RenderTargetView**, int>)(lpVtbl[76]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pResource, pDesc, ppRTView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDepthStencilView([NativeTypeName("ID3D10Resource *")] ID3D10Resource* pResource, [NativeTypeName("const D3D10_DEPTH_STENCIL_VIEW_DESC *")] D3D10_DEPTH_STENCIL_VIEW_DESC* pDesc, [NativeTypeName("ID3D10DepthStencilView **")] ID3D10DepthStencilView** ppDepthStencilView)
        {
            return ((delegate* unmanaged<ID3D10Device1*, ID3D10Resource*, D3D10_DEPTH_STENCIL_VIEW_DESC*, ID3D10DepthStencilView**, int>)(lpVtbl[77]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pResource, pDesc, ppDepthStencilView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInputLayout([NativeTypeName("const D3D10_INPUT_ELEMENT_DESC *")] D3D10_INPUT_ELEMENT_DESC* pInputElementDescs, [NativeTypeName("UINT")] uint NumElements, [NativeTypeName("const void *")] void* pShaderBytecodeWithInputSignature, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D10InputLayout **")] ID3D10InputLayout** ppInputLayout)
        {
            return ((delegate* unmanaged<ID3D10Device1*, D3D10_INPUT_ELEMENT_DESC*, uint, void*, nuint, ID3D10InputLayout**, int>)(lpVtbl[78]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pInputElementDescs, NumElements, pShaderBytecodeWithInputSignature, BytecodeLength, ppInputLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVertexShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D10VertexShader **")] ID3D10VertexShader** ppVertexShader)
        {
            return ((delegate* unmanaged<ID3D10Device1*, void*, nuint, ID3D10VertexShader**, int>)(lpVtbl[79]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, ppVertexShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateGeometryShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D10GeometryShader **")] ID3D10GeometryShader** ppGeometryShader)
        {
            return ((delegate* unmanaged<ID3D10Device1*, void*, nuint, ID3D10GeometryShader**, int>)(lpVtbl[80]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, ppGeometryShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateGeometryShaderWithStreamOutput([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("const D3D10_SO_DECLARATION_ENTRY *")] D3D10_SO_DECLARATION_ENTRY* pSODeclaration, [NativeTypeName("UINT")] uint NumEntries, [NativeTypeName("UINT")] uint OutputStreamStride, [NativeTypeName("ID3D10GeometryShader **")] ID3D10GeometryShader** ppGeometryShader)
        {
            return ((delegate* unmanaged<ID3D10Device1*, void*, nuint, D3D10_SO_DECLARATION_ENTRY*, uint, uint, ID3D10GeometryShader**, int>)(lpVtbl[81]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pSODeclaration, NumEntries, OutputStreamStride, ppGeometryShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePixelShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D10PixelShader **")] ID3D10PixelShader** ppPixelShader)
        {
            return ((delegate* unmanaged<ID3D10Device1*, void*, nuint, ID3D10PixelShader**, int>)(lpVtbl[82]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, ppPixelShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBlendState([NativeTypeName("const D3D10_BLEND_DESC *")] D3D10_BLEND_DESC* pBlendStateDesc, [NativeTypeName("ID3D10BlendState **")] ID3D10BlendState** ppBlendState)
        {
            return ((delegate* unmanaged<ID3D10Device1*, D3D10_BLEND_DESC*, ID3D10BlendState**, int>)(lpVtbl[83]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pBlendStateDesc, ppBlendState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDepthStencilState([NativeTypeName("const D3D10_DEPTH_STENCIL_DESC *")] D3D10_DEPTH_STENCIL_DESC* pDepthStencilDesc, [NativeTypeName("ID3D10DepthStencilState **")] ID3D10DepthStencilState** ppDepthStencilState)
        {
            return ((delegate* unmanaged<ID3D10Device1*, D3D10_DEPTH_STENCIL_DESC*, ID3D10DepthStencilState**, int>)(lpVtbl[84]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pDepthStencilDesc, ppDepthStencilState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRasterizerState([NativeTypeName("const D3D10_RASTERIZER_DESC *")] D3D10_RASTERIZER_DESC* pRasterizerDesc, [NativeTypeName("ID3D10RasterizerState **")] ID3D10RasterizerState** ppRasterizerState)
        {
            return ((delegate* unmanaged<ID3D10Device1*, D3D10_RASTERIZER_DESC*, ID3D10RasterizerState**, int>)(lpVtbl[85]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pRasterizerDesc, ppRasterizerState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSamplerState([NativeTypeName("const D3D10_SAMPLER_DESC *")] D3D10_SAMPLER_DESC* pSamplerDesc, [NativeTypeName("ID3D10SamplerState **")] ID3D10SamplerState** ppSamplerState)
        {
            return ((delegate* unmanaged<ID3D10Device1*, D3D10_SAMPLER_DESC*, ID3D10SamplerState**, int>)(lpVtbl[86]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pSamplerDesc, ppSamplerState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateQuery([NativeTypeName("const D3D10_QUERY_DESC *")] D3D10_QUERY_DESC* pQueryDesc, [NativeTypeName("ID3D10Query **")] ID3D10Query** ppQuery)
        {
            return ((delegate* unmanaged<ID3D10Device1*, D3D10_QUERY_DESC*, ID3D10Query**, int>)(lpVtbl[87]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pQueryDesc, ppQuery);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePredicate([NativeTypeName("const D3D10_QUERY_DESC *")] D3D10_QUERY_DESC* pPredicateDesc, [NativeTypeName("ID3D10Predicate **")] ID3D10Predicate** ppPredicate)
        {
            return ((delegate* unmanaged<ID3D10Device1*, D3D10_QUERY_DESC*, ID3D10Predicate**, int>)(lpVtbl[88]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pPredicateDesc, ppPredicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCounter([NativeTypeName("const D3D10_COUNTER_DESC *")] D3D10_COUNTER_DESC* pCounterDesc, [NativeTypeName("ID3D10Counter **")] ID3D10Counter** ppCounter)
        {
            return ((delegate* unmanaged<ID3D10Device1*, D3D10_COUNTER_DESC*, ID3D10Counter**, int>)(lpVtbl[89]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pCounterDesc, ppCounter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CheckFormatSupport(DXGI_FORMAT Format, [NativeTypeName("UINT *")] uint* pFormatSupport)
        {
            return ((delegate* unmanaged<ID3D10Device1*, DXGI_FORMAT, uint*, int>)(lpVtbl[90]))((ID3D10Device1*)Unsafe.AsPointer(ref this), Format, pFormatSupport);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CheckMultisampleQualityLevels(DXGI_FORMAT Format, [NativeTypeName("UINT")] uint SampleCount, [NativeTypeName("UINT *")] uint* pNumQualityLevels)
        {
            return ((delegate* unmanaged<ID3D10Device1*, DXGI_FORMAT, uint, uint*, int>)(lpVtbl[91]))((ID3D10Device1*)Unsafe.AsPointer(ref this), Format, SampleCount, pNumQualityLevels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CheckCounterInfo([NativeTypeName("D3D10_COUNTER_INFO *")] D3D10_COUNTER_INFO* pCounterInfo)
        {
            ((delegate* unmanaged<ID3D10Device1*, D3D10_COUNTER_INFO*, void>)(lpVtbl[92]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pCounterInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CheckCounter([NativeTypeName("const D3D10_COUNTER_DESC *")] D3D10_COUNTER_DESC* pDesc, [NativeTypeName("D3D10_COUNTER_TYPE *")] D3D10_COUNTER_TYPE* pType, [NativeTypeName("UINT *")] uint* pActiveCounters, [NativeTypeName("LPSTR")] sbyte* szName, [NativeTypeName("UINT *")] uint* pNameLength, [NativeTypeName("LPSTR")] sbyte* szUnits, [NativeTypeName("UINT *")] uint* pUnitsLength, [NativeTypeName("LPSTR")] sbyte* szDescription, [NativeTypeName("UINT *")] uint* pDescriptionLength)
        {
            return ((delegate* unmanaged<ID3D10Device1*, D3D10_COUNTER_DESC*, D3D10_COUNTER_TYPE*, uint*, sbyte*, uint*, sbyte*, uint*, sbyte*, uint*, int>)(lpVtbl[93]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pDesc, pType, pActiveCounters, szName, pNameLength, szUnits, pUnitsLength, szDescription, pDescriptionLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT")]
        public uint GetCreationFlags()
        {
            return ((delegate* unmanaged<ID3D10Device1*, uint>)(lpVtbl[94]))((ID3D10Device1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OpenSharedResource([NativeTypeName("HANDLE")] IntPtr hResource, [NativeTypeName("const IID &")] Guid* ReturnedInterface, [NativeTypeName("void **")] void** ppResource)
        {
            return ((delegate* unmanaged<ID3D10Device1*, IntPtr, Guid*, void**, int>)(lpVtbl[95]))((ID3D10Device1*)Unsafe.AsPointer(ref this), hResource, ReturnedInterface, ppResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetTextFilterSize([NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint, uint, void>)(lpVtbl[96]))((ID3D10Device1*)Unsafe.AsPointer(ref this), Width, Height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetTextFilterSize([NativeTypeName("UINT *")] uint* pWidth, [NativeTypeName("UINT *")] uint* pHeight)
        {
            ((delegate* unmanaged<ID3D10Device1*, uint*, uint*, void>)(lpVtbl[97]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pWidth, pHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateShaderResourceView1([NativeTypeName("ID3D10Resource *")] ID3D10Resource* pResource, [NativeTypeName("const D3D10_SHADER_RESOURCE_VIEW_DESC1 *")] D3D10_SHADER_RESOURCE_VIEW_DESC1* pDesc, [NativeTypeName("ID3D10ShaderResourceView1 **")] ID3D10ShaderResourceView1** ppSRView)
        {
            return ((delegate* unmanaged<ID3D10Device1*, ID3D10Resource*, D3D10_SHADER_RESOURCE_VIEW_DESC1*, ID3D10ShaderResourceView1**, int>)(lpVtbl[98]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pResource, pDesc, ppSRView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBlendState1([NativeTypeName("const D3D10_BLEND_DESC1 *")] D3D10_BLEND_DESC1* pBlendStateDesc, [NativeTypeName("ID3D10BlendState1 **")] ID3D10BlendState1** ppBlendState)
        {
            return ((delegate* unmanaged<ID3D10Device1*, D3D10_BLEND_DESC1*, ID3D10BlendState1**, int>)(lpVtbl[99]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pBlendStateDesc, ppBlendState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D3D10_FEATURE_LEVEL1 GetFeatureLevel()
        {
            return ((delegate* unmanaged<ID3D10Device1*, D3D10_FEATURE_LEVEL1>)(lpVtbl[100]))((ID3D10Device1*)Unsafe.AsPointer(ref this));
        }
    }
}
